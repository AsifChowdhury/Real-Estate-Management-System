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
        public frmDef_Locations()
        {
            InitializeComponent();
        }

        private void frmDef_Locations_Load(object sender, EventArgs e)
        {
            clsCommonFunctions.AutoFormatComboBoxes(this);
            clsCommonFunctions.PopulateListOfDistricts(cmbDistrict);
            clsCommonFunctions.AutoFormatListViews(this);

        }

        private void cmbDistrict_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                bLayer.PopulateListOfAreas(cmbAreas, cmbDistrict.Text);
                bLayer.PopulateLocationDetails(lstLocationDetails, cmbDistrict.Text);

            }
            catch (Exception ex) { MessageBox.Show(Resources.strFailedMessage + ex.Message.ToString(), Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {

        }

    }
}
