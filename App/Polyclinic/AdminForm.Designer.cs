namespace Polyclinic
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.CRUDOfDoctor = new System.Windows.Forms.Button();
            this.CRUDOfRegister = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CRUDOfDoctor
            // 
            this.CRUDOfDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CRUDOfDoctor.Location = new System.Drawing.Point(132, 56);
            this.CRUDOfDoctor.Name = "CRUDOfDoctor";
            this.CRUDOfDoctor.Size = new System.Drawing.Size(171, 49);
            this.CRUDOfDoctor.TabIndex = 0;
            this.CRUDOfDoctor.Text = "CRUD of doctor";
            this.CRUDOfDoctor.UseVisualStyleBackColor = true;
            this.CRUDOfDoctor.Click += new System.EventHandler(this.CRUDOfDoctor_Click);
            // 
            // CRUDOfRegister
            // 
            this.CRUDOfRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CRUDOfRegister.Location = new System.Drawing.Point(132, 132);
            this.CRUDOfRegister.Name = "CRUDOfRegister";
            this.CRUDOfRegister.Size = new System.Drawing.Size(171, 52);
            this.CRUDOfRegister.TabIndex = 1;
            this.CRUDOfRegister.Text = "CRUD of receptionist";
            this.CRUDOfRegister.UseVisualStyleBackColor = true;
            this.CRUDOfRegister.Click += new System.EventHandler(this.CRUDOfRegister_Click);
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOut.Location = new System.Drawing.Point(158, 199);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(120, 50);
            this.LogOut.TabIndex = 2;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // AdminForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(425, 270);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.CRUDOfRegister);
            this.Controls.Add(this.CRUDOfDoctor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMIS \"Polyclinic\"";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CRUDOfDoctor;
        private System.Windows.Forms.Button CRUDOfRegister;
        private System.Windows.Forms.Button LogOut;
    }
}