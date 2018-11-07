using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;
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

namespace RealEstateManagementSystem.UserInterface.Clients
{
    public partial class frmUnitRegistration : Form
    {
        bllUnitRegistrationInfo bLayer = new bllUnitRegistrationInfo();
        public frmUnitRegistration()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void frmUnitRegistration_Load(object sender, EventArgs e)
        {
            clsCommonFunctions.PopulateListOfProjects(cmbProjectName, true);
        }

        private void cmbProjectName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PopulateProjectData(cmbProjectName.SelectedValue.ToString().ConvertToInt32());
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void PopulateProjectData(int projectId)
        {
            if (cmbProjectName.Items.Count > 0 && cmbProjectName.SelectedValue.ToString().ConvertToInt32() > 0)
            {
                lvClientData.Items.Clear();
                
                DataTable dt = bllUnitRegistrationInfo.GetUnitRegistrationList(projectId);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow drItem in dt.Rows)
                    {
                        ListViewItem lvItem = new ListViewItem(Convert.ToString(drItem["UnitNumber"]));
                        lvItem.SubItems.Add(Convert.ToString(drItem["FullClientId"]));
                        lvItem.SubItems.Add(Convert.ToString(drItem["Name"]));
                        lvItem.SubItems.Add(!DBNull.Value.Equals(drItem["RegistrationDate"]) ? Convert.ToString(drItem["RegistrationDate"]).ShowAsStandardDateFormat() : "");
                        lvItem.SubItems.Add(Convert.ToString(drItem["DeedNumber"]));
                        lvItem.SubItems.Add(Convert.ToString(drItem["Loan"]) == "1" ? "Y" : "N");
                        lvItem.SubItems.Add(Convert.ToString(drItem["LandArea"]));
                        lvItem.SubItems.Add(!DBNull.Value.Equals(drItem["DeedDeliveryDate"]) ? Convert.ToString(drItem["DeedDeliveryDate"]).ShowAsStandardDateFormat() : "");
                        lvItem.SubItems.Add(Convert.ToDecimal(drItem["DeedValue"]).FormatAsMoney());
                        lvItem.SubItems.Add(Convert.ToDecimal(drItem["ITFee"]).FormatAsMoney());
                        lvItem.SubItems.Add(Convert.ToDecimal(drItem["RegistrationFee"]).FormatAsMoney());
                        lvItem.SubItems.Add(Convert.ToDecimal(drItem["VAT"]).FormatAsMoney());
                        lvItem.Tag = Convert.ToString(drItem["ClientId"]);
                        lvClientData.Items.Add(lvItem);
                    }
                }
            }
        }

        private void RefreshForm()
        {
            dtpRegistrationDate.Value = dtpDeedDeliveryDate.Value = DateTime.Now;
            dtpRegistrationDate.Checked = dtpDeedDeliveryDate.Checked = chkLoan.Checked = false;
            txtLandArea.Text = txtDeedNumber.Text = txtDeedValue.Text = txtITFee.Text = txtRegistrationFee.Text = txtVAT.Text = "0";
            txtClientId.Text = txtClientName.Text = txtUnitNumber.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvClientData.SelectedItems.Count == 0)
                {
                    string err = "Please select at lease one client data from the list to save registration info.";
                    throw new ApplicationException(err);
                }
                if (MessageBox.Show(Resources.strConfirmationMessage, Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);

                UnitRegistrationInfo ur = new UnitRegistrationInfo();
                ur.ClientId = lvClientData.SelectedItems[0].Tag.ToString().ConvertToInt32();
                ur.IsRegistered = dtpRegistrationDate.Checked;
                ur.RegistratrionDate = dtpRegistrationDate.Value;
                ur.LandArea = txtLandArea.Text.ConvertToDecimal();
                ur.Loan = chkLoan.Checked;
                ur.IsDeedDelivered = dtpDeedDeliveryDate.Checked;
                ur.DeedDeliveryDate = dtpDeedDeliveryDate.Value;
                ur.DeedNumber = txtDeedNumber.Text.ConvertToInt32();
                ur.DeedValue = txtDeedValue.Text.ConvertToDecimal();
                ur.ITFee = txtITFee.Text.ConvertToDecimal();
                bLayer.SaveRegistrationData(ur);
                MessageBox.Show(Resources.strSuccessMessage, Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateProjectData(cmbProjectName.SelectedValue.ToString().ConvertToInt32());
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void lvClientData_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvClientData.Items.Count == 0 || lvClientData.SelectedItems.Count == 0) { return; }
                int clientId = lvClientData.SelectedItems[0].Tag.ToString().ConvertToInt32();
                UnitRegistrationInfo ur = new UnitRegistrationInfo();
                ur.ClientId = clientId;
                bLayer.GetClientRegistrationData(ur);
                txtClientId.Text = ur.FullClientId;
                txtClientName.Text = ur.ClientName_English;
                txtUnitNumber.Text = ur.UnitSummary;

                dtpRegistrationDate.Value = ur.RegistratrionDate.returnFalseIfNullDate() == true ? ur.RegistratrionDate : DateTime.Now;
                dtpRegistrationDate.Checked = ur.IsRegistered;
                txtLandArea.Text = ur.LandArea.ToString();
                chkLoan.Checked = ur.Loan;
                dtpDeedDeliveryDate.Value = ur.DeedDeliveryDate.returnFalseIfNullDate() == true ? ur.DeedDeliveryDate : DateTime.Now;
                dtpDeedDeliveryDate.Checked = ur.IsDeedDelivered;

                txtDeedNumber.Text = Convert.ToString(ur.DeedNumber);
                txtITFee.Text = ur.ITFee.FormatAsMoney();
                txtDeedValue.Text = ur.DeedValue.FormatAsMoney();
                txtRegistrationFee.Text = ur.RegistrationFee.FormatAsMoney();
                txtVAT.Text = ur.VAT.FormatAsMoney();

            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void txt_FormatAsMoney(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text != "" && ((TextBox)sender).Text.ConvertToDecimal() > 0 ? ((TextBox)sender).Text.ConvertToDecimal().FormatAsMoney() : "0";

        }

        private void btnAcknowlegementReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                if ((lvClientData.SelectedItems.Count == 0 && lvClientData.CheckedItems.Count == 0) || lvClientData.Items.Count == 0) return;
                string clientIds = lvClientData.CheckedItems.Count > 0 ? clsCommonFunctions.convertToCommaSeperatedValueFromItemTag(lvClientData) : lvClientData.SelectedItems[0].Tag.ToString();
                clsReports.RegistrationAcknowledgementReceipt(clientIds, tssStatus);
            }
            catch (Exception ex) { ex.ProcessException(tssStatus); }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string clientIds = lvClientData.CheckedItems.Count > 0 ? clsCommonFunctions.convertToCommaSeperatedValueFromItemTag(lvClientData) : "";
                clsReports.RegistrationList(projectId: cmbProjectName.SelectedValue.ToString().ConvertToInt32(), clientIds: clientIds, tssStatus: tssStatus);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }
    }
}
