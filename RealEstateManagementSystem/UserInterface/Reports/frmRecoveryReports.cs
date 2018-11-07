using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;
using RealEstateManagementSystem.Reports;
using RealEstateManagementSystem.Utilities;
using static RealEstateManagementSystem.Utilities.clsCommonFunctions;

namespace RealEstateManagementSystem.UserInterface.Reports
{
    public partial class frmRecoveryReports : Form
    {
        public frmRecoveryReports()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frmRecoveryReports_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateListViewsFromSingleLineQuery("EXEC sp_GetProjectStatuses", lvProjectStatus, null, false);
                //clsCommonFunctions.PopulateDistinctSalesYears(cmbSalesYears);
                PopulateDistinctSalesYears(lvSalesYears);
                //PopulateInstallmentTypes(cmbInstallmentTypes);
                PopulateRefundInstallmentNames(cmbInstallments);
                dtpStartDate.Value = DateTime.Now.AddMonths(-6);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void PopulateRefundInstallmentNames(ComboBox comboBox)
        {
            PopulateComboboxWithDisplayAndValueMember(CommandType.StoredProcedure, "sp_RefundInstallmentNames", "InstallmentName", "InstallmentId", cmbInstallments);
        }

        private void _checkedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                ResetRadioButtons(this, false, (RadioButton)sender);
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbProjectValuation.Checked)
                {
                    if (lvProjects.CheckedItems.Count < 1 && lvProjectStatus.CheckedItems.Count < 1) throw new ApplicationException("Please select at least one project status/project name.");
                    if (lvProjects.CheckedItems.Count > 0) clsReports.GetProjectValuation("Project", convertToCommaSeperatedValue(lvProjects, 1), clsGlobalClass.ProjectCommonReport_FilterBy.SelectedProjects, dtpProjectValuation.Value, tssStatus);
                    else clsReports.GetProjectValuation("Summary", convertToCommaSeperatedValue(lvProjectStatus, 0), clsGlobalClass.ProjectCommonReport_FilterBy.ProjectStatus, dtpProjectValuation.Value, tssStatus);
                }
                else if (rbRefundAmountFrom.Checked)
                {
                    if (lvProjects.CheckedItems.Count < 1 && lvProjectStatus.CheckedItems.Count < 1) throw new ApplicationException("Please select at least one project status/project name.");
                    if (lvProjects.CheckedItems.Count > 0) clsReports.GetRefundAmount("Project", convertToCommaSeperatedValue(lvProjects, 1), clsGlobalClass.ProjectCommonReport_FilterBy.SelectedProjects, Convert.ToInt32(cmbInstallments.SelectedValue), null, null, tssStatus);
                    else clsReports.GetRefundAmount("Summary", convertToCommaSeperatedValue(lvProjectStatus, 0), clsGlobalClass.ProjectCommonReport_FilterBy.ProjectStatus, Convert.ToInt32(cmbInstallments.SelectedValue), null, null, tssStatus);
                }
                else if (rbRecoveryPosition.Checked)
                {
                    if (lvProjects.CheckedItems.Count < 1 && lvProjectStatus.CheckedItems.Count < 1) throw new ApplicationException("Please select at least one project status/project name.");
                    if (lvProjects.CheckedItems.Count > 0) clsReports.GetRecoveryPosition("Project", convertToCommaSeperatedValue(lvProjects, 1), clsGlobalClass.ProjectCommonReport_FilterBy.SelectedProjects, tssStatus);
                    else clsReports.GetRecoveryPosition("Summary", convertToCommaSeperatedValue(lvProjectStatus, 0), clsGlobalClass.ProjectCommonReport_FilterBy.ProjectStatus, tssStatus);
                }

