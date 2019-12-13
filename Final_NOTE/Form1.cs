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
namespace NOTE
{
    public partial class Note : Form
    {
        MyDrawBox myDrawBox;
        List<TextBox> tbxs = new List<TextBox>(); //文本框数组
        FontBrush fb = new FontBrush(); //格式刷
        bool fbstatus = false; // 格式刷状态
        int TbxNum = -1;  //选中文本框的号码
        public Note()
        {   
            InitializeComponent();
            myDrawBox = new MyDrawBox(pictureBox1);
            penSize.Items.Add(5);
            penSize.Items.Add(7);
            penSize.Items.Add(9);
            penSize.Items.Add(11);
            var list = GetTestList();
            //搜索匹配
            this.textBox1.AutoCompleteCustomSource.Clear();
            this.textBox1.AutoCompleteCustomSource.AddRange(list.ToArray());
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;

            //for(int i = 0; NoteList.SelectedIndex != -1; i++)
            //{
            //    if (this.textBox1.Text == NoteList.SelectedItem.ToString())
            //    {
            //        MessageBox.Show(this.textBox1.Text);
            //    }
            //}
            //textBox1.KeyUp += new KeyEventHandler(textBox1_KeyUp);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            myDrawBox.mourseDown(e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            myDrawBox.mourseUp(e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            myDrawBox.mourseMove(e);
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
            tb.Click += new System.EventHandler(TextBox_Click);
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

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NoteList.Items.Add("k1");
        }
        //测试数据
        private List<string> GetTestList()
        {
            var list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add("笔记" + (i + 1));
            }
            return list;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            var list = GetTestList();
            NoteList.DataSource = list;
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
                textBox1.Text = "";
            }
            textBox1.ForeColor = Color.Black;
        }
        //textbox失去焦点
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "请输入笔记名称";
                textBox1.ForeColor = Color.LightGray;
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

            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < this.NoteList.Items.Count; i++)
                {
                    if (this.textBox1.Text == this.NoteList.Items[i].ToString())
                    {
                        MessageBox.Show("按下了回车键,找到"+ this.NoteList.Items[i].ToString());
                    }
                }

                
            }
        }
    }
}
