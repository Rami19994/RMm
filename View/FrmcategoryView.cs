using rm.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rm.View
{
    public partial class FrmcategoryView : SampleView
    {
        public FrmcategoryView()
        {
            InitializeComponent();
        }

        private void FrmcategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = "SELECT * FROM category WHERE catName LIKE '%" + TxtSearch.Text + "%'";
            List<string> columns = new List<string> { "dgvsSno", "dgvName" }; // Use column names
            MainClass.LoadData(qry, dataGridView1, columns);
        }

        public override void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmCategoryAdd frm = new FrmCategoryAdd();
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
                FrmCategoryAdd frm = new FrmCategoryAdd();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvsSno"].Value);
                frm.TxtName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.ShowDialog();
                GetData();
            }
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvsSno"].Value);
                string qry = "DELETE FROM category WHERE catID = " + id;
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