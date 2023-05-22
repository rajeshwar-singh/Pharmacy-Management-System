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
    public partial class UserControl_Dashboard : UserControl
    {

        Function fn = new Function();
        string query;
        DataSet ds;
        public UserControl_Dashboard()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_Dashboard_Load(object sender, EventArgs e)
        {
            //count no of admin available
            query = "select count(userRole) from users where userRole ='Administrator'";
            ds = fn.getData(query);
            setLabel(ds, AdminLabel);


            //count no of pharma available
            query = "select count(userRole) from users where userRole = 'Pharmacist'";
            ds = fn.getData(query);
            setLabel(ds, PharmacistLabel);

            //count no. of customers
            query = "select count(userRole) from users where userRole = 'Customer'";
            ds = fn.getData(query);
            setLabel(ds, CustomerLabel);

        }
        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UserControl_Dashboard_Load(this, null);
        }
    }
}
