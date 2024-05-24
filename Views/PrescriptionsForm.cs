using System;
using System.Windows.Forms;
using _2_1056_HODOROAGA_IONUT.EditForms;
using _2_1056_HODOROAGA_IONUT.Entities;
using _2_1056_HODOROAGA_IONUT.Repositories;

namespace _2_1056_HODOROAGA_IONUT
{
    public partial class PrescriptionsForm : Form
    {
       
        private int _totalCount;
        private int _currentPage = 1;
        private int _pageSize = 8;
        private int _totalPages;
        public int CurrentPage { get { return _currentPage; } set { _currentPage = value; } }
        public int PageSize { get { return _pageSize; } set { _pageSize = value; } }
        public int TotalPages { get { return _totalPages; } set { _totalPages = value; } }

        public int TotalCount { get { return _totalCount; } set { _totalCount = value; } }

        private PrescriptionRepository _PrescriptionRepository;

        public PrescriptionsForm()
        {
            InitializeComponent();

            _PrescriptionRepository = new PrescriptionRepository();

            _totalCount = _PrescriptionRepository.GetTotalCount();
            _totalPages = Convert.ToInt32(Math.Ceiling((double)_totalCount / _pageSize));

            totalCountTextBox.Text = _totalCount.ToString();
            currentPageTextBox.Text = $"{_currentPage} / {_totalPages}";

            EvaluateButtons();

            prescriptionDataGridView.AutoGenerateColumns = true;
            prescriptionDataGridView.DataSource = _PrescriptionRepository.FetchData(_currentPage, _pageSize);
            CreateButtonColumn("Delete prescription", "Delete", "DeletePrescriptionColumn");
            CreateButtonColumn("Edit prescription", "Edit", "EditPrescriptionColumn");
        
        }

        private void CreateButtonColumn(string headerText, string buttonText, string columnName)
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.HeaderText = headerText;
            column.Text = buttonText;
            column.UseColumnTextForButtonValue = true;
            column.Name = columnName;

            prescriptionDataGridView.Columns.Add(column);
        }

        public void RefreshData()
        {
            prescriptionDataGridView.DataSource = _PrescriptionRepository.FetchData(_currentPage, _pageSize);

            TotalCount = _PrescriptionRepository.GetTotalCount();
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
            }
            else
            {
                _totalPages = (_totalCount / _pageSize) + 1;
            }

            if (_totalPages == _currentPage || _totalPages == 1)
            {
                nextPageButton.Enabled = false;
            }
        }


        private void EditPrescription(Prescription prescription)
        {
            EditPrescriptionForm editPrescriptionForm = new EditPrescriptionForm(prescription);
            editPrescriptionForm.MdiParent = MdiParent;
            editPrescriptionForm.Show();
        }

        private void DeletePrescription(Prescription prescription)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to perform this action?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                _PrescriptionRepository.DeletePrescription(prescription);
                RefreshData();
            }
        }

      
        private void prescriptionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < prescriptionDataGridView.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < prescriptionDataGridView.Columns.Count)
            {
                var columnName = ((DataGridView)sender).Columns[e.ColumnIndex].Name;
                var prescription = (Prescription)prescriptionDataGridView.Rows[e.RowIndex].DataBoundItem;

                switch (columnName)
                {
                    case "EditPrescriptionColumn":
                        {
                            EditPrescription(prescription);
                            break;
                        }
                    case "DeletePrescriptionColumn":
                        {
                            DeletePrescription(prescription);
                            foreach (var form in Application.OpenForms)
                            {
                                if (form is PrescriptionsForm prescriptionsForm)
                                {
                                    prescriptionsForm.RefreshData();
                                }
                            }
                            break;
                        }
                }
            }
        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {
            _currentPage--;
            currentPageTextBox.Text = $"{_currentPage} / {_totalPages}";

            EvaluateButtons();

            prescriptionDataGridView.DataSource = _PrescriptionRepository.FetchData(_currentPage, _pageSize);
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            _currentPage++;
            currentPageTextBox.Text = $"{_currentPage} / {_totalPages}";

            EvaluateButtons();

           prescriptionDataGridView.DataSource = _PrescriptionRepository.FetchData(_currentPage, _pageSize);
        }
    }
}
