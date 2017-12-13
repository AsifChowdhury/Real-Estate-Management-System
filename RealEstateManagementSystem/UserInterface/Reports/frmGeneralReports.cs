using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;
using RealEstateManagementSystem.Reports;
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

namespace RealEstateManagementSystem.UserInterface.Reports
{
    public partial class frmGeneralReports : Form
    {
        int projectId = 0;
        public frmGeneralReports()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void txtClientId_Leave(object sender, EventArgs e)
        {
            txtClientId.Text = clsCommonFunctions.GetFullClientId(txtClientId.Text);
            LoadPaymentSummary(txtClientId.Text);
        }

        private void frmGeneralReports_Load(object sender, EventArgs e)
        {
            clsCommonFunctions.PopulateListOfProjects(cmbProjectName, clsGlobalClass.ProjectStatus.All, true);
            lblPayable_TillDate.Text = lblDue_TillDate.Text = "Till\n" + DateTime.Now.ToString().ShowAsStandardDateFormat();
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

        private void PopulateSearchResult()
        {
            int cancelledCount = 0, activeCount = 0, registeredCount = 0;
            bllGlobal b = new bllGlobal();
            lstClients.Items.Clear();
            b.ProjectId = projectId;
            b.ClientName = Convert.ToString(txtClientName.Text);
            b.UnitNumber = Convert.ToString(txtUnitNumber.Text);
            foreach (DataRow drItems in b.GetListOfClients(true).Rows)
            {
                ListViewItem lvItem = new ListViewItem(Convert.ToString(drItems["ClientId"]));
                lvItem.SubItems.Add(Convert.ToString(drItems["UnitNumber"]));
                lvItem.SubItems.Add(Convert.ToString(drItems["Name"]));
                lvItem.ForeColor = Convert.ToString(drItems["IsCancelled"]).ConvertToBoolean() == false ? Convert.ToString(drItems["isRegistered"]).ConvertToBoolean() == true ? Color.Blue : Color.Black : Color.Red;
                if (Convert.ToString(drItems["IsCancelled"]).ConvertToBoolean() == true) cancelledCount++;
                if (Convert.ToString(drItems["isRegistered"]).ConvertToBoolean() == true) registeredCount++;
                lstClients.Items.Add(lvItem);
            }
            rbAllClients.Checked = rbActiveClients.Checked = rbRegisteredClients.Checked = rbCancelledClients.Checked = false;
            rbAllClients.Text = lstClients.Items.Count.ToString() + " Client(s) Found";
            activeCount = (lstClients.Items.Count - cancelledCount);
            rbActiveClients.Text = "Active: " + activeCount.ToString();
            rbRegisteredClients.Text = "Registered: " + registeredCount.ToString();
            rbUnRegisteredClients.Text = "Un-Registerd: " + (activeCount - registeredCount).ToString();
            rbCancelledClients.Text = "Cancelled: " + cancelledCount.ToString();
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
            if (lstClients.Items.Count < 1 || lstClients.SelectedItems.Count < 1) return;
            txtClientId.Text = lstClients.SelectedItems[0].Text;
            LoadPaymentSummary(txtClientId.Text);
        }

        private void LoadPaymentSummary(string clientId)
        {

            ResetPaymentSummaryPanel();
            if (string.IsNullOrEmpty(clientId)) { return; }

            decimal gt_PayableTillDate, gt_PayableTotal, gt_Paid, gt_DueTillDate, gt_DueTotal;
            gt_PayableTillDate = gt_PayableTotal = gt_Paid = gt_DueTillDate = gt_DueTotal = 0;
            int intClientId = clsCommonFunctions.GetNumericPartOfFullClientId(clientId);
            bllPayment summary = new bllPayment();
            DataTable dt = new DataTable();
            dt = summary.GetPaymentSummaryOfClient_ByInstallment(clientId);
            foreach (DataRow dr in dt.Rows)
            {
                decimal payable_TillDate = Convert.ToDecimal(dr["Payable_TillDate"]);
                decimal payable_Total = Convert.ToDecimal(dr["Payable_Total"]);
                decimal paid_Total = Convert.ToDecimal(dr["Paid_Total"]);
                decimal due_TillDate = Convert.ToDecimal(dr["Due_TillDate"]);
                decimal due_Total = Convert.ToDecimal(dr["Due_Total"]);

                switch (dr["InstallTypeId"].ToString())
                {
                    case "1":
                        lblPayable_TillDate_RegularPayment.Text = payable_TillDate.FormatAsMoney(true, true, true);
                        gt_PayableTillDate = gt_PayableTillDate + payable_TillDate;
                        lblPayable_Total_RegularPayment.Text = payable_Total.FormatAsMoney(true, true, true);
                        gt_PayableTotal = gt_PayableTotal + payable_Total;
                        lblPaid_RegularPayment.Text = paid_Total.FormatAsMoney(true, true, true);
                        gt_Paid = gt_Paid + paid_Total;
                        lblDue_TillDate_RegularPayment.Text = due_TillDate.FormatAsMoney(true, true, true);
                        gt_DueTillDate = gt_DueTillDate + due_TillDate;
                        lblDue_Total_RegularPayment.Text = due_Total.FormatAsMoney(true, true, true);
                        gt_DueTotal = gt_DueTotal + due_Total;
                        pbKeyList.Visible = Convert.ToString(dr["KeyList"]).ConvertToBoolean();
                        pbHandover.Visible = Convert.ToString(dr["HandOver"]).ConvertToBoolean();
                        pnlPaymentSummary.BackColor = Convert.ToString(dr["ClientStatus"]).ConvertToBoolean() == true ? Color.FromArgb(0, 0, 64) : Color.Black;
                        lblLoanChequeInfo.Text = Convert.ToString(dr["LoanCheque"]);
                        break;
                    case "2":
                        lblPayable_TillDate_OtherExpenses.Text = payable_TillDate.FormatAsMoney(true, true, true);
                        gt_PayableTillDate = gt_PayableTillDate + payable_TillDate;
                        lblPayable_Total_OtherExpenses.Text = payable_Total.FormatAsMoney(true, true, true);
                        gt_PayableTotal = gt_PayableTotal + payable_Total;
                        lblPaid_OtherExpenses.Text = paid_Total.FormatAsMoney(true, true, true);
                        gt_Paid = gt_Paid + paid_Total;
                        lblDue_TillDate_OtherExpenses.Text = due_TillDate.FormatAsMoney(true, true, true);
                        gt_DueTillDate = gt_DueTillDate + due_TillDate;
                        lblDue_Total_OtherExpenses.Text = due_Total.FormatAsMoney(true, true, true);
                        gt_DueTotal = gt_DueTotal + due_Total;
                        break;
                    case "5":
                        lblPayable_TillDate_AdjustableAmount.Text = payable_TillDate.FormatAsMoney(true, true, true);
                        gt_PayableTillDate = gt_PayableTillDate + payable_TillDate;
                        lblPayable_Total_AdjustableAmount.Text = payable_Total.FormatAsMoney(true, true, true);
                        gt_PayableTotal = gt_PayableTotal + payable_Total;
                        lblPaid_AdjustableAmount.Text = paid_Total.FormatAsMoney(true, true, true);
                        gt_Paid = gt_Paid + paid_Total;
                        lblDue_TillDate_AdjustableAmount.Text = due_TillDate.FormatAsMoney(true, true, true);
                        gt_DueTillDate = gt_DueTillDate + due_TillDate;
                        lblDue_Total_AdjustableAmount.Text = due_Total.FormatAsMoney(true, true, true);
                        gt_DueTotal = gt_DueTotal + due_Total;
                        break;
                    default:
                        break;
                }
            }
            lblPayable_TillDate_GrandTotal.Text = gt_PayableTillDate.FormatAsMoney(true, true, true);
            lblPayable_Total_GrandTotal.Text = gt_PayableTotal.FormatAsMoney(true, true, true);
            lblPaid_GrandTotal.Text = gt_Paid.FormatAsMoney(true, true, true);
            lblDue_TillDate_GrandTotal.Text = gt_DueTillDate.FormatAsMoney(true, true, true);
            lblDue_Total_GrandTotal.Text = gt_DueTotal.FormatAsMoney(true, true, true);



        }

        private void ResetPaymentSummaryPanel()
        {
            lblPayable_TillDate_RegularPayment.Text =
                lblPayable_TillDate_OtherExpenses.Text =
                lblPayable_TillDate_AdjustableAmount.Text =
                lblPayable_TillDate_GrandTotal.Text =
                lblPayable_Total_RegularPayment.Text =
                lblPayable_Total_OtherExpenses.Text =
                lblPayable_Total_AdjustableAmount.Text =
                lblPayable_Total_GrandTotal.Text =
                lblPaid_RegularPayment.Text =
                lblPaid_OtherExpenses.Text =
                lblPaid_AdjustableAmount.Text =
                lblPaid_GrandTotal.Text =
                lblDue_TillDate_RegularPayment.Text =
                lblDue_TillDate_OtherExpenses.Text =
                lblDue_TillDate_AdjustableAmount.Text =
                lblDue_TillDate_GrandTotal.Text =
                lblDue_Total_RegularPayment.Text =
                lblDue_Total_OtherExpenses.Text =
                lblDue_Total_AdjustableAmount.Text =
                lblDue_Total_GrandTotal.Text = "-/=";
            pbKeyList.Visible = pbHandover.Visible = false;
            pnlPaymentSummary.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                string clientIds = lstClients.CheckBoxes == true && lstClients.CheckedItems.Count > 1 ? selectedClientIds(lstClients) : clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId.Text).ToString();
                if (string.IsNullOrEmpty(clientIds) == true || clientIds == "0") { throw new ApplicationException("At least one ClientId needed to generate report."); }
                if (rbProfile.Checked == true)
                {
                    clsReports.ClientProfile(txtClientId.Text, tssStatus);
                }
                else if (rbAllotmentLetter.Checked == true)
                {
                    clsReports.AllotmentLetter(clientIds, txtRent.Text.ToString().ConvertToDecimal(), tssStatus);
                }
                else if (rbPaymentSchedule.Checked == true)
                {
                    clsReports.PaymentSchedule(clientIds, withPaymentStatus: false, tssStatus: tssStatus);
                }
                else if (rbPaymentScheduleStatus.Checked == true)
                {
                    clsReports.PaymentSchedule(clientIds, withPaymentStatus: true, tssStatus: tssStatus);

                }
                else if (rbPSComparison.Checked == true)
                {
                    clsReports.PaymentComparison(clientId: clientIds, tssStatus: tssStatus);
                }
                else if (rbPaymentHistory.Checked == true)
                {
                    if (chkIncludeBankAccounts.Checked == true) { clsReports.PaymentHistoryOfClient_WithBankAccount(clientIds, tssStatus: tssStatus); }
                    else { clsReports.PaymentHistoryOfClient(clientIds, tssStatus); }
                }
                else if (rbLoanDisbursementHistory.Checked == true)
                {
                    clsReports.LoanDisbursementHistory(clientIds: clientIds, tssStatus: tssStatus);
                }
                else if (rbHandoverProcess.Checked == true)
                {
                    if (clsCommonFunctions.IsActiveClient(clientIds.ConvertToInt32()) == false)
                        throw new ApplicationException("Handover process cannot be activated for cancelled clients.");
                    frmHandoverProcess hp = new frmHandoverProcess
                    {
                        clientId = clientIds.ConvertToInt32()
                    };
                    hp.ShowDialog();
                }
                else if (rbRegistrationAcknowledgeReceipt.Checked == true)
                {
                    clsReports.RegistrationAcknowledgementReceipt(clientIds: clientIds, tssStatus: tssStatus);
                }
            }
            catch (Exception ex) { tssStatus.Text = Resources.strReadyStatus; ex.ProcessException(); }


        }

