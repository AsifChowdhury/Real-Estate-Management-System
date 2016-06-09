using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateManagementSystem.UserInterface.Projects
{
    public partial class frmProjectInformation : Form
    {
        bllProjectInfo bLayer = new bllProjectInfo();
        public frmProjectInformation()
        {
            InitializeComponent();
        }

        private void frmProjectInformation_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommonFunctions.AutoFormatComboBoxes(root: this, backColor: Color.Linen);
                clsCommonFunctions.AutoFormatListViews(this);
                bLayer.PopulateProjectLocationCombo(cmbLocation);
                bLayer.PopulateProjectsCombo(cmbProjectName, clsGlobalClass.ProjectStatus.All);
                bLayer.PopulateProjectTypeCombo(cmbProjectType);
                bLayer.PopulateLandTypeCombo(cmbLandType);
                bLayer.PopulateProjectInChargeCombo(cmbInCharge);
                bLayer.PopulateProjectArchitectCombo(cmbArchitect);
                bLayer.PopualateDesignEngineerCombo(cmbDesignEngr);
                bLayer.PopulateSignatoryCombo(cmbSignatory);
                bLayer.PopulateProjectSpecificationTypes(cmbProjectSpecificationType);
            }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }
        }

        private void frmProjectInformation_KeyDown(object sender, KeyEventArgs e)
        {
            clsCommonFunctions.ConvertEnterToTab(this, e);
        }

        private void btnDefProjectLocation_Click(object sender, EventArgs e)
        {
            try
            {
                frmDef_Locations def = new frmDef_Locations();
                def.ShowDialog();
            }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }
        }

        private void cmbProjectName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                bLayer.ProjectId = Convert.ToInt32(cmbProjectName.SelectedValue.ToString());
                bLayer.GetProjectDetails();

                cmbLocation.Text = bLayer.ProjectLocation;
                nudProjectCode.Value = bLayer.ProjectCode;

                txtProjectName.Text = bLayer.ProjectName;
                txtProjectName_Bangla.Text = bLayer.ProjectName_InBangla;
                txtAddress.Text = bLayer.ProjectAddress;
                txtAddress_Bangla.Text = bLayer.ProjectAddress_InBangla;

                dtpAgreementDate.Value = bLayer.AgreementSignDate;
                dtpAgreementDate.Checked = bLayer.IsAgreementSigned;

                dtpPlotTakeOverDate.Value = bLayer.PlotTakeOverDate;
                dtpPlotTakeOverDate.Checked = bLayer.IsPlotTakenOver;
                nudDuration.Value = bLayer.ConstructionDuration;
                nudGracePeriod.Value = bLayer.ConstructionGracePeriod;

                dtpConstructionStartDate.Value = bLayer.ConstructionStartedOn;
                dtpConstructionStartDate.Checked = bLayer.IsConstructionStarted;

                dtpSaleStartDate.Value = bLayer.SaleStartedOn;
                dtpSaleStartDate.Checked = bLayer.IsSaleStarted;

                dtpEstimatedHandoverDate.Value = bLayer.EstimatedHandoverDate;
                dtpEstimatedHandoverDate.Checked = bLayer.IsEstimatedHandoverDateSet;

                dtpActualHandOverDate.Value = bLayer.HandoverDate;
                dtpActualHandOverDate.Checked = bLayer.IsHandedOver;

                cmbProjectType.Text = bLayer.ProjectType;
                cmbLandType.Text = bLayer.LandType;
                nudLandArea.Value = bLayer.LandArea;

                txtGeoLocation.Text = bLayer.GeoLocation;

                txtApprovalNumber.Text = bLayer.ApprovalNumber;
                dtpApprovalDate.Value = bLayer.ApprovalDate;
                dtpApprovalDate.Checked = bLayer.IsProjectApproved;

                txtRemarks.Text = bLayer.Remarks;

                cmbInCharge.Text = bLayer.ProjectInCharge;
                cmbArchitect.Text = bLayer.ProjectArchitect;
                cmbDesignEngr.Text = bLayer.ProjectStructuralDesigner;
                cmbSignatory.Text = bLayer.ProjectSignatory;

                chkDetailsInDB.Checked = bLayer.IsAvailableInDB;
                chkNeedPiling.Checked = bLayer.IsPilingNeeded;
                chkShowInWeb.Checked = bLayer.IsVisibleInWeb;
                chkIsCancelled.Checked = bLayer.IsCancelledProject;

                clsCommonFunctions.PopulateListViewFromDataTable(
                                    dataTable: bLayer.GetListOfBuildingsInProject(),
                                    lView: lstBuildingDetails,
                                    decorateAlternateRows: true, hideFirstColumn: true);

                clsCommonFunctions.PopulateListViewFromDataTable(
                            dataTable: bLayer.GetListOfProjectSpecifications(),
                            lView: lstProjectSpecifications,
                            decorateAlternateRows: true, hideFirstColumn: false);

            }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            //dtpSaleStartDate.Checked = false;
        }
    }
}
