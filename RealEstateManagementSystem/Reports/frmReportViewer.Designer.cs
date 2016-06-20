namespace RealEstateManagementSystem.Reports
{
    partial class frmReportViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewer));
            this.crptMasterReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crptMasterReport
            // 
            this.crptMasterReport.ActiveViewIndex = -1;
            this.crptMasterReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptMasterReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptMasterReport.DisplayBackgroundEdge = false;
            this.crptMasterReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptMasterReport.EnableDrillDown = false;
            this.crptMasterReport.Location = new System.Drawing.Point(0, 0);
            this.crptMasterReport.Name = "crptMasterReport";
            this.crptMasterReport.ShowCopyButton = false;
            this.crptMasterReport.ShowGroupTreeButton = false;
            this.crptMasterReport.ShowLogo = false;
            this.crptMasterReport.ShowParameterPanelButton = false;
            this.crptMasterReport.Size = new System.Drawing.Size(484, 377);
            this.crptMasterReport.TabIndex = 0;
            this.crptMasterReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 377);
            this.Controls.Add(this.crptMasterReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Report Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crptMasterReport;
    }
}