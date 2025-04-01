using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace rm.Model
{
    public partial class frmcheckout : SamplAdd
    {
        public frmcheckout()
        {
            InitializeComponent();
        }

        public double amt;
        public int MainnnId=0;
        private void TxtRceived_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double receipt = 0;
            double change = 0;
            double service = 0;
            double.TryParse(TxtBillAmount.Text, out amt);
            double.TryParse(TxtRceived.Text, out receipt);
            

            change=Math.Abs(amt-receipt);
           

            TxtChange.Text=change.ToString();
        }

        public override void BtnSave_Click(object sender, EventArgs e)
        {
            // التحقق من أن جميع الحقول ممتلئة
            if (string.IsNullOrWhiteSpace(TxtBillAmount.Text) ||
                string.IsNullOrWhiteSpace(TxtRceived.Text) ||
                string.IsNullOrWhiteSpace(TxtChange.Text))
            {
                MessageBox.Show("All fields must be filled in before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // إيقاف التنفيذ
            }

            string qry = @"update tblMain set total=@total, received=@rec, change=@change, status='Paid' where MineID=@id";

            Hashtable ht = new Hashtable();
            ht.Add("@id", MainnnId);
            ht.Add("@total", TxtBillAmount.Text);
            ht.Add("@rec", TxtRceived.Text);
            ht.Add("@change", TxtChange.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }


        private void frmcheckout_Load(object sender, EventArgs e)
        {
            TxtBillAmount.Text=amt.ToString();
        }
    }
}
