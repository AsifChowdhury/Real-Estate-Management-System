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

namespace RealEstateManagementSystem.UserInterface.Recovery
{
    public partial class frmAddInstallment_OA : Form
    {
        int clientId = 0;
        bllPayment installment = new bllPayment();
        public frmAddInstallment_OA()
        {
            InitializeComponent();
        }

        private void frmAddInstallment_OA_Load(object sender, EventArgs e)
        {
            clientId = clsCommonFunctions.GetNumericPartOfFullClientId(lblClientId.Text);
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT InstallTypeId, InstallType FROM defInstallType WHERE InstallTypeId IN (2,5)", "InstallType", "InstallTypeId", false, cmbInstallType);

        }

        private void cmbInstallType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PopulateExistingInstallmentList();
            clsCommonFunctions.PopulateComboboxWithDisplayAndValueMember("SELECT InstallmentId, InstallmentName FROM defInstallment WHERE InstallTypeId = " + cmbInstallType.SelectedValue.ToString() + " AND showInReport = 1 ORDER BY InstallmentName", "InstallmentName", "InstallmentId", false, cmbInstallmentName);
        }

        private void PopulateExistingInstallmentList()
        {
            lstInstallments.Items.Clear();
            foreach (DataRow drItems in installment.GetListOfInstallmentsByInstallType(clientId: clientId, installTypeId: cmbInstallType.SelectedValue.ToString().ConvertToInt32()).Rows)
            {
                ListViewItem lvItems = new ListViewItem(Convert.ToString(drItems["InstallmentId"]));
                lvItems.SubItems.Add(Convert.ToString(drItems["InstallmentName"]));
                lvItems.SubItems.Add(Spell.SpellAmount.comma(Convert.ToDecimal(drItems["Amount"])));
                lstInstallments.Items.Add(lvItems);
            }
        }

        private void lstInstallments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstInstallments.SelectedItems.Count < 1 || lstInstallments.Items.Count < 1) { return; }
            cmbInstallmentName.Text = lstInstallments.SelectedItems[0].SubItems[1].Text;
            txtAmount.Text = lstInstallments.SelectedItems[0].SubItems[2].Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Sure about manipulate " + cmbInstallType.Text.ToString() + "?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                InstallmentInfo i = new InstallmentInfo();
                i.InstallmentId = cmbInstallmentName.SelectedValue.ToString().ConvertToInt32();
                i.InstallmentAmount = txtAmount.Text.ToString().ConvertToInt32();
                installment.ManipulateOAInstallment(clientId, i);
                MessageBox.Show("Installment Saved Successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateExistingInstallmentList();
                txtAmount.Text = "0";
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

    }
}
