using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTE.ClassModel
{
    public class Note
    {
        int ID;
        String name;//笔记名字
        String Path;//笔记路径
        DateTime CreateTime;//创建时间
        DateTime LastModify;//最后一次修改时间
        PictureBox Paint;
        List<TextBox> Texts;
    }
}
