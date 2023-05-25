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
    public partial class UserControl_Profile : UserControl
    {
        Function fn = new Function();
        string query;
        DataSet ds;
        public UserControl_Profile()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { profile_userName.Text = value;}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void profile_userName_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_Profile_Load(object sender, EventArgs e)
        {

        }

        private void UserControl_Profile_Enter(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + profile_userName.Text + "'";
            ds = fn.getData(query);

            profile_userRole.Text = ds.Tables[0].Rows[0][1].ToString();

            profile_Name.Text = ds.Tables[0].Rows[0][2].ToString();

            profile_DOB.Text = ds.Tables[0].Rows[0][3].ToString();

            profile_Mobile.Text = ds.Tables[0].Rows[0][4].ToString();

            profile_Email.Text = ds.Tables[0].Rows[0][5].ToString();

            profile_Password.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void profile_btnReset_Click(object sender, EventArgs e)
        {
            UserControl_Profile_Enter(this, null);
        }

        private void profile_btnUpdate_Click(object sender, EventArgs e)
        {
            string role = profile_userRole.Text;
            string name = profile_Name.Text;
            string date = profile_DOB.Text;
            Int64 mob = Int64.Parse(profile_Mobile.Text);
            string email = profile_Email.Text;
            string username = profile_userName.Text;
            string pass = profile_Password.Text;

            query = "update users set userRole = '" + role + "',name = '" + name + "',dob = '" + date + "',mobile = '" + mob + "',email = '" + email + "'" +
                ",pass = '" + pass + "' where username = '"+username+"'";
            fn.setData(query, "Profile Updation Successful");
        }
    }
}
