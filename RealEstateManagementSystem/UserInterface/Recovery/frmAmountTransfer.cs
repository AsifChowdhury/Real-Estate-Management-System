using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;
using RealEstateManagementSystem.Reports;
using RealEstateManagementSystem.Utilities;
using System;
using System.Windows.Forms;
namespace RealEstateManagementSystem.UserInterface.Recovery
{
    public partial class frmAmountTransfer : Form
    {
        private static decimal refundInstallmentAmount = 0;
        private static decimal transferInstallmentAmount = 0;
        private enum DataContainer
        {
            From,
            To,
            All
        }
        public frmAmountTransfer()
        {
            InitializeComponent();
        }

        private void ClearForm(DataContainer container)
        {
            switch (container)
            {
                case DataContainer.From:
                    clsCommonFunctions.ResetTextBoxes(gbFrom, "", txtClientId_From);
                    clsCommonFunctions.ResetComboBox(gbFrom);
                    clsCommonFunctions.ResetDTPicker(gbFrom);
                    break;
                case DataContainer.To:
                    clsCommonFunctions.ResetTextBoxes(gbTo, "", txtClientId_To);
                    clsCommonFunctions.ResetComboBox(gbTo);
                    clsCommonFunctions.ResetDTPicker(gbTo);
                    break;
                case DataContainer.All:
                    clsCommonFunctions.ResetTextBoxes(this, "", txtClientId_From, txtClientId_To);
                    clsCommonFunctions.ResetComboBox(this);
                    clsCommonFunctions.ResetDTPicker(this);
                    break;
                default:
                    break;
            }
        }


