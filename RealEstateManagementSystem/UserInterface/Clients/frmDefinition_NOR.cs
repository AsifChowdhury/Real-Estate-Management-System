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

namespace RealEstateManagementSystem.UserInterface.Clients
{
    public partial class frmDefinition_NOR : Form
    {
        bllNOR bLayer = new bllNOR();
        int id = 0;


        private void PopulateListOfDefinition()
        {
            string strSQLQuery = string.Empty;
            if (rbNationality.Checked == true)
            {
                strSQLQuery = "SELECT NationalityID, Nationality FROM defNationality ORDER BY NationalityID";
            }
            else if (rbOccupation.Checked == true)
            {
                strSQLQuery = "SELECT OccupationId, Occupation FROM defOccupation ORDER BY Occupation";
            }
            else if (rbReligion.Checked == true)
            {
                strSQLQuery = "SELECT ReligionId, Religion FROM defReligion ORDER BY ReligionId";
            }
            clsCommonFunctions.PopulateListViewsFromSingleLineQuery(strSQLQuery, lvDefinition, lblRecordCount, true);
            id = 0;
        }

        private void rbOccupation_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOccupation.Checked == true)
            {
                lblDefinition.Text = "Occupation:";
                PopulateListOfDefinition();
            }
        }

        private void rbNationality_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNationality.Checked == true)
            {
                lblDefinition.Text = "Nationality:";
                PopulateListOfDefinition();
            }
        }

        private void rbReligion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReligion.Checked == true)
            {
                lblDefinition.Text = "Religion";
                PopulateListOfDefinition();
            }
        }

        private void lvDefinition_Click(object sender, EventArgs e)
        {
           
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(id > 0 ? Resources.strUpdateConfirmation : Resources.strInsertConfirmation, Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                NationalityReligionOccupation nor = new NationalityReligionOccupation();
                if (rbNationality.Checked == true)
                {
                    nor.NationalityId = id;
                    nor.Nationality = txtDefinition.Text.ToString();
                    bLayer.ManipulateNationality(nor);
                }
                else if (rbOccupation.Checked == true)
                {
                    nor.OccupationId = id;
                    nor.Occupation = txtDefinition.Text.ToString();
                    bLayer.ManipulateOccupation(nor);
                }
                else if (rbReligion.Checked == true)
                {
                    nor.ReligionId = id;
                    nor.Religion = txtDefinition.Text.ToString();
                    bLayer.ManipulateReligion(nor);
                }
                RefreshForm();
                MessageBox.Show(Resources.strSuccessMessage, Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { ex.Display(); }
        }

        public frmDefinition_NOR()
        {
            InitializeComponent();
        }

        private void frmDefinition_NOR_Load(object sender, EventArgs e)
        {
            PopulateListOfDefinition();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            txtDefinition.Text = string.Empty;
            PopulateListOfDefinition();
            id = 0;
            txtDefinition.Focus();
        }

        private void lvDefinition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDefinition.SelectedItems.Count < 1 || lvDefinition.Items.Count < 1) return;
            id = lvDefinition.SelectedItems[0].Text.ToString().ConvertToInt32();
            txtDefinition.Text = lvDefinition.SelectedItems[0].SubItems[1].Text;
        }
    }
}
