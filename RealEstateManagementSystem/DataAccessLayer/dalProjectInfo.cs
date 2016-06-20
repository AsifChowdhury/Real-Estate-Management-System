using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using RealEstateManagementSystem.Utilities;
using RealEstateManagementSystem.BusinessLogicLayer;

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
                        b.ProjectCode = dr["ProjectCode"] != DBNull.Value ? Convert.ToInt32(dr["ProjectCode"].ToString()) : 0;

                        b.ProjectName = dr["ProjectName"].ToString();
                        b.ProjectName_InBangla = dr["ProjectName_Bangla"].ToString();
                        b.ProjectAddress = dr["Address"].ToString();
                        b.ProjectAddress_InBangla = dr["Address_Bangla"].ToString();

                        b.AgreementSignDate = clsCommonFunctions.ReturnIfValidDate(Convert.ToDateTime(dr["AgreementSign"].ToString()));
                        b.IsAgreementSigned = clsCommonFunctions.CheckIfValidDate(Convert.ToDateTime(dr["AgreementSign"].ToString()));

                        b.PlotTakeOverDate = clsCommonFunctions.ReturnIfValidDate(Convert.ToDateTime(dr["PlotTakeOverDate"].ToString()));
                        b.IsPlotTakenOver = clsCommonFunctions.CheckIfValidDate(Convert.ToDateTime(dr["PlotTakeOverDate"].ToString()));
                        b.ConstructionDuration = dr["ConstructionDuration"] != DBNull.Value ? Convert.ToInt32(dr["ConstructionDuration"].ToString()) : 0;
                        b.ConstructionGracePeriod = dr["ConstructionGracePeriod"] != DBNull.Value ? Convert.ToInt32(dr["ConstructionGracePeriod"].ToString()) : 0;

                        b.ConstructionStartedOn = clsCommonFunctions.ReturnIfValidDate(Convert.ToDateTime(dr["StartedOn"].ToString()));
                        b.IsConstructionStarted = clsCommonFunctions.CheckIfValidDate(Convert.ToDateTime(dr["StartedOn"].ToString()));

                        b.SaleStartedOn = clsCommonFunctions.ReturnIfValidDate(Convert.ToDateTime(dr["SaleStartedOn"].ToString()));
                        b.IsSaleStarted = clsCommonFunctions.CheckIfValidDate(Convert.ToDateTime(dr["SaleStartedOn"].ToString()));

                        b.EstimatedHandoverDate = clsCommonFunctions.ReturnIfValidDate(Convert.ToDateTime(dr["Completion"].ToString()));
                        b.IsEstimatedHandoverDateSet = clsCommonFunctions.CheckIfValidDate(Convert.ToDateTime(dr["Completion"].ToString()));

                        b.ActualHandoverDate = clsCommonFunctions.ReturnIfValidDate(Convert.ToDateTime(dr["Handover"].ToString()));
                        b.IsHandedOver = clsCommonFunctions.CheckIfValidDate(Convert.ToDateTime(dr["Handover"].ToString()));

                        b.ProjectType = dr["ProjectType"].ToString();
                        b.LandType = dr["LandType"].ToString();
                        b.LandArea = dr["Area"] != DBNull.Value ? Convert.ToDecimal(dr["Area"].ToString()) : 0;

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

        internal void ManipulateProjectInfo(bllProjectInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "prcManipulateProjectInfo";
                cmd.Parameters.AddWithValue("@projectId", b.ProjectId);
                cmd.Parameters.AddWithValue("@projectName", b.ProjectName);
                cmd.Parameters.AddWithValue("@projectName_Bangla", b.ProjectName_InBangla);
                cmd.Parameters.AddWithValue("@address", b.ProjectAddress);
                cmd.Parameters.AddWithValue("@address_Bangla", b.ProjectAddress_InBangla);
                cmd.Parameters.AddWithValue("@locationId", b.LocationId);
                cmd.Parameters.AddWithValue("@inChargeId", b.InChargeId);
                cmd.Parameters.AddWithValue("@architectId", b.ArchitectId);
                cmd.Parameters.AddWithValue("@structuralDesignerId", b.ProjectStructuralDesignerId);
                cmd.Parameters.AddWithValue("@area", b.LandArea);
                cmd.Parameters.AddWithValue("@remarks", b.Remarks);
                cmd.Parameters.AddWithValue("@plotTakeover", b.IsPlotTakenOver == true ? b.PlotTakeOverDate : clsGlobalClass.defaultDate);
                cmd.Parameters.AddWithValue("@agreementSign", b.IsAgreementSigned == true ? b.AgreementSignDate : clsGlobalClass.defaultDate);
                cmd.Parameters.AddWithValue("@startedOn", b.IsConstructionStarted == true ? b.ConstructionStartedOn : clsGlobalClass.defaultDate);
                cmd.Parameters.AddWithValue("@approvalDate", b.IsProjectApproved == true ? b.ApprovalDate : clsGlobalClass.defaultDate);
                cmd.Parameters.AddWithValue("@constructionDuration", b.ConstructionDuration);
                cmd.Parameters.AddWithValue("@constructionGracePeriod", b.ConstructionGracePeriod);
                cmd.Parameters.AddWithValue("@saleStartedOn", b.IsSaleStarted == true ? b.SaleStartedOn : clsGlobalClass.defaultDate);
                cmd.Parameters.AddWithValue("@approxCompletion", b.IsEstimatedHandoverDateSet == true ? b.EstimatedHandoverDate : clsGlobalClass.defaultDate);
                cmd.Parameters.AddWithValue("@handoverDate", b.IsHandedOver == true ? b.ActualHandoverDate : clsGlobalClass.defaultDate);
                cmd.Parameters.AddWithValue("@landTypeId", b.LandTypeId);
                cmd.Parameters.AddWithValue("@projectCode", b.ProjectCode);
                cmd.Parameters.AddWithValue("@entryAvailable", b.IsAvailableInDB == true ? 1 : 0);
                cmd.Parameters.AddWithValue("@showInWeb", b.IsVisibleInWeb == true ? 1 : 0);
                cmd.Parameters.AddWithValue("@geoLocation", b.GeoLocation);
                cmd.Parameters.AddWithValue("@SignatoryId", b.ProjectSignatoryId);
                cmd.Parameters.AddWithValue("@pile", b.IsPilingNeeded == true ? 1 : 0);
                cmd.Parameters.AddWithValue("@isCancelledProject", b.IsCancelledProject == true ? 1 : 0);
                cmd.Parameters.AddWithValue("@projectTypeId", b.ProjectTypeId);
                cmd.Parameters.AddWithValue("@rajukNumber", b.ApprovalNumber);
                cmd.Parameters.AddWithValue("@manipulatedBy", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@manipulatedFrom", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
        }

        internal void GetProjectSpecificationDetails(bllProjectInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ProjectSpecification WHERE ProjectId = @projectId AND SpecName = @specificationType";
                cmd.Parameters.AddWithValue("@projectId", b.ProjectId);
                cmd.Parameters.AddWithValue("@specificationType", b.SpecificationType);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        b.SpecificationType = dr["SpecName"].ToString();
                        b.SpecificationDetails = dr["SpecDetails"].ToString();
                    }
                }

            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Dispose(); dr.Close(); }
        }

        internal void ManipulateProjectSpecification(bllProjectInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateProjectSpecification";
                cmd.Parameters.AddWithValue("@projectId", b.ProjectId);
                cmd.Parameters.AddWithValue("@specificationTypeId", b.SpecificationTypeId);
                cmd.Parameters.AddWithValue("@specificationDetails", b.SpecificationDetails);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
        }

        internal void ManipulateBuildingData(bllProjectInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateBuildingData";
                cmd.Parameters.AddWithValue("@buildingId", b.BuildingId);
                cmd.Parameters.AddWithValue("@buildingName", b.BuildingName);
                cmd.Parameters.AddWithValue("@countOfBasements", b.CountOfBasements);
                cmd.Parameters.AddWithValue("@countOfFloors", b.CountOfFloors);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstationIp", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Dispose(); }
        }

        internal void GetBuildingDetails(bllProjectInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM BuildingNumber WHERE BuildingID = @buildingId";
                cmd.Parameters.AddWithValue("@buildingId", b.BuildingId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        b.BuildingName = dr["Name"].ToString();
                        b.CountOfBasements = Convert.ToDecimal(dr["NumOfBasements"].ToString());
                        b.CountOfFloors = Convert.ToDecimal(dr["NumOfFloors"].ToString());
                        b.FloorInformation = dr["FloorInformation"].ToString();
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Dispose(); dr.Close(); }
        }

        internal void ManipulateBuildingCount(int projectId, int countOfBuilding)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateBuildingCount";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Parameters.AddWithValue("@countOfBuilding", countOfBuilding);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@manipulatedFrom", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Dispose(); }
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
                cmd.CommandText = "SELECT * FROM BuildingNumber WHERE ProjectId=@projectId";
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
