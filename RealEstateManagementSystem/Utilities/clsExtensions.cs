using RealEstateManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateManagementSystem.Utilities
{
    public static class clsExtensions
    {

        #region [Batch Control Processing]
        //this.Controls.ClearControls();
        //this.Controls.ClearControls<TextBox>();
        private static Dictionary<Type, Action<Control>> controldefaults = new Dictionary<Type, Action<Control>>() {
            {typeof(TextBox), c => ((TextBox)c).Clear()},
            {typeof(CheckBox), c => ((CheckBox)c).Checked = false},
            {typeof(ListBox), c => ((ListBox)c).Items.Clear()},
            {typeof(RadioButton), c => ((RadioButton)c).Checked = false},
            {typeof(GroupBox), c => ((GroupBox)c).Controls.ClearControls()},
            {typeof(Panel), c => ((Panel)c).Controls.ClearControls()}
            };

        private static void FindAndInvoke(Type type, Control control)
        {
            if (controldefaults.ContainsKey(type))
            {
                controldefaults[type].Invoke(control);
            }
        }

        public static void ClearControls(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                FindAndInvoke(control.GetType(), control);
            }
        }

        public static void ClearControls<T>(this Control.ControlCollection controls) where T : class
        {
            if (!controldefaults.ContainsKey(typeof(T))) return;

            foreach (Control control in controls)
            {
                if (control.GetType() == typeof(T))
                {
                    FindAndInvoke(typeof(T), control);
                }
            }
        }
        #endregion [Batch Control Processing]

        #region [Handling NULL values from DB]

        public static bool HandleNULLBoolean(this SqlDataReader dr, string columnName)
        {
            return !DBNull.Value.Equals(dr[columnName]) ? Convert.ToBoolean(dr[columnName]) : false;
        }

        public static int HandleNULLInteger(this SqlDataReader dr, string columnName)
        {
            return !DBNull.Value.Equals(dr[columnName]) ? Convert.ToInt32(dr[columnName]) : 0;
        }

        public static double HandleNULLFloat(this SqlDataReader dr, string columnName)
        {
            return !DBNull.Value.Equals(dr[columnName]) ? Convert.ToDouble(dr[columnName]) : 0;
        }

        public static decimal HandleNULLDecimal(this SqlDataReader dr, string columnName)
        {
            return !DBNull.Value.Equals(dr[columnName]) ? Convert.ToDecimal(dr[columnName]) : 0;
        }

        public static string HandleNULLString(this SqlDataReader dr, string columnName)
        {
            return !DBNull.Value.Equals(dr[columnName]) ? Convert.ToString(dr[columnName]) : string.Empty;
        }

        public static DateTime HandleNULLDateTime(this SqlDataReader dr, string columnName)
        {
            return !DBNull.Value.Equals(dr[columnName]) ? Convert.ToDateTime(dr[columnName]) : clsGlobalClass.considerAsNULLDate;
        }

        public static byte HandleNULLByte(this SqlDataReader dr, string columnName)
        {
            return !DBNull.Value.Equals(dr[columnName]) ? Convert.ToByte(dr[columnName]) : (byte)0;
        }

        public static bool returnFalseIfNullDate(this DateTime date)
        {
            int i = DateTime.Compare(date, clsGlobalClass.considerAsNULLDate);
            return DateTime.Compare(date, clsGlobalClass.considerAsNULLDate) == 0 ? false : true;
        }

        #endregion

        #region [Substring shortcuts]
        /// <summary>
        /// Get string between [a] and [b]
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>string</returns>
        public static string Between(this string value, string a, string b)
        {
            int posA = value.IndexOf(a);
            int posB = value.LastIndexOf(b);
            if (posA == -1)
            {
                return "";
            }
            if (posB == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= posB)
            {
                return "";
            }
            return value.Substring(adjustedPosA, posB - adjustedPosA);
        }

        /// <summary>
        /// Get string value after [first] a.
        /// </summary>
        /// <param name="a"></param>
        /// <returns>string</returns>
        public static string Before(this string value, string a)
        {
            int posA = value.IndexOf(a);
            if (posA == -1)
            {
                return "";
            }
            return value.Substring(0, posA);
        }

        /// <summary>
        /// Get string value after [last] a.
        /// </summary>
        /// <param name="a"></param>
        /// <returns>string</returns>
        public static string After(this string value, string a)
        {
            int posA = value.LastIndexOf(a);
            if (posA == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= value.Length)
            {
                return "";
            }
            return value.Substring(adjustedPosA);
        }
        #endregion

        #region [Type Conversions]
        public static bool IsInteger(this string String)
        {
            int i = 0;
            return int.TryParse(String, out i);
        }

        public static string RemoveCommas(this string String)
        {
            return String.Replace(",", "");
        }

        public static string RemoveBrackets(this string String)
        {
            return String.Replace("(", "").Replace(")", ""); ;
        }

        public static bool ConvertToBoolean(this string str)
        {
            return str != "0" && str.ToUpper() != "FALSE";
        }

        public static int ConvertToInt32(this string str)
        {
            int i = 0;
            return int.TryParse(str.RemoveCommas(), out i) == true ? Convert.ToInt32(str.RemoveCommas()) : 0;
        }

        public static DateTime ConvertToDateTime(this string str)
        {
            DateTime dt = DateTime.Now;
            return DateTime.TryParse(str, out dt) == true ? Convert.ToDateTime(str.ToString()) : DateTime.Now;

        }

        public static decimal ConvertToDecimal(this string str)
        {
            decimal d = 0;
            return decimal.TryParse(str.RemoveCommas(), out d) == true ? Convert.ToDecimal(str.RemoveCommas()) : 0;
        }

        public static int ConverBooleanToSmallInt(this bool bln)
        {
            return bln == true ? 1 : 0;
        }

        public static string ReplaceEmptyStringWithNA(this string str)
        {
            return string.IsNullOrEmpty(str) ? "N/A" : str;
        }
        #endregion

        #region [Decimal Functions]
        /// <summary>
        /// Format Decimal number as Comma-Seperated string format (xx,xx,xxx)
        /// </summary>
        /// <param name="amount">Value</param>
        /// <param name="addCurrencyMark">Add Tk. in front and /- in end</param>
        /// <param name="useBracketForNegative"></param>
        /// <param name="replaceZeroWithDash"></param>
        /// <returns></returns>
        public static string FormatAsMoney(this decimal amount, bool addCurrencyMark = false, bool useBracketForNegative = false, bool replaceZeroWithDash = false)
        {
            if (replaceZeroWithDash == true && amount == 0)
            {
                return "-";
            }

            if (useBracketForNegative == true)
            {
                return amount < 0 ?
                    addCurrencyMark == true ? "(Tk." + Spell.SpellAmount.comma(amount * -1) + "/-)" : "(" + Spell.SpellAmount.comma(amount * -1) + ")" :
                    addCurrencyMark == true ? "Tk. " + Spell.SpellAmount.comma(amount) + "/-" : Spell.SpellAmount.comma(amount);
            }

            return amount < 0 ?
                addCurrencyMark == true ? "Tk. -" + Spell.SpellAmount.comma(amount * -1) + "/-" : "-" + Spell.SpellAmount.comma(amount * -1) + "" :
                addCurrencyMark == true ? "Tk. " + Spell.SpellAmount.comma(amount) + "/-" : Spell.SpellAmount.comma(amount);
        }

        public static string AmountInWords(this decimal amount)
        {
            return amount < 0 ? Spell.SpellAmount.InWrods(amount * -1) + " (Refund)" : Spell.SpellAmount.InWrods(amount);
        }
        #endregion

        #region [Date Functions]
        public static string ShowAsStandardDateFormat(this string str, bool showWithTime = false)
        {
            DateTime dt = DateTime.Now;
            string strFormat = showWithTime == true ? "dd-MMM-yyyy hh:mm:ss tt" : "dd-MMM-yyyy";
            return DateTime.TryParse(str, out dt) == true ? Convert.ToDateTime(str.ToString()).ToString(strFormat) : str;
        }

        /// <summary>
        /// Return Current date if supplied date is NULL or less than '1900-01-01'
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime ManageInvalidDate(this DateTime date)
        {
            DateTime dt = DateTime.Now;
            return DateTime.TryParse(date.ToString(), out dt) == true ? DateTime.Compare(date, clsGlobalClass.considerAsNULLDate) < 0 ? DateTime.Now : date : date;
        }


        public static bool IsBeforeStartOfCurrentMonth(this DateTime date)
        {
            DateTime now = DateTime.Now;
            DateTime startOfCurrentMonth = new DateTime(now.Year, now.Month, 1);
            return date < startOfCurrentMonth;
        }


        public static DateTime ProcessNullDate(this DateTime date)
        {
            return !DBNull.Value.Equals(date) ? date : clsGlobalClass.defaultDate;
        }

        /// <summary>
        /// Return false if supplied date is NULL or less than '1900-01-01'
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool IsValidDate(this DateTime date)
        {
            DateTime dt = DateTime.Now;
            return DateTime.TryParse(date.ToString(), out dt) != true || DateTime.Compare(date, clsGlobalClass.considerAsNULLDate) >= 0;
        }




        public static string MonthName(this int monthNumber, bool fullMonth = false, bool allCaps = false)
        {
            string monthName;
            switch (monthNumber)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    monthName = "Invalid";
                    break;
            }
            monthName = fullMonth ? monthName.Substring(0, 3) : monthName;
            return allCaps == true ? monthName.ToUpper() : monthName;
        }
        #endregion

        #region [Exception Handler]
        public static Exception Log(this Exception ex)
        {
            File.AppendAllText("CaughtExceptions" + DateTime.Now.ToString("yyyy-MM-dd") + ".log", DateTime.Now.ToString("HH:mm:ss") + ": " + ex.Message + "\n" + ex.ToString() + "\n");
            return ex;
        }


        public static Exception ProcessException(this Exception ex, ToolStripStatusLabel tssStatus = null)
        {
            string errMsgInitial = string.Empty;
            int errorId = 0;
            if (!ex.GetType().IsAssignableFrom(typeof(ApplicationException)))
            {
                errorId = clsCommonFunctions.LogError(ex);
                errMsgInitial = !ex.GetType().IsAssignableFrom(typeof(SqlException))
                                ? Resources.strSystemErrorMessage
                                : errMsgInitial = Resources.strFailedMessage;
            }
            else { errMsgInitial = Resources.strFailedMessage; }
            MessageBox.Show(errMsgInitial + ex.Message.ToString() + (errorId > 0 ? " [ErrorId: " + errorId.ToString() + "]" : ""), Resources.strFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (tssStatus != null) { tssStatus.Text = Resources.strReadyStatus; }
            return ex;
        }
        #endregion
    }
}
