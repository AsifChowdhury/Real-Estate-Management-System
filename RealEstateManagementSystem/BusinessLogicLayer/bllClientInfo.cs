using RealEstateManagementSystem.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using RealEstateManagementSystem.Utilities;

namespace RealEstateManagementSystem.BusinessLogicLayer
{
    [Serializable]
    public class PersonInformation
    {
        public int ClientId { get; set; }
        public string FullClientId { get; set; }
        public int ClientTypeId { get; set; }
        public string ClientType { get; set; }
        public bool UseSalutation { get; set; }
        public string ClientName_English { get; set; }
        public string ClientName_Bangla { get; set; }
        public string Gender { get; set; }
        public int GuardianTypeId { get; set; }
        public string GuardianType { get; set; }
        public string CareOf { get; set; }
        public string GuardianName_English { get; set; }
        public string GuardianName_Bangla { get; set; }
        public string FatherName_English { get; set; }
        public string FatherName_Bangla { get; set; }
        public string MotherName_English { get; set; }
        public string MotherName_Bangla { get; set; }
        public bool IsValidDateOfBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int MaritalStatusId { get; set; }
        public string MaritalStatus { get; set; }
        public bool IsValidMarriageDate { get; set; }
        public DateTime MarriageDate { get; set; }
        public string NationalIdNumber { get; set; }
        public string TINNumber { get; set; }
        public string PassportNumber { get; set; }
        public string CurrentAddress { get; set; }
        public int CurrentCountryId { get; set; }
        public string CurrentCountry { get; set; }
        public string PermanentAddress_Bangla { get; set; }
        public string PostalAddress { get; set; }
        public int PostalCountryId { get; set; }
        public string PostalCountry { get; set; }
        public string ContactNumber { get; set; }
        public string SMSContact { get; set; }
        public string EMailAddress { get; set; }
        public Image ClientPhoto { get; set; }
        public Image ClientSignature { get; set; }
        public bool NeedBankLoan { get; set; }
        public string Initial { get; set; }
        public bool IsReferredByClient { get; set; }
        public string Referrer { get; set; }
        public string SoldBy { get; set; }

        #region ClassReference
        public FinancialInstitute LoanProvider { get; set; }
        public NationalityReligionOccupation NationalityReligionOccupation { get; set; }
        public BookingAndPaymentSchedule BookingAndPaymentSchedule { get; set; }
        public SaleOffer SaleOffer { get; set; }
        public PartnerInformation PartnerInformation { get; set; }
        public EntryAndUpdateInfo EntryAndUpdateInfo { get; set; }
        #endregion

    }

    [Serializable]
    public class EntryAndUpdateInfo
    {
        public string EntryMadeBy { get; set; }
        public string LastUpdatedBy { get; set; }
    }

    [Serializable]
    public class PartnerInformation : PersonInformation
    {
        public int PartnerId { get; set; }
        public string PartnerName_English { get; set; }
        public string PartnerName_Bangla { get; set; }
        public NationalityReligionOccupation Partner_NOR { get; set; }
    }

