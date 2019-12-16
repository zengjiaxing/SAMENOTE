
using System;
using System.Collections.Generic;
using NOTE.ControlModel;
using System.Drawing;
using System.Windows.Forms;
using NOTE.ClassModel;
using NOTE.model;
using NOTE.Tools;
using Models.ClassModels;
//using MySql.Data.MySqlClient;
//using NoteDAL;
namespace NOTE
{
    public partial class NoteInterface : Form
    {
        //List<Note> nl = new List<Note>();
        //User u = new User();
        Note n = new Note();

        private DrawTools dt;
        private string sType;//绘图样式
        private string sFileName;//打开的文件名
        private bool bReSize = false;//是否改变画布大小
        private Size DefaultPicSize;//储存原始画布大小，用来新建文件时使用

        List<string> list = new List<string>();
        //string[] list= new string[100];//存储搜索源
        //int index = 0;//list的下标
        Boolean search = false;//textbox的功能
        List<TextBox> tbxs = new List<TextBox>(); //文本框数组
        List<TextBoxInfo> tbxinfos = new List<TextBoxInfo>();
        List<PictureBox> pbs = new List<PictureBox>();
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

            //u.NoteList1 = nl;
            n.Paint = this.dt;
            n.Texts = tbxinfos;
            

            this.SearchBox.Visible = false;
            //初始生成10个笔记
            //for (int i = 0; i < 3; i++)
            //{
            //    this.NoteList.Items.Add("笔记" + (i + 1));
            //    //list[i] = "笔记" + (i+1);
            //    //index = i;
            //    list.Add("笔记" + (i + 1));
            //}
            string[] str = list.ToArray();
            //搜索匹配
            this.SearchBox.AutoCompleteCustomSource.Clear();
            this.SearchBox.AutoCompleteCustomSource.AddRange(str);
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            //for(int i = 0; NoteList.SelectedIndex != -1; i++)
            //{
            //    if (this.textBox1.Text == NoteList.SelectedItem.ToString())
            //    {
            //        MessageBox.Show(this.textBox1.Text);
            //    }
            //}
            //textBox1.KeyUp += new KeyEventHandler(textBox1_KeyUp);
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
            ChangeTextInfo(tbxinfos[TbxNum], tbxs[TbxNum]);
        }
        private void textBox_MouseDown(object sender, MouseEventArgs e)
        {
            sizeChange.MyMouseDown(sender, e);
        }

        private void textBox_MouseLeave(object sender, EventArgs e)
        {
            sizeChange.MyMouseLeave(sender, e, this.Cursor);
        }

