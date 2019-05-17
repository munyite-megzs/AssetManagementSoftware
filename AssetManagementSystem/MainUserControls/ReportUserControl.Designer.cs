namespace AssetManagementSystem.MainUserControls
{
    partial class ReportUserControl
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.BtnAllAssets = new System.Windows.Forms.Button();
            this.BtnAssignedAssets = new System.Windows.Forms.Button();
            this.BtnUnAssignedAssets = new System.Windows.Forms.Button();
            this.BtnAllEmployees = new System.Windows.Forms.Button();
            this.rptAllAssetsUserControl1 = new AssetManagementSystem.MainUserControls.RptAllAssetsUserControl();
            this.rptAssignedUserControl1 = new AssetManagementSystem.MainUserControls.RptAssignedUserControl();
            this.rptEmployeeUserControl1 = new AssetManagementSystem.MainUserControls.RptEmployeeUserControl();
            this.unassignedUserControl1 = new AssetManagementSystem.MainUserControls.UnassignedUserControl();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(104, 32);
            this.toolStripLabel1.Text = "Reports";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 35);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(190, 239);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // BtnAllAssets
            // 
            this.BtnAllAssets.Location = new System.Drawing.Point(18, 56);
            this.BtnAllAssets.Name = "BtnAllAssets";
            this.BtnAllAssets.Size = new System.Drawing.Size(115, 23);
            this.BtnAllAssets.TabIndex = 2;
            this.BtnAllAssets.Text = "All Assets";
            this.BtnAllAssets.UseVisualStyleBackColor = true;
            this.BtnAllAssets.Click += new System.EventHandler(this.BtnAllAssets_Click);
            // 
            // BtnAssignedAssets
            // 
            this.BtnAssignedAssets.Location = new System.Drawing.Point(18, 105);
            this.BtnAssignedAssets.Name = "BtnAssignedAssets";
            this.BtnAssignedAssets.Size = new System.Drawing.Size(115, 23);
            this.BtnAssignedAssets.TabIndex = 2;
            this.BtnAssignedAssets.Text = "Assigned Assets";
            this.BtnAssignedAssets.UseVisualStyleBackColor = true;
            this.BtnAssignedAssets.Click += new System.EventHandler(this.BtnAssignedAssets_Click);
            // 
            // BtnUnAssignedAssets
            // 
            this.BtnUnAssignedAssets.Location = new System.Drawing.Point(18, 155);
            this.BtnUnAssignedAssets.Name = "BtnUnAssignedAssets";
            this.BtnUnAssignedAssets.Size = new System.Drawing.Size(115, 23);
            this.BtnUnAssignedAssets.TabIndex = 2;
            this.BtnUnAssignedAssets.Text = "Unassigned Assets";
            this.BtnUnAssignedAssets.UseVisualStyleBackColor = true;
            this.BtnUnAssignedAssets.Click += new System.EventHandler(this.BtnUnAssignedAssets_Click);
            // 
            // BtnAllEmployees
            // 
            this.BtnAllEmployees.Location = new System.Drawing.Point(18, 207);
            this.BtnAllEmployees.Name = "BtnAllEmployees";
            this.BtnAllEmployees.Size = new System.Drawing.Size(115, 23);
            this.BtnAllEmployees.TabIndex = 2;
            this.BtnAllEmployees.Text = "All Employees";
            this.BtnAllEmployees.UseVisualStyleBackColor = true;
            this.BtnAllEmployees.Click += new System.EventHandler(this.BtnAllEmployees_Click);
            // 
            // rptAllAssetsUserControl1
            // 
            this.rptAllAssetsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptAllAssetsUserControl1.Location = new System.Drawing.Point(190, 35);
            this.rptAllAssetsUserControl1.Name = "rptAllAssetsUserControl1";
            this.rptAllAssetsUserControl1.Size = new System.Drawing.Size(653, 239);
            this.rptAllAssetsUserControl1.TabIndex = 3;
            // 
            // rptAssignedUserControl1
            // 
            this.rptAssignedUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptAssignedUserControl1.Location = new System.Drawing.Point(190, 35);
            this.rptAssignedUserControl1.Name = "rptAssignedUserControl1";
            this.rptAssignedUserControl1.Size = new System.Drawing.Size(653, 239);
            this.rptAssignedUserControl1.TabIndex = 4;
            // 
            // rptEmployeeUserControl1
            // 
            this.rptEmployeeUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptEmployeeUserControl1.Location = new System.Drawing.Point(190, 35);
            this.rptEmployeeUserControl1.Name = "rptEmployeeUserControl1";
            this.rptEmployeeUserControl1.Size = new System.Drawing.Size(653, 239);
            this.rptEmployeeUserControl1.TabIndex = 5;
            // 
            // unassignedUserControl1
            // 
            this.unassignedUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unassignedUserControl1.Location = new System.Drawing.Point(190, 35);
            this.unassignedUserControl1.Name = "unassignedUserControl1";
            this.unassignedUserControl1.Size = new System.Drawing.Size(653, 239);
            this.unassignedUserControl1.TabIndex = 6;
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.unassignedUserControl1);
            this.Controls.Add(this.rptEmployeeUserControl1);
            this.Controls.Add(this.rptAssignedUserControl1);
            this.Controls.Add(this.rptAllAssetsUserControl1);
            this.Controls.Add(this.BtnAllEmployees);
            this.Controls.Add(this.BtnUnAssignedAssets);
            this.Controls.Add(this.BtnAssignedAssets);
            this.Controls.Add(this.BtnAllAssets);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(843, 274);
            this.Load += new System.EventHandler(this.ReportUserControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button BtnAllAssets;
        private System.Windows.Forms.Button BtnAssignedAssets;
        private System.Windows.Forms.Button BtnUnAssignedAssets;
        private System.Windows.Forms.Button BtnAllEmployees;
        private RptAllAssetsUserControl rptAllAssetsUserControl1;
        private RptAssignedUserControl rptAssignedUserControl1;
        private RptEmployeeUserControl rptEmployeeUserControl1;
        private UnassignedUserControl unassignedUserControl1;
    }
}
