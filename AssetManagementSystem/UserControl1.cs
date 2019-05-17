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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        void LoadCombobox()
        {
            ////Clear combobox items first
            //cmBStatus.Items.Clear();
            //cmBCondition.Items.Clear();
            ////get the items from db
            //using (AccetManagementEntities db = new AccetManagementEntities())
            //{
            //    var statusquery = db.STATUS
            //                           .Select(e => e.STATUSNAME).ToList();
            //    cmBStatus.DataSource = statusquery;

            //    var locationquery = db.CONDITIONs
            //                          .Select(a => a.CONDITIONNAME).ToList();
            //    cmBCondition.DataSource = locationquery;

            //}

            //if (txtcheckedOutto.Text == " ")
            //{
            //    btnUser.Enabled = false;
            //}

        }


        public void populateControl(string assno)
        {
            using (AccetManagementEntities db = new AccetManagementEntities())
            {

                //var assDetails = db.ASSETs.Where(c => c.ASSETNO == assno).ToList();

                //var statusId = assDetails[0].STATUSID;
                //var dd = db.STATUS.Where(e => e.STATUSID == statusId).Select(e => e.STATUSNAME).ToList();

                //var cond = assDetails[0].CONDITIONID;
                //var ddCon = db.CONDITIONs.Where(e => e.CONDITIONID == cond).Select(e => e.CONDITIONNAME).ToList();

                //txtserial.SelectedText = assDetails[0].SERIALNUMBER;
                //cmBStatus.Text = dd[0].ToString();
                //txtcheckedOutto.Text = assDetails[0].EMPNAME;
                //dueDatepicker.Text = assDetails[0].DUEDATE.ToString();
                //txtNotes.Text = assDetails[0].NOTES;









            }
        }

        private void NewUserControl_Load(object sender, EventArgs e)
        {
            LoadCombobox();
        }
    }
}