        private void textBox_MouseMove(object sender, MouseEventArgs e)
        {
            sizeChange.MyMouseMove(sender, e, this.Cursor);
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
                TbxNum = -1;
                tbxinfos[TbxNum].FontSize = tbxs[TbxNum].Font.Size;
            }
        }

        private void FontSizeMinus_Click(object sender, EventArgs e)
        {
            if (TbxNum != -1)
            {
                tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font.FontFamily, tbxs[TbxNum].Font.Size - 1, tbxs[TbxNum].Font.Style);
                TbxNum = -1;
                tbxinfos[TbxNum].FontSize = tbxs[TbxNum].Font.Size;
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
            noteName = true;
            this.SearchBox.Visible = true;

        }
        //测试数据
        //private List<string> GetTestList()
        //{
        //    var list = new List<string>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        list.Add("笔记" + (i + 1));
        //    }
        //    return list;
        //}
        private void button1_Click_1(object sender, EventArgs e)
        {
            /*还不知道什么用途*/
            //var list = GetTestList();
            //for(int i = 0;i<10 ; i++)
            //{
            //    this.NoteList.Items.Add("笔记" + i);
            //    list[i] = "笔记"+i;
            //}
            //this.textBox1.Visible = true;
            //this.NoteList.Items.Add(this.textBox1.Text);
            //index++;
            //list[index] = this.textBox1.Text;
        }

        private void NoteList_MouseClick(object sender, MouseEventArgs e)
        {
            int index = NoteList.IndexFromPoint(e.X, e.Y);
            NoteList.SelectedIndex = index;
            if (NoteList.SelectedIndex != -1)
            {
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
                    this.NoteList.Items.Add(this.SearchBox.Text);//listbox添加item
                    list.Add(this.SearchBox.Text);//list添加


                    //n.Name = this.SearchBox.Text;
                    //this.u.NoteList1.Add(n);


                    this.SearchBox.Text = "";
                    string[] str = list.ToArray();
                    //搜索匹配
                    this.SearchBox.AutoCompleteCustomSource.Clear();
                    this.SearchBox.AutoCompleteCustomSource.AddRange(str);
                    this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
                    this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
                    noteName = false;
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

        private void 图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath;
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                DialogResult dr = dlg.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string fileName = dlg.FileName;
                    //this.pictureBox1.Image = Image.FromFile(fileName);//将图片填充到pictureBox中

                    filepath = dlg.FileName;//获取全部文件路径（包括拓展名）
                    PictureBox p = new PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(p)).BeginInit();
                    p.Image = Image.FromFile(filepath);
                    p.Size = new Size(100, 100);
                    p.Location = new Point(300, 330);
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.BringToFront();
                    pbs.Add(p);
                    this.Controls.Add(p);
                }

            }
        }

        //private void 连接数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    DataSource data = new DataSource();
        //    List<User> userlist = new List<User>();
        //    userlist = data.init();
        //    foreach(User x in userlist)
        //    {
        //        MessageBox.Show("用户姓名："+x.Name1+"，用户密码："+ x.Password1);
        //    }
        //}

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
            //int i = 0;
            //for (i = 0; i < this.u.NoteList1.Count; i++)
            //{
            //    if (this.u.NoteList1[i].Name == NoteList.Items[NoteList.SelectedIndex].ToString())
            //    {
            //        break;
            //    }
            //}
            //this.n = u.NoteList1[i-1];
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.n.Paint = this.dt;
            Serializer st = new Serializer();
            st.NoteSerialize(this.n);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Serializer st = new Serializer();
            Note n = st.DeNoteSerialize();
            TextBox t = new TextBox();
            //MessageBox.Show(n.Texts[0].Text+"\n"+ n.Texts[0].Location);
            //MessageBox.Show(n.Texts[0].Name);
            //t = loadTextBox(n.Texts[0]);
            this.dt = n.Paint;
            Controls.Add(t);
            tbxs.Add(t);
            //MessageBox.Show(t.Text + "\n" + t.Location + "\n" + t.Name +"\n"+t.Size);
        }

        private TextBox loadTextBox(TextBoxInfo tf)
        {
            TextBox t = new TextBox();
            t.Location = tf.Location;
            t.Size = tf.Size;
            if (tf.Bold)
            {
                t.Font = new Font(tf.Font, t.Font.Size, t.Font.Style ^ FontStyle.Bold);
            }
            if (tf.Italic)
            {
                t.Font = new Font(tf.Font, t.Font.Size, t.Font.Style ^ FontStyle.Italic);
            }
            if (tf.Underline)
            {
                t.Font = new Font(tf.Font, t.Font.Size, t.Font.Style ^ FontStyle.Underline);
            }
            t.ForeColor = tf.FontColor;
            t.Name = tf.Name;
            t.Text = tf.Text;
            t.BringToFront();
            t.Multiline = true;
            t.BorderStyle = BorderStyle.Fixed3D;
            t.BorderStyle = BorderStyle.Fixed3D;
            t.Click += new System.EventHandler(TextBox_Click);
            t.MouseDown += new System.Windows.Forms.MouseEventHandler(textBox_MouseDown);
            t.MouseLeave += new System.EventHandler(textBox_MouseLeave);
            t.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseMove);
            t.TextChanged += new System.EventHandler(textBox_TextChanged);
            return t;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.dt.Save();
        }
    } 
}
