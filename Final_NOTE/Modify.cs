using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteBLL.DBOperate;
namespace NOTE
{
    public partial class Modify : Form
    {
        string name;
        public Modify(string a)
        {
            InitializeComponent();
            name = a;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            UserFunction uf = new UserFunction();
            uf.Modify(name,this.password.Text);
            MessageBox.Show("更改成功");
            this.Close();
        }
    }
}
