namespace _2_1056_HODOROAGA_IONUT
{
    partial class SchemaForm
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
            this.schemaPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.schemaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // schemaPictureBox
            // 
            this.schemaPictureBox.Image = global::_2_1056_HODOROAGA_IONUT.Properties.Resources.schemaPAW;
            this.schemaPictureBox.Location = new System.Drawing.Point(12, 12);
            this.schemaPictureBox.Name = "schemaPictureBox";
            this.schemaPictureBox.Size = new System.Drawing.Size(1282, 572);
            this.schemaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.schemaPictureBox.TabIndex = 0;
            this.schemaPictureBox.TabStop = false;
            // 
            // SchemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 600);
            this.Controls.Add(this.schemaPictureBox);
            this.Name = "SchemaForm";
            this.Text = "SchemaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SchemaForm_FormClosing);
            this.Load += new System.EventHandler(this.SchemaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schemaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox schemaPictureBox;
    }
}