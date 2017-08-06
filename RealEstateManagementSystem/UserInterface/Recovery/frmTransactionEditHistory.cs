using RealEstateManagementSystem.BusinessLogicLayer;
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

namespace RealEstateManagementSystem.UserInterface.Recovery
{
    public partial class frmTransactionEditHistory : Form
    {
        public int transactionId = 0;
        public frmTransactionEditHistory()
        {
            InitializeComponent();
        }

        private void frmTransactionEditHistory_Load(object sender, EventArgs e)
        {
            try
            {
                bllPayment b = new bllPayment();
                lstTransactionHistory.Items.Clear();
                foreach (DataRow drItems in b.GetTransactionUpdateHostory(transactionId).Rows)
                {
                    ListViewItem lvItems = new ListViewItem(Convert.ToString(drItems["StatusName"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["InstallmentName"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["TransactionDate"]).ShowAsStandardDateFormat(true));
                    lvItems.SubItems.Add(Convert.ToDecimal(drItems["AmountPaid"]).FormatAsMoney(true, false, true));
                    lvItems.SubItems.Add(Convert.ToString(drItems["PaymentMode"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["ParticularsDate"]).ShowAsStandardDateFormat(false));
                    lvItems.SubItems.Add(Convert.ToString(drItems["Particulars"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["Remarks"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["BankInfo"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["BankAccountNumber"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["CancelReason"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["UpdateReason"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["UpdatedBy"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["UpdatedOn"]).ShowAsStandardDateFormat(true));
                    lstTransactionHistory.Items.Add(lvItems);
                }
            }
            catch (Exception ex) { ex.ProcessException(); }

        }
    }
}
