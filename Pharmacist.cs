using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pUserControl_viewMedicines1.Visible = true;
            pUserControl_viewMedicines1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            pUserControl_modifyMedsicine1.Visible = true;
            pUserControl_modifyMedsicine1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pUserControl_Dashboard1.Visible = true;
            pUserControl_Dashboard1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pUserControl_addMedicine1.Visible = true;
            pUserControl_addMedicine1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();

            this.Hide();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            pUserControl_Dashboard1.Visible = false;
            pUserControl_addMedicine1.Visible = false;
            pUserControl_viewMedicines1.Visible = false;
            pUserControl_modifyMedsicine1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void pUserControl_viewMedicines1_Load(object sender, EventArgs e)
        {

        }
    }
}
