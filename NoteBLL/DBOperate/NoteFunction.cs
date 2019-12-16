using NOTE.ClassModel;
using NoteDAL;
using System.Collections.Generic;

namespace NoteBLL.DBOperate
{
 public   class NoteFunction
    {
        public List<Note> GetMyNote(string uname)
        {
            List<Note> allNotes;
            List<Note> myNotes = new List<Note>();
            DataSource ds = new DataSource();
            allNotes = ds.ReadDatabaseNOTE();
            for(int i = 0; i < allNotes.Count; i++)
            {
                if(allNotes[i].UserName == uname)
                {
                    myNotes.Add(allNotes[i]);
                }
            }
            return myNotes;
        }
    }
}
