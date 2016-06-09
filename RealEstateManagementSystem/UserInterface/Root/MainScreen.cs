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

namespace RealEstateManagementSystem.UserInterface.Root
{
    public partial class MainScreen : Form
    {
        bllUserControl bLayer = new bllUserControl();
        private frmProjectInformation projectInformation = null;

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
                this.Text = clsGlobalClass.applicationName.ToString();
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
                }
            }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }
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
    }
}
