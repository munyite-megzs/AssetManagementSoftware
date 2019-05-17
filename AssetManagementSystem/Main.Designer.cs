namespace AssetManagementSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEmployee = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnVendor = new System.Windows.Forms.Button();
            this.BtnAssets = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetsUserControl1 = new AssetManagementSystem.MainUserControls.AssetsUserControl();
            this.employeeUserControl1 = new AssetManagementSystem.MainUserControls.EmployeeUserControl();
            this.reportUserControl1 = new AssetManagementSystem.MainUserControls.ReportUserControl();
            this.vendorUserControl1 = new AssetManagementSystem.MainUserControls.VendorUserControl();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.BtnEmployee);
            this.panel1.Controls.Add(this.BtnReport);
            this.panel1.Controls.Add(this.BtnVendor);
            this.panel1.Controls.Add(this.BtnAssets);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 3;
            // 
            // BtnEmployee
            // 
            this.BtnEmployee.FlatAppearance.BorderSize = 0;
            this.BtnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmployee.Image")));
            this.BtnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmployee.Location = new System.Drawing.Point(96, 3);
            this.BtnEmployee.Name = "BtnEmployee";
            this.BtnEmployee.Size = new System.Drawing.Size(90, 35);
            this.BtnEmployee.TabIndex = 2;
            this.BtnEmployee.Text = "Employee";
            this.BtnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEmployee.UseVisualStyleBackColor = true;
            this.BtnEmployee.Click += new System.EventHandler(this.BtnEmployee_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.Image = ((System.Drawing.Image)(resources.GetObject("BtnReport.Image")));
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.Location = new System.Drawing.Point(288, 3);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(90, 35);
            this.BtnReport.TabIndex = 1;
            this.BtnReport.Text = "Report";
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnVendor
            // 
            this.BtnVendor.FlatAppearance.BorderSize = 0;
            this.BtnVendor.Image = ((System.Drawing.Image)(resources.GetObject("BtnVendor.Image")));
            this.BtnVendor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVendor.Location = new System.Drawing.Point(192, 3);
            this.BtnVendor.Name = "BtnVendor";
            this.BtnVendor.Size = new System.Drawing.Size(90, 35);
            this.BtnVendor.TabIndex = 1;
            this.BtnVendor.Text = "Vendor";
            this.BtnVendor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVendor.UseVisualStyleBackColor = true;
            this.BtnVendor.Click += new System.EventHandler(this.BtnVendor_Click);
            // 
            // BtnAssets
            // 
            this.BtnAssets.FlatAppearance.BorderSize = 0;
            this.BtnAssets.Image = ((System.Drawing.Image)(resources.GetObject("BtnAssets.Image")));
            this.BtnAssets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAssets.Location = new System.Drawing.Point(0, 3);
            this.BtnAssets.Name = "BtnAssets";
            this.BtnAssets.Size = new System.Drawing.Size(90, 35);
            this.BtnAssets.TabIndex = 0;
            this.BtnAssets.Text = "Assets";
            this.BtnAssets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAssets.UseVisualStyleBackColor = true;
            this.BtnAssets.Click += new System.EventHandler(this.BtnAsets_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewItemsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewItemsToolStripMenuItem
            // 
            this.addNewItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.assetToolStripMenuItem,
            this.vendorToolStripMenuItem});
            this.addNewItemsToolStripMenuItem.Name = "addNewItemsToolStripMenuItem";
            this.addNewItemsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addNewItemsToolStripMenuItem.Text = "Add New Items";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // assetToolStripMenuItem
            // 
            this.assetToolStripMenuItem.Name = "assetToolStripMenuItem";
            this.assetToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.assetToolStripMenuItem.Text = "Asset";
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.vendorToolStripMenuItem.Text = "Vendor";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.changeIconToolStripMenuItem});
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.hToolStripMenuItem.Text = "Edit";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.manageToolStripMenuItem.Text = "Manage Selection Fields";
            // 
            // changeIconToolStripMenuItem
            // 
            this.changeIconToolStripMenuItem.Name = "changeIconToolStripMenuItem";
            this.changeIconToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.changeIconToolStripMenuItem.Text = "Change Application Icon";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            this.contentToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.contentToolStripMenuItem.Text = "Content";
            // 
            // assetsUserControl1
            // 
            this.assetsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetsUserControl1.Location = new System.Drawing.Point(0, 77);
            this.assetsUserControl1.Name = "assetsUserControl1";
            this.assetsUserControl1.Size = new System.Drawing.Size(800, 373);
            this.assetsUserControl1.TabIndex = 6;
            // 
            // employeeUserControl1
            // 
            this.employeeUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeUserControl1.Location = new System.Drawing.Point(0, 77);
            this.employeeUserControl1.Name = "employeeUserControl1";
            this.employeeUserControl1.Size = new System.Drawing.Size(800, 373);
            this.employeeUserControl1.TabIndex = 5;
            // 
            // reportUserControl1
            // 
            this.reportUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportUserControl1.Location = new System.Drawing.Point(0, 77);
            this.reportUserControl1.Name = "reportUserControl1";
            this.reportUserControl1.Size = new System.Drawing.Size(800, 373);
            this.reportUserControl1.TabIndex = 4;
            // 
            // vendorUserControl1
            // 
            this.vendorUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorUserControl1.Location = new System.Drawing.Point(0, 77);
            this.vendorUserControl1.Name = "vendorUserControl1";
            this.vendorUserControl1.Size = new System.Drawing.Size(800, 373);
            this.vendorUserControl1.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vendorUserControl1);
            this.Controls.Add(this.assetsUserControl1);
            this.Controls.Add(this.employeeUserControl1);
            this.Controls.Add(this.reportUserControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Asset Management System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnEmployee;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnVendor;
        private System.Windows.Forms.Button BtnAssets;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentToolStripMenuItem;
        private MainUserControls.ReportUserControl reportUserControl1;
        private MainUserControls.EmployeeUserControl employeeUserControl1;
        private MainUserControls.AssetsUserControl assetsUserControl1;
        private MainUserControls.VendorUserControl vendorUserControl1;
    }
}

