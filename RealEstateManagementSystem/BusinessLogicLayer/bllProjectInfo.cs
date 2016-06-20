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
        public string GeoLocation_Lat { get; set; }

        public int ProjectSignatoryId { get; set; }
        public string ProjectSignatory { get; set; }
        public string ApprovalNumber { get; set; }
        public int LocationId { get; set; }
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
        public string PilingNeeded { get; set; }

        public bool IsVisibleInWeb { get; set; }
        public string ShowInWeb { get; set; }

        public bool IsCancelledProject { get; set; }
        public string CancelledProject { get; set; }
        #endregion

        #region Building Properties
        public int BuildingId { get; set; }
        public int BuildingNumber { get; set; }
        public string BuildingName { get; set; }
        public decimal CountOfBasements { get; set; }
        public decimal CountOfFloors { get; set; }
        public string FloorInformation { get; set; }
        #endregion

        #region Building Specification
        public int SpecificationTypeId { get; set; }
        public string SpecificationType { get; set; }
        public string SpecificationDetails { get; set; }
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


        internal void PopulateListOfAreas(ComboBox cmbAreas, string districtName)
        {
            try
            {
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

        internal void PopulateProjectsCombo(ComboBox cmbProjectName, clsGlobalClass.ProjectStatus projectStatus)
        {
            try
            {
                cmbProjectName.DataSource = dLayer.PopulateProjectsCombo(projectStatus).Tables[0];
                cmbProjectName.DisplayMember = "ProjectName";
                cmbProjectName.ValueMember = "ProjectId";
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
            catch (Exception ex){ throw ex; }
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
    }
}
