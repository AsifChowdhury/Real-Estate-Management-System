using RealEstateManagementSystem.DataAccessLayer;
using System;
using System.Data;
using RealEstateManagementSystem.Utilities;

namespace RealEstateManagementSystem.BusinessLogicLayer
{
    #region PropertyClasses

    public class CommonProperties_Recovery
    {
        public int ClientId { get; set; }
        public string FullClientId { get; set; }
        public string ClientName { get; set; }
        public string Allocation { get; set; }
        public string ContactNumber { get; set; }
        public DateTime BookingDate { get; set; }
        public string ReferredBy { get; set; }
        public string SoldBy { get; set; }
        public string ClientType { get; set; }
        public string ClientStatus { get; set; }
        public bool IsActiveClient { get; set; }
        public decimal FaceValue { get; set; }
        public decimal SaleValue { get; set; }
        public decimal Payable_Installment { get; set; }
        public decimal Paid_Installment { get; set; }
        public decimal Due_Installment { get; set; }
        public decimal Payable_OtherExpenses { get; set; }
        public decimal Paid_OtherExpenses { get; set; }
        public decimal Due_OtherExpenses { get; set; }
        public decimal Payable_AdjustableAmount { get; set; }
        public decimal Paid_AdjustableAmount { get; set; }
        public decimal Due_AdjustableAmount { get; set; }
        public decimal Payable_GrandTotal { get; set; }
        public decimal Paid_GrandTotal { get; set; }
        public decimal Due_GrandTotal { get; set; }
        public int NumberOfInvoices { get; set; }
        public int LastInvoiceNumber { get; set; }
        public decimal CurrentDue { get; set; }
        public int CountOfDueInstallment { get; set; }
        public int CountOfRegularInstallment { get; set; }
        public string RegistrationDate { get; set; }
        public bool IsKeyLetterProcessed { get; set; }
        public bool IsHandoverCertificateProcessed { get; set; }
        public string LoanChequeInfo { get; set; }

    }
    public class BankInfo
    {
        public int BankId { get; set; }
        public string BankName { get; set; }
        public EntryAndUpdateInfo EntryAndUPdate { get; set; }
    }
    public class BranchInfo
    {

        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public EntryAndUpdateInfo EntryAndUpdate { get; set; }
    }
    public class DistrictInfo
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
    }
    public class CountryInfo
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
    public class PaymentModeInfo
    {
        public int PaymentModeId { get; set; }
        public string PaymentModeName { get; set; }
        public string PaymentModeInitial { get; set; }
        public bool IsBankInfoNeeded { get; set; }
    }
    public class InstallTypeInfo
    {
        public int InstallTypeId { get; set; }
        public string InstallTypeName { get; set; }

    }
    public class InstallmentInfo
    {
        public int InstallmentId { get; set; }
        public string InstallmentName { get; set; }
        public float InstallmentAmount { get; set; }

    }
    public class Payment
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TransactionAmount { get; set; }
        public string Particulars { get; set; }
        public string Remarks { get; set; }
        public string BankAccountNumber { get; set; }
        public DateTime ParticularDate { get; set; }
        public string UpdateReason { get; set; }
        public string ReturnText { get; set; }
        public object PaymentStatusId { get; internal set; }
        public string PaymentStatus { get; set; }
        public object AlterReasonId { get; internal set; }
        public string AlterReason { get; internal set; }
        public DateTime PaymentStatusChangeDate { get; internal set; }
        public object CompnanyBankAccountId { get; internal set; }
        public string CompnanyBankAccount { get; internal set; }
        public InstallTypeInfo InstallType { get; set; }
        public InstallmentInfo Installment { get; set; }
        public bool IsRefundTransaction { get; set; }

        public BankInfo Bank { get; set; }
        public BranchInfo Branch { get; set; }
        public DistrictInfo District { get; set; }
        public CountryInfo Country { get; set; }
        public PaymentModeInfo PaymentMode { get; set; }
        public CommonProperties_Recovery CommonProperties { get; set; }

        public EntryAndUpdateInfo EntryAndUpdate { get; set; }
        
    }

    #endregion


    #region Business Logics
    public class bllCommonProperties_Recovery
    {
        dalCommonProperties_Recovery d = new dalCommonProperties_Recovery();
        internal void GetPaymentSummaryOfClient(CommonProperties_Recovery cpr)
        {
            d.GetPaymentSummaryOfClient(cpr);
        }
    }

    public class bllBankBranchDefinition
    {
        dalBankBranchDefinition def = new dalBankBranchDefinition();

        internal void GetBankInfo(BankInfo b)
        {
            def.GetBankInfo(b);
        }

        internal void GetBranchInfo(BranchInfo b)
        {
            def.GetBranchInfo(b);
        }

        internal DataTable GetListOfBanks()
        {
            return def.GetListOfBanks();
        }

        internal DataTable GetListOfBranches()
        {
            return def.GetListOfBranches();
        }

        internal void ManipulateBranchInfo(BranchInfo b)
        {
            def.ManipulateBranchInfo(b);
        }

        internal void ManipulateBankInfo(BankInfo b)
        {
            def.ManipulateBankInfo(b);
        }
    }

    public class bllPayment
    {
        dalPayment payment = new dalPayment();
        internal DataTable GetListOfPayments(int clientId)
        {
            return payment.GetListOfPayments(clientId);
        }

        internal DataSet GetKeyList(int clientId, int projectEngineer)
        {
            return payment.GetKeyList(clientId, projectEngineer);
        }

        internal DataSet GetHandoverCertificate(int clientId, DateTime handoverDate, int handoverBy, int forwardedBy, int recommendedBy)
        {
            return payment.GetHandoverCertificate(clientId, handoverDate, handoverBy, forwardedBy, recommendedBy);
        }

        internal DataTable InstallmentListOfClient(int clientId, int installmentTypeId)
        {
            return payment.InstallmentListOfClient(clientId, installmentTypeId);
        }

        internal DataSet GetPaymentClearanceCertificate(int clientId, int verifiedBy, int checkedBy, int recommnededBy)
        {
            return payment.GetPaymentClearanceCertificate(clientId, verifiedBy, checkedBy, recommnededBy);
        }

        internal Payment GetChequeInformation(int transactionId)
        {
            return payment.GetChequeInformation(transactionId);
        }

        internal void InstallmentAlgorithm(int clientId, decimal dblPAmount, int installmentId, int transactionId, out int lastInstallmentId, out string installInWord)
        {
            payment.InstallmentAlgorithm(clientId, dblPAmount, installmentId, transactionId, out lastInstallmentId, out installInWord);
        }

        internal void GetTransactionDetails(Payment transactionInfo)
        {
            payment.GetTransactionDetails(transactionInfo);
        }

        internal void GetPaymentModeDetails(PaymentModeInfo pMode)
        {
            payment.GetPaymentModeDetails(pMode);
        }

        internal decimal GetMaximumAmountPayable(int clientId, int installTypeId, int installmentId)
        {
            return payment.GetMaximumAmountPayable(clientId, installTypeId, installmentId);
        }

        internal void UpdateChequeStatus(Payment p)
        {
            payment.UpdateChequeStatus(p);
        }

        internal decimal AmountPayable(int clientId, int installmentId)
        {
            return payment.AmountPayable(clientId, installmentId);
        }

        internal int CommitTransaction(Payment p)
        {
            return payment.CommitTransaction(p);
        }

        internal bool IsBankInfoNeeded(int paymentModeId)
        {
            return payment.IsBankInfoNeeded(paymentModeId);
        }

        internal void DeleteTransaction(int transactionId)
        {
            payment.DeleteTransaction(transactionId);
        }

        internal DataSet GetMoneyReceipt(int transactionId, bool isDuplicate)
        {
            return payment.GetMoneyReceipt(transactionId, isDuplicate);
        }

        internal DataSet GetLoanDisbursementHistory(string clientIds)
        {
            return payment.GetLoanDisbursementHistory(clientIds);
        }

        internal decimal GetAmountPaidInTransaction(int transactionId)
        {
            return payment.GetAmountPaidInTransaction(transactionId);
        }

        internal DataSet GetPaymentHistoryOfClient(string clientIds)
        {
            return payment.GetPaymentHistoryOfClient(clientIds);
        }

        internal DataSet AcknowledgementReceipt(int transactionId)
        {
            return payment.AcknowledgementReceipt(transactionId);
        }

        internal DataTable GetListOfInstallmentsByInstallType(int clientId, int installTypeId)
        {
            return payment.GetListOfInstallmentsByInstallType(clientId, installTypeId);
        }

        internal int GetProjectIdFromProjectName(string projectName)
        {
            return payment.GetProjectIdFromProjectName(projectName);
        }

        internal int IsTransactionEdited(int transactionId)
        {
            return payment.IsTransactionEdited(transactionId);
        }

        internal DataTable GetTransactionUpdateHostory(int transactionId)
        {
            return payment.GetTransactionUpdateHistory(transactionId);
        }

        internal DataTable SearchChequeInformation(clsGlobalClass.ChequeSearchBy searchBy, int invoiceNumber, int clientId, int bankId, DateTime startDate, DateTime endDate, bool excludeReceived, bool excludeCashTransactions)
        {
            return payment.SearchChequeInformation(searchBy, invoiceNumber, clientId, bankId, startDate, endDate, excludeReceived, excludeCashTransactions);
        }

        internal DataSet GetPaymentComparison(string clientId)
        {
            return payment.GetPaymentComparison(clientId);
        }

        internal void ManipulateOAInstallment(int clientId, InstallmentInfo i)
        {
            payment.ManipulateOAInstallment(clientId, i);
        }

        internal DataSet GetPaymentHistoryOfClient_WithBankAccount(string clientIds)
        {
            return payment.GetPaymentHistoryOfClient_WithBankAccount(clientIds);
        }

        internal DataTable GetPaymentSummaryOfClient_ByInstallment(string clientId)
        {
            return payment.GetPaymentSummaryOfClient_ByInstallment(clientId);
        }

        internal DataTable GetSummartForPaymentClearance(int clientId)
        {
            return payment.GetSummartForPaymentClearance(clientId);
        }

        internal bool IsHandoverCertficateDelivered(int clientId)
        {
            return payment.IsHandoverCertficateDelivered(clientId);
        }

        internal bool IsKeyListDelivered(int clientId)
        {
            return payment.IsKeyListDelivered(clientId);
        }
    }

    public static class bllRecoveryReports
    {
        internal static DataTable GetProjectValuation(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, DateTime dateUpTo)
        {
            return dalRecoveryReports.GetProjectValuation(searchBy, filterCriteria, filterBy, dateUpTo);
        }

        internal static DataTable GetRefundAmount(string searchBy, string filterCriteria,
            clsGlobalClass.ProjectCommonReport_FilterBy filterBy, int? installmentId = null, DateTime? startDate = null,
            DateTime? endDate = null)
        {
            return dalRecoveryReports.GetRefundAmount(searchBy, filterCriteria, filterBy, installmentId, startDate, endDate);
        }

        internal static DataTable GetTransactionSummary(int month, int year)
        {
            return dalRecoveryReports.GetTransactionSummary(month, year);
        }

        internal static DataTable GetRecoveryPosition(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy)
        {
            return dalRecoveryReports.GetRecoveryPosition(searchBy, filterCriteria, filterBy);
        }

        internal static DataTable GetComparePaymentStatus(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, DateTime startDate, DateTime endDate)
        {
            return dalRecoveryReports.GetComparePaymentStatus(searchBy, filterCriteria, filterBy, startDate, endDate);
        }

        internal static DataTable GetRegistrationCompletionList(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, DateTime startDate, DateTime endDate)
        {
            return dalRecoveryReports.GetRegistrationCompletionList(searchBy, filterCriteria, filterBy, startDate, endDate);
        }

        internal static DataTable GetAnnualRecoveryPosition(string saleYears)
        {
            return dalRecoveryReports.GetAnnualRecoveryPosition(saleYears);
        }

        internal static DataTable GetListOfClientsByCurrentDue(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, decimal minimumDue, decimal maximumDue)
        {
            return dalRecoveryReports.GetListOfClientsByCurrentDue(searchBy, filterCriteria, filterBy, minimumDue,
                maximumDue);
        }

        public static DataTable GetMonthlyRecoveryPosition(int month, int year, decimal targetAmount, decimal installmentDue, decimal bdPaymentDue, string analysis, bool isNewEntry)
        {
            return dalRecoveryReports.GetMonthlyRecoveryPosition(month, year, targetAmount, installmentDue, bdPaymentDue, analysis, isNewEntry);
        }

        public static bool IsMRPDataAvailable(int month, int year)
        {

            return dalRecoveryReports.IsMRPDataAvailable(month, year);
        }

        public static DataTable GetAnnualAgreementList(string reportYears)
        {
            return dalRecoveryReports.GetAnnualAgreementList(reportYears);
        }
    }

    #endregion


}
