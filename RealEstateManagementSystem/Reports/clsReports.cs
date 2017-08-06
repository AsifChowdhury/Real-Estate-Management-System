using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;
using RealEstateManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateManagementSystem.Reports
{
    class clsReports
    {
        public static void ClientProfile(string strClientId, ToolStripStatusLabel tssStatus)
        {
            bllClientInfo b = new bllClientInfo();
            tssStatus.Text = "Generating Client Profile.....";
            int clientId = clsCommonFunctions.GetNumericPartOfFullClientId(strClientId);
            Clients.crptClientProfile crptProfile = new Reports.Clients.crptClientProfile();
            crptProfile.SetDataSource(b.GetClientProfile(clientId: clientId).Tables[0]);
            crptProfile.Subreports[1].SetDataSource(b.GetListOfPartners(clientId: clientId));
            crptProfile.Subreports[2].SetDataSource(b.GetPaymentSchedule(clientIds: clientId.ToString()).Tables[0]);
            clsCommonFunctions.ShowReport(crptProfile, tssStatus, true, true);
        }

        public static void MoneyReceipt(int transactionId, bool isDuplicate, ToolStripStatusLabel tssStatus)
        {

            bllPayment moneyReceipt = new bllPayment();
            tssStatus.Text = "Loading Money Receipt";
            Recovery.crptMoneyReceipt rptMoneyReceipt = new Recovery.crptMoneyReceipt();
            rptMoneyReceipt.SetDataSource(moneyReceipt.GetMoneyReceipt(transactionId, isDuplicate).Tables[0]);
            clsCommonFunctions.ShowReport(rptMoneyReceipt, tssStatus, false, true);
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void PaymentHistoryOfClient(string clientIds, ToolStripStatusLabel tssStatus)
        {
            bllPayment paymentHistory = new bllPayment();
            tssStatus.Text = "Loading Payment History";
            Recovery.crptPaymentHistoryOfClient rptPaymentHistory = new Recovery.crptPaymentHistoryOfClient();
            rptPaymentHistory.SetDataSource(paymentHistory.GetPaymentHistoryOfClient(clientIds).Tables[0]);
            clsCommonFunctions.ShowReport(rptPaymentHistory, tssStatus, true, true);
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void PaymentHistoryOfClient_WithBankAccount(string clientIds, ToolStripStatusLabel tssStatus)
        {
            bllPayment paymentHistory = new bllPayment();
            tssStatus.Text = Resources.strCollectingData;
            Recovery.crptPaymentHistoryOfClient_WithAccountNumber pHistory = new Recovery.crptPaymentHistoryOfClient_WithAccountNumber();
            pHistory.SetDataSource(paymentHistory.GetPaymentHistoryOfClient_WithBankAccount(clientIds).Tables[0]);
            clsCommonFunctions.ShowReport(pHistory, tssStatus, false, false);
        }

        internal static void UnitDetailsOfProject(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo bLayer = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            Projects.crptUnitInformation rptUnitInformation = new Projects.crptUnitInformation();
            rptUnitInformation.SetDataSource(bLayer.GetUnitDetailsOfProject(projectId).Tables[0]);
            clsCommonFunctions.ShowReport(rptUnitInformation, tssStatus, true);
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void AcknoledgementReceipt(int transactionId, ToolStripStatusLabel tssStatus)
        {
            bllPayment ackReceipt = new bllPayment();
            tssStatus.Text = Resources.strCollectingData;
            Recovery.crptAcknowledgementReceipt rptAckReceipt = new Recovery.crptAcknowledgementReceipt();
            rptAckReceipt.SetDataSource(ackReceipt.AcknowledgementReceipt(transactionId).Tables[0]);
            clsCommonFunctions.ShowReport(rptAckReceipt, tssStatus, false, true);
            tssStatus.Text = Resources.strReadyStatus;
        }



        internal static void PaymentSchedule(string clientIds, bool withPaymentStatus, ToolStripStatusLabel tssStatus)
        {
            bllClientInfo paymentSchedule = new bllClientInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = new DataTable();

            dt = paymentSchedule.GetPaymentSchedule(clientIds).Tables[0];
            if (withPaymentStatus == true)
            {
                Clients.crptPaymentScheduleStatus rptPaymentScheduleStatus = new Clients.crptPaymentScheduleStatus();
                rptPaymentScheduleStatus.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rptPaymentScheduleStatus, tssStatus, true, true);
            }
            else
            {
                Clients.crptPaymentSchedule rptPaymentSchedule = new Clients.crptPaymentSchedule();
                rptPaymentSchedule.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rptPaymentSchedule, tssStatus, true, true);
            }
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void HandoverCertificate(int clientId, DateTime handoverDate, int handoverBy, int forwardedBy, int recommendedBy, ToolStripStatusLabel tssStatus)
        {
            bllPayment handoverCertificate = new bllPayment();
            tssStatus.Text = Resources.strCollectingData;
            Recovery.crptHandoverCertificate rptHandover = new Recovery.crptHandoverCertificate();
            rptHandover.SetDataSource(handoverCertificate.GetHandoverCertificate(clientId, handoverDate, handoverBy, forwardedBy, recommendedBy).Tables[0]);
            clsCommonFunctions.ShowReport(rptHandover, tssStatus, false, false);
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void ListOfKeys(int clientId, int projectEngineer, ToolStripStatusLabel tssStatus)
        {
            bllPayment keyList = new bllPayment();
            tssStatus.Text = Resources.strCollectingData;
            Recovery.crptKeyList rptKeyList = new Recovery.crptKeyList();
            rptKeyList.SetDataSource(keyList.GetKeyList(clientId, projectEngineer).Tables[0]);
            clsCommonFunctions.ShowReport(rptKeyList, tssStatus, true, false);
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void PaymentClearanceCertificate(int clientId, int verifiedBy, int checkedBy, int recommnededBy, ToolStripStatusLabel tssStatus)
        {
            bllPayment paymentClearance = new bllPayment();
            tssStatus.Text = Resources.strCollectingData;
            Recovery.crpt_PaymentClearanceCertificate crptPaymentClearance = new Recovery.crpt_PaymentClearanceCertificate();
            crptPaymentClearance.SetDataSource(paymentClearance.GetPaymentClearanceCertificate(clientId, verifiedBy, checkedBy, recommnededBy).Tables[0]);
            clsCommonFunctions.ShowReport(crptPaymentClearance, tssStatus, true, true);
            tssStatus.Text = Resources.strReadyStatus;
        }
        
        internal static void ProjectSummary(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo bLayer = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            Projects.crptProjectInfo rptProjectSummary = new Projects.crptProjectInfo();
            rptProjectSummary.SetDataSource(bLayer.GetProjectSummary(projectId).Tables[0]);
            clsCommonFunctions.ShowReport(rptProjectSummary, tssStatus, true, true);
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void ListOfClientsByProjectId(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo b = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            Projects.crptListOfClientsByProjectId rptListOfClients = new Projects.crptListOfClientsByProjectId();
            rptListOfClients.SetDataSource(b.GetListOfClientsByProjectId(projectId).Tables[0]);
            clsCommonFunctions.ShowReport(rptListOfClients, tssStatus, true, true);
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void LoanDisbursementHistory(string clientIds, ToolStripStatusLabel tssStatus)
        {
            bllPayment loan = new bllPayment();
            tssStatus.Text = Resources.strCollectingData;
            Recovery.crptLoanDisbursementHistory rptLoan = new Recovery.crptLoanDisbursementHistory();
            rptLoan.SetDataSource(loan.GetLoanDisbursementHistory(clientIds).Tables[0]);
            clsCommonFunctions.ShowReport(rptLoan, tssStatus, true, true);
            tssStatus.Text = Resources.strReadyStatus;

        }

        internal static void RegistrationAcknowledgementReceipt(string clientIds, ToolStripStatusLabel tssStatus)
        {
            
            if (clsCommonFunctions.isContainCancelledClient(clientIds) == true) { throw new ApplicationException("Registration Acknowledgement Report cannot be generated for Cancelled Clients."); }
            bllClientInfo ackReceipt = new bllClientInfo();
            tssStatus.Text = Resources.strCollectingData;
            Clients.crptRegistrationAcknowledgementReceipt rptAckReceipt = new Clients.crptRegistrationAcknowledgementReceipt();
            rptAckReceipt.SetDataSource(ackReceipt.RegistrationAcknowledgementReceipt(clientIds).Tables[0]);
            rptAckReceipt.DataDefinition.FormulaFields["Designation"].Text = "'" + clsGlobalClass.userDesignation + "'";
            clsCommonFunctions.ShowReport(rptAckReceipt, tssStatus, true, true);
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void AllotmentLetter(string clientIds, decimal monthlyRent, ToolStripStatusLabel tssStatus)
        {
            if (monthlyRent <= 0) throw new ApplicationException("Monthly rental amount cannot be less than or equal to zero.");
            if (clsCommonFunctions.IsActiveClient(clientIds.ConvertToInt32()) == false) { throw new ApplicationException("Allotment letter cannot be generated for Cancelled Clients."); }
            bllClientInfo allotmentLetter = new bllClientInfo();
            tssStatus.Text = Resources.strCollectingData;
            Clients.crptAllotmentLetter rptAllotmentLetter = new Clients.crptAllotmentLetter();
            rptAllotmentLetter.SetDataSource(allotmentLetter.GetAllotmentLetter(clientIds, monthlyRent).Tables[0]);
            clsCommonFunctions.ShowReport(rptAllotmentLetter, tssStatus, false, false);
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void PaymentComparison(string clientId, ToolStripStatusLabel tssStatus)
        {
            if (clsCommonFunctions.isContainCancelledClient(clientId) == true) { throw new ApplicationException("Payment Comparison report cannot be generated for Cancelled Clients."); }
            bllPayment paymentComparison = new bllPayment();
            tssStatus.Text = Resources.strCollectingData;
            Recovery.crpt_PaymentComparison rptPaymentComparison = new Recovery.crpt_PaymentComparison();
            rptPaymentComparison.SetDataSource(paymentComparison.GetPaymentComparison(clientId).Tables[0]);
            clsCommonFunctions.ShowReport(rptPaymentComparison, tssStatus, true, true);
            tssStatus.Text = Resources.strReadyStatus;
        }
    }
}
