using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_1056_HODOROAGA_IONUT.Repositories;

namespace _2_1056_HODOROAGA_IONUT
{
    public partial class PrescriptionsForm : Form
    {
        /*public Form1()
        {
            InitializeComponent();
        }*/
        private int _totalCount;
        private int _currentPage = 1;
        private int _pageSize = 25;
        private int _totalPages;

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
