namespace AssetManagementSystem.MainUserControls
{
    partial class UserControlFinance
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
            this.txtScrapValue = new System.Windows.Forms.TextBox();
            this.txtMarketVlaue = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.dtpWarranty = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recPeriod = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPoNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdVendor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpService = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpPurchase = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.recPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScrapValue
            // 
            this.txtScrapValue.Location = new System.Drawing.Point(321, 76);
            this.txtScrapValue.Name = "txtScrapValue";
            this.txtScrapValue.Size = new System.Drawing.Size(121, 20);
            this.txtScrapValue.TabIndex = 52;
            this.txtScrapValue.TextChanged += new System.EventHandler(this.TxtScrapValue_TextChanged);
            // 
            // txtMarketVlaue
            // 
            this.txtMarketVlaue.Location = new System.Drawing.Point(321, 45);
            this.txtMarketVlaue.Name = "txtMarketVlaue";
            this.txtMarketVlaue.Size = new System.Drawing.Size(121, 20);
            this.txtMarketVlaue.TabIndex = 51;
            this.txtMarketVlaue.TextChanged += new System.EventHandler(this.TxtMarketVlaue_TextChanged);
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(322, 17);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(121, 20);
            this.txtPurchasePrice.TabIndex = 50;
            this.txtPurchasePrice.TextChanged += new System.EventHandler(this.TxtPurchasePrice_TextChanged);
            // 
            // dtpWarranty
            // 
            this.dtpWarranty.Location = new System.Drawing.Point(539, 89);
            this.dtpWarranty.Name = "dtpWarranty";
            this.dtpWarranty.Size = new System.Drawing.Size(176, 20);
            this.dtpWarranty.TabIndex = 43;
            this.dtpWarranty.ValueChanged += new System.EventHandler(this.DtpWarranty_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Warranty End";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "In Service";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Scrap Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Market Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Purchase  Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "(Yrs)";
            // 
            // recPeriod
            // 
            this.recPeriod.Location = new System.Drawing.Point(106, 86);
            this.recPeriod.Name = "recPeriod";
            this.recPeriod.Size = new System.Drawing.Size(59, 20);
            this.recPeriod.TabIndex = 35;
            this.recPeriod.ValueChanged += new System.EventHandler(this.RecPeriod_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Recovery Period";
            // 
            // txtPoNumber
            // 
            this.txtPoNumber.Location = new System.Drawing.Point(106, 45);
            this.txtPoNumber.Name = "txtPoNumber";
            this.txtPoNumber.Size = new System.Drawing.Size(121, 20);
            this.txtPoNumber.TabIndex = 33;
            this.txtPoNumber.TextChanged += new System.EventHandler(this.TxtPoNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "PO Number";
            // 
            // cmdVendor
            // 
            this.cmdVendor.FormattingEnabled = true;
            this.cmdVendor.Location = new System.Drawing.Point(106, 14);
            this.cmdVendor.Name = "cmdVendor";
            this.cmdVendor.Size = new System.Drawing.Size(121, 21);
            this.cmdVendor.TabIndex = 31;
            this.cmdVendor.SelectedIndexChanged += new System.EventHandler(this.CmdVendor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Vendor";
            // 
            // dtpService
            // 
            this.dtpService.Location = new System.Drawing.Point(539, 53);
            this.dtpService.Name = "dtpService";
            this.dtpService.Size = new System.Drawing.Size(176, 20);
            this.dtpService.TabIndex = 53;
            this.dtpService.ValueChanged += new System.EventHandler(this.DtpService_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(450, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Purchase Date";
            // 
            // dtpPurchase
            // 
            this.dtpPurchase.Location = new System.Drawing.Point(539, 22);
            this.dtpPurchase.Name = "dtpPurchase";
            this.dtpPurchase.Size = new System.Drawing.Size(176, 20);
            this.dtpPurchase.TabIndex = 55;
            this.dtpPurchase.ValueChanged += new System.EventHandler(this.DtpPurchase_ValueChanged);
            // 
            // UserControlFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpPurchase);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpService);
            this.Controls.Add(this.txtScrapValue);
            this.Controls.Add(this.txtMarketVlaue);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.dtpWarranty);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recPeriod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPoNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdVendor);
            this.Controls.Add(this.label1);
            this.Name = "UserControlFinance";
            this.Size = new System.Drawing.Size(784, 186);
            this.Load += new System.EventHandler(this.UserControlFinance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox cmdVendor;
        public System.Windows.Forms.TextBox txtPurchasePrice;
        public System.Windows.Forms.TextBox txtPoNumber;
        public System.Windows.Forms.TextBox txtScrapValue;
        public System.Windows.Forms.DateTimePicker dtpWarranty;
        public System.Windows.Forms.NumericUpDown recPeriod;
        public System.Windows.Forms.DateTimePicker dtpService;
        public System.Windows.Forms.DateTimePicker dtpPurchase;
        public System.Windows.Forms.TextBox txtMarketVlaue;
    }
}
