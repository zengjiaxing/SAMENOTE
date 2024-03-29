﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using NOTE.ClassModel;
namespace NoteDAL
{
    public class DataSource
    {
        //DataSource data;       //新建了一个这个类的对象，方便方法的调用
        //public MySqlConnection conn;     //新建一个数据库连接对象
        //public bool isConnection = false;     //数据库是否连接上
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
            string constr = "server=.;database=Note;uid=sun;pwd=sun5j666";
            SqlConnection conn = new SqlConnection(constr);
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
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void CloseDataBase(SqlConnection c)
        {
            c.Close();
        }
        public SqlConnection ConnectToDataBase()
        {
            string constr = "server=.;database=Note;uid=sun;pwd=sun5j666";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("数据库连接成功");
            return conn;
        }
        //查询数据库USER
        public List<User> ReadDatabaseUSER()
        {
            //1.sql语句  
            string readSql = "SELECT * FROM Users";
            SqlConnection conn = ConnectToDataBase();
            //1.参sql语句 2.参是当前数据库服务器连接对象
            conn.Close();
            conn.Open();
            SqlCommand command = new SqlCommand(readSql, conn);
            //.检索数据
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                User user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), null);
                userList.Add(user);
            }
            conn.Close();
            return userList;

        }

        //插入数据库USER
        public bool InsertDatabaseUSER(string name, string psw, string tel)
        {
            //string sqlstr = "INSERT INTO note.user VALUES ('11','11')";
            SqlConnection conn = ConnectToDataBase();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Users VALUES (@name,@pswd,@tel)";
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@pswd", psw);
            command.Parameters.AddWithValue("@tel", tel);
            conn.Close();
            conn.Open();
            try
            {
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (SqlException ex)
            {
                conn.Close();
                return false;
            }

            //ReadDatabase();
            ////返回值
            //int result = command.ExecuteNonQuery();
            ////查询
            //ReadDatabase();
        }

        public bool GetUser(string name)
        {
            SqlConnection conn = ConnectToDataBase();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Users WHERE userName = @name";
            command.Parameters.AddWithValue("@name", name);
            //.检索数据
            SqlDataReader reader = command.ExecuteReader();
            List<User> list = new List<User>();

            while (reader.Read())
            {
                //User user = new User(reader.GetString(0))
                User user = new User(reader.GetString(0));
                if(user.Name == name)
                {
                    return true;
                }
            }
            return false;
        }


        //修改数据库USER
        public void AlterDatabaseUSER(string name, string psw)
        {
            //string sqlstr = "INSERT INTO note.user VALUES ('11','11')";
            SqlConnection conn = ConnectToDataBase();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "update Users set passWord = '" + psw + "' where userName = '" + name + "'";
            conn.Close();
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
            //1.sql语句  people表名字
            string readSql = "SELECT * FROM Notes";
            SqlConnection conn = ConnectToDataBase();
            //1.参sql语句 2.参是当前数据库服务器连接对象
            conn.Close();
            conn.Open();
            SqlCommand command = new SqlCommand(readSql, conn);
            //.检索数据
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Note note = new Note(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetDateTime(5), null, null);
                noteList.Add(note);
            }
            conn.Close();
            return noteList;
        }

        //插入数据库NOTE
        public void InsertDatabaseNOTE(string UserName, string NoteName, string Path, DateTime CTime, DateTime LTime)
        {
            //string sqlstr = "INSERT INTO note.user VALUES ('11','11')";
            SqlConnection conn = ConnectToDataBase();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "insert  into Notes(UserName, NoteName, Path, CTime, LTime)VALUES (@UserName,@NoteName,@Path,@CTime,@LTime)";
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@NoteName", NoteName);
            command.Parameters.AddWithValue("@Path", Path);
            command.Parameters.AddWithValue("@CTime", CTime);
            command.Parameters.AddWithValue("@LTime", LTime);
            conn.Close();
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
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
            SqlConnection conn = ConnectToDataBase();

            //1.参sql语句 2.参是当前数据库服务器连接对象
            conn.Open();
            SqlCommand command = new SqlCommand(readSql, conn);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@NoteName", NoteName);
            //.检索数据
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            return id;
        }
        //修改数据库NOTE
        public void AlterNoteName(string NoteName1,int id, DateTime LTime)
        {
            //string sqlstr = "INSERT INTO note.user VALUES ('11','11')";
            SqlConnection conn = ConnectToDataBase();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "update Notes set " +
                "NoteName = @NoteName1,LTime = @LTime where ID = @ID";
            command.Parameters.AddWithValue("@NoteName1", NoteName1);
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@LTime", LTime);
            conn.Close();
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void AlterNotePath(string Path, int id, DateTime LTime)
        {
            //string sqlstr = "INSERT INTO note.user VALUES ('11','11')";
            SqlConnection conn = ConnectToDataBase();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "update Notes set " +
                "Path = @Path,LTime = @LTime where ID = @ID";
            command.Parameters.AddWithValue("@Path", Path);
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@LTime", LTime);
            conn.Close();
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        //删除数据库NOTE信息
        public void DelDatabaseNOTE(int id)
        {
            //string sqlstr = "INSERT INTO note.user VALUES ('11','11')";
            SqlConnection conn = ConnectToDataBase();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from Notes where ID = @ID";
            command.Parameters.AddWithValue("@ID", id);
            conn.Close();
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        public List<Note> GetNotesbyCtime(string uname)
        {
            List<Note> list = new List<Note>();
            string str = "select * from Notes where UserName = @uname order by CTime DESC";
            SqlConnection conn = ConnectToDataBase();
            //1.参sql语句 2.参是当前数据库服务器连接对象
            conn.Close();
            conn.Open();
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@uname", uname);
            //.检索数据
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Note note = new Note(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetDateTime(5), null, null);
                list.Add(note);
            }
            return list;
        }
        public List<Note> GetNotesbyLtime(string uname)
        {
            List<Note> list = new List<Note>();
            string str = "select * from Notes where UserName = @uname order by LTime DESC";
            SqlConnection conn = ConnectToDataBase();
            //1.参sql语句 2.参是当前数据库服务器连接对象
            conn.Close();
            conn.Open();
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@uname", uname);
            //.检索数据
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Note note = new Note(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetDateTime(5), null, null);
                list.Add(note);
            }
            return list;
        }

        public void AlterNoteTIme(DateTime LTime, int id)
        {
            //string sqlstr = "INSERT INTO note.user VALUES ('11','11')";
            SqlConnection conn = ConnectToDataBase();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "update Notes set " +
                "LTime = @LTime where ID = @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@LTime", LTime);
            conn.Close();
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}