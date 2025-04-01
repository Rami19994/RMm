using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            texpass.PasswordChar = '*';  
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string username = texuser.Text;
            string password = texpass.Text;
            MessageBox.Show($"Username: {username}");

            if (MainClass.IsValidUser(username, password) == false)
            {
                MessageBox.Show("error");
            }
            else
            {
                this.Hide();
                FrmMain frm = new FrmMain();
                frm.Show();
            }
        }
    }
}
