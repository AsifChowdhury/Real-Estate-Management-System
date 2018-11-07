using RealEstateManagementSystem.BusinessLogicLayer;
using RealEstateManagementSystem.Reports;
using RealEstateManagementSystem.Utilities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RealEstateManagementSystem.UserInterface.Reports
{
    public partial class frmSaleSummaryByRep : Form
    {
        public frmSaleSummaryByRep()
        {
            InitializeComponent();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            try
            {
                bllSummarizedSalesReport b = new bllSummarizedSalesReport();
                DataTable dt = b.GetSalesReportByRep(dtpStartDate.Value, dtpEndDate.Value, false, string.Empty);
                lvSummaryList.Items.Clear();
                decimal active = 0, faceValue_Active = 0, rebate_Active = 0, sellValue_Active = 0, collection = 0, totalDue = 0
                        , currentDue = 0, cancelled = 0, faceValue_cancelled = 0, rebate_Cancelled = 0, sellValue_Cancelled = 0;
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow drItem in dt.Rows)
                    {
                        ListViewItem lvItems = new ListViewItem(Convert.ToString(drItem["Name"]));
                        lvItems.SubItems.Add(Convert.ToString(drItem["Active"]));
                        active = active + Convert.ToDecimal(drItem["Active"]);
                        lvItems.SubItems.Add(Convert.ToDecimal(drItem["FaceValue_Active"]).FormatAsMoney());
                        faceValue_Active = faceValue_Active + Convert.ToDecimal(drItem["FaceValue_Active"]);
                        lvItems.SubItems.Add(Convert.ToDecimal(drItem["Rebate_Active"]).FormatAsMoney());
                        rebate_Active = rebate_Active + Convert.ToDecimal(drItem["Rebate_Active"]);
                        lvItems.SubItems.Add(Convert.ToDecimal(drItem["SellValue_Active"]).FormatAsMoney());
                        sellValue_Active = sellValue_Active + Convert.ToDecimal(drItem["SellValue_Active"]);
                        lvItems.SubItems.Add(Convert.ToDecimal(drItem["Collection"]).FormatAsMoney());
                        collection = collection + Convert.ToDecimal(drItem["Collection"]);
                        lvItems.SubItems.Add(Convert.ToDecimal(Convert.ToDecimal(drItem["SellValue_Active"]) - Convert.ToDecimal(drItem["Collection"])).FormatAsMoney());
                        totalDue = totalDue + (Convert.ToDecimal(Convert.ToDecimal(drItem["SellValue_Active"]) - Convert.ToDecimal(drItem["Collection"])));
                        lvItems.SubItems.Add(Convert.ToDecimal(drItem["CurrentDue"]).FormatAsMoney());
                        currentDue = currentDue + Convert.ToDecimal(drItem["CurrentDue"]);
                        lvItems.SubItems.Add(Convert.ToDecimal(drItem["Cancelled"]).FormatAsMoney());
                        cancelled = cancelled + Convert.ToDecimal(drItem["Cancelled"]);
                        lvItems.SubItems.Add(Convert.ToDecimal(drItem["FaceValue_Cancelled"]).FormatAsMoney());
                        faceValue_cancelled = faceValue_cancelled + Convert.ToDecimal(drItem["FaceValue_Cancelled"]);
                        lvItems.SubItems.Add(Convert.ToDecimal(drItem["Rebate_Cancelled"]).FormatAsMoney());
                        rebate_Cancelled = rebate_Cancelled + Convert.ToDecimal(drItem["Rebate_Cancelled"]);
                        lvItems.SubItems.Add(Convert.ToDecimal(drItem["SellValue_Cancelled"]).FormatAsMoney());
                        sellValue_Cancelled = sellValue_Cancelled + Convert.ToDecimal(drItem["SellValue_Cancelled"]);
                        lvItems.SubItems.Add(Convert.ToString(drItem["EmpId"]));
                        lvSummaryList.Items.Add(lvItems);
                    }
                    ListViewItem lvBlankLine = new ListViewItem("");
                    lvBlankLine.SubItems.Add("=");
                    lvBlankLine.SubItems.Add("=");
                    lvBlankLine.SubItems.Add("=");
                    lvBlankLine.SubItems.Add("=");
                    lvBlankLine.SubItems.Add("=");
                    lvBlankLine.SubItems.Add("=");
                    lvBlankLine.SubItems.Add("=");
                    lvBlankLine.SubItems.Add("=");
                    lvBlankLine.SubItems.Add("=");
                    lvBlankLine.SubItems.Add("=");
                    lvBlankLine.SubItems.Add("=");
                    lvBlankLine.SubItems.Add("");
                    lvBlankLine.ForeColor = Color.Maroon;
                    lvSummaryList.Items.Add(lvBlankLine);

                    ListViewItem lvTotal = new ListViewItem("Total:");
                    lvTotal.SubItems.Add(active.FormatAsMoney());
                    lvTotal.SubItems.Add(faceValue_Active.FormatAsMoney());
                    lvTotal.SubItems.Add(rebate_Active.FormatAsMoney());
                    lvTotal.SubItems.Add(sellValue_Active.FormatAsMoney());
                    lvTotal.SubItems.Add(collection.FormatAsMoney());
                    lvTotal.SubItems.Add(totalDue.FormatAsMoney());
                    lvTotal.SubItems.Add(currentDue.FormatAsMoney());
                    lvTotal.SubItems.Add(cancelled.FormatAsMoney());
                    lvTotal.SubItems.Add(faceValue_cancelled.FormatAsMoney());
                    lvTotal.SubItems.Add(rebate_Cancelled.FormatAsMoney());
                    lvTotal.SubItems.Add(sellValue_Cancelled.FormatAsMoney());
                    lvBlankLine.SubItems.Add("");
                    lvTotal.ForeColor = Color.Blue;
                    lvSummaryList.Items.Add(lvTotal);
                }
            }
            catch (Exception ex) { ex.ProcessException(); }
        }

        private void frmSaleSummaryByRep_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now.AddYears(-1);
        }

        private void lvSummaryList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvSummaryList.Items.Count > 0 && lvSummaryList.SelectedItems.Count > 0)
            {
                clsReports.SaleDataByRep(dtpStartDate.Value, dtpEndDate.Value, true, lvSummaryList.SelectedItems[0].SubItems[12].Text, tssStatus);
            }
        }

        private void btnPrintSummary_Click(object sender, EventArgs e)
        {
            clsReports.SaleDataByRep(dtpStartDate.Value, dtpEndDate.Value, false, "", tssStatus);
        }
    }
}
