using rm.reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rm.View
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qry= @"select * from products";

            SqlCommand cmd = new SqlCommand(qry, MainClass.Con);
            MainClass.Con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.Con.Close();

            frmPrintcs frm = new frmPrintcs();
            Cryproduct cr = new Cryproduct();
            cr.SetDatabaseLogon("sa", "12345");
            cr.SetDataSource(dt);

            frm.crystalReportViewer1.ReportSource = cr;
            cr.Refresh();

            frm.crystalReportViewer1.Refresh();
            frm.Show();

        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            string qry = @"select * from staff";

            SqlCommand cmd = new SqlCommand(qry, MainClass.Con);
            MainClass.Con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.Con.Close();

            frmPrintcs frm = new frmPrintcs();
            Crystaff cr = new Crystaff();
            cr.SetDatabaseLogon("sa", "12345");
            cr.SetDataSource(dt);

            frm.crystalReportViewer1.ReportSource = cr;
            cr.Refresh();

            frm.crystalReportViewer1.Refresh();
            frm.Show();

        }

        private void btnselectcat_Click(object sender, EventArgs e)
        {
            frmsalebycategory frm = new frmsalebycategory();
            frm.ShowDialog();
        }
    }
}
