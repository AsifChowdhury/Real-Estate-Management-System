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
    public partial class frmDefinition_BankBranch : Form
    {
        bllBankBranchDefinition def = new bllBankBranchDefinition();
        int bankId = 0, branchId = 0;
        public frmDefinition_BankBranch()
        {
            InitializeComponent();
        }

        private void frmDefinition_BankBranch_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateBankList();
                PopulateBranchList();
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void PopulateBranchList()
        {
            lstBranch.Items.Clear();
            foreach (DataRow drItems in def.GetListOfBranches().Rows)
            {
                ListViewItem lvItems = new ListViewItem(Convert.ToString(drItems["BranchId"]));
                lvItems.SubItems.Add(Convert.ToString(drItems["BranchName"]));
                lstBranch.Items.Add(lvItems);
            }
            lblBranchCount.Text = lstBranch.Items.Count.ToString() + " Branches Found.";
        }

        private void PopulateBankList()
        {
            lstBank.Items.Clear();
            foreach (DataRow drItems in def.GetListOfBanks().Rows)
            {
                ListViewItem lvItems = new ListViewItem(Convert.ToString(drItems["BankId"]));
                lvItems.SubItems.Add(Convert.ToString(drItems["BankName"]));
                lstBank.Items.Add(lvItems);
            }
            lblBankCount.Text = lstBank.Items.Count.ToString() + " Bank(s) Found.";
        }

        private void btnSaveBank_Click(object sender, EventArgs e)
        {
            try
            {
                string strMessage = bankId == 0 ? "Sure about INSERT a new Bank Information?" : "Sure about UPDATE this Bank Name?";
                DialogResult dr = MessageBox.Show(strMessage, Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) { throw new ApplicationException(Resources.strCancelledByUser); }
                BankInfo b = new BankInfo();
                b.BankId = bankId;
                b.BankName = txtBankName.Text;
                def.ManipulateBankInfo(b);
                MessageBox.Show("Bank information saved successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshBankTab();

            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnRefreshBank_Click(object sender, EventArgs e)
        {
            RefreshBankTab();
        }

        private void RefreshBankTab()
        {
            bankId = 0;
            txtBankName.Text = string.Empty;
            PopulateBankList();
            txtBankName.Focus();
        }

        private void lstBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstBranch.Items.Count < 1 || lstBranch.SelectedItems.Count < 1) { return; }
                branchId = lstBranch.SelectedItems[0].Text.ToString().ConvertToInt32();
                BranchInfo b = new BranchInfo();
                b.BranchId = branchId;
                def.GetBranchInfo(b);
                txtBranchName.Text = b.BranchName;
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void btnRefreshBranchTab_Click(object sender, EventArgs e)
        {
            RefreshBranchTab();
        }

        private void RefreshBranchTab()
        {
            branchId = 0;
            txtBranchName.Text = string.Empty;
            PopulateBranchList();
            txtBranchName.Focus();
        }

        private void btnSaveBranch_Click(object sender, EventArgs e)
        {
            try
            {
                string strMessage = branchId == 0 ? "Sure about INSERT a new Branch Information?" : "Sure about UPDATE this Branch Name?";
                DialogResult dr = MessageBox.Show(strMessage, Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) { throw new ApplicationException(Resources.strCancelledByUser); }
                BranchInfo b = new BranchInfo();
                b.BranchId = branchId;
                b.BranchName = txtBranchName.Text;
                def.ManipulateBranchInfo(b);
                MessageBox.Show("Branch information saved successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshBranchTab();
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void lstBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstBank.SelectedItems.Count < 1 || lstBank.Items.Count < 1) { return; }
                bankId = lstBank.SelectedItems[0].Text.ToString().ConvertToInt32();
                BankInfo b = new BankInfo();
                b.BankId = bankId;
                def.GetBankInfo(b);
                txtBankName.Text = b.BankName;
            }
            catch (Exception ex) { ex.ProcessException(); }

        }
    }
}
