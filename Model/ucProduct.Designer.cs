using System.Windows.Forms;

namespace rm.Model
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduct));
            this.txtImage = new System.Windows.Forms.PictureBox();
            this.panl1 = new System.Windows.Forms.FlowlyoutPanel();
            this.lablName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.panl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtImage
            // 
            this.txtImage.Image = ((System.Drawing.Image)(resources.GetObject("txtImage.Image")));
            this.txtImage.Location = new System.Drawing.Point(55, 3);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(123, 119);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtImage.TabIndex = 0;
            this.txtImage.TabStop = false;
            this.txtImage.Click += new System.EventHandler(this.txtImage_Click);
            // 
            // panl1
            // 
            this.panl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panl1.Controls.Add(this.lablName);
            this.panl1.Location = new System.Drawing.Point(19, 128);
            this.panl1.Name = "panl1";
            this.panl1.Size = new System.Drawing.Size(209, 88);
            this.panl1.TabIndex = 1;
            // 
            // lablName
            // 
            this.lablName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lablName.AutoSize = true;
            this.lablName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lablName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablName.Location = new System.Drawing.Point(3, 0);
            this.lablName.Name = "lablName";
            this.lablName.Size = new System.Drawing.Size(201, 33);
            this.lablName.TabIndex = 0;
            this.lablName.Text = "product Name";
            this.lablName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panl1);
            this.panel1.Controls.Add(this.txtImage);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 230);
            this.panel1.TabIndex = 0;
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(260, 246);
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.panl1.ResumeLayout(false);
            this.panl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        public PictureBox txtImage;
        private FlowlyoutPanel panl1;
        public Label lablName;
        public Panel panel1;
    }
}
