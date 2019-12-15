using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NOTE.ClassModel
{
    public class Note
    {
        int ID;
        string UserName;
        String name;//笔记名字
        String Path;//笔记路径
        DateTime CreateTime;//创建时间
        DateTime LastModify;//最后一次修改时间
        PictureBox Paint;
        List<TextBox> Texts;

        public Note(int id, string u,string v1, string v2, DateTime v3, DateTime v4, PictureBox p1, List<TextBox> p2)
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

        public int ID1 { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public string Path1 { get => Path; set => Path = value; }
        public DateTime CreateTime1 { get => CreateTime; set => CreateTime = value; }
        public DateTime LastModify1 { get => LastModify; set => LastModify = value; }
        public PictureBox Paint1 { get => Paint; set => Paint = value; }
        public List<TextBox> Texts1 { get => Texts; set => Texts = value; }
        public string UserName1 { get => UserName; set => UserName = value; }
    }
}
