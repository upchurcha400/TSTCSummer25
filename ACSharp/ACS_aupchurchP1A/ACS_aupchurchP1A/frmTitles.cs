using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ACS_aupchurchP1A
{
    public partial class frmTitles : Form
    {
        CurrencyManager titlesManager;
        public frmTitles()
        {
            InitializeComponent();
        }
        //Database itese2353pbe UserId aupchurchSU252353
        //Password  studentid
        private void frmTitles_Load(object sender, EventArgs e)
        {
         //add textboxes to bdConnect to use in create data method
         dbConnect.TbxTitle = tbxTitle;
            dbConnect.TbxYearPub = tbxYearPub;
            dbConnect.TbxISBN = tbxISBN;
            dbConnect.TbxPubID = tbxPubID;
            //create a connection to the database
            dbConnect.OpenCreateData();
            //establsihs currency manager
            titlesManager = (CurrencyManager)BindingContext[dbConnect.DTTitlesTable];
            //close the connection
            dbConnect.CloseDisposeData();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            titlesManager.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            titlesManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            titlesManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            titlesManager.Position = titlesManager.Count - 1;
        }
    }
}
