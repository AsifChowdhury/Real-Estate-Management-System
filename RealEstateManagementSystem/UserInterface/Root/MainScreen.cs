using RealEstateManagementSystem.Properties;
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
using RealEstateManagementSystem.UserInterface.Projects;
using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.UserInterface.UserAuthentication;

namespace RealEstateManagementSystem.UserInterface.Root
{
    public partial class MainScreen : Form
    {
        bllUserControl bLayer = new bllUserControl();
        private frmProjectInformation projectInformation = null;
        private frmUserAuthentication userAuthentication = null;

        public MainScreen()
        {
            InitializeComponent();
        }

        private Form ShowOrActiveForm(Form form, Type t)
        {
            try
            {
                if (form == null)
                {
                    form = (Form)Activator.CreateInstance(t);
                    form.MdiParent = this;
                    form.Show();
                }
                else
                {
                    if (form.IsDisposed)
                    {
                        form = (Form)Activator.CreateInstance(t);
                        form.MdiParent = this;
                        form.Show();
                    }
                    else
                    {
                        form.Activate();
                    }
                }
                return form;
            }
            catch (Exception ex) { throw ex; }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            try
            {
                SetMenuAuthentication();
                //this.Text = clsGlobalClass.applicationName.ToString();
                this.Text = Properties.Resources.ApplicationName.ToString();
                foreach (Control control in this.Controls)
                {
                    if (control is MdiClient)
                    {
                        control.BackColor = Color.FromArgb(5, 16, 51);
                        break;
                    }
                    bLayer.UserId = clsGlobalClass.userId.ToString();
                    bLayer.GetUserDetails();
                    tssUserLoggedIn.Text = bLayer.EmployeeName.ToString();
                    tssDesignation.Text = bLayer.CurrentPosition.ToString();
                    tssWorkStationIP.Text = clsGlobalClass.workStationIP.ToString();
                    tssCurrentVersion.Text = clsGlobalClass.currentVersion.ToString();
                    tssConnectedServerIP.Text = Program.dataServerIP;
                }
            }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }
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
                            if (mnuLevel1.Name.Substring(0, 4) == "tsmi") { mnuLevel1.Enabled = lstArray.Contains(mnuLevel1.Name) ? true : false; }
                            foreach (ToolStripDropDownItem mnuLevel2 in mnuLevel1.DropDownItems)
                            {
                                if (mnuLevel2.Name.Substring(0, 4) == "tsmi") { mnuLevel2.Enabled = lstArray.Contains(mnuLevel2.Name) ? true : false; }
                                foreach (ToolStripDropDownItem mnuLevel3 in mnuLevel2.DropDownItems)
                                {
                                    if (mnuLevel3.Name.Substring(0, 4) == "tsmi") { mnuLevel3.Enabled = lstArray.Contains(mnuLevel3.Name) ? true : false; }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { throw ex; }
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
                        Application.Exit();
                    }
                    else { e.Cancel = true; }
                }
            }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }
        }

        private void tsmiProjectInformation_Click(object sender, EventArgs e)
        {
            try { projectInformation = ShowOrActiveForm(projectInformation, typeof(frmProjectInformation)) as frmProjectInformation; }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }
        }

        private void tsmiUserAuthentication_Click(object sender, EventArgs e)
        {
            try { userAuthentication = ShowOrActiveForm(userAuthentication, typeof(frmUserAuthentication)) as frmUserAuthentication; }
            catch (Exception ex) { throw ex; }
        }
    }
}
