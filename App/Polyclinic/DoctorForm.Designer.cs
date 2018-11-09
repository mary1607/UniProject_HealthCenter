namespace Polyclinic
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.WorkingDay = new System.Windows.Forms.Button();
            this.ReferenceBook = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.PatientFiles = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WorkingDay
            // 
            this.WorkingDay.BackColor = System.Drawing.Color.LightGreen;
            this.WorkingDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WorkingDay.ForeColor = System.Drawing.SystemColors.Desktop;
            this.WorkingDay.Location = new System.Drawing.Point(52, 33);
            this.WorkingDay.Name = "WorkingDay";
            this.WorkingDay.Size = new System.Drawing.Size(138, 61);
            this.WorkingDay.TabIndex = 0;
            this.WorkingDay.Text = "Start your working day";
            this.WorkingDay.UseVisualStyleBackColor = false;
            this.WorkingDay.Click += new System.EventHandler(this.WorkingDay_Click);
            // 
            // ReferenceBook
            // 
            this.ReferenceBook.BackColor = System.Drawing.Color.LightGreen;
            this.ReferenceBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReferenceBook.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ReferenceBook.Location = new System.Drawing.Point(52, 137);
            this.ReferenceBook.Name = "ReferenceBook";
            this.ReferenceBook.Size = new System.Drawing.Size(138, 62);
            this.ReferenceBook.TabIndex = 1;
            this.ReferenceBook.Text = "Reference book";
            this.ReferenceBook.UseVisualStyleBackColor = false;
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.Color.LightGreen;
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Report.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Report.Location = new System.Drawing.Point(242, 33);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(133, 61);
            this.Report.TabIndex = 2;
            this.Report.Text = "Submit a record";
            this.Report.UseVisualStyleBackColor = false;
            this.Report.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatientFiles
            // 
            this.PatientFiles.BackColor = System.Drawing.Color.LightGreen;
            this.PatientFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PatientFiles.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PatientFiles.Location = new System.Drawing.Point(242, 137);
            this.PatientFiles.Name = "PatientFiles";
            this.PatientFiles.Size = new System.Drawing.Size(133, 61);
            this.PatientFiles.TabIndex = 3;
            this.PatientFiles.Text = "Patients\' files";
            this.PatientFiles.UseVisualStyleBackColor = false;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOut.ForeColor = System.Drawing.Color.DarkGreen;
            this.LogOut.Location = new System.Drawing.Point(380, 241);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(98, 39);
            this.LogOut.TabIndex = 4;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(479, 280);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.PatientFiles);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.ReferenceBook);
            this.Controls.Add(this.WorkingDay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMIS \"Polyclinic\"";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WorkingDay;
        private System.Windows.Forms.Button ReferenceBook;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button PatientFiles;
        private System.Windows.Forms.Button LogOut;
    }
}