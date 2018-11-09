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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void WorkingDay_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.ShowDialog();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
