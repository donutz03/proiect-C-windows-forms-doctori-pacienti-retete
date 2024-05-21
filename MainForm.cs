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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientsForm pacientiForm = new PatientsForm();
            pacientiForm.Show();
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorsForm = new DoctorsForm();
            doctorsForm.Show();
        }

        private void prescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrescriptionsForm prescriptionsForm = new PrescriptionsForm();
            prescriptionsForm.Show();
        }
    }
}
