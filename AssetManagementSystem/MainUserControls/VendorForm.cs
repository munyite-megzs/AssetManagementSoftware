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
    public partial class VendorForm : Form
    {
        public VendorForm()
        {
            InitializeComponent();
        }

        private void ToolStripButtonsave_Click(object sender, EventArgs e)
        {
            using (AccetManagementEntities db = new AccetManagementEntities())
            {

                VENDOR vENDOR = new VENDOR
                {
                    CONTACTNAME = txtContactName.Text,
                    COUNTRY = txtCountry.Text,
                    EMAIL = txtEmail.Text,
                    PHONENO = txtphoneNumber.Text,
                    POSTALADDRESS = txtAdress.Text,
                    TOWN = txtTown.Text,
                    VENDORNAME = txtVendorName.Text,
                    VENDORNO = txtVendorNumber.Text,
                    WEBSITE = txtWebsite.Text
                };

                db.VENDORs.Add(vENDOR);

                db.SaveChanges();
                this.Close();
                MessageBox.Show("Saved Successfully to Database.");

                Application.Restart(); ;



            }
        } 




        internal void PopulateControls(string vendno)
        {
            using (AccetManagementEntities db = new AccetManagementEntities())
            {

                var vendorDetails = db.VENDORs.Where(c => c.VENDORNO == vendno).ToList();
                


                txtContactName.Text = vendorDetails[0].CONTACTNAME;
                txtCountry.Text = vendorDetails[0].COUNTRY;
                txtEmail.Text = vendorDetails[0].EMAIL;
                txtphoneNumber.Text = vendorDetails[0].PHONENO;
                txtAdress.Text = vendorDetails[0].POSTALADDRESS;
                txtTown.Text = vendorDetails[0].TOWN;
                txtVendorName.Text = vendorDetails[0].VENDORNAME;
                txtVendorNumber.Text = vendorDetails[0].VENDORNO;
                txtWebsite.Text = vendorDetails[0].VENDORNO;

                this.Text = "Edit Vendor  " + vendorDetails[0].VENDORNO;



                //this.userControl11.Show();

                //userControl11.BringToFront();



            }
        }

    }
}
