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
    public partial class RptAssignedUserControl : UserControl
    {
        public RptAssignedUserControl()
        {
            InitializeComponent();
        }

        private void RptAssignedUserControl_Load(object sender, EventArgs e)
        {
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                rPTASSIGNEDALLASSETBindingSource.DataSource = db.RPTASSIGNEDALLASSETS.ToList();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (rPTASSIGNEDALLASSETBindingSource.DataSource is List<RPTASSIGNEDALLASSET> RPTASSIGNEDALLASSETS)
            {

                using (AssignedAssetForm tryReport = new AssignedAssetForm(RPTASSIGNEDALLASSETS))
                {
                    tryReport.ShowDialog();
                }

            }
        }
    }
}
