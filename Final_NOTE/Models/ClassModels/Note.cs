using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
        string userName;
        String name;//笔记名字
        String path;//笔记路径
        DateTime createTime;//创建时间
        DateTime lastModify;//最后一次修改时间
        Image paint;
        List<TextBoxInfo> texts = new List<TextBoxInfo>();

        public Note(int id, string u, string v1, string v2, DateTime v3, DateTime v4, Image p1, List<TextBoxInfo> p2)
        {
            this.ID = id;
            this.UserName = u;
            this.name = v1;
            this.Path = v2;
            this.CreateTime = v3;
            this.LastModify = v4;
            this.Paint = p1;
            this.Texts = p2;
        }
        public Note() { }
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Path { get => path; set => path = value; }
        public DateTime CreateTime { get => createTime; set => createTime = value; }
        public DateTime LastModify { get => lastModify; set => lastModify = value; }
        public Image Paint { get => paint; set => paint = value; }
        public List<TextBoxInfo> Texts { get => texts; set => texts = value; }
        public string UserName { get => userName; set => userName = value; }
    }
}
