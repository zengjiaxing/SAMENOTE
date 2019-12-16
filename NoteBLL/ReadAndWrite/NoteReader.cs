using NOTE.ClassModel;
using NoteBLL.Serialize;
using System.Drawing;
using System.IO;

namespace NoteBLL.ReadAndWrite
{
 public   class NoteReader
    {
        public Note ReadFromFile(string path)
        {
            Serializer sl = new Serializer();
            Note n = sl.DeNoteSerialize(path);
            n.Path = path;
            Stream s = File.Open(path+"/image.bmp", FileMode.Open);
            n.Paint = Image.FromStream(s);
            s.Close();
            return n;
        }
    }
}
