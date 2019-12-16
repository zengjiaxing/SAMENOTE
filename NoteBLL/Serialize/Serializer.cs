
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using NOTE.ClassModel;
using System.Xml.Serialization;
namespace NOTE.Tools
{
    class Serializer
    {
        public void NoteSerialize(Note n)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            //XmlSerializer formatter = new XmlSerializer(typeof(Note));
            using (FileStream stream = new FileStream(@"D:\note.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, n);
            }
        }

        public Note DeNoteSerialize()
        {
            Note outNote = null;
            BinaryFormatter formatter = new BinaryFormatter();
using (FileStream stream = new FileStream(@"D:\note.txt", FileMode.OpenOrCreate))
              {
                 outNote = formatter.Deserialize(stream) as Note;
              }
            return outNote;
        }
    }
}
