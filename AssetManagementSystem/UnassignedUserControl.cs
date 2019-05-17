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
    public partial class UnassignedUserControl : UserControl
    {
        public UnassignedUserControl()
        {
            InitializeComponent();
        }

        private void UnassignedUserControl_Load(object sender, EventArgs e)
        {
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                rPTUNASSIGNEDALLASSETBindingSource.DataSource = db.RPTUNASSIGNEDALLASSETS.ToList();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (rPTUNASSIGNEDALLASSETBindingSource.DataSource is List<RPTUNASSIGNEDALLASSET> RPTASSIGNEDALLASSETS)
            {

                using (UnassignedForm tryReport = new UnassignedForm(RPTASSIGNEDALLASSETS))
                {
                    tryReport.ShowDialog();
                }

            }
        }
    }
}
