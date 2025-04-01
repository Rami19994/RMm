using rm.Model;
using rm.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rm
{
    public partial class FrmMain : Form
    {
        public static object Instance { get; internal set; }

        public FrmMain()
        {
            InitializeComponent();
        }



        public void AddControls(Form f)
        {


            CenterPanel.Controls.Clear();  // تنظيف الـ Panel قبل إضافة الفورم الجديد
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            CenterPanel.Controls.Add(f);
            f.Show();
        }


        private void FlowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = MainClass.USER;
           
            AddControls(new frmTableSelect());

            

        }


        private void BtnHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmTableSelect());
        }





        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Btncategory_Click(object sender, EventArgs e)
        {
            if (MainClass.ROLE.Equals("Cashier", StringComparison.OrdinalIgnoreCase))
            {
                // إذا كان دور المستخدم Cashier، نوقف تنفيذ الدالة
                return;
            }

            // باقي الكود الخاص بالزر سيتم تنفيذه فقط إذا لم يكن الدور Cashier
            FrmcategoryView frm = new FrmcategoryView();
            frm.Show();
        }
        

        private void BtnProdacts_Click(object sender, EventArgs e)
        {
            if (MainClass.ROLE.Equals("Cashier", StringComparison.OrdinalIgnoreCase))
            {
                // إذا كان دور المستخدم Cashier، نوقف تنفيذ الدالة
                return;
            }

            frmProductView frm = new frmProductView();
            frm.Show();


        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            if (MainClass.ROLE.Equals("Cashier", StringComparison.OrdinalIgnoreCase))
            {
                // إذا كان دور المستخدم Cashier، نوقف تنفيذ الدالة
                return;
            }


            frmStaffView frmStaffView = new frmStaffView();
            frmStaffView.Show();



        }

        private void BtnPos_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.Show();
        }

        private void BtnKitchen_Click(object sender, EventArgs e)
        {
            frmKetchnView frm = new frmKetchnView();
            frm.Show();


        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            if (MainClass.ROLE.Equals("Cashier", StringComparison.OrdinalIgnoreCase))
            {
                // إذا كان دور المستخدم Cashier، نوقف تنفيذ الدالة
                return;
            }

            frmsitteng frm = new frmsitteng();
            frm.Show();


        }

        private void BtnTable_Click(object sender, EventArgs e)
        {
            if (MainClass.ROLE.Equals("Cashier", StringComparison.OrdinalIgnoreCase))
            {
                // إذا كان دور المستخدم Cashier، نوقف تنفيذ الدالة
                return;
            }

            frmTableView frm = new frmTableView();
            frm.Show();



        }

        public void btnReports_Click(object sender, EventArgs e)
        {
            if (MainClass.ROLE.Equals("Cashier", StringComparison.OrdinalIgnoreCase))
            {
                // إذا كان دور المستخدم Cashier، نوقف تنفيذ الدالة
                return;
            }


            AddControls(new frmReports());


        }


       

    }


}

    


