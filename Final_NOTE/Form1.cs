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


namespace NOTE
{
    public partial class Note : Form
    {
        MyDrawBox myDrawBox;
        string[] list= new string[100];//存储搜索源
        int index = 0;//list的下标
        Boolean search = false;//textbox的功能
        public Note()
        {
            InitializeComponent();
            myDrawBox = new MyDrawBox(pictureBox1);
            penSize.Items.Add(5);
            penSize.Items.Add(7);
            penSize.Items.Add(9);
            penSize.Items.Add(11);
            this.textBox1.Visible = false;
            //初始生成10个笔记
            for (int i = 0; i < 10; i++)
            {
                this.NoteList.Items.Add("笔记" + (i+1));
                list[i] = "笔记" + (i+1);
                index = i;
            }
            
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
            foreach (System.Drawing.FontFamily i in objFont.Families)
            {
                FontBox.Items.Add(i.Name.ToString());
            }
            FontBox.SelectedIndex = 0;
        }

        private void cboFont_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            System.Drawing.Font objFonts = new Font(FontBox.Items[e.Index].ToString(), 14);
            e.ItemHeight = objFonts.Height;
        }
        //新增笔记本--名字
        Boolean noteName = false;
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteName = true;
            this.textBox1.Visible = true;
            
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
                
                if (search)//此时textbox进行搜索功能
                {
                 
                    for (int i = 0; i < this.NoteList.Items.Count; i++)
                    {
                        if (this.textBox1.Text == this.NoteList.Items[i].ToString())
                        {
                            //this.NoteList.SelectedIndex = i;

                            MessageBox.Show("按下了回车键,找到" + this.NoteList.Items[i].ToString());
                            Color vColor = Color.Gainsboro;

                            Graphics devcolor = NoteList.CreateGraphics();
                            vColor = Color.LightPink;
                            devcolor.FillRectangle(new SolidBrush(vColor), NoteList.GetItemRectangle(i));
                            devcolor.DrawString(NoteList.Items[i].ToString(), NoteList.Font, new SolidBrush(NoteList.ForeColor), NoteList.GetItemRectangle(i));
                        }
                    }
                }else if (noteName)
                {
                    this.NoteList.Items.Add(this.textBox1.Text);//listbox添加
                    index++;
                    list[index] = this.textBox1.Text;//list添加
                    this.textBox1.Text = "";
                    //搜索匹配
                    this.textBox1.AutoCompleteCustomSource.Clear();
                    this.textBox1.AutoCompleteCustomSource.AddRange(list);
                    this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
                    this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
                    
                }



            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            search = true;
            //显示搜索框
            this.textBox1.Visible = true;
            
        }
    }
}
