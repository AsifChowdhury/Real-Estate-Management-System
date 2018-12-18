using RealEstateManagementSystem.Properties;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateManagementSystem.Utilities;
using RealEstateManagementSystem.UserInterface.Projects;
using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.UserInterface.UserAuthentication;
using RealEstateManagementSystem.UserInterface.Clients;
using RealEstateManagementSystem.UserInterface.Recovery;
using RealEstateManagementSystem.UserInterface.Accounts;
using RealEstateManagementSystem.UserInterface.Reports;
using System.Configuration;

namespace RealEstateManagementSystem.UserInterface.Root
{
    public partial class MainScreen : Form
    {
        bllUserControl bLayer = new bllUserControl();
        private frmProjectInformation projectInformation = null;
        private frmUserAuthentication userAuthentication = null;
        private frmUnitInformation unitInformation = null;
        private frmSandBox sandBox = null;
        private frmClientInformation clientInfo = null;
        private frmAbout about = null;
        private frmPayment payment = null;
        private frmChequeManagement chequeManagement = null;
        private frmGeneralReports generalReport = null;
        private frmProjectReports projectReport = null;
        private frmSummarizedSalesReport summarizedSalesReport = null;
        private frmRecoveryReports recoveryReport = null;
        private frmUnitRegistration unitRegistration = null;
        private frmAmountTransfer amountTransfer = null;
        public MainScreen()
        {
            InitializeComponent();
        }

        private Form ShowOrActiveForm(Form form, Type t)
        {
            if (form == null)
            {
                form = (Form)Activator.CreateInstance(t);
                form.Show();
            }
            else
            {
                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(t);
                    form.Show();
                }
                else { form.Activate(); }
            }
            return form;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            try
            {
                SetMenuAuthentication();
                this.Text = ConfigurationManager.AppSettings["ApplicationName"].ToString();
                lblUserLoggedIn.Text = clsGlobalClass.userFullName + " (" + clsGlobalClass.userDesignation + ")";
                lblWorkStation.Text = clsGlobalClass.workStationIP.ToString() + " => " + Program.dataServerIP;
                lblCurrentVersion.Text = clsGlobalClass.currentVersion.ToString();
                lblDeveloperEMail.Text = "Please feel free to contact me at " + ConfigurationManager.AppSettings["developerEMail"].ToString();
                dtpDataDate.Value = DateTime.Now.AddDays(-30);
                clsCommonFunctions.CheckIfProductionDB(pbStaging);
                PopulateChartData();
            }
            catch (Exception ex) { ex.ProcessException(); }
        }


        private void PopulateChartData()
        {
            bllGlobal b = new bllGlobal
            {
                StartDate = dtpDataDate.Value
            };
            b.GetSummaryDataForMainScreen();
            btnTotalCollection.Text = "Total Collection\n" + b.Collection.FormatAsMoney(true);
            btnUnitSold.Text = "Unit(s) Sold\n" + b.UnitSold.FormatAsMoney();
            btnUnitCancelled.Text = "Unit(s) Cancelled\n" + b.UnitCancelled.FormatAsMoney();
        }


