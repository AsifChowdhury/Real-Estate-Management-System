using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateManagementSystem.BusinessLogicLayer;
using System.Data.SqlClient;

namespace RealEstateManagementSystem.DataAccessLayer
{
    class dalGlobal
    {
        internal DataTable GetListOfClients(bllGlobal b, bool includeCancelledClients = false)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ClientSearch";
                cmd.Parameters.AddWithValue("@projectId", b.ProjectId);
                cmd.Parameters.AddWithValue("@clientName", b.ClientName);
                cmd.Parameters.AddWithValue("@unitNumber", b.UnitNumber);
                cmd.Parameters.AddWithValue("@includeCancelledClients", includeCancelledClients);
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
            return dt;
        }

        internal DataTable GetCollectionData(DateTime startDate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetCollectionSummary";
                cmd.Parameters.AddWithValue("@startDate", startDate.Date);
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
            return dt;
        }

        internal DataTable GetCollectionDetails(DateTime startDate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Root_TransactionList";
                cmd.Parameters.AddWithValue("@startDate", startDate);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetRootCancelledList(DateTime startDate)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_root_CancelledList";
                cmd.Parameters.AddWithValue("@startDate", startDate);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetRootSoldList(DateTime startDate)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Root_SoldList";
                cmd.Parameters.AddWithValue("@startDate", startDate);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }

        }

        internal void GetSummaryDataForMainScreen(bllGlobal b)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetSummaryForMainScreen";
                cmd.Parameters.AddWithValue("@startDate", b.StartDate);
                SqlParameter spCollection = new SqlParameter("@collection", SqlDbType.Decimal, 0);
                spCollection.Direction = ParameterDirection.Output;
                spCollection.Value = 0;
                cmd.Parameters.Add(spCollection);

                SqlParameter spUnitSold = new SqlParameter("@unitSold", SqlDbType.Decimal, 0);
                spUnitSold.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(spUnitSold);
                spUnitSold.Value = 0;
                SqlParameter spUnitCancelled = new SqlParameter("@unitCancelled", SqlDbType.Decimal, 0);
                spUnitCancelled.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(spUnitCancelled);
                spUnitCancelled.Value = 0;
                cmd.ExecuteNonQuery();
                b.Collection = Convert.ToDecimal(spCollection.Value);
                b.UnitSold = Convert.ToDecimal(spUnitSold.Value);
                b.UnitCancelled = Convert.ToDecimal(spUnitCancelled.Value);

            }
            finally { cmd.Dispose(); }

        }
    }
}
