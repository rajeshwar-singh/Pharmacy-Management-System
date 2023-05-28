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
    public partial class pUserControl_modifyMedsicine : UserControl
    {
        Function fn = new Function();
        string query;
        DataSet ds;
        public pUserControl_modifyMedsicine()
        {
            InitializeComponent();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text != "")
            {
                query = "select * from medicine where mId = '" + txtMedicineId.Text+"'";
                ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    txtMedicineName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedicineNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtManufacturingDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtExpireDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtAvailableQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPerUnitPrice.Text = ds.Tables[0].Rows[0][7].ToString();

                }
                else
                {
                    MessageBox.Show("No medicine with id : " + txtMedicineId.Text + " found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                clearAll();
            }
        }
        private void clearAll()
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            txtManufacturingDate.ResetText();
            txtExpireDate.ResetText();
            txtAvailableQuantity.Clear();
            txtPerUnitPrice.Clear();
            if(txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";

            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        Int64 totalQuantity;

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string mname = txtMedicineName.Text;
            string mnumber = txtMedicineNumber.Text;
            string mdate = txtManufacturingDate.Text;
            string edate = txtExpireDate.Text;
            Int64 quantity = Int64.Parse(txtAvailableQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
            Int64 unitPrice = Int64.Parse(txtPerUnitPrice.Text);

            totalQuantity = quantity + addQuantity;

            //updating values
            query = "update medicine set mName = '" + mname + "',mNumber = '" + mnumber+"',mDate = '"+mdate+"',eDate = '"+edate+"',quantity = '"+totalQuantity+"', perUnit = '"+unitPrice+"' where mId = '"+txtMedicineId.Text+"'";
            fn.setData(query, "Updated Medicine info");
        }
    }
}
