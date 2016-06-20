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
                    root.ShowDialog();

                    Registry.SetValue(clsGlobalClass.regKey, "UserId", chkRememberLogIn.Checked == true ? txtUserId.Text.ToString() : "");
                    Registry.SetValue(clsGlobalClass.regKey, "RememberLogIn", chkRememberLogIn.Checked == true ? 1 : 0);

                }
            }
            catch (Exception ex) { clsCommonFunctions.LogError(ex); }
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
                txtUserId.Text = (string)Registry.GetValue(clsGlobalClass.regKey, "UserId", "");
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
