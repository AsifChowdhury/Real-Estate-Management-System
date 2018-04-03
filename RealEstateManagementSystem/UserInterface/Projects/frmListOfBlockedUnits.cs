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
    public partial class frmListOfBlockedUnits : Form
    {
        bllProjectInfo bLayer = new bllProjectInfo();

        public frmListOfBlockedUnits()
        {
            InitializeComponent();
        }

        private void frmListOfBlockedUnits_Load(object sender, EventArgs e)
        {
            try { PopulateProjectsWithBlockedUnits(); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void PopulateProjectsWithBlockedUnits()
        {
            lstProjects.Items.Clear();
            foreach (DataRow drItems in bLayer.GetListOfProjectsWithBlockedUnit().Rows)
            {
                ListViewItem lvItems = new ListViewItem(Convert.ToString(drItems["ProjectId"]));
                lvItems.SubItems.Add(Convert.ToString(drItems["ProjectName"]));
                lvItems.SubItems.Add(Convert.ToString(drItems["Count"]));
                lstProjects.Items.Add(lvItems);
            }
        }

        private void lstProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { PopulateListOfBlockedUnits(); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void lstBlockedUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstBlockedUnits.Items.Count < 1 || lstBlockedUnits.SelectedItems.Count < 1) { return; }
                lstBlockingHistory.Items.Clear();
                foreach (DataRow drItems in bLayer.GetUnitBlockingHistory(lstBlockedUnits.SelectedItems[0].Text.ToString().ConvertToInt32()).Rows)
                //foreach (DataRow drItems in bLayer.GetListOfBlockedUnits('Project', clsGlobalClass.ProjectCommonReport_FilterBy.Area, lstBlockedUnits.SelectedItems[0].Text.ToString()).Rows)
                {
                    ListViewItem lvItems = new ListViewItem(Convert.ToString(drItems["BlockedBy"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["StartDate"]).ShowAsStandardDateFormat(true));
                    lvItems.SubItems.Add(Convert.ToString(drItems["EndDate"]).ShowAsStandardDateFormat(true));
                    lvItems.SubItems.Add(Convert.ToString(drItems["Remarks"]));
                    lstBlockingHistory.Items.Add(lvItems);
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void PopulateListOfBlockedUnits()
        {
            try
            {
                if (lstProjects.SelectedItems.Count < 1 || lstProjects.Items.Count < 1) { return; }
                lstBlockedUnits.Items.Clear();
                lstBlockingHistory.Items.Clear();
                int projectId = lstProjects.SelectedItems[0].Text.ToString().ConvertToInt32();
                DataTable dt = bLayer.GetListOfBlockedUnits("Project", clsGlobalClass.ProjectCommonReport_FilterBy.Area, projectId.ToString());
                foreach (DataRow drItems in dt.Rows)
                {
                    ListViewItem lvItems = new ListViewItem(Convert.ToString(drItems["UnitId"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["UnitNumber"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["UnitType"]));
                    lvItems.SubItems.Add(Convert.ToDecimal(drItems["UnitArea"]).FormatAsMoney(replaceZeroWithDash: true));
                    lvItems.SubItems.Add(Convert.ToDecimal(drItems["Rate"]).FormatAsMoney(replaceZeroWithDash: true));
                    lvItems.SubItems.Add(Convert.ToDecimal(drItems["UnitValue"]).FormatAsMoney(replaceZeroWithDash: true));
                    lstBlockedUnits.Items.Add(lvItems);
                }
            }
            catch (Exception ex) { ex.ProcessException(); }

        }

        private void lstBlockedUnits_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (lstBlockedUnits.Items.Count < 1 || lstBlockedUnits.SelectedItems.Count < 1) { return; }
                if (e.Button == MouseButtons.Right)
                {
                    ContextMenu cm = new ContextMenu();
                    MenuItem mi = new MenuItem("Unblock " + lstBlockedUnits.SelectedItems[0].SubItems[2].Text + " # " + lstBlockedUnits.SelectedItems[0].SubItems[1].Text + ".", mi_OnClick);
                    cm.MenuItems.Add(mi);
                    cm.Show((Control)sender, e.Location);
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void mi_OnClick(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedItem = lstBlockedUnits.SelectedItems[0];
                if (!string.IsNullOrEmpty(selectedItem.Text))
                {
                    if (MessageBox.Show("Sure about un-block <"+ selectedItem.SubItems[2].Text +" # " + selectedItem.SubItems[1].Text + ">?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser); ;
                    bLayer.UnitId = lstBlockedUnits.SelectedItems[0].Text.ConvertToInt32();
                    bLayer.UnBlockUnit(bLayer.UnitId);
                    MessageBox.Show("<"+ selectedItem.SubItems[2].Text + " # " + selectedItem.SubItems[1].Text + "> un-blocked successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateListOfBlockedUnits();
                    PopulateProjectsWithBlockedUnits();
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }
    }
}
