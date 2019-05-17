using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using AssetManagementSystem.MainUserControls.SharedClasses;

namespace AssetManagementSystem.MainUserControls
{
    public partial class NewAsset : Form
    {

        ASSET myAsset = new ASSET();
        UserControl1 us = new UserControl1();
        public NewAsset()
        {
            InitializeComponent();
        }

        private void NewAsset_Load(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
            userControlFinance1.Hide();
            attachments1.Hide();
            historyControl1.Hide();
            //load Combibix items
            //TO DO
            LoadCombobox();
        }
        void LoadCombobox()
        {
            //Clear combobox items first
            cmBAssetType.Items.Clear();
            cmBLocation.Items.Clear();
            //get the items from db
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                var assettypequery = db.ASSETTYPEs
                                       .Select(e => e.ASSETTYPE1).ToList();
                cmBAssetType.DataSource = assettypequery;

                var locationquery = db.LOCATIONs
                                      .Select(a => a.LOCATIONNAME).ToList();
                cmBLocation.DataSource = locationquery;

            }

        }
        internal void PopulateControls(string assno)
        {
            using (AccetManagementEntities db = new AccetManagementEntities())
            {

                var assDetails = db.ASSETs.Where(c => c.ASSETNO == assno).ToList();

                var assetId = assDetails[0].ASSETTYPEID;
                var dd = db.ASSETTYPEs.Where(e => e.ASSETTYPEID == assetId).Select(e => e.ASSETTYPE1).ToList();

                var loc = assDetails[0].LOCATIONID;
                var ddLoc = db.LOCATIONs.Where(e => e.LOCATIONID == loc).Select(e => e.LOCATIONNAME).ToList();

                var statusId = assDetails[0].STATUSID;
                var ddsi = db.STATUS.Where(e => e.STATUSID == statusId).Select(e => e.STATUSNAME).ToList();

                var cond = assDetails[0].CONDITIONID;
                var ddCon = db.CONDITIONs.Where(e => e.CONDITIONID == cond).Select(e => e.CONDITIONNAME).ToList();

                txtDesription.Text = assDetails[0].DESCRIPTION;
                cmBAssetType.Text = dd[0].ToString();
                cmBLocation.Text = ddLoc[0].ToString();
                txtmanu.Text = assDetails[0].MANUFACTURER;
                txtBrand.Text = assDetails[0].BRAND;
                txtAssetNumber.Text = assDetails[0].ASSETNO;
                userControl11.txtserial.Text = assDetails[0].SERIALNUMBER;
                userControl11.cmBStatus.Text = ddsi[0].ToString();
                userControl11.cmBCondition.Text = ddCon[0].ToString();
                userControl11.txtcheckedOutto.Text = assDetails[0].EMPNAME.ToString();
                userControl11.dueDatepicker.Text = assDetails[0].DUEDATE.ToString();
                userControl11.txtNotes.Text = assDetails[0].NOTES;
                this.Text = "Edit Asset  " + assDetails[0].ASSETNO;
                var er = userControlFinance1.Controls.Find("txtPoNumber", true);
                var financeTableData = db.FINANCEs.SingleOrDefault(c => c.ASSETNO == assno);

                if (financeTableData !=null)
                {
                    if (financeTableData.VENDORNO != "")
                    {
                        var vendorId = db.VENDORs.Where(e => e.VENDORNO == financeTableData.VENDORNO).ToList();
                        userControlFinance1.txtPoNumber.Text = financeTableData.PONO;
                        userControlFinance1.cmdVendor.Text = vendorId[0].VENDORNAME;
                        userControlFinance1.recPeriod.Value = financeTableData.RECOVERYPERIOD;
                        userControlFinance1.txtPurchasePrice.Text = financeTableData.PURCHASEPRICE.ToString();
                        userControlFinance1.txtScrapValue.Text = financeTableData.SCRAPEVALUE.ToString();
                        userControlFinance1.txtMarketVlaue.Text = financeTableData.MARKETVALUE.ToString();
                        userControlFinance1.dtpPurchase.Value = financeTableData.PURCHASEDATE;
                        userControlFinance1.dtpWarranty.Value = financeTableData.WARRANTYEND;
                        userControlFinance1.dtpService.Value = financeTableData.INSERVICEDATE;
                    }
                }

                
              
                CommonData.SelectedEmpId = assDetails[0].EMPID;

                //picture 

                string fileName = db.ASSETIMAGEs.Where(f => f.ASSETID == assno).Select(f => f.Filepath).FirstOrDefault();

                if (fileName != null && fileName != "")
                {
                    userControl11.pictureBox1.Image = UserControl1.ResizeImage(Image.FromFile(fileName), this.Width, this.Height);
                }
                else
                {

                }
               







            }
        }


