using Microsoft.Win32;
using RealEstateManagementSystem.Properties;
using RealEstateManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateManagementSystem.UserInterface.Root
{
    public partial class frmDBLogIn : Form
    {
        public frmDBLogIn()
        {
            InitializeComponent();
        }

        private void btnSetDBConnection_Click(object sender, EventArgs e)
        {
            try
            {
                clsEncryption crypt = new clsEncryption();
                
                Registry.SetValue(clsGlobalClass.regKey, Resources.regCoreServerIP, (string)crypt.Encrypt(@ConfigurationManager.AppSettings["ProductionServerIP"].ToString(), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256));
                Registry.SetValue(clsGlobalClass.regKey, Resources.regStagingServerIP, (string)crypt.Encrypt(@ConfigurationManager.AppSettings["StagingServerIP"].ToString(), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256));
                Registry.SetValue(clsGlobalClass.regKey, Resources.regDeveloperServerIP, (string)crypt.Encrypt(@ConfigurationManager.AppSettings["DeveloperServerIP"].ToString(), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256));
                Registry.SetValue(clsGlobalClass.regKey, Resources.regDBName, (string)crypt.Encrypt(txtDBName.Text.ToString(), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256));
                Registry.SetValue(clsGlobalClass.regKey, Resources.regDBUser, (string)crypt.Encrypt(txtUserId.Text.ToString(), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256));
                Registry.SetValue(clsGlobalClass.regKey, Resources.regDBPass, (string)crypt.Encrypt(txtPassword.Text.ToString(), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256));
                if (Program.TestDBConnection() == false)
                {
                    throw new ApplicationException("Connection Failed");
                }
                else
                {
                    MessageBox.Show("Connection Setup Successfully Completed.\nPlease Restart App.", Resources.strSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart(); //.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.strFailedMessage + ex.Message.ToString(), Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDBLogIn_Load(object sender, EventArgs e)
        {
            //ASIF-CHOWDHURY\SQLEXPRESS
            string dbCoreServerIP = string.Empty;

            switch (ConfigurationManager.AppSettings["DBEnvironment"].ToString())
            {
                case "0":
                    dbCoreServerIP = @ConfigurationManager.AppSettings["ProductionServerIP"].ToString();
                    break;
                case "1":
                    dbCoreServerIP = @ConfigurationManager.AppSettings["StagingServerIP"].ToString();
                    break;
                case "2":
                    dbCoreServerIP = @ConfigurationManager.AppSettings["DeveloperServerIP"].ToString();
                    break;
                default:
                    break;
            }
            txtServerIP.Text = dbCoreServerIP;
            txtDBName.Text = ConfigurationManager.AppSettings["DBName"].ToString();
        }
    }
}
