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
    public partial class RptAllAssetsUserControl : UserControl
    {
        public RptAllAssetsUserControl()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

            if (rPTALLASSETBindingSource.DataSource is List<RPTALLASSET> RPTALLASSET)
            {

                using (AllAssetsForm tryReport = new AllAssetsForm(RPTALLASSET))
                {
                    tryReport.ShowDialog();
                }

            }

        }

        private void RptAllAssetsUserControl_Load(object sender, EventArgs e)
        {
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                rPTALLASSETBindingSource.DataSource = db.RPTALLASSETS.ToList();
            }
        }
    }
}
