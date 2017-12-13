using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Reports;
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
    public partial class frmRoot_SoldList : Form
    {
        public frmRoot_SoldList()
        {
            InitializeComponent();
        }

        private void frmRoot_SoldList_Load(object sender, EventArgs e)
        {
            LoadClientlist();
        }

        private void LoadClientlist()
        {
            try
            {
                this.Text = "List of unit(s) sold since " + dtpStartDate.Value.ToString("dddd, MMM dd, yyyy");
                bllGlobal b = new bllGlobal();
                foreach (DataRow drItems in b.GetRootSoldList(dtpStartDate.Value).Rows)
                {
                    ListViewItem lvItems = new ListViewItem(Convert.ToString(drItems["ClientId"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["Name"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["ContactNumber"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["ProjectName"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["UnitNumber"]));
                    lvItems.SubItems.Add(Convert.ToDecimal(drItems["FaceValue"]).FormatAsMoney());
                    lvItems.SubItems.Add(Convert.ToDecimal(drItems["Rebate"]).FormatAsMoney());
                    lvItems.SubItems.Add(Convert.ToDecimal(drItems["SaleValue"]).FormatAsMoney());
                    lvItems.SubItems.Add(Convert.ToDecimal(drItems["Paid"]).FormatAsMoney());
                    lvItems.SubItems.Add(Convert.ToString(drItems["BookingDate"]).ShowAsStandardDateFormat(true));
                    lstSold.Items.Add(lvItems);
                }
                lblRecordCount.Text = "# of Sold unit: " + lstSold.Items.Count.ToString();
            }
            catch (Exception ex) { ex.ProcessException(tssSoldCount); }
        }

        private void lstSold_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && lstSold.Items.Count > 0 && lstSold.SelectedItems.Count > 0)
            {
                ContextMenu c = new ContextMenu();
                MenuItem clientProfile = new MenuItem("Profile", clientProfile_OnClick);
                MenuItem paymentSchedule = new MenuItem("Payment Schedule", paymentSchedule_OnClick);
                MenuItem paymentHistory = new MenuItem("Payment History", paymentHistory_OnClick);
                MenuItem sep1 = new MenuItem("-");
                c.MenuItems.Add("ClientId # " + lstSold.SelectedItems[0].Text.ToString());
                c.MenuItems.Add(sep1);
                c.MenuItems.Add(clientProfile);
                c.MenuItems.Add(paymentSchedule);
                c.MenuItems.Add(paymentHistory);
                c.Show((Control)sender, e.Location);
            }
        }

        private void paymentHistory_OnClick(object sender, EventArgs e)
        {
            try { clsReports.PaymentHistoryOfClient(Convert.ToString(clsCommonFunctions.GetNumericPartOfFullClientId(lstSold.SelectedItems[0].Text.ToString())), tssSoldCount); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void paymentSchedule_OnClick(object sender, EventArgs e)
        {
            try { clsReports.PaymentSchedule(Convert.ToString(clsCommonFunctions.GetNumericPartOfFullClientId(lstSold.SelectedItems[0].Text.ToString())), true, tssSoldCount); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void clientProfile_OnClick(object sender, EventArgs e)
        {
            try { clsReports.ClientProfile(lstSold.SelectedItems[0].Text.ToString(), tssSoldCount); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadClientlist();
        }
    }
}
