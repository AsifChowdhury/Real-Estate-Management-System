using RealEstateManagementSystem.BusinessLogicLayer;
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

namespace RealEstateManagementSystem.UserInterface.Root
{
    public partial class frmRoot_CancelList : Form
    {
        public frmRoot_CancelList()
        {
            InitializeComponent();
        }

        private void frmRoot_CancelList_Load(object sender, EventArgs e)
        {
            LoadClientList();
        }

        private void LoadClientList()
        {
            try
            {
                this.Text = "List of Cancelled Client since " + dtpStartDate.Value.ToString("dddd, MMM dd, yyyy");
                bllGlobal b = new bllGlobal();
                foreach (DataRow drItems in b.GetRootCancelledList(dtpStartDate.Value).Rows)
                {
                    ListViewItem lvItems = new ListViewItem(Convert.ToString(drItems["ClientId"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["Name"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["ContactNumber"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["ProjectName"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["UnitNumber"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["CancelDate"]).ShowAsStandardDateFormat(false));
                    lstcancelList.Items.Add(lvItems);
                }
                lblRecordCount.Text = "Total # of Cancelled Unit(s): " + lstcancelList.Items.Count;
            }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void lstcancelList_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && lstcancelList.Items.Count > 0 && lstcancelList.SelectedItems.Count > 0)
            {
                ContextMenu c = new ContextMenu();
                MenuItem clientProfile = new MenuItem("Profile", clientProfile_OnClick);
                MenuItem paymentSchedule = new MenuItem("Payment Schedule", paymentSchedule_OnClick);
                MenuItem paymentHistory = new MenuItem("Payment History", paymentHistory_OnClick);
                MenuItem sep1 = new MenuItem("-");
                c.MenuItems.Add("ClientId # " + lstcancelList.SelectedItems[0].Text.ToString());
                c.MenuItems.Add(sep1);
                c.MenuItems.Add(clientProfile);
                c.MenuItems.Add(paymentSchedule);
                c.MenuItems.Add(paymentHistory);
                c.Show((Control)sender, e.Location);
            }
        }

        private void paymentHistory_OnClick(object sender, EventArgs e)
        {
            try { clsReports.PaymentHistoryOfClient(Convert.ToString(clsCommonFunctions.GetNumericPartOfFullClientId(lstcancelList.SelectedItems[0].Text.ToString())), tssStatus); }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void paymentSchedule_OnClick(object sender, EventArgs e)
        {
            try { clsReports.PaymentSchedule(Convert.ToString(clsCommonFunctions.GetNumericPartOfFullClientId(lstcancelList.SelectedItems[0].Text.ToString())), true, tssStatus); }
            catch (Exception ex) { ex.ProcessException(tssStatus); }

        }

        private void clientProfile_OnClick(object sender, EventArgs e)
        {
            try { clsReports.ClientProfile(lstcancelList.SelectedItems[0].Text.ToString(), tssStatus); }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadClientList();
        }
    }
}
