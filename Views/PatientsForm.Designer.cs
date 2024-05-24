using System.Windows.Forms;

namespace _2_1056_HODOROAGA_IONUT
{
    partial class PatientsForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.totalCountTextBox = new System.Windows.Forms.TextBox();
            this.pacientDataGridView = new System.Windows.Forms.DataGridView();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.currentPageLabel = new System.Windows.Forms.Label();
            this.currentPageTextBox = new System.Windows.Forms.TextBox();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.totalCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // totalCountTextBox
            // 
            this.totalCountTextBox.Enabled = false;
            this.totalCountTextBox.Location = new System.Drawing.Point(1031, 34);
            this.totalCountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalCountTextBox.Name = "totalCountTextBox";
            this.totalCountTextBox.Size = new System.Drawing.Size(132, 22);
            this.totalCountTextBox.TabIndex = 3;
            // 
            // pacientDataGridView
            // 
            this.pacientDataGridView.AllowUserToAddRows = false;
            this.pacientDataGridView.AllowUserToDeleteRows = false;
            this.pacientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacientDataGridView.Location = new System.Drawing.Point(104, 48);
            this.pacientDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.pacientDataGridView.Name = "pacientDataGridView";
            this.pacientDataGridView.ReadOnly = true;
            this.pacientDataGridView.RowHeadersWidth = 51;
            this.pacientDataGridView.Size = new System.Drawing.Size(765, 462);
            this.pacientDataGridView.TabIndex = 4;
            this.pacientDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientDataGridView_CellClick_1);
            // 
            // previousPageButton
            // 
            this.previousPageButton.Location = new System.Drawing.Point(817, 536);
            this.previousPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(115, 28);
            this.previousPageButton.TabIndex = 9;
            this.previousPageButton.Text = "Previous page";
            this.previousPageButton.UseVisualStyleBackColor = true;
            this.previousPageButton.Click += new System.EventHandler(this.previousPageButton_Click_1);
            // 
            // currentPageLabel
            // 
            this.currentPageLabel.AutoSize = true;
            this.currentPageLabel.Location = new System.Drawing.Point(956, 512);
            this.currentPageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentPageLabel.Name = "currentPageLabel";
            this.currentPageLabel.Size = new System.Drawing.Size(84, 16);
            this.currentPageLabel.TabIndex = 10;
            this.currentPageLabel.Text = "Current page";
            // 
            // currentPageTextBox
            // 
            this.currentPageTextBox.Enabled = false;
            this.currentPageTextBox.Location = new System.Drawing.Point(950, 542);
            this.currentPageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.currentPageTextBox.Name = "currentPageTextBox";
            this.currentPageTextBox.Size = new System.Drawing.Size(132, 22);
            this.currentPageTextBox.TabIndex = 11;
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(1090, 536);
            this.nextPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(100, 28);
            this.nextPageButton.TabIndex = 12;
            this.nextPageButton.Text = "Next page";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // totalCountLabel
            // 
            this.totalCountLabel.AutoSize = true;
            this.totalCountLabel.Location = new System.Drawing.Point(926, 37);
            this.totalCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalCountLabel.Name = "totalCountLabel";
            this.totalCountLabel.Size = new System.Drawing.Size(73, 16);
            this.totalCountLabel.TabIndex = 13;
            this.totalCountLabel.Text = "Total count";
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 588);
            this.Controls.Add(this.totalCountLabel);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.currentPageTextBox);
            this.Controls.Add(this.currentPageLabel);
            this.Controls.Add(this.previousPageButton);
            this.Controls.Add(this.pacientDataGridView);
            this.Controls.Add(this.totalCountTextBox);
            this.Name = "PatientsForm";
            this.Text = "Patients";
            ((System.ComponentModel.ISupportInitialize)(this.pacientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalCountTextBox;
        private System.Windows.Forms.DataGridView pacientDataGridView;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.Label currentPageLabel;
        private System.Windows.Forms.TextBox currentPageTextBox;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Label totalCountLabel;
    }
}