        private void General_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();

            userControlFinance1.Hide();
            attachments1.Hide();
            historyControl1.Hide();
            //service1.Hide();
        }
        void FinanceMenu()
        {

            userControl11.Hide();
            attachments1.Hide();
            historyControl1.Hide();
            userControlFinance1.Show();
            userControlFinance1.BringToFront();
            
            

        }
      

        private void HistoryMenuItem5_Click(object sender, EventArgs e)
        {
            historyControl1.Show();
            historyControl1.BringToFront();


            userControl11.Hide();
            attachments1.Hide();
            userControlFinance1.Hide();
        }

        private void FinanceMenuItem_Click(object sender, EventArgs e)
        {
            FinanceMenu();
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveCloseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

         
            UserControlFinance userControlFinance = new UserControlFinance();



            var serial = userControl11.Controls.Find("txtserial", true);
            var status = userControl11.Controls.Find("cmBStatus", true);
            var condition = userControl11.Controls.Find("cmBCondition", true);
            var checkedOutto = userControl11.Controls.Find("txtcheckedOutto", true);
            var datepicker = userControl11.Controls.Find("dueDatepicker", true);
            var txtNotes = userControl11.Controls.Find("txtNotes", true);
            var r = condition[0].Text;
            var currentStatus = status[0].Text;
            var assetImage = userControl11.pictureBox1;

            try
            {


                using (AccetManagementEntities db = new AccetManagementEntities())
                {
                  


                    var currentConditionId = db.CONDITIONs.Where(c => c.CONDITIONNAME == r).OrderBy(c => c.CONDITIONID).Select(c => c.CONDITIONID).ToList();
                    var assetId = db.ASSETTYPEs.Where(c => c.ASSETTYPE1 == cmBAssetType.Text).OrderBy(c => c.ASSETTYPEID).Select(c => c.ASSETTYPEID).ToList();
                    var LocationId = db.LOCATIONs.Where(c => c.LOCATIONNAME == cmBLocation.Text).OrderBy(c => c.LOCATIONID).Select(c => c.LOCATIONID).ToList();
                    var statusId = db.STATUS.Where(c => c.STATUSNAME == currentStatus).OrderBy(c => c.STATUSNAME).Select(c => c.STATUSID).ToList();
                    var aSSETs = txtAssetNumber.Text.Trim().ToString();
                    var assetTableData = db.ASSETs.SingleOrDefault(c => c.ASSETNO == aSSETs);

                    if (assetTableData == null)
                    { 

                       
                        userControlFinance.GetControls(txtAssetNumber.Text.Trim());

                        myAsset.ASSETNO = txtAssetNumber.Text.Trim();
                        myAsset.DESCRIPTION = txtDesription.Text.Trim();

                        myAsset.ASSETTYPEID = assetId[0];
                        myAsset.LOCATIONID = LocationId[0];
                        myAsset.MANUFACTURER = txtmanu.Text.Trim();
                        myAsset.BRAND = txtBrand.Text.Trim();
                        myAsset.MODEL = "NO MODEL YET";
                        myAsset.SERIALNUMBER = serial[0].Text;// data.serial;
                        myAsset.STATUSID = statusId[0]; //data.statusId;
                        myAsset.CONDITIONID = currentConditionId[0];//data.conditionId;
                        myAsset.EMPNAME = checkedOutto[0].Text.ToString().Trim();// data.Emp;
                        myAsset.DUEDATE = Convert.ToDateTime(datepicker[0].Text);
                        myAsset.NOTES = txtNotes[0].Text.ToString().Trim();
                        myAsset.ASSETIMAGEID = 1;
                        myAsset.CHECKOUTDATE = DateTime.Now;
                        myAsset.CHECKOUTCOMMENT = "";
                        myAsset.EMPID = "";
                        myAsset.RECEIVEDDATE = DateTime.Now;
                        db.ASSETs.Add(myAsset);


                        //save Picture 
                        if (pictureBox1.Image != null)
                        {
                            ASSETIMAGE aSSETIMAGE = new ASSETIMAGE
                            {
                                ASSETID = aSSETs,
                                ASSETIMAGEID = 1,
                                Filepath = CommonData.Filename ?? ""
                            };
                            db.ASSETIMAGEs.Add(aSSETIMAGE);
                        }






                    }
                    else
                    {
                        // check whether userImage is in the database 
                        var assImage = db.ASSETIMAGEs.SingleOrDefault(x => x.ASSETID == aSSETs);
                        string fileNamePth = CommonData.Filename ?? "";
                        if (assImage == null)
                        {
                            
                            if (pictureBox1.Image != null)
                            {
                                ASSETIMAGE aSSETIMAGE = new ASSETIMAGE
                                {
                                    ASSETID = aSSETs,
                                    ASSETIMAGEID = 1,
                                    Filepath = fileNamePth
                                };
                                db.ASSETIMAGEs.Add(aSSETIMAGE);
                            }
                        }
                        else
                        {
                            assImage.ASSETIMAGEID = 1;
                            assImage.ASSETID = aSSETs;
                            assImage.Filepath = fileNamePth;
                        }
                       


                        //save finances changes first
                         userControlFinance.GetControls(txtAssetNumber.Text.Trim());

                        assetTableData.ASSETNO = txtAssetNumber.Text.Trim();
                        assetTableData.DESCRIPTION = txtDesription.Text.Trim();

                        assetTableData.ASSETTYPEID = assetId[0];
                        assetTableData.LOCATIONID = LocationId[0];
                        assetTableData.MANUFACTURER = txtmanu.Text.Trim();
                        assetTableData.BRAND = txtBrand.Text.Trim();
                        assetTableData.MODEL = "NO MODEL YET";
                        assetTableData.SERIALNUMBER = serial[0].Text;// data.serial;
                        assetTableData.STATUSID = statusId[0]; //data.statusId;
                        assetTableData.CONDITIONID = currentConditionId[0];//data.conditionId;
                        assetTableData.EMPNAME = checkedOutto[0].Text.ToString().Trim();// data.Emp;
                        assetTableData.DUEDATE = Convert.ToDateTime(datepicker[0].Text);
                        assetTableData.NOTES = txtNotes[0].Text.ToString().Trim();
                        assetTableData.ASSETIMAGEID = 1;
                        assetTableData.CHECKOUTDATE = DateTime.Now;
                        assetTableData.CHECKOUTCOMMENT = "";
                        assetTableData.EMPID = "";
                        assetTableData.RECEIVEDDATE = DateTime.Now;

                    }



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

        //private void ServiceMenuItem3_Click_1(object sender, EventArgs e)
        //{
           
        //}

        //private void AttachmentMenuItem4_Click_1(object sender, EventArgs e)
        //{
        //    attachments1.Show();
        //    attachments1.BringToFront();

        //    userControl11.Hide();
        //    //service1.Hide();
        //    historyControl1.Hide();
        //    userControlFinance1.Hide();
            
        //}

        private void General_Click_1(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();

            userControlFinance1.Hide();
            attachments1.Hide();
            historyControl1.Hide();
        }
    }
}
