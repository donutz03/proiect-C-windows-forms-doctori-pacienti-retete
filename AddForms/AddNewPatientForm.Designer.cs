namespace _2_1056_HODOROAGA_IONUT.AddForms
{
    partial class AddNewPatientForm
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
            this.patientDateOfBirthTb = new System.Windows.Forms.TextBox();
            this.patientNameTb = new System.Windows.Forms.TextBox();
            this.patientIdTb = new System.Windows.Forms.TextBox();
            this.dateOfBirthPatientLabel = new System.Windows.Forms.Label();
            this.pacientNameLabel = new System.Windows.Forms.Label();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientDateOfBirthTb
            // 
            this.patientDateOfBirthTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthTb.Location = new System.Drawing.Point(317, 168);
            this.patientDateOfBirthTb.Name = "patientDateOfBirthTb";
            this.patientDateOfBirthTb.Size = new System.Drawing.Size(275, 26);
            this.patientDateOfBirthTb.TabIndex = 24;
            // 
            // patientNameTb
            // 
            this.patientNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameTb.Location = new System.Drawing.Point(317, 114);
            this.patientNameTb.Name = "patientNameTb";
            this.patientNameTb.Size = new System.Drawing.Size(275, 26);
            this.patientNameTb.TabIndex = 23;
            // 
            // patientIdTb
            // 
            this.patientIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdTb.Location = new System.Drawing.Point(317, 68);
            this.patientIdTb.Name = "patientIdTb";
            this.patientIdTb.Size = new System.Drawing.Size(275, 26);
            this.patientIdTb.TabIndex = 22;
            // 
            // dateOfBirthPatientLabel
            // 
            this.dateOfBirthPatientLabel.AutoSize = true;
            this.dateOfBirthPatientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthPatientLabel.Location = new System.Drawing.Point(209, 174);
            this.dateOfBirthPatientLabel.Name = "dateOfBirthPatientLabel";
            this.dateOfBirthPatientLabel.Size = new System.Drawing.Size(102, 20);
            this.dateOfBirthPatientLabel.TabIndex = 20;
            this.dateOfBirthPatientLabel.Text = "Date of birth";
            // 
            // pacientNameLabel
            // 
            this.pacientNameLabel.AutoSize = true;
            this.pacientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacientNameLabel.Location = new System.Drawing.Point(209, 120);
            this.pacientNameLabel.Name = "pacientNameLabel";
            this.pacientNameLabel.Size = new System.Drawing.Size(53, 20);
            this.pacientNameLabel.TabIndex = 19;
            this.pacientNameLabel.Text = "Name";
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdLabel.Location = new System.Drawing.Point(209, 68);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(22, 20);
            this.patientIdLabel.TabIndex = 18;
            this.patientIdLabel.Text = "Id";
            // 
            // addPatientButton
            // 
            this.addPatientButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientButton.Location = new System.Drawing.Point(365, 236);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(173, 88);
            this.addPatientButton.TabIndex = 17;
            this.addPatientButton.Text = "Adauga";
            this.addPatientButton.UseVisualStyleBackColor = false;
            // 
            // AddNewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 471);
            this.Controls.Add(this.patientDateOfBirthTb);
            this.Controls.Add(this.patientNameTb);
            this.Controls.Add(this.patientIdTb);
            this.Controls.Add(this.dateOfBirthPatientLabel);
            this.Controls.Add(this.pacientNameLabel);
            this.Controls.Add(this.patientIdLabel);
            this.Controls.Add(this.addPatientButton);
            this.Name = "AddNewPatientForm";
            this.Text = "Add a new patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox patientDateOfBirthTb;
        private System.Windows.Forms.TextBox patientNameTb;
        private System.Windows.Forms.TextBox patientIdTb;
        private System.Windows.Forms.Label dateOfBirthPatientLabel;
        private System.Windows.Forms.Label pacientNameLabel;
        private System.Windows.Forms.Label patientIdLabel;
        private System.Windows.Forms.Button addPatientButton;
    }
}