using Microsoft.Win32;
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

namespace RealEstateManagementSystem.UserInterface.Root
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            string dbUser = (string)Registry.GetValue(clsGlobalClass.regKey, "CoreServerIP", "NA");
            frmDBLogIn dbLogIn = new frmDBLogIn();
            frmLogIn userLogIn = new frmLogIn();
            if (dbUser == "NA" || dbUser == null) { dbLogIn.ShowDialog(); }
            else
            {
                if (Program.TestDBConnection() == false) { dbLogIn.ShowDialog(); }
                else { Program.BaseConnection(); userLogIn.ShowDialog(); }
            }
            this.Close();
        }
    }
}
