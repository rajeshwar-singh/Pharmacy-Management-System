using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Pharmacist_UserControl
{
    public partial class pUserControl1_MedicineValidityCheck : UserControl
    {
        Function fn = new Function();
        string query;
        DataSet ds;
        public pUserControl1_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtCheck.SelectedIndex == 0)
            {
                query = "select * from medicine where eDate>=getDate()";
                ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                setLabel.Text = "Valid Medicines";
                setLabel.ForeColor = Color.Black;

            }
            else if(txtCheck.SelectedIndex == 1)
            {
                query = "select * from medicine where eDate < getDate()";
                ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                setLabel.Text = "Expired Medicines";
                setLabel.ForeColor = Color.Red;
            }
            else
            {
                query = "select * from medicine";
                ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                setLabel.Text = "View All Medicines";
                setLabel.ForeColor = Color.DarkGreen ;
            }
        }

        private void pUserControl1_MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            setLabel.Text = ""; 
        }
    }
}
