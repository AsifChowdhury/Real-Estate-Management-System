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
    public partial class frmDefinition_SaleOffer : Form
    {
        bllSaleOffer bLayer = new bllSaleOffer();
        public frmDefinition_SaleOffer()
        {
            InitializeComponent();
        }

        private void frmDefinition_SaleOffer_Load(object sender, EventArgs e)
        {
            PopulateListOfSaleOffers();
        }

        private void PopulateListOfSaleOffers()
        {
            clsCommonFunctions.AutoFormatListViewControl(lvOfferList);
            foreach (DataRow drItems in bLayer.ListOfSaleOffers().Rows)
            {
                ListViewItem lvItems = new ListViewItem(drItems["OfferId"].ToString());
                lvItems.SubItems.Add(drItems["OfferName"].ToString());
                lvItems.SubItems.Add(drItems["Remarks"].ToString());
                lvItems.SubItems.Add(drItems["StartDate"].ToString().ShowAsStandardDateFormat(false));
                lvItems.SubItems.Add(drItems["EndDate"].ToString().ShowAsStandardDateFormat(false));
                lvOfferList.Items.Add(lvItems);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            PopulateListOfSaleOffers();
            txtOfferName.Text = txtOfferRemarks.Text = string.Empty;
            dtpStartDate.Value = dtpEndDate.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string message = string.Empty;
                message = lvOfferList.SelectedItems.Count > 0 ? "Sure about Update Offer " + lvOfferList.SelectedItems[0].SubItems[1].Text.ToString() + "?" : "Sure about insert new sale offer?";
                if (MessageBox.Show(message, Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { throw new ApplicationException(Resources.strCancelledByUser); }
                SaleOffer so = new SaleOffer();
                so.SaleOfferId = lvOfferList.SelectedItems.Count > 0 ? lvOfferList.SelectedItems[0].Text.ToString().ConvertToInt32() : 0;
                so.OfferName = txtOfferName.Text;
                so.Remarks = txtOfferRemarks.Text;
                so.StartDate = dtpStartDate.Value;
                so.EndDate = dtpEndDate.Value;
                bLayer.SaveSaleOffer(so);
                MessageBox.Show(Resources.strSuccessMessage, Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();
            }
            catch (Exception ex) { ex.Display(); }
        }

        private void lvOfferList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvOfferList.SelectedItems.Count < 1) return;
            SaleOffer so = new SaleOffer();
            so.SaleOfferId = lvOfferList.SelectedItems[0].Text.ToString().ConvertToInt32();
            bLayer.GetOfferData(so);
            txtOfferName.Text = so.OfferName;
            txtOfferRemarks.Text = so.Remarks;
            dtpStartDate.Value = so.StartDate;
            dtpEndDate.Value = so.EndDate;

        }
    }
}
