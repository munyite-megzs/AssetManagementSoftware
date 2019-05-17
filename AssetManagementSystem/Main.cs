using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using AssetManagementSystem.MainUserControls;

namespace AssetManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            assetsUserControl1.Show();
            assetsUserControl1.BringToFront();
        }

        private void BtnAsets_Click(object sender, EventArgs e)
        {
            employeeUserControl1.Hide();
            reportUserControl1.Hide();
            vendorUserControl1.Hide();
            assetsUserControl1.Show();
            assetsUserControl1.BringToFront();

        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            assetsUserControl1.Hide();
            reportUserControl1.Hide();
            vendorUserControl1.Hide();
            employeeUserControl1.Show();
            employeeUserControl1.BringToFront();

        }

        private void BtnVendor_Click(object sender, EventArgs e)
        {
            employeeUserControl1.Hide();
            reportUserControl1.Hide();
            assetsUserControl1.Hide();
            vendorUserControl1.Show();
            vendorUserControl1.BringToFront();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            employeeUserControl1.Hide();
            assetsUserControl1.Hide();
            vendorUserControl1.Hide();
            reportUserControl1.Show();
            reportUserControl1.BringToFront();
        }
        

        
    }
}
