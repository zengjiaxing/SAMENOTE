using NOTE.ClassModel;
using NoteDAL;
using System;
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
        public Note GetInsertedNote()
        {
            List<Note> allNotes;
            DataSource ds = new DataSource();
            allNotes = ds.ReadDatabaseNOTE();
            int maxindex = 0;
            int maxvalue = 0;
            for (int i = 0; i < allNotes.Count; i++)
            {
                if (allNotes[i].ID>maxvalue)
                {
                    maxvalue = allNotes[i].ID;
                    maxindex = i;
                }
            }
            return allNotes[maxindex];
        }
        public Note AddNote(string uname,string nname,string path,DateTime ctime ,DateTime ltime)
        {
            DataSource ds = new DataSource();
            ds.InsertDatabaseNOTE(uname,nname,path,ctime,ltime);
            return GetInsertedNote();
        }
    }
}
