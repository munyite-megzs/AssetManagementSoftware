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
    public partial class RptEmployeeUserControl : UserControl
    {
        public RptEmployeeUserControl()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (vIEWALLEMPBindingSource.DataSource is List<VIEWALLEMP> RPTASSIGNEDALLASSETS)
            {

                using (AllEmployees tryReport = new AllEmployees(RPTASSIGNEDALLASSETS))
                {
                    tryReport.ShowDialog();
                }

            }
         


        }

        private void RptEmployeeUserControl_Load(object sender, EventArgs e)
        {

            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                vIEWALLEMPBindingSource.DataSource = db.VIEWALLEMPs.ToList();
            }

        }
    }
}
