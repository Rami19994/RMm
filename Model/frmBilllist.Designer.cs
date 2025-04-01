namespace rm.Model
{
    partial class frmBilllist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilllist));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvsSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvwaiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvprint = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(29, 25);
            this.BtnSave.Size = new System.Drawing.Size(117, 56);
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(152, 25);
            this.BtnClose.Size = new System.Drawing.Size(115, 56);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvsSno,
            this.dgvtable,
            this.dgvwaiter,
            this.dgvtype,
            this.dgvstatus,
            this.dgvtotal,
            this.dgvedit,
            this.dgvprint});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView1.Location = new System.Drawing.Point(0, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.Size = new System.Drawing.Size(1452, 704);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dgvsSno
            // 
            this.dgvsSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvsSno.HeaderText = "id";
            this.dgvsSno.MinimumWidth = 50;
            this.dgvsSno.Name = "dgvsSno";
            this.dgvsSno.ReadOnly = true;
            this.dgvsSno.Width = 150;
            // 
            // dgvtable
            // 
            this.dgvtable.HeaderText = "Table";
            this.dgvtable.MinimumWidth = 8;
            this.dgvtable.Name = "dgvtable";
            this.dgvtable.ReadOnly = true;
            // 
            // dgvwaiter
            // 
            this.dgvwaiter.HeaderText = "Waiter";
            this.dgvwaiter.MinimumWidth = 8;
            this.dgvwaiter.Name = "dgvwaiter";
            this.dgvwaiter.ReadOnly = true;
            // 
            // dgvtype
            // 
            this.dgvtype.HeaderText = "Order Type";
            this.dgvtype.MinimumWidth = 8;
            this.dgvtype.Name = "dgvtype";
            this.dgvtype.ReadOnly = true;
            // 
            // dgvstatus
            // 
            this.dgvstatus.HeaderText = "Status";
            this.dgvstatus.MinimumWidth = 8;
            this.dgvstatus.Name = "dgvstatus";
            this.dgvstatus.ReadOnly = true;
            // 
            // dgvtotal
            // 
            this.dgvtotal.HeaderText = "Total";
            this.dgvtotal.MinimumWidth = 8;
            this.dgvtotal.Name = "dgvtotal";
            this.dgvtotal.ReadOnly = true;
            // 
            // dgvedit
            // 
            this.dgvedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvedit.FillWeight = 50F;
            this.dgvedit.HeaderText = "Edit";
            this.dgvedit.Image = ((System.Drawing.Image)(resources.GetObject("dgvedit.Image")));
            this.dgvedit.MinimumWidth = 100;
            this.dgvedit.Name = "dgvedit";
            this.dgvedit.ReadOnly = true;
            this.dgvedit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvedit.Width = 150;
            // 
            // dgvprint
            // 
            this.dgvprint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvprint.HeaderText = "print";
            this.dgvprint.Image = ((System.Drawing.Image)(resources.GetObject("dgvprint.Image")));
            this.dgvprint.MinimumWidth = 50;
            this.dgvprint.Name = "dgvprint";
            this.dgvprint.ReadOnly = true;
            this.dgvprint.Width = 150;
            // 
            // frmBilllist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 983);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBilllist";
            this.Text = "Bill list";
            this.Load += new System.EventHandler(this.frmBilllist_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvwaiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtotal;
        private System.Windows.Forms.DataGridViewImageColumn dgvedit;
        private System.Windows.Forms.DataGridViewImageColumn dgvprint;
    }
}