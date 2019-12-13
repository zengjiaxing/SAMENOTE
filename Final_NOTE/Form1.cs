using NOTE.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using NOTE.ClassModel;
using NOTE.ControlModel;

namespace NOTE
{
    public partial class Note : Form
    {
        MyDrawBox myDrawBox;
        List<string> list = new List<string>();
        //string[] list= new string[100];//存储搜索源
        //int index = 0;//list的下标
        Boolean search = false;//textbox的功能
        List<TextBox> tbxs = new List<TextBox>(); //文本框数组
        List<PictureBox> pbs = new List<PictureBox>();
        FontBrush fb = new FontBrush(); //格式刷
        bool fbstatus = false; // 格式刷状态
        int TbxNum = -1;  //选中文本框的号码
        SizeChange sizeChange = new SizeChange();
        public Note()
        {   
 
            InitializeComponent();
            myDrawBox = new MyDrawBox(pictureBox1);
            penSize.Items.Add(5);
            penSize.Items.Add(7);
            penSize.Items.Add(9);
            penSize.Items.Add(11);
            this.SearchBox.Visible = false;

            #region 初始化笔记本 by ZX
            //初始生成10个笔记
            for (int i = 0; i < 10; i++)
            {
                this.NoteList.Items.Add("笔记" + (i+1));
                //list[i] = "笔记" + (i+1);
                //index = i;
                list.Add("笔记" + (i + 1));
            }
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

        #endregion

        #region   背景板操作 by ZJX
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            myDrawBox.mourseDown(e,this.pictureBox1);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            myDrawBox.mourseUp(e,this.pictureBox1);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            myDrawBox.mourseMove(e,this.pictureBox1);
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            myDrawBox.mourseDown(e, this.pictureBox1);
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            myDrawBox.mourseUp(e, this.pictureBox1);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            myDrawBox.mourseMove(e, this.pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myDrawBox.colorSelect(colorDialog1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(this.penSize.SelectedItem.ToString());
            myDrawBox.penSizeSelect(size);
        }
        #endregion

        #region 文本框操作 by SWJ
        private void Form1_Load(object sender, EventArgs e)
        {
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
            tb.Location = new Point(133,98);
            tb.Size = new System.Drawing.Size(300, 100);
            tb.Name = "tb"+tbxs.Count.ToString();
            this.Controls.Add(tb);
            tbxs.Add(tb);
            tb.BringToFront();//生成新文本框
            tb.BorderStyle = BorderStyle.Fixed3D;
            tb.Click += new System.EventHandler(TextBox_Click);
            tb.MouseDown += new System.Windows.Forms.MouseEventHandler(textBox_MouseDown);
            tb.MouseLeave += new System.EventHandler(textBox_MouseLeave);
            tb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseMove);
            tb.Multiline = true;
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
            }
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
                TbxNum = -1;
            }
        }

        private void BoldBtn_Click(object sender, EventArgs e)
        {
            if(TbxNum != -1)
            {
                if (!tbxs[TbxNum].Font.Bold)
                {
                    tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font, tbxs[TbxNum].Font.Style | FontStyle.Bold);
                }
                else
                {
                    tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font, tbxs[TbxNum].Font.Style ^ FontStyle.Bold);
                }
            }
        }

        private void ItalicBtn_Click(object sender, EventArgs e)
        {
            if (!tbxs[TbxNum].Font.Italic)
            {
                tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font, tbxs[TbxNum].Font.Style | FontStyle.Italic);
            }
            else
            {
                tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font, tbxs[TbxNum].Font.Style ^ FontStyle.Italic);
            }
        }

        private void UnderlineBtn_Click(object sender, EventArgs e)
        {
            if (!tbxs[TbxNum].Font.Underline)
            {
                tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font, tbxs[TbxNum].Font.Style | FontStyle.Underline);
            }
            else
            {
                tbxs[TbxNum].Font = new Font(tbxs[TbxNum].Font, tbxs[TbxNum].Font.Style ^ FontStyle.Underline);
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
                    TbxNum = -1;
                }
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
            }
        }

        #endregion

        #region 笔记本操作 by ZX
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
            }
            for(int i = 0; i < tbxs.Count; i++)
            {
                tbxs[TbxNum].Name = "tb" + i;
            }
        }
        #endregion

        #region 插入图片操作 by SWJ
        private void 图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath;
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                DialogResult dr = dlg.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string fileName = dlg.FileName;
                    this.pictureBox1.Image = Image.FromFile(fileName);//将图片填充到pictureBox中

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
        #endregion

    }
}
