using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using NOTE.ClassModel;
namespace NoteDAL
{
    public class DataSource
    {
        //DataSource data;       //新建了一个这个类的对象，方便方法的调用
        //public MySqlConnection conn;     //新建一个数据库连接对象
        //public bool isConnection = false;     //数据库是否连接上
        List<User> userList = new List<User>();
        List<Note> noteList = new List<Note>();
        public DataSource()
        {

        }
        public List<User> init()
        {
            //OpenDatabase();
            //InsertDatabase();
            //ReadDatabase();
            return userList;
        }

        //启动数据库
        public void OpenDatabase()
        {
            string connStr = "server=localhost;user=root;password=root; database=note;";
            MySqlConnection conn = new MySqlConnection(connStr);
            //打开数据库
            try
            {
                conn.Open();
                Console.WriteLine("数据库连接成功");
                conn.Close();
                //读取数据库
                //InsertDatabase();
                // userList = ReadDatabase("user");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //查询数据库USER
        public List<User> ReadDatabaseUSER()
        {
            //1.sql语句  
            string readSql = "SELECT * FROM user";
            string connStr = "server=localhost;user=root;password=root; database=note;";
            MySqlConnection conn = new MySqlConnection(connStr);
            //1.参sql语句 2.参是当前数据库服务器连接对象
            conn.Open();
            MySqlCommand command = new MySqlCommand(readSql, conn);
            //.检索数据
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                User user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), null);
                userList.Add(user);
            }
            return userList;

        }
        
        //插入数据库USER
        public void InsertDatabaseUSER(string name, string psw, string tel)
        {
            //string sqlstr = "INSERT INTO note.user VALUES ('11','11')";
            string connStr = "server=localhost;user=root;password=root; database=note;";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO note.user VALUES (@name,@pswd,@tel)";
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@pswd", psw);
            command.Parameters.AddWithValue("@tel", tel);
            conn.Open();
            command.ExecuteNonQuery();
            //ReadDatabase();
            ////返回值
            //int result = command.ExecuteNonQuery();
            ////查询
            //ReadDatabase();

        }
        //修改数据库USER
        public void AlterDatabaseUSER(string name, string psw)
        {
            //string sqlstr = "INSERT INTO note.user VALUES ('11','11')";
            string connStr = "server=localhost;user=root;password=root; database=note;";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "update note.user set passWord = '" + psw + "' where userName = '" + name + "'";
            conn.Open();
            command.ExecuteNonQuery();
            //ReadDatabase();
            ////返回值
            //int result = command.ExecuteNonQuery();
            ////查询
            //ReadDatabase();

        }
        //查询数据库NOTE
        public List<Note> ReadDatabaseNOTE()
        {
            //1.sql语句  people表名字
            string readSql = "SELECT * FROM notelist";
            string connStr = "server=localhost;user=root;password=root; database=note;";
            MySqlConnection conn = new MySqlConnection(connStr);
            //1.参sql语句 2.参是当前数据库服务器连接对象
            conn.Open();
            MySqlCommand command = new MySqlCommand(readSql, conn);
            //.检索数据
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Note note = new Note(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetDateTime(5), null, null);
                noteList.Add(note);
            }
            return noteList;
        }
        //插入数据库NOTE
        public void InsertDatabaseNOTE(string UserName, string NoteName, string Path,DateTime CTime,DateTime LTime)
        {
            //string sqlstr = "INSERT INTO note.user VALUES ('11','11')";
            string connStr = "server=localhost;user=root;password=root; database=note;";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "insert  into note.notelist(UserName, NoteName, Path, CTime, LTime)VALUES (@UserName,@NoteName,@Path,@CTime,@LTime)";
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@NoteName", NoteName);
            command.Parameters.AddWithValue("@Path", Path);
            command.Parameters.AddWithValue("@CTime", CTime);
            command.Parameters.AddWithValue("@LTime", LTime);
            conn.Open();
            command.ExecuteNonQuery();
            //ReadDatabase();
            ////返回值
            //int result = command.ExecuteNonQuery();
            ////查询
            //ReadDatabase();

        }
        //获取note的id
        public int GetId(string UserName, string NoteName)
        {
            int id = 0;
            string readSql = "select ID from note.notelist where notelist.UserName = @UserName and notelist.NoteName=@NoteName";
            string connStr = "server=localhost;user=root;password=root; database=note;";
            MySqlConnection conn = new MySqlConnection(connStr);
            
            //1.参sql语句 2.参是当前数据库服务器连接对象
            conn.Open();
            MySqlCommand command = new MySqlCommand(readSql, conn);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@NoteName", NoteName);
            //.检索数据
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            return id;
        }
        //修改数据库NOTE
        public void AlterDatabaseNOTE(string UserName,string NoteName1,string NoteName2, DateTime LTime)
        {
            //string sqlstr = "INSERT INTO note.user VALUES ('11','11')";
            string connStr = "server=localhost;user=root;password=root; database=note;";
            MySqlConnection conn = new MySqlConnection(connStr);
            int id = GetId(UserName, NoteName1);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "update note.notelist set " +
                "NoteName = @NoteName2,LTime = @LTime where ID = @ID and UserName = @UserName";
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@NoteName2", NoteName2);
            command.Parameters.AddWithValue("@LTime", LTime);
            conn.Open();
            command.ExecuteNonQuery();
        }
        //删除数据库NOTE信息
        public void DelDatabaseNOTE(string UserName,string NoteName)
        {
            //string sqlstr = "INSERT INTO note.user VALUES ('11','11')";
            string connStr = "server=localhost;user=root;password=root; database=note;";
            MySqlConnection conn = new MySqlConnection(connStr);
            int id = GetId(UserName, NoteName);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from note.notelist where ID = @ID and UserName = @UserName";
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@UserName", UserName);
            conn.Open();
            command.ExecuteNonQuery();
        }
        //按最新日期读取NOTE
        public List<Note> ReserveNOTE()
        {
            List<Note> list = new List<Note>();
            string readSql = "select * from note.notelist where 1 = 1 order by LTime desc ;";
            string connStr = "server=localhost;user=root;password=root; database=note;";
            MySqlConnection conn = new MySqlConnection(connStr);
            //1.参sql语句 2.参是当前数据库服务器连接对象
            conn.Open();
            MySqlCommand command = new MySqlCommand(readSql, conn);
            //.检索数据
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Note note = new Note(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetDateTime(5), null, null);
                list.Add(note);
            }
            return list;
        }
    }
}
