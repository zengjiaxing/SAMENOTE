//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
//using NOTE.ClassModel;

//namespace NoteDAL
//{
//    public class DataSource
//    {
//        //DataSource data;       //新建了一个这个类的对象，方便方法的调用
//        //public MySqlConnection conn;     //新建一个数据库连接对象
//        //public bool isConnection = false;     //数据库是否连接上
//        List<User> userList = new List<User>();
//        public DataSource()
//        {
//            init();
//        }
//        public List<User> init()
//        {
//            OpenDatabase();
//            return userList;
//            //ReadDatabase();
//        }
//        //public string connStr = "server=localhost;user=root;password=root; database=note;";
//        //private MySqlConnection conn = new MySqlConnection(connStr);
//        //static void Main(string[] args)
//        //{
//        //    data = new DataSource();
//        //    //1.查询
//        //    data.OpenDatabase();
//        //    if (data.isConnection)
//        //    {
//        //        //Console.WriteLine("可以查询");
//        //        data.ReadDatabase();
//        //        //data.InsertDatabase();
//        //        //插入
//        //    }
//        //    Console.ReadLine();
//        //}
//        //启动数据库
//        void OpenDatabase()
//        {
//            string connStr = "server=localhost;user=root;password=root; database=note;";
//            MySqlConnection conn = new MySqlConnection(connStr);
//            //打开数据库
//            try
//            {
//                conn.Open();
//                Console.WriteLine("数据库连接成功");
//                //读取数据库
//                userList = ReadDatabase();
//            }catch(MySqlException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            //finally
//            //{
//            //    conn.Close();
//            //}
//        }
//        //查询数据库
//        List<User> ReadDatabase()
//        {
//            List<User> list = new List<User>();
//            string connStr = "server=localhost;user=root;password=root; database=note;";
//            MySqlConnection conn = new MySqlConnection(connStr);
//            //1.sql语句  people表名字
//            string readSql = "SELECT * FROM user";
//            //1.参sql语句 2.参是当前数据库服务器连接对象
//            conn.Open();
//            MySqlCommand command = new MySqlCommand(readSql, conn);
//            //.检索数据
//            MySqlDataReader reader = command.ExecuteReader();
//            while (reader.Read())
//            {
//                User user = new User(reader.GetString(0), reader.GetString(1), null);
//                list.Add(user);
//            }
//            //foreach (User x in userList)
//            //{

//            //    Console.WriteLine(x.Name1+x.Password1);
//            //}
//            return list;

//        }
//        //插入数据库
//        void InsertDatabase()
//        {

//        }
//    }
//}
