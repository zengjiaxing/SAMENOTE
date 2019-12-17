
using System;
using System.Collections.Generic;
using NOTE.ControlModel;
using System.Drawing;
using System.Windows.Forms;
using NOTE.ClassModel;
using NOTE.model;
using Models.ClassModels;
using System.IO;
using NoteDAL;
using NoteBLL.ReadAndWrite;
using NoteBLL.DBOperate;
//using MySql.Data.MySqlClient;
//using NoteDAL;
namespace NOTE
{
    public partial class NoteInterface : Form
    {
        User u = new User();//当前用户
        Note n = new Note();//当前编辑页面

        private DrawTools dt;
        private string sType;//绘图样式

        private bool bReSize = false;//是否改变画布大小
        private Size DefaultPicSize;//储存原始画布大小，用来新建文件时使用

        List<int> IdList = new List<int>();

        List<string> list = new List<string>();
        //存储笔记名
        public List<string> strlist = new List<string>();
        public static string UserName = "当前用户未登录";//当前登录用户
        public static Boolean LoginSuccess = false;//用户是否登录成功
        Boolean search = false;//textbox的搜索功能
        Boolean alter = false;//textbox的修改功能
        bool NonnClick = true; //检测是否切换过页面
        List<TextBox> tbxs = new List<TextBox>(); //文本框数组
        List<TextBoxInfo> tbxinfos = new List<TextBoxInfo>();
        FontBrush fb = new FontBrush(); //格式刷
        bool fbstatus = false; // 格式刷状态
        int TbxNum = -1;  //选中文本框的号码


        SizeChange sizeChange = new SizeChange();

        public NoteInterface()
        {

            InitializeComponent();

            penSize.Items.Add(5);
            penSize.Items.Add(7);
            penSize.Items.Add(10);
            penSize.Items.Add(13);

            this.SearchBox.Visible = false;


        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dt.DrawColor = colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
            Bitmap bmp = new Bitmap(Drawbox.Width, Drawbox.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Drawbox.BackColor), new Rectangle(0, 0, Drawbox.Width, Drawbox.Height));
            g.Dispose();
            dt = new DrawTools(this.Drawbox.CreateGraphics(), colorDialog1.Color, bmp);//实例化工具类
            DefaultPicSize = Drawbox.Size;
            foreach (System.Drawing.FontFamily i in objFont.Families)//加载所有字体
            {
                FontBox.Items.Add(i.Name.ToString());
            }
            FontBox.SelectedIndex = 0;

            n.Texts = tbxinfos;
            n.Paint = dt.FinishingImg;
        }

