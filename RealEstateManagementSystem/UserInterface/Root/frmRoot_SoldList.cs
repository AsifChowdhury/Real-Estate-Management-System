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
        public DateTime startDate;
        public frmRoot_SoldList()
        {
            InitializeComponent();
        }

        private void frmRoot_SoldList_Load(object sender, EventArgs e)
        {
            this.Text = "List of unit(s) sold since " + startDate.ToString("dddd dd-MMM-yyyy");
            bllGlobal b = new bllGlobal();
            foreach (DataRow drItems in b.GetRootSoldList(startDate).Rows)
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
            tssSoldCount.Text = "# of Sold unit: " + lstSold.Items.Count.ToString();
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
            clsGlobalClass.ShowUnderConstructionMessage();
        }

        private void paymentSchedule_OnClick(object sender, EventArgs e)
        {
            clsGlobalClass.ShowUnderConstructionMessage();
        }

        private void clientProfile_OnClick(object sender, EventArgs e)
        {
            try { clsReports.ShowReport_ClientProfile(lstSold.SelectedItems[0].Text.ToString(), tssSoldCount); }
            catch (Exception ex) { ex.Display(); }
        }
    }
}
