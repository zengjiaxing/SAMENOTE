using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteBLL.DBOperate;
namespace NOTE
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            UserFunction uf = new UserFunction();
            if(uf.Register(this.username.Text, this.password.Text, this.tel.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("此用户名已被注册");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
