using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;
using RealEstateManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateManagementSystem.Reports
{
    class clsReports
    {
        private static string strCollectingData = ConfigurationManager.AppSettings["strCollectingData"].ToString();

        #region Project Reports
        internal static void GetRegistrationStatusOfProject(int projectId, bool withPaymentInfo, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = strCollectingData;
            DataTable dt = p.GetRegistrationStatusOfProject(projectId).Tables[0];
            if (dt.Rows.Count > 0)
            {
                if (withPaymentInfo == true)
                {
                    Projects.crptRegistrationInformationOfProject_WithPayment rpt = new Projects.crptRegistrationInformationOfProject_WithPayment();
                    rpt.SetDataSource(dt);
                    clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Registration Status (With Payment Data) of " + clsCommonFunctions.GetProjectNameFromProjectId(projectId), true);
                }
                else
                {
                    Projects.crptRegistrationInformationOfProject rpt = new Projects.crptRegistrationInformationOfProject();
                    rpt.SetDataSource(dt);
                    clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Registration Status of " + clsCommonFunctions.GetProjectNameFromProjectId(projectId), true);
                }
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }



        internal static void GetOralBookingOfProject(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetOralBookingOfProject(projectId);
            if (dt.Rows.Count > 0)
            {
                Projects.crptOralBookingOfProject rpt = new Projects.crptOralBookingOfProject();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Oral booking position of " + clsCommonFunctions.GetProjectNameFromProjectId(projectId), true);

            }
            else { throw new ApplicationException(Resources.strNoData); }
        }



        internal static void ListOfLandOwners(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetListOfLandOwners(projectId);
            if (dt.Rows.Count > 0)
            {
                Projects.crptListOfLandOwners rpt = new Projects.crptListOfLandOwners();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "List of Land Owners of " + clsCommonFunctions.GetProjectNameFromProjectId(projectId) + "", true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        internal static void ListOfClientsByProjectId_WithPayment(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetListOfClientsByProjectId_WithPayment(projectId);
            if (dt.Rows.Count > 0)
            {
                Projects.crptGetListOfClientsByProjectWithPayment rpt = new Projects.crptGetListOfClientsByProjectWithPayment();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Client list with payment information of " + clsCommonFunctions.GetProjectNameFromProjectId(projectId), true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }



        internal static void PriceList(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetPriceList(projectId);
            if (dt.Rows.Count > 0)
            {
                Projects.crptPriceListOfProject rpt = new Projects.crptPriceListOfProject();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Price list of " + clsCommonFunctions.GetProjectNameFromProjectId(projectId), true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        internal static void GetConsolidatedProjectSummary(clsGlobalClass.ProjectCommonReport_FilterBy filterBy, string filterCriteria, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetConsolidatedProjectSummary(filterBy, filterCriteria);
            if (dt.Rows.Count > 0)
            {
                Projects.crptConsolidatedProjectSummary rpt = new Projects.crptConsolidatedProjectSummary();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Consolidate Project Summary", true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        internal static void GetFinancialSummaryOfProjects(clsGlobalClass.ProjectCommonReport_FilterBy filterBy, string filterCriteria, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetFinancialSummaryOfProjects(filterBy, filterCriteria);
            if (dt.Rows.Count > 0)
            {
                Projects.crpt_FinancialSummaryOfProject rpt = new Projects.crpt_FinancialSummaryOfProject();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Financial Summary", true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        internal static void GetCommonPriceList(clsGlobalClass.ProjectCommonReport_FilterBy filterBy, string filterCriteria, ToolStripStatusLabel tssStatus)
        {

            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetCommonPriceList(filterBy, filterCriteria);
            if (dt.Rows.Count > 0)
            {
                Projects.crptCommonPriceList rpt = new Projects.crptCommonPriceList();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, false, true, "Common Price List", true);
            }
            else { throw new ApplicationException(Resources.strNoData); }

        }

        internal static void GetListOfBlockedUnits(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo blockedUnits = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = blockedUnits.GetListOfBlockedUnits(searchBy, filterBy, filterCriteria);
            if (dt.Rows.Count > 0)
            {
                Projects.crptListOfBlockedUnits rpt = new Projects.crptListOfBlockedUnits();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Blocked Units", true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        internal static void GetCommonClientList(clsGlobalClass.ProjectCommonReport_FilterBy filterBy, string filterCriteria, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetCommonClientList(filterBy, filterCriteria);
            if (dt.Rows.Count > 0)
            {
                Projects.crptCommonClientList rpt = new Projects.crptCommonClientList();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Common Client List", true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        internal static void BookingPosition(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetBookingPosition(projectId);
            if (dt.Rows.Count > 0)
            {
                Projects.crptBookingPosition rpt = new Projects.crptBookingPosition();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Booking Position of " + clsCommonFunctions.GetProjectNameFromProjectId(projectId), true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        internal static void PaymentDetailsOfClientsByProject(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.PaymentDetailsOfClientsByProject(projectId);
            if (dt.Rows.Count > 0)
            {
                Projects.crptListOfClientsByProjectWithPaymentDetails rpt = new Projects.crptListOfClientsByProjectWithPaymentDetails();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Overall Status of Clients (" + clsCommonFunctions.GetProjectNameFromProjectId(projectId) + ")", true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        //internal static void SummaryCountsOfProject(ToolStripStatusLabel tssStatus)
        //{
        //    bllProjectInfo p = new bllProjectInfo();
        //    Projects.crpt_sr_SummarizedDataOfProject rpt = new Projects.crpt_sr_SummarizedDataOfProject();
        //    rpt.SetDataSource(p.GetProjectSummaryByStatus());
        //    clsCommonFunctions.ShowReport(rpt, tssStatus, false, false, "", false);

        //}


        internal static void ListOfClientsByProjectId_WithPhotoSignature(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetListOfClientsByProjectId_WithPhotoAndSignature(projectId, tssStatus);
            if (dt.Rows.Count > 0)
            {
                Projects.crptGetListOfClientsOfProjectWithPhotoSignature rpt = new Projects.crptGetListOfClientsOfProjectWithPhotoSignature();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Client list with Photo and Signature (" + clsCommonFunctions.GetProjectNameFromProjectId(projectId) + ")", true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        internal static void ListOfClientsByProjectId_WithUnitValue(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetListOfClientsByProjectId_WithUnitValue(projectId);
            if (dt.Rows.Count > 0)
            {
                Projects.crptGetListOfClientsOfProjectWithUnitValue rpt = new Projects.crptGetListOfClientsOfProjectWithUnitValue();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "List of Clients with Unit Value of " + clsCommonFunctions.GetProjectNameFromProjectId(projectId), true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        internal static void GetDeductionAmount(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetDeductionAmountByProject(projectId);
            if (dt.Rows.Count > 0)
            {
                Projects.crptGetDeductionAmountByProject rpt = new Projects.crptGetDeductionAmountByProject();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Deduction amount of " + clsCommonFunctions.GetProjectNameFromProjectId(projectId), true);
            }
            else { throw new ApplicationException(Resources.strNoData); }

        }

        internal static void GetDueListOfProject(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetDueListOfProject(projectId);
            if (dt.Rows.Count > 0)
            {
                Projects.crptDueListByProject rpt = new Projects.crptDueListByProject();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Due List of " + clsCommonFunctions.GetProjectNameFromProjectId(projectId), true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        internal static void GetGeneralStatusOfClient(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetGeneralStatusOfClient(projectId);
            if (dt.Rows.Count > 0)
            {
                Projects.crptGeneralStatusOfClientByProject rpt = new Projects.crptGeneralStatusOfClientByProject();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "General Status of Client(s) <" + clsCommonFunctions.GetProjectNameFromProjectId(projectId) + ">", true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        internal static void GetDeedOfAgreementsOfProject(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = p.GetDeedOfAgreementsOfProject(projectId, tssStatus).Tables[0];
            if (dt.Rows.Count > 0)
            {
                Projects.crptDeedOfAgreements rpt = new Projects.crptDeedOfAgreements();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Deed of Agreement Status of " + clsCommonFunctions.GetProjectNameFromProjectId(projectId), true);
            }
            else { throw new ApplicationException(Resources.strNoData); }

        }

        internal static void ProjectSummary(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo bLayer = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            Projects.crptProjectInfo rptProjectSummary = new Projects.crptProjectInfo();
            rptProjectSummary.SetDataSource(bLayer.GetProjectSummary(projectId).Tables[0]);
            clsCommonFunctions.ShowReport(rptProjectSummary, tssStatus, true, true, "Summary of " + clsCommonFunctions.GetProjectNameFromProjectId(projectId) + " Project");
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void ListOfClientsByProjectId(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo b = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = b.GetListOfClientsByProjectId(projectId).Tables[0];
            if (dt.Rows.Count > 0)
            {
                Projects.crptListOfClientsByProjectId rptListOfClients = new Projects.crptListOfClientsByProjectId();
                rptListOfClients.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rptListOfClients, tssStatus, true, true, "List of Clients. Project: " + clsCommonFunctions.GetProjectNameFromProjectId(projectId), true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }
        #endregion

        #region Transactional Reports
        public static void MoneyReceipt(int transactionId, bool isDuplicate, ToolStripStatusLabel tssStatus)
        {
            bllPayment moneyReceipt = new bllPayment();
            tssStatus.Text = "Loading Money Receipt";
            Recovery.crptMoneyReceipt rptMoneyReceipt = new Recovery.crptMoneyReceipt();
            rptMoneyReceipt.SetDataSource(moneyReceipt.GetMoneyReceipt(transactionId, isDuplicate).Tables[0]);
            clsCommonFunctions.ShowReport(rptMoneyReceipt, tssStatus, false, true, "Money Receipt: Invoice # " + transactionId.ToString());
        }

        internal static void PaymentHistoryOfClient(string clientIds, ToolStripStatusLabel tssStatus)
        {
            bllPayment paymentHistory = new bllPayment();
            tssStatus.Text = "Loading Payment History";
            Recovery.crptPaymentHistoryOfClient rptPaymentHistory = new Recovery.crptPaymentHistoryOfClient();
            DataTable dt = new DataTable();
            dt = paymentHistory.GetPaymentHistoryOfClient(clientIds).Tables[0];
            rptPaymentHistory.SetDataSource(dt);
            clsCommonFunctions.ShowReport(rptPaymentHistory, tssStatus, true, true, "Payment History");
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void PaymentHistoryOfClient_WithBankAccount(string clientIds, ToolStripStatusLabel tssStatus)
        {
            bllPayment paymentHistory = new bllPayment();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = paymentHistory.GetPaymentHistoryOfClient_WithBankAccount(clientIds).Tables[0];
            if (dt.Rows.Count > 0)
            {
                Recovery.crptPaymentHistoryOfClient_WithAccountNumber pHistory = new Recovery.crptPaymentHistoryOfClient_WithAccountNumber();
                pHistory.SetDataSource(dt);
                clsCommonFunctions.ShowReport(pHistory, tssStatus, false, false, "Payment History (With Bank Account #");
            }
            else { throw new ApplicationException(Resources.strNoData); }

        }

        internal static void PaymentComparison(string clientId, ToolStripStatusLabel tssStatus)
        {
            if (clsCommonFunctions.isContainCancelledClient(clientId) == true) { throw new ApplicationException("Payment Comparison report cannot be generated for Cancelled Clients."); }
            bllPayment paymentComparison = new bllPayment();
            tssStatus.Text = Resources.strCollectingData;
            Recovery.crpt_PaymentComparison rptPaymentComparison = new Recovery.crpt_PaymentComparison();
            rptPaymentComparison.SetDataSource(paymentComparison.GetPaymentComparison(clientId).Tables[0]);
            clsCommonFunctions.ShowReport(rptPaymentComparison, tssStatus, true, true, "Payment Comparision");
            tssStatus.Text = Resources.strReadyStatus;
        }
        #endregion

        #region General Reports
        public static void ClientProfile(string strClientId, ToolStripStatusLabel tssStatus)
        {
            bllClientInfo b = new bllClientInfo();
            tssStatus.Text = "Generating Client Profile.....";
            int clientId = clsCommonFunctions.GetNumericPartOfFullClientId(strClientId);
            Clients.crptClientProfile crptProfile = new Clients.crptClientProfile();
            crptProfile.SetDataSource(b.GetClientProfile(clientId: clientId).Tables[0]);
            crptProfile.Subreports[1].SetDataSource(b.GetListOfPartners(clientId: clientId));
            crptProfile.Subreports[2].SetDataSource(b.GetPaymentSchedule(clientIds: clientId.ToString()).Tables[0]);
            clsCommonFunctions.ShowReport(crptProfile, tssStatus, true, true, "Profile of " + strClientId);
        }

        internal static void UnitDetailsOfProject(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo bLayer = new bllProjectInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = bLayer.GetUnitDetailsOfProject(projectId).Tables[0];
            if (dt.Rows.Count > 0)
            {
                Projects.crptUnitInformation rptUnitInformation = new Projects.crptUnitInformation();
                rptUnitInformation.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rptUnitInformation, tssStatus, true, false, "Unit Details of " + clsCommonFunctions.GetProjectNameFromProjectId(projectId));
            }
            else { throw new ApplicationException(Resources.strNoData); }

        }

        internal static void AcknowledgementReceipt(int transactionId, ToolStripStatusLabel tssStatus)
        {
            bllPayment ackReceipt = new bllPayment();
            tssStatus.Text = Resources.strCollectingData;
            Recovery.crptAcknowledgementReceipt rptAckReceipt = new Recovery.crptAcknowledgementReceipt();
            rptAckReceipt.SetDataSource(ackReceipt.AcknowledgementReceipt(transactionId).Tables[0]);
            clsCommonFunctions.ShowReport(rptAckReceipt, tssStatus, false, true, "Acknowledgement Receipt. Invoice # " + transactionId.ToString());
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
                clsCommonFunctions.ShowReport(rptPaymentScheduleStatus, tssStatus, true, true, "Payment Schedule");
            }
            else
            {
                Clients.crptPaymentSchedule rptPaymentSchedule = new Clients.crptPaymentSchedule();
                rptPaymentSchedule.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rptPaymentSchedule, tssStatus, true, true, "Payment Schedule (Without Payment Status)");
            }
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void HandoverCertificate(int clientId, DateTime handoverDate, int handoverBy, int forwardedBy, int recommendedBy, ToolStripStatusLabel tssStatus)
        {
            bllPayment handoverCertificate = new bllPayment();
            tssStatus.Text = Resources.strCollectingData;
            Recovery.crptHandoverCertificate rptHandover = new Recovery.crptHandoverCertificate();
            rptHandover.SetDataSource(handoverCertificate.GetHandoverCertificate(clientId, handoverDate, handoverBy, forwardedBy, recommendedBy).Tables[0]);
            clsCommonFunctions.ShowReport(rptHandover, tssStatus, false, false, "Handover Certificate. Client # " + clsCommonFunctions.GetFullClientId(clientId.ToString()));
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void ListOfKeys(int clientId, int projectEngineer, ToolStripStatusLabel tssStatus)
        {
            bllPayment keyList = new bllPayment();
            tssStatus.Text = Resources.strCollectingData;
            Recovery.crptKeyList rptKeyList = new Recovery.crptKeyList();
            rptKeyList.SetDataSource(keyList.GetKeyList(clientId, projectEngineer).Tables[0]);
            clsCommonFunctions.ShowReport(rptKeyList, tssStatus, true, false, "List of Keys. Client # " + clsCommonFunctions.GetFullClientId(clientId.ToString()));
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void PaymentClearanceCertificate(int clientId, int verifiedBy, int checkedBy, int recommnededBy, ToolStripStatusLabel tssStatus)
        {
            bllPayment paymentClearance = new bllPayment();
            tssStatus.Text = Resources.strCollectingData;
            Recovery.crpt_PaymentClearanceCertificate crptPaymentClearance = new Recovery.crpt_PaymentClearanceCertificate();
            crptPaymentClearance.SetDataSource(paymentClearance.GetPaymentClearanceCertificate(clientId, verifiedBy, checkedBy, recommnededBy).Tables[0]);
            clsCommonFunctions.ShowReport(crptPaymentClearance, tssStatus, true, true, "Payment Clearance Certificate. Client # " + clsCommonFunctions.GetFullClientId(clientId.ToString()));
            tssStatus.Text = Resources.strReadyStatus;
        }

        internal static void LoanDisbursementHistory(string clientIds, ToolStripStatusLabel tssStatus)
        {
            bllPayment loan = new bllPayment();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = loan.GetLoanDisbursementHistory(clientIds).Tables[0];
            if (dt.Rows.Count != 0)
            {
                Recovery.crptLoanDisbursementHistory rptLoan = new Recovery.crptLoanDisbursementHistory();
                rptLoan.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rptLoan, tssStatus, true, true, "Loan Disbursement History");
                tssStatus.Text = Resources.strReadyStatus;
            }
            else { throw new ApplicationException(Resources.strNoData); }

        }

        internal static void RegistrationAcknowledgementReceipt(string clientIds, ToolStripStatusLabel tssStatus)
        {

            if (clsCommonFunctions.isContainCancelledClient(clientIds) == true) { throw new ApplicationException("Registration Acknowledgement Report cannot be generated for Cancelled Clients."); }
            bllClientInfo ackReceipt = new bllClientInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = ackReceipt.RegistrationAcknowledgementReceipt(clientIds).Tables[0];
            if (dt.Rows.Count > 0)
            {
                Clients.crptRegistrationAcknowledgementReceipt rptAckReceipt = new Clients.crptRegistrationAcknowledgementReceipt();
                rptAckReceipt.SetDataSource(dt);
                rptAckReceipt.DataDefinition.FormulaFields["Designation"].Text = "'" + clsGlobalClass.userDesignation + "'";
                clsCommonFunctions.ShowReport(rptAckReceipt, tssStatus, true, true, "Registration Acknowledgement Receipt");
            }
            else { throw new ApplicationException(Resources.strNoData); }

        }

        internal static void AllotmentLetter(string clientIds, decimal monthlyRent, ToolStripStatusLabel tssStatus)
        {
            if (monthlyRent <= 0) throw new ApplicationException("Monthly rental amount cannot be less than or equal to zero.");
            if (clsCommonFunctions.IsActiveClient(clientIds.ConvertToInt32()) == false) { throw new ApplicationException("Allotment letter cannot be generated for Cancelled Clients."); }
            bllClientInfo allotmentLetter = new bllClientInfo();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = allotmentLetter.GetAllotmentLetter(clientIds, monthlyRent).Tables[0];
            if (dt.Rows.Count > 0)
            {
                Clients.crptAllotmentLetter rptAllotmentLetter = new Clients.crptAllotmentLetter();
                rptAllotmentLetter.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rptAllotmentLetter, tssStatus, false, false, "Allotment Letter");
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }
        #endregion

        #region Summarized Sales Report
        internal static void PictorialDepictionOfSalesStatus(DateTime startDate, DateTime endDate, ToolStripStatusLabel tssStatus)
        {
            if (startDate > endDate) throw new ApplicationException("Report End Date (" + endDate.ToString().ShowAsStandardDateFormat() + ") MUST be greater than the Start Date (" + startDate.ToString().ShowAsStandardDateFormat() + ")");
            tssStatus.Text = Resources.strCollectingData;
            bllSummarizedSalesReport sales = new bllSummarizedSalesReport();
            DataTable dt = sales.GetPictorialDepictionOfSalesStatus(startDate, endDate);
            if (dt.Rows.Count > 0)
            {
                SummarizedSales.crptPictorialDepictionOfSalesStatus rpt = new SummarizedSales.crptPictorialDepictionOfSalesStatus();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Sales and Collection Status", true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        internal static void SalesPosition(DateTime startDate, DateTime endDate, ToolStripStatusLabel tssStatus, bool IsISOFormat)
        {
            if (startDate > endDate) throw new ApplicationException("Report End Date (" + endDate.ToString().ShowAsStandardDateFormat() + ") MUST be greater than the Start Date (" + startDate.ToString().ShowAsStandardDateFormat() + ")");
            tssStatus.Text = Resources.strCollectingData;
            bllSummarizedSalesReport sales = new bllSummarizedSalesReport();
            DataTable dt = sales.GetSalesPosition_Details(startDate, endDate);
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            if (dt.Rows.Count > 0)
            {
                if (IsISOFormat == true) { rpt = new SummarizedSales.crptSalesPosition_ISOFormat(); }
                else { rpt = new SummarizedSales.crptSalesPositionDetails(); }
                rpt.DataDefinition.FormulaFields["StartDate"].Text = "'" + startDate.ToString().ShowAsStandardDateFormat() + "'";
                rpt.DataDefinition.FormulaFields["EndDate"].Text = "'" + endDate.ToString().ShowAsStandardDateFormat() + "'";
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Sales position details between " + startDate.ToString().ShowAsStandardDateFormat() + " & " + endDate.ToString().ShowAsStandardDateFormat() + ".", true);
            }
            else { throw new ApplicationException(Resources.strNoData); }

        }

        internal static void GetSummarizedSalesReport(DateTime startDate, DateTime endDate, ToolStripStatusLabel tssStatus)
        {
            if (startDate > endDate) { throw new ApplicationException("Report End Date (" + endDate.ToString().ShowAsStandardDateFormat() + ") MUST be greater than the Start Date (" + startDate.ToString().ShowAsStandardDateFormat() + ")"); }
            tssStatus.Text = Resources.strCollectingData;
            bllSummarizedSalesReport summary = new bllSummarizedSalesReport();
            DataTable dt = summary.GetSummarizedSalesReport(startDate, endDate);
            if (dt.Rows.Count > 0)
            {
                SummarizedSales.crptSummarizedSalesReport rpt = new SummarizedSales.crptSummarizedSalesReport();
                rpt.DataDefinition.FormulaFields["StartDate"].Text = "'" + startDate.ToString().ShowAsStandardDateFormat() + "'";
                rpt.DataDefinition.FormulaFields["EndDate"].Text = "'" + endDate.ToString().ShowAsStandardDateFormat() + "'";
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Summarized Sales Report between " + startDate.ToString().ShowAsStandardDateFormat() + " & " + endDate.ToString().ShowAsStandardDateFormat() + ".", true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        internal static void GetAnnualSalesPosition(int salesYear, ToolStripStatusLabel tssStatus)
        {
            bllSummarizedSalesReport annualStatus = new bllSummarizedSalesReport();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = annualStatus.GetAnnualSalesPosition(salesYear);
            if (dt.Rows.Count > 0)
            {
                SummarizedSales.crptAnnualSalesSummary rpt = new SummarizedSales.crptAnnualSalesSummary();
                rpt.DataDefinition.FormulaFields["SaleYear"].Text = "'" + salesYear.ToString() + "'";
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Annual Sales Position for the Year of " + salesYear.ToString(), true);
            }
            else { throw new Exception(Resources.strNoData); }
        }

        internal static void GetSummaryOfSales(int salesYear, ToolStripStatusLabel tssStatus)
        {
            bllSummarizedSalesReport summaryOfSales = new bllSummarizedSalesReport();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = summaryOfSales.GetSummaryOfSales(salesYear);
            if (dt.Rows.Count > 0)
            {
                SummarizedSales.crptSummaryOfSales rpt = new SummarizedSales.crptSummaryOfSales();
                //rpt.DataDefinition.FormulaFields["SaleYear"].Text = "'" + salesYear.ToString() + "'";
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Summary of Sales for the Year of " + salesYear.ToString(), true);
            }
            else { throw new Exception(Resources.strNoData); }
        }

        internal static void GetListOfCanceledClients(bool isBookingDate, DateTime startDate, DateTime endDate, ToolStripStatusLabel tssStatus)
        {
            bllSummarizedSalesReport cancelClients = new bllSummarizedSalesReport();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = cancelClients.GetListOfCanceledClients(isBookingDate, startDate, endDate);
            if (dt.Rows.Count > 0)
            {
                SummarizedSales.crptListOfCanceledClients rpt = new SummarizedSales.crptListOfCanceledClients();
                rpt.SetDataSource(dt);
                string dateBase = isBookingDate == true ? "Booking date" : "Cancel Date";
                string strCaption = "List of Canceled Clients (" + dateBase + " between " + startDate.ToString().ShowAsStandardDateFormat() + " and " + endDate.ToString().ShowAsStandardDateFormat();
                rpt.SummaryInfo.ReportTitle = strCaption;
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, strCaption, true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        /// <summary>
        /// Get collection summary of project
        /// </summary>
        /// <param name="searchBy">Summary or Project</param>
        /// <param name="filterCriteria">Selected items from a listbox (use clsCommonFunctions.convertToCommaSeperatedValue function)</param>
        /// <param name="filterBy">0-Selected Projects, 1- ProjectStats, 2-District, 3-Area, 4-Location, 5-ProjectType</param>
        /// <param name="tssStatus"></param>
        internal static void GetCollectionsOfProject(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, ToolStripStatusLabel tssStatus)
        {
            bllSummarizedSalesReport projectCollection = new bllSummarizedSalesReport();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = projectCollection.GetCollectionsOfProject(searchBy, filterCriteria, filterBy);
            if (dt.Rows.Count > 0)
            {
                SummarizedSales.crptCollectionOfProjects rpt = new SummarizedSales.crptCollectionOfProjects();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Project Collection", true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }

        internal static void GetSummarizedSalesStatus(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, ToolStripStatusLabel tssStatus)
        {
            bllSummarizedSalesReport status = new bllSummarizedSalesReport();
            tssStatus.Text = Resources.strCollectingData;
            DataTable dt = status.GetSummarizedSalesStatus(searchBy, filterCriteria, filterBy);
            if (dt.Rows.Count > 0)
            {
                SummarizedSales.crptSummarizedSalesStatus rpt = new SummarizedSales.crptSummarizedSalesStatus();
                rpt.SetDataSource(dt);
                clsCommonFunctions.ShowReport(rpt, tssStatus, true, true, "Summarized Sales Status", true);
            }
            else { throw new ApplicationException(Resources.strNoData); }
        }
        #endregion
    }
}
