using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagementSystem.MainUserControls
{
    public partial class UnassignedForm : Form
    {
        List<RPTUNASSIGNEDALLASSET>  rPTUNASSIGNEDALLASSETs;
        public UnassignedForm(List<RPTUNASSIGNEDALLASSET> rPTUNASSIGNEDALLASSETs)
        {
            InitializeComponent();
            this.rPTUNASSIGNEDALLASSETs = rPTUNASSIGNEDALLASSETs;
        }

        private void UnassignedForm_Load(object sender, EventArgs e)
        {
            //CrystalReport11.SetDataSource(vIEWALLASSETs);
            UnassignedCrystalReport1.SetDataSource(rPTUNASSIGNEDALLASSETs);
            crystalReportViewer1.RefreshReport();
        }
    }
}
