namespace AssetManagementSystem.MainUserControls
{
    partial class HistoryControl
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
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.FULLDESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIMESTAMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPUTERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FULLDESCRIPTION,
            this.TIMESTAMP,
            this.COMPUTERNAME});
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.Size = new System.Drawing.Size(507, 224);
            this.dgvHistory.TabIndex = 1;
            // 
            // FULLDESCRIPTION
            // 
            this.FULLDESCRIPTION.DataPropertyName = "FULLDESCRIPTION";
            this.FULLDESCRIPTION.HeaderText = "FULLDESCRIPTION";
            this.FULLDESCRIPTION.Name = "FULLDESCRIPTION";
            // 
            // TIMESTAMP
            // 
            this.TIMESTAMP.DataPropertyName = "TIMESTAMP";
            this.TIMESTAMP.HeaderText = "TIMESTAMP";
            this.TIMESTAMP.Name = "TIMESTAMP";
            // 
            // COMPUTERNAME
            // 
            this.COMPUTERNAME.DataPropertyName = "COMPUTERNAME";
            this.COMPUTERNAME.HeaderText = "COMPUTERNAME";
            this.COMPUTERNAME.Name = "COMPUTERNAME";
            // 
            // HistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvHistory);
            this.Name = "HistoryControl";
            this.Size = new System.Drawing.Size(507, 224);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULLDESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIMESTAMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPUTERNAME;
    }
}
