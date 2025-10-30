using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Reflection.Emit;

namespace ACS_aupchurchM1A
{

    internal class DBConnect
    { 
    private const string CONNECT_STRING = @"Server=3.130.26.194;" + "Database=itse2353pbe;" + "User Id=aupchurchSU252353;" + "Password=Au3241903$;";

    private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);

    private static SqlCommand _sqlCustomersCommand;

    private static SqlDataAdapter _daCustomers = new SqlDataAdapter();

    private static DataTable _dtCustomersTable = new DataTable();

        public static DataTable DTCustomersTable
        {
            get { return _dtCustomersTable; }
            set { _dtCustomersTable = value; }
        }

        // text boxes from frmCustomers
        private static TextBox _tbxCustomerID;
        private static TextBox _tbxCompanyName;
        private static TextBox _tbxContactName;
        private static TextBox _tbxContactTitle;

        // 4. Getters and setters for textboxes (lesson plan style)
        public static TextBox TbxCustomerID
        {
            get { return _tbxCustomerID; }
            set { _tbxCustomerID = value; }
        }
        public static TextBox TbxCompanyName
        {
            get { return _tbxCompanyName; }
            set { _tbxCompanyName = value; }
        }
        public static TextBox TbxContactName
        {
            get { return _tbxContactName; }
            set { _tbxContactName = value; }
        }
        public static TextBox TbxContactTitle
        {
            get { return _tbxContactTitle; }
            set { _tbxContactTitle = value; }
        }

        //connect method
        public static void OpenCreateData()
    {
        _cntDatabase.Open();

        _sqlCustomersCommand = new SqlCommand("SELECT * FROM alupchurchSU252353.Customers", _cntDatabase);
        _daCustomers.SelectCommand = _sqlCustomersCommand;
        _daCustomers.Fill(_dtCustomersTable);
        
        TbxCustomerID.DataBindings.Add("Text", _dtCustomersTable, "CustomerId");
        TbxCompanyName.DataBindings.Add("Text", _dtCustomersTable, "CompanyName");
        TbxContactName.DataBindings.Add("Text", _dtCustomersTable, "ContactName");
        TbxContactTitle.DataBindings.Add("Text", _dtCustomersTable, "ContactTitle");
    }


    public static void CloseDisposeData()
        {
            //close and dispose
            _cntDatabase.Close();
            _cntDatabase.Dispose();
            _sqlCustomersCommand.Dispose();
            _daCustomers.Dispose();
            _dtCustomersTable.Dispose();
        }
  
}
}
