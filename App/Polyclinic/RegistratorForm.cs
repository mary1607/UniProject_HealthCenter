using System;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class RegistratorForm : Form
    {
        public RegistratorForm()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {           
        }

        private void RegistratorForm_Load(object sender, EventArgs e)
        {
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.ShowDialog();
        }
    }
}
