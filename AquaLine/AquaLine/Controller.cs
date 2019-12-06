using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace AquaLine
{
    public class Controller
    {
        
        private DBManager dbMan; // A Reference of type DBManager 
        // (Initially NULL; NO DBManager Object is created yet)

        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }

        //checks the username/password and returns the priviledges associated with this user
        //Returns 0 in case of error
       

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int CheckPassword_Basic(string username, string password)
        {
            string StoredProcedureName = StoredProcedures.getloginpriv;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@password", password);
            
            object p = dbMan.ExecuteScalar(StoredProcedureName,Parameters);
            if (p == null) return 0;
            else return (int)p;
        }

        public DataTable getallstock()
        {
            string StoredProcedureName = StoredProcedures.getstockitems;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable getclientorders()
        {
            string StoredProcedureName = StoredProcedures.getclientorders;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable getwarehousesall()
        {
            string StoredProcedureName = StoredProcedures.getwarehouse;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        
            public DataTable getbranches()
        {
            string StoredProcedureName = StoredProcedures.getbranches;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable getbranchnamess()
        {
            string StoredProcedureName = StoredProcedures.getbranchnamess;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        

        public int insertbranch(string branchname,int cap,int hours)
        {

            string StoredProcedureName = StoredProcedures.insertbranch;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@branchname", branchname);
            Parameters.Add("@capacity", cap);
            Parameters.Add("@hours", hours);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletebranch(string branchname)
        {

            string StoredProcedureName = StoredProcedures.deletebranch;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@branch", branchname);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insertwarehouse(string warname, int cap)
        {

            string StoredProcedureName = StoredProcedures.insertwarehouse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@branchname", warname);
            Parameters.Add("@capacity", cap);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int deletewarehouse(string branchname)
        {

            string StoredProcedureName = StoredProcedures.deletewarehouse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@branch", branchname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable getclients()
        {
            string StoredProcedureName = StoredProcedures.getclients;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable getaccountants()
        {
            string StoredProcedureName = StoredProcedures.getaccountants;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable getengineers()
        {
            string StoredProcedureName = StoredProcedures.getengineers;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable getmanagers()
        {
            string StoredProcedureName = StoredProcedures.getmanagers;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
       
        public DataTable getstockitems()
        {
            string StoredProcedureName = StoredProcedures.getstockitems;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public int deleteaccountant(string branchname)
        {

            string StoredProcedureName = StoredProcedures.deleteaccountant;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ManName", branchname);
             return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deleteengineer(string branchname)
        {

            string StoredProcedureName = StoredProcedures.deleteengineer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ManName", branchname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletemanager(string branchname)
        {

            string StoredProcedureName = StoredProcedures.deletemanager;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ManName", branchname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insertaccountant(string warname, int cap, string sal, string hire, string birth)
        {

            string StoredProcedureName = StoredProcedures.insertaccountant;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
           // SqlDbType.Date). hiredate = hire;
            Parameters.Add("@manname", warname);
            Parameters.Add("@manssn", cap);
            Parameters.Add("@mansalary", sal);
            Parameters.Add("@manhiredate", hire);
            Parameters.Add("@manbirthdate", birth);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insertengineer(string warname, int cap, string sal, string hire, string birth)
        {

            string StoredProcedureName = StoredProcedures.insertengineer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@manname", warname);
            Parameters.Add("@manssn", cap);
            Parameters.Add("@mansalary", sal);
            Parameters.Add("@manhiredate",hire);
            Parameters.Add("@manbirthdate", birth);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insertmanager(string warname, int cap, string sal, string hire, string birth)
        {

            string StoredProcedureName = StoredProcedures.insertmanager;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@manname", warname);
            Parameters.Add("@manssn", cap);
            Parameters.Add("@mansalary", sal);
            Parameters.Add("@manhiredate", hire);
            Parameters.Add("@manbirthdate", birth);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable getsuppliers()
        {
            string StoredProcedureName = StoredProcedures.getsuppliers;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable getsupplierorderitemsall()
        {
            string StoredProcedureName = StoredProcedures.getsupplierorderitemsall;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public int insertsupplier(string warname, string cap, string cap2, string cap3)
        {

            string StoredProcedureName = StoredProcedures.insertsupplier;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@supname", warname);
            Parameters.Add("@suplocation", cap);
            Parameters.Add("@supphonenumber", cap2);
            Parameters.Add("@supemail", cap3);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletesupplier(string branchname)
        {

            string StoredProcedureName = StoredProcedures.deletesupplier;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ProductName", branchname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insertclient(string warname, string cap, string cap2, string cap3, string cap4)
        {

            string StoredProcedureName = StoredProcedures.insertclient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@clName", warname);
            Parameters.Add("@cllocation", cap);
            Parameters.Add("@clrepname", cap2);
            Parameters.Add("@clphonenumber", cap3);
            Parameters.Add("@clemail", cap4);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deleteclient(string branchname)
        {

            string StoredProcedureName = StoredProcedures.deleteclient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@clName", branchname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insertstockitem(string warname, string cap, string cap3)
        {

            string StoredProcedureName = StoredProcedures.insertstockitem;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ProductName", warname);
            Parameters.Add("@weight", cap);
            Parameters.Add("@price", cap3);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletestockitems(string branchname)
        {

            string StoredProcedureName = StoredProcedures.deletestockitems;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ProductName", branchname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        ///////////////////////////////////////////////////////////////////////
        public DataTable getlegalinfo()
        {
            string StoredProcedureName = StoredProcedures.viewlegalinfo;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable getsupplierorders()
        {
            string StoredProcedureName = StoredProcedures.getsupplierorders;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int insertsupplierorder(int id, string Due, string Issue, string supname,int ManagerSSN)
        {

            string StoredProcedureName = StoredProcedures.insertsupplierorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ordid", id);
            Parameters.Add("@ordduedate", Due);
            Parameters.Add("@ordissuedate", Issue);
            Parameters.Add("@ordsuppliername", supname);
            Parameters.Add("@ordmanssncreate", ManagerSSN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int insertclientorder(int id, string Issue, string Due, string payment, string clientname ,int EngineerSSN, int ManagerSSN, int AccountantSSN)
        {

            string StoredProcedureName = StoredProcedures.insertclientorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ordid", id);
            Parameters.Add("@ordissuedate", Issue);
            Parameters.Add("@ordduedate", Due);
            Parameters.Add("@ordspaymethod", payment);
            if(EngineerSSN==0)
                Parameters.Add("@ordengssn",DBNull.Value);
            else
            Parameters.Add("@ordengssn", EngineerSSN);
            if (ManagerSSN == 0)
                Parameters.Add("@ordmanssncreate", DBNull.Value);
            else
            Parameters.Add("@ordmanssncreate", ManagerSSN);
            if (AccountantSSN == 0)
                Parameters.Add("@ordacccreate", DBNull.Value);
            else
            Parameters.Add("@ordacccreate", AccountantSSN);

            Parameters.Add("@ordclientname", clientname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletesupplierorder(int id)
        {

            string StoredProcedureName = StoredProcedures.deletesupplierorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ordid", id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deleteclientrorder(int id)
        {

            string StoredProcedureName = StoredProcedures.deleteclientorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ordid", id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable getassignments()
        {
            string StoredProcedureName = StoredProcedures.getassignments;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int insertassignment(int id, string Status, string Due, string Create, int EngSSN,string ClientName)
        {

            string StoredProcedureName = StoredProcedures.insertassignment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@asid", id);
            Parameters.Add("@asstatus", Status);
            Parameters.Add("@asduedate", Due);
            Parameters.Add("@ascreationdate", Create);
            Parameters.Add("@asengssn", EngSSN);
            Parameters.Add("@asclientname", ClientName);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deleteassignment(int id)
        {

            string StoredProcedureName = StoredProcedures.deleteassignment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@asid", id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable getitemsinclientorder(int ordid)
        {
            string StoredProcedureName = StoredProcedures.getitemsinclientorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ordid", @ordid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable getorderincludingitem(string itemname)
        {
            string StoredProcedureName = StoredProcedures.getorderincludingitem;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@itemname", itemname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int Insertiteminclientorder(int ordid,string prodname,int qty)
        {

            string StoredProcedureName = StoredProcedures.insertitemintoorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ordid", ordid);
            Parameters.Add("@ordprodname", prodname);
            Parameters.Add("@qty", qty);
           
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deleteitemfromclientorder(int ordid, string prodname)
        {
            string StoredProcedureName = StoredProcedures.deleteitemfromclientorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ordid", ordid);
            Parameters.Add("@ordprodname", prodname);
      
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable getitemsinwarehouse(string warname)
        {
            string StoredProcedureName = StoredProcedures.storesgetitemsinwar;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@warname", warname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int Insertiteminwarehouse(string ordid, string prodname, int qty)
        {

            string StoredProcedureName = StoredProcedures.storesinsertiteminwar;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@warname", ordid);
            Parameters.Add("@itemname", prodname);
            Parameters.Add("@qty", qty);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int deleteitemfromwarehouse(string ordid, string prodname)
        {
            string StoredProcedureName = StoredProcedures.storesdeleteitem;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@warname", ordid);
            Parameters.Add("@itemname", prodname);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int updateiteminwarehouse(string ordid, string prodname, int qty)
        {

            string StoredProcedureName = StoredProcedures.storesupdateitemqty;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@warname", ordid);
            Parameters.Add("@itemname", prodname);
            Parameters.Add("@qty", qty);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updateiteminclientorder(int ordid, string prodname, int qty)
        {

            string StoredProcedureName = StoredProcedures.updateitemiqty;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ordid", ordid);
            Parameters.Add("@itemname", prodname);
            Parameters.Add("@qty", qty);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable getitemsinsuppliertorder(int ordid)
        {
            string StoredProcedureName = StoredProcedures.getitemsinsupplierorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ordid", @ordid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int Insertiteminsupplierorder(int ordid, string prodname, int qty)
        {

            string StoredProcedureName = StoredProcedures.insertitemintosupplierorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ordid", ordid);
            Parameters.Add("@ordprodname", prodname);
            Parameters.Add("@qty", qty);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deleteitemfromsupplierorder(int ordid, string prodname)
        {
            string StoredProcedureName = StoredProcedures.deleteitemfromsupplierorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ordid", ordid);
            Parameters.Add("@ordprodname", prodname);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int updateiteminsupplierorder(int ordid, string prodname, int qty)
        {

            string StoredProcedureName = StoredProcedures.updateitemiqtysupplier;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ordid", ordid);
            Parameters.Add("@itemname", prodname);
            Parameters.Add("@qty", qty);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        /////////////////////////////////
        ///
        public DataTable searchassid(int id)
        {
            string StoredProcedureName = StoredProcedures.searchassid;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable searchclientorderid(int id)
        {
            string StoredProcedureName = StoredProcedures.searchclientorderid;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable searchsupplierorderid(int id)
        {
            string StoredProcedureName = StoredProcedures.searchsupplierorderid;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable searchstockitemname(string name)
        {
            string StoredProcedureName = StoredProcedures.searchstockitemname;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable searchclientsname(string name)
        {
            string StoredProcedureName = StoredProcedures.searchclientsname;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable searchsuppliername(string name)
        {
            string StoredProcedureName = StoredProcedures.searchsuppliersname;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable searchaccountantid(int id)
        {
            string StoredProcedureName = StoredProcedures.searchaccountantid;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable searchengid(int id)
        {
            string StoredProcedureName = StoredProcedures.searchengid;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable searchmanagerid(int id)
        {
            string StoredProcedureName = StoredProcedures.searchmanagerid;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable searchbranchname(string name)
        {
            string StoredProcedureName = StoredProcedures.searchabranchname;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable searchwarehousename(string name)
        {
            string StoredProcedureName = StoredProcedures.searchawarehousename;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int changepassword(string user,string  passold,string pass)
        {

            string StoredProcedureName = StoredProcedures.userchangepassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", user);
            Parameters.Add("@passold", passold);
            Parameters.Add("@pass", pass);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int addnewuser(string user, string passold, int priv)
        {

            string StoredProcedureName = StoredProcedures.addnewuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", user);
            Parameters.Add("@pass", passold);
            Parameters.Add("@priv", priv);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        ////////////////////
        ///
        public int updateassignment(int id, string Status, string Due, string Create, int EngSSN, string ClientName)
        {

            string StoredProcedureName = StoredProcedures.updateassignment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@asid", id);
            Parameters.Add("@asstatus", Status);
            Parameters.Add("@asduedate", Due);
            Parameters.Add("@ascreationdate", Create);
            Parameters.Add("@asengssn", EngSSN);
            Parameters.Add("@asclientname", ClientName);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updatewarehousecapacity(string warname, int cap)
        {

            string StoredProcedureName = StoredProcedures.updatewarehousecapacity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@branchname", warname);
            Parameters.Add("@capacity", cap);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updateaccountant(string warname, int cap, string sal, string hire, string birth)
        {

            string StoredProcedureName = StoredProcedures.updateaccountant;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            // SqlDbType.Date). hiredate = hire;
            Parameters.Add("@manname", warname);
            Parameters.Add("@manssn", cap);
            Parameters.Add("@mansalary", sal);
            Parameters.Add("@manhiredate", hire);
            Parameters.Add("@manbirthdate", birth);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updateengineer(string warname, int cap, string sal, string hire, string birth)
        {

            string StoredProcedureName = StoredProcedures.updateengineer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            // SqlDbType.Date). hiredate = hire;
            Parameters.Add("@manname", warname);
            Parameters.Add("@manssn", cap);
            Parameters.Add("@mansalary", sal);
            Parameters.Add("@manhiredate", hire);
            Parameters.Add("@manbirthdate", birth);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updatemanager(string warname, int cap, string sal, string hire, string birth)
        {

            string StoredProcedureName = StoredProcedures.updatemanager;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            // SqlDbType.Date). hiredate = hire;
            Parameters.Add("@manname", warname);
            Parameters.Add("@manssn", cap);
            Parameters.Add("@mansalary", sal);
            Parameters.Add("@manhiredate", hire);
            Parameters.Add("@manbirthdate", birth);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int updatebranch(string old, string newname, int cap, int hour)
        {

            string StoredProcedureName = StoredProcedures.updatebranch;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@oldbranchname", old);
            Parameters.Add("@newbranchname", newname);
            Parameters.Add("@capacity", cap);
            Parameters.Add("@hours", hour);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updatesupplier(string old, string newname, string cap, string hour)
        {

            string StoredProcedureName = StoredProcedures.updatesupplier;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@supname", old);
            Parameters.Add("@suplocation", newname);
            Parameters.Add("@supphonenumber", cap);
            Parameters.Add("@supemail", hour);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updateclient(string old, string newname, string cap, string hour, string em)
        {

            string StoredProcedureName = StoredProcedures.updateclient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@clName", old);
            Parameters.Add("@cllocation", newname);
            Parameters.Add("@clrepname", cap);
            Parameters.Add("@clphonenumber", hour);
            Parameters.Add("@clemail", em);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updatestockitem(string old, string newname, string cap)
        {

            string StoredProcedureName = StoredProcedures.updatestockitem;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ProductName", old);
            Parameters.Add("@weight", newname);
            Parameters.Add("@price", cap);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updatesupplierorder(int id, string Due, string Issue, string supname, int ManagerSSN)
        {

            string StoredProcedureName = StoredProcedures.updatesupplierorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ordid", id);
            Parameters.Add("@ordduedate", Due);
            Parameters.Add("@ordissuedate", Issue);
            Parameters.Add("@ordsuppliername", supname);
            Parameters.Add("@ordmanssncreate", ManagerSSN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updateclientorder(int id, string Issue, string Due, string payment, string clientname, int EngineerSSN, int ManagerSSN, int AccountantSSN)
        {

            string StoredProcedureName = StoredProcedures.updateclientorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ordid", id);
            Parameters.Add("@ordissuedate", Issue);
            Parameters.Add("@ordduedate", Due);
            Parameters.Add("@ordspaymethod", payment);
            if (EngineerSSN == 0)
                Parameters.Add("@ordengssn", DBNull.Value);
            else
                Parameters.Add("@ordengssn", EngineerSSN);
            if (ManagerSSN == 0)
                Parameters.Add("@ordmanssncreate", DBNull.Value);
            else
                Parameters.Add("@ordmanssncreate", ManagerSSN);
            if (AccountantSSN == 0)
                Parameters.Add("@ordacccreate", DBNull.Value);
            else
                Parameters.Add("@ordacccreate", AccountantSSN);

            Parameters.Add("@ordclientname", clientname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


    }
     
    
}
