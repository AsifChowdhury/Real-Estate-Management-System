using RealEstateManagementSystem.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagementSystem.BusinessLogicLayer
{
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
        public InstallTypeInfo InstallType { get; set; }

        public InstallmentInfo Installment { get; set; }
        public bool IsRefundTransaction { get; set; }

        public BankInfo Bank { get; set; }
        public BranchInfo Branch { get; set; }
        public DistrictInfo District { get; set; }
        public CountryInfo Country { get; set; }
        public PaymentModeInfo PaymentMode { get; set; }

        public EntryAndUpdateInfo EntryAndUpdate { get; set; }
    }

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


        internal DataTable InstallmentListOfClient(int clientId, int installmentTypeId)
        {
            return payment.InstallmentListOfClient(clientId, installmentTypeId);
        }

        internal void InstallmentAlgorithm(int clientId, decimal dblPAmount, out int lastInstallmentId, out string installInWord)
        {
            payment.InstallmentAlgorithm(clientId, dblPAmount, out lastInstallmentId, out installInWord);
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

        internal decimal AmountPayable(int clientId, int installmentId)
        {
            return payment.AmountPayable(clientId, installmentId);
        }
    }


}
