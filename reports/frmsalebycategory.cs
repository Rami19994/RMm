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

namespace rm.reports
{
    public partial class frmsalebycategory : Form
    {
        public frmsalebycategory()
        {
            InitializeComponent();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            string qry = @"select * from tblMain m inner join tblDetails d on m.MineID = d.MainID
                            inner join products p on p.pID=d.proID
                            inner join category c on c.catID=p.catergoryID
                            where m.aDate between @sdate and @edate ";

            SqlCommand cmd = new SqlCommand(qry, MainClass.Con);
            cmd.Parameters.AddWithValue("@sdate",Convert.ToDateTime( sdate.Value).Date);
            cmd.Parameters.AddWithValue("@edate", Convert.ToDateTime(edate.Value).Date);
            MainClass.Con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.Con.Close();

            frmPrintcs frm = new frmPrintcs();
            Crysalebycat cr = new Crysalebycat();
            cr.SetDatabaseLogon("sa", "12345");
            cr.SetDataSource(dt);

            frm.crystalReportViewer1.ReportSource = cr;
            cr.Refresh();

            frm.crystalReportViewer1.Refresh();
            frm.Show();

        }
    }
}
