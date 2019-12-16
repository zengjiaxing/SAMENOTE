using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOTE.ClassModel;
using System.Drawing;
using NoteBLL.Serialize;
namespace NoteBLL.ReadAndWrite
{
 public   class NoteWriter
    {
        public void WriteToFile(Note n) {
            string imagePath = n.Path + "/" + "image.bmp";
            
            n.Paint.Save(imagePath);
            n.Paint = null;
            Serializer s = new Serializer();
            s.NoteSerialize(n);
        }
    }
}
