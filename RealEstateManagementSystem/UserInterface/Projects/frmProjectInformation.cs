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
using Spell;
namespace RealEstateManagementSystem.UserInterface.Projects
{
    public partial class frmProjectInformation : Form
    {
        bllProjectInfo bLayer = new bllProjectInfo();
        int projectId = 0;
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
            catch (Exception ex) { ex.Display(); }
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
                bLayer.PopulateProjectLocationCombo(cmbLocation);
            }
            catch (Exception ex) { ex.Display(); }
        }

        private void cmbProjectName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ResetForm(false);
            projectId = cmbProjectName.SelectedValue.ToString().ConvertToInt32();
            LoadProjectDetailsInformation(projectId);
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

                txtBookingMoney.Text = bLayer.BookingMoney.ToString();
                txtDownPayment.Text = bLayer.DownPayment.ToString();
                txtUtilityConnectionFee.Text = Spell.SpellAmount.comma(bLayer.UtilityConnectionFee);

                PopulateListOfBuildings();

                clsCommonFunctions.PopulateListViewFromDataTable(
                            dataTable: bLayer.GetListOfProjectSpecifications(),
                            lView: lstProjectSpecifications, hideFirstColumn: false);



            }
            catch (Exception ex) { ex.Display(); }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                string strConfirmationMessage = projectId > 0 ? "Are you sure about update information of Project " + cmbProjectName.Text.ToString() : "Sure about insert new project information?";
                DialogResult dr = MessageBox.Show(strConfirmationMessage, Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                bLayer.ProjectId = projectId;
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
                clsCommonFunctions.PopulateListOfProjects(cmbProjectName, clsGlobalClass.ProjectStatus.All);
                ResetForm(true);
            }
            catch (Exception ex) { ex.Display(); }

        }

        private void PopulateComboboxes(bool withProjectCombo = false)
        {
            try
            {
                if (withProjectCombo == true) clsCommonFunctions.PopulateListOfProjects(cmbProjectName, clsGlobalClass.ProjectStatus.All);
                bLayer.PopulateProjectLocationCombo(cmbLocation);
                bLayer.PopulateProjectTypeCombo(cmbProjectType);
                bLayer.PopulateLandTypeCombo(cmbLandType);
                bLayer.PopulateProjectInChargeCombo(cmbInCharge);
                bLayer.PopulateProjectArchitectCombo(cmbArchitect);
                bLayer.PopualateDesignEngineerCombo(cmbDesignEngr);
                bLayer.PopulateSignatoryCombo(cmbSignatory);
                bLayer.PopulateProjectSpecificationTypes(cmbProjectSpecificationType);
            }
            catch (Exception ex) { ex.Display(); }

        }

        private void ResetForm(bool withProjectCombo)
        {
            clsCommonFunctions.ResetCheckBoxes(this, false);
            clsCommonFunctions.ResetTextBoxes(this, "");
            clsCommonFunctions.ResetDTPicker(this, false);
            PopulateComboboxes(withProjectCombo);
            projectId = 0;
        }

        private void btnSaveBuildingList_Click(object sender, EventArgs e)
        {
            try
            {
                if (projectId == 0) { MessageBox.Show("Please select a Project from Top.", Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error); return; };
                DialogResult dr = MessageBox.Show("This is a one time operation. You cannot change this entry once you save it.\nAre you sure about adding <" + nudBuildingCount.Value.ToString() + "> Building(s) to Project <" + cmbProjectName.Text.ToString() + ">?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                bLayer.ProjectId = projectId; //Convert.ToInt32(cmbProjectName.SelectedValue);
                bLayer.ManipulateBuildingCount(Convert.ToInt32(nudBuildingCount.Value));
                PopulateListOfBuildings();
                MessageBox.Show(Resources.strSuccessMessage, Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ex.Display(); }
        }


        private void PopulateListOfBuildings()
        {
            try
            {
                lstBuildingDetails.Items.Clear();
                bLayer.ProjectId = cmbProjectName.SelectedValue.ToString().ConvertToInt32();
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

                if (lstBuildingDetails.Items.Count < 1)
                {
                    MessageBox.Show("Please INSERT Building information first to update floor data.", Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (lstBuildingDetails.SelectedItems.Count < 1)
                {
                    MessageBox.Show("Please SELECT Building information first to update floor data.", Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult dr = MessageBox.Show("Sure about update Floor Data for Selected Building?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                bLayer.BuildingId = lstBuildingDetails.SelectedItems[0].Text.ToString().ConvertToInt32();
                bLayer.BuildingName = txtBuildingName.Text;
                bLayer.CountOfBasements = Convert.ToInt32(txtCountOfBasement.Text);
                bLayer.CountOfFloors = Convert.ToInt32(txtCountOfFloor.Text);
                bLayer.ManipulateBuildingData();
                clsCommonFunctions.ResetTextBoxes(tpBuildingFloor);
                PopulateListOfBuildings();
                MessageBox.Show(Resources.strSuccessMessage, Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ex.Display(); }
        }

        private void btnRefresh_PI_Click(object sender, EventArgs e)
        {
            ResetForm(true);
            txtProjectCode.Text = bLayer.GetNewProjectCode().ToString();
        }

        private void btnProjectSummaryReport_Click(object sender, EventArgs e)
        {
            try
            {
                tssStatus.Text = Resources.strCollectingData;
                Reports.Projects.crptProjectInfo rptProjectSummary = new Reports.Projects.crptProjectInfo();
                rptProjectSummary.Subreports[0].SetDataSource(clsCommonFunctions.CompanyInformation());
                rptProjectSummary.SetDataSource(bLayer.GetProjectSummary(cmbProjectName.SelectedValue.ToString().ConvertToInt32()).Tables[0]);
                Reports.frmReportViewer frmReport = new Reports.frmReportViewer();
                frmReport.crptMasterReport.ReportSource = rptProjectSummary;
                tssStatus.Text = Resources.strPreparingData;
                frmReport.ShowDialog();
                GC.Collect();
                tssStatus.Text = Resources.strReadyStatus;
            }
            catch (Exception ex) { tssStatus.Text = Resources.strReadyStatus; ex.Display(); }
        }

        private void lstBuildingDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstBuildingDetails.SelectedItems.Count < 1) return;
                bLayer.BuildingId = lstBuildingDetails.SelectedItems[0].Text.ToString().ConvertToInt32();
                bLayer.GetBuildingDetails();
                txtBuildingName.Text = bLayer.BuildingName.ToString();
                txtCountOfBasement.Text = bLayer.CountOfBasements.ToString();
                txtCountOfFloor.Text = bLayer.CountOfFloors.ToString();
                txtCountOfBasement.Enabled = txtCountOfFloor.Enabled = bLayer.CountOfFloors > 0 ? false : true;
            }
            catch (Exception ex) { ex.Display(); }
        }


        private void SelectAll(object sender, EventArgs e)
        {
            clsCommonFunctions.SelectAllInTextBox(sender, e);
        }

        //private void SelectAll(object sender, KeyEventArgs e)
        //{
        //    clsCommonFunctions.SelectAllInTextBox(sender, e);
        //}

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
                if (projectId == 0) { MessageBox.Show("Please select a Project from Top.", Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error); return; };
                DialogResult dr = MessageBox.Show("Sure about manipulating Specification for " + cmbProjectName.Text.ToString() + " Project?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                bLayer.ProjectId = projectId;//cmbProjectName.SelectedValue.ToString().ConvertToInt32();
                bLayer.SpecificationTypeId = Convert.ToInt32(cmbProjectSpecificationType.SelectedValue.ToString());
                bLayer.SpecificationDetails = txtSpecDetails.Text.ToString();
                bLayer.ManipulateProjectSpecification();
                btnResetSpec.PerformClick();
                MessageBox.Show("Specification saved successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ex.Display(); }
        }

        private void lstProjectSpecifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstProjectSpecifications.SelectedItems.Count < 1) return;
                bLayer.ProjectId = cmbProjectName.SelectedValue.ToString().ConvertToInt32();
                bLayer.SpecificationType = lstProjectSpecifications.SelectedItems[0].Text.ToString();
                bLayer.GetProjectSpecificationDetails();
                cmbProjectSpecificationType.Text = bLayer.SpecificationType;
                txtSpecDetails.Text = bLayer.SpecificationDetails;
            }
            catch (Exception ex) { ex.Display(); }
        }

        private void btnPaymentPolicy_Click(object sender, EventArgs e)
        {
            try
            {
                if (projectId == 0) { MessageBox.Show("Please select a Project from Top.", Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error); return; };
                DialogResult dr = MessageBox.Show("Are you sure you want to update the payment policy for <" + cmbProjectName.Text.ToString() + ">?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                bLayer.ProjectId = projectId;
                bLayer.BookingMoney = txtBookingMoney.Text.ToString().ConvertToInt32();
                bLayer.DownPayment = txtDownPayment.Text.ToString().ConvertToInt32();
                bLayer.UtilityConnectionFee = txtUtilityConnectionFee.Text.ToString().ConvertToInt32();
                bLayer.ManipulateProjectPaymentPolicy();
                MessageBox.Show(Resources.strSuccessMessage, Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ex.Display(); }
        }

        private void txtProjectCode_Enter(object sender, EventArgs e)
        {

        }

        private void txtUtilityConnectionFee_Leave(object sender, EventArgs e)
        {
            txtUtilityConnectionFee.Text = txtUtilityConnectionFee.Text == "" ? "0" : txtUtilityConnectionFee.Text.ConvertToDecimal().FormatAsMoney();
        }
    }
}
