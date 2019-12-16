using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ClassModels
{
    [Serializable]
 public   class TextBoxInfo
    {
        string text ;
        Point location;
        Size size;
        string name;
        string font;
        float fontSize;
        bool bold;
        bool italic;
        bool underline;
        Color fontColor;

        public string Text { get => text; set => text = value; }
        public Point Location { get => location; set => location = value; }
        public Size Size { get => size; set => size = value; }
        public string Name { get => name; set => name = value; }
        public string Font { get => font; set => font = value; }
        public float FontSize { get => fontSize; set => fontSize = value; }
        public bool Bold { get => bold; set => bold = value; }
        public bool Italic { get => italic; set => italic = value; }
        public bool Underline { get => underline; set => underline = value; }
        public Color FontColor { get => fontColor; set => fontColor = value; }
    }
}
