using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.ClassModels;
using NOTE.ControlModel;
namespace NOTE.ClassModel
{
    [Serializable]
    public class Note
    {
        int iD;
        String name;//笔记名字
        String path;//笔记路径
        DateTime rreateTime;//创建时间
        DateTime lastModify;//最后一次修改时间
        DrawTools paint;
        List<TextBoxInfo> texts = new List<TextBoxInfo>();


        public string Name { get => name; set => name = value; }
        public int ID { get => ID; set => ID = value; }
        public string Path { get => path; set => path = value; }
        public DateTime RreateTime { get => rreateTime; set => rreateTime = value; }
        public DateTime LastModify { get => lastModify; set => lastModify = value; }
        public DrawTools Paint { get => paint; set => paint = value; }
        public List<TextBoxInfo> Texts { get => texts; set => texts = value; }
    }
}
