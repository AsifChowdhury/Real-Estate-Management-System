using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using RealEstateManagementSystem.Utilities;

namespace RealEstateManagementSystem.DataAccessLayer
{
    class dalProjectInfo
    {

        internal DataSet PopulateListOfAreas(string districtName)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT AreaId, AreaName FROM AreaDetails WHERE DistrictName = @districtName";
                cmd.Parameters.AddWithValue("@districtName", districtName);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }



        internal DataTable PopulateLocationDetails(string districtName)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT LocationId, LocationName, AreaName, DistrictName FROM LocationDetails WHERE DistrictName = @districtName ORDER BY LocationName";
                cmd.Parameters.AddWithValue("@districtName", districtName);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }

        internal DataSet PopulateProjectsCombo(clsGlobalClass.ProjectStatus projectStatus)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = projectStatus != clsGlobalClass.ProjectStatus.All ?
                                  "SELECT ProjectId, ProjectName FROM ProjectDetails WHERE ProjectStatus = @projectStatus ORDER BY ProjectName" :
                                  "SELECT ProjectId, ProjectName FROM ProjectDetails ORDER BY ProjectName";
                cmd.Parameters.AddWithValue("@projectStatus", projectStatus.ToString());
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal void GetProjectDetails(BusinessLogicLayer.bllProjectInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ProjectDetails WHERE ProjectId = @projectId";
                cmd.Parameters.AddWithValue("@projectId", b.ProjectId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        b.ProjectLocation = dr["ProjectLocation"].ToString();
                        b.ProjectCode = Convert.ToInt32(dr["ProjectCode"].ToString());

                        b.ProjectName = dr["ProjectName"].ToString();
                        b.ProjectName_InBangla = dr["ProjectName_Bangla"].ToString();
                        b.ProjectAddress = dr["Address"].ToString();
                        b.ProjectAddress_InBangla = dr["Address_Bangla"].ToString();

                        b.AgreementSignDate = clsCommonFunctions.ReturnIfValidDate(Convert.ToDateTime(dr["AgreementSign"].ToString()));
                        b.IsAgreementSigned = clsCommonFunctions.CheckIfValidDate(Convert.ToDateTime(dr["AgreementSign"].ToString()));

                        b.PlotTakeOverDate = clsCommonFunctions.ReturnIfValidDate(Convert.ToDateTime(dr["PlotTakeOverDate"].ToString()));
                        b.IsPlotTakenOver = clsCommonFunctions.CheckIfValidDate(Convert.ToDateTime(dr["PlotTakeOverDate"].ToString()));
                        b.ConstructionDuration = Convert.ToInt32(dr["ConstructionDuration"].ToString());
                        b.ConstructionGracePeriod = Convert.ToInt32(dr["ConstructionGracePeriod"].ToString());

                        b.ConstructionStartedOn = clsCommonFunctions.ReturnIfValidDate(Convert.ToDateTime(dr["StartedOn"].ToString()));
                        b.IsConstructionStarted = clsCommonFunctions.CheckIfValidDate(Convert.ToDateTime(dr["StartedOn"].ToString()));

                        b.SaleStartedOn = clsCommonFunctions.ReturnIfValidDate(Convert.ToDateTime(dr["SaleStartedOn"].ToString()));
                        b.IsSaleStarted = clsCommonFunctions.CheckIfValidDate(Convert.ToDateTime(dr["SaleStartedOn"].ToString()));

                        b.EstimatedHandoverDate = clsCommonFunctions.ReturnIfValidDate(Convert.ToDateTime(dr["Completion"].ToString()));
                        b.IsEstimatedHandoverDateSet = clsCommonFunctions.CheckIfValidDate(Convert.ToDateTime(dr["Completion"].ToString()));

                        b.HandoverDate = clsCommonFunctions.ReturnIfValidDate(Convert.ToDateTime(dr["Handover"].ToString()));
                        b.IsHandedOver = clsCommonFunctions.CheckIfValidDate(Convert.ToDateTime(dr["Handover"].ToString()));

                        b.ProjectType = dr["ProjectType"].ToString();
                        b.LandType = dr["LandType"].ToString();
                        b.LandArea = Convert.ToDecimal(dr["Area"].ToString());

                        b.GeoLocation = dr["GeoLocation"].ToString();

                        b.ApprovalDate = clsCommonFunctions.ReturnIfValidDate(Convert.ToDateTime(dr["ApprovalDate"].ToString()));
                        b.IsProjectApproved = clsCommonFunctions.CheckIfValidDate(Convert.ToDateTime(dr["ApprovalDate"].ToString()));
                        b.ApprovalNumber = dr["RAJUKNumber"].ToString();

                        b.Remarks = dr["Remarks"].ToString();

                        b.ProjectInCharge = dr["ICName"].ToString();
                        b.ProjectArchitect = dr["ArchName"].ToString();
                        b.ProjectStructuralDesigner = dr["SDName"].ToString();
                        b.ProjectSignatory = dr["Name"].ToString();

                        b.IsAvailableInDB = Convert.ToBoolean(dr["EntryAvailable"].ToString() == "1" ? true : false);


                        b.IsPilingNeeded = Convert.ToBoolean(dr["Pile"].ToString() == "1" ? true : false);

                        b.IsVisibleInWeb = Convert.ToBoolean(dr["ShowInWeb"].ToString() == "1" ? true : false);

                        b.IsCancelledProject = Convert.ToBoolean(dr["IsCanceledProject"].ToString() == "1" ? true : false);

                    }
                }
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Dispose(); dr.Dispose(); }
        }

        internal DataTable GetListOfProjectSpecifications(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT SpecName [SpecificationType], SpecDetails [Details] from ProjectSpecification WHERE ProjectId = @projectId ORDER BY [Sequence]";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataTable GetListOfBuildingsInProject(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT BuildingId ,BNumber, FloorInformation FROM BuildingNumber WHERE ProjectId=@projectId";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }
    }
}
