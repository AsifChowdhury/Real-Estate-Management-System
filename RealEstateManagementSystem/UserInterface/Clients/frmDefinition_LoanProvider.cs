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
using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;

namespace RealEstateManagementSystem.UserInterface.Clients
{
    public partial class frmDefinition_LoanProvider : Form
    {
        bllFinancialInstitute bLayer = new bllFinancialInstitute();
        public frmDefinition_LoanProvider()
        {
            InitializeComponent();
        }

        private void frmDefinition_LoanProvider_Load(object sender, EventArgs e)
        {
            clsCommonFunctions.AutoFormatListViewControl(lstInstitutes);
            PopulateInstituteList();
        }

        private void PopulateInstituteList()
        {
            string strQuery = "SELECT ProviderId, ProviderName, Initial, Recipient, ContactNumber FROM defLoanProvider ORDER BY ProviderName";
            clsCommonFunctions.PopulateListViewsFromSingleLineQuery(strQuery, lstInstitutes, null, true);
        }

        private void lstInstitutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstInstitutes.Items.Count < 1 || lstInstitutes.SelectedItems.Count < 1) return;
            FinancialInstitute fi = new FinancialInstitute();
            fi.LoanProviderId = lstInstitutes.SelectedItems[0].Text.ToString().ConvertToInt32();
            bLayer.GetFinancialInstituteInformation(fi);
            txtInstitutionName.Text = fi.LoanProviderName;
            txtInitial.Text = fi.Initial;
            txtAddress.Text = fi.Address;
            txtContactPerson.Text = fi.Recipient;
            txtContactNumber.Text = fi.ContactNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strMessage = lstInstitutes.SelectedItems.Count > 0 ? "Are you sure about update the information of Financial Institution: " + lstInstitutes.SelectedItems[0].SubItems[1].Text.ToString() : "Are you sure about insert new financial institution?";
                if (MessageBox.Show(strMessage, Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                FinancialInstitute fi = new FinancialInstitute();
                fi.LoanProviderId = lstInstitutes.SelectedItems.Count > 0 ? lstInstitutes.SelectedItems[0].Text.ToString().ConvertToInt32() : 0;
                fi.LoanProviderName = txtInstitutionName.Text;
                fi.Initial = txtInitial.Text.ToString();
                fi.Address = txtAddress.Text.ToString();
                fi.Recipient = txtContactPerson.Text.ToString();
                fi.ContactNumber = txtContactNumber.Text.ToString();
                bLayer.ManipulateFinancialInstitution(fi);
                MessageBox.Show(Resources.strSuccessMessage, Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            clsCommonFunctions.ResetTextBoxes(this);
            PopulateInstituteList();
        }
    }
}
