using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using AssetManagementSystem.MainUserControls.SharedClasses;

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
            //Clear combobox items first
            cmBStatus.Items.Clear();
            cmBCondition.Items.Clear();
            //get the items from db
            using (AccetManagementEntities db = new AccetManagementEntities())
            {
                var statusquery = db.STATUS
                                       .Select(e => e.STATUSNAME).ToList();
                cmBStatus.DataSource = statusquery;

                var locationquery = db.CONDITIONs
                                      .Select(a => a.CONDITIONNAME).ToList();
                cmBCondition.DataSource = locationquery;

            }

            if (txtcheckedOutto.Text == " ")
            {
                btnUser.Enabled = false;
            }

        }


        public void PopulateControl(string assno)
        {
            using (AccetManagementEntities db = new AccetManagementEntities())
            {

                var assDetails = db.ASSETs.Where(c => c.ASSETNO == assno).ToList();

                var statusId = assDetails[0].STATUSID;
                var dd = db.STATUS.Where(e => e.STATUSID == statusId).Select(e => e.STATUSNAME).ToList();

                var cond = assDetails[0].CONDITIONID;
                var ddCon = db.CONDITIONs.Where(e => e.CONDITIONID == cond).Select(e => e.CONDITIONNAME).ToList();

                txtserial.SelectedText = assDetails[0].SERIALNUMBER;
                cmBStatus.Text = dd[0].ToString();
                txtcheckedOutto.Text = assDetails[0].EMPNAME;
                dueDatepicker.Text = assDetails[0].DUEDATE.ToString();
                txtNotes.Text = assDetails[0].NOTES;




             }
        }

        private void NewUserControl_Load(object sender, EventArgs e)
        {
            LoadCombobox();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName;
                    fileName = ofd.FileName;
                    CommonData.Filename = fileName;

                    pictureBox1.Image = ResizeImage(Image.FromFile(fileName), this.Width, this.Height);

                }
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
           // pictureBox1.InitialImage = null;
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            AddEmployee empl = new AddEmployee();

            var empno = this.txtcheckedOutto.Text.Trim();  
            if (empno == "")
            {
                btnUser.Enabled = false;
                MessageBox.Show("This Asset Not yet Assigned to any Employee", "Employee",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //txtAssetNumber
             
                
                empl.PopulateViewOnlyControls(CommonData.SelectedEmpId);


                empl.ShowDialog();

            }
            
            
        }
    }
}