        private void chkIncludeBankAccounts_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIncludeBankAccounts.Checked == true) { rbPaymentHistory.Checked = true; }
        }

        private void rbPaymentHistory_CheckedChanged(object sender, EventArgs e)
        {
            lstClients.CheckBoxes = rbPaymentHistory.Checked;
            if (rbPaymentHistory.Checked == false) { chkIncludeBankAccounts.Checked = false; }
        }

        private string selectedClientIds(ListView lvControl)
        {
            StringBuilder clientIds = new StringBuilder();
            for (int i = 0; i < lstClients.Items.Count; i++)
            {
                if (lstClients.Items[i].Checked == true)
                {
                    clientIds.Append(clsCommonFunctions.GetNumericPartOfFullClientId(lstClients.Items[i].Text.ToString()).ToString() + ',');
                }
            }
            return clientIds.ToString().TrimEnd(',');
        }

        private void rbPaymentScheduleStatus_CheckedChanged(object sender, EventArgs e)
        {
            lstClients.CheckBoxes = rbPaymentScheduleStatus.Checked;
        }

        private void rbPaymentSchedule_CheckedChanged(object sender, EventArgs e)
        {
            lstClients.CheckBoxes = rbPaymentSchedule.Checked;
        }

        private void rbLoanDisbursementHistory_CheckedChanged(object sender, EventArgs e)
        {
            lstClients.CheckBoxes = rbLoanDisbursementHistory.Checked;
        }

        private void rbRegistrationAcknowledgeReceipt_CheckedChanged(object sender, EventArgs e)
        {
            lstClients.CheckBoxes = rbRegistrationAcknowledgeReceipt.Checked;
        }

        private void rbAllClients_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvItems in lstClients.Items)
            {
                lvItems.Checked = true;
            }
        }

        private void rbActiveClients_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvItem in lstClients.Items) { lvItem.Checked = lvItem.ForeColor == Color.Black || lvItem.ForeColor == Color.Blue ? true : false; }
        }

        private void rbRegisteredClients_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvItem in lstClients.Items) { lvItem.Checked = lvItem.ForeColor == Color.Blue ? true : false; }
        }

        private void rbCancelledClients_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvItem in lstClients.Items) { lvItem.Checked = lvItem.ForeColor == Color.Red ? true : false; }
        }

        private void rbUnRegisteredClients_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvItem in lstClients.Items) { lvItem.Checked = lvItem.ForeColor == Color.Black ? true : false; }
        }


        private void lstClients_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (lstClients.CheckedItems.Count > 1) { ResetPaymentSummaryPanel(); txtClientId.Text = ""; }

        }

        private void txtRent_Leave(object sender, EventArgs e)
        {
            txtRent.Text = Spell.SpellAmount.comma(txtRent.Text.ToString().ConvertToDecimal());
        }

        private void txtRent_TextChanged(object sender, EventArgs e)
        {
            rbAllotmentLetter.Checked = true;
        }

        private void rbAllotmentLetter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllotmentLetter.Checked == false) txtRent.Text = "0";
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvItems in lstClients.Items)  lvItems.Checked = false; 
        }
    }
}
