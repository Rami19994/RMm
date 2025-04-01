using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using System.Xml.Linq;

namespace rm
{
    public partial class frmsitteng : Form
    {
        public frmsitteng()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public int userid =0;
        private void button1_Click(object sender, EventArgs e)
        {
            string Qry = "";

            if (userid == 0) // Insert
            {
                Qry = "INSERT INTO userss VALUES (@usename, @upass,@usernum,@uphone,@Role)";
            }
            else // Update
            {
                Qry = "UPDATE userss SET usename = @usename, upass=@upass,usernum=@usernum,uphone=@phone,Role=@Role WHERE userID = @userID";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@userID", userid);
            ht.Add("@usename", txtUsername.Text);
            ht.Add("@upass", txtPassword.Text);
            ht.Add("@usernum", txtName.Text);
            ht.Add("@uphone", txtPhone.Text);
            ht.Add("@Role", comboBoxRole.Text);

            if (MainClass.SQL(Qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully.");
                userid = 0;
                txtUsername.Text = ""; // Clear the text box
                txtPassword.Text = "";
                txtName.Text = "";
                txtPhone.Text = "";
                comboBoxRole.SelectedIndex = -1;
                this.Close(); // Close the form after saving
            }
        }
    }
}
