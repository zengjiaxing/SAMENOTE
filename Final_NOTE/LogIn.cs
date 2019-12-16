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
using NOTE.ClassModel;

namespace NOTE
{
    public delegate void PassName(string str);
    public partial class LogIn : Form
    {
        public event PassName passname;
        public LogIn()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            UserFunction uf = new UserFunction();
            switch (uf.LogIn(this.username.Text, this.password.Text))
            {
                case -1:
                    MessageBox.Show("用户名或密码输入错误");
                    break;
                case 0:
                    MessageBox.Show("请输入用户名和密码！");
                    break;
                case 1:
                    passname(username.Text);
                    this.Close();
                    break;
            }
        }
    }
}
