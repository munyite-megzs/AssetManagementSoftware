using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssetManagementSystem.MainUserControls.SharedClasses;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace AssetManagementSystem
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            LoadCombobox();
        }

        private void LoadCombobox()
        {
            //Clear combobox items first
            cmbTitle.Items.Clear();
            cmbGroup.Items.Clear();
            cmbStatus.Items.Clear();
            //get the items from db
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                var titlequery = db.ORGANIZATIONROLEs
                                       .Select(e => e.TITLE).ToList();
                cmbTitle.DataSource = titlequery;

                var groupquery = db.ORGANIZATIONGROUPs
                                      .Select(a => a.GROUPNAME).ToList();
                cmbGroup.DataSource = groupquery;

                var statusquery = db.EMPLOYEESTATUS
                                      .Select(a => a.EMPSTATUSNAME).ToList();
                cmbStatus.DataSource = statusquery;

            }
        }

        EMPLOYEETABLE employeeTable = new EMPLOYEETABLE();
        Save_NewMembers saveEmp = new Save_NewMembers();
        string fileName;
        
        private void AsseetCheckedOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvHistory.Visible = false;
            dgvChqInOut.Visible = true;
            //historyControl1.Hide();



            dgvChqInOut.DataSource = null;
            using (AccetManagementEntities db = new AccetManagementEntities())
            {

                dgvChqInOut.AutoGenerateColumns = false;
                //dgvChqInOut.DataSource = db.VIEWCHECKOUTsearches.ToList<VIEWCHECKOUTsearch>(); 
                dgvChqInOut.DataSource = db.VIEWEMPCHECKOUTLISTs.Where(a => a.EMPID == CommonData.PersonalNumber).ToList<VIEWEMPCHECKOUTLIST>();



            }
            chqOut1.Show();
            chqOut1.BringToFront();
            dgvChqInOut.BringToFront();
        }

        //get empdetails
        public void EmpDetails()
        {
            if (txtpersonalNumber.Text == "")
            {
                MessageBox.Show("New Employee.",
                                "Personal Number Cannot be Empty!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {
                SaveToDatabase();
            }

        }


        void SaveToDatabase()
        {
            try
            {
                using (AccetManagementEntities db = new AccetManagementEntities())
                {

                    var titleId = db.ORGANIZATIONROLEs.Where(c => c.TITLE == cmbTitle.Text).Select(c => c.TITLEID).ToList();
                    var groupId = db.ORGANIZATIONGROUPs.Where(c => c.GROUPNAME == cmbGroup.Text).Select(c => c.GROUPID).ToList();
                    var statusId = db.EMPLOYEESTATUS.Where(c => c.EMPSTATUSNAME == cmbStatus.Text).Select(c => c.ID).ToList();

                    // Save Image
                    //save Picture 
                    var pathe = CommonData.EMPFilename ?? "";
                    var checkIfEmployeeExists = db.EMPLOYEETABLEs.SingleOrDefault(c => c.EMPID == txtpersonalNumber.Text.ToString().Trim());

                    if (checkIfEmployeeExists == null)
                    {

                        List<Employee> employees = new List<Employee>
                    {
                        new Employee()
                        {
                            EmpId = txtpersonalNumber.Text.ToString().Trim(),
                            Fname = txtFname.Text.ToString().Trim().ToUpper(),
                            Lname = txtLname.Text.ToString().Trim().ToUpper(),
                            Workno = txtWorkno.Text.ToString().Trim(),
                            MobilePhone = txtPhone.Text.ToString().Trim().ToUpper(),
                            Email = txtEmail.Text.ToString().Trim(),
                            Statusid = statusId[0],
                            GROUPID = groupId[0],
                            TITLEID = titleId[0],
                            IMAGEID = 1


                        }
                    };

                        saveEmp.SaveMember(employees);
                        
                        if (pictureBox1.Image != null)
                        {
                            EMPLOYEEIMAGE eMPLOYEEIMAGE = new EMPLOYEEIMAGE
                            {

                                EMPIMAGEID = txtpersonalNumber.Text.ToString().Trim(),
                                FILEPATH = pathe


                            };
                            db.EMPLOYEEIMAGEs.Add(eMPLOYEEIMAGE);
                            
                        }
                    }
                    else
                    {

                        var empImage = db.EMPLOYEEIMAGEs.SingleOrDefault(x => x.EMPIMAGEID == txtpersonalNumber.Text.ToString().Trim());
                        var fileNamePth = pathe;
                        if (empImage == null)
                        {

                            if (pictureBox1.Image != null)
                            {
                                EMPLOYEEIMAGE employeeImage = new EMPLOYEEIMAGE
                                {
                                    EMPIMAGEID = txtpersonalNumber.Text.ToString().Trim(),
                                    FILEPATH = pathe
                                };
                                db.EMPLOYEEIMAGEs.Add(employeeImage);
                            }
                        }
                        else
                        {
                            
                            empImage.EMPIMAGEID = txtpersonalNumber.Text.ToString().Trim();
                            empImage.FILEPATH = fileNamePth;
                        }
                        checkIfEmployeeExists.EMAIL = txtEmail.Text.ToString().Trim();
                        checkIfEmployeeExists.EMPID = txtpersonalNumber.Text.ToString().Trim();
                        checkIfEmployeeExists.FNAME = txtFname.Text.ToString().Trim().ToUpper();
                        checkIfEmployeeExists.GROUPID = groupId[0];
                        checkIfEmployeeExists.IMAGEID = 1;
                        checkIfEmployeeExists.LNAME = txtLname.Text.ToString().Trim().ToUpper();
                        checkIfEmployeeExists.MOBILEPHONE = txtPhone.Text.ToString().Trim().ToUpper();
                        checkIfEmployeeExists.STATUSID = statusId[0];
                        checkIfEmployeeExists.TITLEID = titleId[0];
                        checkIfEmployeeExists.WORKPHONE = txtWorkno.Text.ToString().Trim();
                    }

                    db.SaveChanges();

                    //db.EMPLOYEETABLEs.Add(employeeTable);
                    //db.SaveChanges();
                    this.Close();
                    MessageBox.Show("Saved Successfully to Database.");
                    Application.Restart();



                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void PopulateViewOnlyControls(string data)
        {
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                var empDetails = db.EMPLOYEETABLEs.Where(c => c.EMPID == data).ToList();

                txtFname.Text = empDetails[0].FNAME;
                txtLname.Text = empDetails[0].LNAME;
                txtWorkno.Text = empDetails[0].WORKPHONE;
                txtPhone.Text = empDetails[0].MOBILEPHONE;
                txtEmail.Text = empDetails[0].EMAIL;
                txtpersonalNumber.Text = data;
                //var statusId = db.STATUS.Where(c => c.STATUSNAME == currentStatus).OrderBy(c => c.STATUSNAME).Select(c => c.STATUSID).ToList();
                var titleId = empDetails[0].TITLEID;
                var dd = db.ORGANIZATIONROLEs.Where(e => e.TITLEID == titleId).Select(e => e.TITLE).ToList();
                cmbTitle.Text = dd[0].ToString();

                var groupId = empDetails[0].GROUPID;
                var gg = db.ORGANIZATIONGROUPs.Where(a => a.GROUPID == groupId).Select(a => a.GROUPNAME).ToList();
                cmbGroup.Text = gg[0].ToString();

                var eStatusid = empDetails[0].STATUSID;
                var emstatusid = db.EMPLOYEESTATUS.Where(a => a.ID == eStatusid).Select(a => a.EMPSTATUSNAME).ToList();
                cmbStatus.Text = emstatusid[0].ToString();

                CommonData.SelectedEmpId = data;
                CommonData.Fname = txtFname.Text;
                CommonData.Lname = txtLname.Text;
                CommonData.WorkNO = txtWorkno.Text;
                CommonData.MobileNO = txtWorkno.Text;
                CommonData.Email = txtEmail.Text;
                CommonData.Statusid = cmbStatus.Text;
                CommonData.GroupId = cmbGroup.Text;
                CommonData.TitleId = cmbTitle.Text;
                CommonData.PersonalNumber = data;


                this.Text = "Edit Employee " + data;

                string fileName = db.EMPLOYEEIMAGEs.Where(f => f.EMPIMAGEID == data).Select(f => f.FILEPATH).FirstOrDefault();

                if (fileName != null)
                {
                    pictureBox1.Image = ResizeImage(Image.FromFile(fileName), this.Width, this.Height);
                }
               
                

                txtFname.Enabled =false;
                txtLname.Enabled = false;
                txtWorkno.Enabled = false;
                txtPhone.Enabled = false;
                txtEmail.Enabled = false;
                txtpersonalNumber.Enabled = false;




            }
        }

        public void PopulateControls(string data)
        {
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                var empDetails = db.EMPLOYEETABLEs.Where(c => c.EMPID == data).ToList();

                txtFname.Text = empDetails[0].FNAME;
                txtLname.Text = empDetails[0].LNAME;
                txtWorkno.Text = empDetails[0].WORKPHONE;
                txtPhone.Text = empDetails[0].MOBILEPHONE;
                txtEmail.Text = empDetails[0].EMAIL;
                txtpersonalNumber.Text = data;
                //var statusId = db.STATUS.Where(c => c.STATUSNAME == currentStatus).OrderBy(c => c.STATUSNAME).Select(c => c.STATUSID).ToList();
                var titleId = empDetails[0].TITLEID;
                var dd = db.ORGANIZATIONROLEs.Where(e => e.TITLEID == titleId).Select(e => e.TITLE).ToList();
                cmbTitle.Text = dd[0].ToString();

                var groupId = empDetails[0].GROUPID;
                var gg = db.ORGANIZATIONGROUPs.Where(a => a.GROUPID == groupId).Select(a => a.GROUPNAME).ToList();
                cmbGroup.Text = gg[0].ToString();

                var eStatusid = empDetails[0].STATUSID;
                var emstatusid = db.EMPLOYEESTATUS.Where(a => a.ID == eStatusid).Select(a => a.EMPSTATUSNAME).ToList();
                cmbStatus.Text = emstatusid[0].ToString();

                CommonData.SelectedEmpId = data;
                CommonData.Fname = txtFname.Text;
                CommonData.Lname = txtLname.Text;
                CommonData.WorkNO = txtWorkno.Text;
                CommonData.MobileNO = txtWorkno.Text;
                CommonData.Email = txtEmail.Text;
                CommonData.Statusid = cmbStatus.Text;
                CommonData.GroupId = cmbGroup.Text;
                CommonData.TitleId = cmbTitle.Text;
                CommonData.PersonalNumber = data;


                this.Text = "Edit Employee " + data;


                string fileName = db.EMPLOYEEIMAGEs.Where(f => f.EMPIMAGEID == data).Select(f => f.FILEPATH).FirstOrDefault();
                if (fileName != null && fileName !="")
                {
                    pictureBox1.Image = ResizeImage(Image.FromFile(fileName), this.Width, this.Height);
                }
                else
                {

                }
                




            }
        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvChqInOut.Visible = false;
            dgvHistory.Visible = true;
            dgvHistory.DataSource = null;
            using (AccetManagementEntities db = new AccetManagementEntities())
            {

                dgvHistory.AutoGenerateColumns = false;
                //dgvHistory.DataSource = db.VIEWCHECKOUTs.where(a => a.ASS).ToList<VIEWCHECKOUT>();
                dgvHistory.DataSource = db.VIEWCHECKOUTs.Where(a => a.PERSONALNO == CommonData.PersonalNumber).ToList<VIEWCHECKOUT>();


            }
            chqOut1.Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    CommonData.EMPFilename = fileName;

                    pictureBox1.Image = ResizeImage(Image.FromFile(fileName), this.Width, this.Height);

                }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }

        private void ToolStripBtnSave_Click(object sender, EventArgs e)
        {
            SaveToDatabase();
        }
    }
}
