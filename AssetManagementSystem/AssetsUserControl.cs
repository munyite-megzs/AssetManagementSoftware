using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagementSystem.MainUserControls
{
    public partial class AssetsUserControl : UserControl
    {
        public AssetsUserControl()
        {
            InitializeComponent();
            LoadGrid();
        }

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
            // Get the genaral user control called usercontrol1. 
            UserControl1 userControl1 = new UserControl1();
            userControl1.populateControl(assno);
            //populate the new asset form with daa
            NewAsset asset = new NewAsset();

            var r = asset.Controls[3].Controls.Find("txtserial", true).ToList();
            asset.PopulateControls(assno);
            //asset.AddOwnedForm(userControl11);

            asset.ShowDialog();







        }
    }
}