        private void btnSearch_From_Click(object sender, EventArgs e)
        {
            try
            {
                clsCommonFunctions.SearchClient(txtClientId_From);
                if (!string.IsNullOrEmpty(txtClientDetails_From.Text))
                {
                    PopulateClientRecord(txtClientId_From.Text.ToString(), DataContainer.From);
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void PopulateClientRecord(string clientId, DataContainer container)
        {

            bllCommonProperties_Recovery b = new bllCommonProperties_Recovery();
            CommonProperties_Recovery cpr = new CommonProperties_Recovery();
            cpr.ClientId = clsCommonFunctions.GetNumericPartOfFullClientId(clientId);
            b.GetPaymentSummaryOfClient(cpr);
            switch (container)
            {
                case DataContainer.From:
                    refundInstallmentAmount = 0;
                    clsCommonFunctions.ResetTextBoxes(gbFrom, "", txtClientId_From);
                    clsCommonFunctions.ResetComboBox(cmbOtherExpensesType_From);
                    txtClientDetails_From.Text = $"{cpr.ClientName.ToString()}{Environment.NewLine}Unit#: {cpr.Allocation}{Environment.NewLine}Sold by: {cpr.SoldBy}";
                    txtInstallment_From.Text = cpr.Paid_Installment.FormatAsMoney(true);
                    refundInstallmentAmount = cpr.Paid_Installment;
                    txtOtherExpenses_From.Text = cpr.Paid_OtherExpenses.FormatAsMoney(true);
                    txtAdjustableAmount_From.Text = cpr.Paid_AdjustableAmount.FormatAsMoney(true);
                    txtRefundTransfer_From.Text = cpr.Refund_GrandTotal.FormatAsMoney(true);
                    txtGrandTotal_From.Text = cpr.Paid_GrandTotal.FormatAsMoney(true);
                    clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember($"EXEC sp_GetDistinctPaidOtherExpensesTypesOfClient {cpr.ClientId}", "InstallmentName", "InstallmentId", true, cmbOtherExpensesType_From);
                    clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember($"EXEC sp_GetDistinctPaidOtherExpensesTypesOfClient {cpr.ClientId}, 1", "InstallmentName", "InstallmentId", true, cmbRefundFrom, cmbTransferFrom);
                    //cmbRefundFrom.Text = "Installment";
                    break;
                case DataContainer.To:
                    clsCommonFunctions.ResetTextBoxes(gbTo, "", txtClientId_To);
                    clsCommonFunctions.ResetComboBox(cmbOtherExpensesType_To);
                    txtClientDetails_To.Text = $"{cpr.ClientName.ToString()}{Environment.NewLine}Unit#: {cpr.Allocation}{Environment.NewLine}Sold by: {cpr.SoldBy}";
                    txtInstallment_To.Text = cpr.Paid_Installment.FormatAsMoney(true);
                    txtOtherExpenses_To.Text = cpr.Paid_OtherExpenses.FormatAsMoney(true);
                    txtAdjustableAmount_To.Text = cpr.Paid_AdjustableAmount.FormatAsMoney(true);
                    txtRefundTransfer_To.Text = cpr.Refund_GrandTotal.FormatAsMoney(true);
                    txtGrandTotal_To.Text = cpr.Paid_GrandTotal.FormatAsMoney(true);
                    clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember($"EXEC sp_GetDistinctPaidOtherExpensesTypesOfClient {cpr.ClientId}", "InstallmentName", "InstallmentId", true, cmbOtherExpensesType_To);
                    break;
                default:
                    break;
            }

        }

        private void frmAmountTransfer_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT PaymentModeId, PaymentMode FROM defPaymentMode ORDER BY PaymentModeId", "PaymentMode", "PaymentModeId", false, cmbRefundPaymentMode);
            clsCommonFunctions.PopulateCompanyBankAccountList(cmbCompanyBankAccount);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(System.Data.CommandType.StoredProcedure, "SP_PopulateAmountTransferToInstallmentListCombo", "InstallmentName", "InstallmentId", cmbTransferTo, true);
        }



        private void btnSearchClient_To_Click(object sender, EventArgs e)
        {
            try
            {
                clsCommonFunctions.SearchClient(txtClientId_To);
                if (!string.IsNullOrEmpty(txtClientId_To.Text)) PopulateClientRecord(txtClientId_To.Text.ToString(), DataContainer.To);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void txtClientId_From_Leave(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(txtClientId_From.Text) && txtClientId_From.Text.ToString().IsInteger()) || (clsCommonFunctions.CheckIfValidClientId(txtClientId_From.Text) == true))
                {
                    txtClientId_From.Text = clsCommonFunctions.GetFullClientId(txtClientId_From.Text);
                    PopulateClientRecord(txtClientId_From.Text, DataContainer.From);
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtClientId_From.Text))
                    {
                        txtClientId_From.Focus();
                        txtClientId_From.SelectAll();
                        ClearForm(DataContainer.From);
                        throw new ApplicationException("Invalid Client ID. Please check again.");
                    }
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void txtClientId_To_Leave(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(txtClientId_To.Text) && txtClientId_To.Text.ToString().IsInteger()) || (clsCommonFunctions.CheckIfValidClientId(txtClientId_To.Text) == true))
                {
                    txtClientId_To.Text = clsCommonFunctions.GetFullClientId(txtClientId_To.Text);
                    PopulateClientRecord(txtClientId_To.Text, DataContainer.To);
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtClientId_To.Text))
                    {
                        txtClientId_To.Focus();
                        txtClientId_To.SelectAll();
                        ClearForm(DataContainer.To);
                        throw new ApplicationException("Invalid Client ID. Please check again.");
                    }
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void cmbOtherExpensesType_From_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try { LoadOtherExpensesAmount(clientId: txtClientId_From.Text, installmentId: cmbOtherExpensesType_From.SelectedValue.ToString().ConvertToInt32(), populateTo: txtOtherExpensesAmount_From); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void LoadOtherExpensesAmount(string clientId, int installmentId, TextBox populateTo)
        {
            bllPayment otherExpenses = new bllPayment();
            populateTo.Text = otherExpenses.AmountPaid(clsCommonFunctions.GetNumericPartOfFullClientId(clientId), installmentId).FormatAsMoney();
        }

        private void cmbOtherExpensesType_To_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try { LoadOtherExpensesAmount(clientId: txtClientId_To.Text, installmentId: cmbOtherExpensesType_To.SelectedValue.ToString().ConvertToInt32(), populateTo: txtOtherExpensesAmount_To); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void cmbRefundFrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbRefundFrom.Text == "Installment")
            {
                bllPayment p = new bllPayment();
                txtRefundAmount.Text = Convert.ToDecimal(p.AmountPaidByInstallmentType(clientId: clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId_From.Text), installTypeId: 1)).FormatAsMoney();
            }
            else
            {
                LoadOtherExpensesAmount(clientId: txtClientId_From.Text, installmentId: cmbRefundFrom.SelectedValue.ToString().ConvertToInt32(), populateTo: txtRefundAmount);
            }
            txtRefundRemarks.Text = $"Refund From {cmbRefundFrom.Text}";
        }


        private void cmbRefundPaymentMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bllPayment p = new bllPayment();
            //gbRefundBankInfo.Enabled = p.IsBankInfoNeeded(cmbRefundPaymentMode.SelectedValue.ToString().ConvertToInt32());
            //txtRefundParticulars.

