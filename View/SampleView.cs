using System;
using System.Windows.Forms;

namespace rm
{
    
    public partial class SampleView : Form
    {
        public SampleView()
        {
            InitializeComponent();
        }

        
        public virtual void BtnAdd_Click(object sender, EventArgs e)
        {
            
        }

       
        public virtual void TxtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        
        private void SampleView_Load(object sender, EventArgs e)
        {
            try
            {
                
                if (this.categoryTableAdapter != null && this.rMDataSet != null)
                {
                    this.categoryTableAdapter.Fill(this.rMDataSet.category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
