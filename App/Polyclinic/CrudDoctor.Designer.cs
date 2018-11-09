namespace Polyclinic
{
    partial class CrudDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudDoctor));
            this.Delete = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Location = new System.Drawing.Point(47, 160);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(61, 58);
            this.Delete.TabIndex = 0;
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // New
            // 
            this.New.Image = ((System.Drawing.Image)(resources.GetObject("New.Image")));
            this.New.Location = new System.Drawing.Point(47, 31);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(59, 59);
            this.New.TabIndex = 1;
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Update
            // 
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.Location = new System.Drawing.Point(47, 96);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(59, 58);
            this.Update.TabIndex = 2;
            this.Update.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(134, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "New";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(134, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(134, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delete";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(221, 226);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(61, 35);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // CrudDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Delete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrudDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMIS \"Polyclinic\"";
            this.Load += new System.EventHandler(this.CrudDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Back;
    }
}