namespace AssetManagementSystem.MainUserControls
{
    partial class RptEmployeeUserControl
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
            this.BtnPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOBILEPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPSTATUSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPTVIEWALLEMPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEWALLEMPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTVIEWALLEMPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWALLEMPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(4, 4);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(75, 23);
            this.BtnPrint.TabIndex = 0;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPIDDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.mOBILEPHONEDataGridViewTextBoxColumn,
            this.tITLEDataGridViewTextBoxColumn,
            this.eMPSTATUSNAMEDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.eMPNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vIEWALLEMPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 236);
            this.dataGridView1.TabIndex = 1;
            // 
            // eMPIDDataGridViewTextBoxColumn
            // 
            this.eMPIDDataGridViewTextBoxColumn.DataPropertyName = "EMPID";
            this.eMPIDDataGridViewTextBoxColumn.HeaderText = "EMPID";
            this.eMPIDDataGridViewTextBoxColumn.Name = "eMPIDDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // mOBILEPHONEDataGridViewTextBoxColumn
            // 
            this.mOBILEPHONEDataGridViewTextBoxColumn.DataPropertyName = "MOBILEPHONE";
            this.mOBILEPHONEDataGridViewTextBoxColumn.HeaderText = "MOBILEPHONE";
            this.mOBILEPHONEDataGridViewTextBoxColumn.Name = "mOBILEPHONEDataGridViewTextBoxColumn";
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            // 
            // eMPSTATUSNAMEDataGridViewTextBoxColumn
            // 
            this.eMPSTATUSNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMPSTATUSNAME";
            this.eMPSTATUSNAMEDataGridViewTextBoxColumn.HeaderText = "EMPSTATUSNAME";
            this.eMPSTATUSNAMEDataGridViewTextBoxColumn.Name = "eMPSTATUSNAMEDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // eMPNAMEDataGridViewTextBoxColumn
            // 
            this.eMPNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMPNAME";
            this.eMPNAMEDataGridViewTextBoxColumn.HeaderText = "EMPNAME";
            this.eMPNAMEDataGridViewTextBoxColumn.Name = "eMPNAMEDataGridViewTextBoxColumn";
            // 
            // rPTVIEWALLEMPBindingSource
            // 
            this.rPTVIEWALLEMPBindingSource.DataSource = typeof(AssetManagementSystem.RPTVIEWALLEMP);
            // 
            // vIEWALLEMPBindingSource
            // 
            this.vIEWALLEMPBindingSource.DataSource = typeof(AssetManagementSystem.VIEWALLEMP);
            // 
            // RptEmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnPrint);
            this.Name = "RptEmployeeUserControl";
            this.Size = new System.Drawing.Size(775, 269);
            this.Load += new System.EventHandler(this.RptEmployeeUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTVIEWALLEMPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWALLEMPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOBILEPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPSTATUSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rPTVIEWALLEMPBindingSource;
        private System.Windows.Forms.BindingSource vIEWALLEMPBindingSource;
    }
}
