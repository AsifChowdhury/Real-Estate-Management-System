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

namespace RealEstateManagementSystem.UserInterface.Reports
{
    public partial class frmHandoverProcess : Form
    {
        public int clientId = 0;
        public frmHandoverProcess()
        {
            InitializeComponent();
        }

        private void frmHandoverProcess_Load(object sender, EventArgs e)
        {
            txtClientId.Text = clsCommonFunctions.GetFullClientId(clientId.ToString());
            PopulatePaymentSummary();
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT PFNumber, EmployeeName FROM Employee WHERE Active = 1", "EmployeeName", "PFNumber", false,
                                                                           cmbHO_ForwardedBy
                                                                         , cmbHO_RecommendedBy
                                                                         , cmbPC_CheckedBy
                                                                         , cmbPC_RecommendedBy
                                                                         , cmbPC_VerifiedBy);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT CompanyId, Name FROM defProjectEngineer WHERE CompanyId IS NOT NULL AND CompanyId > 0", "Name", "CompanyId", false, cmbKey_ProjectEngineer, cmbHO_HandoverBy);
            cmbPC_VerifiedBy.Text = clsCommonFunctions.GetDefaultValue("PCC_VerifiedBy");
            cmbPC_CheckedBy.Text = clsCommonFunctions.GetDefaultValue("PCC_CheckedBy");
            cmbPC_RecommendedBy.Text = clsCommonFunctions.GetDefaultValue("PCC_RecommendedBy");
            cmbHO_ForwardedBy.Text = clsCommonFunctions.GetDefaultValue("HOC_ForwardedByBy");
            cmbHO_RecommendedBy.Text = clsCommonFunctions.GetDefaultValue("HOC_RecommendedBy");


            bllPayment check = new bllPayment();
            pbHandover.Visible = check.IsHandoverCertficateDelivered(clientId);
            pbKeyList.Visible = check.IsKeyListDelivered(clientId);

        }

        private void PopulatePaymentSummary()
        {
            lstPaymentClearance.Items.Clear();
            bllPayment clearance = new bllPayment();

            foreach (DataRow drItems in clearance.GetSummartForPaymentClearance(clientId).Rows)
            {
                ListViewItem lvItems = new ListViewItem(drItems["PaymentType"].ToString());
                lvItems.SubItems.Add(drItems["ShowData"].ToString().ConvertToBoolean() == true
                                    ? drItems["Payable"].ToString().ConvertToDecimal().FormatAsMoney(false, true, true)
                                    : drItems["MakeBold"].ToString().ConvertToBoolean() == true ? "..." : string.Empty);
                lvItems.SubItems.Add(drItems["ShowData"].ToString().ConvertToBoolean() == true
                                    ? drItems["Paid"].ToString().ConvertToDecimal().FormatAsMoney(false, true, true)
                                    : drItems["MakeBold"].ToString().ConvertToBoolean() == true ? "..." : string.Empty);
                lvItems.SubItems.Add(drItems["ShowData"].ToString().ConvertToBoolean() == true
                                    ? drItems["Due"].ToString().ConvertToDecimal().FormatAsMoney(false, true, true)
                                    : drItems["MakeBold"].ToString().ConvertToBoolean() == true ? "..." : string.Empty);
                lvItems.ForeColor = drItems["MakeBold"].ToString().ConvertToBoolean() == true ? Color.Blue : Color.Black;
                lvItems.Font = new Font(lstPaymentClearance.Font, drItems["MakeBold"].ToString().ConvertToBoolean() == true ? FontStyle.Bold : FontStyle.Regular);
                lstPaymentClearance.Items.Add(lvItems);
            }
        }

        private void rbPaymentClearance_CheckedChanged(object sender, EventArgs e)
        {
            pnlPaymentClearance.Visible = rbPaymentClearance.Checked;
        }

        private void rbHandoverCertificate_CheckedChanged(object sender, EventArgs e)
        {
            pnlHandover.Visible = rbHandoverCertificate.Checked;
        }

        private void rbListOfKeys_CheckedChanged(object sender, EventArgs e)
        {
            pnlListOfKeys.Visible = rbListOfKeys.Checked;
        }

        private void btnGetCertificate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPaymentClearance.Checked == true)
                {
                    clsReports.PaymentClearanceCertificate(clientId, cmbPC_CheckedBy.SelectedValue.ToString().ConvertToInt32(), cmbPC_VerifiedBy.SelectedValue.ToString().ConvertToInt32(), cmbPC_RecommendedBy.SelectedValue.ToString().ConvertToInt32(), tssStatus);
                }
                else if (rbListOfKeys.Checked == true)
                {
                    clsReports.ListOfKeys(clientId, cmbKey_ProjectEngineer.SelectedValue.ToString().ConvertToInt32(), tssStatus);
                }
                else
                {
                    clsReports.HandoverCertificate(clientId: clientId,
                                                   handoverDate: dtpHandoverDate.Value,
                                                   handoverBy: cmbHO_HandoverBy.SelectedValue.ToString().ConvertToInt32(),
                                                   forwardedBy: cmbHO_ForwardedBy.SelectedValue.ToString().ConvertToInt32(),
                                                   recommendedBy: cmbHO_RecommendedBy.SelectedValue.ToString().ConvertToInt32(),
                                                   tssStatus: tssStatus);
                }
            }
            catch (Exception ex) { ex.ProcessException(tssStatus); }

        }
    }
}
