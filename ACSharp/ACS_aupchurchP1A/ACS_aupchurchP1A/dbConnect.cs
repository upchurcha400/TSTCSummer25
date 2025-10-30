using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace ACS_aupchurchP1A
{
    internal class dbConnect
    {
        //connection string  to the database
        private const string CONNECT_STRING =@"Server=3.130.26.194;" + "Database=itse2353pbe;" + "User Id=aupchurchSU252353;" + "Password=Au3241903$;";

        //build a connection to the books db
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        //add the command object
        private static SqlCommand _sqlTitlesCommand;

        private static SqlDataAdapter _daTitles = new SqlDataAdapter();
        //data tables
        private static DataTable _dtTitlesTable = new DataTable();

        //getters and setter
        public static DataTable DTTitlesTable
        {
            get { return _dtTitlesTable; }
            set { _dtTitlesTable = value; }
        }

        //text boxes from frmTitle
        private static TextBox _tbxTitle;
        private static TextBox _tbxYearPub;
        private static TextBox _tbxISBN;
        private static TextBox _tbxPubID;

        //get set
        public static TextBox TbxTitle
        {
            get { return _tbxTitle; }
            set { _tbxTitle = value; }
        }
                public static TextBox TbxYearPub
        {
            get { return _tbxYearPub; }
            set { _tbxYearPub = value; }
        }
                public static TextBox TbxISBN
        {
            get { return _tbxISBN; }
            set { _tbxISBN = value; }
        }
                public static TextBox TbxPubID
        {
            get { return _tbxPubID; }
            set { _tbxPubID = value; }
        }


        //method to connect
        public static void OpenCreateData()
        {
            //method to open and allow use of database
            _cntDatabase.Open();
            //estab command object
            _sqlTitlesCommand = new SqlCommand("Select * From aupchurchSU252353.Titles", _cntDatabase);
            //establish data tables
            _daTitles.SelectCommand = _sqlTitlesCommand;
            // establsih data table
            _daTitles.Fill(_dtTitlesTable);
            //bind text boxes to the data table
            TbxTitle.DataBindings.Add("Text", _dtTitlesTable, "Title");
            TbxYearPub.DataBindings.Add("Text", _dtTitlesTable, "Year_Published");
            TbxISBN.DataBindings.Add("Text", _dtTitlesTable, "ISBN");
            TbxPubID.DataBindings.Add("Text", _dtTitlesTable, "PubID");


        }

        public static void CloseDisposeData()
        {
            //method to close and dispose
            _cntDatabase.Close();
            _cntDatabase.Dispose();
            _sqlTitlesCommand.Dispose();

            _daTitles.Dispose();
            _dtTitlesTable.Dispose();
        }
    }
}
