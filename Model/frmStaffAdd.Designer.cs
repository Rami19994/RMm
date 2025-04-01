namespace rm.Model
{
    partial class frmStaffAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffAdd));
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtphone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(47, 202);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(438, 40);
            this.TxtName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Role";
            // 
            // Txtphone
            // 
            this.Txtphone.Location = new System.Drawing.Point(513, 202);
            this.Txtphone.Multiline = true;
            this.Txtphone.Name = "Txtphone";
            this.Txtphone.Size = new System.Drawing.Size(438, 40);
            this.Txtphone.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Cashier ",
            "Waiter",
            "Cleaning",
            "Capten",
            "Shif",
            "Maneger",
            "Driver",
            "Other"});
            this.cbRole.Location = new System.Drawing.Point(47, 386);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(185, 28);
            this.cbRole.TabIndex = 12;
            // 
            // frmStaffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 620);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.Txtphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStaffAdd";
            this.Text = "Staff Add";
            this.Load += new System.EventHandler(this.frmStaffAdd_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Txtphone, 0);
            this.Controls.SetChildIndex(this.cbRole, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Txtphone;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbRole;
    }
}