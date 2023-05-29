using DGVPrinterHelper;
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
    public partial class pUserControl1_SellMedicine : UserControl
    {
        Function fn = new Function();
        string query;
        DataSet ds;
        public pUserControl1_SellMedicine()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pUserControl1_SellMedicine_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mName from medicine where eDate>=getDate() and quantity > '0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            pUserControl1_SellMedicine_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mName from medicine where mName like '" + txtSearch.Text + "%' and eDate >= getDate() and quantity>'0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.Clear();

            string name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);
            txtMedicineName.Text = name;


            query = "select mId, eDate, perUnit from medicine where mName = '" + name + "'";
            ds = fn.getData(query);

            txtMedicineId.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpiry.Text = ds.Tables[0].Rows[0][1].ToString();
            txtUnitPrice.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text !="")
            {
                Int64 unitPrice = Int64.Parse(txtUnitPrice.Text);
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 total = unitPrice * quantity;
                txtTotalPrice.Text = total.ToString();
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }


        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        

        private void btnToCart_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text != "")
            {
                query = "select quantity from medicine where mId = '"+txtMedicineId.Text+"'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtQuantity.Text);

                if (newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtMedicineId.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMedicineName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtExpiry.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtUnitPrice.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtQuantity.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    txtFinalPrice.Text = "Rs. " + totalAmount.ToString();

                    query = "update medicine set quantity = '" + newQuantity + "' where mId = '" + txtMedicineId.Text+"'";
                    fn.setData(query, "Medicine Added !!");

                }
                else
                {
                    MessageBox.Show("Medicine is out of stock.\n Only " + quantity + " left", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ClearAll();
                pUserControl1_SellMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine first.", "Information !!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        int valueAmount;
        string valueId;
        protected Int64 noOfUnit;

        

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception){ }
        }

        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(valueId!= null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index); 
                }
                catch(Exception)
                {

                }
                finally
                {
                    query = "select quantity from medicine where mId = '" + valueId + "'";
                    ds = fn.getData(query);

                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfUnit;

                    query = "update medicine set quantity = '" + newQuantity + "' where mId = '"+valueId+"'";
                    fn.setData(query, "Medicine Remove from cart!!");
                    totalAmount = totalAmount - valueAmount;
                    txtFinalPrice.Text = "Rs. " + totalAmount.ToString();
                }
                pUserControl1_SellMedicine_Load(this, null);
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date:- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount : " + txtFinalPrice.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmount = 0;
            txtFinalPrice.Text = "Rs. 00";
            guna2DataGridView1.DataSource = 0;

        }
        private void ClearAll()
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            txtExpiry.ResetText();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
        }


    }
}
