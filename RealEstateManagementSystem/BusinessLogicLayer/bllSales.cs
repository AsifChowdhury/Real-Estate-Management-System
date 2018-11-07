using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateManagementSystem.DataAccessLayer;
using RealEstateManagementSystem.Utilities;

namespace RealEstateManagementSystem.BusinessLogicLayer
{


    public class bllSales
    {

    }

    public class bllSummarizedSalesReport
    {
        internal DataTable GetPictorialDepictionOfSalesStatus(DateTime startDate, DateTime endDate)
        {
            dalSummarizedSalesReport sales = new dalSummarizedSalesReport();
            return sales.GetPictorialDepictionOfSalesStatus(startDate, endDate);
        }

        internal DataTable GetSalesReportByRep(DateTime startDate, DateTime endDate, bool showDetails, string repId)
        {
            dalSummarizedSalesReport d = new dalSummarizedSalesReport();
            return d.GetSalesReportByRep(startDate, endDate, showDetails, repId);
        }

        internal DataTable GetSalesPosition_Details(DateTime startDate, DateTime endDate)
        {
            dalSummarizedSalesReport sales = new dalSummarizedSalesReport();
            return sales.GetSalesPosition_Details(startDate, endDate);

        }

        internal DataTable GetSummarizedSalesReport(DateTime startDate, DateTime endDate)
        {
            dalSummarizedSalesReport summary = new dalSummarizedSalesReport();
            return summary.GetSummarizedSalesReport(startDate, endDate);
        }

        internal DataTable GetAnnualSalesPosition(int salesYear)
        {
            dalSummarizedSalesReport annualData = new dalSummarizedSalesReport();
            return annualData.GetAnnualSalesPosition(salesYear);
        }

        internal DataTable GetSummaryOfSales(int salesYear)
        {
            dalSummarizedSalesReport summary = new dalSummarizedSalesReport();
            return summary.GetSummaryOfSales(salesYear);
        }

        internal DataTable GetListOfCanceledClients(bool isBookingDate, DateTime startDate, DateTime endDate)
        {
            dalSummarizedSalesReport canceledClient = new dalSummarizedSalesReport();
            return canceledClient.GetListOfCanceledClient(isBookingDate, startDate, endDate);
        }

        internal DataTable GetCollectionsOfProject(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy)
        {
            dalSummarizedSalesReport collection = new dalSummarizedSalesReport();
            return collection.GetCollectionsOfProject(searchBy, filterCriteria, filterBy);
        }

        //internal DataTable GetSummarizedSalesStatus(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy)
        //{
        //    dalSummarizedSalesReport status = new dalSummarizedSalesReport();
        //    return status.GetSummarizedSalesStatus(searchBy, filterCriteria, filterBy);
        //}

        internal DataTable GetSummarizedSalesStatus(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy)
        {
            dalSummarizedSalesReport status = new dalSummarizedSalesReport();
            return status.GetSummarizedSalesStatus(searchBy, filterCriteria, filterBy);
        }
    }
}
