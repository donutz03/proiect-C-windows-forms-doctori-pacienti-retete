namespace _2_1056_HODOROAGA_IONUT.EditForms
{
    partial class EditPatientForm
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
            this.updatePatientNameTb = new System.Windows.Forms.TextBox();
            this.updatePatientIdTb = new System.Windows.Forms.TextBox();
            this.updateDateOfBirthPatientLabel = new System.Windows.Forms.Label();
            this.updatePacientNameLabel = new System.Windows.Forms.Label();
            this.updatePatientIdLabel = new System.Windows.Forms.Label();
            this.updatePatientButton = new System.Windows.Forms.Button();
            this.editPatientDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // updatePatientNameTb
            // 
            this.updatePatientNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientNameTb.Location = new System.Drawing.Point(288, 134);
            this.updatePatientNameTb.Name = "updatePatientNameTb";
            this.updatePatientNameTb.Size = new System.Drawing.Size(275, 26);
            this.updatePatientNameTb.TabIndex = 30;
            // 
            // updatePatientIdTb
            // 
            this.updatePatientIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientIdTb.Location = new System.Drawing.Point(288, 88);
            this.updatePatientIdTb.Name = "updatePatientIdTb";
            this.updatePatientIdTb.Size = new System.Drawing.Size(275, 26);
            this.updatePatientIdTb.TabIndex = 29;
            // 
            // updateDateOfBirthPatientLabel
            // 
            this.updateDateOfBirthPatientLabel.AutoSize = true;
            this.updateDateOfBirthPatientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDateOfBirthPatientLabel.Location = new System.Drawing.Point(180, 194);
            this.updateDateOfBirthPatientLabel.Name = "updateDateOfBirthPatientLabel";
            this.updateDateOfBirthPatientLabel.Size = new System.Drawing.Size(102, 20);
            this.updateDateOfBirthPatientLabel.TabIndex = 28;
            this.updateDateOfBirthPatientLabel.Text = "Date of birth";
            // 
            // updatePacientNameLabel
            // 
            this.updatePacientNameLabel.AutoSize = true;
            this.updatePacientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePacientNameLabel.Location = new System.Drawing.Point(180, 140);
            this.updatePacientNameLabel.Name = "updatePacientNameLabel";
            this.updatePacientNameLabel.Size = new System.Drawing.Size(53, 20);
            this.updatePacientNameLabel.TabIndex = 27;
            this.updatePacientNameLabel.Text = "Name";
            // 
            // updatePatientIdLabel
            // 
            this.updatePatientIdLabel.AutoSize = true;
            this.updatePatientIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientIdLabel.Location = new System.Drawing.Point(180, 88);
            this.updatePatientIdLabel.Name = "updatePatientIdLabel";
            this.updatePatientIdLabel.Size = new System.Drawing.Size(22, 20);
            this.updatePatientIdLabel.TabIndex = 26;
            this.updatePatientIdLabel.Text = "Id";
            // 
            // updatePatientButton
            // 
            this.updatePatientButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updatePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientButton.Location = new System.Drawing.Point(336, 256);
            this.updatePatientButton.Name = "updatePatientButton";
            this.updatePatientButton.Size = new System.Drawing.Size(173, 88);
            this.updatePatientButton.TabIndex = 25;
            this.updatePatientButton.Text = "Actualizeaza";
            this.updatePatientButton.UseVisualStyleBackColor = false;
            this.updatePatientButton.Click += new System.EventHandler(this.updatePatientButton_Click);
            // 
            // editPatientDateTimePicker
            // 
            this.editPatientDateTimePicker.Location = new System.Drawing.Point(288, 194);
            this.editPatientDateTimePicker.Name = "editPatientDateTimePicker";
            this.editPatientDateTimePicker.Size = new System.Drawing.Size(275, 22);
            this.editPatientDateTimePicker.TabIndex = 31;
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editPatientDateTimePicker);
            this.Controls.Add(this.updatePatientNameTb);
            this.Controls.Add(this.updatePatientIdTb);
            this.Controls.Add(this.updateDateOfBirthPatientLabel);
            this.Controls.Add(this.updatePacientNameLabel);
            this.Controls.Add(this.updatePatientIdLabel);
            this.Controls.Add(this.updatePatientButton);
            this.Name = "EditPatientForm";
            this.Text = "Edit Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox updatePatientNameTb;
        private System.Windows.Forms.TextBox updatePatientIdTb;
        private System.Windows.Forms.Label updateDateOfBirthPatientLabel;
        private System.Windows.Forms.Label updatePacientNameLabel;
        private System.Windows.Forms.Label updatePatientIdLabel;
        private System.Windows.Forms.Button updatePatientButton;
        private System.Windows.Forms.DateTimePicker editPatientDateTimePicker;
    }
}