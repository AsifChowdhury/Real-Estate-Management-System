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
using System.Windows.Forms;

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
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
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
                string qry = "SELECT ProjectId, ProjectName FROM ProjectDetails";
                switch (projectStatus)
                {
                    case clsGlobalClass.ProjectStatus.All:
                        qry = qry + " ";
                        break;
                    case clsGlobalClass.ProjectStatus.AllExceptCancelled:
                        qry = qry + " WHERE ProjectStatus <> @projectStatus";
                        break;
                    default:
                        qry = qry + " WHERE ProjectStatus = @projectStatus";
                        break;
                }
                qry = qry + " ORDER BY ProjectName";
                cmd.CommandText = qry;
                cmd.Parameters.AddWithValue("@projectStatus", projectStatus.ToString());
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal void GetProjectDetails(bllProjectInfo b)
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

                        b.AgreementSignDate = Convert.ToDateTime(dr["AgreementSign"]).ManageInvalidDate();
                        b.IsAgreementSigned = Convert.ToDateTime(dr["AgreementSign"]).IsValidDate();

                        b.PlotTakeOverDate = Convert.ToDateTime(dr["PlotTakeoverDate"]).ManageInvalidDate();
                        b.IsPlotTakenOver = Convert.ToDateTime(dr["PlotTakeOverDate"]).IsValidDate();

                        b.ConstructionDuration = dr["ConstructionDuration"] != DBNull.Value ? Convert.ToInt32(dr["ConstructionDuration"].ToString()) : 0;
                        b.ConstructionGracePeriod = dr["ConstructionGracePeriod"] != DBNull.Value ? Convert.ToInt32(dr["ConstructionGracePeriod"].ToString()) : 0;

                        b.ConstructionStartedOn = Convert.ToDateTime(dr["StartedOn"]).ManageInvalidDate();
                        b.IsConstructionStarted = Convert.ToDateTime(dr["StartedOn"]).IsValidDate();

                        b.SaleStartedOn = Convert.ToDateTime(dr["SaleStartedOn"]).ManageInvalidDate();
                        b.IsSaleStarted = Convert.ToDateTime(dr["SaleStartedOn"]).IsValidDate();

                        b.EstimatedHandoverDate = Convert.ToDateTime(dr["Completion"]).ManageInvalidDate();
                        b.IsEstimatedHandoverDateSet = Convert.ToDateTime(dr["Completion"]).IsValidDate();

                        b.ActualHandoverDate = Convert.ToDateTime(dr["Handover"]).ManageInvalidDate();
                        b.IsHandedOver = Convert.ToDateTime(dr["Handover"]).IsValidDate();

                        b.ProjectType = dr["ProjectType"].ToString();
                        b.LandType = dr["LandType"].ToString();
                        b.LandArea = dr["Area"] != DBNull.Value ? Convert.ToDecimal(dr["Area"].ToString()) : 0;

                        b.GeoLocation = dr["GeoLocation"].ToString();

                        b.ApprovalDate = Convert.ToDateTime(dr["ApprovalDate"]).ManageInvalidDate();
                        b.IsProjectApproved = Convert.ToDateTime(dr["ApprovalDate"]).IsValidDate();
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
                        //clsExDllClass ex = new clsExDllClass();
                        b.BookingMoney = Convert.ToInt32(dr["BookingMoney"].ToString());
                        b.DownPayment = Convert.ToInt32(dr["DownPayment"].ToString());
                        b.UtilityConnectionFee = Convert.ToInt32(dr["UtilityConnectionFee"].ToString());
                    }
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }



        internal DataTable GetBlockedUnitOfProject(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfBlockedUnits";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetListOfProjectsWithBlockedUnit()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfProjectsWithBlockedUnits";
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal void GetLocationInfo(bllProjectInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM LocationDetails WHERE LocationId = @locationId";
                cmd.Parameters.AddWithValue("@locationId", b.LocationId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        b.DistrictName = dr["DistrictName"].ToString();
                        b.AreaName = dr["AreaName"].ToString();
                        b.LocationName = dr["LocationName"].ToString();
                        b.LocationName_Bangla = dr["LocationName_Bangla"].ToString();
                    }
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal void GetAreaInfo(bllProjectInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT dbo.defArea.*, dbo.defDistrict.DistrictName FROM dbo.defArea INNER JOIN dbo.defDistrict ON dbo.defArea.DistrictId = dbo.defDistrict.DistrictId WHERE (dbo.defArea.AreaId = @areaId)";
                cmd.Parameters.AddWithValue("@areaId", b.AreaId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        b.AreaName = dr["AreaName"].ToString();
                        b.AreaName_Bangla = dr["AreaName_Bangla"].ToString();
                        b.DistrictName = dr["DistrictName"].ToString();
                    }
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
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
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal void ManipulateUnitInformation(bllProjectInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateUnitInformation";
                cmd.Parameters.AddWithValue("@unitid", b.UnitId);
                cmd.Parameters.AddWithValue("@floorId", b.FloorId);
                cmd.Parameters.AddWithValue("@unitNumber", b.UnitNumber);
                cmd.Parameters.AddWithValue("@area", b.UnitArea);
                cmd.Parameters.AddWithValue("@rate", b.Rate);
                cmd.Parameters.AddWithValue("@owner", b.Owner);
                cmd.Parameters.AddWithValue("@typeOfUnitId", b.TypeOfUnitId);
                cmd.Parameters.AddWithValue("@facingId", b.FacingId);
                //cmd.Parameters.AddWithValue("@isBlocked", b.IsBlocked.ConverBooleanToSmallInt());
                cmd.Parameters.AddWithValue("@unitTypeId", b.UnitTypeId);
                cmd.Parameters.AddWithValue("@isSaleable", b.IsSaleable.ConverBooleanToSmallInt());
                cmd.Parameters.AddWithValue("@cpAvailable", b.IsParkingAvailable.ConverBooleanToSmallInt());
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
                //cmd.Dispose();
            }
            finally { cmd.Dispose(); }
        }

        internal DataSet GetUnitDetailsOfProject(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfUnitInProject";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }

        }

        internal int GetNewProjectCode()
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetNewProjectCode";
                SqlParameter projectCode = new SqlParameter("@projectCode", SqlDbType.Int);
                projectCode.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(projectCode);
                cmd.ExecuteNonQuery();
                return projectCode.Value.ToString().ConvertToInt32();
            }
            finally { cmd.Dispose(); }
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
            finally { cmd.Dispose(); }
        }
        internal DataTable GetCommonPriceList(clsGlobalClass.ProjectCommonReport_FilterBy filterBy, string filterCriteria)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetCommonPriceList";
                cmd.Parameters.AddWithValue("@filterBy", Convert.ToInt32(filterBy));
                cmd.Parameters.AddWithValue("@filterCriteria", filterCriteria);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }

        }

        internal DataTable GetFinancialSummaryOfProjects(clsGlobalClass.ProjectCommonReport_FilterBy filterBy, string filterCriteria)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetFinancialSummaryOfProjects";
                cmd.Parameters.AddWithValue("@filterBy", Convert.ToInt32(filterBy));
                cmd.Parameters.AddWithValue("@filterCriteria", filterCriteria);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }

        }

        internal DataTable GetProjectSummaryByStatus()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetSummarizedDataOfProject";
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetConsolidatedProjectSummary(clsGlobalClass.ProjectCommonReport_FilterBy filterBy, string filterCriteria)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetConsolidatedProjectSummary";
                cmd.Parameters.AddWithValue("@filterBy", Convert.ToInt32(filterBy));
                cmd.Parameters.AddWithValue("@filterCriteria", filterCriteria);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetCommonClientList(clsGlobalClass.ProjectCommonReport_FilterBy filterBy, string filterCriteria)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetCommonClientList";
                cmd.Parameters.AddWithValue("@filterBy", Convert.ToInt32(filterBy));
                cmd.Parameters.AddWithValue("@filterCriteria", filterCriteria);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetListOfLandOwners(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfLandOwners";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetPriceList(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetPriceList";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetBookingPosition(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetBookingPosition";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable PaymentDetailsOfClientsByProject(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfClientsOfProjectWithPayment";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetListOfClientsByProjectId_WithPhotoAndSignature(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfClientsOfProjectWithPhotoSignature";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetListOfClientsByProjectId_WithPayment(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfClientsOfProjectWithPayment";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetListOfClientsByProjectId_WithUnitValue(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfClientsOfProjectWithUnitValue";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetOralBookingOfProject(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetOralBookingOfProject";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetDeductionAmountByProject(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetDeductedAmountOfProject";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetDueListOfProject(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetDueListByProject";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetGeneralStatusOfClient(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetGeneralStatusOfClientByProject";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataSet GetDeedOfAgreementsOfProject(int projectId, ToolStripStatusLabel tssStatus)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetDeedOfAgreemetsOfProject";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal DataSet GetRegistrationStatusOfProject(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetRegistrationStatusOfProject";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { da.Dispose(); cmd.Dispose(); ds.Dispose(); }
        }

        internal DataSet GetListOfClientsByProjectId(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfClientsByProjectId";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal bool IsFloorInfoAvailable(int buildingId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ISNULL(COUNT(FloorId), 0) CountOfFloors FROM FloorInfo WHERE BuildingId = @buildingId";
                cmd.Parameters.AddWithValue("@buildingId", buildingId);
                dr = cmd.ExecuteReader();

                int countOfFloors = 0;
                if (dr.HasRows)
                {
                    while (dr.Read()) { countOfFloors = dr["CountOfFloors"].ToString().ConvertToInt32(); }
                }
                return countOfFloors > 0 ? true : false;
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal DataTable GetLisOfProjects(clsGlobalClass.ProjectStatus projectStatus)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                string qry = "SELECT ProjectId, ProjectName, ProjectCode FROM ProjectDetails";
                switch (projectStatus)
                {
                    case clsGlobalClass.ProjectStatus.All:
                        qry = qry + " ";
                        break;
                    case clsGlobalClass.ProjectStatus.AllExceptCancelled:
                        qry = qry + " WHERE ProjectStatus <> @projectStatus";
                        break;
                    default:
                        qry = qry + " WHERE ProjectStatus = @projectStatus";
                        break;
                }
                qry = qry + " ORDER BY ProjectName";
                cmd.CommandText = qry;
                cmd.Parameters.AddWithValue("@projectStatus", projectStatus.ToString());
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal void AddFloorToBuilding(int buildingId, bool isBasement)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_AddFloorToBuilding";
                cmd.Parameters.AddWithValue("@buildingId", buildingId);
                cmd.Parameters.AddWithValue("@isBasement", isBasement);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal DataTable GetUnitBlockingHistory(int unitId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetBlockingHistory";
                cmd.Parameters.AddWithValue("@unitId", unitId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal void UnBlockUnit(int unitId)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateUnitUnBlock";
                cmd.Parameters.AddWithValue("@unitId", unitId);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal void UpdateHashParking(int unitId, string parkingNumber, int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateHashParking";
                cmd.Parameters.AddWithValue("@unitId", unitId);
                cmd.Parameters.AddWithValue("@parkingNumber", parkingNumber);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal DataTable GetListOfHashParking(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetHashParkingList";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); }
        }
        internal void BlockUnit(bllProjectInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateUnitBlock";
                cmd.Parameters.AddWithValue("@unitId", b.UnitId);
                cmd.Parameters.AddWithValue("@blockStart", b.BlockStart);
                cmd.Parameters.AddWithValue("@blockEnd", b.BlockEnd);
                cmd.Parameters.AddWithValue("@remarks", b.BlockRemarks);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal void ManipulateProjectPaymentPolicy(bllProjectInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateProjectPaymentPolicy";
                cmd.Parameters.AddWithValue("@projectId", b.ProjectId);
                cmd.Parameters.AddWithValue("@bookingMoney", b.BookingMoney);
                cmd.Parameters.AddWithValue("@downPayment", b.DownPayment);
                cmd.Parameters.AddWithValue("@utilityConnectionFee", b.UtilityConnectionFee);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal DataTable GetListOfUnitsByUnitTypeAndBuildingId(string unitType, int buildingId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfUnitsByUnitTypeAndBuildingId";
                cmd.Parameters.AddWithValue("@buildingId", buildingId);
                cmd.Parameters.AddWithValue("@unitType", unitType);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetListOfUnitsInProject(int projectId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetListOfUnitInProject";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal void GetUnitInformation(bllProjectInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetUnitInfo";
                cmd.Parameters.AddWithValue("@unitId", b.UnitId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //b.IsEditable = (dr["ClientId"].ToString().ConvertToInt32() == 0) || (dr["ObjectType"].ToString() == "Car Parking" && dr["FlatNumber"].ToString().Contains("#") == true) ? true : false;
                        b.IsEditable = Convert.ToString(dr["IsEditable"]).ConvertToBoolean();
                        b.BuildingName = Convert.ToString(dr["BNumber"]);
                        b.UnitType = Convert.ToString(dr["ObjectType"]);
                        b.FormattedFloorNumber = Convert.ToString(dr["FormattedFloorNumber"]);
                        b.Facing = Convert.ToString(dr["FacingDefinition"]);
                        b.TypeOfUnit = Convert.ToString(dr["FlatType"]);
                        b.UnitNumber = Convert.ToString(dr["FlatNumber"]);
                        b.Owner = Convert.ToString(dr["Owner"]);
                        b.UnitArea = Convert.ToString(dr["Area"]).ConvertToDecimal();
                        b.Rate = Convert.ToString(dr["Rate"]).ConvertToDecimal();
                        b.IsNumberEnabled = Convert.ToString(dr["NumberEnabled"]).ConvertToBoolean();
                        b.IsFacingEnabled = Convert.ToString(dr["FacingEnabled"]).ConvertToBoolean();
                        b.IsTypeEnabled = Convert.ToString(dr["TypeEnabled"]).ConvertToBoolean();
                        b.IsAreaEnabled = Convert.ToString(dr["AreaEnabled"]).ConvertToBoolean();
                        b.IsSaleable = Convert.ToString(dr["IsSaleable"]).ConvertToBoolean();
                        b.IsBlocked = Convert.ToString(dr["Blocked"]).ConvertToBoolean();
                        b.IsParkingAvailable = Convert.ToString(dr["CPAvailable"]).ConvertToBoolean();
                    }
                }
            }
            finally { dr.Close(); cmd.Dispose(); }
        }

        internal string ProjectLoadQuery(clsGlobalClass.ProjectStatus projectStatus)
        {
            string qry = "SELECT ProjectId, ProjectName FROM ProjectDetails";
            switch (projectStatus)
            {
                case clsGlobalClass.ProjectStatus.All:
                    qry = qry + " ";
                    break;
                case clsGlobalClass.ProjectStatus.AllExceptCancelled:
                    qry = qry + " WHERE ProjectStatus <> '" + projectStatus.ToString() + "' ";
                    break;
                default:
                    qry = qry + " WHERE ProjectStatus = @projectStatus";
                    break;
            }
            qry = qry + " ORDER BY ProjectName";
            return qry;
        }

        internal DataTable GetListOfUnitTypesInBuilding(int buildingId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT DISTINCT ObjectType FROM vwUnitDetails WHERE BuildingId = @buildingId";
                cmd.Parameters.AddWithValue("@buildingId", buildingId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal void GetUnitTypeProperties(bllProjectInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ObjectType WHERE ObjectTypeId = @unitTypeId";
                cmd.Parameters.AddWithValue("@unitTypeId", b.UnitTypeId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        b.IsNumberEnabled = dr["NumberEnabled"].ToString().ConvertToBoolean();
                        b.IsFacingEnabled = dr["FacingEnabled"].ToString().ConvertToBoolean();
                        b.IsTypeEnabled = dr["TypeEnabled"].ToString().ConvertToBoolean();
                        b.IsAreaEnabled = dr["AreaEnabled"].ToString().ConvertToBoolean();
                        b.IsMasterUnit = dr["IsMasterObject"].ToString().ConvertToBoolean();
                        b.UnitInitial = dr["Initial"].ToString();
                    }
                }
            }
            finally { cmd.Dispose(); dr.Close(); }
        }

        internal string GenerateUnitNumber(int unitTypeId, int typeOfUnitId, int floorId)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GenerateUnitNumber";
                cmd.Parameters.AddWithValue("@unitTypeId", unitTypeId);
                cmd.Parameters.AddWithValue("@typeOfUnitId", typeOfUnitId);
                cmd.Parameters.AddWithValue("@floorId", floorId);
                SqlParameter prmUnitNumber = new SqlParameter("@unitNumber", SqlDbType.VarChar, 10);
                prmUnitNumber.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(prmUnitNumber);
                cmd.ExecuteNonQuery();
                return prmUnitNumber.Value.ToString();
            }
            finally { cmd.Dispose(); }
        }

        internal void ManipulateAreaInfo(int districtId, int areaId, string areaName, string areaName_Bangla)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateAreaInfo";
                cmd.Parameters.AddWithValue("@districtId", districtId);
                cmd.Parameters.AddWithValue("@areaId", areaId);
                cmd.Parameters.AddWithValue("@areaName", areaName);
                cmd.Parameters.AddWithValue("@areaName_Bangla", areaName_Bangla);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal void GetDistrictInfo(bllProjectInfo b)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM defDistrict WHERE DistrictId = @districtId";
                cmd.Parameters.AddWithValue("@districtId", b.DistrictId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        b.DistrictName = dr["DistrictName"].ToString();
                        b.DistrictName_Bangla = dr["DistrictName_Bangla"].ToString();
                    }
                }
            }
            finally { cmd.Dispose(); dr.Close(); }
        }

        internal void ManipulateLocationInfo(int areaId, int locationId, string locationName, string locationName_Bangla)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateLocationInfo";
                cmd.Parameters.AddWithValue("@locationId", locationId);
                cmd.Parameters.AddWithValue("@areaId", areaId);
                cmd.Parameters.AddWithValue("@locationName", locationName);
                cmd.Parameters.AddWithValue("@locationName_Bangla", locationName_Bangla);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal void ManipulateDistrictInfo(int districtId, string districtName, string districtName_Bangla)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ManipulateDistrictInfo";
                cmd.Parameters.AddWithValue("@districtId", districtId);
                cmd.Parameters.AddWithValue("@districtName", districtName);
                cmd.Parameters.AddWithValue("@districtName_Bangla", districtName_Bangla);
                cmd.Parameters.AddWithValue("@user", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstation", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
            }
            finally { cmd.Dispose(); }
        }

        internal DataTable GetListOfLocations(int areaId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Location WHERE AreaId = @areaId";
                cmd.Parameters.AddWithValue("@areaId", areaId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetListOfAreas(int districtId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT AreaId, AreaName FROM defArea WHERE DistrictId = @districtId";
                cmd.Parameters.AddWithValue("@districtId", districtId);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataTable GetListOfDistricts()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT DistrictId, DistrictName FROM defDistrict ORDER BY DistrictName";
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        internal DataSet GetProjectSummary(int projectId)
        {
            SqlCommand cmdDetails = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cmdDetails.Connection = Program.cnConn;
                cmdDetails.CommandType = CommandType.Text;
                cmdDetails.CommandText = "SELECT * FROM ProjectSummary WHERE ProjectId = @projectId";
                cmdDetails.Parameters.AddWithValue("@projectId", projectId);
                da.SelectCommand = cmdDetails;
                da.Fill(ds);
                return ds;
            }
            finally { cmdDetails.Dispose(); da.Dispose(); ds.Dispose(); }
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
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
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
            finally { cmd.Dispose(); }
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
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
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
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }
    }
}
