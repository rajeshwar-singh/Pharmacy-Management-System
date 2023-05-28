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
    public partial class pUserControl_addMedicine : UserControl
    {
        Function fn = new Function();
        string query;
        public pUserControl_addMedicine()
        {
            InitializeComponent();
        }

        private void pUserControl_addMedicine_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text != "" && txtMedicineName.Text != "" && txtMedicineNumber.Text != "" && txtQuantity.Text != "" && txtPerUnitPrice.Text != "")
            {
                string mid = txtMedicineId.Text;
                string name = txtMedicineName.Text;
                string number = txtMedicineNumber.Text;
                string manu = txtManuDate.Text;
                string expiry = txtExpiryDate.Text;
                int quantity = int.Parse(txtQuantity.Text);
                int price = int.Parse(txtPerUnitPrice.Text);

                query = "insert into medicine values('" + mid + "','" + name + "','" + number + "','" + manu + "','" + expiry + "','" + quantity + "','" + price + "')";
                fn.setData(query, "Medicine Added !!");
            }
            else
            {
                MessageBox.Show("Adding data is Mandatory", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            txtManuDate.ResetText();
            txtExpiryDate.ResetText();
            txtQuantity.Clear();
            txtPerUnitPrice.Clear();
        }
    }
}
