using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssetManagementSystem.MainUserControls.SharedClasses;

namespace AssetManagementSystem.MainUserControls
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
            LoadComboboxItems();
        }

        private void LoadComboboxItems()
        {
            //Clear combobox items first
            cmbCheckout.Items.Clear();
            cmbStatus.Items.Clear();
            cmbLocation.Items.Clear();
            //get the items from db
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                var checkoutquery = db.EMPLOYEETABLEs
                                       .Select(e => e.FNAME + " " + e.LNAME).ToList();
                cmbCheckout.DataSource = checkoutquery;

                var statusquery = db.STATUS
                                      .Select(a => a.STATUSNAME).ToList();
                cmbStatus.DataSource = statusquery;

                var locationquery = db.LOCATIONs
                                      .Select(a => a.LOCATIONNAME).ToList();
                cmbLocation.DataSource = locationquery;



            }
        }

        int staId, locId;
        public void FillControls()
        {
            var fullName = CommonData.Fname + " " + CommonData.Lname;
            cmbCheckout.SelectedItem = fullName;
            cmbStatus.SelectedItem = CommonData.Statusid;


        }

        public void LoadDatagridView(List<string> assNo)
        {
            dgvItemsCheckedOut.DataSource = null;


            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                //dgvItemsCheckedOut.DataSource = db.VIEWCHECKOUTsearches.Where(e => assNo.Contains(e.ASSETNO)).ToList<VIEWCHECKOUTsearches>();
                dgvItemsCheckedOut.DataSource = db.VIEWCHECKOUTsearches.Where(e => assNo.Contains(e.ASSETNO)).ToList<VIEWCHECKOUTsearch>();


            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.Close();
            CheckoutSearch asset = new CheckoutSearch();

            asset.ShowDialog();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateAssetTable()
        {
            List<Asset> empAsset = new List<Asset>();
            Save_NewMembers saveEmp = new Save_NewMembers();

            empAsset.Add(new Asset()
            {
                AssetNo = this.dgvItemsCheckedOut.CurrentRow.Cells[1].Value.ToString(),
                Comment = rctComment.Text.ToString().Trim(),
                EmpName = cmbCheckout.Text.ToString().Trim(),
                CheckoutDate = DateTime.Now,
                StatusId = staId,
                LocationId = locId,
                EmpId = CommonData.PersonalNumber




            });

            saveEmp.UpdateAssetTable(empAsset);
        }

        private void Checkout_Load(object sender, EventArgs e)
        {

        }

        private void BtnCompleteCheckout_Click(object sender, EventArgs e)
        {


            CHECKOUTIN choi = new CHECKOUTIN();
            try
            {


                using (AccetManagementEntities db = new AccetManagementEntities())
                {
                    var statusId = db.STATUS.Where(c => c.STATUSNAME == cmbStatus.Text).OrderBy(c => c.STATUSNAME).Select(c => c.STATUSID).ToList();
                    var LocationId = db.LOCATIONs.Where(c => c.LOCATIONNAME == cmbLocation.Text).OrderBy(c => c.LOCATIONID).Select(c => c.LOCATIONID).ToList();

                    // UPDATE ASSETS TABLE 
                    staId = statusId[0];
                    locId = LocationId[0];

                    UpdateAssetTable();
                    choi.EMPNAME = cmbCheckout.Text.ToString().Trim();// CommonData.Fname + " " + CommonData.Lname;
                    choi.ASSETNO = this.dgvItemsCheckedOut.CurrentRow.Cells[1].Value.ToString();
                    choi.COMMENT = rctComment.Text.ToString();
                    choi.DUEDATE = Convert.ToDateTime(dtpDate.Text.ToString());
                    choi.STATUSID = statusId[0];
                    choi.LOCATIONID = LocationId[0];
                    choi.DESCRIPTION = this.dgvItemsCheckedOut.CurrentRow.Cells[0].Value.ToString();
                    choi.CHECKOUTDATE = DateTime.Now;
                    choi.COMPNAME = Environment.MachineName;
                    //choi.EMPID = CommonData.PersonalNumber;



                    db.CHECKOUTINs.Add(choi);
                    db.SaveChanges();
                    this.Close();
                    MessageBox.Show("Saved Successfully to Database.");

                    Application.Restart();

                    //Main newMain = new Main();
                    //newMain.ShowDialog();


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Invalid entry. Ensure you do not repeat the same entry on AssetNo" + ex);
                //throw;
            }
        }

    }
}
