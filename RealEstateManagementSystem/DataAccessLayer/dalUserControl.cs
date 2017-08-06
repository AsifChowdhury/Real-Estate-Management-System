using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;
using RealEstateManagementSystem.Utilities;

namespace RealEstateManagementSystem.DataAccessLayer
{
    class dalUserControl
    {
        internal bool ValidateUserLogIn(bllUserControl b)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandText = "sp_ValidateREMSUserLogIn";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userId", b.UserId);
                cmd.Parameters.AddWithValue("@password", b.Password);
                cmd.Parameters.AddWithValue("@applicationId", clsGlobalClass.applicationId);
                cmd.Parameters.AddWithValue("@version", clsGlobalClass.currentVersion);
                cmd.Parameters.AddWithValue("@terminal", clsGlobalClass.workStationIP);
                SqlParameter isValid = new SqlParameter("@isValid", SqlDbType.Bit);
                isValid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(isValid);
                cmd.ExecuteNonQuery();

                b.IsValidLogIn = (bool)isValid.Value;
                return b.IsValidLogIn;
            }
            finally { cmd.Dispose(); }
        }

        internal DataTable GetListOfAuthenticatedUsers(bool authorizedOnly)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfAuthenticatedUsers_ByApp";
                cmd.Parameters.AddWithValue("@applicationId", Resources.ApplicationId);
                cmd.Parameters.AddWithValue("@returnAuthorizedOnly", authorizedOnly);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataSet GetActiveMenuList()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ApplicationMenuPermissionDetails WHERE EmpId=@empId AND IsAllowed=1 AND ApplicationId=@applicationId";
                cmd.Parameters.AddWithValue("@applicationId", Resources.ApplicationId);
                cmd.Parameters.AddWithValue("@empId", clsGlobalClass.userId);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal void SetAppAuthentication(string userId, bool isAllowed)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "prcSetAppAuthentication";

                cmd.Parameters.AddWithValue("@applicationId", Resources.ApplicationId);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@isAllowed", isAllowed == true ? 1 : 0);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally { cmd.Dispose(); }

        }

        internal void ManipulateApplicationMenu(string menuKey)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "prcManipulateApplicationMenu";
                cmd.Parameters.AddWithValue("@applicationId", Resources.ApplicationId);
                cmd.Parameters.AddWithValue("@menuKey", menuKey);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal DataTable GetListOfAuthorizedUsers_ByMenuKey(string menuKey)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfAuthenticatedUsers_ByMenuKey";
                cmd.Parameters.AddWithValue("@applicationId", Resources.ApplicationId);
                cmd.Parameters.AddWithValue("@menuKey", menuKey);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }


        internal void SetAppMenuAuthentication(string menuKey, string userId, bool isAllowed)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "prcSetAppMenuAuthentication";
                cmd.Parameters.AddWithValue("@applicationId", Resources.ApplicationId);
                cmd.Parameters.AddWithValue("@menuKey", menuKey);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@isAllowed", isAllowed == true ? 1 : 0);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally { cmd.Dispose(); }
        }


        internal void GetUserDetails(bllUserControl b)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_getUserInfo";
                cmd.Parameters.AddWithValue("@userId", b.UserId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        b.EmployeeName = dr["Name"].ToString();
                        b.CurrentPosition = dr["CurrentPosition"].ToString();
                    }
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Dispose(); }
        }
    }
}
