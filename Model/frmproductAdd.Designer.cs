namespace rm.Model
{
    partial class frmproductAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmproductAdd));
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.Txtprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtimage = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtimage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            resources.ApplyResources(this.cbCat, "cbCat");
            this.cbCat.Name = "cbCat";
            this.cbCat.SelectedIndexChanged += new System.EventHandler(this.cbCat_SelectedIndexChanged);
            // 
            // Txtprice
            // 
            resources.ApplyResources(this.Txtprice, "Txtprice");
            this.Txtprice.Name = "Txtprice";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // TxtName
            // 
            resources.ApplyResources(this.TxtName, "TxtName");
            this.TxtName.Name = "TxtName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtimage
            // 
            this.txtimage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.txtimage, "txtimage");
            this.txtimage.Name = "txtimage";
            this.txtimage.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // frmproductAdd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtimage);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.Txtprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Name = "frmproductAdd";
            this.Load += new System.EventHandler(this.frmproductAdd_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Txtprice, 0);
            this.Controls.SetChildIndex(this.cbCat, 0);
            this.Controls.SetChildIndex(this.txtimage, 0);
            this.Controls.SetChildIndex(this.btnBrowse, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbCat;
        public System.Windows.Forms.TextBox Txtprice;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox txtimage;
        private System.Windows.Forms.Button btnBrowse;
    }
}