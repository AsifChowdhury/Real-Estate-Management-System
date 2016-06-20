using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateManagementSystem.Utilities
{
    class clsCommonFunctions
    {
        #region Common Use
        protected static IEnumerable<Control> GetAllChildren(Control root)
        {
            var stack = new Stack<Control>();
            stack.Push(root);
            while (stack.Any())
            {
                var next = stack.Pop();
                foreach (Control child in next.Controls)
                    stack.Push(child);
                yield return next;
            }
        }


        public static DataTable CompanyInformation()
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
            catch (Exception ex) { throw ex; }
            finally { cmd.Dispose(); da.Dispose(); dt.Dispose(); }
        }

        #endregion

        #region Reset Control

        public static void ResetCheckBoxes(Control root, bool isChecked = false)
        {
            try
            {
                foreach (CheckBox chk in GetAllChildren(root).OfType<CheckBox>())
                {
                    chk.Checked = isChecked;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public static void ResetNumericUpDown(Control root, decimal defaultValue = 0)
        {
            try
            {
                foreach (NumericUpDown nud in GetAllChildren(root).OfType<NumericUpDown>())
                {
                    nud.Value = defaultValue;
                }
            }
            catch (Exception ex) { throw ex; }
        }


        public static void ResetTextBoxes(Control root, string resetWith = "")
        {
            try
            {
                foreach (TextBox txt in GetAllChildren(root).OfType<TextBox>())
                {

                    txt.Text = resetWith == "" ? string.Empty : resetWith;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public static void AutoFormatListViews(
                            Control root,
                            bool? isAlternateColor = null,
                            Color? alternateColor = null,
                            bool checkBoxes = false)
        {

            try
            {
                foreach (var lView in GetAllChildren(root).OfType<ListView>())
                {
                    lView.AllowColumnReorder = false;
                    lView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lView.BackColor = lView.Parent.BackColor;
                    lView.BorderStyle = BorderStyle.FixedSingle;
                    lView.CheckBoxes = checkBoxes;
                    lView.ForeColor = root.ForeColor;
                    lView.FullRowSelect = true;
                    lView.GridLines = true;
                    lView.HideSelection = false;
                    lView.Items.Clear();
                    lView.MultiSelect = false;
                    lView.View = View.Details;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public static void ResetAllDateTimePicker
            (Control root, bool isChecked = true)
        {
            try
            {
                foreach (DateTimePicker item in GetAllChildren(root).OfType<DateTimePicker>())
                {
                    item.Checked = isChecked;
                    item.Value = DateTime.Now;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public static void AutoFormatComboBoxes
        (Control root, ComboBoxStyle? listStyle = null,
        Color? backColor = null, FlatStyle? flatStyle = null, Color? foreColor = null)
        {
            try
            {
                foreach (var cb in GetAllChildren(root).OfType<ComboBox>())
                {
                    cb.DataSource = null;
                    cb.Items.Clear();

                    cb.BackColor = backColor ?? root.BackColor;
                    cb.DropDownStyle = listStyle ?? ComboBoxStyle.DropDownList;
                    cb.FlatStyle = flatStyle ?? FlatStyle.Flat;
                    cb.ForeColor = foreColor ?? root.ForeColor;
                }
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Populate/Format ComboBoxes

        public static Dictionary<string, string> GetDisplayAndValueMemberForComboBox(CommandType cmdType, string sqlQuery, string displayMember,
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
            finally { cmd.Dispose(); dr.Dispose(); }
        }

        public static void PopulateComboboxWithDisplayAndValueMember
                    (CommandType cmdType, string sqlQuery,
                    string displayMember, string valueMember,
                    ComboBox comboBox, Boolean addAnEmptyRow = false)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
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
                }
                ds.Tables[0].DefaultView.Sort = displayMember;
                comboBox.DisplayMember = displayMember;
                if (valueMember != string.Empty) comboBox.ValueMember = valueMember;
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Dispose(); da.Dispose(); ds.Dispose(); }
        }

        public static void PopulateListOfDistricts(ComboBox cmb)
        {
            PopulateComboboxWithDisplayAndValueMember(
                CommandType.Text, "SELECT DistrictId, DistrictName FROM defDistrict ORDER BY DistrictName",
                "DistrictName", "DistrictId", cmb, true);
        }

        #endregion

        #region Listview/GridView Controls
        public static void PopulateListViewFromDataTable
                                    (DataTable dataTable,
                                    ListView lView,
                                    Label lblRecordCount = null,
                                    Boolean hideFirstColumn = false,
                                    ToolStripStatusLabel stripLabel = null)
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
                lView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                if (hideFirstColumn == true) { lView.Columns[0].Width = 0; }
                if (lblRecordCount != null) { lblRecordCount.Text = lView.Items.Count.ToString() + Resources.strRecordsFound; }
                if (stripLabel != null) { stripLabel.Text = "Ready"; }
            }
            catch (Exception ex) { throw ex; }
        }





        #endregion

        #region SandBox

        public static void SelectAllInTextBox(object textBox, EventArgs e)
        {
            (textBox as TextBox).SelectAll();
        }

        public static void NumericTextBox(object txtBox, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') { e.Handled = true; }
            if (e.KeyChar == '.' && (txtBox as TextBox).Text.IndexOf('.') > -1) { e.Handled = true; }
        }

        public void SetdtPickerValue(DateTimePicker dtPicker, DateTime dtDate)
        {
            if (dtDate < clsGlobalClass.calculateAsNULLDate) { dtPicker.Value = dtDate; dtPicker.Checked = true; } else { dtPicker.Value = DateTime.Now; dtPicker.Checked = false; }
        }

        public static void ConvertEnterToTab(Form formName, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { formName.SelectNextControl(formName.ActiveControl, true, true, true, true); e.Handled = true; e.SuppressKeyPress = true; }
        }

        public static void ConvertEnterToTab(Form formName, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) { formName.SelectNextControl(formName.ActiveControl, true, true, true, true); e.Handled = false; }
        }

        public static void LogError(Exception ex)
        {
            if (!ex.GetType().IsAssignableFrom(typeof(ApplicationException)))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.cnConn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_LogErrorMessages";
                cmd.Parameters.AddWithValue("@appName", clsGlobalClass.applicationName);
                cmd.Parameters.AddWithValue("@message", ex.Message.ToString());
                cmd.Parameters.AddWithValue("@exceptionType", ex.GetType().Name.ToString());
                cmd.Parameters.AddWithValue("@stackTrace", ex.StackTrace.ToString());
                cmd.Parameters.AddWithValue("@source", ex.Source.ToString());
                cmd.Parameters.AddWithValue("@targetSites", ex.TargetSite.ToString());
                cmd.Parameters.AddWithValue("@userId", clsGlobalClass.userId);
                cmd.Parameters.AddWithValue("@workstationIP", clsGlobalClass.workStationIP);
                cmd.ExecuteNonQuery();
                MessageBox.Show(Resources.strFailedMessage + ex.Message.ToString(), Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(ex.Message.ToString(), Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Date Functions
        internal static DateTime ReturnIfValidDate(DateTime dateTime)
        {
            if (dateTime < clsGlobalClass.calculateAsNULLDate)
            {
                return DateTime.Now;
            }
            else
            {
                return dateTime;
            }

        }

        internal static bool CheckIfValidDate(DateTime dateTime)
        {
            if (dateTime < clsGlobalClass.calculateAsNULLDate)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        #endregion

        #region Image to Byte & Byte to Image
        public static Byte[] ImageToByte(System.Drawing.Image Img)
        {

            System.Drawing.ImageConverter d = new System.Drawing.ImageConverter();
            Byte[] bta;
            bta = (Byte[])(d.ConvertTo(Img, typeof(Byte[])));
            return bta;
        }

        public static System.Drawing.Image ImageFromByte(object bta)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream((Byte[])(bta));
            return System.Drawing.Image.FromStream(ms);
        }
        #endregion
    }
}
