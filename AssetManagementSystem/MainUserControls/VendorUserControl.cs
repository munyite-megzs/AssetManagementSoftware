using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace AssetManagementSystem.MainUserControls
{
    public partial class VendorUserControl : UserControl
    {
        public VendorUserControl()
        {
            InitializeComponent();
        }
        VendorForm vendor = new VendorForm();

        public void LoadGrid()
        {
            dgvVendor.DataSource = null;
            this.dgvVendor.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendor.MultiSelect = false;
            using (AccetManagementEntities db = new AccetManagementEntities())
            {

                dgvVendor.AutoGenerateColumns = false;
                dgvVendor.DataSource = db.VENDORs.ToList<VENDOR>();

            }
        }
        private void DgvVendor_DoubleClick(object sender, EventArgs e)
        {

            //Ensure that the gridview column is not a header 
            if (dgvVendor.CurrentRow.Index != -1)
            {
                var vendornumber = this.dgvVendor.CurrentRow.Cells[1].Value.ToString();
                
                vendor.PopulateControls(vendornumber);
                vendor.ShowDialog();
            }

        }

        private void VendorUserControl_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void ToolStripButtonNewVendor_Click(object sender, EventArgs e)
        {
            OpenVendorPage();
        }

        private void OpenVendorPage()
        {
           
            vendor.ShowDialog();
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            
            // Get the genaral user control called usercontrol1. 

            if (dgvVendor.CurrentRow.Index != -1)
            {
                var vendorNo = this.dgvVendor.CurrentRow.Cells[1].Value.ToString();

                //NewAsset asset = new NewAsset();
                vendor.PopulateControls(vendorNo);
                vendor.ShowDialog();
            }

          
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "DELETE VENDOR?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var vendNo = Convert.ToString(this.dgvVendor.CurrentRow.Cells[1].Value);
                
                using (AccetManagementEntities db = new AccetManagementEntities())
                {
                    var getvendorFromDb = db.FINANCEs.Where(x => x.VENDORNO == vendNo).Select(x=> x.VENDORNO).FirstOrDefault();

                    if (getvendorFromDb == null)
                    {
                        int rows = dgvVendor.RowCount;
                        for (int i = rows - 1; i >= 0; i--)
                        {
                            if (dgvVendor.Rows[i].Selected)
                            {
                                VENDOR iVendor = new VENDOR
                                {
                                    VENDORNO = vendNo
                                };
                                iVendor = db.VENDORs.Where(x => x.VENDORNO == iVendor.VENDORNO).FirstOrDefault();

                                var entry = db.Entry(iVendor);

                                if (entry.State == EntityState.Unchanged)
                                {
                                    db.VENDORs.Attach(iVendor);
                                    db.VENDORs.Remove(iVendor);
                                    db.SaveChanges();
                                    LoadGrid();

                                    if (dgvVendor.CurrentRow == null)
                                    {
                                        MessageBox.Show("All Items deleted successfully");
                                    }
                                    else
                                    {
                                        dgvVendor.Rows[0].Selected = false;
                                    }


                                }

                                //db.VIEWALLASSETS.Remove(dgvAllAssets.Rows[i].DataBoundItem as VIEWALLASSET);
                                //vIEWALLASSETBindingSource.RemoveAt(dgvAllAssets.Rows[i].Index);
                            }
                            
                        } 
                    }
                    else
                    {
                        MessageBox.Show("Vendor is currently attached to an Asset");
                    }


                }
            }
        }
    }
}
