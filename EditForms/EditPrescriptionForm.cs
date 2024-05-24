using _2_1056_HODOROAGA_IONUT.Entities;
using _2_1056_HODOROAGA_IONUT.Repositories;
using System;
using System.Windows.Forms;

namespace _2_1056_HODOROAGA_IONUT.EditForms
{
    public partial class EditPrescriptionForm : Form
    {
        private Prescription _prescription;
        private PrescriptionRepository _PrescriptionRepository;

        public EditPrescriptionForm(Prescription prescription)
        {
            InitializeComponent();
            _prescription = prescription;
            _PrescriptionRepository = new PrescriptionRepository();
            editPrescriptionIdTb.ReadOnly = true;
            editPrescriptionIdTb.Text = _prescription.Id.ToString();
            editPrescriptionDescriptionRTB.Text = _prescription.Description;
            editPrescriptionPatientIdTb.Text = _prescription.IdPacient.ToString();
            editPrescriptionDoctorIdTb.Text = _prescription.IdDoctor.ToString();
            editPrescriptionPatientNameTb.Text = _prescription.PacientName;
            editPrescriptionDoctorNameTb.Text = _prescription.DoctorName;
        }

        private void editPrescriptionButton_Click(object sender, EventArgs e)
        {
            _prescription.Description = editPrescriptionDescriptionRTB.Text;
            _prescription.IdPacient = int.Parse(editPrescriptionPatientIdTb.Text);
            _prescription.IdDoctor = int.Parse(editPrescriptionDoctorIdTb.Text);
            _prescription.PacientName = editPrescriptionPatientNameTb.Text;
            _prescription.DoctorName = editPrescriptionDoctorNameTb.Text;

            _PrescriptionRepository.UpdatePrescription(_prescription);


            foreach (var form in Application.OpenForms)
            {
                if (form is PrescriptionsForm prescriptionsForm)
                {
                    prescriptionsForm.RefreshData();
                }
            }

            Close();
        }
    }
}
