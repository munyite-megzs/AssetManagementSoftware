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

    public partial class AssignedForm : Form
    {
        List<RPTASSIGNEDALLASSET> rPTASSIGNEDALLASSETs;
        public AssignedForm(List<RPTASSIGNEDALLASSET> rPTASSIGNEDALLASSETs)
        {
            InitializeComponent();
            this.rPTASSIGNEDALLASSETs = rPTASSIGNEDALLASSETs;
        }

        private void AssignedForm_Load(object sender, EventArgs e)
        {
           AssignedCrystalReport1.SetDataSource(rPTASSIGNEDALLASSETs);
            crystalReportViewer1.RefreshReport();
        }
    }
}