            PaymentModeInfo pMode = new PaymentModeInfo();
            pMode.PaymentModeId = cmbRefundPaymentMode.SelectedValue.ToString().ConvertToInt32();
            p.GetPaymentModeDetails(pMode);
            txtRefundParticulars.Text = pMode.PaymentModeInitial;
            gbRefundBankInfo.Enabled = pMode.IsBankInfoNeeded;
        }

        private void cmbTransferFrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbTransferFrom.Text == "Installment")
            {
                bllPayment p = new bllPayment();
                txtTransferAmount.Text = Convert.ToDecimal(p.AmountPaidByInstallmentType(clientId: clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId_From.Text), installTypeId: 1)).FormatAsMoney();
            }
            else { LoadOtherExpensesAmount(clientId: txtClientId_From.Text, installmentId: cmbTransferFrom.SelectedValue.ToString().ConvertToInt32(), populateTo: txtTransferAmount); }
        }

        private void cmbTransferTo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int clientIdFrom = clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId_From.Text);
            int clientIdTo = clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId_To.Text);


            bllClientInfo c = new bllClientInfo();

            txtTransferRemarks_From.Text = $"Transfer To {c.GetUnitSummaryOfClient(clientIdTo, true, false)} ({cmbTransferFrom.Text} as ({cmbTransferTo.Text}))";
            txtTransferRemarks_To.Text = $"Transfer from {c.GetUnitSummaryOfClient(clientIdFrom, true, false)} ({cmbTransferFrom.Text} as ({cmbTransferTo.Text}))";
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (clsCommonFunctions.CheckIfValidClientId(txtClientId_From.Text) == false)
                {
                    txtClientId_From.Focus();
                    throw new ApplicationException("Invalid Client Id.");
                }
                if (clsCommonFunctions.CheckIfValidClientId(txtClientId_To.Text) == false)
                {
                    txtClientId_To.Focus();
                    throw new ApplicationException("Invalid Client Id.");
                }
                if (MessageBox.Show($"Are you sure you want to transfer {txtTransferAmount.Text.ConvertToDecimal().FormatAsMoney(true)} from {txtClientId_From.Text} ({cmbTransferFrom.Text}) to {txtClientId_To.Text} as {cmbTransferTo.Text}?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    throw new ApplicationException(Resources.strCancelledByUser);
                }
                bllPayment transfer = new bllPayment();
                string transactionIds = transfer.CommitTransferTransaction(
                    clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId_From.Text)
                    , clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId_To.Text)
                    , cmbTransferFrom.Text
                    , cmbTransferTo.Text
                    , txtTransferRemarks_From.Text
                    , txtTransferRemarks_To.Text
                    , txtTransferAmount.Text.ToString().ConvertToDecimal()
                    , dtpTransferDate.Value
                    );
                int transactionId_From = transactionIds.Before(",").ConvertToInt32();
                int transactionId_To = transactionIds.After(",").ConvertToInt32();
                if (MessageBox.Show($"Transfer of {txtTransferAmount.Text.ConvertToDecimal().FormatAsMoney(true)} from {txtClientId_From.Text} ({cmbTransferFrom.Text}) to {txtClientId_To.Text} ({cmbTransferTo.Text}) Completed Successfully.\n(Optional) Do you want to print Acknowledgement Letter and Money Receipt Now?", Resources.strSuccessCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clsReports.AcknowledgementReceipt(transactionId_From, tssStatus);
                    clsReports.MoneyReceipt(transactionId_To, false, tssStatus);
                }
                else
                {
                    MessageBox.Show("You can print those receipts anytime from Payment module.", Resources.strNoProblem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnRefundAndPrintAckLetter_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Are you sure about refund {txtRefundAmount.Text.ConvertToDecimal().FormatAsMoney(true)} from {cmbRefundFrom.Text} of ClientId: {txtClientId_From.Text}?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    throw new ApplicationException(Resources.strCancelledByUser);
                }

                if (clsCommonFunctions.CheckIfValidClientId(txtClientId_From.Text) == false)
                {
                    txtClientId_From.Focus();
                    throw new ApplicationException("Invalid Client Id.");
                }
                Payment p = new Payment();
                bllPayment refund = new bllPayment();
                p.CommonProperties = new CommonProperties_Recovery { ClientId = clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId_From.Text) };
                p.TransactionAmount = txtRefundAmount.Text.ConvertToDecimal();
                p.TransactionDate = dtpRefundDate.Value;
                p.ParticularDate = dtpRefundChequeDate.Value;
                p.PaymentMode = new PaymentModeInfo { PaymentModeId = cmbRefundPaymentMode.SelectedValue.ToString().ConvertToInt32() };
                p.RefundFrom = cmbRefundFrom.Text;
                p.CompanyBankAccount = new CompanyBankAccount { CompanyBankAccountId = cmbCompanyBankAccount.SelectedValue.ToString().ConvertToInt32() };
                p.Remarks = txtRefundRemarks.Text;
                p.Particulars = txtRefundParticulars.Text;
                int transactionId = refund.CommitRefundTransaction(p);
                if (MessageBox.Show($"Refund of {txtRefundAmount.Text.ConvertToDecimal().FormatAsMoney(true)} processed successfully. \n(Optional) Do you want to print the Acknowledgement Receipt now?", Resources.strSuccessCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clsReports.AcknowledgementReceipt(transactionId, tssStatus);
                }
                else
                {
                    MessageBox.Show("You can print Acknowledgement Letter anytime from Payment module.", Resources.strNoProblem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void amount_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text)) { ((TextBox)sender).Text = ((TextBox)sender).Text.ConvertToDecimal().FormatAsMoney(); }
            else { ((TextBox)sender).Text = "0"; }
        }


        private void AllowNumberOnly(object sender, KeyPressEventArgs e)
        {
            clsCommonFunctions.NumericTextBox(sender, e);
        }
    }
}
