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
    public partial class CreateReceptionistForm : Form
    {
        CrudReceptionist previousForm = null;
        public CreateReceptionistForm(CrudReceptionist receptionistCrudForm)
        {
            InitializeComponent();
            previousForm = receptionistCrudForm;
            //FirstNameBox.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            previousForm.Show();
        }

        private void CreateReceptionistForm_Load(object sender, EventArgs e)
        {

        }
    }
}
