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
        clsEncryption crypt = new clsEncryption();

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
                    _bLayer.UserId = clsGlobalClass.userId.ToString();
                    _bLayer.GetUserDetails();
                    clsGlobalClass.userFullName = _bLayer.EmployeeName.ToString();
                    clsGlobalClass.userDesignation = _bLayer.CurrentPosition.ToString();
                    this.Hide();
                    root.ShowDialog();

                    Registry.SetValue(clsGlobalClass.regKey, "UserId", chkRememberLogIn.Checked == true ? (string)crypt.Encrypt(txtUserId.Text.ToString(), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256) : "");
                    Registry.SetValue(clsGlobalClass.regKey, "RememberLogIn", chkRememberLogIn.Checked == true ? 1 : 0);
                    Registry.SetValue(clsGlobalClass.regKey, "Key", chkRememberPassword.Checked == true ? (string)crypt.Encrypt(txtPassword.Text.ToString(), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256) : "");
                    Registry.SetValue(clsGlobalClass.regKey, "RememberKey", chkRememberPassword.Checked == true ? 1 : 0);
                }
                else
                {
                    MessageBox.Show("Invalid user credentials.\nPlease contact IT.");
                }
            }
            catch (Exception ex) { ex.Display(); }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            if (Registry.GetValue(clsGlobalClass.regKey, "RememberLogIn", 0) == null || (int)Registry.GetValue(clsGlobalClass.regKey, "RememberLogIn", 0) == 0)
            {
                txtUserId.Text = "";
                chkRememberLogIn.Checked = false;
            }
            else
            {
                //txtUserId.Text = (string)Registry.GetValue(clsGlobalClass.regKey, "UserId", "");
                txtUserId.Text = crypt.Decrypt((string)Registry.GetValue(clsGlobalClass.regKey, Resources.regUserId, "NA"), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256);
                chkRememberLogIn.Checked = true;
                txtPassword.TabIndex = 0;
                cmdLogIn.TabIndex = 1;
                chkRememberLogIn.TabIndex = 2;
                txtUserId.TabIndex = 3;
            }

            if (Registry.GetValue(clsGlobalClass.regKey, "RememberKey", 0) == null || (int)Registry.GetValue(clsGlobalClass.regKey, "RememberKey", 0) == 0)
            {
                txtPassword.Text = "";
                chkRememberPassword.Checked = false;
            }
            else
            {
                //txtUserId.Text = (string)Registry.GetValue(clsGlobalClass.regKey, "UserId", "");
                txtPassword.Text = crypt.Decrypt((string)Registry.GetValue(clsGlobalClass.regKey, Resources.regPassword, "NA"), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256);
                chkRememberPassword.Checked = true;
                cmdLogIn.TabIndex = 0;
                txtUserId.TabIndex = 1;
                txtPassword.TabIndex = 2;
                chkRememberLogIn.TabIndex = 3;
                chkRememberPassword.TabIndex = 4;
            }
            tssLogIn.Text = "Verson:" + clsGlobalClass.currentVersion.ToString();
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            chkRememberLogIn.Checked = false;
        }


    }
}
