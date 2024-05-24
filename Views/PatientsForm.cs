using System;
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
        private int _pageSize = 8;
        private int _totalPages;
        public int CurrentPage { get { return _currentPage; } set { _currentPage = value; } }
        public int PageSize { get { return _pageSize; } set { _pageSize = value; } }
        public int TotalPages { get { return _totalPages; } set { _totalPages = value; } }

        public int TotalCount { get { return _totalCount; } set { _totalCount = value; } }
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
            
            TotalCount = _PacientRepository.GetTotalCount();
            totalCountTextBox.Text = _totalCount.ToString();
            if (_totalCount % _pageSize == 0)
            {
                _totalPages = _totalCount / _pageSize;
            }
            else
            {
                _totalPages = (_totalCount / _pageSize) + 1;
            }
            currentPageTextBox.Text = $"{_currentPage} / {_totalPages}";
            EvaluateButtons();
        }


        private void EvaluateButtons()
        {
            previousPageButton.Enabled = true;
            nextPageButton.Enabled = true;
            if (_currentPage == 1)
            {
                previousPageButton.Enabled = false;
            }
            if (_totalCount % _pageSize == 0)
            {
               _totalPages = _totalCount / _pageSize;
            } else
            {
                _totalPages = (_totalCount / _pageSize) + 1;
            }

            if (_totalPages== _currentPage || _totalPages ==1)
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
                //RefreshData(); 
            }
        }

        private void pacientDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < pacientDataGridView.Rows.Count && e.ColumnIndex >=0 && e.ColumnIndex < pacientDataGridView.Columns.Count)
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
                        foreach (var form in Application.OpenForms)
                        {
                            if (form is PatientsForm patientsForm)
                            {
                                patientsForm.RefreshData();
                            }
                        }
                        break;
                }
            }
        }

        public void previousPageButton_Click(object sender, EventArgs e)
        {
            _currentPage--;
            currentPageTextBox.Text = $"{_currentPage} / {_totalPages}";

            EvaluateButtons();

            pacientDataGridView.DataSource = _PacientRepository.FetchData(_currentPage, _pageSize);
        }

        public void nextPageButton_Click(object sender, EventArgs e)
        {
            _currentPage++;
            currentPageTextBox.Text = $"{_currentPage} / {_totalPages}";

            EvaluateButtons();

            pacientDataGridView.DataSource = _PacientRepository.FetchData(_currentPage, _pageSize);
        }
    }
}
