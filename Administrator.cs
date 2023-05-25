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
    
    public partial class Administrator : Form
    {
        string user = "";

        public Administrator()
        {
            InitializeComponent();
        }
        public string ID
        {
            get { return user.ToString(); }
        }
        public Administrator(string username)
        {
            InitializeComponent();
            AdminName.Text = username;
            user = username;
            userControl_ViewUser1.ID = ID;
            userControl_Profile1.ID = ID;
        }

        

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            userControl_Profile1.Visible = true;
            userControl_Profile1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            userControl_Dashboard1.Visible = true;
            
            userControl_Dashboard1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            userControl_AddUser1.Visible = true;
            userControl_AddUser1.BringToFront();
             
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            userControl_ViewUser1.Visible = true;
            userControl_ViewUser1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //Showing the Login page
            Form1 fm = new Form1();
            fm.Show();

            //Hiding currrent Administrator page
            this.Hide();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            userControl_Dashboard1.Visible = false;
            userControl_AddUser1.Visible = false;
            userControl_ViewUser1.Visible = false;
            userControl_Profile1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void userControl_AddUser1_Load(object sender, EventArgs e)
        {

        }

        private void userControl_ViewUser1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
