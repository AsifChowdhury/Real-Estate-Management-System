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
            clsCommonFunctions.PopulateListOfProjects(cmbProjectName, clsGlobalClass.ProjectStatus.AllExceptCancelled, false);
            clsCommonFunctions.PopulateDistinctSalesYears(cmbSalesYear);
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            if (rbPictorialDepiction.Checked == true)
            {
                clsReports.PictorialDepictionOfSalesStatus(dtpSR_StartDate.Value, dtpSR_EndDate.Value, tssStatus);
            }
            else if (rbSalesPosition_Details.Checked == true)
            {

            }
            else if (rbSalesPosition_ISO.Checked == true)
            {

            }
            else if (rbSummarizedSalesReport.Checked == true)
            {
            }
            else if (rbSummarizedSalesReport_ByYear.Checked == true)
            {

            }
            else if (rbTargetAchievement_ByYear.Checked == true)
            {

            }
            else if (rbSummaryOfSales_ByYear.Checked == true)
            {

            }
            else if (rbDetailsOfCancelledUnits.Checked == true)
            {

            }
            else if (rbCollectionOfProject.Checked == true)
            {

            }
            else if (rbSummarizedSalesStatus_ByProject.Checked == true)
            {

            }

        }
    }
}
