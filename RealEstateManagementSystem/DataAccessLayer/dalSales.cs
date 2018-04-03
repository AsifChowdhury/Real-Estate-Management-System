using RealEstateManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagementSystem.DataAccessLayer
{
    class dalSales
    {

    }
    public class dalSummarizedSalesReport
    {
        internal DataTable GetPictorialDepictionOfSalesStatus(DateTime startDate, DateTime endDate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_PictorialDepictionOfSalesStatus";
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetSummarizedSalesReport(DateTime startDate, DateTime endDate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetSummarizedSalesReport";
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetListOfCanceledClient(bool isBookingDate, DateTime startDate, DateTime endDate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfCanceledClients";
                cmd.Parameters.AddWithValue("@isBookingDateRange", isBookingDate == true ? 1 : 0);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        

        internal DataTable GetSummaryOfSales(int salesYear)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM YearlySalesSummary_UnitCountAndTotalArea WHERE SaleYear = @salesYear ORDER BY SaleMonth";
                cmd.Parameters.AddWithValue("@salesYear", salesYear);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetAnnualSalesPosition(int salesYear)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetAnnualSalesPosition";
                cmd.Parameters.AddWithValue("@salesYear", salesYear);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetSalesPosition_Details(DateTime startDate, DateTime endDate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetSalesPosition";
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }


        internal DataTable GetCollectionsOfProject(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CollectionOfProjects";
                cmd.Parameters.AddWithValue("@searchBy", searchBy);
                cmd.Parameters.AddWithValue("@filterCriteria", filterCriteria);
                cmd.Parameters.AddWithValue("@filterBy", Convert.ToInt32(filterBy));
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }


        internal DataTable GetSummarizedSalesStatus(string searchBy, string filterCriteria, clsGlobalClass.ProjectCommonReport_FilterBy filterBy)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SummarizedSalesStatus";
                cmd.Parameters.AddWithValue("@searchBy", searchBy);
                cmd.Parameters.AddWithValue("@filterCriteria", filterCriteria);
                cmd.Parameters.AddWithValue("@filterBy", Convert.ToInt32(filterBy));
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }
    }
}
