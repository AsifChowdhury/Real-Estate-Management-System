using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Utilities;
using static RealEstateManagementSystem.Utilities.clsCommonFunctions;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using RealEstateManagementSystem.Properties;
using RealEstateManagementSystem.Reports;

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
            try { if (e.KeyChar == Convert.ToChar(Keys.Enter)) { LoadSearchListBox(); } }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void cmbBank_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try { LoadSearchListBox(); }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void frmChequeManagement_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now.AddMonths(-6);
            LoadDropDownBoxes();
        }

        private void LoadDropDownBoxes()
        {
            PopulateComboboxWithDisplayAndValueMember("SELECT BankId, BankName From defBank ORDER BY BankName", "BankName", "BankId", false, cmbBank);
            PopulateComboboxWithDisplayAndValueMember("SELECT PaymentStatusId, StatusName FROM defPaymentStatus WHERE ShowInList = 1 ORDER BY StatusName", "StatusName", "PaymentStatusId", true, cmbInvoiceStatus);
            PopulateComboboxWithDisplayAndValueMember("SELECT ReasonId, ReasonDesc FROM defCancelreason ORDER BY ReasonDesc", "ReasonDesc", "ReasonId", false, cmbAlterReason);
            PopulateComboboxWithDisplayAndValueMember("SELECT AccountID, Account FROM CompanyAccountList ORDER BY BankName, AccountNumber", "Account", "AccountId", true, cmbCompanyAccounts);

        }


        private DataTable SearchResult()
        {
            clsGlobalClass.ChequeSearchBy searchBy;
            if (rbClient.Checked == true) { searchBy = clsGlobalClass.ChequeSearchBy.ClientId; }
            else if (rbBank.Checked == true) { searchBy = clsGlobalClass.ChequeSearchBy.Bank; }
            else if (rbInvoice.Checked == true) { searchBy = clsGlobalClass.ChequeSearchBy.Invoice; }
            else if (rbDateRange.Checked == true) { searchBy = clsGlobalClass.ChequeSearchBy.DateRange; }
            else { searchBy = clsGlobalClass.ChequeSearchBy.Invoice; }

            
            DataTable dt = new DataTable();
            int invoiceNumber = rbInvoice.Checked == true ? Convert.ToInt32(txtInvoice.Text) : 0;
            int clientId = rbClient.Checked == true ? string.IsNullOrEmpty(txtClientId.Text) ? 0 : clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId.Text) : 0;
            int bankId = rbBank.Checked == true ? cmbBank.SelectedValue.ToString().ConvertToInt32() : 0;
            DateTime startDate = rbDateRange.Checked == true ? dtpStartDate.Value : DateTime.Now;
            DateTime endDate = rbDateRange.Checked == true ? dtpEndDate.Value : DateTime.Now;
            dt = b.SearchChequeInformation(searchBy, invoiceNumber, clientId, bankId, startDate, endDate, chkExcludeReceived.Checked, chkExcludeCashTransactions.Checked);
            return dt;
        }


        private void LoadSearchListBox()
        {
            LoadDropDownBoxes();
            lvResultSet.Items.Clear();
            DataTable dt = SearchResult();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow drItems in dt.Rows)
                {
                    ListViewItem lvItems = new ListViewItem(Convert.ToString(drItems["Status"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["PaymentMode"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["Reason"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["Cleared"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["InvoiceNumber"]));
                    lvItems.SubItems.Add(Convert.ToDecimal(drItems["Amount"]).FormatAsMoney());
                    lvItems.SubItems.Add(Convert.ToString(drItems["TransactionDate"]).ShowAsStandardDateFormat());
                    lvItems.SubItems.Add(Convert.ToString(drItems["Particulars"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["CQDate"]).ShowAsStandardDateFormat());
                    lvItems.SubItems.Add(Convert.ToString(drItems["BankInfo"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["Remarks"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["DepositedTo"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["DepositedOn"]).ShowAsStandardDateFormat());
                    lvItems.BackColor = Convert.ToString(drItems["Cleared"]) == "Y" ? Color.LightGray : Color.White;
                    lvResultSet.Items.Add(lvItems);
                }
            }
            lblRecordCount.Text = $"{dt.Rows.Count.ToString()} Record(s) Found.";
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            try
            {
                clsCommonFunctions.SearchClient(txtClientId);
                LoadSearchListBox();
            }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void btnSearch_DateRange_Click(object sender, EventArgs e)
        {
            try { LoadSearchListBox(); }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void txtClientId_Leave(object sender, EventArgs e)
        {
            try
            {
                //clsCommonFunctions.SearchClient(txtClientId);
                txtClientId.Text = clsCommonFunctions.GetFullClientId(txtClientId.Text);
                LoadSearchListBox();
            }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void lvResultSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvResultSet.Items.Count > 0 && lvResultSet.SelectedItems.Count > 0)
                {
                    bllPayment info = new bllPayment();
                    int invoiceNumber = lvResultSet.SelectedItems[0].SubItems[4].Text.ConvertToInt32();
                    Payment p = info.GetChequeInformation(invoiceNumber);

                    txtInvoiceNumber.Text = Convert.ToString(p.TransactionId);
                    cmbAlterReason.Text = Convert.ToString(p.AlterReason);
                    cmbInvoiceStatus.Text = Convert.ToString(p.PaymentStatus);
                    dtpStatusDate.Value = Convert.ToDateTime(p.PaymentStatusChangeDate);
                    cmbCompanyAccounts.Text = Convert.ToString(p.CompnanyBankAccount);
                }
            }
            catch (Exception ex) { ex.ProcessException(tssStatus); }

        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"Are you sure about changing the status of Invoice # {txtInvoiceNumber.Text} to {cmbInvoiceStatus.Text}?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) { throw new ApplicationException(Resources.strCancelledByUser); }

                Payment p = new Payment();
                p.TransactionId = txtInvoiceNumber.Text.ConvertToInt32();
                p.PaymentStatusId = cmbInvoiceStatus.SelectedValue;
                p.AlterReasonId = cmbAlterReason.SelectedValue;
                p.PaymentStatusChangeDate = dtpStatusDate.Value;
                p.CompnanyBankAccountId = cmbCompanyAccounts.SelectedValue;

                bllPayment pmt = new bllPayment();
                pmt.UpdateChequeStatus(p);
                MessageBox.Show($"Cheque information (Invoice# {p.TransactionId}) updated successfully", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSearchListBox();
            }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void btnRealodSearch_Click(object sender, EventArgs e)
        {
            LoadSearchListBox();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            try
            {
                clsReports.ChequeInformationReport(SearchResult(), tssStatus);
            }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }
    }
}
