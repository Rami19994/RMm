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
    public partial class frmTableAdd : SamplAdd
    {
        public frmTableAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void BtnSave_Click(object sender, EventArgs e)
        {
            string Qry = "";

            if (id == 0) // Insert
            {
                Qry = "INSERT INTO tables (tName) VALUES (@Name)";
            }
            else // Update
            {
                Qry = "UPDATE tables SET tName = @Name WHERE tID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", TxtName.Text);

            if (MainClass.SQL(Qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully.");
                id = 0;
                TxtName.Text = ""; // Clear the text box
                this.Close(); // Close the form after saving
            }
        }

        public override void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }
    }
}

