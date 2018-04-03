using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateManagementSystem.Utilities;
using RealEstateManagementSystem.Reports;
using RealEstateManagementSystem.Properties;

namespace RealEstateManagementSystem.UserInterface.Reports
{
    public partial class frmProjectReports : Form
    {
        public frmProjectReports()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void frmProjectReports_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommonFunctions.PopulateListOfProjects(cmbProjectName, true);
                cmbProjectName.Focus();
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT DISTINCT dbo.ProjectStatus(ProjectID) AS ProjectStatus FROM ProjectInfo ORDER BY ProjectStatus", "ProjectStatus", "", "All", cmbSummaryCriteria);
            }
            catch (Exception ex) { ex.ProcessException(); }

        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                int projectId = cmbProjectName.SelectedValue.ToString().ConvertToInt32();
                string filterCriteria = cmbSummaryCriteria.Text;
                clsGlobalClass.ProjectCommonReport_FilterBy filterBy = clsGlobalClass.ProjectCommonReport_FilterBy.ProjectStatus;
                if (rbProjectStatus.Checked == true)
                {
                    filterBy = clsGlobalClass.ProjectCommonReport_FilterBy.ProjectStatus;
                }
                else if (rbDistrict.Checked == true)
                {
                    filterBy = clsGlobalClass.ProjectCommonReport_FilterBy.District;
                }
                else if (rbArea.Checked == true)
                {
                    filterBy = clsGlobalClass.ProjectCommonReport_FilterBy.Area;
                }
                else if (rbLocation.Checked == true)
                {
                    filterBy = clsGlobalClass.ProjectCommonReport_FilterBy.Location;
                }
                else if (rbProjectType.Checked == true)
                {
                    filterBy = clsGlobalClass.ProjectCommonReport_FilterBy.ProjectType;
                }

