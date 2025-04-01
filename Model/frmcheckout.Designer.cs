namespace rm.Model
{
    partial class frmcheckout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcheckout));
            this.TxtBillAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRceived = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            // 
            // TxtBillAmount
            // 
            this.TxtBillAmount.Enabled = false;
            this.TxtBillAmount.Location = new System.Drawing.Point(29, 206);
            this.TxtBillAmount.Multiline = true;
            this.TxtBillAmount.Name = "TxtBillAmount";
            this.TxtBillAmount.Size = new System.Drawing.Size(248, 39);
            this.TxtBillAmount.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bill Amount";
            // 
            // TxtChange
            // 
            this.TxtChange.Enabled = false;
            this.TxtChange.Location = new System.Drawing.Point(30, 331);
            this.TxtChange.Multiline = true;
            this.TxtChange.Name = "TxtChange";
            this.TxtChange.Size = new System.Drawing.Size(237, 40);
            this.TxtChange.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Change";
            // 
            // TxtRceived
            // 
            this.TxtRceived.Location = new System.Drawing.Point(307, 206);
            this.TxtRceived.Multiline = true;
            this.TxtRceived.Name = "TxtRceived";
            this.TxtRceived.Size = new System.Drawing.Size(264, 39);
            this.TxtRceived.TabIndex = 13;
            this.TxtRceived.TextChanged += new System.EventHandler(this.TxtRceived_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Payment Received";
            // 
            // frmcheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 694);
            this.Controls.Add(this.TxtRceived);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBillAmount);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcheckout";
            this.Text = "check out";
            this.Load += new System.EventHandler(this.frmcheckout_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtBillAmount, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtChange, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtRceived, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtBillAmount;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtChange;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtRceived;
        public System.Windows.Forms.Label label3;
    }
}