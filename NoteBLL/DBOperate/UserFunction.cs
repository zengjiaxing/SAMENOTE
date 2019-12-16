
using NOTE.ClassModel;
using NoteDAL;
using System.Collections.Generic;

namespace NoteBLL.DBOperate
{
 public   class UserFunction
    {
        public bool Register(string s1,string s2,string s3)
        {
            DataSource ds = new DataSource();
            if (!ds.GetUser(s1))
            {
                ds.InsertDatabaseUSER(s1, s2, s3);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int LogIn(string s1, string s2)
        {
            bool LoginSuccess = false;
            DataSource ds = new DataSource();
            List<User> userlist = new List<User>();
            userlist = ds.ReadDatabaseUSER();
            if (s1 == "" || s2 == "")
            {
                return 0;
            }
            foreach (User u in userlist)
            {
                if (u.Name == s1 && u.Password == s2)
                {
                    return 1;
                }
            }
            return -1;
        }

        public void Modify(string s1,string s2)
        {
            string uname = s1;
            string psw = s2;
            DataSource data = new DataSource();
            List<User> userlist = new List<User>();
            data.AlterDatabaseUSER(uname, psw);
            userlist = data.ReadDatabaseUSER();
            foreach (User u in userlist)
            {
                if (u.Name == uname && u.Password == psw)
                {
                    return;
                }
            }
        }

        public bool Forget(string s1,string s2)
        {
            string uname = s1;
            string tel = s2;
            DataSource data = new DataSource();
            List<User> userlist = new List<User>();
            userlist = data.ReadDatabaseUSER();
            foreach (User u in userlist)
            {
                System.Console.WriteLine(uname);
                System.Console.WriteLine(tel);
                if (u.Name == uname && u.Tel == tel)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
