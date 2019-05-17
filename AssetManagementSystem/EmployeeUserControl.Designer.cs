namespace AssetManagementSystem.MainUserControls
{
    partial class EmployeeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeUserControl));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonnewEmp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonInactive = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonActive = new System.Windows.Forms.ToolStripButton();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.EMPNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPNUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonnewEmp,
            this.toolStripSeparator1,
            this.toolStripButtonEdit,
            this.toolStripSeparator2,
            this.toolStripButtonDelete});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(856, 25);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonnewEmp
            // 
            this.toolStripButtonnewEmp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonnewEmp.Image")));
            this.toolStripButtonnewEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonnewEmp.Name = "toolStripButtonnewEmp";
            this.toolStripButtonnewEmp.Size = new System.Drawing.Size(106, 22);
            this.toolStripButtonnewEmp.Text = "New Personnel";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(47, 22);
            this.toolStripButtonEdit.Text = "Edit";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(60, 22);
            this.toolStripButtonDelete.Text = "Delete";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButtonInactive,
            this.toolStripButtonActive});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(856, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "Personnel";
            // 
            // toolStripButtonInactive
            // 
            this.toolStripButtonInactive.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonInactive.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInactive.Image")));
            this.toolStripButtonInactive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInactive.Name = "toolStripButtonInactive";
            this.toolStripButtonInactive.Size = new System.Drawing.Size(72, 22);
            this.toolStripButtonInactive.Text = "Inactive";
            // 
            // toolStripButtonActive
            // 
            this.toolStripButtonActive.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonActive.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonActive.Image")));
            this.toolStripButtonActive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonActive.Name = "toolStripButtonActive";
            this.toolStripButtonActive.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonActive.Text = "Active";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EMPNAME,
            this.EMPNUMBER,
            this.PHONE,
            this.EMAIL,
            this.TITLE});
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 50);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(856, 249);
            this.dgvEmployee.TabIndex = 8;
            // 
            // EMPNAME
            // 
            this.EMPNAME.DataPropertyName = "EMPNAME";
            this.EMPNAME.HeaderText = "EMPNAME";
            this.EMPNAME.Name = "EMPNAME";
            // 
            // EMPNUMBER
            // 
            this.EMPNUMBER.DataPropertyName = "EMPID";
            this.EMPNUMBER.HeaderText = "EMPNUMBER";
            this.EMPNUMBER.Name = "EMPNUMBER";
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "MOBILEPHONE";
            this.PHONE.HeaderText = "PHONE";
            this.PHONE.Name = "PHONE";
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            // 
            // TITLE
            // 
            this.TITLE.DataPropertyName = "TITLE";
            this.TITLE.HeaderText = "TITLE";
            this.TITLE.Name = "TITLE";
            // 
            // EmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EmployeeUserControl";
            this.Size = new System.Drawing.Size(856, 299);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonnewEmp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInactive;
        private System.Windows.Forms.ToolStripButton toolStripButtonActive;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPNUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITLE;
    }
}
