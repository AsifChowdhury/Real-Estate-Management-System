using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateManagementSystem.Reports
{
    class clsReports
    {
        public static void ShowReport_ClientProfile(string strClientId, ToolStripStatusLabel tssStatus)
        {
            bllClientInfo b = new bllClientInfo();
            tssStatus.Text = "Generating Client Profile.....";
            int clientId = clsCommonFunctions.GetNumericPartOfFullClientId(strClientId);
            Reports.Clients.crptClientProfile crptProfile = new Reports.Clients.crptClientProfile();
            crptProfile.SetDataSource(b.GetClientProfile(clientId: clientId).Tables[0]);
            crptProfile.Subreports[1].SetDataSource(b.GetListOfPartners(clientId: clientId));
            crptProfile.Subreports[2].SetDataSource(b.GetPaymentSchedule(clientId: clientId).Tables[0]);
            clsCommonFunctions.ShowReport(crptProfile, tssStatus, true, clsGlobalClass.userFullName);
        }
    }
}
