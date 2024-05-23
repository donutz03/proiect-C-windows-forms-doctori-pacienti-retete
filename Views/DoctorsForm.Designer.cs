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
            this.refreshDoctorsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // totalCountLabel
            // 
            this.totalCountLabel.AutoSize = true;
            this.totalCountLabel.Location = new System.Drawing.Point(666, 40);
            this.totalCountLabel.Name = "totalCountLabel";
            this.totalCountLabel.Size = new System.Drawing.Size(67, 15);
            this.totalCountLabel.TabIndex = 20;
            this.totalCountLabel.Text = "Total count";
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(789, 445);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(75, 23);
            this.nextPageButton.TabIndex = 19;
            this.nextPageButton.Text = "Next page";
            this.nextPageButton.UseVisualStyleBackColor = true;
            // 
            // currentPageTextBox
            // 
            this.currentPageTextBox.Enabled = false;
            this.currentPageTextBox.Location = new System.Drawing.Point(684, 450);
            this.currentPageTextBox.Name = "currentPageTextBox";
            this.currentPageTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentPageTextBox.TabIndex = 18;
            // 
            // currentPageLabel
            // 
            this.currentPageLabel.AutoSize = true;
            this.currentPageLabel.Location = new System.Drawing.Point(688, 426);
            this.currentPageLabel.Name = "currentPageLabel";
            this.currentPageLabel.Size = new System.Drawing.Size(78, 15);
            this.currentPageLabel.TabIndex = 17;
            this.currentPageLabel.Text = "Current page";
            // 
            // previousPageButton
            // 
            this.previousPageButton.Location = new System.Drawing.Point(584, 445);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(86, 23);
            this.previousPageButton.TabIndex = 16;
            this.previousPageButton.Text = "Previous page";
            this.previousPageButton.UseVisualStyleBackColor = true;
            // 
            // doctorDataGridView
            // 
            this.doctorDataGridView.AllowUserToAddRows = false;
            this.doctorDataGridView.AllowUserToDeleteRows = false;
            this.doctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorDataGridView.Location = new System.Drawing.Point(50, 49);
            this.doctorDataGridView.Name = "doctorDataGridView";
            this.doctorDataGridView.ReadOnly = true;
            this.doctorDataGridView.RowHeadersWidth = 51;
            this.doctorDataGridView.Size = new System.Drawing.Size(574, 375);
            this.doctorDataGridView.TabIndex = 15;
            // 
            // totalCountTextBox
            // 
            this.totalCountTextBox.Enabled = false;
            this.totalCountTextBox.Location = new System.Drawing.Point(745, 37);
            this.totalCountTextBox.Name = "totalCountTextBox";
            this.totalCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalCountTextBox.TabIndex = 14;
            // 
            // refreshDoctorsButton
            // 
            this.refreshDoctorsButton.Location = new System.Drawing.Point(50, 2);
            this.refreshDoctorsButton.Name = "refreshDoctorsButton";
            this.refreshDoctorsButton.Size = new System.Drawing.Size(75, 23);
            this.refreshDoctorsButton.TabIndex = 21;
            this.refreshDoctorsButton.Text = "refresh";
            this.refreshDoctorsButton.UseVisualStyleBackColor = true;
            this.refreshDoctorsButton.Click += new System.EventHandler(this.refreshDoctorsButton_Click);
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 535);
            this.Controls.Add(this.refreshDoctorsButton);
            this.Controls.Add(this.totalCountLabel);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.currentPageTextBox);
            this.Controls.Add(this.currentPageLabel);
            this.Controls.Add(this.previousPageButton);
            this.Controls.Add(this.doctorDataGridView);
            this.Controls.Add(this.totalCountTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DoctorsForm";
            this.Text = "Doctors";
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalCountLabel;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.TextBox currentPageTextBox;
        private System.Windows.Forms.Label currentPageLabel;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.DataGridView doctorDataGridView;
        private System.Windows.Forms.TextBox totalCountTextBox;
        private System.Windows.Forms.Button refreshDoctorsButton;
    }
}