        // 生成新文本框
        private void 文本框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            TextBoxInfo tbf =  new TextBoxInfo();
            tb.Location = new Point(133, 98);
            tb.Size = new System.Drawing.Size(300, 100);
            tb.Name = "tb" + tbxs.Count.ToString();
            this.Controls.Add(tb);
            tbxs.Add(tb);
            tb.BringToFront();//生成新文本框
            tb.BorderStyle = BorderStyle.Fixed3D;
            tb.Click += new System.EventHandler(TextBox_Click);
            tb.MouseDown += new System.Windows.Forms.MouseEventHandler(textBox_MouseDown);
            tb.MouseLeave += new System.EventHandler(textBox_MouseLeave);
            tb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseMove);
            tb.TextChanged += new System.EventHandler(textBox_TextChanged);
            tb.Multiline = true;
            ChangeTextInfo(tbf, tb);
            tbxinfos.Add(tbf);
        }
        void ChangeTextInfo(TextBoxInfo tbxif,TextBox tbx)
        {
            tbxif.Name = tbx.Name;
            tbxif.Font = tbx.Font.ToString();
            tbxif.Size = tbx.Size;
            tbxif.Location = tbx.Location;
            tbxif.Text = tbx.Text;
            tbxif.FontSize = tbx.Font.Size;
            tbxif.FontColor = tbx.ForeColor;
            tbxif.Bold = tbx.Font.Bold;
            tbxif.Italic = tbx.Font.Italic;
            tbxif.Underline = tbx.Font.Underline;
        }
        private void TextBox_Click(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            TbxNum = Convert.ToInt32(t.Name.Substring(2, 1));
            if (fbstatus)//如果格式刷被选中
            {
                tbxs[TbxNum].Font = fb.f;
                tbxs[TbxNum].ForeColor = fb.c;
                fbstatus = false;
                ChangeTextInfo(tbxinfos[TbxNum], tbxs[TbxNum]);
            }
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            TbxNum = Convert.ToInt32(t.Name.Substring(2, 1));
            ChangeTextInfo(tbxinfos[TbxNum], tbxs[TbxNum]);
        }
        private void textBox_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox t = (TextBox)sender;
            TbxNum = Convert.ToInt32(t.Name.Substring(2, 1));
            sizeChange.MyMouseDown(sender, e);
            ChangeTextInfo(tbxinfos[TbxNum], tbxs[TbxNum]);
        }

        private void textBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            TbxNum = Convert.ToInt32(t.Name.Substring(2, 1));
            sizeChange.MyMouseLeave(sender, e, this.Cursor);
            ChangeTextInfo(tbxinfos[TbxNum], tbxs[TbxNum]);
        }

        private void textBox_MouseMove(object sender, MouseEventArgs e)
        {
            TextBox t = (TextBox)sender;
            TbxNum = Convert.ToInt32(t.Name.Substring(2, 1));
            sizeChange.MyMouseMove(sender, e, this.Cursor);
            ChangeTextInfo(tbxinfos[TbxNum], tbxs[TbxNum]);
        }

        private void FontBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (TbxNum != -1)
            {
                tbxs[TbxNum].Font = new Font(FontBox.Items[cb.SelectedIndex].ToString(),
                                              tbxs[TbxNum].Font.Size, tbxs[TbxNum].Font.Style);
                tbxinfos[TbxNum].Font = FontBox.Items[cb.SelectedIndex].ToString();
                TbxNum = -1;
            }
        }

        private void BoldBtn_Click(object sender, EventArgs e)
        {
            if (TbxNum != -1)
            {
                if (!tbxs[TbxNum].Font.Bold)
                {
                    tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font, tbxs[TbxNum].Font.Style | FontStyle.Bold);
                    tbxinfos[TbxNum].Bold = true;
                }
                else
                {
                    tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font, tbxs[TbxNum].Font.Style ^ FontStyle.Bold);
                    tbxinfos[TbxNum].Bold = false;
                }
            }
        }

        private void ItalicBtn_Click(object sender, EventArgs e)
        {
            if (!tbxs[TbxNum].Font.Italic)
            {
                tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font, tbxs[TbxNum].Font.Style | FontStyle.Italic);
                tbxinfos[TbxNum].Italic = true;
            }
            else
            {
                tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font, tbxs[TbxNum].Font.Style ^ FontStyle.Italic);
                tbxinfos[TbxNum].Italic = false;
            }
        }

        private void UnderlineBtn_Click(object sender, EventArgs e)
        {
            if (!tbxs[TbxNum].Font.Underline)
            {
                tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font, tbxs[TbxNum].Font.Style | FontStyle.Underline);
                tbxinfos[TbxNum].Underline = true;
            }
            else
            {
                tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font, tbxs[TbxNum].Font.Style ^ FontStyle.Underline);
                tbxinfos[TbxNum].Underline = false;
            }
        }

        private void FontColor_Click(object sender, EventArgs e)
        {
            ColorDialog cldlg = colorDialog1;
            if (cldlg.ShowDialog() == DialogResult.OK)
            {
                if (TbxNum != -1)
                {
                    tbxs[TbxNum].ForeColor = cldlg.Color;
                    tbxinfos[TbxNum].FontColor = cldlg.Color;
                    TbxNum = -1;
                }
            }
        }
        private void FontSizePlus_Click(object sender, EventArgs e)
        {
            if (TbxNum != -1)
            {
                tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font.FontFamily, tbxs[TbxNum].Font.Size + 1, tbxs[TbxNum].Font.Style);
                tbxinfos[TbxNum].FontSize = tbxs[TbxNum].Font.Size;
                TbxNum = -1;
            }
        }

        private void FontSizeMinus_Click(object sender, EventArgs e)
        {
            if (TbxNum != -1)
            {
                tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font.FontFamily, tbxs[TbxNum].Font.Size - 1, tbxs[TbxNum].Font.Style);
                tbxinfos[TbxNum].FontSize = tbxs[TbxNum].Font.Size;
                TbxNum = -1;
            }
        }

        private void Format_Painter_Click(object sender, EventArgs e)
        {
            if (TbxNum != -1)
            {
                this.fb.f = tbxs[TbxNum].Font;
                this.fb.c = tbxs[TbxNum].ForeColor;
                TbxNum = -1;
                fbstatus = true;
            }
        }


        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (TbxNum != -1)
            {
                tbxs[TbxNum].Font = DefaultFont;
                tbxs[TbxNum].ForeColor = DefaultForeColor;
                ChangeTextInfo(tbxinfos[TbxNum], tbxs[TbxNum]);
            }
        }
        //新增笔记本--名字
        Boolean noteName = false;
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //已经打开搜索框
            if (SearchBox.Visible)
            {
                this.SearchBox.Text = "";
                this.SearchBox.Visible = false;
            }
            if (LoginSuccess)
            {
                noteName = true;
                this.SearchBox.Visible = true;
            }
            else
            {
                MessageBox.Show("用户需要登录后新增笔记");
                LogInSteps();
            }
        }
 
            //从数据库读取笔记
            private void ShowNoteBtn_Click(object sender, EventArgs e)
        {
            if (LoginSuccess)//登录成功
            {
                //如果当前列表已有item,清空数据源和列表信息，清空存储列表
                if (NoteList.Items.Count > 0)
                {
                    NoteList.DataSource = null;
                    NoteList.Items.Clear();
                    strlist.Clear();
                }
                //this.UserLabel.Text = UserName;//显示登录用户名
                DataSource data = new DataSource();
                List<ClassModel.Note> list = new List<ClassModel.Note>();
                list = data.ReadDatabaseNOTE();
                foreach (ClassModel.Note n in list)
                {
                    strlist.Add(n.Name);
                }
                SearchInfo();
            }
            else
            {
                MessageBox.Show("当前用户未登录，请先登录");
            }
        }
        private void SearchInfo()
        {
            //笔记名显示
            NoteList.DataSource = strlist;
            string[] str = strlist.ToArray();
            //搜索匹配
            this.SearchBox.AutoCompleteCustomSource.Clear();
            this.SearchBox.AutoCompleteCustomSource.AddRange(str);
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
        }

        private void NoteList_MouseDown(object sender, MouseEventArgs e)
        {
            int index = NoteList.IndexFromPoint(e.X, e.Y);
            NoteList.SelectedIndex = index;
            //鼠标左键显示笔记，右键修改笔记信息
            if (e.Button == MouseButtons.Right)
            {
                //this.SearchBox.Visible = true;
                //this.alter = true;
            }
            else
            {
                if (NoteList.SelectedIndex != -1)
                {
                    MessageBox.Show(NoteList.SelectedItem.ToString());
                }
            }
        }

        #region 提示文字
        Boolean textboxHasText = false;
        //textbox获得焦点
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
            {
                SearchBox.Text = "";
            }
            SearchBox.ForeColor = Color.Black;
        }
        //textbox失去焦点
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                SearchBox.Text = "请输入笔记名称";
                SearchBox.ForeColor = Color.LightGray;
                textboxHasText = false;
            }
            else
            {
                textboxHasText = true;
            }
        }

        #endregion
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)//按下回车
            {

                if (search)//此时textbox进行搜索功能
                {

                    for (int i = 0; i < this.NoteList.Items.Count; i++)
                    {
                        if (this.SearchBox.Text == this.NoteList.Items[i].ToString())
                        {
                            //将找到的item背景设置为粉色
                            MessageBox.Show("按下了回车键,找到" + this.NoteList.Items[i].ToString());
                            Color vColor = Color.Gainsboro;

                            Graphics devcolor = NoteList.CreateGraphics();
                            vColor = Color.LightPink;
                            devcolor.FillRectangle(new SolidBrush(vColor), NoteList.GetItemRectangle(i));
                            devcolor.DrawString(NoteList.Items[i].ToString(), NoteList.Font, new SolidBrush(NoteList.ForeColor), NoteList.GetItemRectangle(i));
                            search = false;
                        }
                    }
                    ////说明循环后search还是真
                    ////循环后找不到笔记名
                    //MessageBox.Show("按下了回车键,找不到" + this.SearchBox.Text);

                }
                else if (noteName)
                {
                    if (!NonnClick)
                    {
                        SavePage();
                    }
                    NoteFunction nf = new NoteFunction();
                    Note n1 = new Note();
                    n1 = nf.GetInsertedNote();
                    SearchInfo();
                    string path = "D:/Note/"+ u.Name+"/" + (n1.ID+1).ToString();

                    n1 = nf.AddNote(u.Name,SearchBox.Text,path,DateTime.Now,DateTime.Now);
                    this.u.NoteList.Add(n1);
                    NoteList.DataSource = null;
                    NoteList.Items.Clear();
                    this.AddNotesToList();
                    this.list.Add(n1.Name);
                    this.IdList.Add(n1.ID);
                    this.n = n1;
                    CleanPage();
                    this.NoteList.SelectedIndex = this.NoteList.Items.Count - 1;
                    noteName = false;
                    this.SearchBox.Visible = false;
                }
                else if (alter)
                {
                    DataSource data = new DataSource();
                    Random r = new Random();

                    for (int i = 0; i < this.NoteList.Items.Count; i++)
                    {
                        if (NoteList.SelectedItems.Contains(NoteList.Items[i]))
                        {
                            //data.AlterDatabaseNOTE(this.UserLabel.Text, this.NoteList.Items[i].ToString(), this.SearchBox.Text, DateTime.Now);
                            this.SearchBox.Text = "";
                            this.SearchBox.Visible = false;
                            MessageBox.Show("已更新笔记名称，请刷新笔记");
                        }
                    }
                }
                //else
                //{
                //    MessageBox.Show("按下了回车键,找不到" + this.SearchBox.Text);

                //}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search = true;
            //显示搜索框
            this.SearchBox.Visible = true;

        }





        private void delete_Click(object sender, EventArgs e)
        {
            if (TbxNum != -1)
            {
                this.Controls.Remove(tbxs[TbxNum]);
                tbxs.Remove(tbxs[TbxNum]);
                for (int i = 0; i < tbxs.Count; i++)
                {
                    tbxs[TbxNum].Name = "tb" + i;
                }
            }

        }


        private void Drawbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dt != null)
                {
                    dt.startDraw = true;//相当于所选工具被激活，可以开始绘图
                    dt.startPointF = new PointF(e.X, e.Y);
                }
            }
        }

        private void Drawbox_MouseMove(object sender, MouseEventArgs e)
        {
            // mousePostion.Text = e.Location.ToString();
            if (dt.startDraw)
            {
                switch (sType)
                {
                    case "Dot": dt.DrawDot(e); break;
                    case "Eraser": dt.Eraser(e); break;
                    default: dt.Draw(e, sType); break;
                }
            }
        }

        private void Drawbox_MouseUp(object sender, MouseEventArgs e)
        {
            if (dt != null)
            {
                dt.EndDraw();
            }
        }



        private void Dash_Click(object sender, EventArgs e)
        {
            dt.Dash(((Button)sender).Name);
        }
        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sType = ((System.Windows.Forms.ToolStripMenuItem)sender).Name;
        }

        private void penSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.pen.Width = Convert.ToInt32(penSize.Text);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            bReSize = true;//当鼠标按下时，说明要开始调节大小
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bReSize)
            {
                reSize.Location = new Point(reSize.Location.X + e.X, reSize.Location.Y + e.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            bReSize = false;//大小改变结束
            //调节大小可能造成画板大小超过屏幕区域，所以事先要设置autoScroll为true.
            //但是滚动条的出现反而增加了我们的难度，因为滚动条上下移动并不会自动帮我们调整图片的坐标。
            //这是因为GDI绘图的坐标系不只一个，好像有三个，没有仔细了解，一个是屏幕坐标，一个是客户区坐标，还个是文档坐标。
            //滚动条的上下移动改变的是文档的坐标，但是客户区坐标不变，而location属性就属于客户区坐标，所以我们直接计算会出现错误
            //这时我们就需要知道文档坐标与客户区坐标的偏移量，这就是AutoScrollPostion可以提供的

            Drawbox.Size = new Size(reSize.Location.X - (this.panel1.AutoScrollPosition.X), reSize.Location.Y - (this.panel1.AutoScrollPosition.Y));
            dt.targetGraphics = Drawbox.CreateGraphics();//因为画板的大小被改变所以必须重新赋值

            //另外画布也被改变所以也要重新赋值
            Bitmap bmp = new Bitmap(Drawbox.Width, Drawbox.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, Drawbox.Width, Drawbox.Height);
            g.DrawImage(dt.OrginalImg, 0, 0);
            g.Dispose();
            g = Drawbox.CreateGraphics();
            g.DrawImage(bmp, 0, 0);
            g.Dispose();
            dt.OrginalImg = bmp;

            bmp.Dispose();
        }

        private void RevokeBtn_Click(object sender, EventArgs e)
        {
            dt.revocation();
        }

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            dt.advance();
        }

        private void Rubber_Click(object sender, EventArgs e)
        {
            sType = ((Button)sender).Name;
        }

        private void Clearpicture_Click(object sender, EventArgs e)
        {
            dt.clear();
        }

        private void NoteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!NonnClick)
            {
                SavePage();
            }
            NoteReader nr = new NoteReader();
            if (NoteList.SelectedIndex != -1 && !NonnClick)
            {
                int i;
                CleanPage();
                for (i = 0; i < u.NoteList.Count; i++)
                {
                    if (u.NoteList[i].ID == IdList[NoteList.SelectedIndex])
                    {
                        break;
                    }
                }
                this.n = nr.ReadFromFile(u.NoteList[i].Path);
                GetPage();
            }
            NonnClick = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SavePage();
        }


        private void CleanPage()//清除页面
        {
             for(int i = 0; i < tbxs.Count; i++)
            {
                this.Controls.Remove(tbxs[i]);
            }
            tbxs = new List<TextBox>();
            TbxNum = -1;
            tbxinfos = new List<TextBoxInfo>();
            dt.clear();
        }

        private void GetPage()
        {
            NoteReader nr = new NoteReader();
            this.n = nr.ReadFromFile(this.n.Path);
            for(int i = 0; i < n.Texts.Count; i++)
            {
                TextBox tb = new TextBox();
                TextBoxInfo tbf = new TextBoxInfo();
                tb.Location = n.Texts[i].Location;
                tb.Size = n.Texts[i].Size;
                tb.Name = n.Texts[i].Name;
                tb.Text = n.Texts[i].Text;
                tb.ForeColor = n.Texts[i].FontColor;
                tb.Font = new Font(n.Texts[i].Font, n.Texts[i].FontSize);
                if (n.Texts[i].Bold)
                {
                    tb.Font = new Font(tb.Font, tb.Font.Style ^ FontStyle.Bold);
                }
                if (n.Texts[i].Italic)
                {
                    tb.Font = new Font(tb.Font, tb.Font.Style ^ FontStyle.Italic);
                }
                if (n.Texts[i].Underline)
                {
                    tb.Font = new Font(tb.Font, tb.Font.Style ^ FontStyle.Underline);
                }
                this.Controls.Add(tb);
                tbxs.Add(tb);
                tb.BringToFront();//生成新文本框
                tb.Multiline = true;
                tb.BorderStyle = BorderStyle.Fixed3D;
                tb.Click += new System.EventHandler(TextBox_Click);
                tb.MouseDown += new System.Windows.Forms.MouseEventHandler(textBox_MouseDown);
                tb.MouseLeave += new System.EventHandler(textBox_MouseLeave);
                tb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseMove);
                tb.TextChanged += new System.EventHandler(textBox_TextChanged);
                ChangeTextInfo(tbf, tb);
                tbxinfos.Add(tbf);
            }
            
            dt.clear();
            this.Drawbox.Height = this.n.Paint.Height;
            this.Drawbox.Width = this.n.Paint.Width;
            this.reSize.Location = this.Drawbox.Location + this.Drawbox.Size;

            //dt.targetGraphics = this.Drawbox.CreateGraphics();
            Bitmap bmp = new Bitmap(Drawbox.Width, Drawbox.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Drawbox.BackColor), new Rectangle(0, 0, Drawbox.Width, Drawbox.Height));
            g.Dispose();
            dt = new DrawTools(this.Drawbox.CreateGraphics(), colorDialog1.Color, bmp);//实例化工具类
            dt.draw = (Image)this.n.Paint.Clone();
            dt.Draw(dt.draw);
        }
        private void SavePage()
        {
            string path1 = "D:/Note";
            Directory.CreateDirectory(path1);
            path1 = path1 + "/" + u.Name;
            Directory.CreateDirectory(path1);
            this.n.LastModify = DateTime.Now;
            this.n.Texts = tbxinfos;
            this.n.Paint = dt.FinishingImg;
            this.n.Path = "D:/Note/" + u.Name + "/" + n.ID.ToString();
            Directory.CreateDirectory(n.Path);
            NoteWriter nw = new NoteWriter();
            nw.WriteToFile(n);
        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }


        private void 登入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInSteps();
        }

        private void LogInSteps()
        {
            LogIn l = new LogIn();
            l.passname += new PassName(Change_text);
            l.ShowDialog();
            LoginSuccess = true;
            NoteFunction nf = new NoteFunction();
            u.NoteList = nf.GetMyNote(u.Name);
            AddNotesToList();
        }

        private void AddNotesToList()
        {
            this.list = new List<string>();
            this.IdList = new List<int>();
            for(int i = 0; i < u.NoteList.Count; i++)
            {
                NoteList.Items.Add(u.NoteList[i].Name);
                this.list.Add(u.NoteList[i].Name);
                this.IdList.Add(u.NoteList[i].ID);
            }
        }
        public void Change_text(string str)
        {
            namelabel.Text = str;
            this.u.Name = str;
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.u.Name == "")
            {
                MessageBox.Show("请先登入");
            }
            else
            {
                Modify m = new Modify(this.u.Name);
                m.ShowDialog();
            }
        }

        private void 忘记密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forget f = new Forget();
            f.ShowDialog();
        }

        private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanPage();
            CleanVars();
            NoteList.DataSource = null;
            NoteList.Items.Clear();
        }

        private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanVars();
            CleanPage();
            NoteList.DataSource = null;
            NoteList.Items.Clear();
            LogIn l = new LogIn();
            l.passname += new PassName(Change_text);
            l.ShowDialog();
        }

        private void CleanVars()
        {
            this.namelabel.Text = "";
            this.u = new User();
            this.n = new Note();
            this.IdList = new List<int>();
            this.list = new List<string>();
            LoginSuccess = false;
            this.search = false;
            this.alter = false;
            this.tbxs = new List<TextBox>();
            this.tbxinfos = new List<TextBoxInfo>();
            this.fb = new FontBrush();
            this.fbstatus = false;
            TbxNum = -1;
            NonnClick = true;
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePage();
            MessageBox.Show("保存成功");
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
