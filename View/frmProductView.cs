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
    public partial class frmProductView : SampleView
    {
        public frmProductView()
        {
            InitializeComponent();
        }

        private void frmProductView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = "select pID,pName,pPrice,catergoryID,c.catName from products p inner join category c on c.catID = p.catergoryID WHERE pName LIKE '%" + TxtSearch.Text + "%'";
            List<string> columns = new List<string> { "dgvsSno", "dgvName", "dgvprice", "dgvcatID","dgvcat" }; // Use column names
            MainClass.LoadData(qry, dataGridView1, columns);
        }

        public override void BtnAdd_Click(object sender, EventArgs e)
        {
            frmproductAdd frm=new frmproductAdd();
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
                frmproductAdd frm = new frmproductAdd();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvsSno"].Value);
                frm.TxtName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.Txtprice.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvprice"].Value);
                frm.cbCat.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvcatID"].Value);
                frm.ShowDialog();
                GetData();
            }
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvsSno"].Value);
                string qry = "DELETE FROM products WHERE pID = " + id;
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
