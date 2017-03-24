using RealEstateManagementSystem.DataAccessLayer;
using RealEstateManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateManagementSystem.BusinessLogicLayer
{

    class bllProjectInfo
    {
        private dalProjectInfo dLayer = new dalProjectInfo();

        #region Properties

        #region Project Properties
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectName_InBangla { get; set; }
        public string ProjectAddress { get; set; }
        public string ProjectAddress_InBangla { get; set; }
        public DateTime AgreementSignDate { get; set; }
        public bool IsAgreementSigned { get; set; }
        public DateTime PlotTakeOverDate { get; set; }
        public bool IsPlotTakenOver { get; set; }
        public DateTime ApprovalDate { get; set; }
        public bool IsProjectApproved { get; set; }
        public DateTime ConstructionStartedOn { get; set; }
        public bool IsConstructionStarted { get; set; }
        public DateTime SaleStartedOn { get; set; }
        public bool IsSaleStarted { get; set; }
        public DateTime ActualCompletion { get; set; }
        public bool IsActuallyCompleted { get; set; }
        public DateTime EstimatedHandoverDate { get; set; }
        public bool IsEstimatedHandoverDateSet { get; set; }
        public DateTime ActualHandoverDate { get; set; }
        public bool IsHandedOver { get; set; }
        public decimal ConstructionDuration { get; set; }
        public decimal ConstructionGracePeriod { get; set; }
        public decimal LandArea { get; set; }
        public string Remarks { get; set; }
        public int ProjectCode { get; set; }
        public string GeoLocation { get; set; }
        public int ProjectSignatoryId { get; set; }
        public string ProjectSignatory { get; set; }
        public string ApprovalNumber { get; set; }
        public string ProjectLocation { get; set; }
        public int InChargeId { get; set; }
        public string ProjectInCharge { get; set; }
        public int ArchitectId { get; set; }
        public string ProjectArchitect { get; set; }
        public int ProjectStructuralDesignerId { get; set; }
        public string ProjectStructuralDesigner { get; set; }
        public int ProjectTypeId { get; set; }
        public string ProjectType { get; set; }
        public int LandTypeId { get; set; }
        public string LandType { get; set; }
        public bool IsAvailableInDB { get; set; }


        public string AvailableInDB { get; set; }
        public bool IsPilingNeeded { get; set; }
        public bool IsVisibleInWeb { get; set; }
        public bool IsCancelledProject { get; set; }
        #endregion

        #region Building Properties
        public int BuildingId { get; set; }
        public int BuildingNumber { get; set; }
        public string BuildingName { get; set; }
        public decimal CountOfBasements { get; set; }
        public decimal CountOfFloors { get; set; }
        public string FloorInformation { get; set; }
        public int FloorId { get; set; }
        public string FloorType { get; set; }
        public string FormattedFloorNumber { get; set; }

        #endregion

        #region Building Specification
        public int SpecificationTypeId { get; set; }
        public string SpecificationType { get; set; }
        public string SpecificationDetails { get; set; }
        #endregion

        #region District/Area/Location
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string DistrictName_Bangla { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public string AreaName_Bangla { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string LocationName_Bangla { get; set; }
        #endregion

        #region Payment Policy
        public int BookingMoney { get; set; }
        public int DownPayment { get; set; }
        public int UtilityConnectionFee { get; set; }
        #endregion

        #region UnitProperties
        public bool IsEditable { get; set; }
        public int UnitId { get; set; }
        public string UnitNumber { get; set; }
        public int UnitTypeId { get; set; }
        public string UnitType { get; set; }
        public decimal UnitArea { get; set; }
        public decimal Rate { get; set; }
        public string UnitSpecification { get; set; }
        public string Owner { get; set; }
        public int FacingId { get; set; }
        public string Facing { get; set; }
        public int TypeOfUnitId { get; set; }
        public string TypeOfUnit { get; set; }
        public bool IsNumberEnabled { get; set; }
        public bool IsTypeEnabled { get; set; }
        public bool IsFacingEnabled { get; set; }
        public bool IsAreaEnabled { get; set; }
        public bool IsMasterUnit { get; set; }
        public string UnitInitial { get; set; }
        public bool IsSaleable { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsParkingAvailable { get; set; }
        #endregion

        #region UnitBlocking
        public DateTime BlockStart { get; set; }
        public DateTime BlockEnd { get; set; }
        public string BlockRemarks { get; set; }

        #endregion

        #endregion

        internal void PopulateProjectSpecificationTypes(ComboBox cmbProjectSpecificationType)
        {
            try
            {
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(
                  CommandType.Text,
                  "SELECT SpecTypeId, SpecName FROM defProjectSpec ORDER BY [Sequence]",
                  "SpecName",
                  "SpecTypeId",
                  cmbProjectSpecificationType);
            }
            catch (Exception ex) { throw ex; }
        }

        internal void GetAreaInfo()
        {
            try { dLayer.GetAreaInfo(this); }
            catch (Exception ex) { throw ex; }
        }

        internal void GetLocationInfo()
        {
            try { dLayer.GetLocationInfo(this); }
            catch (Exception ex) { throw ex; }
        }

        internal void PopulateListOfAreas(ComboBox cmbAreas, string districtName)
        {
            try
            {
                clsCommonFunctions.ResetComboBox(cmbAreas);
                cmbAreas.DataSource = dLayer.PopulateListOfAreas(districtName).Tables[0];
                cmbAreas.DisplayMember = "AreaName";
                cmbAreas.ValueMember = "AreaId";
            }
            catch (Exception ex) { throw ex; }
        }

        internal void PopulateLocationDetails(ListView lstLocationDetails, string districtName)
        {
            try { clsCommonFunctions.PopulateListViewFromDataTable(dataTable: dLayer.PopulateLocationDetails(districtName), lView: lstLocationDetails); }
            catch (Exception ex) { throw ex; }
        }

        internal void PopulateProjectLocationCombo(ComboBox cmbLocation)
        {
            try
            {
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(
                  CommandType.Text,
                  "SELECT LocationId, Location FROM LocationDetails ORDER BY Location",
                  "Location",
                  "LocationId",
                  cmbLocation);
            }
            catch (Exception ex) { throw ex; }
        }



        internal DataTable GetListOfProjectSpecifications()
        {
            try { return dLayer.GetListOfProjectSpecifications(this.ProjectId); }
            catch (Exception ex) { throw ex; }
        }

        internal DataTable GetListOfBuildingsInProject()
        {
            try { return dLayer.GetListOfBuildingsInProject(this.ProjectId); }
            catch (Exception ex) { throw ex; }
        }

        internal void PopulateProjectTypeCombo(ComboBox cmbProjectType)
        {
            try
            {
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(
                    CommandType.Text,
                    "SELECT * FROM defProjectType ORDER BY ProjectType",
                    "ProjectType", "ProjectTypeId", cmbProjectType
                    );
            }
            catch (Exception ex) { throw ex; }
        }

        internal void PopulateLandTypeCombo(ComboBox cmbLandType)
        {
            try
            {
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(
                    CommandType.Text,
                    "SELECT * FROM defLandType",
                    "LandType", "LandTypeId",
                    cmbLandType
                    );
            }
            catch (Exception ex) { throw ex; }
        }

        internal void PopulateProjectInChargeCombo(ComboBox cmbInCharge)
        {
            try
            {
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(
                        CommandType.Text,
                        "SELECT InChargeId, ICName FROM ProjectInCharge ORDER BY ICName",
                        "ICName", "InChargeId", cmbInCharge
                    );
            }
            catch (Exception ex) { throw ex; }
        }

        internal void PopulateProjectArchitectCombo(ComboBox cmbArchitect)
        {
            try
            {
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(
                        CommandType.Text,
                        "SELECT ArchitectId, ArchName FROM ProjectArchitect ORDER BY ArchName",
                        "ArchName", "ArchitectId", cmbArchitect
                    );
            }
            catch (Exception ex) { throw ex; }
        }

        internal void PopualateDesignEngineerCombo(ComboBox cmbDesignEngr)
        {
            try
            {
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(
                        CommandType.Text,
                        "select StructuralDesignerId, SDName FROM StructuralDesigner ORDER BY SDName",
                        "SDName", "StructuralDesignerId", cmbDesignEngr
                    );
            }
            catch (Exception ex) { throw ex; }
        }

        internal void ManipulateUnitInformation()
        {
            try { dLayer.ManipulateUnitInformation(this); }
            catch (Exception ex) { throw ex; }
        }

        internal void ManipulateProjectInfo()
        {
            try { dLayer.ManipulateProjectInfo(this); }
            catch (Exception ex) { throw ex; }
        }

        internal void PopulateSignatoryCombo(ComboBox cmbSignatory)
        {
            try
            {
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(
                        CommandType.Text,
                        "SELECT SignatoryId, Name FROM defSignatory",
                        "Name", "SignatoryId", cmbSignatory
                    );
            }
            catch (Exception ex) { throw ex; }
        }

        internal void GetProjectDetails()
        {
            try { dLayer.GetProjectDetails(this); }
            catch (Exception ex) { throw ex; }
        }

        internal void ManipulateBuildingCount(int countOfBuilding)
        {
            try { dLayer.ManipulateBuildingCount(this.ProjectId, countOfBuilding); }
            catch (Exception ex) { throw ex; }
        }

        internal void GetBuildingDetails()
        {
            try { dLayer.GetBuildingDetails(this); }
            catch (Exception ex) { throw ex; }
        }

        internal void ManipulateBuildingData()
        {
            try { dLayer.ManipulateBuildingData(this); }
            catch (Exception ex) { throw ex; }
        }

        internal void ManipulateProjectSpecification()
        {
            try { dLayer.ManipulateProjectSpecification(this); }
            catch (Exception ex) { throw ex; }
        }

        internal void GetProjectSpecificationDetails()
        {
            try { dLayer.GetProjectSpecificationDetails(this); }
            catch (Exception ex) { throw ex; }
        }

        internal DataSet GetProjectSummary(int projectId)
        {
            try { return dLayer.GetProjectSummary(projectId); }
            catch (Exception ex) { throw ex; }
        }

        internal DataTable GetListOfDistricts()
        {
            try { return dLayer.GetListOfDistricts(); }
            catch (Exception ex) { throw ex; }
        }
        internal DataTable GetListOfAreas(int districtId)
        {
            try { return dLayer.GetListOfAreas(districtId); }
            catch (Exception ex) { throw ex; }
        }

        internal DataTable GetListOfLocations(int areaId)
        {
            try { return dLayer.GetListOfLocations(areaId); }
            catch (Exception ex) { throw ex; }
        }
        internal void ManipulateDistrictInfo()
        {
            try { dLayer.ManipulateDistrictInfo(this.DistrictId, this.DistrictName, this.DistrictName_Bangla); }
            catch (Exception ex) { throw ex; }
        }

        internal int GetNewProjectCode()
        {
            return dLayer.GetNewProjectCode();
        }

        internal DataSet GetUnitDetailsOfProject(int projectId)
        {
            return dLayer.GetUnitDetailsOfProject(projectId);
        }

        internal void ManipulateAreaInfo()
        {
            try { dLayer.ManipulateAreaInfo(this.DistrictId, this.AreaId, this.AreaName, this.AreaName_Bangla); }
            catch (Exception ex) { throw ex; }
        }
        internal void ManipulateLocationInfo()
        {
            try { dLayer.ManipulateLocationInfo(this.AreaId, this.LocationId, this.LocationName, this.LocationName_Bangla); }
            catch (Exception ex) { throw ex; }
        }

        internal void GetDistrictInfo()
        {
            try { dLayer.GetDistrictInfo(this); }
            catch (Exception ex) { throw ex; }
        }
        internal DataTable GetListOfUnitTypesInBuilding(int buildingId)
        {
            try { return dLayer.GetListOfUnitTypesInBuilding(buildingId); }
            catch (Exception ex) { throw ex; }
        }
        internal DataTable GetListOfUnitsByUnitTypeAndBuildingId(string unitType, int buildingId)
        {
            try { return dLayer.GetListOfUnitsByUnitTypeAndBuildingId(unitType, buildingId); }
            catch (Exception ex) { throw ex; }
        }

        internal void ManipulateProjectPaymentPolicy()
        {
            try { dLayer.ManipulateProjectPaymentPolicy(this); }
            catch (Exception ex) { throw ex; }
        }

        internal void PopulateBuildingsCombo(int projectId, ComboBox cmbBuilding)
        {
            try
            {
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember
                                  (CommandType.Text,
                                  "SELECT BNumber, BuildingId FROM BuildingNumber WHERE ProjectId = " + projectId,
                                  "BNumber", "BuildingId", cmbBuilding, false);
            }
            catch (Exception ex) { throw ex; }
        }

        internal void BlockUnit()
        {
            dLayer.BlockUnit(this);
        }

        internal void PopulateFloorsCombo(int buildingId, ComboBox cmbFloorNumber)
        {
            try
            {
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember
                            (CommandType.Text,
                             "SELECT FloorId, dbo.fnGetFormattedFloorNumber(FloorType, FloorNumber) [Floor], FloorNumber FROM FloorInfo where BuildingId = " + buildingId + " ORDER BY FloorType, FloorNumber ASC",
                             "Floor", "FloorId", cmbFloorNumber, false);
            }
            catch (Exception ex) { throw ex; }
        }

        internal DataTable GetUnitBlockingHistory(int unitId)
        {
            return dLayer.GetUnitBlockingHistory(unitId);
        }

        internal void PopulateTypeOfUnitCombo(ComboBox cmbType)
        {
            try
            {
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(CommandType.Text, "SELECT * FROM defFlatType ORDER BY FlatType", "FlatType", "FlatTypeId", cmbType, false);
            }
            catch (Exception ex) { throw ex; }
        }

        internal void UnBlockUnit(int unitId)
        {
            dLayer.UnBlockUnit(unitId);
        }

        internal void PopulateFacingCombo(ComboBox cmbFacing)
        {
            try
            {
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(CommandType.Text, "SELECT FacingId, FacingDefinition FROM defFacing ORDER BY FacingDefinition", "FacingDefinition", "FacingId", cmbFacing, false);
            }
            catch (Exception ex) { throw ex; }
        }

        internal void PopulateUnitTypeCombo(ComboBox cmbUnitType)
        {
            try
            {
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember
                                (CommandType.Text,
                                 "SELECT ObjectTypeID, ObjectType FROM ObjectType ORDER BY ObjectType",
                                 "ObjectType", "ObjectTypeId",
                                 cmbUnitType, false);
            }
            catch (Exception ex) { throw ex; }
        }

        internal void GetUnitTypeProperties()
        {
            try { dLayer.GetUnitTypeProperties(this); }
            catch (Exception ex) { throw ex; }
        }

        internal string GenerateUnitNumber(int unitTypeId, int typeOfUnitId, int floorId)
        {
            try { return dLayer.GenerateUnitNumber(unitTypeId, typeOfUnitId, floorId); }
            catch (Exception ex) { throw ex; }
        }

        internal DataTable GetListOfUnitsInProject()
        {
            try { return dLayer.GetListOfUnitsInProject(this.ProjectId); }
            catch (Exception ex) { throw ex; }
        }
        internal void GetUnitInformation()
        {
            try { dLayer.GetUnitInformation(this); }
            catch (Exception ex) { throw ex; }
        }

        internal DataTable GetListOfHashParking(int projectId)
        {
            return dLayer.GetListOfHashParking(ProjectId);
        }

        internal void UpdateHashParking(int unitId, string parkingNumber, int projectId)
        {
            dLayer.UpdateHashParking(unitId, parkingNumber, projectId);
        }
    }
}
