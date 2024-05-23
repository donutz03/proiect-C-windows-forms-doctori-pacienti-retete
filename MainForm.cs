using _2_1056_HODOROAGA_IONUT.AddForms;
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
    public partial  class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.MdiChildActivate += MainForm_MdiChildActivate;
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientsForm pacientiForm = new PatientsForm();
            pacientiForm.MdiParent = this;
            pacientiForm.Show();
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorsForm = new DoctorsForm();
            doctorsForm.MdiParent = this;
            doctorsForm.Show();
        }

        private void prescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrescriptionsForm prescriptionsForm = new PrescriptionsForm();
            prescriptionsForm.MdiParent = this;
            prescriptionsForm.Show();
        }

        private void newDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDoctorForm addNewDoctorForm = new AddNewDoctorForm();
            addNewDoctorForm.MdiParent = this;
            addNewDoctorForm.Show();
        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPatientForm addNewPatientForm = new AddNewPatientForm();
            addNewPatientForm.MdiParent = this;
            addNewPatientForm.Show();
        }

        private void newPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPrescriptionForm addNewPrescriptionForm = new AddNewPrescriptionForm();
            addNewPrescriptionForm.MdiParent = this;
            addNewPrescriptionForm.Show();
        }

        private void databaseSchemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchemaForm schemaForm = new SchemaForm();
            schemaForm.MdiParent = this;
            schemaForm.Show();
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Label || control is TextBox)
                    {
                        control.Visible = true;
                    }
                }
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Label || control is TextBox)
                    {
                        control.Visible = false;
                    }
                }
            }
        }
    }
}
