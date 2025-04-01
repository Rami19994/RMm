using System;
using System.Collections;
using System.Data;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Security.RightsManagement;
using System.Windows.Forms;

namespace rm.Model
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }
          
        public int detailID = 0;
        public int MainID = 0;
        public int MineID = 0;
        public int driverID=0;
        public string cusName = "";
        public string cusPhone = "";
        public string orderType="";

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // لا تحتاج إلى أي شيء هنا
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {





            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Clear();
            AddCategory();
            LoadProduct();


        }

        private void AddCategory()
        {
            string qry = "SELECT * FROM category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Button btn = new Button
                    {
                        ForeColor = Color.FromArgb(50, 55, 89),
                        Size = new Size(100, 30),
                        Text = dr["catName"].ToString()
                    };
                    btn.Click += new EventHandler(btnCategory_Click);
                    btn.Click += new EventHandler(_Click);
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
        }

        private void _Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach (var item in flowLayoutPanel2.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(btn.Text.Trim().ToLower());
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            // يمكنك إضافة وظيفة إضافية هنا
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            // يمكنك إضافة وظيفة إضافية هنا
        }

        private void AddItems(string inv,string id, string proID, string Name, string Price, string Cat, Image pImage)
        {
            var w = new ucProduct
            {
                PName = Name,
                PPrice = Price,
                PCategory = Cat,
                pImage = pImage,
                proID = Convert.ToInt32(proID),
                invoiceid = Convert.ToInt32(inv)
                // استخدام معرف المنتج الفعلي
            };

            flowLayoutPanel2.Controls.Add(w);
            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells["dgvproID"].Value) == wdg.proID)
                    {
                        row.Cells["dgvInvoiceID"].Value=wdg.invoiceid;
                        row.Cells["dgvqty"].Value = int.Parse(row.Cells["dgvqty"].Value.ToString()) + 1;
                        row.Cells["dgvamaunt"].Value = int.Parse(row.Cells["dgvqty"].Value.ToString()) *
                        double.Parse(row.Cells["dgvprice"].Value.ToString());
                        GetTotal();
                        return;
                    }

                }
                
                dataGridView1.Rows.Add(new object[] {wdg.invoiceid, 0, wdg.proID, wdg.PName, 1, wdg.PPrice, wdg.PPrice });

                GetTotal();

            };

        }

        private void LoadProduct()
        {
            string qry = "SELECT * FROM products INNER JOIN category ON catID = catergoryID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                byte[] imagearray = (byte[])item["pImage"];
                Byte[] imagebytarray = imagearray;
                AddItems("0","0", item["pID"].ToString(), item["pName"].ToString(), item["pPrice"].ToString(), item["catName"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel2.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(TxtSearch.Text.Trim().ToLower());
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }


        private void GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["dgvamaunt"].Value.ToString());

            }
            lblTotal.Text = tot.ToString("N2");
            return;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lalTable.Text = "";
            lalWaiter.Text = "";
            lalTable.Visible = false;
            lalWaiter.Visible = false;
            dataGridView1.Rows.Clear();
            MineID = 0;
            lblTotal.Text = "00";
        }

        private void btnDellivery_Click(object sender, EventArgs e)
        {
            lalTable.Text = "";
            lalWaiter.Text = "";
            lalTable.Visible = false;
            lalWaiter.Visible = false;
            orderType = "Delivery";
            frmAddcustomer frm = new frmAddcustomer();
            frm.mainID = MainID;
            frm.orderType = orderType;
            frm.ShowDialog();

            if (frm.TxtName.Text != "")
            {
                driverID = frm.DriverID;
                lblDraiverName.Text = "cudtomer Name :  " + frm.TxtName.Text + "  Phone :  " + frm.txtPhone.Text + "  Driver :  " +frm.cbDriver.Text;
                lblDraiverName.Visible = true;
                cusName = frm.TxtName.Text;
                cusPhone = frm.txtPhone.Text;
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            lalTable.Text = "";
            lalWaiter.Text = "";
            lalTable.Visible = false;
            lalWaiter.Visible = false;
            orderType = "Take Away";

            frmAddcustomer frm=new frmAddcustomer();
            frm.mainID=MainID;
            frm.orderType = orderType;
            frm.ShowDialog(); 

            if (frm.TxtName.Text != "")
            {
                driverID = frm.DriverID;
                lblDraiverName.Text="cudtomer Name :  "  + frm.TxtName.Text + "  Phone :  " + frm.txtPhone.Text;
                lblDraiverName.Visible = true;
                cusName=frm.TxtName.Text;
                cusPhone=frm.txtPhone.Text;
            }
        }

        private void btnDin_Click(object sender, EventArgs e)
        {
            orderType = "Din in";
            lblDraiverName.Visible=false;
            //frmTableSelect frm = new frmTableSelect();
            //frm.ShowDialog();
            //if (frm.TableName != "")
            //{
            //    lalTable.Text = frm.TableName;
            //    lalTable.Visible = true;
            //}
            //else
            //{
            //    lalTable.Text = "";
            //    lalTable.Visible = false;
            //}

            frmWaiterSelect frm2 = new frmWaiterSelect();
            frm2.ShowDialog();
            if (frm2.WaiterName != "")
            {
                lalWaiter.Text = frm2.WaiterName;
                lalWaiter.Visible = true;
            }
            else
            {
                lalWaiter.Text = "";
                lalWaiter.Visible = false;
            }

        }

        private void btnKOT_Click(object sender, EventArgs e)
        {
            
            string qry1 = "";
            string qry2="";
            int detailID=0;
            int invoiceNumber = 0;
            if (MineID == 0)
            {
                qry1 = @"INSERT INTO tblMain (aDate, aTime, TableName, WaiterName, status, orderType, total, received, change,driverID,custName,custPhon)
                     VALUES (@aDate, @aTime, @TableName, @WaiterName, @status, @orderType, @total, @received, @change,@driverID,@custName,@custPhon);
                     SELECT SCOPE_IDENTITY();";
            }
            else
            {
                qry1 = @"UPDATE tblMain 
                     SET status=@status, total=@total, received=@received, change=@change 
                     WHERE MineID=@ID";
            }
            Hashtable ht = new Hashtable();
            SqlCommand cmd = new SqlCommand(qry1, MainClass.Con);

            cmd.Parameters.AddWithValue("@ID", MineID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lalTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lalWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@orderType", orderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@custName",cusName.ToString());
            cmd.Parameters.AddWithValue("@custPhon",Convert.ToString(cusPhone));



            if (MainClass.Con.State == ConnectionState.Closed) { MainClass.Con.Open(); }

            if (MineID == 0)
            {
                MineID = Convert.ToInt32(cmd.ExecuteScalar()); // جلب آخر ID عند الإدراج
            }
            else
            {
                cmd.ExecuteNonQuery(); // تنفيذ التحديث بدون إرجاع قيمة
            }

            if (MainClass.Con.State == ConnectionState.Open) { MainClass.Con.Close(); }

             invoiceNumber = GenerateInvoiceNumber();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               
                detailID = Convert.ToInt32(row.Cells["dgvsSno"].Value);
               
                if (detailID == 0 )
                {
                   
                    qry2 = @"INSERT INTO tblDetails (MainID, proID, qty, price, amount,invoiceID) 
                                    VALUES (@MainID, @proID, @qty, @price, @amount,@invoiceID)";
                }
                else
                {
                    qry2 = @"UPDATE tblDetails 
                                SET MainID=@MainID, proID=@proID, qty=@qty, price=@price, amount=@amount 
                                    WHERE DetailID=@ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.Con);
                {
                    cmd2.Parameters.AddWithValue("@ID", detailID);
                    cmd2.Parameters.AddWithValue("@MainID", MineID);
                    cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                    cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvqty"].Value));
                    cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvprice"].Value));
                    cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvamaunt"].Value));
                    cmd2.Parameters.AddWithValue("@invoiceID", invoiceNumber);


                    if (MainClass.Con.State == ConnectionState.Closed) { MainClass.Con.Open(); }
                    cmd2.ExecuteNonQuery();
                    if (MainClass.Con.State == ConnectionState.Open) { MainClass.Con.Close(); }
                }
            }

            MessageBox.Show("Saved successfully..!");
            MineID = 0;
            detailID = 0;
            invoiceNumber = 0;
            dataGridView1.Rows.Clear();
            lalTable.Text = "";
            lalWaiter.Text = "";
            lalTable.Visible = false;
            lalWaiter.Visible = false;
            lblTotal.Text = "00";
            lblDraiverName.Text = "";
            dataGridView1.Rows.Clear();
            this.Close();
        }



        public int id = 0;
        internal string TableName;

        private void btnBill_Click(object sender, EventArgs e)
        {
            frmBilllist frm = new frmBilllist();
            frm.ShowDialog();

            if (frm.MainnID > 0)
            {
                id = frm.MainnID;
                MainID = frm.MainnID;
                LoadEnters();
            }
        }

        public void LoadEnters()
        {
            string qry = @"
                            SELECT * FROM tblMain m
                            INNER JOIN tblDetails d ON m.MineID = d.MainID
                            INNER JOIN products p ON p.pID = d.proID
                            WHERE m.MineID = @id";

            SqlCommand cmd2 = new SqlCommand(qry, MainClass.Con);
            cmd2.Parameters.AddWithValue("@id", id);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            if (dt2.Rows[0]["orderType"].ToString() == "Delivery")
            {
                btnDellivery.Enabled = true;
                lalWaiter.Visible = false;
                lalTable.Visible = false;

            }
            else if (dt2.Rows[0]["orderType"].ToString() == "Take Away")
            {
                Btncheck.Enabled = true;
                lalWaiter.Visible = false;
                lalTable.Visible = false;
            }
            else
            {
                btnDin.Enabled = true;
                lalWaiter.Visible = false;
                lalTable.Visible = false;
            }



            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt2.Rows)
            {
                lalTable.Text = item["TableName"].ToString();
                lalWaiter.Text = item["WaiterName"].ToString();




                string detailid = item["DetailID"].ToString();
                
                string proid = item["proID"].ToString();
                string proname = item["pName"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();
                string invoiceid = item["invoiceID"].ToString();

                object[] obj = {invoiceid, detailid,proid, proname, qty, price, amount,0};
                dataGridView1.Rows.Add(obj);
            }
            GetTotal();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lalTable_Click(object sender, EventArgs e)
        {

        }

        private void Btncheck_Click(object sender, EventArgs e)
        {
            frmcheckout frm = new frmcheckout();
            frm.MainnnId = id;
            frm.amt = Convert.ToDouble(lblTotal.Text);
            frm.ShowDialog();
            MineID = 0;
            dataGridView1.Rows.Clear();
            lalTable.Text = "";
            lalWaiter.Text = "";
            lalTable.Visible = false;
            lalWaiter.Visible = false;
            lblTotal.Text = "00";

        }

        private void btnHold_Click(object sender, EventArgs e)
        {

            string qry1="";
            string qry2="";
            int detailID = 0;
            int invoiceNumber = 0;
            if (orderType == "")
            {
                MessageBox.Show("please select the order type..");
                return;
            }

            if (MineID == 0)
            {
                qry1 = @"INSERT INTO tblMain (aDate, aTime, TableName, WaiterName, status, orderType, total, received, change,driverID,custName,custPhon)
                     VALUES (@aDate, @aTime, @TableName, @WaiterName, @status, @orderType, @total, @received, @change,@driverID,@custName,@custPhon);
                     SELECT SCOPE_IDENTITY();";
            }
            else
            {
                qry1 = @"UPDATE tblMain 
                     SET status=@status, total=@total, received=@received, change=@change 
                     WHERE MineID=@ID";
            }
            Hashtable ht = new Hashtable();
            SqlCommand cmd = new SqlCommand(qry1, MainClass.Con);

            cmd.Parameters.AddWithValue("@ID", MineID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lalTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lalWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Hold");
            cmd.Parameters.AddWithValue("@orderType", orderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@custName", cusName.ToString());
            cmd.Parameters.AddWithValue("@custPhon", Convert.ToString(cusPhone));


            if (MainClass.Con.State == ConnectionState.Closed) { MainClass.Con.Open(); }

            if (MineID == 0)
            {
                MineID = Convert.ToInt32(cmd.ExecuteScalar()); // جلب آخر ID عند الإدراج
            }
            else
            {
                cmd.ExecuteNonQuery(); // تنفيذ التحديث بدون إرجاع قيمة
            }

            if (MainClass.Con.State == ConnectionState.Open) { MainClass.Con.Close(); }


            invoiceNumber = GenerateInvoiceNumber();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvsSno"].Value);

                if (detailID == 0)
                {
                    qry2 = @"INSERT INTO tblDetails (MainID, proID, qty, price, amount,invoiceID) 
                                    VALUES (@MainID, @proID, @qty, @price, @amount,@invoiceID)";
                }
                else
                {
                    qry2 = @"UPDATE tblDetails 
                                SET MainID=@MainID, proID=@proID, qty=@qty, price=@price, amount=@amount 
                                    WHERE DetailID=@ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.Con);
                {
                    cmd2.Parameters.AddWithValue("@ID", detailID);
                    cmd2.Parameters.AddWithValue("@MainID", MineID);
                    cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                    cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvqty"].Value));
                    cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvprice"].Value));
                    cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvamaunt"].Value));
                    cmd2.Parameters.AddWithValue("@invoiceID", invoiceNumber);
                    if (MainClass.Con.State == ConnectionState.Closed) { MainClass.Con.Open(); }
                    cmd2.ExecuteNonQuery();
                    if (MainClass.Con.State == ConnectionState.Open) { MainClass.Con.Close(); }
                }
            }

            MessageBox.Show("Saved successfully..!");
            MineID = 0;
            invoiceNumber = 0;
            dataGridView1.Rows.Clear();
            lalTable.Text = "";
            lalWaiter.Text = "";
            lalTable.Visible = false;
            lalWaiter.Visible = false;
            lblTotal.Text = "00";
            lblDraiverName.Text = "";
            
        }

        private int GenerateInvoiceNumber()
        {
            // الطريقة 1: استخدام التاريخ والوقت
            // return int.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));

            // الطريقة 2: الرقم المتسلسل من قاعدة البيانات
            string qry = "SELECT ISNULL(MAX(invoiceID), 0) + 1 FROM tblDetails";
            SqlCommand cmd = new SqlCommand(qry, MainClass.Con);

            if (MainClass.Con.State == ConnectionState.Closed)
                MainClass.Con.Open();

            int newInvoiceID = Convert.ToInt32(cmd.ExecuteScalar());

            if (MainClass.Con.State == ConnectionState.Open)
                MainClass.Con.Close();

            return newInvoiceID;
        }
    }
}