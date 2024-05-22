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

namespace _2_1056_HODOROAGA_IONUT
{
    public partial class DoctorsForm : Form
    {
        private int _totalCount;
        private int _currentPage = 1;
        private int _pageSize = 25;
        private int _totalPages;

        private DoctorRepository _DoctorRepository;

        public DoctorsForm()
        {
            InitializeComponent();

            _DoctorRepository = new DoctorRepository();

            _totalCount = _DoctorRepository.GetTotalCount();
            _totalPages = Convert.ToInt32(Math.Ceiling((double)_totalCount / _pageSize));

            totalCountTextBox.Text = _totalCount.ToString();
            currentPageTextBox.Text = $"{_currentPage} / {_totalPages}";

            EvaluateButtons();

            doctorDataGridView.AutoGenerateColumns = true;
            doctorDataGridView.DataSource = _DoctorRepository.FetchData(_currentPage, _pageSize);
            CreateButtonColumn("Delete doctor", "Delete", "DeleteColumn");
            CreateButtonColumn("Edit doctor", "Edit", "EditColumn");
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
    }
}
