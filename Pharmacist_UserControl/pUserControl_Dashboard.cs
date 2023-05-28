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
    public partial class pUserControl_Dashboard : UserControl
    {
        Function fn = new Function();
        string query;
        DataSet ds;
        Int64 count;
        public pUserControl_Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pUserControl_Dashboard_Load(object sender, EventArgs e)
        {
            loadChart();
        }

        public void loadChart()
        {
            //for valid medicine chart
            query = "select count(mName) from medicine where eDate >= getDate()";
            ds = fn.getData(query);
            count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Valid Medicines"].Points.AddXY("Medicine Validity Chart",count);

            //for invalid medicine chart
            query = "select count(mName) from medicine where eDate < getDate()";
            ds = fn.getData(query);
            count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Expired Medicines"].Points.AddXY("Medicine Validity Chart", count);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Valid Medicines"].Points.Clear();
            chart1.Series["Expired Medicines"].Points.Clear();
            loadChart();
        }
    }
}
