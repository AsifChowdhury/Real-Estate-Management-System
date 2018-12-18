using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;
using RealEstateManagementSystem.Reports;
using RealEstateManagementSystem.UserInterface.Projects;
using RealEstateManagementSystem.Utilities;


namespace RealEstateManagementSystem.UserInterface.Recovery
{
    public partial class frmPayment : Form
    {
        int clientId, transactionId, transactionId_returned, projectId;
        bllPayment payment = new bllPayment();
        bool isRefundTransaction;
        public frmPayment()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            clsCommonFunctions.PopulateListOfProjects(cmbProjectName, clsGlobalClass.ProjectStatus.All, true);
            clsCommonFunctions.PopulateInstallmentTypes(cmbInstallType);
            //clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT InstallTypeId, InstallType FROM defInstallType WHERE InstallTypeId IN (1,2,5) ORDER BY InstallTypeId", "InstallType", "InstallTypeId", false, cmbInstallType);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT PaymentModeId, PaymentMode FROM defPaymentMode ORDER BY PaymentModeId", "PaymentMode", "PaymentModeId", false, cmbPaymentMode);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT BankId, BankName FROM defBank ORDER BY BankName", "BankName", "BankId", false, cmbBankName);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT BranchID, BranchName FROM defBranch ORDER BY BranchName", "BranchName", "BranchId", false, cmbBranchName);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(CommandType.Text, "SELECT DISTINCT UpdateReason FROM [Transaction] WHERE UpdateReason IS NOT NULL ORDER BY UpdateReason", "UpdateReason", string.Empty, cmbUpdateReason, true);
            clsCommonFunctions.PopulateListOfDistricts(cmbDistrictName);
            clsCommonFunctions.PopulateListOfCountries(cmbCountryName);
            dtpPaymentDate.Value = dtpParticularDate.Value = SetTransactionDateTime();
            btnSave.Enabled = clsCommonFunctions.CheckButtonPermission(Name, btnSave.Name);
            btnDelete.Enabled = clsCommonFunctions.CheckButtonPermission(Name, btnDelete.Name);
        }

        private void btnDefAddNewBank_Click(object sender, EventArgs e)
        {
            frmDefinition_BankBranch def = new frmDefinition_BankBranch();
            def.tcBankBranch.SelectedIndex = 0;
            def.ShowDialog();
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT BankId, BankName FROM defBank ORDER BY BankName", "BankName", "BankId", false, cmbBankName);

        }

        private void PopulateSearchResult()
        {

            bllGlobal b = new bllGlobal();
            lstClients.Items.Clear();
            b.ProjectId = projectId;//Convert.ToString(cmbProjectName.SelectedValue).ConvertToInt32();
            b.ClientName = Convert.ToString(txtClientName.Text);
            b.UnitNumber = Convert.ToString(txtUnitNumber.Text);
            foreach (DataRow drItems in b.GetListOfClients(false).Rows)
            {
                ListViewItem lvItem = new ListViewItem(Convert.ToString(drItems["ClientId"]));
                lvItem.SubItems.Add(Convert.ToString(drItems["UnitNumber"]));
                lvItem.SubItems.Add(Convert.ToString(drItems["Name"]));
                lvItem.ForeColor = Convert.ToString(drItems["IsCancelled"]).ConvertToBoolean() == false ? Color.Black : Color.Red;
                lstClients.Items.Add(lvItem);
            }
            //lblRecordsFound.Text = lvSearchResult.Items.Count.ToString() + " Record(s) Found";
            //clsCommonFunctions.PopulateListViewFromDataTable(b.GetListOfClients(), lvSearchResult, lblRecordsFound, false);
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            PopulateSearchResult();
        }

        private void txtUnitNumber_TextChanged(object sender, EventArgs e)
        {
            PopulateSearchResult();
        }

