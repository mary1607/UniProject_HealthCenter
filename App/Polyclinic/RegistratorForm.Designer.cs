namespace Polyclinic
{
    partial class RegistratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistratorForm));
            this.Register = new System.Windows.Forms.Button();
            this.MakeAppoinment = new System.Windows.Forms.Button();
            this.ListOfDotors = new System.Windows.Forms.Button();
            this.ListOfPatients = new System.Windows.Forms.Button();
            this.ListOfRegion = new System.Windows.Forms.Button();
            this.ReferenceBook = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Register.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Register.Location = new System.Drawing.Point(76, 102);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(141, 50);
            this.Register.TabIndex = 0;
            this.Register.Text = "Register a new patient";
            this.Register.UseVisualStyleBackColor = false;
            // 
            // MakeAppoinment
            // 
            this.MakeAppoinment.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MakeAppoinment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeAppoinment.ForeColor = System.Drawing.SystemColors.MenuText;
            this.MakeAppoinment.Location = new System.Drawing.Point(76, 32);
            this.MakeAppoinment.Name = "MakeAppoinment";
            this.MakeAppoinment.Size = new System.Drawing.Size(141, 50);
            this.MakeAppoinment.TabIndex = 1;
            this.MakeAppoinment.Text = "Make medical appointment";
            this.MakeAppoinment.UseVisualStyleBackColor = false;
            // 
            // ListOfDotors
            // 
            this.ListOfDotors.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListOfDotors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfDotors.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ListOfDotors.Location = new System.Drawing.Point(246, 32);
            this.ListOfDotors.Name = "ListOfDotors";
            this.ListOfDotors.Size = new System.Drawing.Size(141, 50);
            this.ListOfDotors.TabIndex = 2;
            this.ListOfDotors.Text = "List of doctors";
            this.ListOfDotors.UseVisualStyleBackColor = false;
            // 
            // ListOfPatients
            // 
            this.ListOfPatients.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListOfPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfPatients.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ListOfPatients.Location = new System.Drawing.Point(246, 102);
            this.ListOfPatients.Name = "ListOfPatients";
            this.ListOfPatients.Size = new System.Drawing.Size(141, 50);
            this.ListOfPatients.TabIndex = 3;
            this.ListOfPatients.Text = "List of patients";
            this.ListOfPatients.UseVisualStyleBackColor = false;
            // 
            // ListOfRegion
            // 
            this.ListOfRegion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListOfRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfRegion.Location = new System.Drawing.Point(246, 169);
            this.ListOfRegion.Name = "ListOfRegion";
            this.ListOfRegion.Size = new System.Drawing.Size(141, 50);
            this.ListOfRegion.TabIndex = 4;
            this.ListOfRegion.Text = "List of region";
            this.ListOfRegion.UseVisualStyleBackColor = false;
            // 
            // ReferenceBook
            // 
            this.ReferenceBook.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReferenceBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReferenceBook.Location = new System.Drawing.Point(76, 169);
            this.ReferenceBook.Name = "ReferenceBook";
            this.ReferenceBook.Size = new System.Drawing.Size(141, 50);
            this.ReferenceBook.TabIndex = 5;
            this.ReferenceBook.Text = "Reference book";
            this.ReferenceBook.UseVisualStyleBackColor = false;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LogOut.Location = new System.Drawing.Point(407, 248);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(91, 35);
            this.LogOut.TabIndex = 6;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // RegistratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(501, 286);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.ReferenceBook);
            this.Controls.Add(this.ListOfRegion);
            this.Controls.Add(this.ListOfPatients);
            this.Controls.Add(this.ListOfDotors);
            this.Controls.Add(this.MakeAppoinment);
            this.Controls.Add(this.Register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistratorForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMIS \"Polyclinic\"";
            this.Load += new System.EventHandler(this.RegistratorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button MakeAppoinment;
        private System.Windows.Forms.Button ListOfDotors;
        private System.Windows.Forms.Button ListOfPatients;
        private System.Windows.Forms.Button ListOfRegion;
        private System.Windows.Forms.Button ReferenceBook;
        private System.Windows.Forms.Button LogOut;
    }
}