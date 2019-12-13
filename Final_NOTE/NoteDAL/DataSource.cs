using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using NOTE.ClassModel;
namespace NoteDAL
{
    class DataSource
    {
        static DataSource data;       //新建了一个这个类的对象，方便方法的调用
        public MySqlConnection conn;     //新建一个数据库连接对象
        public bool isConnection = false;     //数据库是否连接上
        List<User> userList = new List<User>();
        static void Main(string[] args)
        {
            data = new DataSource();
            //1.查询
            data.OpenDatabase();
            if (data.isConnection)
            {
                //Console.WriteLine("可以查询");
                data.ReadDatabase();
                data.InsertDatabase();
                //插入
            }
            Console.ReadLine();
        }
        //启动数据库
        void OpenDatabase()
        {
            string connStr = "server=114.116.39.130;user=root;password=root; database=user;";
            //打开数据库
            conn = new MySqlConnection(connStr);
            conn.Open();
            try
            {
                data.isConnection = true;
                Console.WriteLine("数据库连接成功");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        //查询数据库
        void ReadDatabase()
        {
            //1.sql语句  people表名字
            string readSql = "SELECT * FROM user";
            //1.参sql语句 2.参是当前数据库服务器连接对象
            MySqlCommand command = new MySqlCommand(readSql, conn);
            //.检索数据
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //User user = new User(reader.GetString(1), int.Parse(reader.GetString(2),List<string>(reader.GetString(3)));
                //userList.Add(user);
            }
            foreach (User item in userList)
            {
                //Console.WriteLine(item.name);
            }

        }
        //插入数据库
        void InsertDatabase()
        {

        }
    }
}
