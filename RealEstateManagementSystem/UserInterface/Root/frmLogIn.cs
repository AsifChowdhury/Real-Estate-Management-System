using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateManagementSystem.BusinessLogicLayer;
using Microsoft.Win32;
using RealEstateManagementSystem.Properties;
using RealEstateManagementSystem.Utilities;

namespace RealEstateManagementSystem.UserInterface.Root
{
    public partial class frmLogIn : Form
    {
        bllUserControl _bLayer = new bllUserControl();
        string regKey = Resources.regRoot + "\\" + Resources.regSubKey;

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void cmdLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                _bLayer.UserId = txtUserId.Text.ToString();
                _bLayer.Password = txtPassword.Text.ToString();
                MainScreen root = new MainScreen();
                if (_bLayer.ValidateUserLogIn() == true)
                {
                    clsGlobalClass.userId = txtUserId.Text.ToString();
                    this.Hide();
                    root.Show();
                    
                    Registry.SetValue(regKey, "UserId", chkRememberLogIn.Checked == true ? txtUserId.Text.ToString() : "");
                    Registry.SetValue(regKey, "RememberLogIn", chkRememberLogIn.Checked == true ? 1 : 0);
                }
            }
            catch (Exception ex) { MessageBox.Show(Resources.strFailedMessage + ex.Message.ToString(), Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            if (Registry.GetValue(regKey, "RememberLogIn", 1) == null || (int)Registry.GetValue(regKey, "RememberLogIn", 1) == 0)
            {
                txtUserId.Text = "";
                chkRememberLogIn.Checked = false;
            }
            else
            {
                txtUserId.Text = (string)Registry.GetValue(regKey, "UserId", "Not Found");
                chkRememberLogIn.Checked = true;
                txtPassword.TabIndex = 0;
                cmdLogIn.TabIndex = 1;
                chkRememberLogIn.TabIndex = 2;
                txtUserId.TabIndex = 3;
            }
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            chkRememberLogIn.Checked = false;
        }
    }
}
