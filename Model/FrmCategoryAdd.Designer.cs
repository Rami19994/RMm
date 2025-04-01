namespace rm.Model
{
    partial class FrmCategoryAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoryAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(113, 269);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(438, 58);
            this.TxtName.TabIndex = 3;
            // 
            // FrmCategoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 589);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCategoryAdd";
            this.Text = "Category Add";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtName;
    }
}