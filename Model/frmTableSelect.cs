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

namespace rm.Model
{
    public partial class frmTableSelect : Form
    {
        public frmTableSelect()
        {
            InitializeComponent();
        }

        public string TableName;
        private void frmTableSelect_Load(object sender, EventArgs e)
        {
            string qry = "select * from tables";
            SqlCommand cmd = new SqlCommand(qry, MainClass.Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Button btn = new Button();
                btn.ForeColor = Color.FromArgb(50, 55, 89);
                btn.Size = new Size(100, 50);
                btn.Text = row["tName"].ToString();
                btn.Click += new EventHandler(btnCategory_Click);
                btn.Click += new EventHandler(openpos_Click);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void openpos_Click(object sender, EventArgs e)
        {
            frmPOS frm= new frmPOS();
            if (!string.IsNullOrEmpty(TableName))
            {
                frm.lalTable.Text = TableName;
                frm.lalTable.Visible = true;
            }
            else
            {
                frm.lalTable.Text = "";
                frm.lalTable.Visible = false;
            }
            frm.ShowDialog();


        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            TableName = (sender as Button).Text.ToString();
            this.DialogResult = DialogResult.OK;

            

        }
    }
}
