namespace AssetManagementSystem.MainUserControls
{
    partial class CheckoutSearch
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
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDITIONALINFORMATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSETNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.AddtoCheckout = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(588, 35);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(167, 32);
            this.toolStripLabel1.Text = "Search Results";
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DESCRIPTION,
            this.ADDITIONALINFORMATION,
            this.ASSETNO});
            this.dgvSearch.Location = new System.Drawing.Point(0, 76);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(572, 210);
            this.dgvSearch.TabIndex = 9;
            this.dgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentClick_1);
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.DataPropertyName = "DESCRIPTION";
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.Width = 305;
            // 
            // ADDITIONALINFORMATION
            // 
            this.ADDITIONALINFORMATION.DataPropertyName = "ADDITIONALINFORMATION";
            this.ADDITIONALINFORMATION.HeaderText = "ADDITIONALINFORMATION";
            this.ADDITIONALINFORMATION.Name = "ADDITIONALINFORMATION";
            this.ADDITIONALINFORMATION.Width = 250;
            // 
            // ASSETNO
            // 
            this.ASSETNO.DataPropertyName = "ASSETNO";
            this.ASSETNO.HeaderText = "ASSETNO";
            this.ASSETNO.Name = "ASSETNO";
            this.ASSETNO.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // AddtoCheckout
            // 
            this.AddtoCheckout.Enabled = false;
            this.AddtoCheckout.Location = new System.Drawing.Point(270, 311);
            this.AddtoCheckout.Name = "AddtoCheckout";
            this.AddtoCheckout.Size = new System.Drawing.Size(148, 23);
            this.AddtoCheckout.TabIndex = 8;
            this.AddtoCheckout.Text = "Add To Checkout";
            this.AddtoCheckout.UseVisualStyleBackColor = true;
            this.AddtoCheckout.Click += new System.EventHandler(this.AddtoCheckout_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 339);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(588, 69);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // CheckoutSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 408);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddtoCheckout);
            this.Controls.Add(this.splitter1);
            this.Name = "CheckoutSearch";
            this.Text = "CheckoutSearch";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddtoCheckout;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDITIONALINFORMATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSETNO;
    }
}