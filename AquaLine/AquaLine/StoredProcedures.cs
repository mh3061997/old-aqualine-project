using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaLine
{
    public class StoredProcedures
    {
        public static string deleteaccountant = "deleteaccountant";
        public static string deleteassignment = "deleteassignment";
        public static string deletebranch = "deletebranch";
        public static string deleteclient = "deleteclient";
        public static string deleteclientorder = "deleteclientorder";
        public static string deleteengineer = "deleteengineer";
        public static string deleteitemfromclientorder = "deleteitemfromclientorder";
        public static string deleteitemfromsupplierorder = "deleteitemfromsupplierorder";
        public static string deletemanager = "deletemanager";
        public static string deletestockitems = "deletestockitems";
        public static string deletesupplier = "deletesupplier";
        public static string deletesupplierorder = "deletesupplierorder";
        public static string deletewarehouse = "deletewarehouse";
        public static string getaccountants = "getaccountants";
        public static string getassignments = "getassignments";

        public static string getbranches = "getbranches";
        public static string getbranchnamess = "getbranchnamess";
        public static string getclientorderitemsall = "getclientorderitemsall";
        public static string getclientorders = "getclientorders";
        public static string getclients = "getclients";
        public static string getclientwithmostassignments = "getclientwithmostassignments";
        public static string getclientwithmostorders = "getclientwithmostorders";

        public static string getengineers = "getengineers";
        public static string getengwmosttasks = "getengwmosttasks";
        public static string getitemsinclientorder = "getitemsinclientorder";
        public static string getitemsinsupplierorder = "getitemsinsupplierorder";
        public static string getloginpriv = "getloginpriv";
        public static string getmanagers = "getmanagers";
        public static string getmostordereditem = "getmostordereditem";

        public static string getmostsupplierorderfrom = "getmostsupplierorderfrom";
        public static string getorderincludingitem = "[getorderincludingitem]";
        public static string getstockitems = "getstockitems";
        public static string getsupplierorderincludingitem = "getsupplierorderincludingitem";
        public static string getsupplierorderitemsall = "getsupplierorderitemsall";
        public static string getsupplierorders = "getsupplierorders";
        public static string getsuppliers = "getsuppliers";

        public static string getwarehouse = "getwarehouse";
        public static string insertaccountant = "insertaccountant";
        public static string insertassignment = "insertassignment";
        public static string insertbranch = "insertbranch";
        public static string insertclient = "insertclient";
        public static string insertclientorder = "insertclientorder";
        public static string insertengineer = "insertengineer";

        public static string insertitemintoorder = "insertitemintoorder";
        public static string insertitemintosupplierorder = "insertitemintosupplierorder";
        public static string insertmanager = "insertmanager";
        public static string insertstockitem = "insertstockitem";
        public static string insertsupplier = "insertsupplier";
        public static string insertsupplierorder = "insertsupplierorder";
        public static string insertwarehouse = "insertwarehouse";

        public static string updateaccountant = "updateaccountant";
        public static string updateassignment = "updateassignment";
        public static string updatebranch = "updatebranch";
        public static string updateclient = "updateclient";
        public static string updateclientorder = "updateclientorder";
        public static string updateengineer = "updateengineer";
        public static string updateitemiqty = "updateitemiqty";

        public static string updateitemiqtysupplier = "updateitemiqtysupplier";
        public static string updatelegalinfo = "updatelegalinfo";
        public static string updatemanager = "updatemanager";
        public static string updatestockitem = "updatestockitem";
        public static string updatesupplier = "updatesupplier";
        public static string updatesupplierorder = "updatesupplierorder";
        public static string updatewarehousecapacity = "updatewarehousecapacity";

        public static string viewlegalinfo = "viewlegalinfo";

        public static string storesdeleteitem = "storesdeleteitem";
        public static string storesgetitemsinwar = "storesgetitemsinwar";
        public static string storesinsertiteminwar = "storesinsertiteminwar";
        public static string storesupdateitemqty = "storesupdateitemqty";

        public static string searchassid = "searchassid";
        public static string searchclientorderid = "searchclientorderid";
        public static string searchsupplierorderid = "searchsupplierorderid";
        public static string searchstockitemname = "searchstockitemname";
        public static string searchclientsname = "searchclientsname";
        public static string searchsuppliersname = "searchsuppliersname";
        public static string searchaccountantid = "searchaccountantid";
        public static string searchengid = "searchengid";
        public static string searchmanagerid = "searchmanagerid";
        public static string searchabranchname = "searchabranchname";
        public static string searchawarehousename = "searchawarehousename";

        public static string userchangepassword = "userchangepassword";
        public static string addnewuser = "addnewuser";

        

    }
}
