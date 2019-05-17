namespace AssetManagementSystem.MainUserControls
{
    partial class VendorUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorUserControl));
            this.dgvVendor = new System.Windows.Forms.DataGridView();
            this.vENDORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDORNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wEBSITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSTALADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOWNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUNTRYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonNewVendor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripAllAssets = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDORBindingSource)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStripAllAssets.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVendor
            // 
            this.dgvVendor.AutoGenerateColumns = false;
            this.dgvVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vENDORNAMEDataGridViewTextBoxColumn,
            this.vENDORNODataGridViewTextBoxColumn,
            this.pHONENODataGridViewTextBoxColumn,
            this.wEBSITEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.cONTACTNAMEDataGridViewTextBoxColumn,
            this.pOSTALADDRESSDataGridViewTextBoxColumn,
            this.tOWNDataGridViewTextBoxColumn,
            this.cOUNTRYDataGridViewTextBoxColumn});
            this.dgvVendor.DataSource = this.vENDORBindingSource;
            this.dgvVendor.Location = new System.Drawing.Point(3, 53);
            this.dgvVendor.Name = "dgvVendor";
            this.dgvVendor.Size = new System.Drawing.Size(950, 242);
            this.dgvVendor.TabIndex = 0;
            this.dgvVendor.DoubleClick += new System.EventHandler(this.DgvVendor_DoubleClick);
            // 
            // vENDORNAMEDataGridViewTextBoxColumn
            // 
            this.vENDORNAMEDataGridViewTextBoxColumn.DataPropertyName = "VENDORNAME";
            this.vENDORNAMEDataGridViewTextBoxColumn.HeaderText = "VENDORNAME";
            this.vENDORNAMEDataGridViewTextBoxColumn.Name = "vENDORNAMEDataGridViewTextBoxColumn";
            // 
            // vENDORNODataGridViewTextBoxColumn
            // 
            this.vENDORNODataGridViewTextBoxColumn.DataPropertyName = "VENDORNO";
            this.vENDORNODataGridViewTextBoxColumn.HeaderText = "VENDORNO";
            this.vENDORNODataGridViewTextBoxColumn.Name = "vENDORNODataGridViewTextBoxColumn";
            // 
            // pHONENODataGridViewTextBoxColumn
            // 
            this.pHONENODataGridViewTextBoxColumn.DataPropertyName = "PHONENO";
            this.pHONENODataGridViewTextBoxColumn.HeaderText = "PHONENO";
            this.pHONENODataGridViewTextBoxColumn.Name = "pHONENODataGridViewTextBoxColumn";
            // 
            // wEBSITEDataGridViewTextBoxColumn
            // 
            this.wEBSITEDataGridViewTextBoxColumn.DataPropertyName = "WEBSITE";
            this.wEBSITEDataGridViewTextBoxColumn.HeaderText = "WEBSITE";
            this.wEBSITEDataGridViewTextBoxColumn.Name = "wEBSITEDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // cONTACTNAMEDataGridViewTextBoxColumn
            // 
            this.cONTACTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CONTACTNAME";
            this.cONTACTNAMEDataGridViewTextBoxColumn.HeaderText = "CONTACTNAME";
            this.cONTACTNAMEDataGridViewTextBoxColumn.Name = "cONTACTNAMEDataGridViewTextBoxColumn";
            // 
            // pOSTALADDRESSDataGridViewTextBoxColumn
            // 
            this.pOSTALADDRESSDataGridViewTextBoxColumn.DataPropertyName = "POSTALADDRESS";
            this.pOSTALADDRESSDataGridViewTextBoxColumn.HeaderText = "POSTALADDRESS";
            this.pOSTALADDRESSDataGridViewTextBoxColumn.Name = "pOSTALADDRESSDataGridViewTextBoxColumn";
            // 
            // tOWNDataGridViewTextBoxColumn
            // 
            this.tOWNDataGridViewTextBoxColumn.DataPropertyName = "TOWN";
            this.tOWNDataGridViewTextBoxColumn.HeaderText = "TOWN";
            this.tOWNDataGridViewTextBoxColumn.Name = "tOWNDataGridViewTextBoxColumn";
            // 
            // cOUNTRYDataGridViewTextBoxColumn
            // 
            this.cOUNTRYDataGridViewTextBoxColumn.DataPropertyName = "COUNTRY";
            this.cOUNTRYDataGridViewTextBoxColumn.HeaderText = "COUNTRY";
            this.cOUNTRYDataGridViewTextBoxColumn.Name = "cOUNTRYDataGridViewTextBoxColumn";
            // 
            // vENDORBindingSource
            // 
            this.vENDORBindingSource.DataSource = typeof(AssetManagementSystem.VENDOR);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonNewVendor,
            this.toolStripSeparator1,
            this.ToolStripButtonEdit,
            this.toolStripSeparator2,
            this.ToolStripButtonDelete});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(956, 25);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ToolStripButtonNewVendor
            // 
            this.ToolStripButtonNewVendor.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonNewVendor.Image")));
            this.ToolStripButtonNewVendor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonNewVendor.Name = "ToolStripButtonNewVendor";
            this.ToolStripButtonNewVendor.Size = new System.Drawing.Size(88, 22);
            this.ToolStripButtonNewVendor.Text = "NewVendor";
            this.ToolStripButtonNewVendor.Click += new System.EventHandler(this.ToolStripButtonNewVendor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButtonEdit
            // 
            this.ToolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonEdit.Image")));
            this.ToolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            this.ToolStripButtonEdit.Size = new System.Drawing.Size(47, 22);
            this.ToolStripButtonEdit.Text = "Edit";
            this.ToolStripButtonEdit.Click += new System.EventHandler(this.ToolStripButtonEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButtonDelete
            // 
            this.ToolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonDelete.Image")));
            this.ToolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new System.Drawing.Size(60, 22);
            this.ToolStripButtonDelete.Text = "Delete";
            this.ToolStripButtonDelete.Click += new System.EventHandler(this.ToolStripButtonDelete_Click);
            // 
            // toolStripAllAssets
            // 
            this.toolStripAllAssets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStripAllAssets.Location = new System.Drawing.Point(0, 0);
            this.toolStripAllAssets.Name = "toolStripAllAssets";
            this.toolStripAllAssets.Size = new System.Drawing.Size(956, 25);
            this.toolStripAllAssets.TabIndex = 6;
            this.toolStripAllAssets.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(97, 22);
            this.toolStripLabel1.Text = "All Vendors";
            // 
            // VendorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStripAllAssets);
            this.Controls.Add(this.dgvVendor);
            this.Name = "VendorUserControl";
            this.Size = new System.Drawing.Size(956, 299);
            this.Load += new System.EventHandler(this.VendorUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDORBindingSource)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStripAllAssets.ResumeLayout(false);
            this.toolStripAllAssets.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENDORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENDORNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wEBSITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSTALADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOWNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUNTRYDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vENDORBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton ToolStripButtonNewVendor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ToolStripButtonDelete;
        private System.Windows.Forms.ToolStrip toolStripAllAssets;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}
