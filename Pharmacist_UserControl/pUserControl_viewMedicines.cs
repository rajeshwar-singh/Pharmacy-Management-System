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
    public partial class pUserControl_viewMedicines : UserControl
    {
        Function fn = new Function();
        string query;
        DataSet ds;

        public pUserControl_viewMedicines()
        {
            InitializeComponent();
        }

        private void pUserControl_viewMedicines_Load(object sender, EventArgs e)
        {
            query = "select * from medicine";
            setDataGridView(query);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medicine where mName like'" + txtSearch.Text + "%'";
            setDataGridView(query);
        }

        private void setDataGridView(string query)
        {
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        string medId;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medId = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure ? ","Delete Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from medicine where mId = '" + medId + "'";
                fn.setData(query, "Medicine Deleted !!");
                pUserControl_viewMedicines_Load(this, null);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            pUserControl_viewMedicines_Load(this, null);
        }
    }
}
