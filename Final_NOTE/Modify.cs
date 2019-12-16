using NOTE.ClassModel;
using NoteDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTE
{
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }
        //修改密码
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            string uname = this.UserNameTbx.Text;
            string psw = this.PasswordTbx.Text;
            DataSource data = new DataSource();
            List<User> userlist = new List<User>();
            data.AlterDatabaseUSER(uname, psw);
            userlist = data.ReadDatabaseUSER();
            foreach (User u in userlist)
            {
                if (u.Name1 == uname && u.Password1 == psw)
                {
                    MessageBox.Show("用户修改密码成功");
                    //关闭当前窗口
                    this.Close();
                }
            }
        }
    }
}
