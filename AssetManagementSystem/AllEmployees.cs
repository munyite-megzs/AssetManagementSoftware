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
    public partial class AllEmployees : Form
    {
        List<VIEWALLEMP> vIEWALLEMPs;
        public AllEmployees(List<VIEWALLEMP> vIEWALLEMPs)
        {
            InitializeComponent();
            this.vIEWALLEMPs = vIEWALLEMPs;
        }

        private void AllEmployees_Load(object sender, EventArgs e)
        {
            AllEmpCrystalReport1.SetDataSource(vIEWALLEMPs);
            crystalReportViewer1.RefreshReport();
        }
    }
}
