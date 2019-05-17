using System;
using System.Windows.Forms;
using AssetManagementSystem.MainUserControls.SharedClasses;

namespace AssetManagementSystem.MainUserControls
{
    public partial class ChqOut : UserControl
    {
        public ChqOut()
        {
            InitializeComponent();
        }

        private void ToolStripCheckin_Click(object sender, EventArgs e)
        {
            FormCheckin formCheckin = new FormCheckin();
            formCheckin.Show();
        }

        private void SaveNewEmployee()
        {
            AddEmployee addEmloyee = new AddEmployee();
            addEmloyee.EmpDetails();
        }

        private void ToolStripCheckOut_Click(object sender, EventArgs e)
        {
            //FIRST CHECK WHETHER THEY HAVE BEEN SAVED IF NOT DO NOT LOAD THE ASSET PAGE
            //GetEmployeesDetails();
            //get the personal no from Add employees form  


            AddEmployee addEmloyee = new AddEmployee();
            var emDet = addEmloyee.txtFname.Text;
            var personalno = addEmloyee.Controls.Find("txtpersonalNumber", true);

            if (CommonData.SelectedEmpId == null)
            {

                var results = MessageBox.Show("Checkout is only done to Employees who have been saved. would you like to Save this record first?",
                                     "Add Employee",
                                     MessageBoxButtons.OKCancel);

                if (results == DialogResult.Cancel)
                {


                }
                else
                {
                    SaveNewEmployee();

                }

                //if yes save records to database.


            }
            else
            {
                Checkout asset = new Checkout();

                asset.FillControls();
                asset.ShowDialog();
            }
        }
    }
}
