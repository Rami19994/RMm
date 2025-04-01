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

namespace rm.Model
{
    public partial class frmStaffAdd : SamplAdd
    {
        public frmStaffAdd()
        {
            InitializeComponent();
        }

        private void frmStaffAdd_Load(object sender, EventArgs e)
        {

        }

        public int id = 0;

        public override void BtnSave_Click(object sender, EventArgs e)
        {
            string Qry = "";

            if (id == 0) // Insert
            {
                Qry = "INSERT INTO staff VALUES (@Name, @Phone,@Role)";
            }
            else // Update
            {
                Qry = "UPDATE staff SET sName = @Name, sPhone=@Phone,sRole=@Role WHERE staffID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", TxtName.Text);
            ht.Add("@Phone", Txtphone.Text);
            ht.Add("@Role", cbRole.Text);

            if (MainClass.SQL(Qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully.");
                id = 0;
                TxtName.Text = ""; // Clear the text box
                Txtphone.Text = "";
                cbRole.SelectedIndex = -1;
                this.Close(); // Close the form after saving
            }
        }

        public override void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

       
    }
}
