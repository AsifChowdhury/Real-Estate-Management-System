using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;
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
    public partial class frmDef_Locations : Form
    {

        private bllProjectInfo bLayer = new bllProjectInfo();
        int districtId = 0, areaId = 0, locationId = 0;

        public frmDef_Locations()
        {
            InitializeComponent();
        }

        private void frmDef_Locations_Load(object sender, EventArgs e)
        {
            clsCommonFunctions.AutoFormatComboBoxes(this);
            clsCommonFunctions.PopulateListOfDistricts(cmbL_District);
            clsCommonFunctions.PopulateListOfDistricts(cmbA_District);
            PrepareTreeView();
        }

        private void PrepareTreeView()
        {
            tvLocationDetails.Nodes.Clear();
            foreach (DataRow drDistricts in bLayer.GetListOfDistricts().Rows)
            {
                TreeNode tnDistrict = new TreeNode(drDistricts["DistrictName"].ToString());
                tnDistrict.ImageIndex = 0;
                tnDistrict.SelectedImageIndex = 0;
                tvLocationDetails.Nodes.Add(tnDistrict);
                tnDistrict.Tag = "D" + drDistricts["DistrictId"].ToString();
                foreach (DataRow drArea in bLayer.GetListOfAreas(Convert.ToInt32(tnDistrict.Tag.ToString().Substring(1))).Rows)
                {
                    TreeNode tnArea = new TreeNode(drArea["AreaName"].ToString());
                    tnArea.ImageIndex = 1;
                    tnArea.SelectedImageIndex = 1;
                    tnArea.Tag = "A" + drArea["AreaId"].ToString();
                    tnDistrict.Nodes.Add(tnArea);
                    foreach (DataRow drLocations in bLayer.GetListOfLocations(Convert.ToInt32(tnArea.Tag.ToString().Substring(1))).Rows)
                    {
                        TreeNode tnLocation = new TreeNode(drLocations["LocationName"].ToString());
                        tnLocation.ImageIndex = 2;
                        tnLocation.SelectedImageIndex = 2;
                        tnLocation.Tag = "L" + drLocations["LocationId"].ToString();
                        tnArea.Nodes.Add(tnLocation);
                    }
                }
            }
        }

        private void cmbL_District_SelectedIndexChanged(object sender, EventArgs e)
        {
            bLayer.PopulateListOfAreas(cmbL_Area, cmbL_District.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            if (rbDistrict.Checked == true)
            {
                districtId = 0;
                txtDistrictName.Text = txtDistrictName_Bangla.Text = string.Empty;
            }
            else if (rbArea.Checked == true)
            {
                areaId = 0;
                txtAreaName.Text = txtAreaName_Bangla.Text = string.Empty;
            }
            else if (rbLocation.Checked == true)
            {
                locationId = 0;
                txtLocationName.Text = txtLocationName_Bangla.Text = string.Empty;
            }
            clsCommonFunctions.PopulateListOfDistricts(cmbA_District);
            clsCommonFunctions.PopulateListOfDistricts(cmbL_District);
            cmbL_Area.DataSource = null;
            btnSave.Text = "Insert";
            PrepareTreeView();
        }

        private void rbDistrict_CheckedChanged(object sender, EventArgs e)
        {
            pnlDistrict.Visible = rbDistrict.Checked;
        }

        private void rbArea_CheckedChanged(object sender, EventArgs e)
        {
            pnlArea.Visible = rbArea.Checked;
        }

        private void rbLocation_CheckedChanged(object sender, EventArgs e)
        {
            pnlLocation.Visible = rbLocation.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(districtId > 0 || areaId > 0 || locationId > 0 ? Resources.strUpdateConfirmation : Resources.strInsertConfirmation, Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                if (rbDistrict.Checked == true)
                {
                    bLayer.DistrictId = districtId;
                    bLayer.DistrictName = txtDistrictName.Text.ToString();
                    bLayer.DistrictName_Bangla = txtDistrictName_Bangla.Text.ToString();
                    bLayer.ManipulateDistrictInfo();
                }
                else if (rbArea.Checked == true)
                {
                    bLayer.AreaId = areaId;
                    bLayer.DistrictId = Convert.ToInt32(cmbA_District.SelectedValue);
                    bLayer.AreaName = txtAreaName.Text.ToString();
                    bLayer.AreaName_Bangla = txtAreaName_Bangla.Text.ToString();
                    bLayer.ManipulateAreaInfo();
                }
                else if (rbLocation.Checked == true)
                {
                    bLayer.LocationId = locationId;
                    bLayer.AreaId = Convert.ToInt32(cmbL_Area.SelectedValue);
                    bLayer.LocationName = txtLocationName.Text.ToString();
                    bLayer.LocationName_Bangla = txtLocationName_Bangla.Text.ToString();
                    bLayer.ManipulateLocationInfo();
                }
                ResetForm();
                MessageBox.Show(Resources.strSuccessMessage, Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ex.Display(); }
        }

        private void tvLocationDetails_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                btnSave.Text = "Update";
                int id = Convert.ToInt32(e.Node.Tag.ToString().Substring(1));
                switch (e.Node.Tag.ToString().Substring(0, 1))
                {
                    case "D":
                        rbDistrict.Checked = true;
                        districtId = id;
                        bLayer.DistrictId = districtId;
                        bLayer.GetDistrictInfo();
                        txtDistrictName.Text = bLayer.DistrictName;
                        txtDistrictName_Bangla.Text = bLayer.DistrictName_Bangla;
                        break;
                    case "A":
                        rbArea.Checked = true;
                        areaId = id;
                        bLayer.AreaId = areaId;
                        bLayer.GetAreaInfo();
                        cmbA_District.Text = bLayer.DistrictName;
                        txtAreaName.Text = bLayer.AreaName;
                        txtAreaName_Bangla.Text = bLayer.AreaName_Bangla;
                        break;
                    case "L":
                        rbLocation.Checked = true;
                        locationId = id;
                        bLayer.LocationId = locationId;
                        bLayer.GetLocationInfo();
                        cmbL_District.Text = bLayer.DistrictName;
                        cmbL_Area.Text = bLayer.AreaName;
                        txtLocationName.Text = bLayer.LocationName;
                        txtLocationName_Bangla.Text = bLayer.LocationName_Bangla;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { ex.Display(); }
        }
    }
}
