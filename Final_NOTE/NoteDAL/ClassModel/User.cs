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
        List<Note> NoteList;

        public User(string v1, string v2, List<Note> p)
        {
            this.Name = v1;
            this.Password = v2;
            this.NoteList = p;
        }

        public string Name1 { get => Name; set => Name = value; }
        public string Password1 { get => Password; set => Password = value; }
        public List<Note> NoteList1 { get => NoteList; set => NoteList = value; }
    }
}
