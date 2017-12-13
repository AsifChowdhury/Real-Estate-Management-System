using RealEstateManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateManagementSystem.Utilities
{
    class clsGlobalClass
    {
        #region Variables for Global Use
        public Color alternateRowColor = Color.Gainsboro;
        public static string regKey = Resources.regRoot + "\\" + Resources.regSubKey;
        public static string userId = "";
        public static string userFullName = "";
        public static string userDesignation = "";
        public static string clientId = "";
        public static readonly string applicationName = Assembly.GetExecutingAssembly().GetName().Name;
        public static readonly int applicationId = 5;
        public static readonly string workStationName = Environment.MachineName;
        public static readonly string workStationIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(o => o.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First().ToString();
        public static readonly string currentVersion = ApplicationDeployment.IsNetworkDeployed == true ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString() : Application.ProductVersion.ToString();
        public static readonly string publishLocation = ApplicationDeployment.IsNetworkDeployed == true ? ApplicationDeployment.CurrentDeployment.UpdateLocation.AbsolutePath.ToString() : "Desktop Deployment";
        public static readonly DateTime considerAsNULLDate = Convert.ToDateTime("02/02/1900");
        public static readonly DateTime defaultDate = Convert.ToDateTime("1900-01-01");

        public enum ProjectCommonReport_FilterBy
        {
            ProjectStatus = 1,
            District = 2,
            Area = 3,
            Location = 4,
            ProjectType = 5
        }


        public enum ProjectStatus
        {
            Cancelled = 1,
            Handover = 2,
            Ongoing = 3,
            PreWork = 4,
            Ready = 5,
            Upcoming = 6,
            All = 7,
            AllExceptCancelled = 8
        }

        public enum ClientStatus
        {
            Cancelled = 0,
            Active = 1,
            IncompleteProfile = 2,
            Transferred = 3
        }


        public enum ChequeSearchBy
        {
            Invoice,
            ClientId,
            Bank,
            DateRange
        }

        internal static void ShowUnderConstructionMessage()
        {
            MessageBox.Show("This module is Under Construction. \nWe're ready to prioritize any module based on frequent need.\nPlease feel free to notify IT, if you need this module completed immediately.", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        #endregion
    }
}
