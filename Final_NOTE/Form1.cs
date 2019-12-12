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

        public Note()
        {
            InitializeComponent();
            myDrawBox = new MyDrawBox(pictureBox1);
            penSize.Items.Add(5);
            penSize.Items.Add(7);
            penSize.Items.Add(9);
            penSize.Items.Add(11);
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
            myDrawBox.colorSelect(colorDialog1) ;
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
    }
}
