namespace rm.View
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.remoteReportProxyBase1 = new CrystalDecisions.Shared.RemoteReportProxyBase();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnstaff = new System.Windows.Forms.Button();
            this.btnselectcat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // remoteReportProxyBase1
            // 
            this.remoteReportProxyBase1.Credentials = null;
            this.remoteReportProxyBase1.ReportServiceVersionHeaderValue = null;
            this.remoteReportProxyBase1.Url = "http://localhost/websamples/Chart_src_genproxy.asmx";
            this.remoteReportProxyBase1.UseDefaultCredentials = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(86)))));
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(106, 113);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(286, 136);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Poudect Report";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnstaff
            // 
            this.btnstaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(86)))));
            this.btnstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstaff.Image = ((System.Drawing.Image)(resources.GetObject("btnstaff.Image")));
            this.btnstaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstaff.Location = new System.Drawing.Point(439, 113);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(296, 136);
            this.btnstaff.TabIndex = 1;
            this.btnstaff.Text = "Staff Report";
            this.btnstaff.UseVisualStyleBackColor = false;
            this.btnstaff.Click += new System.EventHandler(this.btnstaff_Click);
            // 
            // btnselectcat
            // 
            this.btnselectcat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(86)))));
            this.btnselectcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselectcat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnselectcat.Image = ((System.Drawing.Image)(resources.GetObject("btnselectcat.Image")));
            this.btnselectcat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnselectcat.Location = new System.Drawing.Point(782, 113);
            this.btnselectcat.Name = "btnselectcat";
            this.btnselectcat.Size = new System.Drawing.Size(312, 136);
            this.btnselectcat.TabIndex = 2;
            this.btnselectcat.Text = "Sels by Category";
            this.btnselectcat.UseVisualStyleBackColor = false;
            this.btnselectcat.Click += new System.EventHandler(this.btnselectcat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reports";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1206, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnselectcat);
            this.Controls.Add(this.btnstaff);
            this.Controls.Add(this.btnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Shared.RemoteReportProxyBase remoteReportProxyBase1;
        public System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.Button btnstaff;
        public System.Windows.Forms.Button btnselectcat;
        private System.Windows.Forms.Label label1;
    }
}