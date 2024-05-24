using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_1056_HODOROAGA_IONUT.EditForms;
using _2_1056_HODOROAGA_IONUT.Entities;
using _2_1056_HODOROAGA_IONUT.Repositories;

namespace _2_1056_HODOROAGA_IONUT
{
    public partial class PatientsForm : Form
    {
      
        private int _totalCount;
        private int _currentPage = 1;
        private int _pageSize = 25;
        private int _totalPages;

        private PatientRepository _PacientRepository;

        public PatientsForm()
        {
            InitializeComponent();

            _PacientRepository = new PatientRepository();

            _totalCount = _PacientRepository.GetTotalCount();
            _totalPages = Convert.ToInt32(Math.Ceiling((double)_totalCount / _pageSize));

            totalCountTextBox.Text = _totalCount.ToString();
            currentPageTextBox.Text = $"{_currentPage} / {_totalPages}";

            EvaluateButtons();

            pacientDataGridView.AutoGenerateColumns = true;
            pacientDataGridView.DataSource = _PacientRepository.FetchData(_currentPage, _pageSize);
            CreateButtonColumn("Delete patient", "Delete", "DeletePatientColumn");
            CreateButtonColumn("Edit patient", "Edit", "EditPatientColumn");
            // CreateButtonColumn("Show prescriptions", "Prescriptions", "ViewPrescriptionsColumn");
        }

        private void CreateButtonColumn(string headerText, string buttonText, string columnName)
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.HeaderText = headerText;
            column.Text = buttonText;
            column.UseColumnTextForButtonValue = true;
            column.Name = columnName;

            pacientDataGridView.Columns.Add(column);
        }

        public void RefreshData()
        {
            pacientDataGridView.DataSource = _PacientRepository.FetchData(_currentPage, _pageSize);
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {

        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {

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

        

        private void EditPatient(Patient patient)
        {
            var editPatientForm = new EditPatientForm(patient);
            editPatientForm.MdiParent = MdiParent;
            editPatientForm.Show();
        }

        private void DeletePatient(Patient patient)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                _PacientRepository.DeletePatient(patient);
                RefreshData(); 
            }
        }

        private void pacientDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < pacientDataGridView.Rows.Count)
            {
                var columnName = ((DataGridView)sender).Columns[e.ColumnIndex].Name;
                var patient = (Patient)pacientDataGridView.Rows[e.RowIndex].DataBoundItem;

                switch (columnName)
                {
                    case "EditPatientColumn":
                        EditPatient(patient);
                        break;
                    case "DeletePatientColumn":
                        DeletePatient(patient);
                        break;
                        // case "ViewPrescriptionsColumn":
                        //   ShowPrescriptions(patient);
                        //   break;
                }
            }
        }
    }
}
