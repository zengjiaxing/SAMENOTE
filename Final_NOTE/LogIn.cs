using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NOTE.ClassModel;
using NoteDAL;
namespace NOTE
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        //注册用户信息
        private void button1_Click(object sender, EventArgs e)
        {
            string uname = this.UserNameTbx.Text;
            string psw = this.PasswordTbx.Text;
            string tel = this.TELBox.Text;
            if (this.UserNameTbx.Text == "")
            {
                MessageBox.Show("用户名不能为空");
                //InitializeComponent();
            }
            else if (this.PasswordTbx.Text == "")
            {
                MessageBox.Show("密码不能为空");
                //InitializeComponent();
            }
            else if (this.TELBox.Text == "")
            {
                MessageBox.Show("电话不能为空");
                //InitializeComponent();
            }
            else
            {
                DataSource data = new DataSource();
                //data.InsertDatabaseUSER(uname, psw, tel);
                List<User> userlist = new List<User>();
                userlist = data.ReadDatabaseUSER();
                Boolean HasRegister = false;
                foreach (User u in userlist)
                {
                    if (u.Name1 == uname)
                    {
                        MessageBox.Show("用户已存在，请重新注册");
                        this.UserNameTbx.Text = "";
                        this.PasswordTbx.Text = "";
                        this.TELBox.Text = "";
                        HasRegister = true;//已经注册过
                    }
                }
                
                if (!HasRegister)
                {
                    data.InsertDatabaseUSER(uname, psw, tel);
                }

                foreach (User u in userlist)
                {
                    if (u.Name1 == uname && u.Password1 == psw && u.Tel1 == tel)
                    {
                        MessageBox.Show("用户注册成功");
                        this.UserNameTbx.Text = "";
                        this.PasswordTbx.Text = "";
                        this.TELBox.Text = "";
                    }
                }
            }

        }
        //用户登录
        public void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Boolean LoginSuccess = false;
            string uname = this.UserNameTbx.Text;
            string psw = this.PasswordTbx.Text;
            DataSource data = new DataSource();
            List<User> userlist = new List<User>();
            userlist = data.ReadDatabaseUSER();
            foreach (User u in userlist)
            {
                if (u.Name1 == uname && u.Password1 == psw)
                {
                    MessageBox.Show("用户登录成功");
                    this.UserNameTbx.Text = "";
                    this.PasswordTbx.Text = "";
                    this.Close();
                    Note.UserName = uname;
                    Note.LoginSuccess = true;
                    LoginSuccess = true;
                }
            }
            if (!LoginSuccess)
            {
                this.UserNameTbx.Text = "";
                this.PasswordTbx.Text = "";
                MessageBox.Show("用户名与密码不匹配，请重新输入");
            }
            
            //return false;

        }
        //忘记密码
        public void ForgetBtn_Click(object sender, EventArgs e)
        {
            Boolean User = false;//用户身份验证
            string uname = this.UserNameTbx.Text;
            string tel = this.TELBox.Text;
            //string psw = this.PasswordTbx.Text;
            DataSource data = new DataSource();
            List<User> userlist = new List<User>();
            userlist = data.ReadDatabaseUSER();
            Tishi.Visible = true;
            foreach (User u in userlist)
            {
                if (u.Name1 == uname && u.Tel1 == tel)
                {
                    User = true;
                    MessageBox.Show("用户验证身份成功");
                    this.UserNameTbx.Text = "";
                    this.TELBox.Text = "";
                    //用户进行修改密码
                    Modify modify = new Modify();
                    modify.Show();
                }
            }
            if (!User)
            {
                MessageBox.Show("用户验证身份失败，请重新输入");
                this.UserNameTbx.Text = "";
                this.TELBox.Text = "";
            }
        }
    }
}
