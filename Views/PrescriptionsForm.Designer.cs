using System.Windows.Forms;

namespace _2_1056_HODOROAGA_IONUT
{
    partial class PrescriptionsForm : Form
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
            this.prescriptionDataGridView = new System.Windows.Forms.DataGridView();
            this.totalCountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // totalCountLabel
            // 
            this.totalCountLabel.AutoSize = true;
            this.totalCountLabel.Location = new System.Drawing.Point(873, 47);
            this.totalCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalCountLabel.Name = "totalCountLabel";
            this.totalCountLabel.Size = new System.Drawing.Size(73, 16);
            this.totalCountLabel.TabIndex = 27;
            this.totalCountLabel.Text = "Total count";
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(1037, 546);
            this.nextPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(100, 28);
            this.nextPageButton.TabIndex = 26;
            this.nextPageButton.Text = "Next page";
            this.nextPageButton.UseVisualStyleBackColor = true;
            // 
            // currentPageTextBox
            // 
            this.currentPageTextBox.Enabled = false;
            this.currentPageTextBox.Location = new System.Drawing.Point(897, 552);
            this.currentPageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.currentPageTextBox.Name = "currentPageTextBox";
            this.currentPageTextBox.Size = new System.Drawing.Size(132, 22);
            this.currentPageTextBox.TabIndex = 25;
            // 
            // currentPageLabel
            // 
            this.currentPageLabel.AutoSize = true;
            this.currentPageLabel.Location = new System.Drawing.Point(903, 522);
            this.currentPageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentPageLabel.Name = "currentPageLabel";
            this.currentPageLabel.Size = new System.Drawing.Size(84, 16);
            this.currentPageLabel.TabIndex = 24;
            this.currentPageLabel.Text = "Current page";
            // 
            // previousPageButton
            // 
            this.previousPageButton.Location = new System.Drawing.Point(764, 546);
            this.previousPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(115, 28);
            this.previousPageButton.TabIndex = 23;
            this.previousPageButton.Text = "Previous page";
            this.previousPageButton.UseVisualStyleBackColor = true;
            // 
            // prescriptionDataGridView
            // 
            this.prescriptionDataGridView.AllowUserToAddRows = false;
            this.prescriptionDataGridView.AllowUserToDeleteRows = false;
            this.prescriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescriptionDataGridView.Location = new System.Drawing.Point(51, 58);
            this.prescriptionDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.prescriptionDataGridView.Name = "prescriptionDataGridView";
            this.prescriptionDataGridView.ReadOnly = true;
            this.prescriptionDataGridView.RowHeadersWidth = 51;
            this.prescriptionDataGridView.Size = new System.Drawing.Size(765, 462);
            this.prescriptionDataGridView.TabIndex = 22;
            // 
            // totalCountTextBox
            // 
            this.totalCountTextBox.Enabled = false;
            this.totalCountTextBox.Location = new System.Drawing.Point(978, 44);
            this.totalCountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalCountTextBox.Name = "totalCountTextBox";
            this.totalCountTextBox.Size = new System.Drawing.Size(132, 22);
            this.totalCountTextBox.TabIndex = 21;
            // 
            // PrescriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 622);
            this.Controls.Add(this.totalCountLabel);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.currentPageTextBox);
            this.Controls.Add(this.currentPageLabel);
            this.Controls.Add(this.previousPageButton);
            this.Controls.Add(this.prescriptionDataGridView);
            this.Controls.Add(this.totalCountTextBox);
            this.Name = "PrescriptionsForm";
            this.Text = "Retete";
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalCountLabel;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.TextBox currentPageTextBox;
        private System.Windows.Forms.Label currentPageLabel;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.DataGridView prescriptionDataGridView;
        private System.Windows.Forms.TextBox totalCountTextBox;
    }
}