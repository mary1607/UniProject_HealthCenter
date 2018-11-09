using System;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class LogInForm : Form
    {
        string adminLogin = "Admin";
        string adminPassword ="1234";

        string registretorLogin = "Receptionist";
        string registretorPassword = "0123";

        string doctorLogin = "Doctor";
        string doctorPassword = "2345";

        public LogInForm()
        {
            InitializeComponent();
            LoginBox.Select();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text == adminPassword && LoginBox.Text == adminLogin)
            {
                Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
                Close();
            }
            else if (PasswordBox.Text == registretorPassword && LoginBox.Text == registretorLogin)
            {
                Hide();
                RegistratorForm registratorForm = new RegistratorForm();
                registratorForm.ShowDialog();
                Close();
            }
            else if (PasswordBox.Text == doctorPassword && LoginBox.Text == doctorLogin)
            {
                Hide();
                DoctorForm doctorForm = new DoctorForm();
                doctorForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong login or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginBox.Text = string.Empty;
                PasswordBox.Text = string.Empty;
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
        }
    }
}