                if (rbProjectSummary.Checked == true)
                {
                    clsReports.ProjectSummary(projectId, tssStatus);
                }
                else if (rbRegistrationStatus.Checked == true)
                {
                    clsReports.GetRegistrationStatusOfProject(projectId, chkRegistrationStatus_WithPayment.Checked, tssStatus);
                }
                else if (rbDeedOfAgreementStatus.Checked == true)
                {
                    clsReports.GetDeedOfAgreementsOfProject(projectId, tssStatus);
                }
                else if (rbGeneralStatusOfClient.Checked == true)
                {
                    clsReports.GetGeneralStatusOfClient(projectId, tssStatus);
                }
                else if (rbDueList.Checked == true)
                {
                    clsReports.GetDueListOfProject(projectId, tssStatus);
                }
                else if (rbDeductedAmount.Checked == true)
                {
                    clsReports.GetDeductionAmount(projectId, tssStatus);
                }
                else if (rbOralBooking.Checked == true)
                {
                    clsReports.GetOralBookingOfProject(projectId, tssStatus);
                }
                else if (rbBlockedUnits.Checked == true)
                {
                    clsReports.GetListOfBlockedUnits("Project", cmbProjectName.SelectedValue.ToString(), clsGlobalClass.ProjectCommonReport_FilterBy.SelectedProjects, tssStatus);
                }
                else if (rbListOfUnits.Checked == true)
                {
                    clsReports.UnitDetailsOfProject(projectId, tssStatus);
                }
                else if (rbListOfLandOwners.Checked == true)
                {
                    clsReports.ListOfLandOwners(projectId, tssStatus);
                }
                else if (rbListOfClients.Checked == true)
                {
                    if (chkLOC_withUnitValue.Checked == true)
                    {
                        clsReports.ListOfClientsByProjectId_WithUnitValue(projectId, tssStatus);
                    }
                    else if (chkLOC_withPayment.Checked == true)
                    {
                        clsReports.ListOfClientsByProjectId_WithPayment(projectId, tssStatus);
                    }
                    else if (chkLOC_withPhotoAndSignature.Checked == true)
                    {
                        clsReports.ListOfClientsByProjectId_WithPhotoSignature(projectId, tssStatus);
                    }
                    else
                    {
                        clsReports.ListOfClientsByProjectId(projectId, tssStatus);
                    }
                }
                else if (rbPayementDetailsOfAllClient.Checked == true)
                {
                    clsReports.PaymentDetailsOfClientsByProject(projectId, tssStatus);
                }
                else if (rbBookingPosition.Checked == true)
                {
                    clsReports.BookingPosition(projectId, tssStatus);
                }
                else if (rbPriceList.Checked == true)
                {
                    clsReports.PriceList(projectId, tssStatus);
                }
                else if (rbProjectStatus.Checked == true || rbProjectType.Checked == true || rbDistrict.Checked == true || rbArea.Checked == true || rbLocation.Checked == true)
                {
                    if (rbProjectConsolidation.Checked == true)
                    {
                        clsReports.GetConsolidatedProjectSummary(filterBy, filterCriteria, tssStatus);
                    }
                    else if (rbCommonPriceList.Checked == true)
                    {
                        clsReports.GetCommonPriceList(filterBy, filterCriteria, tssStatus);
                    }
                    else if (rbCommonClientList.Checked == true)
                    {
                        clsReports.GetCommonClientList(filterBy, filterCriteria, tssStatus);
                    }
                    else if (rbFinancialSummary.Checked == true)
                    {
                        clsReports.GetFinancialSummaryOfProjects(filterBy, filterCriteria, tssStatus);
                    }
                    else if (rbBlockedUnits_Summary.Checked == true)
                    {
                        clsReports.GetListOfBlockedUnits("Summary", filterCriteria, filterBy, tssStatus);
                    }
                    else if (rbSummarizedSalesStatus.Checked == true)
                    {
                        clsReports.GetSummarizedSalesStatus("Summary", filterCriteria, filterBy, tssStatus);
                    }
                    else
                    {
                        throw new ApplicationException("Please select a summary report type.");
                    }

                }
            }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void chkRegistrationStatus_WithPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegistrationStatus_WithPayment.Checked == true) { rbRegistrationStatus.Checked = true; }
        }

        private void btnShowReport_MouseHover(object sender, EventArgs e)
        {

        }

        private void rbListOfClients_CheckedChanged(object sender, EventArgs e)
        {
            if (rbListOfClients.Checked == true) clsCommonFunctions.ResetRadioButtons(pnlSummaryReportType);
            if (rbListOfClients.Checked == false) chkLOC_withPayment.Checked = chkLOC_withUnitValue.Checked = chkLOC_withPhotoAndSignature.Checked = false;
        }


        private void chkLOC_withPhotoAndSignature_Click(object sender, EventArgs e)
        {
            rbListOfClients.Checked = true;
            if (chkLOC_withPhotoAndSignature.Checked == true) chkLOC_withPayment.Checked = chkLOC_withUnitValue.Checked = false;
        }

        private void chkLOC_withPayment_Click(object sender, EventArgs e)
        {
            rbListOfClients.Checked = true;
            if (chkLOC_withPayment.Checked == true) chkLOC_withUnitValue.Checked = chkLOC_withPhotoAndSignature.Checked = false;
        }

        private void chkLOC_withUnitValue_Click(object sender, EventArgs e)
        {
            rbListOfClients.Checked = true;
            if (chkLOC_withUnitValue.Checked == true) chkLOC_withPayment.Checked = chkLOC_withPhotoAndSignature.Checked = false;
        }

        private void rbProjectStatus_CheckedChanged(object sender, EventArgs e)
        {
            try { if (rbProjectStatus.Checked == true) { clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT DISTINCT dbo.ProjectStatus(ProjectID) AS ProjectStatus FROM ProjectInfo ORDER BY ProjectStatus", "ProjectStatus", "", "All", cmbSummaryCriteria); } }
            catch (Exception ex) { ex.ProcessException(); }

        }

        private void rbDistrict_CheckedChanged(object sender, EventArgs e)
        {
            try { if (rbDistrict.Checked == true) { clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT DistrictId, DistrictName FROM defDistrict ORDER BY DistrictName", "DistrictName", "DistrictId", false, cmbSummaryCriteria); } }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void rbArea_CheckedChanged(object sender, EventArgs e)
        {
            try { if (rbArea.Checked == true) { clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT AreaId, Area FROM AreaDetails ORDER BY AreaName", "Area", "AreaId", false, cmbSummaryCriteria); } }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void rbLocation_CheckedChanged(object sender, EventArgs e)
        {
            try { if (rbLocation.Checked == true) { clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT LocationId, [Location] FROM LocationDetails ORDER BY [Location]", "Location", "LocationId", false, cmbSummaryCriteria); } }
            catch (Exception ex) { ex.ProcessException(); }

        }

        private void rbProjectType_CheckedChanged(object sender, EventArgs e)
        {
            try { if (rbProjectType.Checked == true) { clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT * FROM defProjectType ORDER BY ProjectType", "ProjectType", "ProjectTypeId", "All", cmbSummaryCriteria); } }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbProjectSummary_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProjectSummary.Checked == true) clsCommonFunctions.ResetRadioButtons(pnlSummaryReportType);
        }

        private void rbRegistrationStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRegistrationStatus.Checked == true) clsCommonFunctions.ResetRadioButtons(pnlSummaryReportType);
        }

        private void rbDeedOfAgreementStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeedOfAgreementStatus.Checked == true) clsCommonFunctions.ResetRadioButtons(pnlSummaryReportType);
        }

        private void rbGeneralStatusOfClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGeneralStatusOfClient.Checked == true) clsCommonFunctions.ResetRadioButtons(pnlSummaryReportType);
        }

        private void rbDueList_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDueList.Checked == true) clsCommonFunctions.ResetRadioButtons(pnlSummaryReportType);
        }

        private void rbDeductedAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeductedAmount.Checked == true) clsCommonFunctions.ResetRadioButtons(pnlSummaryReportType);
        }

        private void rbOralBooking_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOralBooking.Checked == true) clsCommonFunctions.ResetRadioButtons(pnlSummaryReportType);
        }

        private void rbBlockedUnits_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlockedUnits.Checked == true) clsCommonFunctions.ResetRadioButtons(pnlSummaryReportType);
        }

        private void rbListOfUnits_CheckedChanged(object sender, EventArgs e)
        {
            if (rbListOfUnits.Checked == true) clsCommonFunctions.ResetRadioButtons(pnlSummaryReportType);
        }

        private void rbListOfLandOwners_CheckedChanged(object sender, EventArgs e)
        {
            if (rbListOfLandOwners.Checked == true) clsCommonFunctions.ResetRadioButtons(pnlSummaryReportType);
        }

        private void rbPayementDetailsOfAllClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPayementDetailsOfAllClient.Checked == true) clsCommonFunctions.ResetRadioButtons(pnlSummaryReportType);
        }

        private void rbBookingPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBookingPosition.Checked == true) clsCommonFunctions.ResetRadioButtons(pnlSummaryReportType);
        }

        private void rbPriceList_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPriceList.Checked == true) clsCommonFunctions.ResetRadioButtons(pnlSummaryReportType);
        }
    }
}
