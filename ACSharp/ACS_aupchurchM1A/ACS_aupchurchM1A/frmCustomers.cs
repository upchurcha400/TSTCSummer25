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
using System.Data.Common;



namespace ACS_aupchurchM1A
{
    public partial class frmCustomers : Form
    {
        CurrencyManager customerManager;
        public frmCustomers()
        {
            InitializeComponent();
        }


        private void frmCustomers_Load(object sender, EventArgs e)
        {
            DBConnect.TbxCustomerID = tbxCustomerID;
            DBConnect.TbxCompanyName = tbxCompanyName;
            DBConnect.TbxContactName = tbxContactName;
            DBConnect.TbxContactTitle = tbxContactTitle;
            DBConnect.OpenCreateData();
            customerManager = ((CurrencyManager)BindingContext[DBConnect.DTCustomersTable]);
            DBConnect.CloseDisposeData();

        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            customerManager.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            customerManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            customerManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            customerManager.Position = customerManager.Count-1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

    }
}
