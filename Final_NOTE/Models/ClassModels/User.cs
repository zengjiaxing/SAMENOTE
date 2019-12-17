using System.Collections.Generic;
namespace NOTE.ClassModel
{
    public class User
    {
        string name;
        string password;
        string tel;
        List<Note> noteList;

        public User() { }
        public User(string v1, string v2, string v3,List<Note> p)
        {
            this.Name = v1;
            this.Password = v2;
            this.Tel = v3;
            this.NoteList = p;
        }
        public User(string s)
        {
            this.name = s;
        }

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Tel { get => tel; set => tel = value; }
        public List<Note> NoteList { get => noteList; set => noteList = value; }
    }
}
