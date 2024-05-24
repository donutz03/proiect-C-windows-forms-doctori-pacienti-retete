using _2_1056_HODOROAGA_IONUT.EditForms;
using _2_1056_HODOROAGA_IONUT.Entities;
using _2_1056_HODOROAGA_IONUT.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _2_1056_HODOROAGA_IONUT
{
    public partial class DoctorsForm : Form
    {
        private int _totalCount;
        private int _currentPage = 1;
        private int _pageSize = 8;
        private int _totalPages;

        private DoctorRepository _DoctorRepository;
        private PrescriptionRepository _PrescriptionRepository;


        public DoctorsForm()
        {
            InitializeComponent();

            _DoctorRepository = new DoctorRepository();
            _PrescriptionRepository = new PrescriptionRepository();

            _totalCount = _DoctorRepository.GetTotalCount();
            _totalPages = Convert.ToInt32(Math.Ceiling((double)_totalCount / _pageSize));

            totalCountTextBox.Text = _totalCount.ToString();
            currentPageTextBox.Text = $"{_currentPage} / {_totalPages}";

            EvaluateButtons();

            doctorDataGridView.AutoGenerateColumns = true;
            doctorDataGridView.DataSource = _DoctorRepository.FetchData(_currentPage, _pageSize);
            CreateButtonColumn("Delete doctor", "Delete", "DeleteDoctorColumn");
            CreateButtonColumn("Edit doctor", "Edit", "EditDoctorColumn");
            CreateButtonColumn("Show patients", "Patients", "ViewPatientsColumn");

        }

        private void CreateButtonColumn(string headerText, string buttonText, string columnName)
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.HeaderText = headerText;
            column.Text = buttonText;
            column.UseColumnTextForButtonValue = true;
            column.Name = columnName;

            doctorDataGridView.Columns.Add(column);
        }



        public void RefreshData()
        {
            doctorDataGridView.DataSource = _DoctorRepository.FetchData(_currentPage, _pageSize);
        }

     

        private void EvaluateButtons()
        {
            previousPageButton.Enabled = true;
            nextPageButton.Enabled = true;
            if (_currentPage == 1)
            {
                previousPageButton.Enabled = false;
            }
            if (_currentPage == _totalPages)
            {
                nextPageButton.Enabled = false;
            }
        }

        private void EditDoctor(Doctor doctor)
        {
            var editDoctorForm = new EditDoctorForm(doctor);
            editDoctorForm.MdiParent = MdiParent;
            editDoctorForm.Show();
        }

        private void DeleteDoctor(Doctor doctor)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to perform this action?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                _DoctorRepository.DeleteDoctor(doctor);
            }
        }


        private void doctorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < doctorDataGridView.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < doctorDataGridView.Columns.Count)
            {
                var columnName = ((DataGridView)sender).Columns[e.ColumnIndex].Name;
                var doctor = (Doctor)doctorDataGridView.Rows[e.RowIndex].DataBoundItem;

                switch (columnName)
                {
                    case "EditDoctorColumn":
                        {
                            EditDoctor(doctor);
                            break;
                        }
                    case "DeleteDoctorColumn":
                        {
                            DeleteDoctor(doctor);
                            foreach (var form in Application.OpenForms)
                            {
                                if (form is DoctorsForm doctorsForm)
                                {
                                    doctorsForm.RefreshData();
                                }
                            }
                            break;
                        }
                    case "ViewPatientsColumn":
                        
                        ShowPatients(doctor);
                        break;
                }
            }
        }

        private void ShowPatients(Doctor doctor)
        {
            List<Patient> patients = _PrescriptionRepository.GetPatientsByDoctorId(doctor);
            if (patients.Count > 0) { 
            string patientList = string.Join(Environment.NewLine, patients.Select(p => $"{p.Name} (DOB: {p.DateOfBirth.ToShortDateString()})"));

            MessageBox.Show(patientList, "Patients of Dr. " + doctor.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doctorul " + doctor.Name + " nu are pacienti!", "Lipsa pacienti", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void previousPageButton_Click_1(object sender, EventArgs e)
        {
            _currentPage--;
            currentPageTextBox.Text = $"{_currentPage} / {_totalPages}";

            EvaluateButtons();

            doctorDataGridView.DataSource = _DoctorRepository.FetchData(_currentPage, _pageSize);
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            _currentPage++;
            currentPageTextBox.Text = $"{_currentPage} / {_totalPages}";

            EvaluateButtons();

            doctorDataGridView.DataSource = _DoctorRepository.FetchData(_currentPage, _pageSize);
        }
    }
}
