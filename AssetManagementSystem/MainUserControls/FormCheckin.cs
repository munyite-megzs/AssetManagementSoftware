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
    public partial class FormCheckin : Form
    {
        public FormCheckin()
        {
            InitializeComponent();
            LoadComboboxItems();
        }


        private void LoadComboboxItems()
        {
            //Clear combobox items first

            cmbStatus.Items.Clear();
            cmbLocation.Items.Clear();
            //get the items from db
            using (AccetManagementEntities db = new AccetManagementEntities())
            {


                var statusquery = db.STATUS
                                      .Select(a => a.STATUSNAME).ToList();
                cmbStatus.DataSource = statusquery;

                var locationquery = db.LOCATIONs
                                      .Select(a => a.LOCATIONNAME).ToList();
                cmbLocation.DataSource = locationquery;



            }
        }

        private void FormCheckin_Load(object sender, EventArgs e)
        {
            using (AccetManagementEntities db = new AccetManagementEntities())
            {

                dgvCheckin.AutoGenerateColumns = false;
                //dgvChqInOut.DataSource = db.VIEWCHECKOUTsearches.ToList<VIEWCHECKOUTsearch>(); 
                dgvCheckin.DataSource = db.VIEWEMPCHECKOUTLISTs.Where(a => a.EMPID == CommonData.PersonalNumber).ToList<VIEWEMPCHECKOUTLIST>();



            }
        }

        private void BtnCompleteCheckin_Click(object sender, EventArgs e)
        {
            //Update assets table set empid , empname to empty string
            UpdateAssetTable();

            //Insert to Checkin Table 

            InsetCheckinTable();
        }

        private void InsetCheckinTable()
        {


            CHECKOUTIN choi = new CHECKOUTIN();
            try
            {


                using (AccetManagementEntities db = new AccetManagementEntities())
                {
                    var statusId = db.STATUS.Where(c => c.STATUSNAME == cmbStatus.Text).OrderBy(c => c.STATUSNAME).Select(c => c.STATUSID).ToList();
                    var LocationId = db.LOCATIONs.Where(c => c.LOCATIONNAME == cmbLocation.Text).OrderBy(c => c.LOCATIONID).Select(c => c.LOCATIONID).ToList();

                    choi.EMPNAME = CommonData.Fname + " " + CommonData.Lname;
                    choi.ASSETNO = this.dgvCheckin.CurrentRow.Cells[0].Value.ToString();
                    choi.COMMENT = richTextBoxComent.Text.ToString();
                    choi.DUEDATE = Convert.ToDateTime(this.dgvCheckin.CurrentRow.Cells[3].Value.ToString());
                    choi.STATUSID = statusId[0];
                    choi.LOCATIONID = LocationId[0];
                    choi.DESCRIPTION = this.dgvCheckin.CurrentRow.Cells[1].Value.ToString();
                    choi.CHECKOUTDATE = Convert.ToDateTime(this.dgvCheckin.CurrentRow.Cells[2].Value.ToString());
                    choi.COMPNAME = Environment.MachineName;
                    choi.CHECKINDATE = DateTime.Now;
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

        private void UpdateAssetTable()
        {
            List<Asset> empAsset = new List<Asset>();
            Save_NewMembers saveEmp = new Save_NewMembers();
            int staId, locId;
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                var statusId = db.STATUS.Where(c => c.STATUSNAME == cmbStatus.Text).OrderBy(c => c.STATUSNAME).Select(c => c.STATUSID).ToList();
                var LocationId = db.LOCATIONs.Where(c => c.LOCATIONNAME == cmbLocation.Text).OrderBy(c => c.LOCATIONID).Select(c => c.LOCATIONID).ToList();


                // UPDATE ASSETS TABLE 
                staId = statusId[0];
                locId = LocationId[0];


                empAsset.Add(new Asset()
                {
                    AssetNo = this.dgvCheckin.CurrentRow.Cells[0].Value.ToString(),
                    Comment = richTextBoxComent.Text.ToString().Trim(),
                    EmpName = "",
                    CheckoinDate = DateTime.Now,
                    StatusId = statusId[0],
                    LocationId = LocationId[0],
                    EmpId = ""




                });



            }
            saveEmp.CheckinUpdate(empAsset);
        }

        private void DgvCheckin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
