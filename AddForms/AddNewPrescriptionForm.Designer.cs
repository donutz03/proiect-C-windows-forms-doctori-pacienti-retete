namespace _2_1056_HODOROAGA_IONUT.AddForms
{
    partial class AddNewPrescriptionForm
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
            this.addPrescriptionButton = new System.Windows.Forms.Button();
            this.prescriptionIdLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // addPrescriptionButton
            // 
            this.addPrescriptionButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addPrescriptionButton.Location = new System.Drawing.Point(347, 443);
            this.addPrescriptionButton.Name = "addPrescriptionButton";
            this.addPrescriptionButton.Size = new System.Drawing.Size(173, 88);
            this.addPrescriptionButton.TabIndex = 0;
            this.addPrescriptionButton.Text = "Adauga";
            this.addPrescriptionButton.UseVisualStyleBackColor = false;
            // 
            // prescriptionIdLabel
            // 
            this.prescriptionIdLabel.AutoSize = true;
            this.prescriptionIdLabel.Location = new System.Drawing.Point(115, 69);
            this.prescriptionIdLabel.Name = "prescriptionIdLabel";
            this.prescriptionIdLabel.Size = new System.Drawing.Size(18, 16);
            this.prescriptionIdLabel.TabIndex = 1;
            this.prescriptionIdLabel.Text = "Id";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(115, 114);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(109, 16);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Descriere Reteta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(257, 114);
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(348, 153);
            this.descriptionTB.TabIndex = 7;
            this.descriptionTB.Text = "";
            // 
            // AddNewPrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 658);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.prescriptionIdLabel);
            this.Controls.Add(this.addPrescriptionButton);
            this.Name = "AddNewPrescriptionForm";
            this.Text = "Add a new prescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPrescriptionButton;
        private System.Windows.Forms.Label prescriptionIdLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox descriptionTB;
    }
}