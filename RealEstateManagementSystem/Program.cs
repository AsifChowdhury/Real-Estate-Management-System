using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;
using RealEstateManagementSystem.Properties;

namespace RealEstateManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>




        public static readonly SqlConnection cnConn = new SqlConnection();
        static Mutex mutex = new Mutex(true, "{C0C20DEC-9982-4922-8C9D-8BAF6B866CDE}");
        [STAThread]
        static void Main()
        {

            try
            {
                if (mutex.WaitOne(TimeSpan.Zero, true))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    OpenDBConnection();
                    Application.Run(new UserInterface.Root.frmLogIn());
                    //Application.Run(new IDM_AWS.Interfaces.AWS_Root.frmSplash());
                    mutex.ReleaseMutex();
                }
                else { MessageBox.Show(Application.ProductName.ToString() + " is Already Running." + Environment.NewLine + "One Instance at a time is permitted.", "Duplicate Instance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.strFailedMessage + ex.Message.ToString(), Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void OpenDBConnection()
        {
            try
            {
                //cnConn.ConnectionString = ConfigurationManager.ConnectionStrings["cnProduction"].ToString();
                cnConn.ConnectionString = ConfigurationManager.ConnectionStrings["cnStatging"].ToString();
                cnConn.Open();
            }
            catch (Exception ex) { throw ex; }
        }



        internal static void CloseDBConnection()
        {
            try { if (cnConn.State == ConnectionState.Open) cnConn.Close(); }
            catch (Exception ex) { throw ex; }
        }
    }
}
