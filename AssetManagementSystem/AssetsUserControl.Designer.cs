namespace AssetManagementSystem.MainUserControls
{
    partial class AssetsUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetsUserControl));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripAllAssets = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dgvAllAssets = new System.Windows.Forms.DataGridView();
            this.ASSETNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSETTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRAND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIALNUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUSNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPTALLASSETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEWALLASSETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSSETTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCATIONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONDITIONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSSETNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANUFACTURERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRANDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERIALNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2.SuspendLayout();
            this.toolStripAllAssets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTALLASSETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWALLASSETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(861, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton1.Text = "NewAsset";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton2.Text = "Edit";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton3.Text = "Delete";
            // 
            // toolStripAllAssets
            // 
            this.toolStripAllAssets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStripAllAssets.Location = new System.Drawing.Point(0, 0);
            this.toolStripAllAssets.Name = "toolStripAllAssets";
            this.toolStripAllAssets.Size = new System.Drawing.Size(861, 25);
            this.toolStripAllAssets.TabIndex = 4;
            this.toolStripAllAssets.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(82, 22);
            this.toolStripLabel1.Text = "All Assets";
            // 
            // dgvAllAssets
            // 
            this.dgvAllAssets.AutoGenerateColumns = false;
            this.dgvAllAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ASSETNO,
            this.ASSETTYPE,
            this.DESCRIPTION,
            this.BRAND,
            this.EMPNAME,
            this.DUEDATE,
            this.SERIALNUMBER,
            this.STATUSNAME,
            this.aSSETTYPEDataGridViewTextBoxColumn,
            this.sTATUSNAMEDataGridViewTextBoxColumn,
            this.lOCATIONNAMEDataGridViewTextBoxColumn,
            this.cONDITIONNAMEDataGridViewTextBoxColumn,
            this.aSSETNODataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.mANUFACTURERDataGridViewTextBoxColumn,
            this.bRANDDataGridViewTextBoxColumn,
            this.sERIALNUMBERDataGridViewTextBoxColumn,
            this.eMPNAMEDataGridViewTextBoxColumn,
            this.dUEDATEDataGridViewTextBoxColumn,
            this.nOTESDataGridViewTextBoxColumn});
            this.dgvAllAssets.DataSource = this.vIEWALLASSETBindingSource;
            this.dgvAllAssets.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAllAssets.Location = new System.Drawing.Point(0, 50);
            this.dgvAllAssets.Name = "dgvAllAssets";
            this.dgvAllAssets.Size = new System.Drawing.Size(861, 409);
            this.dgvAllAssets.TabIndex = 6;
            // 
            // ASSETNO
            // 
            this.ASSETNO.DataPropertyName = "ASSETNO";
            this.ASSETNO.HeaderText = "ASSETNO";
            this.ASSETNO.Name = "ASSETNO";
            // 
            // ASSETTYPE
            // 
            this.ASSETTYPE.DataPropertyName = "ASSETTYPE";
            this.ASSETTYPE.HeaderText = "ASSETTYPE";
            this.ASSETTYPE.Name = "ASSETTYPE";
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.DataPropertyName = "DESCRIPTION";
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            // 
            // BRAND
            // 
            this.BRAND.DataPropertyName = "BRAND";
            this.BRAND.HeaderText = "BRAND";
            this.BRAND.Name = "BRAND";
            // 
            // EMPNAME
            // 
            this.EMPNAME.DataPropertyName = "EMPNAME";
            this.EMPNAME.HeaderText = "CUSTODIAN";
            this.EMPNAME.Name = "EMPNAME";
            // 
            // DUEDATE
            // 
            this.DUEDATE.DataPropertyName = "DUEDATE";
            this.DUEDATE.HeaderText = "DUEDATE";
            this.DUEDATE.Name = "DUEDATE";
            // 
            // SERIALNUMBER
            // 
            this.SERIALNUMBER.DataPropertyName = "SERIALNUMBER";
            this.SERIALNUMBER.HeaderText = "SERIALNUMBER";
            this.SERIALNUMBER.Name = "SERIALNUMBER";
            // 
            // STATUSNAME
            // 
            this.STATUSNAME.DataPropertyName = "STATUSNAME";
            this.STATUSNAME.HeaderText = "STATUS";
            this.STATUSNAME.Name = "STATUSNAME";
            // 
            // rPTALLASSETBindingSource
            // 
            this.rPTALLASSETBindingSource.DataSource = typeof(AssetManagementSystem.RPTALLASSET);
            // 
            // vIEWALLASSETBindingSource
            // 
            this.vIEWALLASSETBindingSource.DataSource = typeof(AssetManagementSystem.VIEWALLASSET);
            // 
            // aSSETTYPEDataGridViewTextBoxColumn
            // 
            this.aSSETTYPEDataGridViewTextBoxColumn.DataPropertyName = "ASSETTYPE";
            this.aSSETTYPEDataGridViewTextBoxColumn.HeaderText = "ASSETTYPE";
            this.aSSETTYPEDataGridViewTextBoxColumn.Name = "aSSETTYPEDataGridViewTextBoxColumn";
            // 
            // sTATUSNAMEDataGridViewTextBoxColumn
            // 
            this.sTATUSNAMEDataGridViewTextBoxColumn.DataPropertyName = "STATUSNAME";
            this.sTATUSNAMEDataGridViewTextBoxColumn.HeaderText = "STATUSNAME";
            this.sTATUSNAMEDataGridViewTextBoxColumn.Name = "sTATUSNAMEDataGridViewTextBoxColumn";
            // 
            // lOCATIONNAMEDataGridViewTextBoxColumn
            // 
            this.lOCATIONNAMEDataGridViewTextBoxColumn.DataPropertyName = "LOCATIONNAME";
            this.lOCATIONNAMEDataGridViewTextBoxColumn.HeaderText = "LOCATIONNAME";
            this.lOCATIONNAMEDataGridViewTextBoxColumn.Name = "lOCATIONNAMEDataGridViewTextBoxColumn";
            // 
            // cONDITIONNAMEDataGridViewTextBoxColumn
            // 
            this.cONDITIONNAMEDataGridViewTextBoxColumn.DataPropertyName = "CONDITIONNAME";
            this.cONDITIONNAMEDataGridViewTextBoxColumn.HeaderText = "CONDITIONNAME";
            this.cONDITIONNAMEDataGridViewTextBoxColumn.Name = "cONDITIONNAMEDataGridViewTextBoxColumn";
            // 
            // aSSETNODataGridViewTextBoxColumn
            // 
            this.aSSETNODataGridViewTextBoxColumn.DataPropertyName = "ASSETNO";
            this.aSSETNODataGridViewTextBoxColumn.HeaderText = "ASSETNO";
            this.aSSETNODataGridViewTextBoxColumn.Name = "aSSETNODataGridViewTextBoxColumn";
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // mANUFACTURERDataGridViewTextBoxColumn
            // 
            this.mANUFACTURERDataGridViewTextBoxColumn.DataPropertyName = "MANUFACTURER";
            this.mANUFACTURERDataGridViewTextBoxColumn.HeaderText = "MANUFACTURER";
            this.mANUFACTURERDataGridViewTextBoxColumn.Name = "mANUFACTURERDataGridViewTextBoxColumn";
            // 
            // bRANDDataGridViewTextBoxColumn
            // 
            this.bRANDDataGridViewTextBoxColumn.DataPropertyName = "BRAND";
            this.bRANDDataGridViewTextBoxColumn.HeaderText = "BRAND";
            this.bRANDDataGridViewTextBoxColumn.Name = "bRANDDataGridViewTextBoxColumn";
            // 
            // sERIALNUMBERDataGridViewTextBoxColumn
            // 
            this.sERIALNUMBERDataGridViewTextBoxColumn.DataPropertyName = "SERIALNUMBER";
            this.sERIALNUMBERDataGridViewTextBoxColumn.HeaderText = "SERIALNUMBER";
            this.sERIALNUMBERDataGridViewTextBoxColumn.Name = "sERIALNUMBERDataGridViewTextBoxColumn";
            // 
            // eMPNAMEDataGridViewTextBoxColumn
            // 
            this.eMPNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMPNAME";
            this.eMPNAMEDataGridViewTextBoxColumn.HeaderText = "EMPNAME";
            this.eMPNAMEDataGridViewTextBoxColumn.Name = "eMPNAMEDataGridViewTextBoxColumn";
            // 
            // dUEDATEDataGridViewTextBoxColumn
            // 
            this.dUEDATEDataGridViewTextBoxColumn.DataPropertyName = "DUEDATE";
            this.dUEDATEDataGridViewTextBoxColumn.HeaderText = "DUEDATE";
            this.dUEDATEDataGridViewTextBoxColumn.Name = "dUEDATEDataGridViewTextBoxColumn";
            // 
            // nOTESDataGridViewTextBoxColumn
            // 
            this.nOTESDataGridViewTextBoxColumn.DataPropertyName = "NOTES";
            this.nOTESDataGridViewTextBoxColumn.HeaderText = "NOTES";
            this.nOTESDataGridViewTextBoxColumn.Name = "nOTESDataGridViewTextBoxColumn";
            // 
            // AssetsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAllAssets);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStripAllAssets);
            this.Name = "AssetsUserControl";
            this.Size = new System.Drawing.Size(861, 462);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStripAllAssets.ResumeLayout(false);
            this.toolStripAllAssets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTALLASSETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWALLASSETBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStrip toolStripAllAssets;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgvAllAssets;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSETNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSETTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRAND;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUEDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIALNUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUSNAME;
        private System.Windows.Forms.BindingSource rPTALLASSETBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSSETTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCATIONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONDITIONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSSETNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANUFACTURERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sERIALNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTESDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vIEWALLASSETBindingSource;
    }
}
