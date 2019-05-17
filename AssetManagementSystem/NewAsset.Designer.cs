namespace AssetManagementSystem.MainUserControls
{
    partial class NewAsset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAsset));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAssetNumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmanu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmBLocation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmBAssetType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.general = new System.Windows.Forms.ToolStripMenuItem();
            this.financeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.attachmentMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.historyMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.historyControl1 = new AssetManagementSystem.MainUserControls.HistoryControl();
            this.attachments1 = new AssetManagementSystem.MainUserControls.Attachments();
            this.userControlFinance1 = new AssetManagementSystem.MainUserControls.UserControlFinance();
            this.userControl11 = new AssetManagementSystem.MainUserControls.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txtBrand);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtmanu);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.cmBLocation);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cmBAssetType);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtDesription);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.userControl11);
            this.splitContainer1.Panel2.Controls.Add(this.userControlFinance1);
            this.splitContainer1.Panel2.Controls.Add(this.attachments1);
            this.splitContainer1.Panel2.Controls.Add(this.historyControl1);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCloseToolStripMenuItem,
            this.checkoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveCloseToolStripMenuItem
            // 
            this.saveCloseToolStripMenuItem.Name = "saveCloseToolStripMenuItem";
            this.saveCloseToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.saveCloseToolStripMenuItem.Text = "Save and Close";
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.checkoutToolStripMenuItem.Text = "Checkout";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAssetNumber);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(420, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 74);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asset Number";
            // 
            // txtAssetNumber
            // 
            this.txtAssetNumber.Location = new System.Drawing.Point(53, 27);
            this.txtAssetNumber.Name = "txtAssetNumber";
            this.txtAssetNumber.Size = new System.Drawing.Size(139, 20);
            this.txtAssetNumber.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 13);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(100, 140);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(197, 20);
            this.txtBrand.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Brand";
            // 
            // txtmanu
            // 
            this.txtmanu.Location = new System.Drawing.Point(100, 112);
            this.txtmanu.Name = "txtmanu";
            this.txtmanu.Size = new System.Drawing.Size(197, 20);
            this.txtmanu.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Manufacturer";
            // 
            // cmBLocation
            // 
            this.cmBLocation.FormattingEnabled = true;
            this.cmBLocation.Location = new System.Drawing.Point(100, 85);
            this.cmBLocation.Name = "cmBLocation";
            this.cmBLocation.Size = new System.Drawing.Size(121, 21);
            this.cmBLocation.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Location";
            // 
            // cmBAssetType
            // 
            this.cmBAssetType.FormattingEnabled = true;
            this.cmBAssetType.Location = new System.Drawing.Point(100, 58);
            this.cmBAssetType.Name = "cmBAssetType";
            this.cmBAssetType.Size = new System.Drawing.Size(121, 21);
            this.cmBAssetType.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Asset Type";
            // 
            // txtDesription
            // 
            this.txtDesription.Location = new System.Drawing.Point(100, 32);
            this.txtDesription.Name = "txtDesription";
            this.txtDesription.Size = new System.Drawing.Size(262, 20);
            this.txtDesription.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Description";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.general,
            this.financeMenuItem,
            this.serviceMenuItem3,
            this.attachmentMenuItem4,
            this.historyMenuItem5});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 15;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // general
            // 
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(59, 20);
            this.general.Text = "General";
            // 
            // financeMenuItem
            // 
            this.financeMenuItem.Name = "financeMenuItem";
            this.financeMenuItem.Size = new System.Drawing.Size(60, 20);
            this.financeMenuItem.Text = "Finance";
            this.financeMenuItem.Click += new System.EventHandler(this.financeMenuItem_Click);
            // 
            // serviceMenuItem3
            // 
            this.serviceMenuItem3.Name = "serviceMenuItem3";
            this.serviceMenuItem3.Size = new System.Drawing.Size(56, 20);
            this.serviceMenuItem3.Text = "Service";
            // 
            // attachmentMenuItem4
            // 
            this.attachmentMenuItem4.Name = "attachmentMenuItem4";
            this.attachmentMenuItem4.Size = new System.Drawing.Size(82, 20);
            this.attachmentMenuItem4.Text = "Attachment";
            // 
            // historyMenuItem5
            // 
            this.historyMenuItem5.Name = "historyMenuItem5";
            this.historyMenuItem5.Size = new System.Drawing.Size(57, 20);
            this.historyMenuItem5.Text = "History";
            this.historyMenuItem5.Click += new System.EventHandler(this.historyMenuItem5_Click);
            // 
            // historyControl1
            // 
            this.historyControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyControl1.Location = new System.Drawing.Point(0, 24);
            this.historyControl1.Name = "historyControl1";
            this.historyControl1.Size = new System.Drawing.Size(800, 256);
            this.historyControl1.TabIndex = 16;
            // 
            // attachments1
            // 
            this.attachments1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attachments1.Location = new System.Drawing.Point(0, 24);
            this.attachments1.Name = "attachments1";
            this.attachments1.Size = new System.Drawing.Size(800, 256);
            this.attachments1.TabIndex = 17;
            // 
            // userControlFinance1
            // 
            this.userControlFinance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFinance1.Location = new System.Drawing.Point(0, 24);
            this.userControlFinance1.Name = "userControlFinance1";
            this.userControlFinance1.Size = new System.Drawing.Size(800, 256);
            this.userControlFinance1.TabIndex = 18;
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(0, 24);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(800, 256);
            this.userControl11.TabIndex = 19;
            // 
            // NewAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "NewAsset";
            this.Text = "NewAsset";
            this.Load += new System.EventHandler(this.NewAsset_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAssetNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmanu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmBLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmBAssetType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem general;
        private System.Windows.Forms.ToolStripMenuItem financeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem attachmentMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItem5;
        private UserControl1 userControl11;
        private UserControlFinance userControlFinance1;
        private Attachments attachments1;
        private HistoryControl historyControl1;
    }
}