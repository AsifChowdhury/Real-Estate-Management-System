using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RealEstateManagementSystem.BusinessLogicLayer;

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
                SqlParameter isValid = new SqlParameter("@isValid", SqlDbType.Bit);
                isValid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(isValid);
                cmd.ExecuteNonQuery();

                b.IsValidLogIn = (bool)isValid.Value;
                return b.IsValidLogIn;
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Dispose(); }
        }

        internal void GetUserDetails(bllUserControl b)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Name, CurrentPosition FROM EmployeeDetails WHERE CompanyId = (SELECT PFNumber FROM Employee WHERE EmpId=@userId)";
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
            catch (Exception ex) { throw ex; }
            finally { cmd.Dispose(); dr.Dispose(); }
        }
    }
}
