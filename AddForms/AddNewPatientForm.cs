using _2_1056_HODOROAGA_IONUT.Entities;
using _2_1056_HODOROAGA_IONUT.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1056_HODOROAGA_IONUT.AddForms
{
    public partial class AddNewPatientForm : Form
    {
        PatientRepository _patientRepository;
        public AddNewPatientForm()
        {
            InitializeComponent();
            _patientRepository = new PatientRepository();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(patientIdTb.Text);
            string name = patientNameTb.Text;
            DateTime dateOfBirth = addNewPatientDateTimePicker.Value;

            Patient newPatient = new Patient
            {
                Id = id,
                Name = name,
                DateOfBirth = dateOfBirth
            };

            _patientRepository.AddPatient(newPatient);

            MessageBox.Show("Patient added successfully!");
            foreach (var form in Application.OpenForms)
            {
                if (form is PatientsForm patientsForm)
                {
                    patientsForm.RefreshData();
                }
            }
            patientIdTb.Text = "";
            patientNameTb.Text = "";
            addNewPatientDateTimePicker.Value = DateTime.Now;
        }
    }
}
