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

namespace RealEstateManagementSystem.UserInterface.UserAuthentication
{
    public partial class frmUserAuthentication : Form
    {
        private bllUserControl bLayer = new bllUserControl();
        public frmUserAuthentication()
        {
            InitializeComponent();
        }

        private void frmUserAuthentication_Load(object sender, EventArgs e)
        {
            clsCommonFunctions.AutoFormatListViews(root: this, checkBoxes: true, isAlternateColor: false);
            PopulateAuthenticationList();
            LoadApplicationMenuItemsTreeView();
            //clsCommonFunctions.PopulateListViewFromDataTable(dataTable: bLayer.GetListOfAuthenticatedUsers(), lView: listView1);
        }

        private void LoadApplicationMenuItemsTreeView()
        {
            try
            {
                Root.MainScreen main = new Root.MainScreen();
                foreach (ToolStripMenuItem level1 in main.msMainForm.Items)
                {
                    TreeNode tnLevel1 = new TreeNode(level1.Text.ToString().Replace("&&", "&"));
                    tvMainMenu.Nodes.Add(tnLevel1);
                    tnLevel1.Tag = level1.Name.ToString();
                    foreach (ToolStripMenuItem level2 in level1.DropDownItems)
                    {
                        TreeNode tnLevel2 = new TreeNode(level2.Text.ToString().Replace("&&", "&"));
                        tnLevel1.Nodes.Add(tnLevel2);
                        tnLevel2.Tag = level2.Name.ToString();
                        foreach (ToolStripMenuItem level3 in level2.DropDownItems)
                        {
                            TreeNode tnLevel3 = new TreeNode(level3.Text.ToString().Replace("&&", "&"));
                            tnLevel2.Nodes.Add(tnLevel3);
                            tnLevel3.Tag = level3.Name.ToString();
                            foreach (ToolStripMenuItem level4 in level3.DropDownItems)
                            {
                                TreeNode tnLevel4 = new TreeNode(level4.Text.ToString().Replace("&&", "&"));
                                tnLevel3.Nodes.Add(tnLevel4);
                                tnLevel4.Tag = level4.Name.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void PopulateAuthenticationList()
        {
            lvAppAuthentication.Items.Clear();
            foreach (DataRow drItems in bLayer.GetListOfAuthenticatedUsers().Rows)
            {
                string[] arrItems =
                    {
                        drItems["EmpId"].ToString().ToUpper(),
                        drItems["CompanyId"].ToString(),
                        drItems["Name"].ToString(),
                        drItems["Designation"].ToString()
                    };
                ListViewItem lvItems = new ListViewItem(arrItems);
                lvItems.Checked = drItems["IsAllowed"].ToString() == "1" ? true : false;
                lvItems.ForeColor = drItems["IsAllowed"].ToString() == "1" ? Color.DarkGreen : Color.Maroon;
                lvAppAuthentication.Items.Add(lvItems);
            }
            lvAppAuthentication.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnSetAppPermission_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(Resources.strConfirmationMessage, Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) { throw new ApplicationException(Resources.strCancelledByUser); }
                if (MessageBox.Show("Are you sure you want to authenticate selected users to use this app?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                foreach (ListViewItem lvItems in lvAppAuthentication.Items)
                {
                    bLayer.UserId = lvItems.Text.ToString();
                    bLayer.IsAllowed = lvItems.Checked;
                    bLayer.SetAppAuthentication();
                }
                MessageBox.Show("User authenticated successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateAuthenticationList();
            }
            catch (Exception ex) { ex.ProcessException(); }


        }

        private void tvMainMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                lstUsers.Items.Clear();
                if (e.Node.Tag.ToString().Substring(0, 4) == "tsmi")
                {
                    bLayer.MenuKey = e.Node.Tag.ToString();
                    foreach (DataRow drItems in bLayer.GetListOfAuthorizedUsers_ByMenuKey().Rows)
                    {
                        string[] arrItems = { drItems["EmpId"].ToString(), drItems["CompanyId"].ToString(), drItems["Name"].ToString(), drItems["CurrentPosition"].ToString() };
                        ListViewItem lvItem = new ListViewItem(arrItems);
                        lvItem.Checked = drItems["IsAllowed"].ToString() == "1" ? true : false;
                        lvItem.ForeColor = drItems["IsAllowed"].ToString() == "1" ? Color.Green : Color.Maroon;
                        lstUsers.Items.Add(lvItem);
                    }
                    btnSetMenuPermission.Enabled = true;
                    lstUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                else
                {
                    btnSetMenuPermission.Enabled = false;
                }
            }
            catch (Exception ex) { ex.ProcessException(); }

        }

        private void btnSetMenuPermission_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure about approve this authentication list?", Resources.strConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) throw new ApplicationException(Resources.strCancelledByUser);
                UpdateMenuItems();
                SetMenuPermission();
                MessageBox.Show("Authentication applied successfully.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void SetMenuPermission()
        {
            try
            {
                bLayer.MenuKey = tvMainMenu.SelectedNode.Tag.ToString();
                foreach (ListViewItem lvItems in lstUsers.Items)
                {
                    bLayer.UserId = lvItems.Text.ToString();
                    bLayer.IsAllowed = lvItems.Checked;
                    bLayer.SetAppMenuAuthentication();
                }
            }
            catch (Exception ex) { throw ex; }

        }

        private void UpdateMenuItems()
        {
            try
            {
                foreach (TreeNode level1 in tvMainMenu.Nodes)
                {
                    if (level1.Tag.ToString().Substring(0, 4) == "tsmi")
                    {
                        bLayer.MenuKey = level1.Tag.ToString();
                        bLayer.ManipulateApplicationMenu();
                    }
                    foreach (TreeNode level2 in level1.Nodes)
                    {
                        if (level2.Tag.ToString().Substring(0, 4) == "tsmi")
                        {
                            bLayer.MenuKey = level2.Tag.ToString();
                            bLayer.ManipulateApplicationMenu();
                        }
                        foreach (TreeNode level3 in level2.Nodes)
                        {
                            if (level3.Tag.ToString().Substring(0, 4) == "tsmi")
                            {
                                bLayer.MenuKey = level3.Tag.ToString();
                                bLayer.ManipulateApplicationMenu();
                            }
                            foreach (TreeNode level4 in level3.Nodes)
                            {
                                if (level4.Tag.ToString().Substring(0, 4) == "tsmi")
                                {
                                    bLayer.MenuKey = level4.Tag.ToString();
                                    bLayer.ManipulateApplicationMenu();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
