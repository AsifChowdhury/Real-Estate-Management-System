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

namespace RealEstateManagementSystem.UserInterface.Root
{
    public partial class frmSearchClient : Form
    {

        bllGlobal b = new bllGlobal();
        public frmSearchClient()
        {
            InitializeComponent();
        }

        private void frmSearchClient_Load(object sender, EventArgs e)
        {
            
            clsCommonFunctions.PopulateListOfProjects(cmbProjectName, clsGlobalClass.ProjectStatus.All);
            //clsCommonFunctions.AutoFormatListViews(this);
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            clsCommonFunctions.PopulateListOfProjects(cmbProjectName, clsGlobalClass.ProjectStatus.All);
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgSearch.Value = e.ProgressPercentage;
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label4.Text = lvSearchResult.Items.Count.ToString() + Resources.strRecordsFound;
        }

        private void cmbProjectName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PopulateSearchResult();
        }

        private void PopulateSearchResult()
        {
            lvSearchResult.Items.Clear();
            b.ProjectId = cmbProjectName.SelectedValue.ToString().ConvertToInt32();
            b.ClientName = txtClientName.Text.ToString();
            b.UnitNumber = txtUnitNumber.Text.ToString();

            foreach (DataRow drItems in b.GetListOfClients().Rows)
            {
                ListViewItem lvItem = new ListViewItem(Convert.ToString(drItems["ClientId"]));
                lvItem.SubItems.Add(Convert.ToString(drItems["BookingDate"]).ShowAsStandardDateFormat());
                lvItem.SubItems.Add(Convert.ToString(drItems["Name"]));
                lvItem.SubItems.Add(Convert.ToString(drItems["UnitNumber"]));
                lvItem.SubItems.Add(Convert.ToString(drItems["ContactNumber"]));
                lvItem.ForeColor = Convert.ToString(drItems["IsCancelled"]).ConvertToBoolean() == false ? Color.Black : Color.Red;
                lvSearchResult.Items.Add(lvItem);
            }
            lblRecordsFound.Text = lvSearchResult.Items.Count.ToString() + " Record(s) Found";
            //clsCommonFunctions.PopulateListViewFromDataTable(b.GetListOfClients(), lvSearchResult, lblRecordsFound, false);
        }

        private void txtUnitNumber_TextChanged(object sender, EventArgs e)
        {
            PopulateSearchResult();
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            PopulateSearchResult();
        }

        private void lvSearchResult_DoubleClick(object sender, EventArgs e)
        {
            if (lvSearchResult.SelectedItems.Count < 1 || lvSearchResult.Items.Count < 1) return;
            clsGlobalClass.clientId = lvSearchResult.SelectedItems[0].Text.ToString();
            this.Dispose();
        }

        private void lvSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
