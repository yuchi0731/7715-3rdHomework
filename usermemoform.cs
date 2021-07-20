using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework0717
{
    public partial class usermemoform : Form
    {
        public usermemoform()
        {
            InitializeComponent();
        }

        private void 黑ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 紅色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.textememo.Text != "")
            {
                this.textememo.ForeColor = Color.Red;
            }
            
        }

        private void 綠色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.textememo.Text != "")
            {
                this.textememo.ForeColor = Color.Green;
            }
        }

        private void 藍色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.textememo.Text != "")
            {
                this.textememo.ForeColor = Color.Blue;
            }
        }

        private void usermemoform_Load(object sender, EventArgs e)
        {
            if (this.textememo.Text != "")
            {
                this.textememo.ForeColor = Color.Black;
            }
        }
    }
}
