using rm.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rm.View
{
    public partial class frmStaffView : SampleView
    {
        public frmStaffView()
        {
            InitializeComponent();
        }

        private void frmStaffView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = "SELECT * FROM staff WHERE sName LIKE '%" + TxtSearch.Text + "%'";
            List<string> columns = new List<string> { "dgvsSno", "dgvName" , "dgvphon", "dgvrole" }; // Use column names
            MainClass.LoadData(qry, dataGridView1, columns);
        }

        public override void BtnAdd_Click(object sender, EventArgs e)
        {
            frmStaffAdd frm=new frmStaffAdd();
            frm.ShowDialog();
            GetData();
        }

        public override void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                frmStaffAdd frm = new frmStaffAdd();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvsSno"].Value);
                frm.TxtName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.Txtphone.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvphon"].Value);
                frm.cbRole.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvrole"].Value);
                frm.ShowDialog();
                GetData();
            }
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvsSno"].Value);
                string qry = "DELETE FROM staff WHERE staffID = " + id;
                Hashtable ht = new Hashtable();
                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Deleted successfully.");
                    GetData();
                }
            }
        }
    }
}
