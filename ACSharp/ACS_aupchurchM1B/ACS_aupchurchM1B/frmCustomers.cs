﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACS_aupchurchM1B
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.itse2353pbeDataSet);

        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itse2353pbeDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.itse2353pbeDataSet.Customers);

        }
    }
}
