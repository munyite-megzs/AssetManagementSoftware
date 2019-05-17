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
 
      
    public partial class AllAssetsForm : Form
    {
        List<RPTALLASSET> rPTALLASSETs;
        public AllAssetsForm(List<RPTALLASSET> rPTALLASSETs)
        {
            InitializeComponent();
            this.rPTALLASSETs = rPTALLASSETs;
        }

        private void AllAssetsForm_Load(object sender, EventArgs e)
        {
            //CrystalReport11.SetDataSource(vIEWALLASSETs);
            AllAssetsCrystalReport1.SetDataSource(rPTALLASSETs);
            crystalReportViewer1.RefreshReport();
        }
    }
}
