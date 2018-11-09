using System;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void CRUDOfDoctor_Click(object sender, EventArgs e)
        {
            Hide();
            CrudDoctor crudDoctorForm = new CrudDoctor(this);
            crudDoctorForm.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AdminFormClosing(Object sender, FormClosingEventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.ShowDialog();
        }

        private void CRUDOfRegister_Click(object sender, EventArgs e)
        {
            Hide();
            CrudReceptionist crudReceptionistForm = new CrudReceptionist(this);
            crudReceptionistForm.ShowDialog();
        }
    }
}