        private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { LoadClientData(); }
            catch (Exception ex) { ex.ProcessException(); }
        }



        private void PopulateInstallmentList(int clientId, int installmentTypeId)
        {
            DataTable dt = new DataTable();
            dt = payment.InstallmentListOfClient(clientId, installmentTypeId);
            btnNewInstallment.Enabled = installmentTypeId != 1 ? true : false;
            if (dt.Rows.Count > 0)
            {
                cmbInstallment.DataSource = dt;
                cmbInstallment.DisplayMember = "InstallmentName";
                cmbInstallment.ValueMember = "InstallmentId";
            }
            else
            {
                clsCommonFunctions.ResetComboBox(cmbInstallment);

            }
        }

        private void PopulateBankAccountNumbers(int clientId)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT DISTINCT BankAccountNumber FROM [Transaction] WHERE ClientId = " + clientId, "BankAccountNumber", "BankAccountNumber", true, cmbAccountNumber);
        }

        private DateTime SetTransactionDateTime()
        {
            DateTime transactionDateTime = clsCommonFunctions.GetServerDate();
            try
            {
                DateTime serverDateTime = clsCommonFunctions.GetServerDate();
                transactionDateTime = serverDateTime;
                DateTime transactionStartTime = Convert.ToDateTime(serverDateTime.ToString("dd-MMM-yyyy") + " " + clsCommonFunctions.GetDefaultValue("TransactionStartTime"));
                DateTime transactionClosingTime = Convert.ToDateTime(serverDateTime.ToString("dd-MMM-yyyy") + " " + clsCommonFunctions.GetDefaultValue("TransactionClosingTime"));
                if (TimeSpan.Compare(serverDateTime.TimeOfDay, transactionStartTime.TimeOfDay) < 0)
                {
                    transactionDateTime = transactionStartTime;
                }
                else if (TimeSpan.Compare(serverDateTime.TimeOfDay, transactionClosingTime.TimeOfDay) > 0)
                {
                    transactionDateTime = serverDateTime.AddDays(1).ToString("dddd").ToUpper() == "FRIDAY" ? transactionStartTime.AddDays(2) : transactionDateTime = transactionStartTime.AddDays(1);
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
            return transactionDateTime;
        }


        private void LoadClientData()
        {
            if (lstClients.Items.Count < 1 || lstClients.SelectedItems.Count < 1) { ResetPaymentSummaryPanel(); return; }
            clientId = clsCommonFunctions.GetNumericPartOfFullClientId(lstClients.SelectedItems[0].Text);
            LoadClientSummary(clientId);
            LoadListOfTransaction(clientId);
            ResetTransactionInfoPanel();
        }

        private void ResetPaymentSummaryPanel()
        {
            //clsCommonFunctions.ResetComboBox(pnlTransactionInfo);
            clientId = 0;
            lstPayments.Items.Clear();
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT InstallTypeId, InstallType FROM defInstallType WHERE InstallTypeId IN (1,2,5) ORDER BY InstallTypeId", "InstallType", "InstallTypeId", false, cmbInstallType);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT PaymentModeId, PaymentMode FROM defPaymentMode ORDER BY PaymentMode", "PaymentMode", "PaymentModeId", false, cmbPaymentMode);
            cmbInstallment.DataSource = null;
            lblClientId.Text
                = lblClientName.Text
                = lblBookingDate.Text
                = lblAllocation.Text
                = lblContactNumber.Text
                = lblReferredBy.Text
                = lblSoldBy.Text
                = lblAdjustableAmount_Paid.Text
                = lblAdjustableAmount_Due.Text
                = lblAdjustableAmount_Payable.Text
                = lblInstallment_Due.Text
                = lblInstallment_Paid.Text
                = lblInstallment_Payable.Text
                = lblOtherExpenses_Due.Text
                = lblOtherExpenses_Paid.Text
                = lblOtherExpenses_Payable.Text
                = lblGrandTotal_Due.Text
                = lblGrandTotal_Paid.Text
                = lblGrandTotal_Payable.Text
                = lblNumberOfInvoices.Text
                = lblLastInvoiceNumber.Text
                = lblCurrentDue.Text
                = lblCountOfDues.Text
                = lblCountOfInstallment.Text
                = string.Empty;
        }



        private void LoadListOfTransaction(int clientId)
        {
            try
            {
                lstPayments.Items.Clear();
                DataTable dt = new DataTable();
                dt = payment.GetListOfPayments(clientId);
                foreach (DataRow drItems in dt.Rows)
                {
                    ListViewItem lvItems = new ListViewItem(Convert.ToString(drItems["StatusName"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["TransactionId"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["TransactionDate"]).ShowAsStandardDateFormat(true));
                    lvItems.SubItems.Add(Convert.ToDecimal(drItems["AmountPaid"]).FormatAsMoney(true));
                    lvItems.SubItems.Add(Convert.ToString(drItems["PaymentMode"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["Particulars"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["Remarks"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["BankInfo"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["EntryInfo"]));
                    lvItems.ForeColor = Convert.ToString(drItems["PaymentAllowed"]).ConvertToBoolean() ? Color.Black : Color.Red;
                    lstPayments.Items.Add(lvItems);
                }
                cmbReturnInvoice.DataSource = dt;
                cmbReturnInvoice.DisplayMember = "TransactionId";
                cmbReturnInvoice.ValueMember = "TransactionId";
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void LoadClientSummary(int clientId)
        {
            try
            {
                CommonProperties_Recovery cpr = new CommonProperties_Recovery();
                cpr.ClientId = clientId;

                bllCommonProperties_Recovery b = new bllCommonProperties_Recovery();

                b.GetPaymentSummaryOfClient(cpr);
                gbClientSummary.BackColor = cpr.IsActiveClient ? Color.White : Color.DarkSalmon;
                lblClientId.Text = cpr.FullClientId;
                lblClientName.Text = cpr.ClientName;
                lblBookingDate.Text = cpr.BookingDate.ToString().ShowAsStandardDateFormat();
                lblAllocation.Text = cpr.Allocation;
                lblContactNumber.Text = cpr.ContactNumber;
                lblReferredBy.Text = cpr.ReferredBy;
                lblSoldBy.Text = cpr.SoldBy;

                lblInstallment_Payable.Text = cpr.Payable_Installment.FormatAsMoney(true);
                lblInstallment_Paid.Text = cpr.Paid_Installment.FormatAsMoney(true);
                lblInstallment_Due.Text = cpr.Due_Installment.FormatAsMoney(true);

                lblOtherExpenses_Payable.Text = cpr.Payable_OtherExpenses.FormatAsMoney(true);
                lblOtherExpenses_Paid.Text = cpr.Paid_OtherExpenses.FormatAsMoney(true);
                lblOtherExpenses_Due.Text = cpr.Due_OtherExpenses.FormatAsMoney(true);

                lblAdjustableAmount_Payable.Text = cpr.Payable_AdjustableAmount.FormatAsMoney(true);
                lblAdjustableAmount_Paid.Text = cpr.Paid_AdjustableAmount.FormatAsMoney(true);
                lblAdjustableAmount_Due.Text = cpr.Due_AdjustableAmount.FormatAsMoney(true);

                lblGrandTotal_Payable.Text = cpr.Payable_GrandTotal.FormatAsMoney(true);
                lblGrandTotal_Paid.Text = cpr.Paid_GrandTotal.FormatAsMoney(true);
                lblGrandTotal_Due.Text = cpr.Due_GrandTotal.FormatAsMoney(true);

                lblNumberOfInvoices.Text = cpr.NumberOfInvoices.ToString();
                lblLastInvoiceNumber.Text = cpr.LastInvoiceNumber.ToString();
                lblCurrentDue.Text = cpr.CurrentDue.FormatAsMoney(true);
                lblCountOfDues.Text = cpr.CountOfDueInstallment.ToString();
                lblCountOfInstallment.Text = cpr.CountOfRegularInstallment.ToString();

                lblLoanChequeInfo.Text = cpr.LoanChequeInfo;
                lblRegistrationDate.Text = cpr.RegistrationDate;
                pbKeyList.Visible = cpr.IsKeyLetterProcessed;
                pbHandover.Visible = cpr.IsHandoverCertificateProcessed;

            }
            catch (Exception ex) { ex.ProcessException(); }
        }




        private void cmbPaymentMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try { GetPaymentParticularInitial(); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void GetPaymentParticularInitial()
        {
            PaymentModeInfo pMode = new PaymentModeInfo();
            pMode.PaymentModeId = cmbPaymentMode.SelectedValue.ToString().ConvertToInt32();
            payment.GetPaymentModeDetails(pMode);
            txtParticulars.Text = pMode.PaymentModeInitial;
            pnlBankInfo.Enabled = pMode.IsBankInfoNeeded;
        }

        private void lstClients_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right && lstClients.Items.Count > 0 && lstClients.SelectedItems.Count > 0)
                {
                    ContextMenu cm = new ContextMenu();
                    MenuItem sep1 = new MenuItem("-");
                    MenuItem profile = new MenuItem("Profile", profile_OnClick);
                    cm.MenuItems.Add(profile);
                    cm.MenuItems.Add(sep1);
                    MenuItem paymentHistory = new MenuItem("Payment History", paymentHistory_OnClick);
                    MenuItem sep2 = new MenuItem("-");
                    cm.MenuItems.Add(paymentHistory);
                    cm.MenuItems.Add(sep2);
                    //MenuItem paymentSchedule = new MenuItem("Payment Schedule", paymentSchedule_OnClick);
                    //MenuItem sep3 = new MenuItem("-");
                    //cm.MenuItems.Add(paymentSchedule);
                    //cm.MenuItems.Add(sep3);
                    cm.Show((Control)sender, e.Location);
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void paymentHistory_OnClick(object sender, EventArgs e)
        {
            try
            {
                clsReports.PaymentHistoryOfClient(clientId.ToString(), tssStatus);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void paymentSchedule_OnClick(object sender, EventArgs e)
        {
            clsGlobalClass.ShowUnderConstructionMessage();
        }

        private void profile_OnClick(object sender, EventArgs e)
        {
            try { clsReports.ClientProfile(lstClients.SelectedItems[0].Text, tssStatus); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void chkReturnInvoice_CheckedChanged(object sender, EventArgs e)
        {
            cmbReturnInvoice.Enabled = chkReturnInvoice.Checked;
        }

        private void cmbInstallType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try { PopulateInstallmentList(clientId, cmbInstallType.SelectedValue.ToString().ConvertToInt32()); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void txtAmountPaid_Leave(object sender, EventArgs e)
        {
            try
            {
                if (clientId == 0) { throw new ApplicationException("Please select Client Information from list."); }
                if (txtPayingAmount.Text != null && txtPayingAmount.Text.ConvertToDecimal() > payment.GetMaximumAmountPayable(clientId, cmbInstallType.SelectedValue.ToString().ConvertToInt32(), cmbInstallment.SelectedValue.ToString().ConvertToInt32()))
                {
                    string install = cmbInstallType.SelectedValue.ToString() == "1" ? cmbInstallType.Text : cmbInstallment.Text;
                    MessageBox.Show(@"Paying more than Maximum Possible Due of " + install + ".", @"Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //if (transactionId == 0)
                //{
                int lastInstallmentId = 0; string installInWord = "";
                payment.InstallmentAlgorithm(clientId, txtPayingAmount.Text.ConvertToDecimal(), cmbInstallment.SelectedValue.ToString().ConvertToInt32(), transactionId, out lastInstallmentId, out installInWord);
                if (cmbInstallType.SelectedValue.ToString().ConvertToInt32() == 1) cmbInstallment.SelectedValue = lastInstallmentId;
                txtRemarks.Text = installInWord;
                //}
                txtAmountInWords.Text = txtPayingAmount.Text.ConvertToDecimal().AmountInWords();
                txtPayingAmount.Text = txtPayingAmount.Text.ConvertToDecimal().FormatAsMoney();
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void lstPayments_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstPayments.SelectedItems.Count < 1 || lstPayments.Items.Count < 1) { return; }
                ResetTransactionInfoPanel();

                transactionId = lstPayments.SelectedItems[0].SubItems[1].Text.ConvertToInt32();
                Payment trInfo = new Payment { TransactionId = transactionId };
                payment.GetTransactionDetails(trInfo);
                cmbInstallType.Text = trInfo.InstallType.InstallTypeName;
                cmbInstallType_SelectionChangeCommitted(null, null);
                cmbInstallment.Text = trInfo.Installment.InstallmentName;
                cmbPaymentMode.Text = trInfo.PaymentMode.PaymentModeName;
                pnlBankInfo.Enabled = payment.IsBankInfoNeeded(cmbPaymentMode.SelectedValue.ToString().ConvertToInt32());
                dtpPaymentDate.Value = trInfo.TransactionDate;
                txtPayingAmount.Text = trInfo.TransactionAmount.FormatAsMoney();
                txtAmountInWords.Text = trInfo.TransactionAmount.AmountInWords();
                txtParticulars.Text = trInfo.Particulars;
                txtRemarks.Text = trInfo.Remarks;
                dtpParticularDate.Value = trInfo.ParticularDate;
                cmbAccountNumber.Text = trInfo.BankAccountNumber;
                cmbUpdateReason.Text = trInfo.UpdateReason;
                cmbBankName.Text = trInfo.BankDetails.Bank.BankName;
                cmbBranchName.Text = trInfo.BankDetails.Branch.BranchName;
                cmbDistrictName.Text = trInfo.BankDetails.District.DistrictName;
                cmbCountryName.Text = trInfo.BankDetails.Country.CountryName;
                isRefundTransaction = trInfo.IsRefundTransaction;
                btnSave.Text = "Update";

            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void ResetTransactionInfoPanel()
        {
            PopulateInstallmentList(clientId: clientId, installmentTypeId: 1);
            transactionId = 0;
            int lastInstallmentId = 0; string installInWord = "";
            payment.InstallmentAlgorithm(clientId, 0, 1, 0, out lastInstallmentId, out installInWord);
            cmbInstallment.SelectedValue = lastInstallmentId;
            PopulateBankAccountNumbers(clientId);
            btnSave.Text = "Save";
            cmbPaymentMode.Text = "Cheque";
            GetPaymentParticularInitial();

            txtPayingAmount.Text = "0";
            dtpPaymentDate.Value = dtpParticularDate.Value = SetTransactionDateTime();
            cmbBankName.SelectedIndex = cmbBranchName.SelectedIndex = 0;
            cmbDistrictName.Text = "Dhaka";
            cmbCountryName.Text = "Bangladesh";
            txtRemarks.Text = txtAmountInWords.Text = cmbUpdateReason.Text = string.Empty;
            chkReturnInvoice.Checked = false;
            pnlBankInfo.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try { CommitTransaction(); }
            catch (Exception ex) { ex.ProcessException(); }

        }

        private void CommitTransaction()
        {
            try
            {
                PaymentModeInfo pi = new PaymentModeInfo();
                pi.PaymentModeId = cmbPaymentMode.SelectedValue.ToString().ConvertToInt32();
                payment.GetPaymentModeDetails(pi);
                string strMessage = string.Empty;
                strMessage = transactionId == 0 ? "NEW TRANSACTION" : "Transaction #:" + transactionId;
                strMessage = strMessage + "\nTransaction Date: " + dtpPaymentDate.Value.ToString("ddd, dd-MMM-yyyy hh:mm:ss tt");
                strMessage = strMessage + "\nPayment Mode: " + cmbPaymentMode.Text;
                strMessage = strMessage + "\nAmount: Tk." + txtPayingAmount.Text.ConvertToDecimal().FormatAsMoney() + "/- [" + txtPayingAmount.Text.ConvertToDecimal().AmountInWords() + "]";
                strMessage = strMessage + "\nPaticulars: " + txtParticulars.Text;
                if (pi.IsBankInfoNeeded)
                {
                    strMessage = strMessage + "\n" + pi.PaymentModeName + " Date: " + dtpParticularDate.Value.ToString("ddd, dd-MMM-yyyy");
                    strMessage = strMessage + "," + cmbBankName.Text + ", " + cmbBranchName.Text + ", " + cmbDistrictName.Text + ", " + cmbCountryName.Text;
                    strMessage = strMessage + "\nAccount #: " + cmbAccountNumber.Text;
                }
                strMessage = strMessage + "\nRemarks: " + txtRemarks.Text;
                strMessage = strMessage + (transactionId == 0 ? "\n\nSure about commit Transaction?" : "\n\nSure about UPDATE the Transaction # " + transactionId + "?");
                DialogResult dr = MessageBox.Show(strMessage, Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) { throw new ApplicationException(Resources.strCancelledByUser); }
                Payment p = new Payment
                {
                    TransactionId = transactionId,
                    CommonProperties = new CommonProperties_Recovery()
                };
                p.CommonProperties.ClientId = clientId;
                p.TransactionDate = dtpPaymentDate.Value;
                p.TransactionAmount = txtPayingAmount.Text.ConvertToDecimal();
                p.ParticularDate = dtpParticularDate.Value;
                p.Particulars = txtParticulars.Text;
                p.Remarks = txtRemarks.Text;
                p.Installment = new InstallmentInfo { InstallmentId = cmbInstallment.SelectedValue.ToString().ConvertToInt32() };
                p.PaymentMode = new PaymentModeInfo { PaymentModeId = cmbPaymentMode.SelectedValue.ToString().ConvertToInt32() };
                p.BankDetails.Bank = new BankInfo { BankId = cmbBankName.SelectedValue.ToString().ConvertToInt32() };
                p.BankDetails.Branch = new BranchInfo { BranchId = cmbBranchName.SelectedValue.ToString().ConvertToInt32() };
                p.BankDetails.District = new DistrictInfo { DistrictId = cmbDistrictName.SelectedValue.ToString().ConvertToInt32() };
                p.BankDetails.Country = new CountryInfo { CountryId = cmbCountryName.SelectedValue.ToString().ConvertToInt32() };
                p.BankAccountNumber = cmbAccountNumber.Text;
                p.UpdateReason = transactionId > 0 ? cmbUpdateReason.Text : string.Empty;
                p.ReturnText = chkReturnInvoice.Checked ? cmbReturnInvoice.Text : "N/A";
                transactionId_returned = payment.CommitTransaction(p);
                LoadListOfTransaction(clientId);
                dr = MessageBox.Show("Payment Processed Successfully for Transaction # " + transactionId_returned + ".\nDo you want to Print the Money Receipt Now?", Resources.strSuccessCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes) clsReports.MoneyReceipt(transactionId_returned, false, tssStatus);
                ResetTransactionInfoPanel();
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void cmbInstallment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbInstallType.SelectedValue.ToString().ConvertToInt32() > 1)
                {
                    decimal amountPayable = payment.AmountPayable(clientId, cmbInstallment.SelectedValue.ToString().ConvertToInt32());
                    txtPayingAmount.Text = amountPayable.FormatAsMoney();
                    txtAmountInWords.Text = amountPayable.AmountInWords();
                    txtRemarks.Text = cmbInstallment.Text;
                }
                else
                {
                    txtPayingAmount.Text = "0";
                    txtRemarks.Text = txtAmountInWords.Text = string.Empty;
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnNewBranch_Click(object sender, EventArgs e)
        {
            try
            {
                frmDefinition_BankBranch def = new frmDefinition_BankBranch();
                def.tcBankBranch.SelectedIndex = 1;
                def.ShowDialog();
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT BranchId, BranchName FROM defBranch ORDER BY BranchName", "BranchName", "BranchId", false, cmbBranchName);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnNewDistrict_Click(object sender, EventArgs e)
        {
            try
            {
                frmDef_Locations loc = new frmDef_Locations();
                loc.rbDistrict.Checked = true;
                loc.ShowDialog();
                clsCommonFunctions.PopulateListOfDistricts(cmbDistrictName);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string strMessage = string.Empty;
                if (transactionId == 0) { throw new ApplicationException("Please select a transaction from list to Delete."); }
                DialogResult dr = MessageBox.Show("Are you sure about DELETING Transaction # " + transactionId + "?\nTHIS ACTION CANNOT BE REVERTED.", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) { throw new ApplicationException(Resources.strCancelledByUser); }
                payment.DeleteTransaction(transactionId);
                MessageBox.Show("Transaction # " + transactionId + " Deleted Successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadClientData();

            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void lstPayments_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right && lstPayments.Items.Count > 0 && lstPayments.SelectedItems.Count > 0)
                {
                    ContextMenu cm = new ContextMenu();
                    MenuItem sep1 = new MenuItem("-");
                    MenuItem transactionNumber = new MenuItem("Transaction # " + transactionId + ".");
                    cm.MenuItems.Add(transactionNumber);
                    cm.MenuItems.Add(sep1);

                    MenuItem sep2 = new MenuItem("-");
                    MenuItem moneyReceipt = new MenuItem("Money Receipt");
                    MenuItem moneyReceipt_Original = new MenuItem("Original", moneyReceipt_Original_OnClick);
                    MenuItem moneyReceipt_Duplicate = new MenuItem("Duplicate", moneyReceipt_Duplicate_OnClick);
                    moneyReceipt.MenuItems.Add(moneyReceipt_Original);
                    moneyReceipt.MenuItems.Add(sep2);
                    moneyReceipt.MenuItems.Add(moneyReceipt_Duplicate);

                    MenuItem ackReceipt = new MenuItem("Print Acknowledgement Recipt", ackReceipt_OnClick);
                    cm.MenuItems.Add(isRefundTransaction ? ackReceipt : moneyReceipt);
                    int numberOfEdits = payment.IsTransactionEdited(transactionId);
                    if (numberOfEdits > 0)
                    {
                        MenuItem sep3 = new MenuItem("-");
                        cm.MenuItems.Add(sep3);

                        MenuItem historyOfTransaction = new MenuItem("# of Edit(s) : " + numberOfEdits, historyOfTransaction_OnClick);
                        cm.MenuItems.Add(historyOfTransaction);
                    }
                    cm.Show((Control)sender, e.Location);
                }
            }
            catch (Exception ex) { ex.ProcessException(); }

        }

        private void moneyReceipt_Original_OnClick(object sender, EventArgs e)
        {
            try { clsReports.MoneyReceipt(transactionId, false, tssStatus); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void ackReceipt_OnClick(object sender, EventArgs e)
        {
            try { clsReports.AcknowledgementReceipt(transactionId, tssStatus); }
            catch (Exception ex) { ex.ProcessException(); }

        }

        private void historyOfTransaction_OnClick(object sender, EventArgs e)
        {
            try
            {
                frmTransactionEditHistory history = new frmTransactionEditHistory();
                history.transactionId = transactionId;
                history.ShowDialog();
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void moneyReceipt_Duplicate_OnClick(object sender, EventArgs e)
        {
            try { clsReports.MoneyReceipt(transactionId, true, tssStatus); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnNewInstallment_Click(object sender, EventArgs e)
        {
            try
            {
                string tmpInstallType = cmbInstallType.Text;
                frmAddInstallment_OA installment = new frmAddInstallment_OA();
                installment.lblClientId.Text = lblClientId.Text;
                installment.lblClientName.Text = lblClientName.Text;
                installment.lblUnitNumber.Text = lblAllocation.Text;
                installment.ShowDialog();
                LoadClientData();
                cmbInstallType.Text = tmpInstallType;
                cmbInstallType_SelectionChangeCommitted(null, null);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }



        private void cmbProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbProjectName.Text))
                {
                    ResetPaymentSummaryPanel();
                    txtClientName.Text = txtUnitNumber.Text = string.Empty;
                    projectId = clsCommonFunctions.GetProjectIdFromProjectName(cmbProjectName.Text);
                    PopulateSearchResult();
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void cmbInstallType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            try { ResetTransactionInfoPanel(); }
            catch (Exception ex) { ex.ProcessException(); }

        }
    }
}
