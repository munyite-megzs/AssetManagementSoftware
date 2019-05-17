using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace AssetManagementSystem.MainUserControls
{
    public partial class EmployeeUserControl : UserControl
    {
        AddEmployee addEmloyee = new AddEmployee();
        public EmployeeUserControl()
        {
            InitializeComponent();
            LoadGrid();
        }

        public void LoadGrid()
        {
            dgvEmployee.DataSource = null;
            using (AccetManagementEntities db = new AccetManagementEntities())
            {

                dgvEmployee.AutoGenerateColumns = false;
                dgvEmployee.DataSource = db.VIEWALLEMPs.ToList<VIEWALLEMP>();
                //this.dgvEmployee.SelectionMode =
                //DataGridViewSelectionMode.FullRowSelect;
                //this.dgvEmployee.MultiSelect = false;

            }
        }
        private void DgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddEmployee empl = new AddEmployee();

            var empno = this.dgvEmployee.CurrentRow.Cells["EMPNUMBER"].Value.ToString();
            empl.PopulateControls(empno);


            empl.ShowDialog();
        }

        private void ToolStripButtonnewEmp_Click(object sender, EventArgs e)
        {
            addEmloyee.ShowDialog();
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            ShowEditEmployeePage();
        } 

        void ShowEditEmployeePage()
        {
            AddEmployee empl = new AddEmployee();

            var empno = this.dgvEmployee.CurrentRow.Cells["EMPNUMBER"].Value.ToString();
            empl.PopulateControls(empno);


            empl.ShowDialog();
        }

        private void DgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            ShowEditEmployeePage();
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "DELETE EMPLOYEE?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (AccetManagementEntities db = new AccetManagementEntities())
                {
                    EMPLOYEETABLE eMPLOYEETABLE = new EMPLOYEETABLE
                    {
                        EMPID = Convert.ToString(this.dgvEmployee.CurrentRow.Cells["EMPNUMBER"].Value)
                    };
                    var empname = db.ASSETs.Where(x => x.EMPID == eMPLOYEETABLE.EMPID).Select(x => x.EMPNAME).FirstOrDefault();

                    if (empname == "" || empname == null)
                    {
                        int rows = dgvEmployee.RowCount;
                        for (int i = rows - 1; i >= 0; i--)
                        {
                            if (dgvEmployee.Rows[i].Selected)
                            {

                                eMPLOYEETABLE = db.EMPLOYEETABLEs.Where(x => x.EMPID == eMPLOYEETABLE.EMPID).FirstOrDefault();

                                var entry = db.Entry(eMPLOYEETABLE);

                                if (entry.State == EntityState.Unchanged)
                                {
                                    db.EMPLOYEETABLEs.Attach(eMPLOYEETABLE);
                                    db.EMPLOYEETABLEs.Remove(eMPLOYEETABLE);
                                    db.SaveChanges();
                                    LoadGrid();
                                    if (dgvEmployee.CurrentRow == null)
                                    {
                                        MessageBox.Show("All Items deleted successfully");
                                    }
                                    else
                                    {
                                        dgvEmployee.Rows[0].Selected = false;
                                    }


                                }

                                //db.VIEWALLASSETS.Remove(dgvAllAssets.Rows[i].DataBoundItem as VIEWALLASSET);
                                //vIEWALLASSETBindingSource.RemoveAt(dgvAllAssets.Rows[i].Index);
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Employee Cannot be deleted because there is an asset attatched to  " + empname);
                    }

                   

                }
            }
        }
    }
}