        private void SetMenuAuthentication()
        {
            try
            {
                List<string> lstArray = new List<string>();
                foreach (System.Data.DataRow drItems in bLayer.GetActiveMenuList().Tables[0].Rows) { lstArray.Add(drItems["MenuKey"].ToString()); }
                if (clsGlobalClass.userId.ToUpper() != "ADMIN")
                {
                    foreach (ToolStripMenuItem rootMenu in msMainForm.Items)
                    {
                        foreach (ToolStripDropDownItem mnuLevel1 in rootMenu.DropDownItems)
                        {
                            if (mnuLevel1.Name.Substring(0, 4) == "tsmi") { mnuLevel1.Visible = lstArray.Contains(mnuLevel1.Name) ? true : false; }
                            foreach (ToolStripDropDownItem mnuLevel2 in mnuLevel1.DropDownItems)
                            {
                                if (mnuLevel2.Name.Substring(0, 4) == "tsmi") { mnuLevel2.Visible = lstArray.Contains(mnuLevel2.Name) ? true : false; }
                                foreach (ToolStripDropDownItem mnuLevel3 in mnuLevel2.DropDownItems)
                                {
                                    if (mnuLevel3.Name.Substring(0, 4) == "tsmi") { mnuLevel3.Visible = lstArray.Contains(mnuLevel3.Name) ? true : false; }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason != CloseReason.ApplicationExitCall)
                {
                    if (MessageBox.Show("Are you sure you want to exit?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Program.CloseDBConnection();
                        GC.Collect();
                        Application.Exit();
                    }
                    else { e.Cancel = true; }
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void tsmiProjectInformation_Click(object sender, EventArgs e)
        {
            try { projectInformation = ShowOrActiveForm(projectInformation, typeof(frmProjectInformation)) as frmProjectInformation; }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void tsmiUserAuthentication_Click(object sender, EventArgs e)
        {
            try { userAuthentication = ShowOrActiveForm(userAuthentication, typeof(frmUserAuthentication)) as frmUserAuthentication; }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void tsmiUnitInformation_Click(object sender, EventArgs e)
        {
            try { unitInformation = ShowOrActiveForm(unitInformation, typeof(frmUnitInformation)) as frmUnitInformation; }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            try { about = ShowOrActiveForm(about, typeof(frmAbout)) as frmAbout; }
            catch (Exception ex) { ex.ProcessException(); }


            //try { sandBox = ShowOrActiveForm(sandBox, typeof(frmSandBox)) as frmSandBox; }
            //catch (Exception ex) { throw ex; }
        }

        private void tsmiClientInformation_Click(object sender, EventArgs e)
        {
            try { clientInfo = ShowOrActiveForm(clientInfo, typeof(frmClientInformation)) as frmClientInformation; }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try { PopulateChartData(); }
            catch (Exception ex) { ex.ProcessException(); }

        }

        private void btnTotalCollection_Click(object sender, EventArgs e)
        {
            frmRoot_Collection collection = new frmRoot_Collection();
            collection.dtpStartDate.Value = dtpDataDate.Value;
            collection.ShowDialog();
        }

        private void btnUnitSold_Click(object sender, EventArgs e)
        {
            PopulateChartData();
            frmRoot_SoldList soldList = new frmRoot_SoldList();
            soldList.dtpStartDate.Value = dtpDataDate.Value;
            soldList.ShowDialog();
        }

        private void btnUnitCancelled_Click(object sender, EventArgs e)
        {
            PopulateChartData();
            frmRoot_CancelList cancelList = new frmRoot_CancelList();
            cancelList.dtpStartDate.Value = dtpDataDate.Value;
            cancelList.ShowDialog();
        }

        private void tsmiPayment_Click(object sender, EventArgs e)
        {
            try { payment = ShowOrActiveForm(payment, typeof(frmPayment)) as frmPayment; }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void tsmiChequeManagement_Click(object sender, EventArgs e)
        {
            try { chequeManagement = ShowOrActiveForm(chequeManagement, typeof(frmChequeManagement)) as frmChequeManagement; }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void tsmiClientReports_Click(object sender, EventArgs e)
        {
            try { generalReport = ShowOrActiveForm(generalReport, typeof(frmGeneralReports)) as frmGeneralReports; }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void tsmiProjectReports_Click(object sender, EventArgs e)
        {
            try { projectReport = ShowOrActiveForm(projectReport, typeof(frmProjectReports)) as frmProjectReports; }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void tsmiSummarizedSalesReport_Click(object sender, EventArgs e)
        {
            try { summarizedSalesReport = ShowOrActiveForm(summarizedSalesReport, typeof(frmSummarizedSalesReport)) as frmSummarizedSalesReport; }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void tsmiRecoveryReports_Click(object sender, EventArgs e)
        {
            try { recoveryReport = ShowOrActiveForm(recoveryReport, typeof(frmRecoveryReports)) as frmRecoveryReports; }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void tsmiRegistrationProcess_Click(object sender, EventArgs e)
        {
            try { unitRegistration = ShowOrActiveForm(unitRegistration, typeof(frmUnitRegistration)) as frmUnitRegistration; }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void tsmiAmountTransfer_Click(object sender, EventArgs e)
        {
            try
            { amountTransfer = ShowOrActiveForm(amountTransfer, typeof(frmAmountTransfer)) as frmAmountTransfer; }
            catch (Exception ex) { ex.ProcessException(); }
        }
    }
}
