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
    public partial class frmClientInformation : Form
    {
        bllClientInfo bLayer = new bllClientInfo();
        string message = string.Empty;
        private enum EntryMode
        {
            New,
            Copy
        }
        public frmClientInformation()
        {
            InitializeComponent();
        }

        private void tpClientData_Click(object sender, EventArgs e)
        {

        }

        private void frmClientInformation_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateComboBoxes();
            }
            catch (Exception ex) { ex.ProcessException(); }

        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            try
            {

                clsCommonFunctions.SearchClient(txtClientId);
                if (txtClientId.Text != string.Empty) LoadClientData(strClientId: txtClientId.Text.ToString());
            }
            catch (Exception ex) { ex.ProcessException(); tssStatus.Text = Resources.strReadyStatus; }
        }

        private void btnLoadClientPhoto_Click(object sender, EventArgs e)
        {
            try { clsCommonFunctions.LoadImageToPictureBox(pbClientPhoto, 500, Resources.NoPhoto); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnClearClientPhoto_Click(object sender, EventArgs e)
        {
            pbClientPhoto.Image = Resources.NoPhoto;
        }

        private void btnClearClientSignature_Click(object sender, EventArgs e)
        {
            pbClientSignature.Image = Resources.NoSign;
        }

        private void txtClientId_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtClientId.Text == string.Empty)
                {
                    return;
                }
                if (clsCommonFunctions.CheckIfValidClientId(txtClientId.Text) == true)
                {
                    txtClientId.Text = clsCommonFunctions.GetFullClientId(txtClientId.Text.ToString());
                    LoadClientData(strClientId: txtClientId.Text.ToString());
                }
                else
                {
                    if (txtClientId.Text != string.Empty) MessageBox.Show("Please Insert a valid ClientId.", Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetForm(true);
                }
            }
            catch (Exception ex) { ex.ProcessException(); tssStatus.Text = Resources.strReadyStatus; }
        }


        private void AllowNumericOnly(object sender, KeyPressEventArgs e)
        {
            clsCommonFunctions.NumericTextBox(sender, e);
        }

        private void cmbClient_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT GuardianTypeId, GuardianType FROM defGuardianType WHERE Gender = '" + cmbClient_Gender.Text.ToString() + "' ORDER BY GuardianTypeID", "GuardianType", "GuardianTypeId", false, cmbClient_GuardianType);
            if (cmbClient_GuardianType.Items.Count > 0)
                GetCareOf(cmbClient_GuardianType.Text, cmbClient_GuardianType.SelectedValue.ToString().ConvertToInt32(), txtClient_FatherName_English, txtClient_FatherName_Bangla, txtClient_GuardianName_English, txtClient_GuardianName_Bangla, lblClient_CareOf);
        }

        private void cmbPartner_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT GuardianTypeId, GuardianType FROM defGuardianType WHERE Gender = '" + cmbPartner_Gender.Text.ToString() + "' ORDER BY GuardianTypeID", "GuardianType", "GuardianTypeId", false, cmbPartner_GuardianType);
            if (cmbPartner_GuardianType.Items.Count > 0)
                GetCareOf(cmbPartner_GuardianType.Text, cmbPartner_GuardianType.SelectedValue.ToString().ConvertToInt32(), txtPartner_FatherName_English, txtPartner_FatherName_Bangla, txtPartner_GuardianName_English, txtPartner_GuardianName_Bangla, lblPartner_CareOf);

        }


        private void txtPartner_GuardianName_TextChanged(object sender, EventArgs e)
        {
            if (cmbPartner_GuardianType.Text == "Father") txtPartner_FatherName_English.Text = txtPartner_GuardianName_English.Text;
        }

        private void txtPartner_GuardianName_Bangla_TextChanged(object sender, EventArgs e)
        {
            if (cmbPartner_GuardianType.Text == "Father") txtPartner_FatherName_Bangla.Text = txtPartner_GuardianName_Bangla.Text;
        }

        private void rbReferrer_SEL_CheckedChanged(object sender, EventArgs e)
        {
            cmbReferrer.Visible = rbReferrer_SEL.Checked;
        }

        private void rbReferrer_Client_CheckedChanged(object sender, EventArgs e)
        {
            txtReferrer.Visible = btnSearchReferrer.Visible = rbReferrer_Client.Checked;
        }

        private void btnSearchReferrer_Click(object sender, EventArgs e)
        {
            clsCommonFunctions.SearchClient(txtReferrer);
        }

        private void txtReferrer_Leave(object sender, EventArgs e)
        {
            try { txtReferrer.Text = !string.IsNullOrEmpty(txtReferrer.Text.ToString()) ? clsCommonFunctions.GetFullClientId(txtReferrer.Text.ToString()) : string.Empty; }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void AddNationality(object sender, EventArgs e)
        {
            frmDefinition_NOR nor = new frmDefinition_NOR();
            nor.rbNationality.Checked = true;
            nor.ShowDialog();
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT NationalityID, Nationality FROM defNationality ORDER BY NationalityId", "Nationality", "NationalityID", false, cmbClient_Nationality, cmbPartner_Nationality);
        }

        private void AddOccupation(object sender, EventArgs e)
        {
            frmDefinition_NOR nor = new frmDefinition_NOR();
            nor.rbOccupation.Checked = true;
            nor.ShowDialog();
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT OccupationId, Occupation FROM defOccupation ORDER BY Occupation", "Occupation", "OccupationId", false, cmbClient_Occupation, cmbPartner_Occupation);
        }

        private void AddReligion(object sender, EventArgs e)
        {
            frmDefinition_NOR nor = new frmDefinition_NOR();
            nor.rbReligion.Checked = true;
            nor.ShowDialog();
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT ReligionId, Religion FROM defReligion ORDER BY ReligionID", "Religion", "ReligionID", false, cmbClient_Religion, cmbPartner_Religion);
        }



        private void GetCareOf(string guardianType, int guardianTypeId, TextBox FatherName_English, TextBox FatherName_Bangla, TextBox GuardianName_English, TextBox GuardianName_Bangla, Label careOf)
        {
            if (guardianType == "Father")
            {
                FatherName_English.Text = GuardianName_English.Text;
                FatherName_Bangla.Text = GuardianName_Bangla.Text;
                FatherName_English.Enabled = FatherName_Bangla.Enabled = false;
            }
            else
            {
                FatherName_English.Text = FatherName_Bangla.Text = string.Empty;
                FatherName_English.Enabled = FatherName_Bangla.Enabled = true;
            }
            careOf.Text = bLayer.GetCareOfCaption(guardianTypeId);
        }


        private void cmbPartner_GuardianType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCareOf(cmbPartner_GuardianType.Text, cmbPartner_GuardianType.SelectedValue.ToString().ConvertToInt32(), txtPartner_FatherName_English, txtPartner_FatherName_Bangla, txtPartner_GuardianName_English, txtPartner_GuardianName_Bangla, lblPartner_CareOf);
            //if (cmbPartner_GuardianType.Text == "Father")
            //{
            //    txtPartner_FatherName_English.Text = txtPartner_GuardianName_English.Text;
            //    txtPartner_FatherName_Bangla.Text = txtPartner_GuardianName_Bangla.Text;
            //    txtPartner_FatherName_English.Enabled = txtPartner_FatherName_Bangla.Enabled = false;
            //}
            //else
            //{
            //    txtPartner_FatherName_English.Text = txtPartner_FatherName_Bangla.Text = string.Empty;
            //    txtPartner_FatherName_English.Enabled = txtPartner_FatherName_Bangla.Enabled = true;
            //}
            //lblPartner_CareOf.Text = bLayer.GetCareOfCaption(cmbPartner_GuardianType.SelectedValue.ToString().ConvertToInt32());
        }

        private void cmbClient_GuardianType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCareOf(cmbClient_GuardianType.Text, cmbClient_GuardianType.SelectedValue.ToString().ConvertToInt32(), txtClient_FatherName_English, txtClient_FatherName_Bangla, txtClient_GuardianName_English, txtClient_GuardianName_Bangla, lblClient_CareOf);
            //try
            //{
            //    if (cmbClient_GuardianType.Text == "Father")
            //    {
            //        txtClient_FatherName_English.Text = txtClient_GuardianName_English.Text;
            //        txtClient_FatherName_Bangla.Text = txtClient_GuardianName_Bangla.Text;
            //        txtClient_FatherName_English.Enabled = txtClient_FatherName_Bangla.Enabled = false;
            //    }
            //    else
            //    {
            //        txtClient_FatherName_English.Text = txtClient_FatherName_Bangla.Text = string.Empty;
            //        txtClient_FatherName_English.Enabled = txtClient_FatherName_Bangla.Enabled = true;
            //    }
            //    lblClient_CareOf.Text = bLayer.GetCareOfCaption(cmbClient_GuardianType.SelectedValue.ToString().ConvertToInt32());
            //}
            //catch (Exception ex) { ex.Display(); }

        }

        private void btnSave_ClientInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int newClientId = 0;
                PersonInformation pi = new PersonInformation();
                pi.ClientId = clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId.Text.ToString());
                message = pi.ClientId > 0 ? "Sure about update Client Information of Id # " + txtClientId.Text.ToString() : "Sure about insert new client information?";
                if (MessageBox.Show(message, Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    throw new ApplicationException(Resources.strCancelledByUser);
                }
                pi.ClientTypeId = cmbClientType.SelectedValue.ToString().ConvertToInt32();
                pi.UseSalutation = chkClient_Salutation.Checked;
                pi.ClientName_English = txtClient_Name_English.Text;
                pi.ClientName_Bangla = txtClient_Name_Bangla.Text;
                pi.Gender = cmbClient_Gender.Text;
                pi.GuardianTypeId = cmbClient_GuardianType.SelectedValue.ToString().ConvertToInt32();
                pi.GuardianName_Bangla = txtClient_GuardianName_Bangla.Text;
                pi.GuardianName_English = txtClient_GuardianName_English.Text;
                pi.FatherName_Bangla = txtClient_FatherName_Bangla.Text;
                pi.FatherName_English = txtClient_FatherName_English.Text;
                pi.MotherName_Bangla = txtClient_MotherName_Bangla.Text;
                pi.MotherName_English = txtClient_MotherName_English.Text;
                pi.NationalityReligionOccupation = new NationalityReligionOccupation();
                pi.NationalityReligionOccupation.NationalityId = cmbClient_Nationality.SelectedValue.ToString().ConvertToInt32();
                pi.NationalityReligionOccupation.OccupationId = cmbClient_Occupation.SelectedValue.ToString().ConvertToInt32();
                pi.NationalityReligionOccupation.ReligionId = cmbClient_Religion.SelectedValue.ToString().ConvertToInt32();
                pi.IsValidDateOfBirth = dtpClient_DateOfBirth.Checked;
                pi.DateOfBirth = dtpClient_DateOfBirth.Value;
                pi.MaritalStatusId = cmbClient_MaritalStatus.SelectedValue.ToString().ConvertToInt32();
                pi.IsValidMarriageDate = dtpClient_MarriageDate.Checked;
                pi.MarriageDate = dtpClient_MarriageDate.Value;
                pi.NationalIdNumber = txtClient_NationalId.Text;
                pi.TINNumber = txtClient_TINNumber.Text;
                pi.PassportNumber = txtClient_PassportNumber.Text;
                pi.CurrentAddress = txtCurrentAddress.Text;
                pi.CurrentCountryId = cmbCurrentCountry.SelectedValue.ToString().ConvertToInt32();
                pi.PostalAddress = txtPostalAddress.Text;
                pi.PostalCountryId = cmbPostalCountry.SelectedValue.ToString().ConvertToInt32();
                pi.PermanentAddress_Bangla = txtPermanentAddress_Bangla.Text;
                pi.ContactNumber = txtContactNumber.Text;
                pi.EMailAddress = txtEMailAddress.Text;
                pi.SMSContact = txtSMSContact.Text;
                pi.ClientPhoto = pbClientPhoto.Image;
                pi.ClientSignature = pbClientSignature.Image;
                pi.NeedBankLoan = chkNeedBankLoan.Checked;
                pi.LoanProvider = new FinancialInstitute();
                pi.LoanProvider.LoanProviderId = cmbLoanProvider.SelectedValue.ToString().ConvertToInt32();
                pi.IsReferredByClient = rbReferrer_Client.Checked;
                pi.Referrer = rbReferrer_Client.Checked == true ? txtReferrer.Text : cmbReferrer.Text;
                pi.SoldBy = cmbSoldBy.Text;
                pi.SaleOffer = new SaleOffer();
                pi.SaleOffer.SaleOfferId = cmbSaleOffer.SelectedValue.ToString().ConvertToInt32();
                newClientId = bLayer.SavePersonInformation(pi);
                if (newClientId > 0)
                {
                    txtClientId.Text = clsCommonFunctions.GetFullClientId(Convert.ToString(newClientId));
                    message = "Personal information for New Client Inserted Successfully. New Client Id: " + txtClientId.Text.ToString();
                }
                else
                {
                    message = "Personal Information Updated Successfully for Client Id: " + txtClientId.Text.ToString();
                }
                MessageBox.Show(message, Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void LoadClientData(string strClientId)
        {

            tssStatus.Text = "Resetting Form...";
            ResetForm();
            tssStatus.Text = "Collecting Client Profile..."; this.Refresh();
            int clientId = clsCommonFunctions.GetNumericPartOfFullClientId(strClientId);
            clsGlobalClass.ClientStatus clientStatus = bLayer.GetClientStatus(clientId);
            LoadPersonalProfileData(clientId, clientStatus);
            this.Refresh(); tssStatus.Text = "Collecting Partner Data...";
            PopulatePartnerList(clientId, clientStatus);
            this.Refresh(); tssStatus.Text = "Collecting Allocation and Installment Data...";
            PopulateAllocationAndInstallmentData(clientId, clientStatus);
            lblAllocationSummary.Text = bLayer.GetUnitSummaryOfClient(clientId, true, true);
            switch (clientStatus)
            {
                case clsGlobalClass.ClientStatus.Cancelled:
                    lblProfileStatus.Text = "Cancelled";
                    pnlClientIds.BackColor = Color.DarkSalmon;
                    break;
                case clsGlobalClass.ClientStatus.Active:
                    lblProfileStatus.Text = "Active";
                    pnlClientIds.BackColor = Color.PaleGreen;
                    break;
                case clsGlobalClass.ClientStatus.IncompleteProfile:
                    lblProfileStatus.Text = "Incomplete";
                    pnlClientIds.BackColor = Color.LightBlue;
                    break;
                case clsGlobalClass.ClientStatus.Transferred:
                    lblProfileStatus.Text = "Transferred";
                    pnlClientIds.BackColor = Color.PaleTurquoise;
                    break;
                default:
                    lblProfileStatus.Text = string.Empty;
                    pnlClientIds.BackColor = Color.White;
                    break;
            }
            this.Refresh(); tssStatus.Text = "Ready";
        }

        private void LoadPersonalProfileData(int clientId, clsGlobalClass.ClientStatus status)
        {
            PersonInformation pi = new PersonInformation();
            pi.ClientId = clientId;

            tpClientData.ImageIndex = bLayer.GetClientInformation(pi) == true ? 0 : 1;
            cmbClientType.Text = pi.ClientType;
            ResetForClientType();
            chkClient_Salutation.Checked = pi.UseSalutation;
            txtClient_Name_English.Text = pi.ClientName_English;
            txtClient_Name_Bangla.Text = pi.ClientName_Bangla;
            cmbClient_Gender.Text = pi.Gender;
            cmbClient_GuardianType.Text = pi.GuardianType;
            txtClient_FatherName_English.Enabled = txtClient_FatherName_Bangla.Enabled = pi.GuardianType == "Father" ? false : true;
            lblClient_CareOf.Text = pi.CareOf + ":";
            txtClient_GuardianName_English.Text = pi.GuardianName_English;
            txtClient_GuardianName_Bangla.Text = pi.GuardianName_Bangla;
            txtClient_FatherName_English.Text = pi.FatherName_English;
            txtClient_FatherName_Bangla.Text = pi.FatherName_Bangla;
            txtClient_MotherName_English.Text = pi.MotherName_English;
            txtClient_MotherName_Bangla.Text = pi.MotherName_Bangla;
            cmbClient_Occupation.Text = pi.NationalityReligionOccupation.Occupation;
            cmbClient_Nationality.Text = pi.NationalityReligionOccupation.Nationality;
            cmbClient_Religion.Text = pi.NationalityReligionOccupation.Religion;
            dtpClient_DateOfBirth.Value = pi.DateOfBirth;
            dtpClient_DateOfBirth.Checked = pi.IsValidDateOfBirth;
            cmbClient_MaritalStatus.Text = pi.MaritalStatus;
            dtpClient_MarriageDate.Value = pi.MarriageDate;
            dtpClient_MarriageDate.Checked = pi.IsValidMarriageDate;
            txtPermanentAddress_Bangla.Text = pi.PermanentAddress_Bangla;
            txtCurrentAddress.Text = pi.CurrentAddress;
            cmbCurrentCountry.Text = pi.CurrentCountry;
            txtPostalAddress.Text = pi.PostalAddress;
            cmbPostalCountry.Text = pi.PostalCountry;
            txtContactNumber.Text = pi.ContactNumber;
            txtSMSContact.Text = pi.SMSContact;
            txtClient_NationalId.Text = pi.NationalIdNumber;
            txtClient_PassportNumber.Text = pi.PassportNumber;
            txtClient_TINNumber.Text = pi.TINNumber;
            txtEMailAddress.Text = pi.EMailAddress;
            bLayer.GetImageAndOtherInfoOfClient(pi);
            pbClientPhoto.Image = pi.ClientPhoto;
            pbClientSignature.Image = pi.ClientSignature;
            chkNeedBankLoan.Checked = pi.NeedBankLoan;
            cmbLoanProvider.Text = pi.LoanProvider.LoanProviderName.ToString();
            cmbSaleOffer.Text = pi.SaleOffer.OfferName.ToString();
            if (pi.IsReferredByClient == true)
            {
                rbReferrer_Client.Checked = txtReferrer.Visible = true;
                txtReferrer.Text = pi.Referrer;
                cmbReferrer.Visible = false;
            }
            else
            {
                rbReferrer_SEL.Checked = cmbReferrer.Visible = true;
                cmbReferrer.Text = pi.Referrer;
                txtReferrer.Visible = false;
                txtReferrer.Text = string.Empty;
            }
            cmbSoldBy.Text = pi.SoldBy;
            lblCreatedBy.Text = pi.EntryAndUpdateInfo.EntryMadeBy;
            lblLastEditedBy.Text = pi.EntryAndUpdateInfo.LastUpdatedBy;
            switch (status)
            {
                case clsGlobalClass.ClientStatus.Cancelled:
                    btnSave_ClientInfo.Enabled = false;
                    break;
                case clsGlobalClass.ClientStatus.Active:
                    btnSave_ClientInfo.Enabled = true;
                    break;
                case clsGlobalClass.ClientStatus.IncompleteProfile:
                    btnSave_ClientInfo.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void PopulateAllocationAndInstallmentData(int clientId, clsGlobalClass.ClientStatus clientStatus = clsGlobalClass.ClientStatus.Active)
        {
            ResetAllocationAndInstallmentTab();

            bllAllocationAndInstallment ai = new bllAllocationAndInstallment();
            decimal totalFaceValue = 0, totalRebate = 0, totalSaleValue = 0;
            foreach (DataRow drItems in ai.GetAllocationList(clientId).Rows)
            {

                ListViewItem lvItems = new ListViewItem(drItems["UnitId"].ToString());
                lvItems.SubItems.Add(drItems["UnitType"].ToString());
                lvItems.SubItems.Add(drItems["UnitNumber"].ToString());
                lvItems.SubItems.Add(drItems["Area"].ToString().ConvertToDecimal().FormatAsMoney());
                lvItems.SubItems.Add(drItems["Rate"].ToString().ConvertToDecimal().FormatAsMoney());
                lvItems.SubItems.Add(drItems["FaceValue"].ToString().ConvertToDecimal().FormatAsMoney());
                totalFaceValue += Convert.ToDecimal(drItems["FaceValue"].ToString());
                lvItems.SubItems.Add(drItems["RebateAmount"].ToString().ConvertToDecimal().FormatAsMoney());
                totalRebate += Convert.ToDecimal(drItems["RebateAmount"].ToString());
                lvItems.SubItems.Add(drItems["SaleValue"].ToString().ConvertToDecimal().FormatAsMoney());
                totalSaleValue += Convert.ToDecimal(drItems["SaleValue"].ToString());
                lstAllocation.Items.Add(lvItems);
            }
            txtGrandTotal_FaceValue.Text = totalFaceValue.FormatAsMoney();
            txtGrandTotal_Rebate.Text = totalRebate.FormatAsMoney();
            txtGrandTotal_SaleValue.Text = totalSaleValue.FormatAsMoney();

            decimal installmentAmount = 0, otherAmount = 0;
            foreach (DataRow drItems in ai.GetInstallmentDetails(clientId).Rows)
            {
                ListViewItem lvItems = new ListViewItem(drItems["InstallmentId"].ToString());
                lvItems.SubItems.Add(drItems["InstallmentName"].ToString());
                lvItems.SubItems.Add(drItems["DueDate"].ToString().ShowAsStandardDateFormat());
                lvItems.SubItems.Add(drItems["Amount"].ToString().ConvertToDecimal().FormatAsMoney());
                if (drItems["InstallTypeId"].ToString() == "1") { installmentAmount += drItems["Amount"].ToString().ConvertToDecimal(); }
                else { otherAmount += drItems["Amount"].ToString().ConvertToDecimal(); }
                lstPaymentSchedule.Items.Add(lvItems);
            }
            txtTotalInstallmentAmount.Text = installmentAmount.FormatAsMoney();
            txtTotalOtherAmount.Text = otherAmount.FormatAsMoney();
            txtGrandTotal.Text = (installmentAmount + otherAmount).FormatAsMoney();
            dtpBookingDate.Value = bLayer.GetBookingDate(clientId);
            tpAllocation.ImageIndex = lstAllocation.Items.Count > 0 ? 0 : 1;
            switch (clientStatus)
            {
                case clsGlobalClass.ClientStatus.Cancelled:
                    pnlUnitListing.Enabled =
                        pnlUnitPricing.Enabled =
                        pnlInstallmentAmount.Enabled =
                        pnlOtherExpenses.Enabled =
                        btnSaveAllocation.Enabled = false;
                    break;
                case clsGlobalClass.ClientStatus.Active:
                    pnlUnitListing.Enabled =
                        pnlUnitPricing.Enabled =
                        pnlInstallmentAmount.Enabled =
                        pnlOtherExpenses.Enabled =
                        btnSaveAllocation.Enabled = false;
                    break;
                case clsGlobalClass.ClientStatus.IncompleteProfile:
                    pnlUnitListing.Enabled =
                        pnlUnitPricing.Enabled =
                        pnlInstallmentAmount.Enabled =
                        pnlOtherExpenses.Enabled =
                        btnSaveAllocation.Enabled = true;
                    break;
                default:
                    break;
            }
        }


        private void PopulatePartnerList(int clientId, clsGlobalClass.ClientStatus clientStatus = clsGlobalClass.ClientStatus.Active)
        {
            lstPartner.Items.Clear();
            foreach (DataRow drItems in bLayer.GetListOfPartners(clientId).Rows)
            {
                ListViewItem lvItems = new ListViewItem(Convert.ToString(drItems["PartnerId"]));
                lvItems.SubItems.Add(Convert.ToString(drItems["EngName"]));
                lvItems.SubItems.Add(Convert.ToDateTime(drItems["DOB"]).ToString("dd-MMM-yyyy"));
                lvItems.SubItems.Add(Convert.ToString(drItems["Nationality"]));
                lvItems.SubItems.Add(Convert.ToString(drItems["NationalIDNum"]) == "0" ? string.Empty : Convert.ToString(drItems["NationalIDNum"]));
                lstPartner.Items.Add(lvItems);
            }
            tpPartner.ImageIndex = lstPartner.Items.Count > 0 ? 0 : 1;
            switch (clientStatus)
            {
                case clsGlobalClass.ClientStatus.Active:
                    btnSave_PartnerInformation.Enabled = btnAddNewPartner.Enabled = true;
                    break;
                case clsGlobalClass.ClientStatus.Cancelled:
                    btnSave_PartnerInformation.Enabled = btnAddNewPartner.Enabled = false;
                    break;
                case clsGlobalClass.ClientStatus.IncompleteProfile:
                    btnSave_PartnerInformation.Enabled = btnAddNewPartner.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void cmbProjectName_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void PopulateSaleableUnitList()
        {
            lstAvailableUnits.Items.Clear();
            bllAllocationAndInstallment b = new bllAllocationAndInstallment();
            foreach (DataRow drItems in b.GetListOfSaleableUnitsByUnitTypeFromProject(projectId: cmbProjectName.SelectedValue.ToString().ConvertToInt32(), unitTypeId: cmbUnitType.SelectedValue.ToString().ConvertToInt32(), includeLandOwnersUnits: chkIncludeLandOwnerUnits.Checked, unitNumber: txtSearchUnitNumber.Text).Rows)
            {
                ListViewItem lvItem = new ListViewItem(drItems["UnitId"].ToString());
                lvItem.SubItems.Add(drItems["UnitNumber"].ToString());
                lvItem.SubItems.Add(drItems["Facing"].ToString());
                lvItem.SubItems.Add(drItems["Owner"].ToString());
                lvItem.SubItems.Add(drItems["OralBooking"].ToString());
                lstAvailableUnits.Items.Add(lvItem);
            }
            lblAvailableUnitCount.Text = lstAvailableUnits.Items.Count + Resources.strRecordsFound;
        }


        private void cmbUnitType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //clsCommonFunctions.PopulateListViewFromDataTable(bLayer.GetListOfSaleableUnitsByUnitTypeFromProject(projectId: cmbProjectName.SelectedValue.ToString().ConvertToInt32(), unitTypeId: cmbUnitType.SelectedValue.ToString().ConvertToInt32(), includeLandOwnersUnits: chkIncludeLandOwnerUnits.Checked), lstAvailableUnits, lblAvailableUnitCount, true, null);
            PopulateSaleableUnitList();
            txtSearchUnitNumber.Text = string.Empty;
            ClearPricingPanel();
        }

        private void txtSearchUnitNumber_TextChanged(object sender, EventArgs e)
        {
            //clsCommonFunctions.PopulateListViewFromDataTable(bLayer.GetListOfSaleableUnitsByUnitTypeFromProject(projectId: cmbProjectName.SelectedValue.ToString().ConvertToInt32(), unitTypeId: cmbUnitType.SelectedValue.ToString().ConvertToInt32(), includeLandOwnersUnits: chkIncludeLandOwnerUnits.Checked, unitNumber: txtSearchUnitNumber.Text.ToString()), lstAvailableUnits, null, true, null);
            PopulateSaleableUnitList();
        }

        private void lvAvailableUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstAvailableUnits.SelectedItems.Count < 1) return;
                UnitInformation u = new UnitInformation();
                ClearPricingPanel();
                u.UnitId = lstAvailableUnits.SelectedItems[0].Text.ToString().ConvertToInt32();
                bllAllocationAndInstallment b = new bllAllocationAndInstallment();
                b.GetUnitPricingDetails(u);
                txtUnitNumber.Text = u.UnitNumber;
                txtSaleRate.Text = u.SaleRate.FormatAsMoney();
                txtUnitArea.Text = u.UnitArea.FormatAsMoney();
                txtFaceValue.Text = txtSaleValue.Text = u.AreaEnabled == true ? (u.SaleRate * u.UnitArea).FormatAsMoney() : u.SaleRate.FormatAsMoney();
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void txtRebateAmount_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtRebateAmount.Text))
            {
                txtSaleValue.Text = (txtFaceValue.Text.ToString().ConvertToDecimal() - txtRebateAmount.Text.ToString().ConvertToDecimal()).FormatAsMoney();
            }
            else
            {
                txtRebateAmount.Text = "0";
            }
        }

        private void txtRebateAmount_Leave(object sender, EventArgs e)
        {
            txtRebateAmount.Text = txtRebateAmount.Text.ToString().ConvertToDecimal().FormatAsMoney();
        }

        private void btnAddToAllocationList_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAvailableUnits.Items.Count < 1 || lstAvailableUnits.SelectedItems.Count < 1) { return; }

                if (MessageBox.Show("Sure about add this selected unit to allocation list?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                int unitId = lstAvailableUnits.SelectedItems[0].Text.ToString().ConvertToInt32();

                bool alreadyAdded = false;
                ListViewItem lv = lstAllocation.FindItemWithText(unitId.ToString());
                alreadyAdded = lv != null ? true : false;
                if (alreadyAdded == true) throw new ApplicationException("Selected Unit is already added to Allocation List.");
                bllAllocationAndInstallment b = new bllAllocationAndInstallment();
                if (b.IsMasterUnit(lstAvailableUnits.SelectedItems[0].Text.ToString().ConvertToInt32()) == true)
                {
                    int countOfMasterUnit = 0;
                    for (int i = 0; i < lstAllocation.Items.Count; i++)
                    {
                        if (b.IsMasterUnit(lstAllocation.Items[i].Text.ToString().ConvertToInt32()) == true) countOfMasterUnit++;
                    }
                    if (countOfMasterUnit > 0) throw new ApplicationException("Already one master unit is available on the list.");
                }
                string strReservedBy = b.CheckOralBooking(unitId);
                if (!String.IsNullOrEmpty(strReservedBy) && strReservedBy != clsGlobalClass.userId) { throw new ApplicationException("This unit is temporarily booked by other Representitive. Please contact him/her for details."); }
                ListViewItem lvTmpAllocation = new ListViewItem(unitId.ToString());
                lvTmpAllocation.SubItems.Add(cmbUnitType.Text.ToString());
                lvTmpAllocation.SubItems.Add(lstAvailableUnits.SelectedItems[0].SubItems[1].Text.ToString());
                lvTmpAllocation.SubItems.Add(txtUnitArea.Text.ToString());
                lvTmpAllocation.SubItems.Add(txtSaleRate.Text.ToString());
                lvTmpAllocation.SubItems.Add(txtFaceValue.Text.ToString());
                lvTmpAllocation.SubItems.Add(txtRebateAmount.Text.ToString());
                lvTmpAllocation.SubItems.Add(txtSaleValue.Text.ToString());
                lstAllocation.Items.Add(lvTmpAllocation);
                CalculateTotalRegularPaymentAmount();
                ClearPricingPanel();
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void ClearPricingPanel()
        {
            clsCommonFunctions.ResetTextBoxes(pnlUnitPricing, "0", txtUnitNumber);
            txtUnitNumber.Text = string.Empty;
        }

        private void CalculateTotalRegularPaymentAmount()
        {
            if (lstAllocation.Items.Count < 1) { return; }
            decimal faceValue = 0, rebateAmount = 0, saleValue = 0;
            for (int i = 0; i < lstAllocation.Items.Count; i++)
            {
                faceValue = faceValue + lstAllocation.Items[i].SubItems[5].Text.ToString().ConvertToDecimal();
                rebateAmount = rebateAmount + lstAllocation.Items[i].SubItems[6].Text.ToString().ConvertToDecimal();
                saleValue = saleValue + lstAllocation.Items[i].SubItems[7].Text.ToString().ConvertToDecimal();
            }
            txtGrandTotal_FaceValue.Text = faceValue.FormatAsMoney();
            txtGrandTotal_Rebate.Text = rebateAmount.FormatAsMoney();
            txtGrandTotal_SaleValue.Text = txtTotalInstallmentAmount.Text = saleValue.FormatAsMoney();
        }

        private void chkIncludeLandOwnerUnits_CheckedChanged(object sender, EventArgs e)
        {
            //bllAllocationAndInstallment b = new bllAllocationAndInstallment();
            //clsCommonFunctions.PopulateListViewFromDataTable(b.GetListOfSaleableUnitsByUnitTypeFromProject(projectId: cmbProjectName.SelectedValue.ToString().ConvertToInt32(), unitTypeId: cmbUnitType.SelectedValue.ToString().ConvertToInt32(), includeLandOwnersUnits: chkIncludeLandOwnerUnits.Checked, unitNumber: txtSearchUnitNumber.Text.ToString()), lstAvailableUnits, null, true, null);
            PopulateSaleableUnitList();
        }

        private void lstAllocation_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && lstAllocation.Items.Count > 0 && lstAllocation.SelectedItems.Count > 0)
            {
                ContextMenu c = new ContextMenu();
                MenuItem m = new MenuItem("Remove Unit # " + lstAllocation.SelectedItems[0].SubItems[2].Text.ToString(), m_OnClick);
                c.MenuItems.Add(m);
                c.Show((Control)sender, e.Location);
            }
        }

        private void m_OnClick(object sender, EventArgs e)
        {
            lstAllocation.SelectedItems[0].Remove();
            CalculateTotalRegularPaymentAmount();
        }

        private void btnAddInstallment_Click(object sender, EventArgs e)
        {
            RegularInstallmentAction();
            dtpOtherExpenses_DueDate.Value = dtpDownPayment.Value.AddMonths(txtNumberOfInstallment.Text.ToString().ConvertToInt32() * cmbPaymentFrequency.SelectedValue.ToString().ConvertToInt32() + 1);
            CalculateTotalPayableAmount();
        }

        private void ChangeAndConvertToCurrency(object sender, EventArgs e)
        {
            clsCommonFunctions.ChangeAndConvertToCurrency(sender, e);
            //((TextBox)sender).Text = !string.IsNullOrEmpty(((TextBox)sender).Text.ToString()) ? Spell.SpellAmount.comma(((TextBox)sender).Text.ToString().ConvertToDecimal()) : "0";
            //((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
        }

        private void btnAddOtherExpenses_Click(object sender, EventArgs e)
        {
            try
            {
                bool alreadyAdded = false;
                ListViewItem lv = lstPaymentSchedule.FindItemWithText(cmbOtherExpenses_Particulars.SelectedValue.ToString());
                alreadyAdded = lv != null ? true : false;
                if (alreadyAdded == true) throw new ApplicationException("Selected Payment Type is already added to Payment List.");

                if (string.IsNullOrEmpty(txtAmount_OtherExpenses.Text)) return;
                ListViewItem lvItems = new ListViewItem(cmbOtherExpenses_Particulars.SelectedValue.ToString());
                lvItems.SubItems.Add(cmbOtherExpenses_Particulars.Text.ToString());
                lvItems.SubItems.Add(dtpOtherExpenses_DueDate.Value.ToString("dd-MMM-yyyy"));
                lvItems.SubItems.Add(txtAmount_OtherExpenses.Text.ToString().ConvertToDecimal().FormatAsMoney());
                lstPaymentSchedule.Items.Add(lvItems);
                CalculateTotalPayableAmount();
                txtAmount_OtherExpenses.Text = "0";
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void CalculateTotalPayableAmount()
        {
            try
            {
                decimal grandTotal = 0, totalOtherExpenses = 0;
                bllAllocationAndInstallment bna = new bllAllocationAndInstallment();
                for (int i = 0; i < lstPaymentSchedule.Items.Count; i++)
                {
                    grandTotal += lstPaymentSchedule.Items[i].SubItems[3].Text.ToString().ConvertToDecimal();
                    totalOtherExpenses = bna.IsRegularPayment(lstPaymentSchedule.Items[i].Text.ToString().ConvertToInt32()) == false ? totalOtherExpenses + lstPaymentSchedule.Items[i].SubItems[3].Text.ToString().ConvertToDecimal() : totalOtherExpenses + 0;
                }
                txtGrandTotal.Text = grandTotal.FormatAsMoney();
                txtTotalOtherAmount.Text = totalOtherExpenses.FormatAsMoney();
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void lstPaymentSchedule_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && lstPaymentSchedule.Items.Count > 0 && lstPaymentSchedule.SelectedItems.Count > 0)
            {
                bllAllocationAndInstallment bna = new bllAllocationAndInstallment();
                if (bna.IsRegularPayment(installmentId: lstPaymentSchedule.SelectedItems[0].Text.ToString().ConvertToInt32()) == false)
                {
                    ContextMenu c = new ContextMenu();
                    MenuItem m = new MenuItem("Remove Installment # " + lstPaymentSchedule.SelectedItems[0].SubItems[1].Text.ToString(), removeInstallment_OnClick);
                    c.MenuItems.Add(m);
                    c.Show((Control)sender, e.Location);
                }
            }
        }

        private void removeInstallment_OnClick(object sender, EventArgs e)
        {
            lstPaymentSchedule.SelectedItems[0].Remove();
            CalculateTotalPayableAmount();
        }

        private void btnSaveAllocation_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAllocation.Items.Count < 1) { return; }
                if (lstPaymentSchedule.Items.Count < 1) { return; }
                if (MessageBox.Show("Are you sure about saving Allocation and Installment Data?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                int clientId = clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId.Text);

                bllAllocationAndInstallment bi = new bllAllocationAndInstallment();

                #region Allocation
                IList<UnitInformation> allocationList = new List<UnitInformation>();
                for (int i = 0; i < lstAllocation.Items.Count; i++)
                {
                    UnitInformation allocation = new UnitInformation();
                    allocation.UnitId = lstAllocation.Items[i].Text.ConvertToInt32();
                    allocation.Rebate = lstAllocation.Items[i].SubItems[6].Text.ConvertToDecimal();
                    allocationList.Add(allocation);
                }
                #endregion

                #region Booking
                BookingAndPaymentSchedule regularInstallments = new BookingAndPaymentSchedule();
                regularInstallments.BookingDate = dtpBookingDate.Value;
                regularInstallments.BookingMoney = txtAmount_BookingMoney.Text.ToString().ConvertToDecimal();
                regularInstallments.DownPaymentDate = dtpDownPayment.Value;
                regularInstallments.DownPayment = txtAmount_DownPayment.Text.ToString().ConvertToDecimal();
                regularInstallments.TotalSaleValue = txtTotalInstallmentAmount.Text.ToString().ConvertToDecimal();
                regularInstallments.GapBetweenInstallment = cmbPaymentFrequency.SelectedValue.ToString().ConvertToInt32();
                regularInstallments.NumberOfInstallment = txtNumberOfInstallment.Text.ToString().ConvertToInt32();
                #endregion


                IList<BookingAndPaymentSchedule> otherInstallments = new List<BookingAndPaymentSchedule>();
                for (int i = 0; i < lstPaymentSchedule.Items.Count; i++)
                {
                    int installmentId = lstPaymentSchedule.Items[i].Text.ToString().ConvertToInt32();
                    if (bi.CheckIfRegularInstallment(installmentId: installmentId) == false)
                    {
                        BookingAndPaymentSchedule other = new BookingAndPaymentSchedule();
                        other.InstallmentId = installmentId;
                        other.DueDate = lstPaymentSchedule.Items[i].SubItems[2].Text.ToString().ConvertToDateTime();
                        other.InstallmentAmount = lstPaymentSchedule.Items[i].SubItems[3].Text.ToString().ConvertToInt32();
                        otherInstallments.Add(other);
                    }
                }
                bi.SaveAllocationAndInstallment(clientId, allocationList, regularInstallments, otherInstallments);
                MessageBox.Show("Allocation and Installment Data Saved Successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSaveAllocation.Enabled = false;
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void RegularInstallmentAction(bool saveInstallment = false)
        {
            try
            {
                BookingAndPaymentSchedule booking = new BookingAndPaymentSchedule();
                bllAllocationAndInstallment bi = new bllAllocationAndInstallment();
                booking.BookingDate = dtpBookingDate.Value;
                booking.BookingMoney = txtAmount_BookingMoney.Text.ToString().ConvertToDecimal();
                booking.DownPaymentDate = dtpDownPayment.Value;
                booking.DownPayment = txtAmount_DownPayment.Text.ToString().ConvertToDecimal();
                booking.TotalSaleValue = txtTotalInstallmentAmount.Text.ToString().ConvertToDecimal();
                booking.GapBetweenInstallment = cmbPaymentFrequency.SelectedValue.ToString().ConvertToInt32();
                booking.NumberOfInstallment = txtNumberOfInstallment.Text.ToString().ConvertToInt32();
                lstPaymentSchedule.Items.Clear();
                foreach (DataRow drItems in bi.ManipulteInstallmentSchedule(booking).Rows)
                {
                    ListViewItem lvItem = new ListViewItem(drItems["InstallmentId"].ToString());
                    lvItem.SubItems.Add(drItems["InstallmentName"].ToString());
                    lvItem.SubItems.Add(Convert.ToDateTime(drItems["DueDate"].ToString()).ToString("dd-MMM-yyyy"));
                    lvItem.SubItems.Add(drItems["Amount"].ToString().ConvertToDecimal().FormatAsMoney());
                    lstPaymentSchedule.Items.Add(lvItem);
                }

                if (saveInstallment == true && !string.IsNullOrWhiteSpace(txtClientId.Text))
                    bi.ManipulteInstallmentSchedule(booking, clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId.Text.ToString()), true);

            }
            catch (Exception ex) { ex.ProcessException(); }

        }

        private void cmbOtherExpenses_Particulars_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtAmount_OtherExpenses.Text = "0";
        }

        private void btnLoadClientSignature_Click(object sender, EventArgs e)
        {
            try { clsCommonFunctions.LoadImageToPictureBox(pbClientSignature, 200, Resources.NoSign); }
            catch (Exception ex) { ex.ProcessException(); }
        }



        private void btnSavePartnerInformation_Click(object sender, EventArgs e)
        {
            try
            {
                if (clsCommonFunctions.CheckIfValidClientId(txtClientId.Text) == false) throw new ApplicationException("Please provide a valid client id.");
                message = lstPartner.SelectedItems.Count > 0 ? "Are you sure about update the information of " + lstPartner.SelectedItems[0].SubItems[1].Text + "?" : "Are you sure about add a new partner to Client # " + txtClientId.Text.ToString() + "?";
                if (MessageBox.Show(message, Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { throw new ApplicationException(Resources.strCancelledByUser); }
                PartnerInformation pi = new PartnerInformation();
                pi.PartnerId = lstPartner.SelectedItems.Count > 0 ? lstPartner.SelectedItems[0].Text.ToString().ConvertToInt32() : 0;
                pi.ClientId = clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId.Text.ToString());
                pi.PartnerName_English = txtPartner_Name_English.Text;
                pi.PartnerName_Bangla = txtPartner_Name_Bangla.Text;
                pi.Gender = cmbPartner_Gender.Text;
                pi.GuardianTypeId = cmbPartner_GuardianType.SelectedValue.ToString().ConvertToInt32();
                pi.GuardianName_English = txtPartner_GuardianName_English.Text;
                pi.GuardianName_Bangla = txtPartner_GuardianName_Bangla.Text;
                pi.FatherName_English = txtPartner_FatherName_English.Text;
                pi.FatherName_Bangla = txtPartner_FatherName_Bangla.Text;
                pi.MotherName_English = txtPartner_MotherName_English.Text;
                pi.MotherName_Bangla = txtPartner_MotherName_Bangla.Text;

                pi.Partner_NOR = new NationalityReligionOccupation();
                pi.Partner_NOR.NationalityId = cmbPartner_Nationality.SelectedValue.ToString().ConvertToInt32();
                pi.Partner_NOR.OccupationId = cmbPartner_Occupation.SelectedValue.ToString().ConvertToInt32();
                pi.Partner_NOR.ReligionId = cmbPartner_Religion.SelectedValue.ToString().ConvertToInt32();
                pi.IsValidDateOfBirth = dtpPartner_DateOfBirth.Checked;
                pi.DateOfBirth = dtpPartner_DateOfBirth.Value;
                pi.MaritalStatusId = cmbPartner_MaritalStatus.SelectedValue.ToString().ConvertToInt32();
                pi.IsValidMarriageDate = dtpPartner_MarriageDate.Checked;
                pi.MarriageDate = dtpPartner_MarriageDate.Value;
                pi.NationalIdNumber = txtPartner_NationalIDNumber.Text;
                pi.PassportNumber = txtPartner_PassportNumber.Text;
                pi.TINNumber = txtPartner_TINNumber.Text;
                bllPartnerInformation partnerDetails = new bllPartnerInformation();
                partnerDetails.ManipulatePartnerInformation(pi);
                MessageBox.Show("Partner information saved successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetPartnerTab();
                PopulatePartnerList(pi.ClientId);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }


        private void lstPartner_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstPartner.SelectedItems.Count < 1) return;
                bllPartnerInformation partnerDetails = new bllPartnerInformation();
                PartnerInformation pi = new PartnerInformation();
                pi.PartnerId = lstPartner.SelectedItems[0].Text.ToString().ConvertToInt32();
                partnerDetails.GetPartnerInformation(pi);
                txtPartner_Name_English.Text = pi.PartnerName_English;
                txtPartner_Name_Bangla.Text = pi.PartnerName_Bangla;
                cmbPartner_Gender.Text = pi.Gender;
                cmbPartner_GuardianType.Text = pi.GuardianType;
                txtPartner_GuardianName_English.Text = pi.GuardianName_English;
                txtPartner_GuardianName_Bangla.Text = pi.GuardianName_Bangla;
                txtPartner_FatherName_English.Text = pi.FatherName_English;
                txtPartner_FatherName_Bangla.Text = pi.FatherName_Bangla;
                txtPartner_MotherName_English.Text = pi.MotherName_English;
                txtPartner_MotherName_Bangla.Text = pi.MotherName_Bangla;
                cmbPartner_Nationality.Text = pi.Partner_NOR.Nationality;
                cmbPartner_Occupation.Text = pi.Partner_NOR.Occupation;
                cmbPartner_Religion.Text = pi.Partner_NOR.Religion;
                dtpPartner_DateOfBirth.Value = pi.DateOfBirth;
                dtpPartner_DateOfBirth.Checked = pi.IsValidDateOfBirth;
                cmbPartner_MaritalStatus.Text = pi.MaritalStatus;
                dtpPartner_MarriageDate.Value = pi.MarriageDate;
                dtpPartner_MarriageDate.Checked = pi.IsValidMarriageDate;
                txtPartner_NationalIDNumber.Text = pi.NationalIdNumber;
                txtPartner_PassportNumber.Text = pi.PassportNumber;
                txtPartner_TINNumber.Text = pi.TINNumber;
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            ResetForm(true);
            tpPersonalData.Focus();
            cmbClientType.Focus();
        }

        private void btnNewSaleOffer_Click(object sender, EventArgs e)
        {
            frmDefinition_SaleOffer saleOffer = new frmDefinition_SaleOffer();
            saleOffer.ShowDialog();
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT OfferId, OfferName FROM SaleOffer ORDER BY StartDate DESC", "OfferName", "OfferId", false, cmbSaleOffer);
        }

        private void btnNewLoanProvider_Click(object sender, EventArgs e)
        {
            frmDefinition_LoanProvider loanProvider = new frmDefinition_LoanProvider();
            loanProvider.ShowDialog();
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT ProviderId, ProviderName FROM defLoanProvider ORDER BY ProviderName", "ProviderName", "ProviderId", false, cmbLoanProvider);
        }

        private void lstPartner_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && lstPartner.Items.Count > 0 && lstPartner.SelectedItems.Count > 0)
            {
                ContextMenu c = new ContextMenu();
                MenuItem m = new MenuItem("Remove Partner " + lstPartner.SelectedItems[0].SubItems[1].Text.ToString(), removePartner_OnClick);
                c.MenuItems.Add(m);
                c.Show((Control)sender, e.Location);
            }
        }

        private void removePartner_OnClick(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure about Deleting Partner " + lstPartner.SelectedItems[0].SubItems[1].Text.ToString() + "?\nDELETED PARTNER INFORMATION CANNOT BE RETRIEVED.", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                int partnerId = lstPartner.SelectedItems[0].Text.ToString().ConvertToInt32();
                bllPartnerInformation bLayer = new bllPartnerInformation();
                bLayer.RemovePartner(partnerId);
                MessageBox.Show(Resources.strSuccessMessage, Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetPartnerTab();
                lstPartner.SelectedItems[0].Remove();
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnCopyClientProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtClientId.Text)) throw new ApplicationException("Please load a client profile to copy.");
                if (MessageBox.Show("You're going to copy Personal and Partner Information of ClientId: <" + txtClientId.Text.ToString() + "> to a new new profile. \nThe new profile will be saved as incomplete. \nPlease complete the profile by submitting Allocation and Installment information.\nDo you want to continue?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                txtClientId.Text = bLayer.CopyClientProfile(clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId.Text.ToString()));
                LoadClientData(txtClientId.Text);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        #region Reset Form Controls
        private void ResetClientInfoTab()
        {
            clsCommonFunctions.ResetTextBoxes(tcPersonalInformation, "");
            lblCreatedBy.Text = lblLastEditedBy.Text = string.Empty;
            pbClientPhoto.Image = Resources.NoPhoto;
            pbClientSignature.Image = Resources.NoSign;
            clsCommonFunctions.ResetDTPicker(tcPersonalInformation);
            dtpClient_MarriageDate.Checked = false;
            clsCommonFunctions.ResetCheckBoxes(tcPersonalInformation);
            btnSave_ClientInfo.Enabled = true;
        }

        private void ResetPartnerTab()
        {
            lstPartner.Items.Clear();
            clsCommonFunctions.ResetTextBoxes(tpPartner);
            clsCommonFunctions.ResetDTPicker(tpPartner);
            dtpPartner_MarriageDate.Checked = false;
            cmbPartner_Gender.Text = "Male";
            cmbPartner_GuardianType.Text = "Father";
            cmbPartner_Nationality.SelectedIndex = cmbPartner_Occupation.SelectedIndex = cmbPartner_Religion.SelectedIndex = 0;
            btnSave_PartnerInformation.Enabled = btnAddNewPartner.Enabled = true;
        }

        private void ResetAllocationAndInstallmentTab()
        {
            lstAllocation.Items.Clear();
            lstPaymentSchedule.Items.Clear();
            lstAvailableUnits.Items.Clear();
            clsCommonFunctions.ResetTextBoxes(tcAllocation, "0", txtSearchUnitNumber);
            clsCommonFunctions.ResetDTPicker(tcAllocation);
            txtSearchUnitNumber.Text = "";
            pnlUnitListing.Enabled =
                pnlUnitPricing.Enabled =
                pnlInstallmentAmount.Enabled =
                pnlOtherExpenses.Enabled =
                btnSaveAllocation.Enabled = true;
        }

        private void ResetForm(bool clearClientId = false)
        {

            tssStatus.Text = "Regenerating DropDown boxes..."; this.Refresh();
            PopulateComboBoxes();
            tssStatus.Text = "Resetting Client Information Tab..."; this.Refresh();
            ResetClientInfoTab();
            tssStatus.Text = "Resetting Partner Information Tab..."; this.Refresh();
            ResetPartnerTab();
            tssStatus.Text = "Resetting Allocation Tab..."; this.Refresh();
            ResetAllocationAndInstallmentTab();
            tpClientData.ImageKey = tpPartner.ImageKey = tpAllocation.ImageKey = null;
            if (clearClientId == true) txtClientId.Text = string.Empty;
            lblProfileStatus.Text = string.Empty;
            lblAllocationSummary.Text = string.Empty;
            pnlProfileStatus.BackColor = pnlClientIds.BackColor = Color.White;
            tssStatus.Text = "Ready";
            this.Refresh();


        }

        private void PopulateComboBoxes()
        {

            //clsCommonFunctions.AutoFormatComboBoxes(this, ComboBoxStyle.DropDownList);
            cmbClient_Gender.Items.Add("Male");
            cmbClient_Gender.Items.Add("Female");
            cmbClient_Gender.SelectedIndex = 0;
            cmbPartner_Gender.Items.Add("Male");
            cmbPartner_Gender.Items.Add("Female");
            cmbPartner_Gender.SelectedIndex = 0;
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT OccupationId, Occupation FROM defOccupation ORDER BY Occupation", "Occupation", "OccupationId", false, cmbClient_Occupation, cmbPartner_Occupation);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT ReligionId, Religion FROM defReligion ORDER BY ReligionID", "Religion", "ReligionID", false, cmbClient_Religion, cmbPartner_Religion);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT NationalityID, Nationality FROM defNationality ORDER BY NationalityId", "Nationality", "NationalityID", false, cmbClient_Nationality, cmbPartner_Nationality);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT InstallmentId, InstallmentName FROM defInstallment WHERE InstallTypeId = 2 ORDER BY InstallmentName", "InstallmentName", "InstallmentId", false, cmbOtherExpenses_Particulars);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT ObjectTypeId, ObjectType FROM ObjectType WHERE isMasterObject =1 ORDER BY ObjectType", "ObjectType", "ObjectTypeID", false, cmbUnitType);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT ProviderId, ProviderName FROM defLoanProvider ORDER BY ProviderName", "ProviderName", "ProviderId", false, cmbLoanProvider);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT OfferId, OfferName FROM SaleOffer ORDER BY StartDate DESC", "OfferName", "OfferId", false, cmbSaleOffer);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT EmpId, EmployeeName FROM Employee WHERE Active = 1 ORDER BY EmployeeName", "EmployeeName", "EmpId", false, cmbReferrer, cmbSoldBy);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT * FROM defMaritalStatus ORDER BY MaritalStatusId", "MaritalStatus", "MaritalStatusId", false, cmbClient_MaritalStatus, cmbPartner_MaritalStatus);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT [InstallmentMode], [GapBetweenInstallment] FROM defInstallmentMode ORDER BY [GapBetweenInstallment]", "InstallmentMode", "GapBetweenInstallment", false, cmbPaymentFrequency);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT * FROM defClientType ORDER BY ClientTypeId", "ClientType", "ClientTypeId", false, cmbClientType);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT * FROM defCountryList ORDER BY CountryName", "CountryName", "CountryId", false, cmbCurrentCountry, cmbPostalCountry);
            cmbCurrentCountry.Text = "Bangladesh";
            cmbPostalCountry.Text = "Bangladesh";
            cmbClient_Religion.Text = "Islam";
            cmbPartner_Religion.Text = "Islam";
            cmbSaleOffer.Text = "N/A";
            cmbLoanProvider.Text = "N/A";
            cmbReferrer.Text = cmbSoldBy.Text = clsCommonFunctions.GetEmployeeNameFromLogInId();
            clsCommonFunctions.PopulateListOfProjects(cmbProjectName);

        }
        #endregion

        private void btnAddNewPartner_Click(object sender, EventArgs e)
        {
            try
            {
                ResetPartnerTab();
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT OccupationId, Occupation FROM defOccupation ORDER BY Occupation", "Occupation", "OccupationId", false, cmbPartner_Occupation);
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT ReligionId, Religion FROM defReligion ORDER BY ReligionID", "Religion", "ReligionID", false, cmbPartner_Religion);
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT NationalityID, Nationality FROM defNationality ORDER BY NationalityId", "Nationality", "NationalityID", false, cmbPartner_Nationality);
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT * FROM defMaritalStatus ORDER BY MaritalStatusId", "MaritalStatus", "MaritalStatusId", false, cmbPartner_MaritalStatus);
                PopulatePartnerList(clsCommonFunctions.GetNumericPartOfFullClientId(txtClientId.Text.ToString()));
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void chkNeedBankLoan_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtClientId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtClient_Name_English.Focus();
            }
        }

        private void btnClientProfile_Click(object sender, EventArgs e)
        {
            try
            {
                clsReports.ClientProfile(txtClientId.Text, tssStatus);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void cmbClientType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ResetForClientType();
        }

        private void ResetForClientType()
        {
            bool isRepNeeded = bLayer.IsRepNeeded(cmbClientType.SelectedValue.ToString().ConvertToInt32());
            if (isRepNeeded == false)
            {
                lblClientType.Text = "Name:";
                lblClient_CareOf.Text = "S/O:";
                txtClient_FatherName_English.Enabled = txtClient_FatherName_Bangla.Enabled
                    = txtClient_MotherName_English.Enabled = txtClient_MotherName_Bangla.Enabled
                    = cmbClient_Gender.Enabled = cmbClient_GuardianType.Enabled = true;

                txtClient_FatherName_English.Text = txtClient_FatherName_Bangla.Text
                    = txtClient_MotherName_English.Text = txtClient_MotherName_Bangla.Text = string.Empty;
            }
            else
            {
                lblClientType.Text = cmbClientType.Text;
                lblClient_CareOf.Text = "Representitive:";
                txtClient_FatherName_English.Enabled = txtClient_FatherName_Bangla.Enabled
                    = txtClient_MotherName_English.Enabled = txtClient_MotherName_Bangla.Enabled
                    = cmbClient_Gender.Enabled = cmbClient_GuardianType.Enabled = false;
                cmbClient_GuardianType.Text = "Father";
                txtClient_FatherName_English.Text = "N/A";

                txtClient_FatherName_English.Text = txtClient_MotherName_English.Text = "N/A";
                txtClient_FatherName_Bangla.Text
                    = txtClient_MotherName_Bangla.Text
                    = Resources.strNotApplicableInBangla;
            }
        }

        private void cmbClient_MaritalStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtpClient_MarriageDate.Checked = cmbClient_MaritalStatus.Text == "Married" ? true : false;
        }

        private void cmbPartner_MaritalStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtpPartner_MarriageDate.Checked = cmbPartner_MaritalStatus.Text == "Married" ? true : false;
        }

        private void txtClient_GuardianName_English_TextChanged(object sender, EventArgs e)
        {
            if (cmbClient_GuardianType.Text == "Father") txtClient_FatherName_English.Text = txtClient_GuardianName_English.Text;
        }

        private void txtClient_GuardianName_Bangla_TextChanged(object sender, EventArgs e)
        {
            if (cmbClient_GuardianType.Text == "Father") txtClient_FatherName_Bangla.Text = txtClient_GuardianName_Bangla.Text;
        }

        private void btnClient_AddNationality_Click(object sender, EventArgs e)
        {
            frmDefinition_NOR nor = new frmDefinition_NOR();
            nor.rbNationality.Checked = true;
            nor.ShowDialog();
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT NationalityID, Nationality FROM defNationality ORDER BY NationalityId", "Nationality", "NationalityID", false, cmbClient_Nationality, cmbPartner_Nationality);
        }

        private void btnClient_AddOccupation_Click(object sender, EventArgs e)
        {
            frmDefinition_NOR nor = new frmDefinition_NOR();
            nor.rbOccupation.Checked = true;
            nor.ShowDialog();
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT OccupationId, Occupation FROM defOccupation ORDER BY Occupation", "Occupation", "OccupationId", false, cmbClient_Occupation, cmbPartner_Occupation);
        }

        private void cmbProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstAvailableUnits.Items.Clear();
                bllAllocationAndInstallment b = new bllAllocationAndInstallment();
                int projectId = 0;
                if (!string.IsNullOrEmpty(cmbProjectName.Text) & cmbProjectName.Text != "") projectId = clsCommonFunctions.GetProjectIdFromProjectName(cmbProjectName.Text);
                //clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember(CommandType.StoredProcedure)
                clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("EXEC sp_GetDistinctTypeOfUnitsInProject " + projectId, "ObjectType", "ObjectTypeId", false, cmbUnitType);
                if (cmbUnitType.Items.Count < 1 || cmbUnitType.SelectedValue.ToString() == string.Empty) return;
                //clsCommonFunctions.PopulateListViewFromDataTable(bLayer.GetListOfSaleableUnitsByUnitTypeFromProject(projectId: cmbProjectName.SelectedValue.ToString().ConvertToInt32(), unitTypeId: cmbUnitType.SelectedValue.ToString().ConvertToInt32(), includeLandOwnersUnits: chkIncludeLandOwnerUnits.Checked), lstAvailableUnits, lblAvailableUnitCount, true, null);
                PopulateSaleableUnitList();
                DateTime approximateCompletionDate = b.GetApproximateCompletionDate(cmbProjectName.SelectedValue.ToString().ConvertToInt32());

                lblApproximateCompletionDate.Text = String.Format("Approx. Completion >> {0}", clsGlobalClass.considerAsNULLDate > approximateCompletionDate ? "N/A" : approximateCompletionDate.ToString().ShowAsStandardDateFormat());
                txtNumberOfInstallment.Text = clsGlobalClass.considerAsNULLDate > approximateCompletionDate ? "1" : b.CalculateNumberOfInstallment(projectId: cmbProjectName.SelectedValue.ToString().ConvertToInt32()).ToString();
                ClearPricingPanel();
                clsCommonFunctions.ResetTextBoxes(gbGrandTotals, "0");
            }
            catch (Exception ex) { ex.ProcessException(); }
        }


    }
}
