using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDPNB.Forms.Transactions
{
    public partial class FrmAllTransactions : Form
    {
        Data.DataClassesDataContext data = new Data.DataClassesDataContext();
        List<Data.Transaction> transactions = new List<Data.Transaction>();
        public FrmAllTransactions()
        {
            InitializeComponent();
        }

        private void FrmAllTransactions_Load(object sender, EventArgs e)
        {
            transactions = data.Transactions.ToList();
            this.dgvTxns.DataSource = transactions;
            this.cmbBoxSearchBy.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (this.cmbBoxSearchBy.SelectedIndex == 0)
                this.dgvTxns.DataSource = transactions.Where(elem => elem.Id.ToString().ToLower().Contains(this.tBoxSearch.Text.ToLower().Trim())).ToList();
        }
    }
}
