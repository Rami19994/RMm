using rm.reports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

using ListBox = System.Windows.Controls.ListBox;
namespace rm.Model
{
    public partial class frmBilllist : SamplAdd
    {
        public frmBilllist()
        {
            InitializeComponent();
        }

        public int MainnID=0; 
        public int OrderID = 0; 
        private void frmBilllist_Load(object sender, EventArgs e)
        {
           
            LoadData();
        }

        private void LoadData()
        {
            string qry = @"select m.MineID, m.TableName, m.WaiterName, m.orderType, m.status, m.total, MIN(d.invoiceID) as invoiceID
                        from tblMain m 
                        inner join tblDetails d on m.MineID = d.MainID 
                        where m.status <> 'Pending'
                        group by m.MineID, m.TableName, m.WaiterName, m.orderType, m.status, m.total";
            List<string> columns = new List<string> {"dgvsSno", "dgvtable", "dgvwaiter", "dgvtype", "dgvstatus", "dgvtotal" , "dgvInvoiceID" }; // Use column names
            MainClass.LoadData(qry, dataGridView1, columns);

        }

      

      private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
      {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {

                MainnID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvsSno"].Value);
                this.Close();

            }
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvprint")
            {
                int selectedInvoiceID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvInvoiceID"].Value);
               

                string qry = @"
                           select * from tblMain m  
                        inner join tblDetails d on d.MainID = m.MineID 
                        inner join products p on p.pID = d.proID 
                        where d.invoiceID = @InvoiceID";

                SqlCommand cmd = new SqlCommand(qry, MainClass.Con);
                cmd.Parameters.AddWithValue("@InvoiceID", selectedInvoiceID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                MainClass.Con.Open();
                da.Fill(dt);
                MainClass.Con.Close();

               

                // تحميل التقرير
                frmPrintcs frm = new frmPrintcs();
                CryBill cr = new CryBill();
                cr.SetDatabaseLogon("sa", "12345");
                cr.SetDataSource(dt);

                frm.crystalReportViewer1.ReportSource = cr;
                cr.Refresh();
                
                frm.crystalReportViewer1.Refresh();
                frm.Show();
            }
        }


        private void BtnSave_Click_1(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


      
    }
}