                else if (rbComparePaymentStatus.Checked)
                {
                    if (lvProjects.CheckedItems.Count < 1 && lvProjectStatus.CheckedItems.Count < 1) throw new ApplicationException("Please select at least one project status/project name.");
                    if (lvProjects.CheckedItems.Count > 0) clsReports.GetComaparePaymentStatus("Project", convertToCommaSeperatedValue(lvProjects, 1), clsGlobalClass.ProjectCommonReport_FilterBy.SelectedProjects, dtpStartDate.Value, dtpEndDate.Value, tssStatus);
                    else clsReports.GetComaparePaymentStatus("Summary", convertToCommaSeperatedValue(lvProjectStatus), clsGlobalClass.ProjectCommonReport_FilterBy.ProjectStatus, dtpStartDate.Value, dtpEndDate.Value, tssStatus);
                }
                else if (rbRegistrationCompleted.Checked)
                {
                    if (lvProjects.CheckedItems.Count < 1 && lvProjectStatus.CheckedItems.Count < 1) throw new ApplicationException("Please select at least one project status/project name.");
                    if (lvProjects.CheckedItems.Count > 0) clsReports.GetRegistrationCompletionList("Project", convertToCommaSeperatedValue(lvProjects, 1), clsGlobalClass.ProjectCommonReport_FilterBy.SelectedProjects, dtpStartDate.Value, dtpEndDate.Value, tssStatus);
                    else clsReports.GetRegistrationCompletionList("Summary", convertToCommaSeperatedValue(lvProjectStatus), clsGlobalClass.ProjectCommonReport_FilterBy.ProjectStatus, dtpStartDate.Value, dtpEndDate.Value, tssStatus);
                }
                else if (rbRefundAmountBetween.Checked)
                {
                    if (lvProjects.CheckedItems.Count < 1 && lvProjectStatus.CheckedItems.Count < 1) throw new ApplicationException("Please select at least one project status/project name.");
                    if (lvProjects.CheckedItems.Count > 0) clsReports.GetRefundAmount("Project", convertToCommaSeperatedValue(lvProjects, 1), clsGlobalClass.ProjectCommonReport_FilterBy.SelectedProjects, null, dtpStartDate.Value, dtpEndDate.Value, tssStatus);
                    else clsReports.GetRefundAmount("Summary", convertToCommaSeperatedValue(lvProjectStatus, 0), clsGlobalClass.ProjectCommonReport_FilterBy.ProjectStatus, null, dtpStartDate.Value, dtpEndDate.Value, tssStatus);
                }
                else if (rbCurrentDue.Checked)
                {
                    if (lvProjects.CheckedItems.Count < 1 && lvProjectStatus.CheckedItems.Count < 1) throw new ApplicationException("Please select at least one project status/project name.");
                    if (lvProjects.CheckedItems.Count > 0) clsReports.GetListOfClientsByCurrentDue("Project", convertToCommaSeperatedValue(lvProjects, 1), clsGlobalClass.ProjectCommonReport_FilterBy.SelectedProjects, nudMinimumAmount.Value, nudMaximumAmount.Value, tssStatus);
                    else clsReports.GetListOfClientsByCurrentDue("Summary", convertToCommaSeperatedValue(lvProjectStatus, 0), clsGlobalClass.ProjectCommonReport_FilterBy.ProjectStatus, nudMinimumAmount.Value, nudMaximumAmount.Value, tssStatus);
                }
                else if (rbMonthlyRecoveryPosition.Checked)
                {
                    if (dtpMonthlyRecoveryPosition.Value.IsBeforeStartOfCurrentMonth() == false)
                        throw new ApplicationException("Monthly Recovery Position Report cannot be generated for current/future month.");

                    bool isMRPDataAvaialable =
                        bllRecoveryReports.IsMRPDataAvailable(dtpMonthlyRecoveryPosition.Value.Month, dtpMonthlyRecoveryPosition.Value.Year);

                    if (isMRPDataAvaialable == false)
                        if (MessageBox.Show(
                                $"Monthly Recovery position data for {dtpMonthlyRecoveryPosition.Value.Month.MonthName(true)}, {dtpMonthlyRecoveryPosition.Value.Year.ToString()} will be saved to database and cannot be edited later.\nDo you want continue?",
                                Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                            DialogResult.No)
                            throw new ApplicationException(Resources.strCancelledByUser);

                    clsReports.GetMonthlyRecoveryPosition(dtpMonthlyRecoveryPosition.Value.Month,
                        dtpMonthlyRecoveryPosition.Value.Year,
                        txtMRP_Target.Text.ConvertToDecimal(),
                        txtMRP_OutstandingInstallment.Text.ConvertToDecimal(),
                        txtMRP_OutstandingBDPayment.Text.ConvertToDecimal(),
                        txtMRP_Analysis.Text, isMRPDataAvaialable == false ? true : false, tssStatus);
                }
                else if (rbTransactionSummary.Checked)
                {
                    clsReports.GetTransactionSummary(dtpTransactionSummary.Value.Month, dtpTransactionSummary.Value.Year, tssStatus);
                }
                else if (rbAnnualRecoveryPosition.Checked)
                {
                    clsReports.GetAnnualRevoveryPosition(convertToCommaSeperatedValue(lvSalesYears), tssStatus);
                }
                else if (rbAnnualAgreementList.Checked)
                {

                    clsReports.GetAnnualAgreementReport(convertToCommaSeperatedValue(lvSalesYears), tssStatus);
                }
                else { throw new ApplicationException("Please select at least one report."); }
            }
            catch (Exception ex) { ex.ProcessException(); }


        }

        private void lvProjectStatus_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                PopulateProjectListByProjectStatus(lvProjectStatus, lvProjects, lblProjectCount, tssStatus);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void dtpMonthlyRecoveryPosition_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bllRecoveryReports.GetMonthlyRecoveryPosition(dtpMonthlyRecoveryPosition.Value.Month,
                    dtpMonthlyRecoveryPosition.Value.Year, txtMRP_Target.Text.ConvertToDecimal(),
                    txtMRP_OutstandingInstallment.Text.ConvertToDecimal(),
                    txtMRP_OutstandingBDPayment.Text.ConvertToDecimal(), txtMRP_Analysis.Text,
                    false);

                if (dt.Rows.Count > 0)
                {
                    txtMRP_ActualReceivable.Text = Convert.ToDecimal(dt.Rows[0]["Receivable"]).FormatAsMoney();
                    txtMRP_ActualReceived.Text = Convert.ToDecimal(dt.Rows[0]["Received"]).FormatAsMoney();
                    txtMRP_AmountRefund.Text = Convert.ToDecimal(dt.Rows[0]["Refund"]).FormatAsMoney();
                    txtMRP_Target.Text = Convert.ToDecimal(dt.Rows[0]["TargetAmount"]).FormatAsMoney();
                    txtMRP_OutstandingInstallment.Text = Convert.ToDecimal(dt.Rows[0]["OutstandingInstallment"]).FormatAsMoney();
                    txtMRP_OutstandingBDPayment.Text = Convert.ToDecimal(dt.Rows[0]["OutstandingBD"]).FormatAsMoney();
                    txtMRP_Total.Text = Convert.ToDecimal(Convert.ToDecimal(dt.Rows[0]["OutstandingInstallment"]) + Convert.ToDecimal(dt.Rows[0]["OutstandingBD"])).FormatAsMoney();
                    txtMRP_Analysis.Text = Convert.ToString(dt.Rows[0]["Remarks"]);
                }
                if (bllRecoveryReports.IsMRPDataAvailable(dtpMonthlyRecoveryPosition.Value.Month, dtpMonthlyRecoveryPosition.Value.Year))
                {
                    txtMRP_ActualReceivable.ReadOnly =
                        txtMRP_ActualReceived.ReadOnly =
                            txtMRP_AmountRefund.ReadOnly =
                                txtMRP_Target.ReadOnly =
                                    txtMRP_OutstandingInstallment.ReadOnly =
                                        txtMRP_OutstandingBDPayment.ReadOnly =
                                            txtMRP_Analysis.ReadOnly = true;
                }
                else
                {
                    txtMRP_ActualReceivable.ReadOnly =
                        txtMRP_ActualReceived.ReadOnly =
                            txtMRP_AmountRefund.ReadOnly = true;

                    txtMRP_Target.ReadOnly =
                        txtMRP_OutstandingInstallment.ReadOnly =
                            txtMRP_OutstandingBDPayment.ReadOnly =
                                txtMRP_Analysis.ReadOnly = false;
                }

            }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            clsCommonFunctions.SelectAllInTextBox((TextBox)sender, e);
        }

        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsCommonFunctions.NumericTextBox((TextBox)sender, e);
        }


        private void calculateTotalOutstanding_Leave(object sender, EventArgs e)
        {
            decimal i = 0;

            if (decimal.TryParse(((TextBox)sender).Text, out i) == true)
            {
                ((TextBox)sender).Text = ((TextBox)sender).Text.ConvertToDecimal().FormatAsMoney();
            }

            if (decimal.TryParse(txtMRP_OutstandingInstallment.Text, out i) == true && decimal.TryParse(txtMRP_OutstandingBDPayment.Text, out i) == true)
            {
                txtMRP_Total.Text = Convert.ToDecimal(Convert.ToDecimal(txtMRP_OutstandingInstallment.Text) + Convert.ToDecimal(txtMRP_OutstandingBDPayment.Text)).FormatAsMoney();
            }
        }

        private void txtMRP_Target_Leave(object sender, EventArgs e)
        {
            decimal i = 0;

            if (decimal.TryParse(((TextBox)sender).Text, out i) == true)
            {
                ((TextBox)sender).Text = ((TextBox)sender).Text.ConvertToDecimal().FormatAsMoney();
            }
        }
    }
}
