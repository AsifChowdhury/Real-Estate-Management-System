using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateManagementSystem.BusinessLogicLayer;
using System.Data.SqlClient;
using System.Data;
using RealEstateManagementSystem.Utilities;
using System.Windows.Forms;

namespace RealEstateManagementSystem.DataAccessLayer
{

    class dalBankBranchDefinition
    {
        internal DataTable GetListOfBanks()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT BankId, BankName FROM defBank ORDER BY BankName";
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetListOfBranches()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT BranchId, BranchName FROM defBranch ORDER BY BranchName";
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal void GetBankInfo(BankInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT BankName FROM defBank WHERE BankId = @bankId";
                cmd.Parameters.AddWithValue("@bankId", b.BankId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        b.BankName = Convert.ToString(dr["BankName"]);
                    }
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal void ManipulateBankInfo(BankInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateBankInfo";
                cmd.Parameters.AddWithValue("@bankId", b.BankId);
                cmd.Parameters.AddWithValue("@bankName", b.BankName);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workStation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal void GetBranchInfo(BranchInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT BranchName FROM defBranch WHERE BranchId = @branchId";
                cmd.Parameters.AddWithValue("@branchId", b.BranchId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        b.BranchName = Convert.ToString(dr["BranchName"]);
                    }
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal void ManipulateBranchInfo(BranchInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateBranchInfo";
                cmd.Parameters.AddWithValue("@branchId", b.BranchId);
                cmd.Parameters.AddWithValue("@branchName", b.BranchName);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workStation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }
    }

    class dalCommonProperties_Recovery
    {
        internal void GetPaymentSummaryOfClient(CommonProperties_Recovery cpr)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetPaymentSummaryOfClient";
                cmd.Parameters.AddWithValue("@clientId", cpr.ClientId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cpr.FullClientId = Convert.ToString(dr["ClientId"]);
                        cpr.ClientName = Convert.ToString(dr["ClientName"]);
                        cpr.Allocation = Convert.ToString(dr["Allocation"]);
                        cpr.BookingDate = Convert.ToDateTime(dr["BookingDate"]);
                        cpr.ContactNumber = Convert.ToString(dr["ContactNumber"]);
                        cpr.FaceValue = Convert.ToDecimal(dr["FaceValue"]);
                        cpr.SaleValue = Convert.ToDecimal(dr["SaleValue"]);
                        cpr.ReferredBy = Convert.ToString(dr["ReferredBy"]);
                        cpr.SoldBy = Convert.ToString(dr["SoldBy"]);

                        cpr.Payable_Installment = Convert.ToDecimal(dr["Installment_Payable"]);
                        cpr.Paid_Installment = Convert.ToDecimal(dr["Installment_Paid"]);
                        cpr.Due_Installment = cpr.Payable_Installment - cpr.Paid_Installment;


                        cpr.Payable_OtherExpenses = Convert.ToDecimal(dr["OtherExpenses_Payable"]);
                        cpr.Paid_OtherExpenses = Convert.ToDecimal(dr["OtherExpenses_Paid"]);
                        cpr.Due_OtherExpenses = cpr.Payable_OtherExpenses - cpr.Paid_OtherExpenses;

                        cpr.Payable_AdjustableAmount = Convert.ToDecimal(dr["AdjustableAmount_Payable"]);
                        cpr.Paid_AdjustableAmount = Convert.ToDecimal(dr["AdjustableAmount_Paid"]);
                        cpr.Due_AdjustableAmount = cpr.Payable_AdjustableAmount - cpr.Paid_AdjustableAmount;

                        cpr.Payable_GrandTotal = cpr.Payable_Installment + cpr.Payable_OtherExpenses + cpr.Payable_AdjustableAmount;
                        cpr.Paid_GrandTotal = cpr.Paid_Installment + cpr.Paid_OtherExpenses + cpr.Paid_AdjustableAmount;
                        cpr.Due_GrandTotal = cpr.Due_Installment + cpr.Due_OtherExpenses + cpr.Due_AdjustableAmount;

                        cpr.NumberOfInvoices = Convert.ToInt32(dr["NumberOfInvoices"]);
                        cpr.LastInvoiceNumber = Convert.ToInt32(dr["LastInvoiceNumber"]);
                        cpr.CurrentDue = Convert.ToDecimal(dr["CurrentDue"]);
                        cpr.CountOfDueInstallment = Convert.ToInt32(dr["NumberOfDue"]);
                        cpr.CountOfRegularInstallment = Convert.ToInt32(dr["CountOfInstallment"]);
                        cpr.ClientStatus = Convert.ToString(dr["StatusName"]);
                        cpr.IsActiveClient = Convert.ToString(dr["IsAllowed"]).ConvertToBoolean();
                        cpr.ClientType = Convert.ToString(dr["ClientType"]);

                        cpr.RegistrationDate = dr["RegistrationDate"] != DBNull.Value ? Convert.ToString(dr["RegistrationDate"]).ShowAsStandardDateFormat() : string.Empty;
                        cpr.IsKeyLetterProcessed = Convert.ToString(dr["KeyLetter"]).ConvertToBoolean();
                        cpr.IsHandoverCertificateProcessed = Convert.ToString(dr["Handover"]).ConvertToBoolean();
                        cpr.LoanChequeInfo = Convert.ToString(dr["LoanCheckInfo"]);
                    }
                }
                else { throw new ApplicationException("Data not found"); }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }
    }

