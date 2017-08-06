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

        internal DataTable GetBlockedUnitOfProject(int projectId)
        {
            return dLayer.GetBlockedUnitOfProject(projectId);
        }
        internal DataTable GetListOfProjectsWithBlockedUnit()
        {
            return dLayer.GetListOfProjectsWithBlockedUnit();
        }

        internal void PopulateProjectSpecificationTypes(ComboBox cmbProjectSpecificationType)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(
              CommandType.Text,
              "SELECT SpecTypeId, SpecName FROM defProjectSpec ORDER BY [Sequence]",
              "SpecName",
              "SpecTypeId",
              cmbProjectSpecificationType);
        }

        internal void GetAreaInfo()
        {
            dLayer.GetAreaInfo(this);

        }

        internal void GetLocationInfo()
        {
            dLayer.GetLocationInfo(this);

        }

        internal void PopulateListOfAreas(ComboBox cmbAreas, string districtName)
        {
            clsCommonFunctions.ResetComboBox(cmbAreas);
            cmbAreas.DataSource = dLayer.PopulateListOfAreas(districtName).Tables[0];
            cmbAreas.DisplayMember = "AreaName";
            cmbAreas.ValueMember = "AreaId";

        }

        internal void PopulateLocationDetails(ListView lstLocationDetails, string districtName)
        {
            clsCommonFunctions.PopulateListViewFromDataTable(dataTable: dLayer.PopulateLocationDetails(districtName), lView: lstLocationDetails);

        }

        internal void PopulateProjectLocationCombo(ComboBox cmbLocation)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(CommandType.Text, "SELECT LocationId, Location FROM LocationDetails ORDER BY Location", "Location", "LocationId", cmbLocation);
        }

        internal DataTable GetListOfProjectSpecifications()
        {
            return dLayer.GetListOfProjectSpecifications(this.ProjectId);
        }

        internal DataTable GetListOfBuildingsInProject()
        {
            return dLayer.GetListOfBuildingsInProject(this.ProjectId);
        }

        internal void PopulateProjectTypeCombo(ComboBox cmbProjectType)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(CommandType.Text, "SELECT * FROM defProjectType ORDER BY ProjectType", "ProjectType", "ProjectTypeId", cmbProjectType);
        }

        internal void PopulateLandTypeCombo(ComboBox cmbLandType)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(CommandType.Text, "SELECT * FROM defLandType", "LandType", "LandTypeId", cmbLandType);
        }

        internal void PopulateProjectInChargeCombo(ComboBox cmbInCharge)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(CommandType.Text, "SELECT InChargeId, ICName FROM ProjectInCharge ORDER BY ICName", "ICName", "InChargeId", cmbInCharge);
        }

        internal void PopulateProjectArchitectCombo(ComboBox cmbArchitect)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(CommandType.Text, "SELECT ArchitectId, ArchName FROM ProjectArchitect ORDER BY ArchName", "ArchName", "ArchitectId", cmbArchitect);
        }

        internal void PopualateDesignEngineerCombo(ComboBox cmbDesignEngr)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(CommandType.Text, "select StructuralDesignerId, SDName FROM StructuralDesigner ORDER BY SDName", "SDName", "StructuralDesignerId", cmbDesignEngr);
        }

        internal void ManipulateUnitInformation()
        {
            dLayer.ManipulateUnitInformation(this);

        }

        internal void ManipulateProjectInfo()
        {
            dLayer.ManipulateProjectInfo(this);

        }

        internal void PopulateSignatoryCombo(ComboBox cmbSignatory)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(CommandType.Text, "SELECT SignatoryId, Name FROM defSignatory", "Name", "SignatoryId", cmbSignatory);
        }

        internal void GetProjectDetails()
        {
            dLayer.GetProjectDetails(this);
        }

        internal void ManipulateBuildingCount(int countOfBuilding)
        {
            dLayer.ManipulateBuildingCount(this.ProjectId, countOfBuilding);
        }

        internal void GetBuildingDetails()
        {
            dLayer.GetBuildingDetails(this);

        }

        internal void ManipulateBuildingData()
        {
            dLayer.ManipulateBuildingData(this);
        }

        internal void ManipulateProjectSpecification()
        {
            dLayer.ManipulateProjectSpecification(this);
        }

        internal void GetProjectSpecificationDetails()
        {
            dLayer.GetProjectSpecificationDetails(this);

        }

        internal DataSet GetProjectSummary(int projectId)
        {
            return dLayer.GetProjectSummary(projectId);

        }

        internal DataTable GetListOfDistricts()
        {
            return dLayer.GetListOfDistricts();

        }
        internal DataTable GetListOfAreas(int districtId)
        {
            return dLayer.GetListOfAreas(districtId);

        }

        internal DataTable GetListOfLocations(int areaId)
        {
            return dLayer.GetListOfLocations(areaId);

        }
        internal void ManipulateDistrictInfo()
        {
            dLayer.ManipulateDistrictInfo(this.DistrictId, this.DistrictName, this.DistrictName_Bangla);

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
            dLayer.ManipulateAreaInfo(this.DistrictId, this.AreaId, this.AreaName, this.AreaName_Bangla);

        }
        internal void ManipulateLocationInfo()
        {
            dLayer.ManipulateLocationInfo(this.AreaId, this.LocationId, this.LocationName, this.LocationName_Bangla);
        }

        internal void GetDistrictInfo()
        {
            dLayer.GetDistrictInfo(this);
        }
        internal DataTable GetListOfUnitTypesInBuilding(int buildingId)
        {
            return dLayer.GetListOfUnitTypesInBuilding(buildingId);
        }
        internal DataTable GetListOfUnitsByUnitTypeAndBuildingId(string unitType, int buildingId)
        {
            return dLayer.GetListOfUnitsByUnitTypeAndBuildingId(unitType, buildingId);
        }

        internal void ManipulateProjectPaymentPolicy()
        {
            dLayer.ManipulateProjectPaymentPolicy(this);
        }

        internal void PopulateBuildingsCombo(int projectId, ComboBox cmbBuilding)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(CommandType.Text, "SELECT BNumber, BuildingId FROM BuildingNumber WHERE ProjectId = " + projectId, "BNumber", "BuildingId", cmbBuilding, false);
        }

        internal void BlockUnit()
        {
            dLayer.BlockUnit(this);
        }

        internal void PopulateFloorsCombo(int buildingId, ComboBox cmbFloorNumber)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember
                        (CommandType.Text,
                         "SELECT FloorId, dbo.fnGetFormattedFloorNumber(FloorType, FloorNumber) [Floor], FloorNumber FROM FloorInfo where BuildingId = " + buildingId + " ORDER BY FloorType, FloorNumber ASC",
                         "Floor", "FloorId", cmbFloorNumber, false);
        }

        internal DataTable GetUnitBlockingHistory(int unitId)
        {
            return dLayer.GetUnitBlockingHistory(unitId);
        }

        internal void PopulateTypeOfUnitCombo(ComboBox cmbType)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(CommandType.Text, "SELECT * FROM defFlatType ORDER BY FlatType", "FlatType", "FlatTypeId", cmbType, false);
        }

        internal void UnBlockUnit(int unitId)
        {
            dLayer.UnBlockUnit(unitId);
        }

        internal void PopulateFacingCombo(ComboBox cmbFacing)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(CommandType.Text, "SELECT FacingId, FacingDefinition FROM defFacing ORDER BY FacingDefinition", "FacingDefinition", "FacingId", cmbFacing, false);
        }

        internal void PopulateUnitTypeCombo(ComboBox cmbUnitType)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember
                            (CommandType.Text, "SELECT ObjectTypeID, ObjectType FROM ObjectType ORDER BY ObjectType", "ObjectType", "ObjectTypeId", cmbUnitType, false);
        }

        internal void GetUnitTypeProperties()
        {
            dLayer.GetUnitTypeProperties(this);
        }

        internal string GenerateUnitNumber(int unitTypeId, int typeOfUnitId, int floorId)
        {
            return dLayer.GenerateUnitNumber(unitTypeId, typeOfUnitId, floorId);
        }

        internal DataTable GetListOfUnitsInProject()
        {
            return dLayer.GetListOfUnitsInProject(this.ProjectId);
        }
        internal void GetUnitInformation()
        {
            dLayer.GetUnitInformation(this);
        }

        internal DataTable GetListOfHashParking(int projectId)
        {
            return dLayer.GetListOfHashParking(ProjectId);
        }

        internal void UpdateHashParking(int unitId, string parkingNumber, int projectId)
        {
            dLayer.UpdateHashParking(unitId, parkingNumber, projectId);
        }

        internal void AddAFloorToBuilding(int buildingId, bool isBasement)
        {
            dLayer.AddFloorToBuilding(buildingId, isBasement);
        }
        internal DataTable GetLisOfProjects(clsGlobalClass.ProjectStatus projectStatus)
        {
            return dLayer.GetLisOfProjects(projectStatus);
        }

        internal bool IsFloorInfoAvailable(int buildingId)
        {
            return dLayer.IsFloorInfoAvailable(buildingId);
        }
        internal DataSet GetListOfClientsByProjectId(int projectId)
        {
            return dLayer.GetListOfClientsByProjectId(projectId);
        }

    }
}
