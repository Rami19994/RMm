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
    public partial class ucProduct : UserControl
    {
        internal int invoiceid;
        internal int id;
        internal int proID;
        public ucProduct()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;

        public int d { get; set; }

        public string PPrice { get; set; }

       
        public string PCategory { get; set; }
        public string PName
        {
            get { return lablName.Text; }
            set { lablName.Text = value; }
        }

        public Image pImage
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }

        private void txtImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this,e);
        }
    }
}
