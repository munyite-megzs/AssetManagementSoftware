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
    public partial class ReportUserControl : UserControl
    {
        public ReportUserControl()
        {
            InitializeComponent();
        }

        private void ReportUserControl_Load(object sender, EventArgs e)
        {
            HideControls();
        }

        void HideControls()
        {
            rptAssignedUserControl1.Hide();
            rptAllAssetsUserControl1.Hide();
            unassignedUserControl1.Hide();
            rptEmployeeUserControl1.Hide();
        }
        private void BtnAllAssets_Click(object sender, EventArgs e)
        {
            rptAssignedUserControl1.Hide();
            unassignedUserControl1.Hide();
            rptEmployeeUserControl1.Hide();
            rptAllAssetsUserControl1.Show();
            rptAllAssetsUserControl1.BringToFront();
        }

        private void BtnAssignedAssets_Click(object sender, EventArgs e)
        {
            rptAllAssetsUserControl1.Hide();
            unassignedUserControl1.Hide();
            rptEmployeeUserControl1.Hide();
            rptAssignedUserControl1.Show();
            rptAssignedUserControl1.BringToFront();
        }

        private void BtnUnAssignedAssets_Click(object sender, EventArgs e)
        {
            rptAssignedUserControl1.Hide();
            rptAllAssetsUserControl1.Hide();
            rptEmployeeUserControl1.Hide();
            unassignedUserControl1.Show();
            unassignedUserControl1.BringToFront();
        }

        private void BtnAllEmployees_Click(object sender, EventArgs e)
        {
            rptAssignedUserControl1.Hide();
            rptAllAssetsUserControl1.Hide();
            unassignedUserControl1.Hide();
            rptEmployeeUserControl1.Show();
            rptEmployeeUserControl1.BringToFront();
        }
    }
}
