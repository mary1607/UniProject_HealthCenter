namespace Polyclinic
{
    partial class CreateReceptionistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateReceptionistForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Patronymic = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.07692F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.92308F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.FirstName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Patronymic, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.79365F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 91);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 34);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 66);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(232, 22);
            this.textBox3.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FirstName.Location = new System.Drawing.Point(3, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(90, 20);
            this.FirstName.TabIndex = 3;
            this.FirstName.Text = "First Name:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LastName.Location = new System.Drawing.Point(3, 31);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(88, 20);
            this.LastName.TabIndex = 4;
            this.LastName.Text = "Last name:";
            // 
            // Patronymic
            // 
            this.Patronymic.AutoSize = true;
            this.Patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Patronymic.Location = new System.Drawing.Point(3, 63);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(91, 20);
            this.Patronymic.TabIndex = 5;
            this.Patronymic.Text = "Patronymic:";
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Create.Location = new System.Drawing.Point(335, 196);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(90, 29);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Back.Location = new System.Drawing.Point(26, 265);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(84, 27);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // CreateReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(459, 304);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateReceptionistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateReceptionistForm";
            this.Load += new System.EventHandler(this.CreateReceptionistForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Patronymic;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Back;
    }
}