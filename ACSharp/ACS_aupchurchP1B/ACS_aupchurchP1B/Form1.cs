using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACS_aupchurchP1B
{
    public partial class frmTitle : Form
    {
        public frmTitle()
        {
            InitializeComponent();
        }

        private void titlesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.titlesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.itse2353pbeDataSet);

        }

        private void frmTitle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itse2353pbeDataSet.Titles' table. You can move, or remove it, as needed.
            this.titlesTableAdapter.Fill(this.itse2353pbeDataSet.Titles);

        }
    }
}
