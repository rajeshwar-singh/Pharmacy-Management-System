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
    public partial class UserControl_ViewUser : UserControl
    {
        Function fn = new Function();
        DataSet ds;
        string query;
        string currentUser = "";
        public UserControl_ViewUser()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { currentUser = value;}
        }
        private void UserControl_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like '"+viewUser_userName.Text+"%'";
            ds = fn.getData(query); 
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }


        string userName;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void viewUser_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure!!", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (currentUser != userName)
                {
                    query = "delete from users where username = '" + userName + "'";
                    ds = fn.getData(query);
                    UserControl_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("You are trying to delete current user profile!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void viewUser_Sync_Click(object sender, EventArgs e)
        {
            UserControl_ViewUser_Load(this, null);
        }
    }
}
