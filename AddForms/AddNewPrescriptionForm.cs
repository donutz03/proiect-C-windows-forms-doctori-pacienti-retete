using _2_1056_HODOROAGA_IONUT.Entities;
using _2_1056_HODOROAGA_IONUT.Repositories;
using System;
using System.Windows.Forms;

namespace _2_1056_HODOROAGA_IONUT.AddForms
{

    public partial class AddNewPrescriptionForm : Form
    {
        PrescriptionRepository _prescriptionRepository;

        public AddNewPrescriptionForm()
        {
            InitializeComponent();
            _prescriptionRepository = new PrescriptionRepository();
        }

        private void addPrescriptionButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(prescriptionIdTb.Text);
            string patient = prescriptionPatientNameTb.Text;
            string doctor = prescriptionDoctorNameTb.Text;
            string description = prescriptionDescriptionRTB.Text;
            int doctorId = int.Parse(prescriptionDoctorIdTb.Text);
            int patientId = int.Parse(prescriptionPatientIdTb.Text);

            Prescription newPrescription = new Prescription
            {
                Id = id,
                PacientName = patient,
                DoctorName = doctor,
                IdDoctor = doctorId,
                Description = description,
                IdPacient =  patientId
            };

            _prescriptionRepository.AddPrescription(newPrescription);

            MessageBox.Show("Prescription added successfully!");
            foreach (var form in Application.OpenForms)
            {
                if (form is PrescriptionsForm prescriptionsForm)
                {
                    prescriptionsForm.RefreshData();
                }
            }
            prescriptionDoctorIdTb.Text = "";
            prescriptionIdTb.Text = "";
            prescriptionDescriptionRTB.Text = "";
            prescriptionPatientNameTb.Text = "";
            prescriptionPatientIdTb.Text = "";
            prescriptionDoctorNameTb.Text = "";
        }
    }
}
