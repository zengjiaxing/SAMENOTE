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
using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;

namespace NOTE
{
    public partial class Form1 : Form
    {
        SizeChange sizeChange = new SizeChange();

        private DrawTools dt;
        private string sType;//绘图样式
        private string sFileName;//打开的文件名
        private bool bReSize = false;//是否改变画布大小
        private Size DefaultPicSize;//储存原始画布大小，用来新建文件时使用
        public Form1()
        {
            InitializeComponent();
        
            penSize.Items.Add(5);
            penSize.Items.Add(7);
            penSize.Items.Add(10);
            penSize.Items.Add(13);
        }
        //文本框拖动和大小改变
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            sizeChange.MyMouseDown(sender, e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            sizeChange.MyMouseLeave(sender, e, this.Cursor);
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            sizeChange.MyMouseMove(sender, e, this.Cursor);
        }

        //画图
        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(pictureBox2.BackColor), new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height));
            g.Dispose();
            dt = new DrawTools(this.pictureBox2.CreateGraphics(), colorDialog1.Color, bmp);//实例化工具类
            DefaultPicSize = pictureBox2.Size;
        }



        private void button2_Click(object sender, EventArgs e)
        {
           sType = ((Button)sender).Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dt.Dash(((Button)sender).Text);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

     

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
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

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
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

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (dt != null)
            {
                dt.EndDraw();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dt.DrawColor = colorDialog1.Color;
            }
        }

        private void penSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.pen.Width = Convert.ToInt32(penSize.Text);
        }

        private void reSize_MouseDown(object sender, MouseEventArgs e)
        {
            bReSize = true;//当鼠标按下时，说明要开始调节大小
        }

        private void reSize_MouseMove(object sender, MouseEventArgs e)
        {
            if (bReSize)
            {
                reSize.Location = new Point(reSize.Location.X + e.X, reSize.Location.Y + e.Y);

            }
        }

        private void reSize_MouseUp(object sender, MouseEventArgs e)
        {
            bReSize = false;//大小改变结束
            //调节大小可能造成画板大小超过屏幕区域，所以事先要设置autoScroll为true.
            //但是滚动条的出现反而增加了我们的难度，因为滚动条上下移动并不会自动帮我们调整图片的坐标。
            //这是因为GDI绘图的坐标系不只一个，好像有三个，没有仔细了解，一个是屏幕坐标，一个是客户区坐标，还个是文档坐标。
            //滚动条的上下移动改变的是文档的坐标，但是客户区坐标不变，而location属性就属于客户区坐标，所以我们直接计算会出现错误
            //这时我们就需要知道文档坐标与客户区坐标的偏移量，这就是AutoScrollPostion可以提供的

            pictureBox2.Size = new Size(reSize.Location.X - (this.panel1.AutoScrollPosition.X), reSize.Location.Y - (this.panel1.AutoScrollPosition.Y));
            dt.targetGraphics = pictureBox2.CreateGraphics();//因为画板的大小被改变所以必须重新赋值

            //另外画布也被改变所以也要重新赋值
            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pictureBox2.Width, pictureBox2.Height);
            g.DrawImage(dt.OrginalImg, 0, 0);
            g.Dispose();
            g = pictureBox2.CreateGraphics();
            g.DrawImage(bmp, 0, 0);
            g.Dispose();
            dt.OrginalImg = bmp;

            bmp.Dispose();
        }

        private void revocation_Click(object sender, EventArgs e)
        {
            dt.revocation();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dt.advance();
        }
    }
}
