using RealEstateManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;

namespace RealEstateManagementSystem.DataAccessLayer
{

    public class dalFinancialInstitute
    {
        internal void GetFinancialInstituteInformation(FinancialInstitute fi)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM defLoanProvider WHERE ProviderId = @providerId";
                cmd.Parameters.AddWithValue("@providerId", fi.LoanProviderId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        fi.LoanProviderName = Convert.ToString(dr["ProviderName"]);
                        fi.Initial = Convert.ToString(dr["Initial"]);
                        fi.Address = Convert.ToString(dr["Address"]);
                        fi.Recipient = Convert.ToString(dr["Recipient"]);
                        fi.ContactNumber = Convert.ToString(dr["ContactNumber"]);
                    }
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal void ManipulateFinancialInstitution(FinancialInstitute fi)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateLoanProvider";
                cmd.Parameters.AddWithValue("@providerId", fi.LoanProviderId);
                cmd.Parameters.AddWithValue("@providerName", fi.LoanProviderName);
                cmd.Parameters.AddWithValue("@initial", fi.Initial.ReplaceEmptyStringWithNA());
                cmd.Parameters.AddWithValue("@address", fi.Address);
                cmd.Parameters.AddWithValue("@recipient", fi.Recipient);
                cmd.Parameters.AddWithValue("@contactNumber", fi.ContactNumber.ReplaceEmptyStringWithNA());
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }
    }

    public class dalSaleOffer
    {
        internal DataTable ListOfSaleOffer()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM SaleOffer ORDER BY StartDate DESC";
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }

        }

        internal void GetOfferData(SaleOffer so)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandText = "SELECT * FROM SaleOffer WHERE OfferId = @offerId";
                cmd.Parameters.AddWithValue("@offerId", so.SaleOfferId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        so.OfferName = Convert.ToString(dr["OfferName"]);
                        so.Remarks = Convert.ToString(dr["Remarks"]);
                        so.StartDate = Convert.ToString(dr["StartDate"]).ConvertToDateTime();
                        so.EndDate = Convert.ToString(dr["EndDate"]).ConvertToDateTime();
                    }
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }

        }

        internal void SaveSaleOffer(SaleOffer so)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateSaleOffer";
                cmd.Parameters.AddWithValue("@offerId", so.SaleOfferId);
                cmd.Parameters.AddWithValue("@offerName", so.OfferName);
                cmd.Parameters.AddWithValue("@remarks", so.Remarks);
                cmd.Parameters.AddWithValue("@startDate", so.StartDate);
                cmd.Parameters.AddWithValue("@endDate", so.EndDate);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }
    }

    public class dalNOR
    {
        internal void ManipulateNationality(int nationalityId, string nationality)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateNationality";
                cmd.Parameters.AddWithValue("@nationalityId", nationalityId);
                cmd.Parameters.AddWithValue("@nationality", nationality);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal void ManipulateReligion(int religionId, string religion)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateReligion";
                cmd.Parameters.AddWithValue("@religionId", religionId);
                cmd.Parameters.AddWithValue("@religion", religion);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal void ManipulateOccupation(int occupationId, string occupation)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateOccupation";
                cmd.Parameters.AddWithValue("@occupationId", occupationId);
                cmd.Parameters.AddWithValue("@occupation", occupation);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }
    }

    public class dalPartnerInformation
    {
        internal void GetPartnerInformation(PartnerInformation pi)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM PartnerDetails WHERE PartnerId = @partnerId";
                cmd.Parameters.AddWithValue("@partnerId", pi.PartnerId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        pi.PartnerName_English = Convert.ToString(dr["EngName"]).Trim();
                        pi.PartnerName_Bangla = Convert.ToString(dr["BangName"]).Trim();
                        pi.GuardianName_English = Convert.ToString(dr["EngGName"]).Trim();
                        pi.GuardianName_Bangla = Convert.ToString(dr["BangGName"]).Trim();
                        pi.FatherName_English = Convert.ToString(dr["EngFName"]).Trim();
                        pi.FatherName_Bangla = Convert.ToString(dr["BangFName"]).Trim();
                        pi.MotherName_English = Convert.ToString(dr["EngMName"]).Trim();
                        pi.MotherName_Bangla = Convert.ToString(dr["BangMName"]).Trim();
                        pi.Gender = Convert.ToString(dr["Gender"]);
                        pi.GuardianType = Convert.ToString(dr["GuardianType"]);
                        pi.CareOf = Convert.ToString(dr["CareOf"]).Trim();
                        pi.Partner_NOR = new NationalityReligionOccupation();
                        pi.Partner_NOR.Nationality = Convert.ToString(dr["Nationality"]);
                        pi.Partner_NOR.Religion = Convert.ToString(dr["Religion"]);
                        pi.Partner_NOR.Occupation = Convert.ToString(dr["Occupation"]);
                        pi.IsValidDateOfBirth = Convert.ToDateTime(dr["DOB"]).IsValidDate();
                        pi.DateOfBirth = Convert.ToDateTime(dr["DOB"]).ManageInvalidDate();
                        pi.MaritalStatus = Convert.ToString(dr["MStatus"]);
                        pi.IsValidMarriageDate = Convert.ToDateTime(dr["MarriageDate"]).IsValidDate();
                        pi.MarriageDate = Convert.ToDateTime(dr["MarriageDate"]).ManageInvalidDate();
                        pi.NationalIdNumber = Convert.ToString(dr["NationalIDNum"]).Trim();
                        pi.PassportNumber = Convert.ToString(dr["PassportNumber"]).Trim();
                        pi.TINNumber = Convert.ToString(dr["TINNumber"]).Trim();
                    }
                }

            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal void RemovePartner(int partnerId)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE PartnerInfo WHERE PartnerId = @partnerId";
                cmd.Parameters.AddWithValue("@partnerId", partnerId);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal void ManipulatePartnerInformation(PartnerInformation pi)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulatePartnerInformation";
                cmd.Parameters.AddWithValue("@partnerId", pi.PartnerId);
                cmd.Parameters.AddWithValue("@clientId", pi.ClientId);
                cmd.Parameters.AddWithValue("@partnerName_English", pi.PartnerName_English);
                cmd.Parameters.AddWithValue("@partnerName_Bangla", pi.PartnerName_Bangla);
                cmd.Parameters.AddWithValue("@guardianName_English", pi.GuardianName_English);
                cmd.Parameters.AddWithValue("@guardianName_Bangla", pi.GuardianName_Bangla);
                cmd.Parameters.AddWithValue("@fatherName_English", pi.FatherName_English);
                cmd.Parameters.AddWithValue("@fatherName_Bangla", pi.FatherName_Bangla);
                cmd.Parameters.AddWithValue("@motherName_English", pi.MotherName_English);
                cmd.Parameters.AddWithValue("@motherName_Bangla", pi.MotherName_Bangla);
                cmd.Parameters.AddWithValue("@gender", pi.Gender);
                cmd.Parameters.AddWithValue("@guardianTypeId", pi.GuardianTypeId);
                cmd.Parameters.AddWithValue("@nationalityId", pi.Partner_NOR.NationalityId);
                cmd.Parameters.AddWithValue("@occupationId", pi.Partner_NOR.OccupationId);
                cmd.Parameters.AddWithValue("@religionId", pi.Partner_NOR.ReligionId);
                cmd.Parameters.AddWithValue("@dateOfBirth", pi.IsValidDateOfBirth == true ? pi.DateOfBirth : clsGlobalClass.defaultDate);
                cmd.Parameters.AddWithValue("@maritalStatusId", pi.MaritalStatusId);
                cmd.Parameters.AddWithValue("@marriageDate", pi.IsValidMarriageDate == true ? pi.MarriageDate : clsGlobalClass.defaultDate);
                cmd.Parameters.AddWithValue("@nationalIdNumber", pi.NationalIdNumber);
                cmd.Parameters.AddWithValue("@TINNumber", pi.TINNumber);
                cmd.Parameters.AddWithValue("@PassportNumber", pi.PassportNumber);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }
    }

    public class dalAllocationAndInstallment
    {
        internal DataTable GetListOfSaleableUnitsByUnitTypeFromProject(int projectId, int unitTypeId, bool includeLandOwnersUnits, string unitNumber = null)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfSaleableUnitsByUnitTypeFromProject";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Parameters.AddWithValue("@unitTypeId", unitTypeId);
                cmd.Parameters.AddWithValue("@includeLandOwnersUnits", includeLandOwnersUnits);
                cmd.Parameters.AddWithValue("@unitNumber", unitNumber);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }
        internal void GetUnitPricingDetails(UnitInformation u)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT FlatNumber, Rate, Area, AreaEnabled FROM FlatDetails WHERE FlatId = @unitId";
                cmd.Parameters.AddWithValue("@unitId", u.UnitId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        u.UnitNumber = dr["FlatNumber"].ToString();
                        u.SaleRate = dr["Rate"].ToString().ConvertToInt32();
                        u.UnitArea = dr["Area"].ToString().ConvertToDecimal();
                        u.AreaEnabled = dr["AreaEnabled"].ToString().ConvertToBoolean();
                    }
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal string CheckOralBooking(int unitId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                string reservedBy = string.Empty;
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT TOP 1 BookedBy FROM OralBooking WHERE FlatId = @UnitId AND ReserveUpTo > GETDATE() AND Released = 0 ORDER BY ReserveUpTo DESC";
                cmd.Parameters.AddWithValue("@unitId", unitId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        reservedBy = dr["BookedBy"].ToString();
                    }
                }
                return reservedBy;

            }
            finally { if (dr != null) dr.Close(); cmd.Dispose(); }
        }

        internal DataTable ManipulteInstallmentSchedule(BookingAndPaymentSchedule b, int clientId = 0, bool insert = false, bool update = false)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateInstallment";
                cmd.Parameters.AddWithValue("@bookingDate", b.BookingDate);
                cmd.Parameters.AddWithValue("@downPaymentDate", b.DownPaymentDate);
                cmd.Parameters.AddWithValue("@totalUnitValue", b.TotalSaleValue);
                cmd.Parameters.AddWithValue("@bookingMoney", b.BookingMoney);
                cmd.Parameters.AddWithValue("@downPayment", b.DownPayment);
                cmd.Parameters.AddWithValue("@timeGap", b.GapBetweenInstallment);
                cmd.Parameters.AddWithValue("@numberOfInstallments", b.NumberOfInstallment);
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@insert", insert);
                cmd.Parameters.AddWithValue("@update", update);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workStation", clsGlobalClass.workStationIP);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal bool IsRegularPayment(int installmentId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            int installmentTypeId = 0;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT InstallTypeId FROM defInstallment WHERE InstallmentId = @installmentId";
                cmd.Parameters.AddWithValue("@installmentId", installmentId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        installmentTypeId = dr["InstallTypeId"].ToString().ConvertToInt32();
                    }
                }
                return installmentTypeId == 1 ? true : false;
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }
        internal bool IsMasterUnit(int unitId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            bool masterUnit = false;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_IsMasterUnit";
                cmd.Parameters.AddWithValue("@unitId", unitId);
                SqlParameter isMasterUnit = new SqlParameter("@isMasterUnit", SqlDbType.Bit);
                isMasterUnit.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(isMasterUnit);
                cmd.ExecuteNonQuery();
                masterUnit = isMasterUnit.Value.ToString().ConvertToBoolean();
                //dr = cmd.ExecuteReader();
                //if (dr.HasRows) { while (dr.Read()) { masterUnit = dr["IsMasterObject"].ToString().ConvertToBoolean(); } }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
            return masterUnit;
        }

        internal int CalculateNumberOfInstallment(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CalculateNumberOfInstallment";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                SqlParameter sp = new SqlParameter("@numberOfInstallment", SqlDbType.Int);
                sp.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(sp);
                cmd.ExecuteNonQuery();
                return sp.Value.ToString().ConvertToInt32();
            }
            finally { cmd.Dispose(); }
        }

        internal DateTime GetApproximateCompletionDate(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            DateTime dtApproximateCompletionDate = DateTime.Now;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Completion, HandOver FROM ProjectInfo WHERE ProjectId = @projectId";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dtApproximateCompletionDate = Convert.ToString(dr["Completion"]).ConvertToDateTime();
                    }
                }
                return dtApproximateCompletionDate > clsGlobalClass.considerAsNULLDate ? dtApproximateCompletionDate : clsGlobalClass.defaultDate;
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal DataTable GetAllocationList(int clientId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetAllocationListOfClient";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetInstallmentDetails(int clientId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetInstallmentDetails";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal bool CheckIfRegularInstallment(int installmentId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            bool isRegularType = true;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT InstallTypeId FROM defInstallment WHERE InstallmentId = @installmentId";
                cmd.Parameters.AddWithValue("@installmentId", installmentId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        isRegularType = dr["InstallTypeId"].ToString().ConvertToInt32() == 2 ? false : true;
                    }
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
            return isRegularType;
        }

        internal void SaveOtherTypeInstallment(int clientId, IList<BookingAndPaymentSchedule> lstBP)
        {
            SqlCommand cmd = Program.cnConn.CreateCommand();
            cmd.Connection = Program.cnConn;
            cmd.CommandType = CommandType.StoredProcedure;

            SqlTransaction transaction;
            transaction = Program.cnConn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {
                foreach (BookingAndPaymentSchedule bp in lstBP)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "sp_ManipulateInstallment_OtherType";
                    cmd.Parameters.AddWithValue("@clientId", clientId);
                    cmd.Parameters.AddWithValue("@installmentId", bp.InstallmentId);
                    cmd.Parameters.AddWithValue("@dueDate", bp.DueDate);
                    cmd.Parameters.AddWithValue("@amount", bp.InstallmentAmount);
                    cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                    cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                try { transaction.Rollback(); throw ex; }
                catch (Exception ex2) { throw ex2; }
            }
            finally { cmd.Dispose(); }
        }


        internal void SaveAllocationAndInstallment(int clientId, IList<UnitInformation> allocationList, BookingAndPaymentSchedule regularInstallments, IList<BookingAndPaymentSchedule> otherInstallments)
        {
            SqlCommand cmd = Program.cnConn.CreateCommand();
            cmd.Connection = Program.cnConn;
            SqlTransaction allocationAndInstallment = Program.cnConn.BeginTransaction();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Transaction = allocationAndInstallment;
            try
            {
                cmd.Parameters.Clear();
                #region Allocation
                foreach (UnitInformation allocation in allocationList)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_InsertAllocationData";
                    cmd.Parameters.AddWithValue("@unitId", allocation.UnitId);
                    cmd.Parameters.AddWithValue("@clientId", clientId);
                    cmd.Parameters.AddWithValue("@rebateAmount", allocation.Rebate);
                    cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                    cmd.Parameters.AddWithValue("@workStation", clsGlobalClass.workStationIP);
                    cmd.ExecuteNonQuery();
                }
                #endregion

                #region Regular Payment
                cmd.Parameters.Clear();
                cmd.CommandText = "sp_ManipulateInstallment";
                cmd.Parameters.AddWithValue("@bookingDate", regularInstallments.BookingDate);
                cmd.Parameters.AddWithValue("@downPaymentDate", regularInstallments.DownPaymentDate);
                cmd.Parameters.AddWithValue("@totalUnitValue", regularInstallments.TotalSaleValue);
                cmd.Parameters.AddWithValue("@bookingMoney", regularInstallments.BookingMoney);
                cmd.Parameters.AddWithValue("@downPayment", regularInstallments.DownPayment);
                cmd.Parameters.AddWithValue("@timeGap", regularInstallments.GapBetweenInstallment);
                cmd.Parameters.AddWithValue("@numberOfInstallments", regularInstallments.NumberOfInstallment);
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@insert", 1);
                cmd.Parameters.AddWithValue("@update", 0);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workStation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
                #endregion

                #region Other Payment
                foreach (BookingAndPaymentSchedule bp in otherInstallments)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "sp_ManipulateInstallment_OtherType";
                    cmd.Parameters.AddWithValue("@clientId", clientId);
                    cmd.Parameters.AddWithValue("@installmentId", bp.InstallmentId);
                    cmd.Parameters.AddWithValue("@dueDate", bp.DueDate);
                    cmd.Parameters.AddWithValue("@amount", bp.InstallmentAmount);
                    cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                    cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                    cmd.ExecuteNonQuery();
                }
                #endregion


                allocationAndInstallment.Commit();
            }
            catch (Exception ex)
            {
                try { allocationAndInstallment.Rollback(); throw ex; }
                catch (Exception ex2) { throw ex2; }
            }
        }

        internal void SaveAllocationData(int clientId, IList<UnitInformation> allocationList)
        {
            SqlCommand cmd = Program.cnConn.CreateCommand();
            cmd.Connection = Program.cnConn;
            SqlTransaction transaction = Program.cnConn.BeginTransaction();
            cmd.Transaction = transaction;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                foreach (UnitInformation allocation in allocationList)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_InsertAllocationData";
                    cmd.Parameters.AddWithValue("@unitId", allocation.UnitId);
                    cmd.Parameters.AddWithValue("@clientId", clientId);
                    cmd.Parameters.AddWithValue("@rebateAmount", allocation.Rebate);
                    cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                    cmd.Parameters.AddWithValue("@workStation", clsGlobalClass.workStationIP);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                try { transaction.Rollback(); throw ex; }
                catch (Exception ex2) { throw ex2; }
            }
            finally { cmd.Dispose(); }
        }
    }

    public class dalClientInfo
    {
        internal DataTable GetListOfPartners(int clientId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetPartnerInfo";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal bool GetImageAndOtherInfoOfClient(PersonInformation pi)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Photo, Signature, Referrer, Referredby, BankLoan, ProviderName, OfferName, SoldBy FROM PersonDetails WHERE ClientId = @clientId";
                cmd.Parameters.AddWithValue("@clientId", pi.ClientId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        pi.ClientPhoto = dr["Photo"] != DBNull.Value ? clsCommonFunctions.ImageFromByte(dr["Photo"]) : Properties.Resources.NoPhoto;
                        pi.ClientSignature = dr["Signature"] != DBNull.Value ? clsCommonFunctions.ImageFromByte(dr["Signature"]) : Properties.Resources.NoSign;
                        pi.NeedBankLoan = dr.HandleNULLString("BankLoan").ToUpper() == "YES" ? true : false;
                        pi.LoanProvider = new FinancialInstitute();
                        pi.LoanProvider.LoanProviderName = dr.HandleNULLString("ProviderName");
                        pi.Referrer = dr.HandleNULLString("Referrer");
                        pi.IsReferredByClient = dr.HandleNULLString("Referredby").ToUpper() == "SEL" ? false : true;
                        pi.SoldBy = dr.HandleNULLString("SoldBy");
                        pi.SaleOffer = new SaleOffer();
                        pi.SaleOffer.OfferName = dr.HandleNULLString("OfferName");
                    }
                }
                return dr.HasRows;
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal int SavePersonInformation(PersonInformation pi)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateClientInfo_PersonalInformation";
                cmd.Parameters.AddWithValue("@clientId", pi.ClientId);
                cmd.Parameters.AddWithValue("@clientTypeId", pi.ClientTypeId);
                cmd.Parameters.AddWithValue("@useSalutation", pi.UseSalutation);
                cmd.Parameters.AddWithValue("@name_English", pi.ClientName_English.Trim());
                cmd.Parameters.AddWithValue("@name_Bangla", pi.ClientName_Bangla.Trim());
                cmd.Parameters.AddWithValue("@gender", pi.Gender);
                cmd.Parameters.AddWithValue("@guardianTypeId", pi.GuardianTypeId);
                cmd.Parameters.AddWithValue("@guardianName_English", pi.GuardianName_English.Trim());
                cmd.Parameters.AddWithValue("@guardianName_Bangla", pi.GuardianName_Bangla.Trim());
                cmd.Parameters.AddWithValue("@fatherName_English", pi.FatherName_English.Trim());
                cmd.Parameters.AddWithValue("@fatherName_Bangla", pi.FatherName_Bangla.Trim());
                cmd.Parameters.AddWithValue("@motherName_English", pi.MotherName_English.Trim());
                cmd.Parameters.AddWithValue("@motherName_Bangla", pi.MotherName_Bangla.Trim());
                //pi.NationalityReligionOccupation = new NationalityReligionOccupation();
                cmd.Parameters.AddWithValue("@nationalityId", pi.NationalityReligionOccupation.NationalityId);
                cmd.Parameters.AddWithValue("@occupationId", pi.NationalityReligionOccupation.OccupationId);
                cmd.Parameters.AddWithValue("@relegionId", pi.NationalityReligionOccupation.ReligionId);
                cmd.Parameters.AddWithValue("@dateOfBirth", pi.IsValidDateOfBirth == true ? pi.DateOfBirth : clsGlobalClass.defaultDate);
                cmd.Parameters.AddWithValue("@maritalStatusId", pi.MaritalStatusId);
                cmd.Parameters.AddWithValue("@marriageDate", pi.IsValidMarriageDate == true ? pi.MarriageDate : clsGlobalClass.defaultDate);
                cmd.Parameters.AddWithValue("@nationalIdNumber", pi.NationalIdNumber.Trim().ReplaceEmptyStringWithNA());
                cmd.Parameters.AddWithValue("@TINNumber", pi.TINNumber.Trim().ReplaceEmptyStringWithNA());
                cmd.Parameters.AddWithValue("@passportNumber", pi.PassportNumber.ReplaceEmptyStringWithNA());
                cmd.Parameters.AddWithValue("@currentAddress", pi.CurrentAddress.Trim());
                cmd.Parameters.AddWithValue("@currentCountryId", pi.CurrentCountryId);
                cmd.Parameters.AddWithValue("@postalAddress", pi.PostalAddress.Trim());
                cmd.Parameters.AddWithValue("@postalCountryId", pi.PostalCountryId);
                cmd.Parameters.AddWithValue("@permanentAddress_Bangla", pi.PermanentAddress_Bangla.Trim());
                cmd.Parameters.AddWithValue("@contactNumber", pi.ContactNumber.Trim());
                cmd.Parameters.AddWithValue("@emailAddress", pi.EMailAddress);
                cmd.Parameters.AddWithValue("@smsContact", pi.SMSContact);
                cmd.Parameters.AddWithValue("@photo", clsCommonFunctions.ImageToByte(pi.ClientPhoto));
                cmd.Parameters.AddWithValue("@signature", clsCommonFunctions.ImageToByte(pi.ClientSignature));
                cmd.Parameters.AddWithValue("@needBankLoan", pi.NeedBankLoan == true ? "Yes" : "No");
                cmd.Parameters.AddWithValue("@loanProviderId", pi.LoanProvider.LoanProviderId);
                cmd.Parameters.AddWithValue("@saleOfferId", pi.SaleOffer.SaleOfferId);
                cmd.Parameters.AddWithValue("@referredBy", pi.IsReferredByClient == true ? "Client" : "SEL");
                cmd.Parameters.AddWithValue("@referrer", clsCommonFunctions.GetLogInIdFromEmployeeName(pi.Referrer));
                cmd.Parameters.AddWithValue("@soldBy", clsCommonFunctions.GetLogInIdFromEmployeeName(pi.SoldBy));
                cmd.Parameters.AddWithValue("@manipulatedBy", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@manipulatedFrom", clsGlobalClass.workStationIP);

                SqlParameter newClientId = new SqlParameter("@newClientId", SqlDbType.Int);
                newClientId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(newClientId);
                cmd.ExecuteNonQuery();
                return pi.ClientId == 0 ? newClientId.Value.ToString().ConvertToInt32() : 0;
            }
            finally { cmd.Dispose(); }
        }

        internal bool GetClientInformation(PersonInformation pi)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT   Salutation
                                           , ClientType
                                           , EngName
                                           , BangName
                                           , Gender
                                           , GuardianType
                                           , CareOf
                                           , EngGName
                                           , BangGName
                                           , EngFName
                                           , BangFName
                                           , EngMName
                                           , BangMName
                                           , Nationality
                                           , Religion
                                           , Occupation
                                           , DOB
                                           , MStatus
                                           , MarriageDate
                                           , NationalIdNum
                                           , PassportNumber
                                           , TINNumber
                                           , CurrentAddres
                                           , CurrentCountry
                                           , PostalContact
                                           , PostalCountry
                                           , BangPmtAddress
                                           , ContactNumber
                                           , EMail
                                           , SMSContact 
                                           , EntryMadeBy, EntryMadeOn, EntryMadeFrom
                                           , LastUpdatedBy, LastUpdatedOn, LastUpdatedFrom 
                                     FROM PersonDetails WHERE ClientId = @clientId";
                cmd.Parameters.AddWithValue("@clientId", pi.ClientId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        pi.UseSalutation = dr.HandleNULLBoolean("Salutation");
                        pi.ClientType = dr.HandleNULLString("ClientType");
                        pi.ClientName_English = dr.HandleNULLString("EngName").Trim();
                        pi.ClientName_Bangla = dr.HandleNULLString("BangName").Trim();
                        pi.Gender = dr.HandleNULLString("Gender");
                        pi.GuardianType = dr.HandleNULLString("GuardianType");
                        pi.CareOf = dr.HandleNULLString("CareOf");
                        pi.GuardianName_English = dr.HandleNULLString("EngGName").Trim();
                        pi.GuardianName_Bangla = dr.HandleNULLString("BangGName").Trim();
                        pi.FatherName_English = dr.HandleNULLString("EngFName").Trim();
                        pi.FatherName_Bangla = dr.HandleNULLString("BangFName").Trim();
                        pi.MotherName_English = dr.HandleNULLString("EngMName").Trim();
                        pi.MotherName_Bangla = dr.HandleNULLString("BangMName").Trim();
                        pi.NationalityReligionOccupation = new NationalityReligionOccupation();
                        pi.NationalityReligionOccupation.Nationality = dr.HandleNULLString("Nationality");
                        pi.NationalityReligionOccupation.Religion = dr.HandleNULLString("Religion");
                        pi.NationalityReligionOccupation.Occupation = dr.HandleNULLString("Occupation");
                        pi.IsValidDateOfBirth = dr.HandleNULLDateTime("DOB").returnFalseIfNullDate();
                        pi.DateOfBirth = dr.HandleNULLDateTime("DOB");
                        pi.MaritalStatus = dr.HandleNULLString("MStatus");
                        pi.IsValidMarriageDate = dr.HandleNULLDateTime("MarriageDate").returnFalseIfNullDate();
                        pi.MarriageDate = dr.HandleNULLDateTime("MarriageDate");
                        pi.NationalIdNumber = dr.HandleNULLString("NationalIdNum").Trim();
                        pi.PassportNumber = dr.HandleNULLString("PassportNumber").Trim();
                        pi.TINNumber = dr.HandleNULLString("TINNumber").Trim();
                        pi.CurrentAddress = dr.HandleNULLString("CurrentAddres").Trim();
                        pi.CurrentCountry = dr.HandleNULLString("CurrentCountry").Trim();
                        pi.PostalAddress = dr.HandleNULLString("PostalContact").Trim();
                        pi.PostalCountry = dr.HandleNULLString("PostalCountry").Trim();
                        pi.PermanentAddress_Bangla = dr.HandleNULLString("BangPmtAddress").Trim();
                        pi.ContactNumber = dr.HandleNULLString("ContactNumber").Trim();
                        pi.EMailAddress = dr.HandleNULLString("EMail").Trim();
                        pi.SMSContact = dr["SMSContact"] == DBNull.Value ? string.Empty : Convert.ToString(dr["SMSContact"]).Substring(4);
                        pi.EntryAndUpdateInfo = new EntryAndUpdateInfo();
                        pi.EntryAndUpdateInfo.EntryMadeBy = $"{dr.HandleNULLString("EntryMadeBy")} on {dr.HandleNULLDateTime("EntryMadeOn").ToString().ShowAsStandardDateFormat(true)} from {dr.HandleNULLString("EntryMadeFrom")}";
                        pi.EntryAndUpdateInfo.LastUpdatedBy = dr.HandleNULLString("LastUpdatedBy") == "N/A" ? "--" : dr.HandleNULLString("LastUpdatedBy") + " on " + dr.HandleNULLDateTime("LastUpdatedOn").ToString().ShowAsStandardDateFormat(true) + " from " + dr.HandleNULLString("LastUpdatedFrom");
                    }
                }
                return dr.HasRows;
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal string GetCareOfCaption(int guardianTypeId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            string careOf = string.Empty;
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = Program.cnConn;
                cmd.CommandText = "SELECT CareOf FROM defGuardianType WHERE GuardianTypeId = @gTypeId";
                cmd.Parameters.AddWithValue("@gTypeId", guardianTypeId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        careOf = dr["CareOf"].ToString() + ":";
                    }
                }
                return careOf;
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal clsGlobalClass.ClientStatus GetClientStatus(int clientId)
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetClientStatus";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                SqlParameter clientStatus = new SqlParameter("@clientStatus", SqlDbType.Int);
                clientStatus.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(clientStatus);
                cmd.ExecuteNonQuery();
                if (clientStatus.Value.ToString().ConvertToInt32() == 0)
                {
                    return clsGlobalClass.ClientStatus.Cancelled;
                }
                else if (clientStatus.Value.ToString().ConvertToInt32() == 1)
                {
                    return clsGlobalClass.ClientStatus.Active;
                }
                else
                {
                    return clsGlobalClass.ClientStatus.IncompleteProfile;
                }
            }
            finally { cmd.Dispose(); }

        }

        internal DateTime GetBookingDate(int clientId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            DateTime bookingDate = clsGlobalClass.defaultDate;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT BookingDate FROM ClientInfo WHERE ClientID = @clientID";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        bookingDate = dr["BookingDate"] == DBNull.Value ? DateTime.Now : Convert.ToString(dr["BookingDate"]).ConvertToDateTime();
                    }
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
            return bookingDate;
        }

        internal string GetUnitSummaryOfClient(int clientId, bool includeProjectName, bool includeParking = true)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            string unitSummary = string.Empty;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT dbo.fnGetUnitInfoOfClient(@clientId, @includeProjectName, @includeParking) AS UnitSummary";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@includeProjectName", includeProjectName);
                cmd.Parameters.AddWithValue("@includeParking", includeParking);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        unitSummary = Convert.ToString(dr["UnitSummary"]);
                    }
                }

            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
            return unitSummary;
        }


        internal string CopyClientProfile(int clientId)
        {
            SqlCommand cmd = new SqlCommand();
            string newClientId = string.Empty;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CopyClientProfile";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                SqlParameter prmClientId = new SqlParameter("@newClientId", SqlDbType.VarChar, 20);
                prmClientId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(prmClientId);
                cmd.ExecuteNonQuery();
                newClientId = Convert.ToString(prmClientId.Value);
            }
            finally { cmd.Dispose(); }
            return newClientId;
        }

        internal DataSet GetClientProfile(int clientId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_getClientProfile";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
            return ds;
        }

        internal bool IsRepNeeded(int clientTypeId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            bool repNeeded = false;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandText = "SELECT * FROM defClientType WHERE ClientTypeId = @clientTypeId";
                cmd.Parameters.AddWithValue("@clientTypeId", clientTypeId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        repNeeded = dr["NeedRepresentative"].ToString().ConvertToBoolean();
                    }
                }
                else
                {
                    repNeeded = false;
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
            return repNeeded;
        }

        internal string GetClientType(int clientTypeId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            string clientType = string.Empty;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandText = "SELECT * FROM defClientType WHERE ClientTypeId = @clientTypeId";
                cmd.Parameters.AddWithValue("@clientTypeId", clientTypeId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        clientType = dr["ClientType"].ToString();
                    }
                }
                else
                {
                    clientType = string.Empty;
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
            return clientType;
        }

        internal DataSet GetPaymentSchedule(string clientIds)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CalculatePaymentSchedule";
                cmd.Parameters.AddWithValue("@clientIDs", clientIds);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }

        }

        internal DataSet GetPaymentSchedule_Multiple(string clientIds)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CalculatePaymentSchedule_Multiple";
                cmd.Parameters.AddWithValue("@clientIds", clientIds);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal DataSet RegistrationAcknowledgementReceipt(string clientIds)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetRegistrationAcknowledgementReceipt";
                cmd.Parameters.AddWithValue("@clientIds", clientIds);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal DataSet GetAllotmentLetter(string clientIds, decimal monthlyRent)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetAllotmentLetter";
                cmd.Parameters.AddWithValue("@clientId", clientIds);
                cmd.Parameters.AddWithValue("@amountPayableAsRent", monthlyRent);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        
    }

    public class dalUnitRegistrationInfo
    {
        internal void GetClientRegistrationInfo(UnitRegistrationInfo ur)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;

            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetRegistiontationDataOfClient";
                cmd.Parameters.AddWithValue("@clientId", ur.ClientId);

                dr = cmd.ExecuteReader();

                if (!dr.HasRows) { throw new Exception(Resources.strNoData); }

                while (dr.Read())
                {
                    ur.FullClientId = dr.HandleNULLString("ClientId");
                    ur.ClientName_English = dr.HandleNULLString("Name");
                    ur.UnitSummary = dr.HandleNULLString("UnitSummary");
                    ur.RegistratrionDate = dr.HandleNULLDateTime("RegistrationDate");
                    ur.IsRegistered = ur.RegistratrionDate.returnFalseIfNullDate();
                    ur.LandArea = dr.HandleNULLDecimal("LandArea");
                    ur.Loan = dr.HandleNULLBoolean("Loan");
                    ur.DeedDeliveryDate = dr.HandleNULLDateTime("DeedDeliveryDate");
                    ur.IsDeedDelivered = ur.DeedDeliveryDate.returnFalseIfNullDate();
                    ur.DeedNumber = dr.HandleNULLInteger("DeedNumber");
                    ur.DeedValue = dr.HandleNULLDecimal("DeedValue");
                    ur.ITFee = dr.HandleNULLDecimal("ITFee");
                    ur.RegistrationFee = dr.HandleNULLDecimal("RegistrationFee");
                    ur.VAT = dr.HandleNULLDecimal("VAT");

                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal void SaveRegistrationData(UnitRegistrationInfo ur)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SaveClientRegistrationInfo";
                cmd.Parameters.AddWithValue("@clientId", ur.ClientId);
                cmd.Parameters.AddWithValue("@isRegistered", ur.IsRegistered);
                cmd.Parameters.AddWithValue("@registrationDate", ur.RegistratrionDate);
                cmd.Parameters.AddWithValue("@landArea", ur.LandArea);
                cmd.Parameters.AddWithValue("@loan", ur.Loan);
                cmd.Parameters.AddWithValue("@deedNumber", ur.DeedNumber);
                cmd.Parameters.AddWithValue("@isDeedDelivered", ur.IsDeedDelivered);
                cmd.Parameters.AddWithValue("@deedDeliveryDate", ur.DeedDeliveryDate);
                cmd.Parameters.AddWithValue("@deedValue", ur.DeedValue);
                cmd.Parameters.AddWithValue("@ITFee", ur.ITFee);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal static DataTable GetUnitRegistrationList(int projectId, string clientIds = null)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetUnitRegistrationList";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Parameters.AddWithValue("@clientIds", clientIds);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }
    }
}
