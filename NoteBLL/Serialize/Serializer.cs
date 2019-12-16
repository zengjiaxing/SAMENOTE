
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using NOTE.ClassModel;
using System.Xml.Serialization;
namespace NoteBLL.Serialize
{
  public  class Serializer
    {
        public void NoteSerialize(Note n)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string NotePath = n.Path + "/note.txt";
            using (FileStream stream = new FileStream(NotePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, n);
            }
        }

        public Note DeNoteSerialize(string path)
        {
            string FilePath = path + "/note.txt";
            Note outNote = null;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(FilePath, FileMode.OpenOrCreate))
              {
                 outNote = formatter.Deserialize(stream) as Note;
              }
            return outNote;
        }
    }
}
