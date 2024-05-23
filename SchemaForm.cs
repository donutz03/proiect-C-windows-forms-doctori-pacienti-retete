using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1056_HODOROAGA_IONUT
{
    public partial class SchemaForm : Form
    {
        public SchemaForm()
        {
            InitializeComponent();
        }

        private void SchemaForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CenterPictureBox();
        }

        private void CenterPictureBox()
        {
            int x = (this.ClientSize.Width - schemaPictureBox.Width) / 2;
            int y = (this.ClientSize.Height - schemaPictureBox.Height) / 2;

            schemaPictureBox.Location = new Point(x, y);
        }
    }
}
