using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Utilities;
using RealEstateManagementSystem.Reports;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RealEstateManagementSystem.UserInterface.Root
{
    public partial class frmRoot_Collection : Form
    {

        
        public frmRoot_Collection()
        {
            InitializeComponent();
        }

        private void frmRoot_Collection_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            try
            {
                lstTransactionList.Items.Clear();
                this.Text = "Collection details since " + dtpStartDate.Value.ToString("DDDD, dd MMM, yyyy");
                bllGlobal b = new bllGlobal();
                decimal totalCollection = 0;
                foreach (DataRow drItems in b.GetCollectionDetails(dtpStartDate.Value).Rows)
                {
                    ListViewItem lvItems = new ListViewItem(Convert.ToString(drItems["FullClientId"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["ClientName"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["BookingDate"]).ShowAsStandardDateFormat());
                    lvItems.SubItems.Add(Convert.ToString(drItems["Allocation"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["PaymentStatus"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["PaymentMode"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["TransactionDate"]).ShowAsStandardDateFormat());
                    lvItems.SubItems.Add(Convert.ToString(drItems["Amount"]).ConvertToDecimal().FormatAsMoney(false, true, true));
                    lvItems.SubItems.Add(Convert.ToString(drItems["Remarks"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["CurrentDue"]).ConvertToDecimal().FormatAsMoney(false, true, true));
                    lvItems.ForeColor = Convert.ToString(drItems["IsPaymentAllowed"]).ConvertToBoolean() == true ? Color.Black : Color.Red;
                    if (drItems["IsPaymentAllowed"].ToString().ConvertToBoolean() == true)
                    {
                        totalCollection = totalCollection + Convert.ToString(drItems["Amount"]).ConvertToDecimal();
                    }
                    lstTransactionList.Items.Add(lvItems);
                    lblRecordCount.Text = "Total Collection: " + totalCollection.FormatAsMoney(true, true, true);
                }
            }
            catch (Exception ex) { ex.ProcessException(tssStatus); }

        }

        private void lstTransactionList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstTransactionList_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && lstTransactionList.Items.Count > 0 && lstTransactionList.SelectedItems.Count > 0)
            {
                ContextMenu c = new ContextMenu();
                MenuItem clientProfile = new MenuItem("Profile", clientProfile_OnClick);
                MenuItem paymentSchedule = new MenuItem("Payment Schedule", paymentSchedule_OnClick);
                MenuItem paymentHistory = new MenuItem("Payment History", paymentHistory_OnClick);
                MenuItem sep1 = new MenuItem("-");
                c.MenuItems.Add("ClientId # " + lstTransactionList.SelectedItems[0].Text.ToString());
                c.MenuItems.Add(sep1);
                c.MenuItems.Add(clientProfile);
                c.MenuItems.Add(paymentSchedule);
                c.MenuItems.Add(paymentHistory);
                c.Show((Control)sender, e.Location);
            }
        }

        private void paymentHistory_OnClick(object sender, EventArgs e)
        {
            try { clsReports.PaymentHistoryOfClient(Convert.ToString(clsCommonFunctions.GetNumericPartOfFullClientId(lstTransactionList.SelectedItems[0].Text.ToString())), tssStatus); }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void paymentSchedule_OnClick(object sender, EventArgs e)
        {
            try { clsReports.PaymentSchedule(Convert.ToString(clsCommonFunctions.GetNumericPartOfFullClientId(lstTransactionList.SelectedItems[0].Text.ToString())), true, tssStatus); }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void clientProfile_OnClick(object sender, EventArgs e)
        {
            try { clsReports.ClientProfile(lstTransactionList.SelectedItems[0].Text.ToString(), tssStatus); }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }
    }
}
