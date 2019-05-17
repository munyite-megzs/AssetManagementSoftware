using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementSystem.MainUserControls.SharedClasses
{
   

    public static class CommonData
    {

        public static string SelectedEmpId;
        public static string Fname;
        public static string Lname;
        public static string WorkNO;
        public static string MobileNO;
        public static string PersonalNumber;
        public static string Email;
        public static string TitleId;
        public static string GroupId;
        public static string Statusid;
        public static string AssetNo;
        public static string Filename;
        public static List<string> choosenAssetNum;

        public static string EMPFilename { get; internal set; }
    } 

    public static class Finances
    {
        public static string VendorName { get; set; }
        public static string TxtPoNumber { get; set; }
        public static Decimal RecPeriod { get; set; }
        public static string PurchasePrice { get; set; }
        public static string MarketVlaue { get; set; }
        public static string ScrapValue { get; set; }
        public static string DatePurchase { get; set; }
        public static string Service { get; set; }
        public static string DtpWarranty { get; set; }
    }

    public class Employee
    {


        public string EmpId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Workno { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int Statusid { get; set; }
        public int GROUPID { get; set; }
        public int TITLEID { get; set; }
        public int IMAGEID { get; set; }
    }


    public class Asset
    {
        public string Comment { get; set; }
        public string AssetNo { get; set; }
        public string EmpName { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime CheckoinDate { get; set; }
        public int StatusId { get; set; }
        public int LocationId { get; set; }
        public string EmpId { get; set; }
    }

    public class Save_NewMembers
    {
        //variable Declarations 
        EMPLOYEETABLE employeeTable = new EMPLOYEETABLE();
        readonly ASSET myAsset = new ASSET();

        public Save_NewMembers()
        {

        }

        public void UpdateAssetTable(List<Asset> assets)
        {



            try
            {
                using (AccetManagementEntities db = new AccetManagementEntities())
                {

                    foreach (var empDetails in assets)
                    {
                        //get the Asset table 
                        var assetTableData = db.ASSETs.Where(c => c.ASSETNO == empDetails.AssetNo).OrderBy(c => c.ASSETNO).ToList();

                        var results = db.ASSETs.SingleOrDefault(a => a.ASSETNO == empDetails.AssetNo);

                        if (results != null)
                        {
                            results.CHECKOUTCOMMENT = empDetails.Comment;
                            results.EMPNAME = empDetails.EmpName;
                            results.CHECKOUTDATE = DateTime.Now;
                            results.STATUSID = empDetails.StatusId;
                            results.LOCATIONID = empDetails.LocationId;
                            results.EMPID = CommonData.PersonalNumber;

                            db.SaveChanges();

                        }



                    }


                    // db.EMPLOYEETABLEs.Add(employeeTable);



                }

            }
            catch (Exception)
            {

                throw;
            }

            //update the row
        }



        public void CheckinUpdate(List<Asset> assets)
        {



            try
            {
                using (AccetManagementEntities db = new AccetManagementEntities())
                {

                    foreach (var empDetails in assets)
                    {
                        //get the Asset table 
                        var assetTableData = db.ASSETs.Where(c => c.ASSETNO == empDetails.AssetNo).OrderBy(c => c.ASSETNO).ToList();

                        var results = db.ASSETs.SingleOrDefault(a => a.ASSETNO == empDetails.AssetNo);

                        if (results != null)
                        {
                            results.CHECKOUTCOMMENT = empDetails.Comment;
                            results.EMPNAME = "";
                            results.STATUSID = empDetails.StatusId;
                            results.LOCATIONID = empDetails.LocationId;

                            db.SaveChanges();

                        }



                    }


                    // db.EMPLOYEETABLEs.Add(employeeTable);



                }

            }
            catch (Exception)
            {

                throw;
            }

            //update the row
        }




        public void SaveMember(List<Employee> empid)
        {


            try
            {
                using (AccetManagementEntities db = new AccetManagementEntities())
                {

                    foreach (var empDetails in empid)
                    {
                        employeeTable.EMPID = empDetails.EmpId;
                        employeeTable.FNAME = empDetails.Fname;
                        employeeTable.LNAME = empDetails.Lname;
                        employeeTable.WORKPHONE = empDetails.Workno;
                        employeeTable.MOBILEPHONE = empDetails.MobilePhone;
                        employeeTable.EMAIL = empDetails.Email;
                        employeeTable.STATUSID = empDetails.Statusid;
                        employeeTable.GROUPID = empDetails.GROUPID;
                        employeeTable.TITLEID = empDetails.TITLEID;
                        employeeTable.IMAGEID = empDetails.IMAGEID;



                    }


                    db.EMPLOYEETABLEs.Add(employeeTable);
                    db.SaveChanges();


                }

            }
            catch (Exception)
            {

                throw;
            }

        }



    }
}
