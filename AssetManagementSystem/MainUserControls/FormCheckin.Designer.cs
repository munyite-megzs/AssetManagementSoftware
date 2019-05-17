namespace AssetManagementSystem.MainUserControls
{
    partial class FormCheckin
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxComent = new System.Windows.Forms.RichTextBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCheckin = new System.Windows.Forms.DataGridView();
            this.ASSETNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHECKEDOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTODIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckin)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(606, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Complete Check In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnCompleteCheckin_Click);
            // 
            // richTextBoxComent
            // 
            this.richTextBoxComent.Location = new System.Drawing.Point(135, 386);
            this.richTextBoxComent.Name = "richTextBoxComent";
            this.richTextBoxComent.Size = new System.Drawing.Size(201, 58);
            this.richTextBoxComent.TabIndex = 15;
            this.richTextBoxComent.Text = "";
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(135, 345);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(201, 21);
            this.cmbLocation.TabIndex = 13;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(135, 317);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(201, 21);
            this.cmbStatus.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Comments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Set Location to ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Set status to ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Items To Check In";
            // 
            // dgvCheckin
            // 
            this.dgvCheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ASSETNO,
            this.DESCRIPTION,
            this.CHECKEDOUT,
            this.DUE,
            this.CUSTODIAN});
            this.dgvCheckin.Location = new System.Drawing.Point(26, 66);
            this.dgvCheckin.Name = "dgvCheckin";
            this.dgvCheckin.Size = new System.Drawing.Size(685, 203);
            this.dgvCheckin.TabIndex = 8;
            this.dgvCheckin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCheckin_CellContentClick);
            // 
            // ASSETNO
            // 
            this.ASSETNO.DataPropertyName = "ASSETNO";
            this.ASSETNO.HeaderText = "ASSETNO";
            this.ASSETNO.Name = "ASSETNO";
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.DataPropertyName = "DESCRIPTION";
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            // 
            // CHECKEDOUT
            // 
            this.CHECKEDOUT.DataPropertyName = "CHECKOUTDATE";
            this.CHECKEDOUT.HeaderText = "CHECKED OUT";
            this.CHECKEDOUT.Name = "CHECKEDOUT";
            // 
            // DUE
            // 
            this.DUE.DataPropertyName = "DUEDATE";
            this.DUE.HeaderText = "DUE";
            this.DUE.Name = "DUE";
            // 
            // CUSTODIAN
            // 
            this.CUSTODIAN.DataPropertyName = "CUSTODIAN";
            this.CUSTODIAN.HeaderText = "CUSTODIAN";
            this.CUSTODIAN.Name = "CUSTODIAN";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "Check In";
            // 
            // FormCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxComent);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCheckin);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormCheckin";
            this.Text = "FormCheckin";
            this.Load += new System.EventHandler(this.FormCheckin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckin)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxComent;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCheckin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSETNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHECKEDOUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTODIAN;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}