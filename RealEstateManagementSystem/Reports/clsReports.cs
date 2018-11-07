using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;
using RealEstateManagementSystem.Utilities;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using static RealEstateManagementSystem.Utilities.clsCommonFunctions;

namespace RealEstateManagementSystem.Reports
{
    class clsReports
    {
        private static string _strCollectingData = ConfigurationManager.AppSettings["strCollectingData"].ToString();

        #region Project Reports

        internal static void GetRegistrationStatusOfProject(int projectId, bool withPaymentInfo,
            ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ReportDocument crpt = withPaymentInfo ? (ReportDocument)new Projects.crptRegistrationInformationOfProject_WithPayment() : new Projects.crptRegistrationInformationOfProject();
            string strReportHeading = $"Registration Status {(withPaymentInfo ? "(With Payment Data) of " : "of ")} {GetProjectNameFromProjectId(projectId)}";
            ShowReport(crpt, p.GetRegistrationStatusOfProject(projectId).Tables[0], tssStatus, true, true,
                strReportHeading, true);
        }

        internal static void GetOralBookingOfProject(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptOralBookingOfProject(), p.GetOralBookingOfProject(projectId), tssStatus, true,
                true, "Oral booking position of " + GetProjectNameFromProjectId(projectId), true);
        }

        internal static void ListOfLandOwners(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptListOfLandOwners(), p.GetListOfLandOwners(projectId), tssStatus, true, true,
                "List of Land Owners of " + GetProjectNameFromProjectId(projectId) + "", true);
        }

        internal static void ListOfClientsByProjectId_WithPayment(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptGetListOfClientsByProjectWithPayment(),
                p.GetListOfClientsByProjectId_WithPayment(projectId), tssStatus, true, true,
                "Client list with payment information of " + GetProjectNameFromProjectId(projectId), true);
        }

        internal static void PriceList(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptPriceListOfProject(), p.GetPriceList(projectId), tssStatus, true, true,
                "Price list of " + GetProjectNameFromProjectId(projectId), true);
        }

        internal static void GetConsolidatedProjectSummary(clsGlobalClass.ProjectCommonReport_FilterBy filterBy,
            string filterCriteria, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptConsolidatedProjectSummary(),
                p.GetConsolidatedProjectSummary(filterBy, filterCriteria), tssStatus, true, true,
                "Consolidate Project Summary", true);
        }

        internal static void GetFinancialSummaryOfProjects(clsGlobalClass.ProjectCommonReport_FilterBy filterBy,
            string filterCriteria, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crpt_FinancialSummaryOfProject(),
                p.GetFinancialSummaryOfProjects(filterBy, filterCriteria), tssStatus, true, true, "Financial Summary",
                true);
        }

        internal static void GetCommonPriceList(clsGlobalClass.ProjectCommonReport_FilterBy filterBy,
            string filterCriteria, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptCommonPriceList(), p.GetCommonPriceList(filterBy, filterCriteria), tssStatus,
                false, true, "Common Price List", true);
        }

        internal static void GetListOfBlockedUnits(string searchBy, string filterCriteria,
            clsGlobalClass.ProjectCommonReport_FilterBy filterBy, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo blockedUnits = new bllProjectInfo();
            ShowReport(new Projects.crptListOfBlockedUnits(),
                blockedUnits.GetListOfBlockedUnits(searchBy, filterBy, filterCriteria), tssStatus, true, true,
                "Blocked Units", true);
        }

        internal static void GetCommonClientList(clsGlobalClass.ProjectCommonReport_FilterBy filterBy,
            string filterCriteria, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptCommonClientList(), p.GetCommonClientList(filterBy, filterCriteria), tssStatus,
                true, true, "Common Client List", true);
        }

        internal static void BookingPosition(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptBookingPosition(), p.GetBookingPosition(projectId), tssStatus, true, true,
                "Booking Position of " + GetProjectNameFromProjectId(projectId), true);
        }

        internal static void PaymentDetailsOfClientsByProject(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptListOfClientsByProjectWithPaymentDetails(),
                p.PaymentDetailsOfClientsByProject(projectId), tssStatus, true, true,
                "Overall Status of Clients (" + GetProjectNameFromProjectId(projectId) + ")", true);
        }

        internal static void ListOfClientsByProjectId_WithPhotoSignature(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptGetListOfClientsOfProjectWithPhotoSignature(),
                p.GetListOfClientsByProjectId_WithPhotoAndSignature(projectId, tssStatus), tssStatus, true, true,
                "Client list with Photo and Signature (" + GetProjectNameFromProjectId(projectId) + ")", true);
        }


        internal static void ListOfClientsByProjectId_WithUnitValue(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptGetListOfClientsOfProjectWithUnitValue(),
                p.GetListOfClientsByProjectId_WithUnitValue(projectId), tssStatus, true, true,
                "List of Clients with Unit Value of " + GetProjectNameFromProjectId(projectId), true);
        }

        internal static void GetDeductionAmount(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptGetDeductionAmountByProject(), p.GetDeductionAmountByProject(projectId),
                tssStatus, true, true, "Deduction amount of " + GetProjectNameFromProjectId(projectId), true);
        }

        internal static void GetDueListOfProject(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptDueListByProject(), p.GetDueListOfProject(projectId), tssStatus, true, true,
                "Due List of " + GetProjectNameFromProjectId(projectId), true);
        }

        internal static void GetGeneralStatusOfClient(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptGeneralStatusOfClientByProject(), p.GetGeneralStatusOfClient(projectId),
                tssStatus, true, true, "General Status of Client(s) <" + GetProjectNameFromProjectId(projectId) + ">",
                true);
        }

        

        internal static void GetDeedOfAgreementsOfProject(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptDeedOfAgreements(),
                p.GetDeedOfAgreementsOfProject(projectId, tssStatus).Tables[0], tssStatus, true, true,
                "Deed of Agreement Status of " + GetProjectNameFromProjectId(projectId), true);
        }

        internal static void ProjectSummary(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo p = new bllProjectInfo();
            ShowReport(new Projects.crptProjectInfo(), p.GetProjectSummary(projectId).Tables[0], tssStatus, true, true,
                "Summary of " + GetProjectNameFromProjectId(projectId) + " Project");
        }

        internal static void ListOfClientsByProjectId(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo b = new bllProjectInfo();
            ShowReport(new Projects.crptListOfClientsByProjectId(), b.GetListOfClientsByProjectId(projectId).Tables[0],
                tssStatus, true, true, "List of Clients. Project: " + GetProjectNameFromProjectId(projectId), true);
        }

        #endregion

        #region Transactional Reports

        public static void MoneyReceipt(int transactionId, bool isDuplicate, ToolStripStatusLabel tssStatus)
        {
            bllPayment moneyReceipt = new bllPayment();
            ShowReport(new Recovery.crptMoneyReceipt(),
                moneyReceipt.GetMoneyReceipt(transactionId, isDuplicate).Tables[0], tssStatus, false, true,
                "Money Receipt: Invoice # " + transactionId.ToString());
        }

        internal static void PaymentHistoryOfClient(string clientIds, ToolStripStatusLabel tssStatus)
        {
            bllPayment paymentHistory = new bllPayment();
            ShowReport(new Recovery.crptPaymentHistoryOfClient(),
                paymentHistory.GetPaymentHistoryOfClient(clientIds).Tables[0], tssStatus, true, true,
                "Payment History");
        }

        internal static void PaymentHistoryOfClient_WithBankAccount(string clientIds, ToolStripStatusLabel tssStatus)
        {
            bllPayment paymentHistory = new bllPayment();
            ShowReport(new Recovery.crptPaymentHistoryOfClient_WithAccountNumber(),
                paymentHistory.GetPaymentHistoryOfClient_WithBankAccount(clientIds).Tables[0], tssStatus, false, false,
                "Payment History (With Bank Account #");
        }

        internal static void PaymentComparison(string clientId, ToolStripStatusLabel tssStatus)
        {
            if (isContainCancelledClient(clientId))
            {
                throw new ApplicationException("Payment Comparison report cannot be generated for Cancelled Clients.");
            }

            bllPayment paymentComparison = new bllPayment();
            ShowReport(new Recovery.crpt_PaymentComparison(),
                paymentComparison.GetPaymentComparison(clientId).Tables[0], tssStatus, true, true,
                "Payment Comparision");
        }

        #endregion

        #region General Reports

        public static void ClientProfile(string strClientId, ToolStripStatusLabel tssStatus)
        {
            bllClientInfo b = new bllClientInfo();
            tssStatus.Text = "Generating Client Profile.....";
            int clientId = GetNumericPartOfFullClientId(strClientId);
            Clients.crptClientProfile crptProfile = new Clients.crptClientProfile();
            crptProfile.SetDataSource(b.GetClientProfile(clientId: clientId).Tables[0]);
            crptProfile.Subreports[1].SetDataSource(b.GetListOfPartners(clientId: clientId));
            crptProfile.Subreports[2].SetDataSource(b.GetPaymentSchedule(clientIds: clientId.ToString()).Tables[0]);
            ShowReport(crptProfile, tssStatus, true, true, "Profile of " + strClientId);
        }

        internal static void UnitDetailsOfProject(int projectId, ToolStripStatusLabel tssStatus)
        {
            bllProjectInfo bLayer = new bllProjectInfo();
            ShowReport(new Projects.crptUnitInformation(), bLayer.GetUnitDetailsOfProject(projectId).Tables[0],
                tssStatus, true, false, "Unit Details of " + GetProjectNameFromProjectId(projectId));
        }

        internal static void AcknowledgementReceipt(int transactionId, ToolStripStatusLabel tssStatus)
        {
            bllPayment ackReceipt = new bllPayment();
            ShowReport(new Recovery.crptAcknowledgementReceipt(),
                ackReceipt.AcknowledgementReceipt(transactionId).Tables[0], tssStatus, false, true,
                "Acknowledgement Receipt. Invoice # " + transactionId.ToString());
        }

        internal static void PaymentSchedule(string clientIds, bool withPaymentStatus, ToolStripStatusLabel tssStatus)
        {
            bllClientInfo paymentSchedule = new bllClientInfo();
            tssStatus.Text = Resources.strCollectingData;
            ReportDocument rpt;
            string strReportHeading = "Payment Schedule";
            if (withPaymentStatus)
            {
                rpt = new Clients.crptPaymentScheduleStatus();
            }
            else
            {
                rpt = new Clients.crptPaymentSchedule();
                strReportHeading = strReportHeading + " (Without Payment Status)";
            }

            ShowReport(rpt, paymentSchedule.GetPaymentSchedule(clientIds).Tables[0], tssStatus, true, true,
                strReportHeading);
        }

        internal static void HandoverCertificate(int clientId, DateTime handoverDate, int handoverBy, int forwardedBy,
            int recommendedBy, ToolStripStatusLabel tssStatus)
        {
            bllPayment handoverCertificate = new bllPayment();
            ShowReport(new Recovery.crptHandoverCertificate()
                , handoverCertificate
                    .GetHandoverCertificate(clientId, handoverDate, handoverBy, forwardedBy, recommendedBy).Tables[0]
                , tssStatus, false, false, "Handover Certificate. Client # " + GetFullClientId(clientId.ToString()));
        }

        internal static void ListOfKeys(int clientId, int projectEngineer, ToolStripStatusLabel tssStatus)
        {
            bllPayment keyList = new bllPayment();
            ShowReport(new Recovery.crptKeyList(), keyList.GetKeyList(clientId, projectEngineer).Tables[0], tssStatus,
                true, false, "List of Keys. Client # " + GetFullClientId(clientId.ToString()));
        }

        internal static void PaymentClearanceCertificate(int clientId, int verifiedBy, int checkedBy, int recommnededBy,
            ToolStripStatusLabel tssStatus)
        {
            bllPayment paymentClearance = new bllPayment();
            ShowReport(new Recovery.crpt_PaymentClearanceCertificate()
                , paymentClearance.GetPaymentClearanceCertificate(clientId, verifiedBy, checkedBy, recommnededBy)
                    .Tables[0]
                , tssStatus, true, true
                , "Payment Clearance Certificate. Client # " + GetFullClientId(clientId.ToString()));
        }

        internal static void LoanDisbursementHistory(string clientIds, ToolStripStatusLabel tssStatus)
        {
            bllPayment loan = new bllPayment();
            ShowReport(new Recovery.crptLoanDisbursementHistory()
                , loan.GetLoanDisbursementHistory(clientIds).Tables[0]
                , tssStatus, true, true, "Loan Disbursement History");
        }

        internal static void RegistrationAcknowledgementReceipt(string clientIds, ToolStripStatusLabel tssStatus)
        {
            if (isContainCancelledClient(clientIds)) throw new ApplicationException("Registration Acknowledgement Report cannot be generated for Cancelled Clients.");

            if (string.IsNullOrEmpty(clientIds)) throw new ApplicationException("Please select atleast one client to print Registration Acknowledgement Report.");

            bllClientInfo ackReceipt = new bllClientInfo();
            Clients.crptRegistrationAcknowledgementReceipt rptAckReceipt =
                new Clients.crptRegistrationAcknowledgementReceipt();
            rptAckReceipt.DataDefinition.FormulaFields["Designation"].Text = "'" + clsGlobalClass.userDesignation + "'";
            ShowReport(rptAckReceipt, ackReceipt.RegistrationAcknowledgementReceipt(clientIds).Tables[0], tssStatus,
                true, true, "Registration Acknowledgement Receipt");
        }

        internal static void AllotmentLetter(string clientIds, decimal monthlyRent, ToolStripStatusLabel tssStatus)
        {
            if (monthlyRent <= 0)
                throw new ApplicationException("Monthly rental amount cannot be less than or equal to zero.");
            if (IsActiveClient(clientIds.ConvertToInt32()) == false)
            {
                throw new ApplicationException("Allotment letter cannot be generated for Cancelled Clients.");
            }

            bllClientInfo allotmentLetter = new bllClientInfo();
            tssStatus.Text = Resources.strCollectingData;
            ShowReport(new Clients.crptAllotmentLetter(),
                allotmentLetter.GetAllotmentLetter(clientIds, monthlyRent).Tables[0], tssStatus, false, false,
                "Allotment Letter");
        }

        #endregion

        #region Summarized Sales Report

        internal static void SaleDataByRep(DateTime startDate, DateTime endDate, bool showDetails, string empId, ToolStripStatusLabel tssStatus)
        {
            if (startDate > endDate)
                throw new ApplicationException($"Report End Date ({endDate.ToString().ShowAsStandardDateFormat()}) MUST be greater than the Start Date ({startDate.ToString().ShowAsStandardDateFormat()})");

            bllSummarizedSalesReport sales = new bllSummarizedSalesReport();
            ShowReport(showDetails == true ? (ReportDocument)new SummarizedSales.crptSalesDetailsByRep() : new SummarizedSales.crptSalesSummaryByRep(),
                sales.GetSalesReportByRep(startDate, endDate, showDetails, empId),
                tssStatus, true, true, $"Sales {(showDetails == true ? "Details" : "Summary")} by Client", true);
        }


        internal static void PictorialDepictionOfSalesStatus(DateTime startDate, DateTime endDate,
            ToolStripStatusLabel tssStatus)
        {
            if (startDate > endDate)
                throw new ApplicationException($"Report End Date ({endDate.ToString().ShowAsStandardDateFormat()}) MUST be greater than the Start Date ({startDate.ToString().ShowAsStandardDateFormat()})"); bllSummarizedSalesReport sales = new bllSummarizedSalesReport();
            ShowReport(new SummarizedSales.crptPictorialDepictionOfSalesStatus(),
                sales.GetPictorialDepictionOfSalesStatus(startDate, endDate), tssStatus, true, true,
                "Sales and Collection Status", true);
        }

        internal static void SalesPosition(DateTime startDate, DateTime endDate, ToolStripStatusLabel tssStatus,
            bool IsISOFormat)
        {
            if (startDate > endDate)
                throw new ApplicationException($"Report End Date ({endDate.ToString().ShowAsStandardDateFormat()}) MUST be greater than the Start Date ({startDate.ToString().ShowAsStandardDateFormat()})"); bllSummarizedSalesReport sales = new bllSummarizedSalesReport();
            ReportDocument rpt = IsISOFormat ? (ReportDocument)new SummarizedSales.crptSalesPosition_ISOFormat() : (ReportDocument)new SummarizedSales.crptSalesPositionDetails();

            rpt.DataDefinition.FormulaFields["StartDate"].Text =
                "'" + startDate.ToString().ShowAsStandardDateFormat() + "'";
            rpt.DataDefinition.FormulaFields["EndDate"].Text =
                "'" + endDate.ToString().ShowAsStandardDateFormat() + "'";
            ShowReport(rpt, sales.GetSalesPosition_Details(startDate, endDate), tssStatus, true, true,
                "Sales position details between " + startDate.ToString().ShowAsStandardDateFormat() + " & " +
                endDate.ToString().ShowAsStandardDateFormat() + ".", true);
        }

        internal static void GetSummarizedSalesReport(DateTime startDate, DateTime endDate,
            ToolStripStatusLabel tssStatus)
        {
            if (startDate > endDate)
                throw new ApplicationException($"Report End Date ({endDate.ToString().ShowAsStandardDateFormat()}) MUST be greater than the Start Date ({startDate.ToString().ShowAsStandardDateFormat()})");

            bllSummarizedSalesReport summary = new bllSummarizedSalesReport();
            SummarizedSales.crptSummarizedSalesReport rpt = new SummarizedSales.crptSummarizedSalesReport();
            rpt.DataDefinition.FormulaFields["StartDate"].Text =
                "'" + startDate.ToString().ShowAsStandardDateFormat() + "'";
            rpt.DataDefinition.FormulaFields["EndDate"].Text =
                "'" + endDate.ToString().ShowAsStandardDateFormat() + "'";
            ShowReport(rpt, summary.GetSummarizedSalesReport(startDate, endDate), tssStatus, true, true,
                $"Summarized Sales Report between {startDate.ToString().ShowAsStandardDateFormat()} & {endDate.ToString().ShowAsStandardDateFormat()}.", true);
        }

        internal static void GetAnnualSalesPosition(int salesYear, ToolStripStatusLabel tssStatus)
        {
            bllSummarizedSalesReport annualStatus = new bllSummarizedSalesReport();
            SummarizedSales.crptAnnualSalesSummary rpt = new SummarizedSales.crptAnnualSalesSummary();
            rpt.DataDefinition.FormulaFields["SaleYear"].Text = "'" + salesYear.ToString() + "'";
            ShowReport(rpt, annualStatus.GetAnnualSalesPosition(salesYear), tssStatus, true, true,
                $"Annual Sales Position for the Year of {salesYear}", true);
        }

        internal static void GetSummaryOfSales(int salesYear, ToolStripStatusLabel tssStatus)
        {
            bllSummarizedSalesReport summaryOfSales = new bllSummarizedSalesReport();
            ShowReport(new SummarizedSales.crptSummaryOfSales(), summaryOfSales.GetSummaryOfSales(salesYear), tssStatus,
                true, true, $"Summary of Sales for the Year of {salesYear}", true);
        }

        internal static void GetListOfCanceledClients(bool isBookingDate, DateTime startDate, DateTime endDate,
            ToolStripStatusLabel tssStatus)
        {
            bllSummarizedSalesReport cancelClients = new bllSummarizedSalesReport();
            SummarizedSales.crptListOfCanceledClients rpt = new SummarizedSales.crptListOfCanceledClients();
            string dateBase = isBookingDate == true ? "Booking date" : "Cancel Date";
            string strCaption = $"List of Canceled Clients ({dateBase}) between {startDate.ToString().ShowAsStandardDateFormat()} and {endDate.ToString().ShowAsStandardDateFormat()}";

            rpt.SummaryInfo.ReportTitle = strCaption;
            ShowReport(rpt, cancelClients.GetListOfCanceledClients(isBookingDate, startDate, endDate), tssStatus, true,
                true, strCaption, true);
        }

        /// <summary>
        /// Get collection summary of project
        /// </summary>
        /// <param name="searchBy">Summary or Project</param>
        /// <param name="filterCriteria">Selected items from a listbox (use clsCommonFunctions.convertToCommaSeperatedValue function)</param>
        /// <param name="filterBy">0-Selected Projects, 1- ProjectStats, 2-District, 3-Area, 4-Location, 5-ProjectType</param>
        /// <param name="tssStatus"></param>
        internal static void GetCollectionsOfProject(string searchBy, string filterCriteria,
            clsGlobalClass.ProjectCommonReport_FilterBy filterBy, ToolStripStatusLabel tssStatus)
        {
            bllSummarizedSalesReport projectCollection = new bllSummarizedSalesReport();
            ShowReport(new SummarizedSales.crptCollectionOfProjects()
                , projectCollection.GetCollectionsOfProject(searchBy, filterCriteria, filterBy)
                , tssStatus, true, true, "Project Collection", true);
        }

        internal static void GetSummarizedSalesStatus(string searchBy, string filterCriteria,
            clsGlobalClass.ProjectCommonReport_FilterBy filterBy, ToolStripStatusLabel tssStatus)
        {
            bllSummarizedSalesReport status = new bllSummarizedSalesReport();
            ShowReport(new SummarizedSales.crptSummarizedSalesStatus(),
                status.GetSummarizedSalesStatus(searchBy, filterCriteria, filterBy), tssStatus, true, true,
                "Summarized Sales Status", true);
        }

        #endregion


        #region Recovery Reports

        internal static void GetProjectValuation(string searchBy, string filterCriteria,
            clsGlobalClass.ProjectCommonReport_FilterBy filterBy, DateTime dateUpTo, ToolStripStatusLabel tssStatus)
        {
            ShowReport(new Recovery.crptProjectValuation()
                , bllRecoveryReports.GetProjectValuation(searchBy, filterCriteria, filterBy, dateUpTo)
                , tssStatus, true, true, "Project Valuation Report", true);
        }

        internal static void GetRefundAmount(string searchBy, string filterCriteria,
            clsGlobalClass.ProjectCommonReport_FilterBy filterBy, int? installmentId = null, DateTime? startDate = null,
            DateTime? endDate = null, ToolStripStatusLabel tssStatus = null)
        {
            if (endDate == null || (startDate == null || !(startDate > endDate)))
                ShowReport(new Recovery.crptGetRefundTransactionHistory()
                    , bllRecoveryReports.GetRefundAmount(searchBy, filterCriteria, filterBy, installmentId, startDate,
                        endDate)
                    , tssStatus, true, true, "Refund Transaction History", true);
            else
                throw new ApplicationException(Resources.strStartDateGreaterThanEndDateError);
        }

        internal static void GetTransactionSummary(int month, int year, ToolStripStatusLabel tssStatus)
        {
            ShowReport(new Recovery.crptGetTransactionSummary()
                , bllRecoveryReports.GetTransactionSummary(month, year)
                , tssStatus, true, true, "Transaction summary", true);
        }

        internal static void GetRecoveryPosition(string searchBy, string filterCriteria,
            clsGlobalClass.ProjectCommonReport_FilterBy filterBy, ToolStripStatusLabel tssStatus)
        {
            ShowReport(new Recovery.crptRecoveryPosition()
                , bllRecoveryReports.GetRecoveryPosition(searchBy, filterCriteria, filterBy)
                , tssStatus, true, true, "Recovery Position", true);
        }

        #endregion

        public static void GetComaparePaymentStatus(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, DateTime startDate, DateTime endDate, ToolStripStatusLabel tssStatus)
        {
            if (!(startDate > endDate))
                ShowReport(new Recovery.crptComparePayment()
                    , bllRecoveryReports.GetComparePaymentStatus(searchBy, filterCriteria, filterBy, startDate, endDate)
                    , tssStatus, true, false
                    , $"Compare Payment between {startDate.ToString(CultureInfo.InvariantCulture).ShowAsStandardDateFormat()} & {endDate.ToString(CultureInfo.InvariantCulture).ShowAsStandardDateFormat()}"
                    , false);
            else
                throw new ApplicationException(Resources.strStartDateGreaterThanEndDateError);
        }

        public static void GetRegistrationCompletionList(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, DateTime startDate, DateTime endDate, ToolStripStatusLabel tssStatus)
        {
            if (!(startDate > endDate))
                ShowReport(new Recovery.crptRegistrationCompletionList()
                    , bllRecoveryReports.GetRegistrationCompletionList(searchBy, filterCriteria, filterBy, startDate, endDate)
                    , tssStatus, true, true
                    , $"Compare Payment between {startDate.ToString(CultureInfo.InvariantCulture).ShowAsStandardDateFormat()} & {endDate.ToString(CultureInfo.InvariantCulture).ShowAsStandardDateFormat()}"
                    , true);
            else
                throw new ApplicationException(Resources.strStartDateGreaterThanEndDateError);

        }

        public static void GetAnnualRevoveryPosition(string saleYears, ToolStripStatusLabel tssStatus)
        {
            ShowReport(new Recovery.crptAnnualRecoveryPosition()
                , bllRecoveryReports.GetAnnualRecoveryPosition(saleYears), tssStatus
                , true, true, "Annual Recovery Position", true);
        }

        public static void GetListOfClientsByCurrentDue(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, decimal minimumDue, decimal maximumDue, ToolStripStatusLabel tssStatus)
        {
            ShowReport(new Recovery.crptListOfClientsByCurrentDue()
                , bllRecoveryReports.GetListOfClientsByCurrentDue(searchBy, filterCriteria, filterBy, minimumDue, maximumDue)
                , tssStatus, true, true
                , $"Current Due between {minimumDue.FormatAsMoney(true)} & {minimumDue.FormatAsMoney(true)}"
                , true);
        }

        public static void GetMonthlyRecoveryPosition(int month, int year, decimal targetAmount, decimal installmentDue, decimal bdPaymentDue, string analysis, bool isNewEntry, ToolStripStatusLabel tssStatus)
        {
            ReportDocument rpt = new Recovery.crptMonthlyRecoveryPosition();
            rpt.DataDefinition.FormulaFields["PreparedBy"].Text =
                "'" + clsGlobalClass.userFullName + "<br />" + clsGlobalClass.userDesignation + "'";
            ShowReport(rpt,
                bllRecoveryReports.GetMonthlyRecoveryPosition(month, year, targetAmount, installmentDue, bdPaymentDue, analysis, isNewEntry),
                tssStatus, true, true,
                $"Monthly Recovery Position for the Month of {month.MonthName()}, {year}", true);

        }

        public static void GetAnnualAgreementReport(string reportYears, ToolStripStatusLabel tssStatus)
        {
            ShowReport(new Recovery.crptAnnualAgreementList(), bllRecoveryReports.GetAnnualAgreementList(reportYears),
                tssStatus, true, true, $"Yearly agreement list for the year of {reportYears}", true);
        }

        internal static void ChequeInformationReport(System.Data.DataTable dt, ToolStripStatusLabel tssStatus)
        {
            ShowReport(new Accounts.crptListOfClientCheques(), dt, tssStatus, true, true, "List of Cheques", true);
        }

        internal static void RegistrationList(int projectId, string clientIds, ToolStripStatusLabel tssStatus)
        {
            ShowReport(new Clients.crptRegistrationList()
                , bllUnitRegistrationInfo.GetUnitRegistrationList(projectId, clientIds)
                , tssStatus, false, false, "Registration List", false);
        }

    }
}