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
        public static readonly string applicationName = Assembly.GetExecutingAssembly().GetName().Name;
        public static readonly string workStationName = Environment.MachineName;
        public static readonly string workStationIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(o => o.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First().ToString();
        public static readonly string currentVersion = ApplicationDeployment.IsNetworkDeployed == true ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString() : Application.ProductVersion.ToString();
        public static readonly string publishLocation = ApplicationDeployment.IsNetworkDeployed == true ? ApplicationDeployment.CurrentDeployment.UpdateLocation.AbsolutePath.ToString() : "Desktop Deployment";
        public static readonly DateTime calculateAsNULLDate = Convert.ToDateTime("01/02/1900");
        public static readonly DateTime defaultDate = Convert.ToDateTime("01/01/1900");

        public enum ProjectStatus
        {
            Cancelled = 1,
            Handover = 2,
            Ongoing = 3,
            PreWork = 4,
            Ready = 5,
            Upcoming = 6,
            All = 7
        }
        #endregion
    }
}