    class dalPayment
    {
        internal void InstallmentAlgorithm(int clientId, decimal dblPAmount, int installmentId, int transactionId, out int intLastInstallPayable, out string strInstallInWord)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InstallmentAlgorithm";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@dblPAmount", dblPAmount);
                cmd.Parameters.AddWithValue("@installmentId", installmentId);
                cmd.Parameters.AddWithValue("@transactionId", transactionId);
                SqlParameter lastInstall = new SqlParameter("@lastInstallmentId", SqlDbType.Int);
                lastInstall.Direction = ParameterDirection.Output;
                lastInstall.Value = 0;
                cmd.Parameters.Add(lastInstall);
                SqlParameter installInWord = new SqlParameter("@installInWord", SqlDbType.NVarChar, 500);
                installInWord.Direction = ParameterDirection.Output;
                installInWord.Value = string.Empty;
                cmd.Parameters.Add(installInWord);
                cmd.ExecuteNonQuery();
                strInstallInWord = installInWord.Value.ToString();
                intLastInstallPayable = lastInstall.Value.ToString().ConvertToInt32();
            }
            finally { cmd.Dispose(); }
        }

        internal DataSet GetPaymentComparison(string clientId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_PaymentComparison";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal DataTable GetSummartForPaymentClearance(int clientId)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_PaymentSummaryForClearance";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal bool IsKeyListDelivered(int clientId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT KeyLetterId FROM KeyLetter WHERE ClientId = @clientId";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                dr = cmd.ExecuteReader();
                return dr.HasRows;
            }
            finally { cmd.Dispose(); if (dr != null) { dr.Close(); } }
        }

        internal bool IsHandoverCertficateDelivered(int clientId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT HOCId FROM HOCLetter WHERE ClientId = @clientId";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                dr = cmd.ExecuteReader();
                return dr.HasRows;
            }
            finally { cmd.Dispose(); if (dr != null) { dr.Close(); } }
        }

        internal DataTable GetPaymentSummaryOfClient_ByInstallment(string clientId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetPaymentSummaryOfClient_ByInstallment";
                cmd.Parameters.AddWithValue("@clientId", clsCommonFunctions.GetNumericPartOfFullClientId(clientId));
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataSet GetPaymentHistoryOfClient_WithBankAccount(string clientIds)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetPaymentHistoryOfClient_WithAccountNumber";
                cmd.Parameters.AddWithValue("@clientIds", clientIds);
                cmd.Parameters.AddWithValue("@signedBy", clsGlobalClass.userId);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal void ManipulateOAInstallment(int clientId, InstallmentInfo i)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (i.InstallmentAmount <= 0) { throw new ApplicationException("Installment amount cannot be less than zero"); }

                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateOAInstallment";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@installmentId", i.InstallmentId);
                cmd.Parameters.AddWithValue("@amount", i.InstallmentAmount);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal DataTable SearchChequeInformation(clsGlobalClass.ChequeSearchBy searchBy, int invoiceNumber, int clientId, int bankId, DateTime startDate, DateTime endDate, bool excludeReceived, bool excludeCashTransactions)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SearchClientCheckInformation";
                string strSearchBy = string.Empty;
                switch (searchBy)
                {
                    case clsGlobalClass.ChequeSearchBy.Invoice: strSearchBy = "Invoice"; break;
                    case clsGlobalClass.ChequeSearchBy.ClientId: strSearchBy = "ClientId"; break;
                    case clsGlobalClass.ChequeSearchBy.Bank: strSearchBy = "Bank"; break;
                    case clsGlobalClass.ChequeSearchBy.DateRange: strSearchBy = "DateRange"; break;
                    default: break;
                }
                cmd.Parameters.AddWithValue("@searchBy", strSearchBy);
                cmd.Parameters.AddWithValue("@invoiceNumber", invoiceNumber);
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@bankId", bankId);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                cmd.Parameters.AddWithValue("@excludeReceived", excludeReceived);
                cmd.Parameters.AddWithValue("@excludeCashTransactions", excludeCashTransactions);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }

        }

        internal DataTable GetTransactionUpdateHistory(int transactionId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetTransactionUpdateHistory";
                cmd.Parameters.AddWithValue("@transactionId", transactionId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal void GetPaymentModeDetails(PaymentModeInfo pMode)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandText = "SELECT * FROM defPaymentMode WHERE PaymentModeId = @paymentModeId";
                cmd.Parameters.AddWithValue("@paymentModeId", pMode.PaymentModeId);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pMode.PaymentModeName = Convert.ToString(dr["PaymentMode"]);
                    pMode.PaymentModeInitial = Convert.ToString(dr["PaymentInitial"]);
                    pMode.IsBankInfoNeeded = Convert.ToBoolean(dr["NeedBankInfo"]);
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal decimal AmountPayable(int clientId, int installmentId)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetAmountPayableByInstallment";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@installmentId", installmentId);
                SqlParameter payable = new SqlParameter("@amountPayable", SqlDbType.Float);
                payable.Value = 0;
                payable.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(payable);
                cmd.ExecuteNonQuery();
                return payable.Value.ToString().ConvertToDecimal();
            }
            finally { cmd.Dispose(); }
        }

        internal decimal GetMaximumAmountPayable(int clientid, int installTypeId, int installmentId)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetMaximumAmountPayable";
                cmd.Parameters.AddWithValue("@clientId", clientid);
                cmd.Parameters.AddWithValue("@installTypeId", installTypeId);
                cmd.Parameters.AddWithValue("@installmentId", installmentId);
                SqlParameter maxAmount = new SqlParameter("@maxAmountPayable", SqlDbType.Float);
                maxAmount.Value = 0;
                maxAmount.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(maxAmount);
                cmd.ExecuteNonQuery();
                return maxAmount.Value.ToString().ConvertToDecimal();
            }
            finally { cmd.Dispose(); }
        }

        internal void GetTransactionDetails(Payment transactionInfo)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetTransactionDetails";
                cmd.Parameters.AddWithValue("@transactionId", transactionInfo.TransactionId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        transactionInfo.InstallType = new InstallTypeInfo();
                        transactionInfo.InstallType.InstallTypeName = Convert.ToString(dr["InstallType"]);
                        transactionInfo.Installment = new InstallmentInfo();
                        transactionInfo.Installment.InstallmentName = Convert.ToString(dr["InstallmentName"]);
                        transactionInfo.PaymentMode = new PaymentModeInfo();
                        transactionInfo.PaymentMode.PaymentModeName = Convert.ToString(dr["PaymentMode"]);
                        transactionInfo.TransactionAmount = Convert.ToDecimal(dr["AmountPaid"]);
                        transactionInfo.TransactionDate = Convert.ToDateTime(dr["TransactionDate"]);
                        transactionInfo.Particulars = Convert.ToString(dr["Particulars"]);
                        transactionInfo.ParticularDate = Convert.ToDateTime(dr["ChequeDate"]);
                        transactionInfo.BankAccountNumber = Convert.ToString(dr["BankAccountNumber"]);
                        transactionInfo.Remarks = Convert.ToString(dr["Remarks"]);
                        transactionInfo.UpdateReason = Convert.ToString(dr["UpdateReason"]);
                        transactionInfo.Bank = new BankInfo();
                        transactionInfo.Bank.BankName = Convert.ToString(dr["BankName"]);
                        transactionInfo.Branch = new BranchInfo();
                        transactionInfo.Branch.BranchName = Convert.ToString(dr["BranchName"]);
                        transactionInfo.District = new DistrictInfo();
                        transactionInfo.District.DistrictName = Convert.ToString(dr["DistrictName"]);
                        transactionInfo.Country = new CountryInfo();
                        transactionInfo.Country.CountryName = Convert.ToString(dr["CountryName"]);
                        transactionInfo.IsRefundTransaction = Convert.ToString(dr["IsRefund"]).ConvertToBoolean();
                    }
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal DataTable GetListOfPayments(int clientId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfPayment";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable InstallmentListOfClient(int clientId, int installmentTypeId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetInstallmentListOfClient";
                cmd.Parameters.AddWithValue("@clientid", clientId);
                cmd.Parameters.AddWithValue("@installTypeId", installmentTypeId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal bool IsBankInfoNeeded(int paymentModeId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            bool isNeeded = false;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT NeedBankInfo FROM defPaymentMode WHERE PaymentModeId = @paymentModeId";
                cmd.Parameters.AddWithValue("@paymentModeId", paymentModeId);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    isNeeded = dr["NeedBankInfo"].ToString().ConvertToBoolean();
                }
                return isNeeded;
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal int CommitTransaction(Payment p)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateTransaction";
                SqlParameter transactionId = new SqlParameter("@transactionId", p.TransactionId);
                transactionId.Direction = ParameterDirection.InputOutput;
                cmd.Parameters.Add(transactionId);
                cmd.Parameters.AddWithValue("@clientId", p.CommonProperties.ClientId);
                cmd.Parameters.AddWithValue("@transactionDate", p.TransactionDate);
                cmd.Parameters.AddWithValue("@amountPaid", p.TransactionAmount);
                cmd.Parameters.AddWithValue("@chequeDate", p.ParticularDate);
                cmd.Parameters.AddWithValue("@particulars", p.Particulars);
                cmd.Parameters.AddWithValue("@remarks", p.Remarks);
                cmd.Parameters.AddWithValue("@installmentId", p.Installment.InstallmentId);
                cmd.Parameters.AddWithValue("@paymentModeId", p.PaymentMode.PaymentModeId);
                cmd.Parameters.AddWithValue("@bankId", p.Bank.BankId);
                cmd.Parameters.AddWithValue("@branchId", p.Branch.BranchId);
                cmd.Parameters.AddWithValue("@districtId", p.District.DistrictId);
                cmd.Parameters.AddWithValue("@countryId", p.Country.CountryId);
                cmd.Parameters.AddWithValue("@returnText", p.ReturnText);
                cmd.Parameters.AddWithValue("@bankAccountNumber", p.BankAccountNumber);
                cmd.Parameters.AddWithValue("@updateReason", p.UpdateReason);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workStation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
                return transactionId.Value.ToString().ConvertToInt32();
            }
            finally { cmd.Dispose(); }
        }

        internal void DeleteTransaction(int transactionId)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeleteTransaction";
                cmd.Parameters.AddWithValue("@transactionId", transactionId);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workStation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal DataSet GetMoneyReceipt(int transactionId, bool isDuplicate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetMoneyReciept";
                cmd.Parameters.AddWithValue("@transactionId", transactionId);
                cmd.Parameters.AddWithValue("@isDuplicate", isDuplicate);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal decimal GetAmountPaidInTransaction(int transactionId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            decimal amountPaid = 0;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT AmountPaid FROM [Transaction] WHERE TransactionId = @transactionId";
                cmd.Parameters.AddWithValue("@transactionId", transactionId);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    amountPaid = Convert.ToDecimal(dr["AmountPaid"]);
                }
                return amountPaid;
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal DataSet GetPaymentHistoryOfClient(string clientIds)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetPaymentHistoryOfClient";
                cmd.Parameters.AddWithValue("@clientIds", clientIds);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal DataSet AcknowledgementReceipt(int transactionId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetAcknowledgementReceipt";
                cmd.Parameters.AddWithValue("@transactionId", transactionId);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal DataTable GetListOfInstallmentsByInstallType(int clientId, int installTypeId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfInstallmentsByInstallType";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@installTypeId", installTypeId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal int GetProjectIdFromProjectName(string projectName)
        {
            SqlCommand cmd = new SqlCommand();
            int projectId = 0;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetProjectIdFromProjectName";
                cmd.Parameters.AddWithValue("@projectName", projectName);
                SqlParameter pId = new SqlParameter("@projectId", SqlDbType.Int);
                pId.Direction = ParameterDirection.Output;
                pId.Value = 0;
                cmd.Parameters.Add(pId);
                cmd.ExecuteNonQuery();
                projectId = Convert.ToInt32(pId.Value);
                return projectId;
            }
            finally { cmd.Dispose(); }
        }

        internal int IsTransactionEdited(int transactionId)
        {
            SqlCommand cmd = new SqlCommand();
            int numberOfEdits = 0;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_IsTransactionEdited";
                cmd.Parameters.AddWithValue("@transactionId", transactionId);
                SqlParameter edited = new SqlParameter("@numberOfEdits", SqlDbType.Int);
                edited.Value = 0;
                edited.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(edited);
                cmd.ExecuteNonQuery();
                numberOfEdits = Convert.ToInt32(edited.Value);
                return numberOfEdits;
            }
            finally { cmd.Dispose(); }
        }

        internal DataSet GetLoanDisbursementHistory(string clientIds)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_LoanDisbursementHistory";
                cmd.Parameters.AddWithValue("@clientIds", clientIds);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal DataSet GetPaymentClearanceCertificate(int clientId, int verifiedBy, int checkedBy, int recommendedBy)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_PaymentComparison";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@verifiedBy", verifiedBy);
                cmd.Parameters.AddWithValue("@checkedBy", checkedBy);
                cmd.Parameters.AddWithValue("@recommendedBy", recommendedBy);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal DataSet GetKeyList(int clientId, int projectEngineer)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetKeyLetter";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@pe_CompanyId", projectEngineer);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal DataSet GetHandoverCertificate(int clientId, DateTime handoverDate, int handoverBy, int forwardedBy, int recommendedBy)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetHandoverCertificate";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@processDate", handoverDate);
                cmd.Parameters.AddWithValue("@preparedBy", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@handoverBy", handoverBy);
                cmd.Parameters.AddWithValue("@forwardedBy", forwardedBy);
                cmd.Parameters.AddWithValue("@RecommendedBy", recommendedBy);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal Payment GetChequeInformation(int transactionId)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            Payment p = new Payment();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetChequeInformation";
                cmd.Parameters.AddWithValue("@transactionId", transactionId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    p.TransactionId = Convert.ToInt32(dt.Rows[0]["TransactionId"]);
                    p.AlterReason = Convert.ToString(dt.Rows[0]["AlterReason"]);
                    p.PaymentStatus = Convert.ToString(dt.Rows[0]["PaymentStatus"]);
                    p.PaymentStatusChangeDate = Convert.ToDateTime(dt.Rows[0]["StatusDate"]);
                    p.CompnanyBankAccount = Convert.ToString(dt.Rows[0]["CompanyAccount"]);
                }
                else
                {
                    p.TransactionId = transactionId;
                    p.AlterReason = string.Empty;
                    p.PaymentStatus = string.Empty;
                    p.PaymentStatusChangeDate = DateTime.Now;
                    p.CompnanyBankAccount = string.Empty;
                }
                return p;
            }
            finally { cmd.Dispose(); da.Dispose(); };
        }

        internal void UpdateChequeStatus(Payment p)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateChequeStatus";
                cmd.Parameters.AddWithValue("@transactionId", p.TransactionId);
                cmd.Parameters.AddWithValue("@statusId", p.PaymentStatusId);
                cmd.Parameters.AddWithValue("@reasonId", p.AlterReasonId);
                cmd.Parameters.AddWithValue("@statusDate", p.PaymentStatusChangeDate);
                cmd.Parameters.AddWithValue("@companyAccountId", p.CompnanyBankAccountId);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workStation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }
    }


    public static class dalRecoveryReports
    {
        internal static DataTable GetProjectValuation(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, DateTime dateUpTo)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetProjectValuation";
                cmd.Parameters.AddWithValue("@searchBy", searchBy);
                cmd.Parameters.AddWithValue("@filterCriteria", filterCriteria);
                cmd.Parameters.AddWithValue("@filterBy", (int)filterBy);
                cmd.Parameters.AddWithValue("@dateUpTo", dateUpTo);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal static DataTable GetRecoveryPosition(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_RecoveryPosition";
                cmd.Parameters.AddWithValue("@searchBy", searchBy);
                cmd.Parameters.AddWithValue("@filterCriteria", filterCriteria);
                cmd.Parameters.AddWithValue("@filterBy", (int)filterBy);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal static DataTable GetRefundAmount(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, int? installmentId = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetRefundTransactionHistory";
                cmd.Parameters.AddWithValue("@searchBy", searchBy);
                cmd.Parameters.AddWithValue("@filterCriteria", filterCriteria);
                cmd.Parameters.AddWithValue("@filterBy", (int)filterBy);
                cmd.Parameters.AddWithValue("@installmentId", installmentId);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal static DataTable GetTransactionSummary(int month, int year)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetTransactionSummary";
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal static DataTable GetComparePaymentStatus(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, DateTime startDate, DateTime endDate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ComparePayment";
                cmd.Parameters.AddWithValue("@searchBy", searchBy);
                cmd.Parameters.AddWithValue("@filterCriteria", filterCriteria);
                cmd.Parameters.AddWithValue("@filterBy", (int)filterBy);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal static DataTable GetRegistrationCompletionList(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, DateTime startDate, DateTime endDate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_RegistrationCompletionList";
                cmd.Parameters.AddWithValue("@searchBy", searchBy);
                cmd.Parameters.AddWithValue("@filterCriteria", filterCriteria);
                cmd.Parameters.AddWithValue("@filterBy", (int)filterBy);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        public static DataTable GetAnnualRecoveryPosition(string saleYears)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_AnnualRecoveryPosition";
                cmd.Parameters.AddWithValue("@years", saleYears);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal static DataTable GetListOfClientsByCurrentDue(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy, decimal minimumDue, decimal maximumDue)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ClientListByCurrentDue";
                cmd.Parameters.AddWithValue("@searchBy", searchBy);
                cmd.Parameters.AddWithValue("@filterCriteria", filterCriteria);
                cmd.Parameters.AddWithValue("@filterBy", (int)filterBy);
                cmd.Parameters.AddWithValue("@minimumDue", minimumDue);
                cmd.Parameters.AddWithValue("@maximumDue", maximumDue);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        public static DataTable GetMonthlyRecoveryPosition(int month, int year, decimal targetAmount, decimal installmentDue, decimal bdPaymentDue, string analysis, bool isNewEntry)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetMRPValues";
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@targetAmount", targetAmount);
                cmd.Parameters.AddWithValue("@installmentDue", installmentDue);
                cmd.Parameters.AddWithValue("@bdPaymentDue", bdPaymentDue);
                cmd.Parameters.AddWithValue("@analysis", analysis);
                cmd.Parameters.AddWithValue("@preparedBy", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@entryMadeFrom", clsGlobalClass.workStationIP);
                cmd.Parameters.AddWithValue("@isNewEntry", isNewEntry);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        public static bool IsMRPDataAvailable(int month, int year)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_IsMRPDataAvailable";
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);
                SqlParameter isAvailable = new SqlParameter
                {
                    ParameterName = "@isAvailable",
                    Direction = ParameterDirection.Output,
                    SqlDbType = SqlDbType.Bit
                };
                cmd.Parameters.Add(isAvailable);
                cmd.ExecuteNonQuery();
                return Convert.ToBoolean(isAvailable.Value);
            }
            finally { cmd.Dispose(); }
        }

        public static DataTable GetAnnualAgreementList(string reportYears)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetAnnualAgreementStatus";
                cmd.Parameters.AddWithValue("@years", reportYears);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }
    }


    class dalRecovery
    {
    }
}
