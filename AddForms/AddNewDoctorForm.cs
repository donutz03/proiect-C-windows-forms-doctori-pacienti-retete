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
using System.Xml.Linq;

namespace _2_1056_HODOROAGA_IONUT.AddForms
{

    public partial class AddNewDoctorForm : Form
    {

        private DoctorRepository _DoctorRepository;

        public AddNewDoctorForm()
        {
            InitializeComponent();
            _DoctorRepository = new DoctorRepository();
        }

        private void addDoctorButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(doctorIdTb.Text);
            string name = doctorNameTb.Text;
            string position = doctorPositionTb.Text;
            string department = doctorDepartmentTb.Text;

            Doctor newDoctor = new Doctor
            {
                Id = id,
                Name = name,
                Position = position,
                Department = department
            };

            _DoctorRepository.AddDoctor(newDoctor);

            MessageBox.Show("Doctor added successfully!");
            foreach (var form in Application.OpenForms)
            {
                if (form is DoctorsForm doctorsForm)
                {
                    doctorsForm.RefreshData();
                }
            }
            doctorIdTb.Text = "";
            doctorNameTb.Text = "";
            doctorPositionTb.Text = "";
            doctorDepartmentTb.Text = "";

        }
      
    }
}
