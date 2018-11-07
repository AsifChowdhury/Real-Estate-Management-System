using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RealEstateManagementSystem.Utilities;
using RealEstateManagementSystem.Reports;
using RealEstateManagementSystem.Properties;

namespace RealEstateManagementSystem.UserInterface.Reports
{
    public partial class frmSummarizedSalesReport : Form
    {
        public frmSummarizedSalesReport()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void frmSummarizedSalesReport_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommonFunctions.PopulateListViewsFromSingleLineQuery("EXEC sp_GetProjectStatuses", lvProjectStatus, null, false);
                clsCommonFunctions.PopulateDistinctSalesYears(cmbSalesYear);
                dtpSR_StartDate.Value = dtpCU_StartDate.Value = DateTime.Now.AddMonths(-6);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPictorialDepiction.Checked == true)
                {
                    clsReports.PictorialDepictionOfSalesStatus(dtpSR_StartDate.Value, dtpSR_EndDate.Value, tssStatus);
                }
                else if (rbSalesPosition_Details.Checked == true)
                {
                    clsReports.SalesPosition(dtpSR_StartDate.Value, dtpSR_EndDate.Value, tssStatus, false);
                }
                else if (rbSalesPosition_ISO.Checked == true)
                {
                    clsReports.SalesPosition(dtpSR_StartDate.Value, dtpSR_EndDate.Value, tssStatus, true);
                }
                else if (rbSummarizedSalesReport.Checked == true)
                {
                    clsReports.GetSummarizedSalesReport(dtpSR_StartDate.Value, dtpSR_EndDate.Value, tssStatus);
                }
                else if (rbAnnualSalesPosition.Checked == true)
                {
                    clsReports.GetAnnualSalesPosition(cmbSalesYear.Text.ConvertToInt32(), tssStatus);
                }
                else if (rbTargetAchievement_ByYear.Checked == true)
                {
                    clsGlobalClass.ShowUnderConstructionMessage();
                }
                else if (rbSummaryOfSales_ByYear.Checked == true)
                {
                    clsReports.GetSummaryOfSales(cmbSalesYear.Text.ConvertToInt32(), tssStatus);
                }
                else if (rbCanceledClientList.Checked == true)
                {
                    clsReports.GetListOfCanceledClients(cmbDateBy.Text == "Booking Date" ? true : false, dtpCU_StartDate.Value, dtpCU_EndDate.Value, tssStatus);
                }
                else if (rbCollectionOfProject.Checked == true)
                {
                    if (lvProjects.CheckedItems.Count < 1 && lvProjectStatus.CheckedItems.Count < 1) throw new ApplicationException("Please select at least one project status/project name.");
                    else if (lvProjects.CheckedItems.Count > 0) clsReports.GetCollectionsOfProject("Project", clsCommonFunctions.convertToCommaSeperatedValue(lvProjects, 1), clsGlobalClass.ProjectCommonReport_FilterBy.SelectedProjects, tssStatus);
                    else clsReports.GetCollectionsOfProject("Summary", clsCommonFunctions.convertToCommaSeperatedValue(lvProjectStatus, 0), clsGlobalClass.ProjectCommonReport_FilterBy.ProjectStatus, tssStatus);
                }
                else if (rbSummarizedSalesStatus_ByProject.Checked == true)
                {
                    if (lvProjects.CheckedItems.Count < 1 && lvProjectStatus.CheckedItems.Count < 1) throw new ApplicationException("Please select at least one project status/project name.");
                    else if (lvProjects.CheckedItems.Count > 0) clsReports.GetSummarizedSalesStatus("Project", clsCommonFunctions.convertToCommaSeperatedValue(lvProjects, 1), clsGlobalClass.ProjectCommonReport_FilterBy.SelectedProjects, tssStatus);
                    else clsReports.GetSummarizedSalesStatus("Summary", clsCommonFunctions.convertToCommaSeperatedValue(lvProjectStatus, 0), clsGlobalClass.ProjectCommonReport_FilterBy.ProjectStatus, tssStatus);
                }
                else if (rbBlockedUnits.Checked == true)
                {
                    if (lvProjects.CheckedItems.Count < 1 && lvProjectStatus.CheckedItems.Count < 1) throw new ApplicationException("Please select at least one project status/project name.");
                    else if (lvProjects.CheckedItems.Count > 0) clsReports.GetListOfBlockedUnits("Project", clsCommonFunctions.convertToCommaSeperatedValue(lvProjects, 1), clsGlobalClass.ProjectCommonReport_FilterBy.SelectedProjects, tssStatus);
                    else clsReports.GetListOfBlockedUnits("Summary", clsCommonFunctions.convertToCommaSeperatedValue(lvProjectStatus, 0), clsGlobalClass.ProjectCommonReport_FilterBy.ProjectStatus, tssStatus);
                }
                else if (rbSalesSummaryByRep.Checked == true)
                {
                    frmSaleSummaryByRep f = new frmSaleSummaryByRep();
                    f.ShowDialog();
                }
            }
            catch (Exception ex) { ex.ProcessException(); }


        }

        private void lvProjectStatus_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try { clsCommonFunctions.PopulateProjectListByProjectStatus(lvProjectStatus, lvProjects, lblProjectCount, tssStatus); }
            catch (Exception ex) { ex.ProcessException(); }
        }
    }
}
