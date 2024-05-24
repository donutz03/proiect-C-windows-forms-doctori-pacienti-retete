using _2_1056_HODOROAGA_IONUT.Entities;
using _2_1056_HODOROAGA_IONUT.Repositories;
using System;
using System.Windows.Forms;

namespace _2_1056_HODOROAGA_IONUT.EditForms
{
    public partial class EditPatientForm : Form
    {
        private PatientRepository _PatientRepository;
        private Patient _patient;

        public EditPatientForm(Patient patient)
        {
            InitializeComponent();
            _patient = patient;
            _PatientRepository = new PatientRepository();

            updatePatientIdTb.Text = _patient.Id.ToString();
            updatePatientIdTb.ReadOnly = true;
            
            updatePatientNameTb.Text = _patient.Name;
            editPatientDateTimePicker.Value = _patient.DateOfBirth;
           
        }

       

        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            _patient.Name = updatePatientNameTb.Text;
            _patient.DateOfBirth = editPatientDateTimePicker.Value;

            _PatientRepository.UpdatePatient(_patient);
            foreach (var form in Application.OpenForms)
            {
                if (form is PatientsForm patientsForm)
                {
                    patientsForm.RefreshData();
                }
            }
            Close();
        }
    }
}
