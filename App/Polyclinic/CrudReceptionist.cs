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
    public partial class CrudReceptionist : Form
    {
        AdminForm previousForm = null;
        public CrudReceptionist(AdminForm adminForm)
        {
            InitializeComponent();
            previousForm = adminForm;
        }

        private void CrudRecceptionist_Load(object sender, EventArgs e)
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
            CreateReceptionistForm receptionistCreateForm = new CreateReceptionistForm(this);
            receptionistCreateForm.ShowDialog();
        }
    }
}
