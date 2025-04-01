using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace rm.View
{
    public partial class frmKetchnView : Form
    {
        public frmKetchnView()
        {
            InitializeComponent();
        }

        private void frmKetchnView_Load(object sender, EventArgs e)
        {
            Getorder();
        }

        private void Getorder()
        {
            flowLayoutPanel1.Controls.Clear();
            string qry1 = @"SELECT * FROM tblMain WHERE status = 'Pending'";
            SqlCommand cmd1 = new SqlCommand(qry1, MainClass.Con);

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt1);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                FlowLayoutPanel p1 = new FlowLayoutPanel()
                {
                    
                    Width = 300, // زيادة العرض لاستيعاب التفاصيل
                    Height = 350, // زيادة الارتفاع لاستيعاب التفاصيل
                    FlowDirection = FlowDirection.TopDown,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10, 10, 10, 10),
                    AutoSize = true,
                };

                FlowLayoutPanel p2 = new FlowLayoutPanel
                {
                    BackColor = Color.FromArgb(50, 55, 89),

                    Width = 300,
                    Height = 100,
                    FlowDirection = FlowDirection.TopDown,
                    Margin = new Padding(0, 0, 0, 0)
                };

                Label lb1 = new Label
                {
                    ForeColor = Color.White,
                    Margin = new Padding(10, 10, 3, 0),
                    AutoSize = true,
                    Text = "Table: " + dt1.Rows[i]["TableName"].ToString()
                };

                Label lb2 = new Label
                {
                    ForeColor = Color.White,
                    Margin = new Padding(10, 5, 3, 0),
                    AutoSize = true,
                    Text = "Waiter Name: " + dt1.Rows[i]["WaiterName"].ToString()
                };

                Label lb3 = new Label
                {
                    ForeColor = Color.White,
                    Margin = new Padding(10, 5, 3, 0),
                    AutoSize = true,
                    Text = "Order Time: " + dt1.Rows[i]["aTime"].ToString()
                };

                Label lb4 = new Label
                {
                    ForeColor = Color.White,
                    Margin = new Padding(10, 5, 3, 10),
                    AutoSize = true,
                    Text = "Order Type: " + dt1.Rows[i]["orderType"].ToString()
                };

                p2.Controls.Add(lb1);
                p2.Controls.Add(lb2);
                p2.Controls.Add(lb3);
                p2.Controls.Add(lb4);

                p1.Controls.Add(p2);

                int mid = 0;
                mid = Convert.ToInt32(dt1.Rows[i]["MineID"].ToString());
                string qry2 = @"
                            SELECT * FROM tblMain m
                            INNER JOIN tblDetails d ON m.MineID = d.MainID
                            INNER JOIN products p ON p.pID = d.proID
                            WHERE m.MineID = @mid"; // استخدام المعلمة

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.Con);
                cmd2.Parameters.AddWithValue("@mid", mid);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    Label lb5 = new Label
                    {
                        AutoSize = true,
                        BackColor = Color.White,
                        ForeColor = Color.Black,
                        Margin = new Padding(20, 10, 3, 0),

                        Text = "" + j + 1 + "  - " + dt2.Rows[j]["pName"].ToString() + " == QTY : " + dt2.Rows[j]["qty"].ToString()
                    };
                    p1.Controls.Add(lb5);
                }

                Button b = new Button
                {

                    Size = new Size(100, 35),
                    Text = "Complete",
                    BackColor = Color.FromArgb(241, 85, 126),
                    Margin = new Padding(100, 190, 3, 0), // هوامش مُعدلة
                    Tag = dt1.Rows[i]["MineID"].ToString()
                };
                b.Click += new EventHandler(b_Click);
                p1.Controls.Add(b);


                flowLayoutPanel1.Controls.Add(p1);
            }
        }


        private void b_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((Button)sender).Tag);
            if (MessageBox.Show("Are you sure you want to complete this order?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string qry = @"UPDATE tblMain SET status = 'Complete' WHERE MineID = @ID";
                Hashtable ht = new Hashtable();
                ht.Add("@ID", id);

                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Order completed successfully.");
                    Getorder(); // تحديث الواجهة بعد الانتهاء
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}