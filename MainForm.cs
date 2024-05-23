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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientsForm pacientiForm = new PatientsForm();
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
            prescriptionsForm.Show();
        }

        private void newDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDoctorForm addNewDoctorForm = new AddNewDoctorForm();
            addNewDoctorForm.Show();
        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPatientForm addNewPatientForm = new AddNewPatientForm();
            addNewPatientForm.Show();
        }

        private void newPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPrescriptionForm addNewPrescriptionForm = new AddNewPrescriptionForm();
            addNewPrescriptionForm.Show();
        }

        private void databaseSchemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchemaForm schemaForm = new SchemaForm();
            schemaForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
