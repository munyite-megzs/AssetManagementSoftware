﻿namespace AssetManagementSystem.MainUserControls
{
    partial class RptAssignedUserControl
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
            this.rPTASSIGNEDALLASSETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTASSIGNEDALLASSETBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.rPTASSIGNEDALLASSETBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 243);
            this.dataGridView1.TabIndex = 1;
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
            // rPTASSIGNEDALLASSETBindingSource
            // 
            this.rPTASSIGNEDALLASSETBindingSource.DataSource = typeof(AssetManagementSystem.RPTASSIGNEDALLASSET);
            // 
            // RptAssignedUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnPrint);
            this.Name = "RptAssignedUserControl";
            this.Size = new System.Drawing.Size(826, 279);
            this.Load += new System.EventHandler(this.RptAssignedUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTASSIGNEDALLASSETBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.BindingSource rPTASSIGNEDALLASSETBindingSource;
    }
}