    [Serializable]
    public class SaleOffer
    {
        public int SaleOfferId { get; set; }
        public string OfferName { get; set; }
        public string Remarks { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    [Serializable]
    public class FinancialInstitute
    {
        public int LoanProviderId { get; set; }
        public string LoanProviderName { get; set; }
        public string Recipient { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Initial { get; set; }
    }

    [Serializable]
    public class NationalityReligionOccupation
    {
        public int NationalityId { get; set; }
        public string Nationality { get; set; }
        public int ReligionId { get; set; }
        public string Religion { get; set; }
        public int OccupationId { get; set; }
        public string Occupation { get; set; }

    }

    [Serializable]
    public class BookingAndPaymentSchedule
    {
        public DateTime BookingDate { get; set; }
        public decimal BookingMoney { get; set; }
        public DateTime DownPaymentDate { get; set; }
        public decimal DownPayment { get; set; }
        public int NumberOfInstallment { get; set; }
        public decimal TotalSaleValue { get; set; }
        public int GapBetweenInstallment { get; set; }
        public int InstallmentId { get; set; }
        public int InstallmentAmount { get; set; }
        public DateTime DueDate { get; set; }
    }

    [Serializable]
    public class UnitInformation
    {
        public int UnitId { get; set; }
        public string UnitNumber { get; set; }
        public decimal SaleRate { get; set; }
        public decimal Rebate { get; set; }
        public decimal UnitArea { get; set; }
        public bool AreaEnabled { get; set; }
    }


    public class bllFinancialInstitute
    {
        dalFinancialInstitute dLayer = new dalFinancialInstitute();
        internal void GetFinancialInstituteInformation(FinancialInstitute fi)
        {
            try { dLayer.GetFinancialInstituteInformation(fi); }
            catch (Exception ex) { throw ex; }
        }

        internal void ManipulateFinancialInstitution(FinancialInstitute fi)
        {
            try
            {
                dLayer.ManipulateFinancialInstitution(fi);
            }
            catch (Exception ex) { throw ex; }
        }
    }

    public class bllSaleOffer
    {
        dalSaleOffer dLayer = new dalSaleOffer();

        internal void GetOfferData(SaleOffer so)
        {
            try { dLayer.GetOfferData(so); }
            catch (Exception ex) { throw ex; }

        }

        internal DataTable ListOfSaleOffers()
        {
            try { return dLayer.ListOfSaleOffer(); }
            catch (Exception ex) { throw ex; }
        }

        internal void SaveSaleOffer(SaleOffer so)
        {
            try { dLayer.SaveSaleOffer(so); }
            catch (Exception ex) { throw ex; }

        }
    }

    public class bllNOR
    {
        dalNOR dLayer = new dalNOR();
        internal void ManipulateNationality(NationalityReligionOccupation nor)
        {
            try
            {
                if (string.IsNullOrEmpty(nor.Nationality) == true) throw new ApplicationException("Please insert a valid Nationality.");
                dLayer.ManipulateNationality(nor.NationalityId, nor.Nationality);
            }
            catch (Exception ex) { throw ex; }
        }


        internal void ManipulateOccupation(NationalityReligionOccupation nor)
        {
            try
            {
                if (string.IsNullOrEmpty(nor.Occupation) == true) throw new ApplicationException("Please insert a valid Occupation.");
                dLayer.ManipulateOccupation(nor.OccupationId, nor.Occupation);
            }
            catch (Exception ex) { throw ex; }
        }

        internal void ManipulateReligion(NationalityReligionOccupation nor)
        {
            try
            {
                if (string.IsNullOrEmpty(nor.Religion) == true) throw new ApplicationException("Please insert a valid Religion.");
                dLayer.ManipulateReligion(nor.ReligionId, nor.Religion);
            }
            catch (Exception ex) { throw ex; }
        }
    }

    public class bllPartnerInformation
    {
        dalPartnerInformation dLayer = new dalPartnerInformation();
        internal void GetPartnerInformation(PartnerInformation pi)
        {
            dLayer.GetPartnerInformation(pi);
        }

        internal void ManipulatePartnerInformation(PartnerInformation pi)
        {
            dLayer.ManipulatePartnerInformation(pi);
        }

        internal void RemovePartner(int partnerId)
        {
            dLayer.RemovePartner(partnerId);
        }
    }


    public class bllAllocationAndInstallment
    {
        dalAllocationAndInstallment dLayer = new dalAllocationAndInstallment();
        internal DataTable GetListOfSaleableUnitsByUnitTypeFromProject(int projectId, int unitTypeId, bool includeLandOwnersUnits, string unitNumber = null)
        {
            return dLayer.GetListOfSaleableUnitsByUnitTypeFromProject(projectId, unitTypeId, includeLandOwnersUnits, unitNumber);
        }

        internal void GetUnitPricingDetails(UnitInformation u)
        {
            dLayer.GetUnitPricingDetails(u);
        }

        internal string CheckOralBooking(int unitId)
        {
            return dLayer.CheckOralBooking(unitId);
        }
        internal bool IsMasterUnit(int unitId)
        {
            return dLayer.IsMasterUnit(unitId);
        }

        /// <summary>
        /// Show and Manipulte regular installment schedule based on Booking Date, Total amount payable and number of schedule
        /// </summary>
        /// <param name="b">Booking and payment record</param>
        /// <param name="clientId">Client ID (Not needed if you just want to show value)</param>
        /// <param name="insert">Inserting new schedule (Not needed if you just want to show value)</param>
        /// <param name="update">Updating Existing schedule (Not needed if you just want to show value)</param>
        /// <returns></returns>
        internal DataTable ManipulteInstallmentSchedule(BookingAndPaymentSchedule b, int clientId = 0, bool insert = false, bool update = false)
        {
            try
            {
                if (b.BookingMoney < 0) { throw new ApplicationException("Please provide valid booking money amount."); }
                if (b.BookingDate > b.DownPaymentDate) { throw new ApplicationException("Down payment date cannot be greater than booking date."); }
                if (b.DownPayment < 0) { throw new ApplicationException("Please provide valid down payment amount."); }
                if (b.NumberOfInstallment <= 0) { throw new ApplicationException("Please provide valid number of installment. You have to provide at least 1(one) installment."); }
                //if (b.GapBetweenInstallment <= 0) { throw new ApplicationException("Please provide valid gap between two installment"); }
                return dLayer.ManipulteInstallmentSchedule(b, clientId, insert, update);

            }
            catch (Exception ex) { throw ex; }
        }

        internal DateTime GetApproximateCompletionDate(int projectId)
        {
            return dLayer.GetApproximateCompletionDate(projectId);
        }

        internal int CalculateNumberOfInstallment(int projectId)
        {
            return dLayer.CalculateNumberOfInstallment(projectId);
        }

        internal bool IsRegularPayment(int installmentId)
        {
            return dLayer.IsRegularPayment(installmentId);
        }

        internal DataTable GetAllocationList(int clientId)
        {
            return dLayer.GetAllocationList(clientId);
        }

        internal DataTable GetInstallmentDetails(int clientId)
        {
            return dLayer.GetInstallmentDetails(clientId);
        }

        internal void SaveAllocationAndInstallment(int clientId, IList<UnitInformation> allocationList, BookingAndPaymentSchedule regularInstallments, IList<BookingAndPaymentSchedule> otherInstallments)
        {
            dLayer.SaveAllocationAndInstallment(clientId, allocationList, regularInstallments, otherInstallments);
        }

        internal bool CheckIfRegularInstallment(int installmentId)
        {
            return dLayer.CheckIfRegularInstallment(installmentId);
        }

        internal void SaveOtherTypeInstallment(int clientId, IList<BookingAndPaymentSchedule> lstBP)
        {
            dLayer.SaveOtherTypeInstallment(clientId, lstBP);
        }
    }


    public class bllClientInfo
    {

        dalClientInfo dLayer = new dalClientInfo();

        internal string GetCareOfCaption(int guardianTypeId)
        {
            return dLayer.GetCareOfCaption(guardianTypeId);
        }

        internal bool GetImageAndOtherInfoOfClient(PersonInformation pi)
        {
            return dLayer.GetImageAndOtherInfoOfClient(pi);
        }

        internal DataTable GetListOfPartners(int clientId)
        {
            return dLayer.GetListOfPartners(clientId);
        }

        internal bool GetClientInformation(PersonInformation pi)
        {
            return dLayer.GetClientInformation(pi);
        }

        internal int SavePersonInformation(PersonInformation pi)
        {
            try
            {
                if (Utilities.clsCommonFunctions.IsValidEmail(pi.EMailAddress) == false)
                {
                    throw new ApplicationException("Please provide a valid EMail Address or leave email address field empty.");
                }
                return dLayer.SavePersonInformation(pi);
            }
            catch (Exception ex) { throw ex; }
        }

        internal clsGlobalClass.ClientStatus GetClientStatus(int clientId)
        {
            return dLayer.GetClientStatus(clientId);
        }

        internal DateTime GetBookingDate(int clientId)
        {
            return dLayer.GetBookingDate(clientId);
        }

        internal string GetUnitSummaryOfClient(int clientId, bool includeProjectName)
        {
            return dLayer.GetUnitSummaryOfClient(clientId, includeProjectName);
        }


        internal string CopyClientProfile(int clientId)
        {
            return dLayer.CopyClientProfile(clientId);
        }

        internal DataSet GetClientProfile(int clientId)
        {
            return dLayer.GetClientProfile(clientId);
        }

        internal bool IsRepNeeded(int clientTypeId)
        {
            return dLayer.IsRepNeeded(clientTypeId);
        }

        internal string GetClientType(int clientTypeId)
        {
            return dLayer.GetClientType(clientTypeId);
        }

        internal DataSet GetPaymentSchedule(int clientId)
        {
            return dLayer.GetPaymentSchedule(clientId);
        }
    }
}
