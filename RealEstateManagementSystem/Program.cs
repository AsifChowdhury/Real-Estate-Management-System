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
using RealEstateManagementSystem.Utilities;
using Microsoft.Win32;
using RealEstateManagementSystem.UserInterface.Root;

namespace RealEstateManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static readonly SqlConnection cnConn = new SqlConnection();
        public static string dataServerIP = string.Empty;
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
                    Application.Run(new UserInterface.Root.frmSplash());
                    mutex.ReleaseMutex();
                }
                else { MessageBox.Show(Application.ProductName.ToString() + " is Already Running." + Environment.NewLine + "One Instance at a time is permitted.", "Duplicate Instance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.strFailedMessage + ex.Message.ToString(), Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string CreateConnectionString()
        {
            string csDBConn = string.Empty;
            try
            {
                clsEncryption crypt = new clsEncryption();
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



                //dbCoreServerIP = ConfigurationManager.AppSettings["IsProductionEnvironment"].ToString().ConvertToBoolean() == true ?
                //                 @ConfigurationManager.AppSettings["ProductionServerIP"].ToString() :
                //                 @ConfigurationManager.AppSettings["StagingServerIP"].ToString();
                //dbCoreServerIP = @Registry.GetValue(clsGlobalClass.regKey, Resources.regCoreServerIP, "NA").ToString();//crypt.Decrypt((string)Registry.GetValue(clsGlobalClass.regKey, Resources.regCoreServerIP, "NA"), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256);
                dataServerIP = @dbCoreServerIP;
                string dbName = crypt.Decrypt((string)Registry.GetValue(clsGlobalClass.regKey, Resources.regDBName, "NA"), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256);
                string dbUserName = crypt.Decrypt((string)Registry.GetValue(clsGlobalClass.regKey, Resources.regDBUser, "NA"), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256);
                string dbPassword = crypt.Decrypt((string)Registry.GetValue(clsGlobalClass.regKey, Resources.regDBPass, "NA"), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256);
                csDBConn = "Server=" + @dataServerIP + ";Database=" + dbName + ";User Id=" + dbUserName + ";Password=" + dbPassword + ";";
            }
            catch (Exception ex) { MessageBox.Show("Database Connection Error: \n" + ex.Message.ToString() + "\n" + ex.StackTrace.ToString()); }
            return csDBConn;
        }


        public static void BaseConnection()
        {
            try
            {
                cnConn.ConnectionString = CreateConnectionString();
                cnConn.Open();
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool TestDBConnection()
        {
            SqlConnection cnTestConnection = new SqlConnection();
            if (cnTestConnection.State == ConnectionState.Open) cnTestConnection.Close();
            try
            {
                cnTestConnection.ConnectionString = CreateConnectionString();
                cnTestConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                string strEx = ex.Message.ToString();
                MessageBox.Show(Resources.strFailedMessage + strEx, Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally { cnTestConnection.Dispose(); }
        }


        internal static void CloseDBConnection()
        {
            try { if (cnConn.State == ConnectionState.Open) cnConn.Close(); }
            catch (Exception ex) { throw ex; }
        }
    }
}
