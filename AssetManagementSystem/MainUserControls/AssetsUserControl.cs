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
using AssetManagementSystem.MainUserControls.SharedClasses;

namespace AssetManagementSystem.MainUserControls
{
    public partial class AssetsUserControl : UserControl
    {
        public AssetsUserControl()
        {
            InitializeComponent();
            LoadGrid();
        }
        ASSET iEWALLASSET = new ASSET();
        public void LoadGrid()
        {
            dgvAllAssets.DataSource = null;
            this.dgvAllAssets.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllAssets.MultiSelect = false;
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
               

                dgvAllAssets.AutoGenerateColumns = false;
                dgvAllAssets.DataSource = db.VIEWALLASSETS.ToList<VIEWALLASSET>();

            }
        }

        private void DgvAllAssets_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            var assno = this.dgvAllAssets.CurrentRow.Cells[0].Value.ToString();
            CommonData.AssetNo = assno;
            // Get the genaral user control called usercontrol1. 
            UserControl1 userControl1 = new UserControl1();
            userControl1.PopulateControl(assno);
            //populate the new asset form with daa
            NewAsset asset = new NewAsset();

            var r = asset.Controls[3].Controls.Find("txtserial", true).ToList();
            asset.PopulateControls(assno);
            //asset.AddOwnedForm(userControl11);

            asset.ShowDialog();







        }

        private void ToolStripNewAsset_Click(object sender, EventArgs e)
        {
            OpenAssetPage();
            //TO DO:
            //allasset.loadGrid();
            LoadAllAssets();
        }

        private void LoadAllAssets()
        {
            //TO DO:
           //assetsUserControl1.Show();
           // assetsUserControl1.BringToFront();


        }
        private void OpenAssetPage()
        {

            NewAsset asset = new NewAsset();
            asset.ShowDialog();
        }
       

        private void DgvAllAssets_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var assno = this.dgvAllAssets.CurrentRow.Cells[0].Value.ToString();
            // Get the genaral user control called usercontrol1. 
            CommonData.AssetNo = assno;
            UserControl1 userControl1 = new UserControl1();
            userControl1.PopulateControl(assno);
            //populate the new asset form with daa
            NewAsset asset = new NewAsset();

            //var r = asset.Controls[3].Controls.Find("txtserial", true).ToList();
            asset.PopulateControls(assno);
            //asset.AddOwnedForm(userControl11);
            
            asset.ShowDialog();

        }

        private void ToolStripBtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "DELETE ASSET?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var assno = Convert.ToString(this.dgvAllAssets.CurrentRow.Cells["ASSETNO"].Value);
                //delete image if any.

                DeleteImage(assno);

                //delete finance attatched to the asset

                DeleteAssetFinance(assno);
                
                using (AccetManagementEntities db = new AccetManagementEntities())
                {
                    

                    var empname = db.VIEWALLASSETS.Where(x => x.ASSETNO == assno).Select(x => x.EMPNAME).FirstOrDefault();
                    if (empname == "" || empname == null)
                    {
                       
                        int rows = dgvAllAssets.RowCount;
                        for (int i = rows - 1; i >= 0; i--)
                        {
                            if (dgvAllAssets.Rows[i].Selected)
                            {
                                iEWALLASSET.ASSETNO = assno;
                                iEWALLASSET = db.ASSETs.Where(x => x.ASSETNO == iEWALLASSET.ASSETNO).FirstOrDefault();

                                var entry = db.Entry(iEWALLASSET);

                                if (entry.State == EntityState.Unchanged)
                                {
                                    db.ASSETs.Attach(iEWALLASSET);
                                    db.ASSETs.Remove(iEWALLASSET);
                                    db.SaveChanges();
                                    LoadGrid();

                                    if (dgvAllAssets.CurrentRow == null)
                                    {
                                        MessageBox.Show("All Items deleted successfully");
                                    }
                                    else
                                    {
                                        dgvAllAssets.Rows[0].Selected = false;
                                    }


                                }

                                //db.VIEWALLASSETS.Remove(dgvAllAssets.Rows[i].DataBoundItem as VIEWALLASSET);
                                //vIEWALLASSETBindingSource.RemoveAt(dgvAllAssets.Rows[i].Index);
                            }
                        }
                    }
                    else
                    {

                        MessageBox.Show("This particular Item cannot be deleted because it's been assigned to an Employee  " + empname 
                            + "  CheckIn the Item first for it to be deleted");

                    }
                    
                   
                }
            }
        }

        private void DeleteAssetFinance(string assno)
        {
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                FINANCE aFinance = new FINANCE();
                //var assFinance = db.FINANCEs.SingleOrDefault(x => x.ASSETNO == assno);
                aFinance = db.FINANCEs.SingleOrDefault(x => x.ASSETNO == assno);
                //db.ASSETIMAGEs.Where(x => x.ASSETID == assno).FirstOrDefault();

                if (aFinance != null)
                {
                    var entry = db.Entry(aFinance);

                    if (entry.State == EntityState.Unchanged)
                    {
                        db.FINANCEs.Attach(aFinance);
                        db.FINANCEs.Remove(aFinance);
                        db.SaveChanges();

                    }
                }


            }
        }

        private void DeleteImage(string assno)
        {
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                ASSETIMAGE aSSETIMAGE = new ASSETIMAGE();
                var assImage = db.ASSETIMAGEs.SingleOrDefault(x => x.ASSETID == assno);
                aSSETIMAGE = db.ASSETIMAGEs.Where(x => x.ASSETID == assno).FirstOrDefault();

                if (aSSETIMAGE != null )
                {
                    var entry = db.Entry(aSSETIMAGE);

                    if (entry.State == EntityState.Unchanged)
                    {
                        db.ASSETIMAGEs.Attach(aSSETIMAGE);
                        db.ASSETIMAGEs.Remove(aSSETIMAGE);
                        db.SaveChanges();

                    }
                }
                

            }
        }

        private void ClearSelectionAndResetSuppression()
        {
            
        }

        private void DgvAllAssets_DoubleClick(object sender, EventArgs e)
        {
            //Ensure that the gridview column is not a header 
            if (dgvAllAssets.CurrentRow.Index != -1)
            {
                var assno = this.dgvAllAssets.CurrentRow.Cells[0].Value.ToString();
                CommonData.AssetNo = assno;
                // Get the genaral user control called usercontrol1. 

                UserControl1 userControl1 = new UserControl1();
                userControl1.PopulateControl(assno);
                //populate the new asset form with daa
                NewAsset asset = new NewAsset();

                //var r = asset.Controls[3].Controls.Find("txtserial", true).ToList();
                asset.PopulateControls(assno);
                //asset.AddOwnedForm(userControl11);

                asset.ShowDialog();
            }
           
        }

        private void ToolStripEdit_Click(object sender, EventArgs e)
        {

            var assno = this.dgvAllAssets.CurrentRow.Cells["ASSETNO"].Value.ToString();
            // Get the genaral user control called usercontrol1. 
            UserControl1 userControl1 = new UserControl1();
            userControl1.PopulateControl(assno);
            //populate the new asset form with daa
            NewAsset asset = new NewAsset();

            //var r = asset.Controls[3].Controls.Find("txtserial", true).ToList();
            asset.PopulateControls(assno);
            //asset.AddOwnedForm(userControl11);
            

            asset.ShowDialog();
        }

        private void ToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripAllAssets_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
