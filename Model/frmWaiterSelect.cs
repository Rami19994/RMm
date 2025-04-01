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
    public partial class frmWaiterSelect : Form
    {
        public frmWaiterSelect()
        {
            InitializeComponent();
        }

        public string WaiterName;
        private void frmWaiterSelect_Load(object sender, EventArgs e)
        {
            string qry = "select * from staff where sRole like 'Waiter'";
            SqlCommand cmd = new SqlCommand(qry, MainClass.Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Button btn = new Button();
                btn.ForeColor = Color.FromArgb(50, 55, 89);
                btn.Size = new Size(100, 30);
                btn.Text = row["sName"].ToString();
                btn.Click += new EventHandler(btnCategory_Click);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            WaiterName = (sender as Button).Text.ToString();
            this.Close();

        }
       
    }
}
