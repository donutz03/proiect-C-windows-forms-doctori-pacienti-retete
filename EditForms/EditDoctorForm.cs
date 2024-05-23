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

namespace _2_1056_HODOROAGA_IONUT.EditForms
{
    public partial class EditDoctorForm : Form
    {
        private DoctorRepository _DoctorRepository;
        private Doctor _doctor;

        public EditDoctorForm(Doctor doctor)
        {
            InitializeComponent();
            _doctor = doctor;
            _DoctorRepository = new DoctorRepository();
            editDoctorIdTb.ReadOnly = true;
            editDoctorIdTb.Text = _doctor.Id.ToString();
            editDoctorNameTb.Text = _doctor.Name;
            editDoctorPositionTb.Text = _doctor.Position;
            editDoctorDepartmentTb.Text = _doctor.Department;
        }

        private void EditDoctorButton_Click(object sender, EventArgs e)
        {
                _doctor.Name = editDoctorNameTb.Text;
                _doctor.Position = editDoctorPositionTb.Text;
                _doctor.Department = editDoctorDepartmentTb.Text;
                _doctor.Id = int.Parse(editDoctorIdTb.Text);
                _DoctorRepository.UpdateDoctor(_doctor);
                foreach (var form in Application.OpenForms)
                {
                    if (form is DoctorsForm doctorsForm)
                    {
                        doctorsForm.RefreshData();
                    }
                }
                Close();
           
        }
    }
}
