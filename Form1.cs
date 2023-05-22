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
    public partial class Form1 : Form
    {
        Function fn = new Function();
        
        string query;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           // Validating for data in the database
           query = "select * from users";
           ds = fn.getData(query);

            //if table count 0 and have no data
                if (ds.Tables[0].Rows.Count == 0)
                {
                    if (txtUserName.Text == "root" && txtPassword.Text == "root")
                    {
                        Administrator admin = new Administrator();
                        admin.Show();
                        this.Hide();
                    }
                }
                else
                {
                    //checking username and password exit in data base or not
                    query = "select * from users where username ='" + txtUserName.Text + "' and pass = '" + txtPassword.Text + "'";
                    ds = fn.getData(query);

                //checking data dataset object is not 0
                if (ds.Tables[0].Rows.Count != 0)
                {
                    //now retriving the user role
                    string role = ds.Tables[0].Rows[0][1].ToString();

                    //if role is administrator then move to the admin page
                    if (role == "Administrator")
                    {
                        Administrator admin = new Administrator(txtUserName.Text);
                        admin.Show();
                        this.Hide();

                    }
                    else if (role == "Pharmacist")
                    {
                        Pharmacist ph = new Pharmacist();
                        ph.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Username and password doesn't exits or matched","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
             }
























            /*if (txtUserName.Text == "u" && txtPassword.Text == "u")
            {
                Administrator am = new Administrator();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
