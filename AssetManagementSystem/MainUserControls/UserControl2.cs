using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssetManagementSystem.MainUserControls.SharedClasses;

namespace AssetManagementSystem.MainUserControls
{
    public partial class UserControlFinance : UserControl
    {
        public UserControlFinance()
        {
            InitializeComponent();
           
        }

        void LoadCombobox()
        {
            //Clear combobox items first
           // cmdDepreciation.Items.Clear();
            cmdVendor.Items.Clear();
            //get the items from db
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                //var depquery = db.Depreciations
                //                       .Select(e => e.DepresiationName).ToList();
                //cmdDepreciation.DataSource = depquery;

                //TO DO: ONCE DONE WITH VENDOR PAGE, LOAD VENDORS HERE

                var vendorName = db.VENDORs
                                     .Select(a => a.VENDORNAME).ToList();
                cmdVendor.DataSource = vendorName;

            }

        }

            private void UserControlFinance_Load(object sender, EventArgs e)
             {

                    LoadCombobox(); 

            }

        internal void GetControls(string assno)
        {
            var idVendor = "";
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                //var currentConditionId = db.CONDITIONs.Where(c => c.CONDITIONNAME == r).OrderBy(c => c.CONDITIONID).Select(c => c.CONDITIONID).ToList();
                if (Finances.VendorName != null)
                {
                    var vendorId = db.VENDORs
                                        .Where(e => e.VENDORNAME == Finances.VendorName)
                                        .Select(e => e.VENDORNO).ToList();
                    idVendor = vendorId[0].ToString();

                }
                if (Finances.PurchasePrice == null)
                {
                    Finances.PurchasePrice = "0";
                }
                if (Finances.MarketVlaue ==null)
                {
                    Finances.MarketVlaue = "0";
                }

                if (Finances.ScrapValue == null)
                {
                    Finances.ScrapValue = "0"; 
                }
                if (Finances.TxtPoNumber == null)
                {
                    Finances.TxtPoNumber = "0";
                }

                if (Finances.DatePurchase == null || Finances.DatePurchase == "")
                {
                    Finances.DatePurchase =Convert.ToString( DateTime.Now);
                }
                if (Finances.Service == null || Finances.Service == "")
                {
                    Finances.Service = Convert.ToString(DateTime.Now);
                }
                if (Finances.DtpWarranty == null || Finances.DtpWarranty == "")
                {
                    Finances.DtpWarranty = Convert.ToString(DateTime.Now);
                }

                //var depreciationId = db.Depreciations.Where(d => d.DepresiationName == cmdDepreciation.Text).
                //                                        Select(d => d.ID).ToList();

                var financeTableData = db.FINANCEs.SingleOrDefault(c => c.ASSETNO == assno);

                if (financeTableData == null)
                {

                   
                    
                        FINANCE fINANCE = new FINANCE
                        {

                            ASSETNO = assno,
                            VENDORNO = idVendor,
                            PONO = Finances.TxtPoNumber,
                            PURCHASEPRICE = Convert.ToDecimal(Finances.PurchasePrice),
                            MARKETVALUE = Convert.ToDecimal(Finances.MarketVlaue),
                            SCRAPEVALUE = Convert.ToDecimal(Finances.ScrapValue),
                            DEPRECIATIONID = 1,
                            PURCHASEDATE = Convert.ToDateTime(Finances.DatePurchase),
                            INSERVICEDATE = Convert.ToDateTime(Finances.Service),
                            WARRANTYEND = Convert.ToDateTime(Finances.DtpWarranty)
                        };
                        db.FINANCEs.Add(fINANCE);
                    
                   

                }
                else
                {
                    financeTableData.ASSETNO = assno;
                    financeTableData.DEPRECIATIONID = 1;
                    financeTableData.INSERVICEDATE = Convert.ToDateTime(Finances.Service);
                    financeTableData.MARKETVALUE = Convert.ToDecimal(Finances.MarketVlaue);
                    financeTableData.PONO = Finances.TxtPoNumber;
                    financeTableData.PURCHASEDATE = Convert.ToDateTime(Finances.DatePurchase);
                    financeTableData.PURCHASEPRICE = Convert.ToDecimal(Finances.PurchasePrice);
                    financeTableData.RECOVERYPERIOD = Convert.ToInt32(Finances.RecPeriod);
                    financeTableData.SCRAPEVALUE = Convert.ToDecimal(Finances.ScrapValue);
                    financeTableData.VENDORNO = idVendor;
                    financeTableData.WARRANTYEND = Convert.ToDateTime(Finances.DtpWarranty);
                }

                db.SaveChanges();



            }
            

        }

        internal void PopulateControls(string assno)
        {
            using (AccetManagementEntities db = new AccetManagementEntities())
            {

               
                var financeTableData = db.FINANCEs.SingleOrDefault(c => c.ASSETNO == assno); 
                

                var vendorId = db.VENDORs.Where(e => e.VENDORNO == financeTableData.VENDORNO).ToList(); 
                Finances.VendorName = vendorId[0].VENDORNAME;
                Finances.TxtPoNumber = financeTableData.PONO;
                cmdVendor.Text = Finances.VendorName;
                txtPoNumber.Text = Finances.TxtPoNumber;
                recPeriod.Value = financeTableData.RECOVERYPERIOD;
                txtPurchasePrice.Text = financeTableData.PURCHASEPRICE.ToString();
                txtMarketVlaue.Text = financeTableData.MARKETVALUE.ToString();
                txtScrapValue.Text = financeTableData.SCRAPEVALUE.ToString();
                dtpPurchase.Value = financeTableData.PURCHASEDATE;
                dtpWarranty.Value = financeTableData.WARRANTYEND;
                dtpService.Value = financeTableData.INSERVICEDATE;

              



            }
        }

        private void CmdVendor_SelectedIndexChanged(object sender, EventArgs e)
        {

            Finances.VendorName = cmdVendor.Text;
            


        }

        private void TxtPoNumber_TextChanged(object sender, EventArgs e)
        {
            Finances.TxtPoNumber = txtPoNumber.Text.ToString().Trim();
        }

        private void RecPeriod_ValueChanged(object sender, EventArgs e)
        {
            Finances.RecPeriod = recPeriod.Value;
        }

        private void TxtPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            Finances.PurchasePrice = txtPurchasePrice.Text;
        }

        private void TxtMarketVlaue_TextChanged(object sender, EventArgs e)
        {
            Finances.MarketVlaue = txtMarketVlaue.Text;
        }

        private void TxtScrapValue_TextChanged(object sender, EventArgs e)
        {
            Finances.ScrapValue = txtScrapValue.Text;
        }

        private void DtpPurchase_ValueChanged(object sender, EventArgs e)
        {
            Finances.DatePurchase = dtpPurchase.Text;
        }

        private void DtpService_ValueChanged(object sender, EventArgs e)
        {
            Finances.Service = dtpService.Text;

        }

        private void DtpWarranty_ValueChanged(object sender, EventArgs e)
        {
            Finances.DtpWarranty = dtpWarranty.Text;
        }
    }
}
