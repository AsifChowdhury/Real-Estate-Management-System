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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            try
            {
                clsCommonFunctions.SearchClient(txtClientId);
                //LoadClientData(strClientId: txtClientId.Text.ToString());
            }
            catch (Exception ex) { ex.Display(); tssStatus.Text = Resources.strReadyStatus; }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void frmPayment_Load(object sender, EventArgs e)
        {

        }

        private void pnlClientIds_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
