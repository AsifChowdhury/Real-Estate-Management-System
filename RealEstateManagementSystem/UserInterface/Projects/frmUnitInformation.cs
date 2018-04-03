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

namespace RealEstateManagementSystem.UserInterface.Projects
{
    public partial class frmUnitInformation : Form
    {
        bllProjectInfo bLayer = new bllProjectInfo();
        private int intUnitId = 0;
        //private string unitIds = "";
        private int intProjectId = 0;
        public frmUnitInformation()
        {
            InitializeComponent();
        }

        private void frmUnitInformation_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommonFunctions.PopulateListOfProjects(cmbProjectName, true);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void AllowNumericOnly(object sender, KeyPressEventArgs e)
        {
            clsCommonFunctions.NumericTextBox(sender, e);
        }


        private void PopulateComboBoxes(bool withProjectCombo = true)
        {
            try
            {
                if (withProjectCombo == true) clsCommonFunctions.PopulateListOfProjects(cmbProjectName, clsGlobalClass.ProjectStatus.All, true);
                bLayer.PopulateUnitTypeCombo(cmbUnitType);
                bLayer.PopulateTypeOfUnitCombo(cmbTypeOfUnit);
                bLayer.PopulateFacingCombo(cmbFacing);
                cmbOwner.Items.Clear();
                cmbOwner.Items.Add("SEL");
                cmbOwner.Items.Add("Land Owner");
            }
            catch (Exception ex) { ex.ProcessException(); }
        }


