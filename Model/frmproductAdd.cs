using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rm.Model
{
    public partial class frmproductAdd :SamplAdd
    {
        public frmproductAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int cID = 0;
        private void frmproductAdd_Load(object sender, EventArgs e)
        {
            string qry = "select catID 'id' , catName 'name' from category  ";
            MainClass.CBFill(qry,cbCat);

            if (cID > 0)
            {
                cbCat.SelectedValue = cID;
            }
            if(id > 0)
            {
                ForUpdate();
            }
        }

        string filepath;
        Byte[] imageByteArray;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images (.jpg,.png)|* .png; *.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                txtimage.Image=new Bitmap(filepath);
            }
        }

        public override void BtnSave_Click(object sender, EventArgs e)
        {
            string Qry = "";

            if (id == 0) // Insert
            {
                Qry = "INSERT INTO products VALUES (@Name, @Price,@Cat,@Img)";
            }
            else // Update
            {
                Qry = "UPDATE products SET pName = @Name, pPrice=@Price,catergoryID=@Cat,pImage =@Img WHERE pID = @id";
            }


            Image temp = new Bitmap(txtimage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", TxtName.Text);
            ht.Add("@Price", Txtprice.Text);
            ht.Add("@Cat", Convert.ToInt32(cbCat.SelectedValue));
            ht.Add("@Img", imageByteArray);

            if (MainClass.SQL(Qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully.");
                id = 0;
                cID = 0;
                TxtName.Text = ""; // Clear the text box
                Txtprice.Text = "";
                cbCat.SelectedIndex = -1;
                txtimage.Image = rm.Properties.Resources.ProductPic;
                this.Close(); // Close the form after saving
            }
        }

        public override void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        private void ForUpdate()
        {
            string qry = @"select * from products where pid=" + id + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                TxtName.Text = dt.Rows[0]["pName"].ToString();
                Txtprice.Text = dt.Rows[0]["pPrice"].ToString();
                Byte[] imageArray = (byte[])(dt.Rows[0]["pImage"]);
                byte[] imageByteArray=imageArray;

                txtimage.Image=Image.FromStream(new MemoryStream(imageArray));
            }

        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
