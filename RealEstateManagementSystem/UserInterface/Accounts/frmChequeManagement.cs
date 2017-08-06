using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;
using RealEstateManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateManagementSystem.UserInterface.Accounts
{
    public partial class frmChequeManagement : Form
    {
        bllPayment b = new bllPayment();
        public frmChequeManagement()
        {
            InitializeComponent();
        }

        private void rbInvoice_CheckedChanged(object sender, EventArgs e)
        {
            pnlInvoice.Visible = rbInvoice.Checked;
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            pnlClientId.Visible = rbClient.Checked;
        }

        private void rbBank_CheckedChanged(object sender, EventArgs e)
        {
            pnlBank.Visible = rbBank.Checked;
        }

        private void rbDateRange_CheckedChanged(object sender, EventArgs e)
        {
            pnlDateRange.Visible = rbDateRange.Checked;
        }

        private void txtInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

            }
        }

        private void cmbBank_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                clsCommonFunctions.SearchClient(txtClientId);
            }
            catch (Exception ex) { ex.ProcessException(); tssStatus.Text = Resources.strReadyStatus; }
        }

        private void frmChequeManagement_Load(object sender, EventArgs e)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT BankId, BankName From defBank ORDER BY BankName", "BankName", "BankId", false, cmbBank);
        }


        private void PopulateSearchResult(clsGlobalClass.ChequeSearchBy searchBy)
        {
            DataTable dt = new DataTable();
            int clientId = rbClient.Checked == true ? string.IsNullOrEmpty(txtClientId.Text) ? 0 : clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId.Text) : 0;
            int bankId = rbBank.Checked == true ? cmbBank.SelectedValue.ToString().ConvertToInt32() : 0;
            DateTime startDate = rbDateRange.Checked == true ? dtpStartDate.Value : DateTime.Now;
            DateTime endDate = rbDateRange.Checked == true ? dtpEndDate.Value : DateTime.Now;
            dt = b.SearchClientCheckInformation(searchBy, Convert.ToInt32(txtInvoice), clientId, bankId, startDate, endDate, chkExcludeReceived.Checked, chkExcludeCashTransactions.Checked);

        }

    }
}
