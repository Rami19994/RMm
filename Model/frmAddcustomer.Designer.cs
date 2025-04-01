namespace rm.Model
{
    partial class frmAddcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddcustomer));
            this.cbDriver = new System.Windows.Forms.ComboBox();
            this.txtDraiver = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDriver
            // 
            this.cbDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDriver.FormattingEnabled = true;
            this.cbDriver.Items.AddRange(new object[] {
            "Cashier ",
            "Waiter",
            "Cleaning",
            "Capten",
            "Shif",
            "Maneger",
            "Other"});
            this.cbDriver.Location = new System.Drawing.Point(13, 42);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(199, 34);
            this.cbDriver.TabIndex = 1;
            this.cbDriver.SelectedIndexChanged += new System.EventHandler(this.cbDriver_SelectedIndexChanged);
            // 
            // txtDraiver
            // 
            this.txtDraiver.AutoSize = true;
            this.txtDraiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDraiver.Location = new System.Drawing.Point(13, 10);
            this.txtDraiver.Name = "txtDraiver";
            this.txtDraiver.Size = new System.Drawing.Size(97, 29);
            this.txtDraiver.TabIndex = 4;
            this.txtDraiver.Text = "Draiver";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(13, 111);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(237, 26);
            this.TxtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Add Customer info";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 85);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtDraiver);
            this.flowLayoutPanel2.Controls.Add(this.cbDriver);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.TxtName);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtPhone);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(47, 144);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(477, 282);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(13, 172);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(237, 27);
            this.txtPhone.TabIndex = 3;
            // 
            // frmAddcustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(571, 531);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddcustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.frmAddcustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cbDriver;
        public System.Windows.Forms.Label txtDraiver;
        public System.Windows.Forms.TextBox TxtName;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.Label label4;
    }
}