        private void PopulateHashParkingList()
        {
            try
            {
                lvHashParkingList.Items.Clear();
                foreach (DataRow drItems in bLayer.GetListOfHashParking(projectId: cmbProjectName.SelectedValue.ToString().ConvertToInt32()).Rows)
                {
                    ListViewItem lvItems = new ListViewItem(drItems["FlatId"].ToString());
                    lvItems.SubItems.Add(Convert.ToString(drItems["ClientId"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["Name"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["MasterUnit"]));
                    lvItems.SubItems.Add(Convert.ToString(drItems["ParkingNumber"]));
                    lvHashParkingList.Items.Add(lvItems);
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void PopulateUnitTree()
        {
            try
            {
                lvBlockingHistory.Items.Clear();
                tvUnitDetails.Nodes.Clear();
                //bLayer.ProjectId = Convert.ToInt32(cmbProjectName.SelectedValue);
                bLayer.ProjectId = intProjectId;
                foreach (DataRow drBuildings in bLayer.GetListOfBuildingsInProject().Rows)
                {
                    TreeNode tnBuilding = new TreeNode(drBuildings["BNumber"].ToString() + " [" + drBuildings["FloorInformation"].ToString() + "]");
                    //tnBuilding.Tag = "B" + drBuildings["BuildingId"].ToString();
                    tvUnitDetails.Nodes.Add(tnBuilding);
                    tnBuilding.ImageIndex = tnBuilding.SelectedImageIndex = 3;
                    foreach (DataRow drUnitType in bLayer.GetListOfUnitTypesInBuilding(drBuildings["BuildingId"].ToString().ConvertToInt32()).Rows)
                    {
                        TreeNode tnUnitType = new TreeNode();
                        int imageIndex = 0;
                        tnBuilding.Nodes.Add(tnUnitType);
                        switch (drUnitType["ObjectType"].ToString())
                        {
                            case "Car Parking": imageIndex = 0; break;
                            case "Flat": imageIndex = 2; break;
                            case "Office": imageIndex = 1; break;
                            case "Shop": imageIndex = 4; break;
                            case "Serviced Apartment": imageIndex = 5; break;
                            case "Show Room": imageIndex = 6; break;
                            default: imageIndex = 7; break;
                        }
                        tnUnitType.ImageIndex = tnUnitType.SelectedImageIndex = imageIndex;
                        int intCountOfUnit = 0;
                        foreach (DataRow drUnitDetails in bLayer.GetListOfUnitsByUnitTypeAndBuildingId(drUnitType["ObjectType"].ToString(), drBuildings["BuildingId"].ToString().ConvertToInt32()).Rows)
                        {
                            string strUnitInfo = drUnitDetails["FlatNumber"].ToString();
                            if (drUnitDetails["FullClientId"].ToString() != "")
                            {
                                strUnitInfo = strUnitInfo + " [" + drUnitDetails["FullClientId"] + "]";
                            }
                            strUnitInfo += " - [" + drUnitDetails["Owner"].ToString() + "]";
                            TreeNode tnUnits = new TreeNode(strUnitInfo);
                            tnUnits.Tag = drUnitDetails["FlatId"].ToString();
                            tnUnits.ForeColor = drUnitDetails["Blocked"].ToString().ConvertToBoolean() == true ? Color.Red : Color.Black;
                            tnUnitType.Nodes.Add(tnUnits);
                            tnUnits.ImageIndex = tnUnits.SelectedImageIndex = imageIndex;
                            intCountOfUnit++;
                        }
                        tnUnitType.Text = drUnitType["ObjectType"].ToString() + " [" + intCountOfUnit.ToString() + "]";
                    }

                }
                if (chkAutoExpand.Checked == true) tvUnitDetails.ExpandAll();
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void tvUnitDetails_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Tag != null)
                {
                    intUnitId = e.Node.Tag.ToString().ConvertToInt32();
                    bLayer.UnitId = intUnitId;
                    bLayer.GetUnitInformation();
                    btnSave.Enabled = btnDelete.Enabled = bLayer.IsEditable;
                    cmbBuilding.Text = bLayer.BuildingName;
                    cmbUnitType.Text = bLayer.UnitType;
                    cmbFloorNumber.Text = bLayer.FormattedFloorNumber;
                    cmbFacing.Text = bLayer.Facing;
                    cmbTypeOfUnit.Text = bLayer.TypeOfUnit;
                    txtUnitNumber.Text = bLayer.UnitNumber;
                    cmbOwner.Text = bLayer.Owner;
                    txtArea.Text = Spell.SpellAmount.comma(bLayer.UnitArea.ToString().ConvertToDecimal());
                    txtRate.Text = bLayer.Rate.ToString().ConvertToDecimal().FormatAsMoney();
                    txtTotalPrice.Text = bLayer.IsAreaEnabled == true ? (bLayer.UnitArea * bLayer.Rate).FormatAsMoney() : bLayer.Rate.FormatAsMoney();
                    chkIsSaleable.Checked = bLayer.IsSaleable;
                    chkIsBlocked.Checked = bLayer.IsBlocked;
                    chkIsCPAvailable.Checked = bLayer.IsParkingAvailable;
                    lblUnit.Text = "Unit #: " + bLayer.UnitNumber;
                    btnUnBlock.Enabled = bLayer.IsBlocked;
                    pnlBlock.Enabled = bLayer.IsBlocked == true ? false : true;
                    PopulateBlockingHistory();
                }
                else { RefreshUnitPanel(); RefreshBlockingPanel(); }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }


        private void RefreshBlockingPanel()
        {
            lvBlockingHistory.Items.Clear();
            dtpBlockStart.Value = dtpBlockEnd.Value = DateTime.Now;
            txtBlockRemark.Text = string.Empty;
            pnlBlock.Enabled = btnUnBlock.Enabled = false;
            lblUnit.Text = "Unit #: ";
        }

        private void RefreshUnitPanel(bool withComboBoxes = true)
        {
            //if (withComboBoxes == true) PopulateComboBoxes(false);
            txtArea.Text = txtRate.Text = txtTotalPrice.Text = "0";
            chkIsBlocked.Checked = chkIsCPAvailable.Checked = chkIsSaleable.Checked = false;
            txtUnitNumber.Text = string.Empty;

        }

        private void cmbBuilding_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try { bLayer.PopulateFloorsCombo(Convert.ToInt32(cmbBuilding.SelectedValue.ToString()), cmbFloorNumber); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void cmbUnitType_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmbFloorNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try { txtUnitNumber.Text = GenerateUnitNumber(); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void cmbTypeOfUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try { txtUnitNumber.Text = GenerateUnitNumber(); }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private string GenerateUnitNumber()
        {
            string unitNumber = string.Empty;
            try
            {

                if (txtUnitNumber.Enabled == false && (cmbFloorNumber.Text != string.Empty && cmbTypeOfUnit.Text != string.Empty))
                {
                    unitNumber = bLayer.GenerateUnitNumber(
                                                            Convert.ToInt32(cmbUnitType.SelectedValue.ToString()),
                                                            Convert.ToInt32(cmbTypeOfUnit.SelectedValue.ToString()),
                                                            Convert.ToInt32(cmbFloorNumber.SelectedValue.ToString()));
                }
                else { unitNumber = string.Empty; }

            }
            catch (Exception ex) { ex.ProcessException(); }
            return unitNumber;
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtArea.Text))
                {
                    txtTotalPrice.Text =
                        txtArea.Enabled == true ?
                                           (txtRate.Text.ConvertToDecimal() * txtArea.Text.ConvertToDecimal()).FormatAsMoney() :
                                           txtRate.Text.ConvertToDecimal().FormatAsMoney();
                }
                else { txtArea.Text = "0"; }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtRate.Text))
                {
                    txtTotalPrice.Text =
                        txtArea.Enabled == true ?
                                           (txtRate.Text.ConvertToDecimal() * txtArea.Text.ConvertToDecimal()).FormatAsMoney() :
                                           txtRate.Text.ConvertToDecimal().FormatAsMoney();
                }
                else { txtRate.Text = "0"; }
            }
            catch (Exception ex) { ex.ProcessException(); }

        }

        private void txtArea_Leave(object sender, EventArgs e)
        {
            try
            {
                txtArea.Text = Spell.SpellAmount.comma(Convert.ToDecimal(txtArea.Text.ToString()));
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            try
            {
                txtRate.Text = Spell.SpellAmount.comma(Convert.ToDecimal(txtRate.Text.ToString()));
            }
            catch (Exception ex) { ex.ProcessException(); }

        }

        private void cmbOwner_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                chkIsSaleable.Checked = cmbOwner.Text == "SEL" ? true : false;
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbFloorNumber.Items.Count < 1) throw new ApplicationException("Please add floor information before saving unit details.");
                if ((cmbFloorNumber.Items.Count > 0 && string.IsNullOrEmpty(cmbFloorNumber.Text) == true)) throw new ApplicationException("Please select floor number.");

                string strMsg = intUnitId > 0 ?
                                "Sure About Updating Selected Unit # " + tvUnitDetails.SelectedNode.Text.ToString() + "?" :
                                "Sure about insert new " + cmbUnitType.Text.ToString() + " unit at " + cmbProjectName.Text.ToString() + "?";
                DialogResult dr = MessageBox.Show(strMsg, Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);

                bLayer.UnitId = intUnitId;
                bLayer.FloorId = cmbFloorNumber.SelectedValue.ToString().ConvertToInt32();
                bLayer.UnitNumber = txtUnitNumber.Text.ToString();
                bLayer.UnitArea = txtArea.Text.ToString().ConvertToDecimal();
                bLayer.Rate = txtRate.Text.ToString().ConvertToDecimal();
                bLayer.TypeOfUnitId = cmbTypeOfUnit.SelectedValue.ToString().ConvertToInt32();
                bLayer.FacingId = cmbFacing.SelectedValue.ToString().ConvertToInt32();
                bLayer.Owner = cmbOwner.Text.ToString();
                bLayer.UnitTypeId = cmbUnitType.SelectedValue.ToString().ConvertToInt32();
                bLayer.IsSaleable = chkIsSaleable.Checked;
                bLayer.IsParkingAvailable = chkIsCPAvailable.Checked;
                bLayer.ManipulateUnitInformation();
                PopulateUnitTree();
                RefreshUnitPanel();
                intUnitId = 0;
                MessageBox.Show(Resources.strSuccessMessage, Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ex.ProcessException(); }

        }

        private void btnUnitDetailsReport_Click(object sender, EventArgs e)
        {
            try
            {
                clsReports.UnitDetailsOfProject(cmbProjectName.SelectedValue.ToString().ConvertToInt32(), tssStatus);
            }
            catch (Exception ex) { tssStatus.Text = Resources.strReadyStatus; ex.ProcessException(); }
        }


        private void btnBlock_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tvUnitDetails.SelectedNode.Tag.ToString()))
                {
                    if (MessageBox.Show("Sure about block this unit?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                    bLayer.UnitId = tvUnitDetails.SelectedNode.Tag.ToString().ConvertToInt32();
                    bLayer.BlockStart = dtpBlockStart.Value;
                    bLayer.BlockEnd = dtpBlockEnd.Value;
                    bLayer.BlockRemarks = txtBlockRemark.Text;
                    bLayer.BlockUnit();
                    PopulateBlockingHistory();
                    MessageBox.Show("Unit blocked successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshBlockingPanel();
                    RefreshUnitPanel();
                    PopulateUnitTree();
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void PopulateBlockingHistory()
        {
            try
            {
                lvBlockingHistory.Items.Clear();
                if (!string.IsNullOrEmpty(tvUnitDetails.SelectedNode.Tag.ToString()))
                {
                    foreach (DataRow drItems in bLayer.GetUnitBlockingHistory(tvUnitDetails.SelectedNode.Tag.ToString().ConvertToInt32()).Rows)
                    {
                        ListViewItem lvItems = new ListViewItem(drItems["BlockingId"].ToString());
                        lvItems.SubItems.Add(Convert.ToString(drItems["BlockedBy"]));
                        lvItems.SubItems.Add(Convert.ToString(drItems["StartDate"]).ShowAsStandardDateFormat(true));
                        lvItems.SubItems.Add(Convert.ToString(drItems["EndDate"]).ShowAsStandardDateFormat(true));
                        lvItems.SubItems.Add(Convert.ToString(drItems["UnBlockedBy"]));
                        lvItems.SubItems.Add(Convert.ToString(drItems["Remarks"]));
                        lvBlockingHistory.Items.Add(lvItems);
                    }
                }
            }
            catch (Exception ex)
            {

                ex.ProcessException();
            }
        }

        private void btnUnBlock_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tvUnitDetails.SelectedNode.Tag.ToString()))
                {
                    if (MessageBox.Show("Sure about un-block this unit?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser); ;
                    bLayer.UnitId = tvUnitDetails.SelectedNode.Tag.ToString().ConvertToInt32();
                    bLayer.UnBlockUnit(bLayer.UnitId);
                    PopulateBlockingHistory();
                    MessageBox.Show("Unit un-blocked successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshBlockingPanel();
                    RefreshUnitPanel();
                    PopulateUnitTree();
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void cmbUnitType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbUnitType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lblCPHashWarning.Visible = cmbUnitType.Text == "Car Parking" ? true : false;
                int parseInt = 0;
                bLayer.UnitTypeId =
                    cmbUnitType.Items.Count > 0 && int.TryParse(Convert.ToString(cmbUnitType.SelectedValue), out parseInt) == true ?
                        Convert.ToString(cmbUnitType.SelectedValue).ConvertToInt32()
                        : 1;
                bLayer.GetUnitTypeProperties();
                cmbFacing.Enabled = bLayer.IsFacingEnabled;
                cmbFacing.Text = bLayer.IsFacingEnabled == true ? "East" : "NA";
                cmbTypeOfUnit.Enabled = bLayer.IsTypeEnabled;
                cmbTypeOfUnit.Text = bLayer.IsTypeEnabled == true ? "A" : "NA";
                txtArea.Enabled = bLayer.IsAreaEnabled;
                txtArea.Text = txtRate.Text = txtTotalPrice.Text = "0";
                txtUnitNumber.Enabled = bLayer.IsNumberEnabled;
                txtUnitNumber.Text = string.Empty;
                lblUnitNumber.Text = cmbUnitType.Text + " #:";
                lblUnitType.Text = cmbUnitType.Text + " Type:";
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshUnitPanel();
            RefreshBlockingPanel();
            lvHashParkingList.Items.Clear();
            lblMasterUnit.Text = txtHashParkingNumber.Text = string.Empty;
            intUnitId = 0;
        }

        private void lvHashParkingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHashParkingList.SelectedItems.Count < 1) return;
            lblMasterUnit.Text = lvHashParkingList.SelectedItems[0].SubItems[3].Text.ToString();
            txtHashParkingNumber.Text = lvHashParkingList.SelectedItems[0].SubItems[4].Text.ToString();
        }

        private void btnHashParkingUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvHashParkingList.Items.Count < 1 || lvHashParkingList.SelectedItems.Count < 1) return;
                if (MessageBox.Show("Sure about update parking allocation for Unit # " + lvHashParkingList.SelectedItems[0].SubItems[3].Text + "?\nTHIS ACTION CANNOT BE REVERTED.", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                if (txtHashParkingNumber.Text == string.Empty) throw new ApplicationException("Please provide a Parking number.");
                if (txtHashParkingNumber.Text.IndexOf("#") > 0) throw new ApplicationException("You cannot use # sign for parking number.");
                bLayer.UpdateHashParking(unitId: lvHashParkingList.SelectedItems[0].Text.ToString().ConvertToInt32(), parkingNumber: txtHashParkingNumber.Text.ToString().Trim(), projectId: cmbProjectName.SelectedValue.ToString().ConvertToInt32());
                MessageBox.Show("Parking number updated successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                lvHashParkingList.SelectedItems[0].SubItems[4].Text = txtHashParkingNumber.Text;
                lblMasterUnit.Text = txtHashParkingNumber.Text = string.Empty;
                PopulateUnitTree();
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void tpUnit_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSave;
        }

        private void pnlBlock_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnBlock;
        }

        private void tpUnit_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void pnlBlock_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void tpHashParking_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnHashParkingUpdate;
        }

        private void tpHashParking_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void chkAutoExpand_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoExpand.Checked == true)
                tvUnitDetails.ExpandAll();
            else
                tvUnitDetails.CollapseAll();
        }


        private void btnListOfBlokedUnits_Click(object sender, EventArgs e)
        {
            frmListOfBlockedUnits bu = new frmListOfBlockedUnits();
            bu.ShowDialog();
        }

        private void cmbProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbFloorNumber.DataSource = null;
                PopulateComboBoxes(false);
                if (!string.IsNullOrEmpty(cmbProjectName.Text))
                {
                    intProjectId = cmbProjectName.SelectedValue.ToString().ConvertToInt32();
                    bLayer.PopulateBuildingsCombo(intProjectId, cmbBuilding);
                    if (cmbBuilding.Items.Count == 1) { bLayer.PopulateFloorsCombo(Convert.ToInt32(cmbBuilding.SelectedValue.ToString()), cmbFloorNumber); }
                    PopulateUnitTree();
                    PopulateHashParkingList();
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you extremely sure you want to delete " + tvUnitDetails.SelectedNode.Text + "? \nDELETED RECORD CANNOT BE RETRIEVED.", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No && intUnitId > 0) { throw new ApplicationException(Resources.strCancelledByUser); }
                bLayer.DeleteUnitData(intUnitId);
                PopulateUnitTree();
                MessageBox.Show("Unit Information Deleted Successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }
    }
}
