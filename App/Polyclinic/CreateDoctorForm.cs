using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class CreateDoctorForm : Form
    {
        CrudDoctor previousForm = null;
        public CreateDoctorForm(CrudDoctor doctorCrudForm)
        {
            InitializeComponent();
            previousForm = doctorCrudForm;
            FirstNameBox.Select();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            previousForm.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNo.AutoCheck)
            {
                tableLayoutPanel3.Visible = false;
            }
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYes.AutoCheck)
            {
                tableLayoutPanel3.Visible = true;
            }
        }

        private void CreateDoctorForm_Load(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
        }                

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void CreateDoctorForm_Load_1(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {            
        }

        private void RegionNumberBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void CheckTherapistBox_CheckedChanged(object sender, EventArgs e)
        {           
        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
