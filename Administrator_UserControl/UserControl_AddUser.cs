using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Administrator_UserControl
{
    public partial class UserControl_AddUser : UserControl
    {
        Function fn = new Function();
        string query;
        public UserControl_AddUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_AddUser_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_reset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            AddUser_userRole.SelectedIndex = -1;
            AddUser_name.Clear();
            AddUser_DOB.ResetText();
            AddUser_mobile.Clear();
            AddUser_email.Clear();
            AddUser_name.Clear();
            AddUser_password.Clear();

        }

        private void AddUser_btnSignUp_Click(object sender, EventArgs e)
        {
            string role = AddUser_userRole.Text;
            string name = AddUser_name.Text;
            string dob = AddUser_DOB.Text;
            Int64 mobile = Int64.Parse(AddUser_mobile.Text);
            string email = AddUser_email.Text;
            string username = AddUser_userName.Text;
            string pass = AddUser_password.Text;

            try
            {
                query = "insert into users values('" + role + "','" + name + "','" + dob + "','" + mobile + "','" + email + "','" + username + "','" + pass + "')";
                fn.setData(query, "Sign Up Successful.");
            }
            catch(Exception)
            { 
                MessageBox.Show("Username already exist !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_userName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username ='" + AddUser_userName.Text + "'";
            DataSet ds = fn.getData(query);

            //if no data is available in the table then show right tick else wrong
            if(ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"C:\Users\Rajeshwar\Desktop\C  Pharmacy Management System\Pharmacy Management System in C#\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\Rajeshwar\Desktop\C  Pharmacy Management System\Pharmacy Management System in C#\no.png";
            }

        }

        private void AddUser_userRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
