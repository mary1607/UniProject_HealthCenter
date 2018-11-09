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
    public partial class CrudDoctor : Form
    {
        AdminForm previousForm = null;
        public CrudDoctor(AdminForm adminForm)
        {
            InitializeComponent();
            previousForm = adminForm;
        }

        private void CrudDoctor_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void New_Click(object sender, EventArgs e)
        {
            Hide();
            CreateDoctorForm doctorCreateForm = new CreateDoctorForm(this);
            doctorCreateForm.ShowDialog();
        }
    }
}
