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
    public partial class CheckoutSearch : Form
    {
        Checkout _checkoutWindow;
        public CheckoutSearch()
        {
            InitializeComponent();
            LoadGridView();
        }

        public CheckoutSearch(Checkout checkout)
        {
            if (checkout == null)
                //throw new ArgumentNullException("CheckoutWindow");

                _checkoutWindow = checkout;
        }

        string assNo = " ";
        List<string> choosenAssetNo = new List<string>();
        private void LoadGridView()
        {
            dgvSearch.DataSource = null;
            using (AccetManagementEntities db = new AccetManagementEntities())
            {

                dgvSearch.AutoGenerateColumns = false;
                dgvSearch.DataSource = db.VIEWCHECKOUTsearches.ToList<VIEWCHECKOUTsearch>(); //db.VIEWCHECKOUTsearches.ToList<VIEWCHECKOUTsearches>();



            }
        }


        private void DgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var results = this.dgvSearch.CurrentRow.Cells[1].Value.ToString();

            assNo = this.dgvSearch.CurrentRow.Cells[2].Value.ToString();
            if (results.Contains("Available for Checkout"))
            {
                AddtoCheckout.Enabled = true;

                choosenAssetNo.Add(assNo);
            }
            else
            {
                AddtoCheckout.Enabled = false;
            }
            CommonData.choosenAssetNum = choosenAssetNo;
        }

        private void AddtoCheckout_Click(object sender, EventArgs e)
        {
            //call the checkout form and populate the dgvItemsCheckedOut gridview

            Checkout chqOut = new Checkout();
            chqOut.LoadDatagridView(CommonData.choosenAssetNum);
            this.Close();
            chqOut.ShowDialog();



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSearch_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var results = this.dgvSearch.CurrentRow.Cells[1].Value.ToString();

            assNo = this.dgvSearch.CurrentRow.Cells[2].Value.ToString();
            if (results.Contains("Available for Checkout"))
            {
                AddtoCheckout.Enabled = true;

                choosenAssetNo.Add(assNo);
            }
            else
            {
                AddtoCheckout.Enabled = false;
            }
            CommonData.choosenAssetNum = choosenAssetNo;
        }
    }
}
