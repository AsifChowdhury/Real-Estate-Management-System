using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace RealEstateManagementSystem.Utilities
{


    class clsCommonFunctions
    {
        #region Common Variables
        private static bool blnValidEmail = false;
        #endregion

        #region Common Use
        internal static int GetNumericPartOfFullClientId(string fullClientId)
        {
            int clientId = 0;
            if (!String.IsNullOrEmpty(fullClientId))
                clientId = fullClientId.Substring(9).ToString().ConvertToInt32();
            return clientId;
        }

        internal static bool CheckIfValidClientId(string clientId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            bool validity = false;
            try
            {
                int checkIfInt = 0, cId = 0;
                if (!string.IsNullOrEmpty(clientId) && int.TryParse(clientId, out checkIfInt) == true)
                {
                    cId = clientId.ConvertToInt32();
                }
                else if (!string.IsNullOrEmpty(clientId) && int.TryParse(clientId, out checkIfInt) == false)
                {
                    cId = GetNumericPartOfFullClientId(clientId);
                }
                else
                {
                    cId = 0;
                }
                if (cId > 0)
                {
                    cmd.Connection = Program.cnConn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT ClientId FROM ClientInfo WHERE ClientId = @clientId";
                    cmd.Parameters.AddWithValue("@clientId", cId);
                    dr = cmd.ExecuteReader();
                    validity = dr.HasRows;
                }


            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
            return validity;
        }

        internal static bool CheckButtonPermission(string formName, string buttonName)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CheckButtonPermission";
                cmd.Parameters.AddWithValue("@formName", formName);
                cmd.Parameters.AddWithValue("@buttonName", buttonName);
                cmd.Parameters.AddWithValue("@userId", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@applicationId", clsGlobalClass.applicationId);
                SqlParameter isAllowed = new SqlParameter("@isAllowed", SqlDbType.Bit);
                isAllowed.Value = false;
                isAllowed.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(isAllowed);
                cmd.ExecuteNonQuery();
                return isAllowed.Value.ToString().ConvertToBoolean();
            }
            finally { cmd.Dispose(); }

        }

        internal static DataTable CompanyInformation()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetCompanyInformation";
                cmd.Parameters.AddWithValue("@concernId", 1);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }


        internal static string GetEmployeeNameFromLogInId()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            string employeeName = string.Empty;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Employee WHERE EmpId = @empId";
                cmd.Parameters.AddWithValue("@empId", clsGlobalClass.userId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        employeeName = dr["EmployeeName"].ToString().Trim();
                    }
                }
                return employeeName;
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal static string GetLogInIdFromEmployeeName(string empName)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            string employeeId = string.Empty;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Employee WHERE EmployeeName = @empName";
                cmd.Parameters.AddWithValue("@empName", empName);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        employeeId = dr["EmpId"].ToString().Trim();
                    }
                }
                return employeeId;
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }


        internal static void SearchClient(TextBox txtBox)
        {
            UserInterface.Root.frmSearchClient sc = new UserInterface.Root.frmSearchClient();
            sc.ShowDialog();
            txtBox.Text = !String.IsNullOrEmpty(clsGlobalClass.clientId) ? clsGlobalClass.clientId.ToString() : string.Empty;
        }
        #endregion

        #region Reset Control
        protected static IEnumerable<Control> GetAllChildren(Control root)
        {
            return new Control[] { root }.Concat(root.Controls.OfType<Control>().SelectMany(item => GetAllChildren(item)));
        }

        internal static void ResetCheckBoxes(Control root, bool isChecked = false, params CheckBox[] except)
        {
            try
            {
                var source = GetAllChildren(root).OfType<CheckBox>().Where(ctrl => !except.Contains(ctrl));
                foreach (CheckBox chk in source) chk.Checked = isChecked;
            }
            catch (Exception) { throw; }
        }


        internal static void ResetTextBoxes(Control root, string resetWith = "", params TextBox[] except)
        {
            try
            {
                var source = GetAllChildren(root).OfType<TextBox>().Where(ctrl => !except.Contains(ctrl));
                foreach (TextBox textBox in source) textBox.Text = resetWith;
            }
            catch (Exception) { throw; }
        }

        internal static void AutoFormatListViews(
                            Control root,
                            bool? isAlternateColor = null,
                            Color? alternateColor = null,
                            bool checkBoxes = false,
                            bool showGroups = false, params ListView[] except)
        {

            var source = GetAllChildren(root).OfType<ListView>().Where(ctrl => !except.Contains(ctrl));

            foreach (ListView lView in source)
            {
                lView.AllowColumnReorder = false;
                //lView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lView.BackColor = lView.Parent.BackColor;
                lView.BorderStyle = BorderStyle.FixedSingle;
                lView.CheckBoxes = checkBoxes;
                lView.ForeColor = root.ForeColor;
                lView.FullRowSelect = true;
                lView.GridLines = true;
                lView.Groups.Clear();
                lView.ShowGroups = showGroups;
                lView.HideSelection = false;
                lView.Items.Clear();
                lView.MultiSelect = false;
                lView.View = View.Details;
            }
        }

        internal static bool isContainCancelledClient(string clientIds)
        {
            SqlCommand cmd = new SqlCommand();
            bool cancelledClient = false;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CheckClientStatus";
                cmd.Parameters.AddWithValue("@clientIds", clientIds);
                SqlParameter spCancelledClient = new SqlParameter("@containCancelledClient", SqlDbType.Bit);
                spCancelledClient.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(spCancelledClient);
                cmd.ExecuteNonQuery();
                cancelledClient = spCancelledClient.Value.ToString().ConvertToBoolean();
                return cancelledClient;
            }
            finally { cmd.Dispose(); }
        }

        internal static bool IsActiveClient(int clientId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            bool isActive = false;

            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT IsAllowed FROM defClientStatus WHERE StatusId = (SELECT StatusId FROM ClientInfo WHERE ClientId = @clientId)";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    isActive = dr["IsAllowed"].ToString() == "1" ? true : false;
                }
                return isActive;
            }
            finally { cmd.Dispose(); dr.Close(); }
        }

        internal static string GetLoanChequeInfo(int clientId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            string loanCheque = string.Empty;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT [LoanCheque] = dbo.fnGetRunningLoanChequeInfo(@clientId)";
                cmd.Parameters.AddWithValue("@clientId", clientId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows) { while (dr.Read()) { loanCheque = Convert.ToString(dr["LoanCheque"]); } }

                return loanCheque;
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
        }

        internal static void ResetDTPicker
            (Control root, bool isChecked = true, params DateTimePicker[] except)
        {
            try
            {
                var source = GetAllChildren(root).OfType<DateTimePicker>().Where(ctrl => !except.Contains(ctrl));
                foreach (DateTimePicker item in source)
                {
                    item.Value = DateTime.Now;
                    item.Checked = isChecked;
                }
            }
            catch (Exception) { throw; }
        }

        internal static void AutoFormatComboBoxes
                            (Control root, ComboBoxStyle? listStyle = null,
                             Color? backColor = null, FlatStyle? flatStyle = null, Color? foreColor = null, params ComboBox[] except)
        {
            try
            {
                var source = GetAllChildren(root).OfType<ComboBox>().Where(ctrl => !except.Contains(ctrl));
                foreach (ComboBox cb in source)
                {
                    cb.DataSource = null;
                    cb.Items.Clear();

                    cb.BackColor = backColor ?? root.BackColor;
                    cb.DropDownStyle = listStyle ?? ComboBoxStyle.DropDownList;
                    cb.FlatStyle = flatStyle ?? FlatStyle.System;
                    cb.ForeColor = foreColor ?? root.ForeColor;
                }
            }
            catch (Exception) { throw; }
        }

        internal static void ResetComboBox(Control root, params ComboBox[] except)
        {
            try
            {
                var source = GetAllChildren(root).OfType<ComboBox>().Where(ctrl => !except.Contains(ctrl));
                foreach (ComboBox cb in source)
                {
                    cb.DataSource = null;
                    cb.IntegralHeight = true;
                    cb.ResetText();
                    cb.Items.Clear();
                    cb.SelectedIndex = -1;
                    cb.DropDownHeight = 106; // default value
                    cb.IntegralHeight = false;
                }


            }
            catch { throw; }

        }
        internal static void ResetComboBox(ComboBox cb)
        {
            try
            {
                cb.DataSource = null;
                cb.IntegralHeight = true;
                cb.ResetText();
                cb.Items.Clear();
                cb.SelectedIndex = -1;
                cb.DropDownHeight = 106; // default value
                cb.IntegralHeight = false;
            }
            catch { throw; }

        }
        #endregion

        #region Populate/Format ComboBoxes

        internal static Dictionary<string, string> GetDisplayAndValueMemberForComboBox(CommandType cmdType, string sqlQuery, string displayMember,
                string valueMember, bool addAnEmptyLine = false)
        {
            Dictionary<string, string> retValue = new Dictionary<string, string>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = cmdType;
                cmd.CommandText = sqlQuery;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        retValue.Add(dr[valueMember].ToString(), dr[displayMember].ToString());
                    }
                }
                return retValue;
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Dispose(); if (dr != null) dr.Dispose(); }
        }




        internal static void PopulateComboboxWithDisplayAndValueMember
                    (CommandType cmdType, string sqlQuery,
                    string displayMember, string valueMember,
                    ComboBox comboBox, Boolean addAnEmptyRow = false,
                    string defaultValue = "")
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                ResetComboBox(comboBox);
                cmd.Connection = Program.cnConn;
                cmd.CommandType = cmdType;
                cmd.CommandText = sqlQuery;
                da.SelectCommand = cmd;
                da.Fill(ds);
                comboBox.DataSource = null;
                comboBox.Items.Clear();
                comboBox.DataSource = ds.Tables[0];
                if (addAnEmptyRow == true)
                {
                    DataRow emptyRow = ds.Tables[0].NewRow();
                    emptyRow[displayMember] = string.Empty;
                    if (valueMember != string.Empty) emptyRow[valueMember] = 0;
                    ds.Tables[0].Rows.Add(emptyRow);
                    ds.Tables[0].DefaultView.Sort = displayMember;
                }
                comboBox.DisplayMember = displayMember;
                if (valueMember != string.Empty) comboBox.ValueMember = valueMember;
                if (defaultValue != "" || defaultValue != string.Empty) comboBox.Text = defaultValue;
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }



        internal static void PopulateComboboxWithDisplayAndValueMember
                    (string sqlQuery,
                    string displayMember, string valueMember,
                    Boolean addAnEmptyRow, params ComboBox[] comboBox
                    )
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {

                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlQuery;
                da.SelectCommand = cmd;
                da.Fill(ds);
                foreach (ComboBox cmb in comboBox)
                {
                    ResetComboBox(cmb);
                    cmb.BindingContext = new BindingContext();
                    cmb.DataSource = null;
                    cmb.Items.Clear();
                    cmb.DataSource = ds.Tables[0];
                    if (addAnEmptyRow == true)
                    {
                        DataRow emptyRow = ds.Tables[0].NewRow();
                        emptyRow[displayMember] = string.Empty;
                        if (valueMember != string.Empty) emptyRow[valueMember] = 0;
                        ds.Tables[0].Rows.Add(emptyRow);
                        ds.Tables[0].DefaultView.Sort = displayMember;
                    }
                    cmb.DisplayMember = displayMember;
                    if (valueMember != string.Empty) cmb.ValueMember = valueMember;
                    SetComboBoxWidth(cmb);
                }
            }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        internal static void PopulateListOfDistricts(ComboBox cmb)
        {
            PopulateComboboxWithDisplayAndValueMember(
                CommandType.Text, "SELECT DistrictId, DistrictName FROM defDistrict ORDER BY DistrictName",
                "DistrictName", "DistrictId", cmb, true, "Dhaka");
        }

        internal static void PopulateListOfCountries(ComboBox cmb)
        {
            PopulateComboboxWithDisplayAndValueMember(
                CommandType.Text, "SELECT CountryId, CountryName FROM defCountryList ORDER BY CountryName",
                "CountryName", "CountryId", cmb, true, "Bangladesh");
        }


        #endregion

        #region Listview/GridView Controls

        internal static void PopulateListViewsFromSingleLineQuery
                            (string strSQLQuery
                            , ListView lView
                            , Label lblRecordCount = null
                            , bool hideFirstColumn = false
                            , ColumnHeaderAutoResizeStyle autoResizeBy = ColumnHeaderAutoResizeStyle.HeaderSize)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = Program.cnConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQLQuery;
            da.SelectCommand = cmd;
            da.Fill(dt);

            lView.BackColor = lView.Parent.BackColor;
            lView.Columns.Clear();
            lView.FullRowSelect = true;
            lView.GridLines = true;
            lView.HideSelection = false;
            lView.Items.Clear();
            lView.MultiSelect = false;
            lView.View = View.Details;
            foreach (DataColumn col in dt.Columns) { lView.Columns.Add(col.Caption.ToString()); }
            foreach (DataRow rows in dt.Rows)
            {
                ListViewItem item = new ListViewItem(rows[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++) { item.SubItems.Add(rows[i].ToString()); }
                lView.Items.Add(item);
            }
            lView.AutoResizeColumns(autoResizeBy);
            if (hideFirstColumn == true) { lView.Columns[0].Width = 0; }
            if (lblRecordCount != null) { lblRecordCount.Text = lView.Items.Count.ToString() + Resources.strRecordsFound; }

        }



        internal static void PopulateListViewFromDataTable
                                    (DataTable dataTable
                                    , ListView lView
                                    , Label lblRecordCount = null
                                    , Boolean hideFirstColumn = false
                                    , ToolStripStatusLabel stripLabel = null
                                    , ColumnHeaderAutoResizeStyle autoResizeBy = ColumnHeaderAutoResizeStyle.HeaderSize)
        {
            try
            {
                if (stripLabel != null) { stripLabel.Text = "Collecting Data....."; }
                lView.BackColor = lView.Parent.BackColor;
                lView.Columns.Clear();
                lView.FullRowSelect = true;
                lView.GridLines = true;
                lView.HideSelection = false;
                lView.Items.Clear();
                lView.MultiSelect = false;
                lView.View = View.Details;
                foreach (DataColumn col in dataTable.Columns) { lView.Columns.Add(col.Caption.ToString()); }
                foreach (DataRow rows in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(rows[0].ToString());
                    for (int i = 1; i < dataTable.Columns.Count; i++) { item.SubItems.Add(rows[i].ToString()); }
                    lView.Items.Add(item);
                    //if (decorateAlternateRows == true && (item.Index % 2) == 0) { item.BackColor = alternateColor ?? Color.WhiteSmoke; }
                }
                lView.AutoResizeColumns(autoResizeBy);
                if (hideFirstColumn == true) { lView.Columns[0].Width = 0; }
                if (lblRecordCount != null) { lblRecordCount.Text = lView.Items.Count.ToString() + Resources.strRecordsFound; }
                if (stripLabel != null) { stripLabel.Text = "Ready"; }
            }
            catch (Exception ex) { throw ex; }
        }


        internal static void AutoFormatListViewControl
                             (ListView lvControl, bool checkBox = false, bool multiSelect = false, View view = View.Details)
        {
            lvControl.BorderStyle = BorderStyle.FixedSingle;
            lvControl.CheckBoxes = checkBox;
            lvControl.FullRowSelect = true;
            lvControl.GridLines = true;
            lvControl.Items.Clear();
            lvControl.MultiSelect = multiSelect;
            lvControl.View = view;
        }

        #endregion

        #region SandBox

        public static int GetProjectIdFromProjectName(string projectName)
        {
            SqlCommand cmd = new SqlCommand();
            int projectId = 0;
            try
            {
                if (!string.IsNullOrEmpty(projectName) & !string.IsNullOrWhiteSpace(projectName))
                {
                    cmd.Connection = Program.cnConn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_GetProjectIdFromProjectName";
                    cmd.Parameters.AddWithValue("@projectName", projectName);
                    SqlParameter pId = new SqlParameter("@projectId", SqlDbType.Int);
                    pId.Direction = ParameterDirection.Output;
                    pId.Value = 0;
                    cmd.Parameters.Add(pId);
                    cmd.ExecuteNonQuery();
                    projectId = Convert.ToInt32(pId.Value);
                }
                else
                {
                    projectId = 0;
                }
                return projectId;
            }
            finally { cmd.Dispose(); }
        }

        public static string GetDefaultValue(string defaultKey)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetDefaultValue";
                cmd.Parameters.AddWithValue("@defaultKey", defaultKey);
                SqlParameter value = new SqlParameter("@defaultValue", SqlDbType.NVarChar, 200);
                value.Direction = ParameterDirection.Output;
                value.Value = string.Empty;
                cmd.Parameters.Add(value);
                cmd.ExecuteNonQuery();
                return Convert.ToString(value.Value);
            }
            finally { cmd.Dispose(); }
        }

        public static DateTime GetServerDate()
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetServerDateTime";
                SqlParameter dt = new SqlParameter("@serverDateTime", SqlDbType.DateTime);
                dt.Direction = ParameterDirection.Output;
                dt.Value = DBNull.Value;
                cmd.Parameters.Add(dt);
                cmd.ExecuteNonQuery();
                return Convert.ToDateTime(dt.Value);
            }
            finally { cmd.Dispose(); }

        }


        /// <summary>
        /// Show report to Default Reporting Interface
        /// </summary>
        /// <param name="reportDocumnent"></param>
        /// <param name="tssStatus"></param>
        /// <param name="includeCompanyBanner"></param>
        /// <param name="passPrintedBy">Leave this parameter false if there is no "@PrintedBy" formula available in Report </param>
        public static void ShowReport(
                            CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocumnent,
                            ToolStripStatusLabel tssStatus,
                            bool includeCompanyBanner = false,
                            bool passPrintedBy = false)
        {
            Reports.frmReportViewer frmReport = new Reports.frmReportViewer();
            if (includeCompanyBanner == true) reportDocumnent.Subreports[0].SetDataSource(clsCommonFunctions.CompanyInformation());
            if (passPrintedBy == true) reportDocumnent.DataDefinition.FormulaFields["PrintedBy"].Text = "'" + clsGlobalClass.userFullName + "'";
            frmReport.crptMasterReport.ReportSource = reportDocumnent;
            frmReport.crptMasterReport.Zoom(100);
            tssStatus.Text = Resources.strPreparingData;
            frmReport.crptMasterReport.Update();
            frmReport.Show();
            GC.Collect();
            tssStatus.Text = Resources.strReadyStatus;
        }


        public static void ChangeAndConvertToCurrency(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = !string.IsNullOrEmpty(((TextBox)sender).Text.ToString()) ? Spell.SpellAmount.comma(((TextBox)sender).Text.ToString().ConvertToDecimal()) : "0";
            ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
        }

        private static void SetComboBoxWidth(ComboBox cmb)
        {
            float length = 0, maxLength = 0;
            Graphics g = cmb.CreateGraphics();
            SizeF stringSize = new SizeF();
            for (int i = 0; i < cmb.Items.Count; i++)
            {
                stringSize = g.MeasureString(cmb.GetItemText(cmb.Items[i]), cmb.Font);
                length = !string.IsNullOrEmpty(cmb.GetItemText(cmb.Items[i])) ? stringSize.Width : 1;
                if (length > maxLength) { maxLength = length; }
                cmb.DropDownWidth = Convert.ToInt32(maxLength);
            }

        }

        public string GetLocalIP()
        {
            string _IP = null;

            // Resolves a host name or IP address to an IPHostEntry instance.
            // IPHostEntry - Provides a container class for Internet host address information. 
            System.Net.IPHostEntry _IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());

            // IPAddress class contains the address of a computer on an IP network. 
            foreach (System.Net.IPAddress _IPAddress in _IPHostEntry.AddressList)
            {
                // InterNetwork indicates that an IP version 4 address is expected 
                // when a Socket connects to an endpoint
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    _IP = _IPAddress.ToString();
                }
            }
            return _IP;
        }

        internal static void PopulateListOfProjects(ComboBox cmbProjectName, bool addAnEmptyLine = false)
        {
            DataAccessLayer.dalProjectInfo d = new DataAccessLayer.dalProjectInfo();
            cmbProjectName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbProjectName.AutoCompleteSource = AutoCompleteSource.ListItems;
            PopulateComboboxWithDisplayAndValueMember("SELECT ProjectId, ProjectName FROM ProjectInfo ORDER BY ProjectName", "ProjectName", "ProjectId", true, cmbProjectName);
        }

        internal static void PopulateListOfProjects(ComboBox cmbProjectName, clsGlobalClass.ProjectStatus projectStatus, bool addAnEmptyLine = false)
        {
            //cmbProjectName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cmbProjectName.AutoCompleteSource = AutoCompleteSource.ListItems;
            //DataAccessLayer.dalProjectInfo d = new DataAccessLayer.dalProjectInfo();
            //DataSet ds = new DataSet();
            //ds = d.PopulateProjectsCombo(projectStatus);
            //cmbProjectName.DataSource = ds;
            //if (addAnEmptyLine == true)
            //{
            //    DataRow dr = ds.Tables[0].NewRow();
            //    dr["ProjectId"] = 0;
            //    dr["ProjectName"] = "";
            //    ds.Tables[0].Rows.Add(dr);
            //    ds.Tables[0].DefaultView.Sort = "ProjectName";
            //}

            //cmbProjectName.DisplayMember = "ProjectName";
            //cmbProjectName.ValueMember = "ProjectId";
            //SetComboBoxWidth(cmbProjectName);
            DataAccessLayer.dalProjectInfo d = new DataAccessLayer.dalProjectInfo();
            cmbProjectName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbProjectName.AutoCompleteSource = AutoCompleteSource.ListItems;
            PopulateComboboxWithDisplayAndValueMember(d.ProjectLoadQuery(projectStatus), "ProjectName", "ProjectId", true, cmbProjectName);
        }

        internal static string GetFullClientId(string clientId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            string fullClientId = string.Empty;
            int checkIfInt = 0, cId = 0;
            try
            {
                if (!string.IsNullOrEmpty(clientId) && int.TryParse(clientId, out checkIfInt) == true)
                {
                    cId = Convert.ToInt32(clientId);
                }
                else if (!string.IsNullOrEmpty(clientId) && int.TryParse(clientId, out checkIfInt) == false)
                {
                    cId = GetNumericPartOfFullClientId(clientId);
                }
                else if (string.IsNullOrEmpty(clientId) == true)
                {
                    fullClientId = string.Empty;
                }
                if (cId > 0)
                {
                    cmd.Connection = Program.cnConn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT ISNULL(dbo.FullClientId(@clientId), '') AS ClientId";
                    cmd.Parameters.AddWithValue("@clientId", cId);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            fullClientId = dr["ClientId"].ToString();
                        }
                    }
                    else
                    {
                        throw new ApplicationException("Invalid Client Id. Please Check again.");
                    }
                }
            }
            finally { cmd.Dispose(); if (dr != null) dr.Close(); }
            return fullClientId;
        }


        internal static void SelectAllInTextBox(object textBox, EventArgs e)
        {
            (textBox as TextBox).SelectAll();
        }

        internal static void NumericTextBox(object txtBox, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') { e.Handled = true; }
            if (e.KeyChar == '.' && (txtBox as TextBox).Text.IndexOf('.') > -1) { e.Handled = true; }
        }

        internal void SetdtPickerValue(DateTimePicker dtPicker, DateTime dtDate)
        {
            if (dtDate < clsGlobalClass.considerAsNULLDate) { dtPicker.Value = dtDate; dtPicker.Checked = true; } else { dtPicker.Value = DateTime.Now; dtPicker.Checked = false; }
        }

        internal static void ConvertEnterToTab(Form formName, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { formName.SelectNextControl(formName.ActiveControl, true, true, true, true); e.Handled = true; e.SuppressKeyPress = true; }
        }

        internal static void ConvertEnterToTab(Form formName, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) { formName.SelectNextControl(formName.ActiveControl, true, true, true, true); e.Handled = false; }
        }

        internal static void LogError(Exception ex)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_LogErrorMessages";
                cmd.Parameters.AddWithValue("@appName", clsGlobalClass.applicationName);
                cmd.Parameters.AddWithValue("@message", ex.Message.ToString().Trim());
                cmd.Parameters.AddWithValue("@exceptionType", ex.GetType().Name.ToString().Trim());
                cmd.Parameters.AddWithValue("@stackTrace", ex.StackTrace.ToString().Trim());
                cmd.Parameters.AddWithValue("@source", ex.Source.ToString().Trim());
                cmd.Parameters.AddWithValue("@targetSites", ex.TargetSite.ToString().Trim());
                cmd.Parameters.AddWithValue("@userId", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstationIP", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();

            }
            finally { cmd.Dispose(); }
        }

        //internal static void LogError(Exception ex)
        //{
        //    if (!ex.GetType().IsAssignableFrom(typeof(ApplicationException)))
        //    {

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = Program.cnConn;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "sp_LogErrorMessages";
        //        cmd.Parameters.AddWithValue("@appName", clsGlobalClass.applicationName);
        //        cmd.Parameters.AddWithValue("@message", ex.Message.ToString());
        //        cmd.Parameters.AddWithValue("@exceptionType", ex.GetType().Name.ToString());
        //        cmd.Parameters.AddWithValue("@stackTrace", ex.StackTrace.ToString());
        //        cmd.Parameters.AddWithValue("@source", ex.Source.ToString());
        //        cmd.Parameters.AddWithValue("@targetSites", ex.TargetSite.ToString());
        //        cmd.Parameters.AddWithValue("@userId", clsGlobalClass.userId);
        //        cmd.Parameters.AddWithValue("@workstationIP", clsGlobalClass.workStationIP);
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show(Resources.strFailedMessage + ex.Message.ToString(), Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        cmd.Dispose();
        //    }
        //    else { MessageBox.Show(ex.Message.ToString(), Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        //}
        #endregion

        #region Date Functions
        //internal static DateTime ReturnIfValidDate(DateTime dateTime)
        //{
        //    return dateTime < clsGlobalClass.considerAsNULLDate ? DateTime.Now : dateTime;

        //}
        ///// <summary>
        ///// Return false when date is before 01/02/1900
        ///// </summary>
        ///// <param name="dateTime">Date to check</param>
        ///// <returns></returns>
        //internal static bool CheckIfValidDate(DateTime dateTime)
        //{
        //    return dateTime < clsGlobalClass.considerAsNULLDate ? false : true;
        //}


        #endregion

        #region Image Controls
        internal static void LoadImageToPictureBox(PictureBox picBox, double maxSizeOfImageInKB, Image alternateImage)
        {
            OpenFileDialog ofdImage = new OpenFileDialog();
            ofdImage.Filter = "Image Files|*.jpg";
            ofdImage.ShowDialog();
            try
            {
                if (!String.IsNullOrEmpty(ofdImage.FileName.ToString()))
                {
                    FileInfo imgFile = new FileInfo(ofdImage.FileName);
                    double imgSize = imgFile.Length / 1024;
                    if (imgSize > maxSizeOfImageInKB)
                    {
                        picBox.Image = alternateImage;
                        throw new Exception("Please select an image of less than " + maxSizeOfImageInKB.ToString() + " KB.");
                    }
                    else
                    {
                        picBox.Image = Image.FromFile(ofdImage.FileName);
                    }
                }
                else
                {
                    picBox.Image = alternateImage;
                }
            }
            catch (Exception err) { throw err; }
        }


        internal static Byte[] ImageToByte(System.Drawing.Image Img)
        {
            System.Drawing.ImageConverter d = new System.Drawing.ImageConverter();
            Byte[] bta;
            bta = (Byte[])(d.ConvertTo(Img, typeof(Byte[])));
            return bta;
        }

        internal static System.Drawing.Image ImageFromByte(object bta)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream((Byte[])(bta));
            return System.Drawing.Image.FromStream(ms);
        }



        #endregion

        #region Verify EMail Address
        internal static bool IsValidEmail(string strIn)
        {
            blnValidEmail = false;
            if (String.IsNullOrEmpty(strIn))
                return true;
            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            if (blnValidEmail)
                return false;
            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private static string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();
            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                blnValidEmail = true;
            }
            return match.Groups[1].Value + domainName;
        }
        #endregion


    }
}
