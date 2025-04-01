using System;
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
    public partial class frmAddcustomer : Form
    {
        public frmAddcustomer()
        {
            InitializeComponent();
        }
        public string orderType = "";
        public int DriverID = 0;
        public int mainID = 0;

        private void frmAddcustomer_Load(object sender, EventArgs e)
        {
            if (orderType =="Take Away")
            {
                txtDraiver.Visible=false;
                cbDriver.Visible=false;
            }
            string qry = "SELECT staffID AS id, sName AS name FROM staff WHERE sRole = 'Driver'";
            MainClass.CBFill(qry, cbDriver);
            if (mainID > 0)
            {
                cbDriver.SelectedValue=DriverID;

            }
        }

        private void cbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriverID =Convert.ToInt32(cbDriver.SelectedValue);
        }
    }
}
