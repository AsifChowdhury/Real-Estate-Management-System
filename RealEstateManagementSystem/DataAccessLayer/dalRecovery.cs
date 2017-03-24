using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateManagementSystem.BusinessLogicLayer;
using System.Data.SqlClient;
using System.Data;
using RealEstateManagementSystem.Utilities;

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
                    }
                }
                else { throw new ApplicationException("Data not found"); }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }
    }

    class dalPayment
    {
        internal void InstallmentAlgorithm(int clientId, decimal dblPAmount, out int intLastInstallPayable, out string strInstallInWord)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InstallmentAlgorithm";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@dblPAmount", dblPAmount);
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

    }

    class dalRecovery
    {
    }
}
