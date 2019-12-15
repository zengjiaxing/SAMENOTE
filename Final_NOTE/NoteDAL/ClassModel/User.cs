using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTE.ClassModel
{
    public class User
    {
        string Name;
        string Password;
        string Tel;
        List<Note> NoteList;

        public User(string v1, string v2,string v3, List<Note> p)
        {
            this.Name = v1;
            this.Password = v2;
            this.Tel = v3;
            this.NoteList = p;
        }

        public string Name1 { get => Name; set => Name = value; }
        public string Password1 { get => Password; set => Password = value; }
        public List<Note> NoteList1 { get => NoteList; set => NoteList = value; }
        public string Tel1 { get => Tel; set => Tel = value; }
    }
}
