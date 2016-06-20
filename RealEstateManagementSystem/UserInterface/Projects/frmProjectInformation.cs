using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;
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
                ResetForm(true);
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
            ResetForm(false);
            LoadProjectDetailsInformation(Convert.ToInt32(cmbProjectName.SelectedValue));
        }

        private void LoadProjectDetailsInformation(int projectId)
        {
            try
            {
                bLayer.ProjectId = Convert.ToInt32(projectId);
                bLayer.GetProjectDetails();

                cmbLocation.Text = bLayer.ProjectLocation;
                txtProjectCode.Text = bLayer.ProjectCode.ToString();

                txtProjectName.Text = bLayer.ProjectName;
                txtProjectName_Bangla.Text = bLayer.ProjectName_InBangla;
                txtAddress.Text = bLayer.ProjectAddress;
                txtAddress_Bangla.Text = bLayer.ProjectAddress_InBangla;

                dtpAgreementDate.Value = bLayer.AgreementSignDate;
                dtpAgreementDate.Checked = bLayer.IsAgreementSigned;

                dtpPlotTakeOverDate.Value = bLayer.PlotTakeOverDate;
                dtpPlotTakeOverDate.Checked = bLayer.IsPlotTakenOver;

                txtConstructionDuration.Text = bLayer.ConstructionDuration.ToString();
                txtConstructionGracePeriod.Text = bLayer.ConstructionGracePeriod.ToString();
                dtpConstructionStartDate.Value = bLayer.ConstructionStartedOn;
                dtpConstructionStartDate.Checked = bLayer.IsConstructionStarted;

                dtpSaleStartDate.Value = bLayer.SaleStartedOn;
                dtpSaleStartDate.Checked = bLayer.IsSaleStarted;

                dtpEstimatedHandoverDate.Value = bLayer.EstimatedHandoverDate;
                dtpEstimatedHandoverDate.Checked = bLayer.IsEstimatedHandoverDateSet;

                dtpActualHandOverDate.Value = bLayer.ActualHandoverDate;
                dtpActualHandOverDate.Checked = bLayer.IsHandedOver;

                cmbProjectType.Text = bLayer.ProjectType;
                cmbLandType.Text = bLayer.LandType;
                txtLandArea.Text = bLayer.LandArea.ToString();

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

                PopulateListOfBuildings();

                clsCommonFunctions.PopulateListViewFromDataTable(
                            dataTable: bLayer.GetListOfProjectSpecifications(),
                            lView: lstProjectSpecifications, hideFirstColumn: false);

            }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(Resources.strConfirmationMessage, Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                bLayer.ProjectId = cmbProjectName.Text != "" ? Convert.ToInt32(cmbProjectName.SelectedValue) : 0;
                bLayer.ProjectName = txtProjectName.Text.ToString();
                bLayer.ProjectName_InBangla = txtProjectName_Bangla.Text.ToString();
                bLayer.ProjectAddress = txtAddress.Text.ToString();
                bLayer.ProjectAddress_InBangla = txtAddress_Bangla.Text.ToString();
                bLayer.LocationId = Convert.ToInt32(cmbLocation.SelectedValue.ToString());
                bLayer.ProjectCode = Convert.ToInt32(txtProjectCode.Text.ToString());
                bLayer.AgreementSignDate = dtpAgreementDate.Value;
                bLayer.IsAgreementSigned = dtpAgreementDate.Checked;
                bLayer.PlotTakeOverDate = dtpPlotTakeOverDate.Value;
                bLayer.IsPlotTakenOver = dtpPlotTakeOverDate.Checked;
                bLayer.ConstructionStartedOn = dtpConstructionStartDate.Value;
                bLayer.IsConstructionStarted = dtpConstructionStartDate.Checked;
                bLayer.ConstructionDuration = Convert.ToDecimal(txtConstructionDuration.Text);
                bLayer.ConstructionGracePeriod = Convert.ToDecimal(txtConstructionGracePeriod.Text);
                bLayer.SaleStartedOn = dtpSaleStartDate.Value;
                bLayer.IsSaleStarted = dtpSaleStartDate.Checked;
                bLayer.EstimatedHandoverDate = dtpEstimatedHandoverDate.Value;
                bLayer.IsEstimatedHandoverDateSet = dtpEstimatedHandoverDate.Checked;
                bLayer.ActualHandoverDate = dtpActualHandOverDate.Value;
                bLayer.IsHandedOver = dtpActualHandOverDate.Checked;
                bLayer.ProjectTypeId = Convert.ToInt32(cmbProjectType.SelectedValue);
                bLayer.LandTypeId = Convert.ToInt32(cmbLandType.SelectedValue);
                bLayer.LandArea = Convert.ToDecimal(txtLandArea.Text);
                bLayer.GeoLocation = txtGeoLocation.Text.ToString();
                bLayer.ApprovalNumber = txtApprovalNumber.Text.ToString();
                bLayer.ApprovalDate = dtpApprovalDate.Value;
                bLayer.IsProjectApproved = dtpApprovalDate.Checked;
                bLayer.Remarks = txtRemarks.Text;
                bLayer.InChargeId = Convert.ToInt32(cmbInCharge.SelectedValue);
                bLayer.ArchitectId = Convert.ToInt32(cmbArchitect.SelectedValue);
                bLayer.ProjectStructuralDesignerId = Convert.ToInt32(cmbDesignEngr.SelectedValue);
                bLayer.ProjectSignatoryId = Convert.ToInt32(cmbSignatory.SelectedValue);
                bLayer.IsVisibleInWeb = chkShowInWeb.Checked;
                bLayer.IsAvailableInDB = chkDetailsInDB.Checked;
                bLayer.IsCancelledProject = chkIsCancelled.Checked;
                bLayer.IsPilingNeeded = chkNeedPiling.Checked;
                bLayer.ManipulateProjectInfo();
                MessageBox.Show(Resources.strSuccessMessage, Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bLayer.PopulateProjectsCombo(cmbProjectName, clsGlobalClass.ProjectStatus.All);
                //dtpSaleStartDate.Checked = false;
            }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }

        }

        private void PopulateComboboxes(bool withProjectCombo = false)
        {

            if (withProjectCombo == true) bLayer.PopulateProjectsCombo(cmbProjectName, clsGlobalClass.ProjectStatus.All);
            bLayer.PopulateProjectLocationCombo(cmbLocation);
            bLayer.PopulateProjectTypeCombo(cmbProjectType);
            bLayer.PopulateLandTypeCombo(cmbLandType);
            bLayer.PopulateProjectInChargeCombo(cmbInCharge);
            bLayer.PopulateProjectArchitectCombo(cmbArchitect);
            bLayer.PopualateDesignEngineerCombo(cmbDesignEngr);
            bLayer.PopulateSignatoryCombo(cmbSignatory);
            bLayer.PopulateProjectSpecificationTypes(cmbProjectSpecificationType);
        }

        private void ResetForm(bool withProjectCombo)
        {
            clsCommonFunctions.ResetCheckBoxes(this, true);
            clsCommonFunctions.ResetTextBoxes(this, "");
            clsCommonFunctions.ResetAllDateTimePicker(this, false);
            PopulateComboboxes(withProjectCombo);
        }

        private void btnSaveBuildingList_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("This is a one time operation. You cannot change this entry once you save it.\nAre you sure about adding <" + nudBuildingCount.Value.ToString() + "> Building(s) to Project <" + cmbProjectName.Text.ToString() + ">?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                bLayer.ProjectId = Convert.ToInt32(cmbProjectName.SelectedValue);
                bLayer.ManipulateBuildingCount(Convert.ToInt32(nudBuildingCount.Value));
                PopulateListOfBuildings();
                MessageBox.Show(Resources.strSuccessMessage, Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }
        }


        private void PopulateListOfBuildings()
        {
            try
            {
                lstBuildingDetails.Items.Clear();
                bLayer.ProjectId = Convert.ToInt32(cmbProjectName.SelectedValue.ToString());
                foreach (DataRow item in bLayer.GetListOfBuildingsInProject().Rows)
                {
                    string[] strItems = { item["BuildingId"].ToString(), item["BuildingNumber"].ToString(), item["Name"].ToString(), item["NumOfBasements"].ToString(), item["NumOfFloors"].ToString() };
                    ListViewItem lvItems = new ListViewItem(strItems);
                    lstBuildingDetails.Items.Add(lvItems);
                }
                lstBuildingDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lstBuildingDetails.Columns[0].Width = 0;
                btnSaveBuildingList.Enabled = lstBuildingDetails.Items.Count > 0 ? false : true;
            }
            catch (Exception ex) { throw ex; }
        }


        private void btnSaveBuidingData_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstBuildingDetails.SelectedItems.Count < 1) return;
                DialogResult dr = MessageBox.Show("Sure about update Building Data?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                bLayer.BuildingId = Convert.ToInt32(lstBuildingDetails.SelectedItems[0].Text.ToString());
                bLayer.BuildingName = txtBuildingName.Text;
                bLayer.CountOfBasements = Convert.ToInt32(txtCountOfBasement.Text);
                bLayer.CountOfFloors = Convert.ToInt32(txtCountOfFloor.Text);
                bLayer.ManipulateBuildingData();
                clsCommonFunctions.ResetTextBoxes(tpBuildingFloor);
                PopulateListOfBuildings();
                MessageBox.Show(Resources.strSuccessMessage, Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }
        }

        private void btnRefresh_PI_Click(object sender, EventArgs e)
        {
            ResetForm(true);
        }

        private void btnProjectSummaryReport_Click(object sender, EventArgs e)
        {
            
            Reports.Projects.crptProjectInfo rptProjectSummary = new Reports.Projects.crptProjectInfo();
            rptProjectSummary.Subreports[0].SetDataSource(clsCommonFunctions.CompanyInformation());

            Reports.frmReportViewer frmReport = new Reports.frmReportViewer();
            
            frmReport.crptMasterReport.ReportSource = rptProjectSummary;
            frmReport.ShowDialog();
            GC.Collect();
        }

        private void lstBuildingDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstBuildingDetails.SelectedItems.Count < 1) return;
                bLayer.BuildingId = Convert.ToInt32(lstBuildingDetails.SelectedItems[0].Text.ToString());
                bLayer.GetBuildingDetails();
                txtBuildingName.Text = bLayer.BuildingName.ToString();
                txtCountOfBasement.Text = bLayer.CountOfBasements.ToString();
                txtCountOfFloor.Text = bLayer.CountOfFloors.ToString();

                txtCountOfBasement.Enabled = txtCountOfFloor.Enabled = bLayer.CountOfFloors > 0 ? false : true;

            }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }
        }

        private void SelectAll(object sender, KeyEventArgs e)
        {
            clsCommonFunctions.SelectAllInTextBox(sender, e);
        }

        private void NumericOnly(object sender, KeyPressEventArgs e)
        {
            clsCommonFunctions.NumericTextBox(sender, e);
        }

        private void btnResetSpec_Click(object sender, EventArgs e)
        {
            bLayer.ProjectId = Convert.ToInt32(cmbProjectName.SelectedValue.ToString());
            clsCommonFunctions.PopulateListViewFromDataTable(
                             dataTable: bLayer.GetListOfProjectSpecifications(),
                             lView: lstProjectSpecifications, hideFirstColumn: false);
            bLayer.PopulateProjectSpecificationTypes(cmbProjectSpecificationType);
            txtSpecDetails.Text = string.Empty;
        }

        private void btnManipulateSpecification_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Sure about manipulating Project Specification?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                bLayer.ProjectId = Convert.ToInt32(cmbProjectName.SelectedValue.ToString());
                bLayer.SpecificationTypeId = Convert.ToInt32(cmbProjectSpecificationType.SelectedValue.ToString());
                bLayer.SpecificationDetails = txtSpecDetails.Text.ToString();
                bLayer.ManipulateProjectSpecification();
                btnResetSpec.PerformClick();
                MessageBox.Show("Specification saved successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }
        }

        private void lstProjectSpecifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstProjectSpecifications.SelectedItems.Count < 1) return;
                bLayer.ProjectId = Convert.ToInt32(cmbProjectName.SelectedValue.ToString());
                bLayer.SpecificationType = lstProjectSpecifications.SelectedItems[0].Text.ToString();
                bLayer.GetProjectSpecificationDetails();
                cmbProjectSpecificationType.Text = bLayer.SpecificationType;
                txtSpecDetails.Text = bLayer.SpecificationDetails;
            }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }
        }
    }
}
