namespace _2_1056_HODOROAGA_IONUT
{
    partial class DoctorsForm
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
            this.totalCountLabel = new System.Windows.Forms.Label();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.currentPageTextBox = new System.Windows.Forms.TextBox();
            this.currentPageLabel = new System.Windows.Forms.Label();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.doctorDataGridView = new System.Windows.Forms.DataGridView();
            this.totalCountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // totalCountLabel
            // 
            this.totalCountLabel.AutoSize = true;
            this.totalCountLabel.Location = new System.Drawing.Point(888, 49);
            this.totalCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalCountLabel.Name = "totalCountLabel";
            this.totalCountLabel.Size = new System.Drawing.Size(73, 16);
            this.totalCountLabel.TabIndex = 20;
            this.totalCountLabel.Text = "Total count";
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(1052, 548);
            this.nextPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(100, 28);
            this.nextPageButton.TabIndex = 19;
            this.nextPageButton.Text = "Next page";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // currentPageTextBox
            // 
            this.currentPageTextBox.Enabled = false;
            this.currentPageTextBox.Location = new System.Drawing.Point(912, 554);
            this.currentPageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.currentPageTextBox.Name = "currentPageTextBox";
            this.currentPageTextBox.Size = new System.Drawing.Size(132, 22);
            this.currentPageTextBox.TabIndex = 18;
            // 
            // currentPageLabel
            // 
            this.currentPageLabel.AutoSize = true;
            this.currentPageLabel.Location = new System.Drawing.Point(917, 524);
            this.currentPageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentPageLabel.Name = "currentPageLabel";
            this.currentPageLabel.Size = new System.Drawing.Size(84, 16);
            this.currentPageLabel.TabIndex = 17;
            this.currentPageLabel.Text = "Current page";
            // 
            // previousPageButton
            // 
            this.previousPageButton.Location = new System.Drawing.Point(779, 548);
            this.previousPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(115, 28);
            this.previousPageButton.TabIndex = 16;
            this.previousPageButton.Text = "Previous page";
            this.previousPageButton.UseVisualStyleBackColor = true;
            this.previousPageButton.Click += new System.EventHandler(this.previousPageButton_Click_1);
            // 
            // doctorDataGridView
            // 
            this.doctorDataGridView.AllowUserToAddRows = false;
            this.doctorDataGridView.AllowUserToDeleteRows = false;
            this.doctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorDataGridView.Location = new System.Drawing.Point(67, 60);
            this.doctorDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.doctorDataGridView.Name = "doctorDataGridView";
            this.doctorDataGridView.ReadOnly = true;
            this.doctorDataGridView.RowHeadersWidth = 51;
            this.doctorDataGridView.Size = new System.Drawing.Size(765, 462);
            this.doctorDataGridView.TabIndex = 15;
            this.doctorDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorDataGridView_CellClick);
            // 
            // totalCountTextBox
            // 
            this.totalCountTextBox.Enabled = false;
            this.totalCountTextBox.Location = new System.Drawing.Point(993, 46);
            this.totalCountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalCountTextBox.Name = "totalCountTextBox";
            this.totalCountTextBox.Size = new System.Drawing.Size(132, 22);
            this.totalCountTextBox.TabIndex = 14;
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 658);
            this.Controls.Add(this.totalCountLabel);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.currentPageTextBox);
            this.Controls.Add(this.currentPageLabel);
            this.Controls.Add(this.previousPageButton);
            this.Controls.Add(this.doctorDataGridView);
            this.Controls.Add(this.totalCountTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DoctorsForm";
            this.Text = "Doctors";
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalCountLabel;
        private System.Windows.Forms.Button nextPageButton;
        public System.Windows.Forms.TextBox currentPageTextBox;
        private System.Windows.Forms.Label currentPageLabel;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.DataGridView doctorDataGridView;
        public System.Windows.Forms.TextBox totalCountTextBox;
    }
}