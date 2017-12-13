namespace RealEstateManagementSystem.UserInterface.Reports
{
    partial class frmSummarizedSalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSummarizedSalesReport));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSR_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSR_EndDate = new System.Windows.Forms.DateTimePicker();
            this.rbPictorialDepiction = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbSalesPosition_Details = new System.Windows.Forms.RadioButton();
            this.rbSalesPosition_ISO = new System.Windows.Forms.RadioButton();
            this.rbSummarizedSalesReport = new System.Windows.Forms.RadioButton();
            this.rbSummarizedSalesReport_ByYear = new System.Windows.Forms.RadioButton();
            this.rbTargetAchievement_ByYear = new System.Windows.Forms.RadioButton();
            this.rbSummaryOfSales_ByYear = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSalesYear = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDateBy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpCU_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpCU_StartDate = new System.Windows.Forms.DateTimePicker();
            this.rbDetailsOfCancelledUnits = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbProjectName = new System.Windows.Forms.ComboBox();
            this.rbCollectionOfProject = new System.Windows.Forms.RadioButton();
            this.rbSummarizedSalesStatus_ByProject = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&&";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date Range:";
            // 
            // dtpSR_StartDate
            // 
            this.dtpSR_StartDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpSR_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSR_StartDate.Location = new System.Drawing.Point(106, 27);
            this.dtpSR_StartDate.Name = "dtpSR_StartDate";
            this.dtpSR_StartDate.Size = new System.Drawing.Size(107, 20);
            this.dtpSR_StartDate.TabIndex = 1;
            // 
            // dtpSR_EndDate
            // 
            this.dtpSR_EndDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpSR_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSR_EndDate.Location = new System.Drawing.Point(238, 27);
            this.dtpSR_EndDate.Name = "dtpSR_EndDate";
            this.dtpSR_EndDate.Size = new System.Drawing.Size(107, 20);
            this.dtpSR_EndDate.TabIndex = 2;
            // 
            // rbPictorialDepiction
            // 
            this.rbPictorialDepiction.AutoSize = true;
            this.rbPictorialDepiction.Checked = true;
            this.rbPictorialDepiction.Location = new System.Drawing.Point(28, 52);
            this.rbPictorialDepiction.Name = "rbPictorialDepiction";
            this.rbPictorialDepiction.Size = new System.Drawing.Size(271, 17);
            this.rbPictorialDepiction.TabIndex = 3;
            this.rbPictorialDepiction.TabStop = true;
            this.rbPictorialDepiction.Text = "Pictorial Depiction of Sales && Collection";
            this.rbPictorialDepiction.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sales Position:";
            // 
            // rbSalesPosition_Details
            // 
            this.rbSalesPosition_Details.AutoSize = true;
            this.rbSalesPosition_Details.Location = new System.Drawing.Point(47, 87);
            this.rbSalesPosition_Details.Name = "rbSalesPosition_Details";
            this.rbSalesPosition_Details.Size = new System.Drawing.Size(67, 17);
            this.rbSalesPosition_Details.TabIndex = 3;
            this.rbSalesPosition_Details.Text = "Details";
            this.rbSalesPosition_Details.UseVisualStyleBackColor = true;
            // 
            // rbSalesPosition_ISO
            // 
            this.rbSalesPosition_ISO.AutoSize = true;
            this.rbSalesPosition_ISO.Location = new System.Drawing.Point(123, 87);
            this.rbSalesPosition_ISO.Name = "rbSalesPosition_ISO";
            this.rbSalesPosition_ISO.Size = new System.Drawing.Size(157, 17);
            this.rbSalesPosition_ISO.TabIndex = 3;
            this.rbSalesPosition_ISO.Text = "(QF-SAL-02) ISO Format";
            this.rbSalesPosition_ISO.UseVisualStyleBackColor = true;
            // 
            // rbSummarizedSalesReport
            // 
            this.rbSummarizedSalesReport.AutoSize = true;
            this.rbSummarizedSalesReport.Location = new System.Drawing.Point(28, 112);
            this.rbSummarizedSalesReport.Name = "rbSummarizedSalesReport";
            this.rbSummarizedSalesReport.Size = new System.Drawing.Size(235, 17);
            this.rbSummarizedSalesReport.TabIndex = 3;
            this.rbSummarizedSalesReport.Text = "(QF-SAL-07) Summarized Sales Report";
            this.rbSummarizedSalesReport.UseVisualStyleBackColor = true;
            // 
            // rbSummarizedSalesReport_ByYear
            // 
            this.rbSummarizedSalesReport_ByYear.AutoSize = true;
            this.rbSummarizedSalesReport_ByYear.Location = new System.Drawing.Point(28, 176);
            this.rbSummarizedSalesReport_ByYear.Name = "rbSummarizedSalesReport_ByYear";
            this.rbSummarizedSalesReport_ByYear.Size = new System.Drawing.Size(235, 17);
            this.rbSummarizedSalesReport_ByYear.TabIndex = 3;
            this.rbSummarizedSalesReport_ByYear.Text = "(QF-SAL-05) Summarized Sales Report";
            this.rbSummarizedSalesReport_ByYear.UseVisualStyleBackColor = true;
            // 
            // rbTargetAchievement_ByYear
            // 
            this.rbTargetAchievement_ByYear.AutoSize = true;
            this.rbTargetAchievement_ByYear.Location = new System.Drawing.Point(28, 199);
            this.rbTargetAchievement_ByYear.Name = "rbTargetAchievement_ByYear";
            this.rbTargetAchievement_ByYear.Size = new System.Drawing.Size(253, 17);
            this.rbTargetAchievement_ByYear.TabIndex = 3;
            this.rbTargetAchievement_ByYear.Text = "(QF-SAL-03) Sales Target && Achievement";
            this.rbTargetAchievement_ByYear.UseVisualStyleBackColor = true;
            // 
            // rbSummaryOfSales_ByYear
            // 
            this.rbSummaryOfSales_ByYear.AutoSize = true;
            this.rbSummaryOfSales_ByYear.Location = new System.Drawing.Point(28, 222);
            this.rbSummaryOfSales_ByYear.Name = "rbSummaryOfSales_ByYear";
            this.rbSummaryOfSales_ByYear.Size = new System.Drawing.Size(121, 17);
            this.rbSummaryOfSales_ByYear.TabIndex = 3;
            this.rbSummaryOfSales_ByYear.Text = "Summary of Sales";
            this.rbSummaryOfSales_ByYear.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Summarized Reports:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "for the Year of";
            // 
            // cmbSalesYear
            // 
            this.cmbSalesYear.FormattingEnabled = true;
            this.cmbSalesYear.Location = new System.Drawing.Point(289, 204);
            this.cmbSalesYear.Name = "cmbSalesYear";
            this.cmbSalesYear.Size = new System.Drawing.Size(87, 21);
            this.cmbSalesYear.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.GreenYellow;
            this.label6.Location = new System.Drawing.Point(15, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Information of Canceled Unit(s)";
            // 
            // cmbDateBy
            // 
            this.cmbDateBy.FormattingEnabled = true;
            this.cmbDateBy.Location = new System.Drawing.Point(47, 296);
            this.cmbDateBy.Name = "cmbDateBy";
            this.cmbDateBy.Size = new System.Drawing.Size(121, 21);
            this.cmbDateBy.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "between";
            // 
            // dtpCU_EndDate
            // 
            this.dtpCU_EndDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpCU_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCU_EndDate.Location = new System.Drawing.Point(238, 325);
            this.dtpCU_EndDate.Name = "dtpCU_EndDate";
            this.dtpCU_EndDate.Size = new System.Drawing.Size(107, 20);
            this.dtpCU_EndDate.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "&&";
            // 
            // dtpCU_StartDate
            // 
            this.dtpCU_StartDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpCU_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCU_StartDate.Location = new System.Drawing.Point(106, 325);
            this.dtpCU_StartDate.Name = "dtpCU_StartDate";
            this.dtpCU_StartDate.Size = new System.Drawing.Size(107, 20);
            this.dtpCU_StartDate.TabIndex = 1;
            // 
            // rbDetailsOfCancelledUnits
            // 
            this.rbDetailsOfCancelledUnits.AutoSize = true;
            this.rbDetailsOfCancelledUnits.Location = new System.Drawing.Point(28, 277);
            this.rbDetailsOfCancelledUnits.Name = "rbDetailsOfCancelledUnits";
            this.rbDetailsOfCancelledUnits.Size = new System.Drawing.Size(163, 17);
            this.rbDetailsOfCancelledUnits.TabIndex = 3;
            this.rbDetailsOfCancelledUnits.Text = "Details list of unit(s)";
            this.rbDetailsOfCancelledUnits.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.GreenYellow;
            this.label9.Location = new System.Drawing.Point(15, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Project Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Project Name:";
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Location = new System.Drawing.Point(117, 383);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(234, 21);
            this.cmbProjectName.TabIndex = 6;
            // 
            // rbCollectionOfProject
            // 
            this.rbCollectionOfProject.AutoSize = true;
            this.rbCollectionOfProject.Location = new System.Drawing.Point(28, 410);
            this.rbCollectionOfProject.Name = "rbCollectionOfProject";
            this.rbCollectionOfProject.Size = new System.Drawing.Size(151, 17);
            this.rbCollectionOfProject.TabIndex = 3;
            this.rbCollectionOfProject.Text = "Collection of Project";
            this.rbCollectionOfProject.UseVisualStyleBackColor = true;
            // 
            // rbSummarizedSalesStatus_ByProject
            // 
            this.rbSummarizedSalesStatus_ByProject.AutoSize = true;
            this.rbSummarizedSalesStatus_ByProject.Location = new System.Drawing.Point(28, 433);
            this.rbSummarizedSalesStatus_ByProject.Name = "rbSummarizedSalesStatus_ByProject";
            this.rbSummarizedSalesStatus_ByProject.Size = new System.Drawing.Size(235, 17);
            this.rbSummarizedSalesStatus_ByProject.TabIndex = 3;
            this.rbSummarizedSalesStatus_ByProject.Text = "(QF-SAL-06) Summarized Sales Status";
            this.rbSummarizedSalesStatus_ByProject.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.GreenYellow;
            this.label11.Location = new System.Drawing.Point(15, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Sales Report";
            // 
            // btnShowReport
            // 
            this.btnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowReport.Image = global::RealEstateManagementSystem.Properties.Resources.rating;
            this.btnShowReport.Location = new System.Drawing.Point(285, 447);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(98, 58);
            this.btnShowReport.TabIndex = 7;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(401, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(386, 17);
            this.tssStatus.Spring = true;
            this.tssStatus.Text = "Ready";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSummarizedSalesReport
            // 
            this.AcceptButton = this.btnShowReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(401, 548);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.cmbProjectName);
            this.Controls.Add(this.cmbDateBy);
            this.Controls.Add(this.cmbSalesYear);
            this.Controls.Add(this.rbCollectionOfProject);
            this.Controls.Add(this.rbSummarizedSalesStatus_ByProject);
            this.Controls.Add(this.rbDetailsOfCancelledUnits);
            this.Controls.Add(this.rbSummaryOfSales_ByYear);
            this.Controls.Add(this.rbTargetAchievement_ByYear);
            this.Controls.Add(this.rbSummarizedSalesReport_ByYear);
            this.Controls.Add(this.rbSummarizedSalesReport);
            this.Controls.Add(this.rbSalesPosition_ISO);
            this.Controls.Add(this.dtpCU_StartDate);
            this.Controls.Add(this.dtpSR_StartDate);
            this.Controls.Add(this.rbSalesPosition_Details);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbPictorialDepiction);
            this.Controls.Add(this.dtpCU_EndDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSR_EndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightCyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSummarizedSalesReport";
            this.Text = "Summarized Sales Report";
            this.Load += new System.EventHandler(this.frmSummarizedSalesReport_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSR_StartDate;
        private System.Windows.Forms.DateTimePicker dtpSR_EndDate;
        private System.Windows.Forms.RadioButton rbPictorialDepiction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbSalesPosition_Details;
        private System.Windows.Forms.RadioButton rbSalesPosition_ISO;
        private System.Windows.Forms.RadioButton rbSummarizedSalesReport;
        private System.Windows.Forms.RadioButton rbSummarizedSalesReport_ByYear;
        private System.Windows.Forms.RadioButton rbTargetAchievement_ByYear;
        private System.Windows.Forms.RadioButton rbSummaryOfSales_ByYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSalesYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDateBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpCU_EndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpCU_StartDate;
        private System.Windows.Forms.RadioButton rbDetailsOfCancelledUnits;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbProjectName;
        private System.Windows.Forms.RadioButton rbCollectionOfProject;
        private System.Windows.Forms.RadioButton rbSummarizedSalesStatus_ByProject;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
    }
}