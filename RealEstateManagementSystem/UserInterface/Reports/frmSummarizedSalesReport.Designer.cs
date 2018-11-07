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
            this.rbAnnualSalesPosition = new System.Windows.Forms.RadioButton();
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
            this.rbCanceledClientList = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rbSummarizedSalesStatus_ByProject = new System.Windows.Forms.RadioButton();
            this.rbCollectionOfProject = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.lvProjectStatus = new System.Windows.Forms.ListView();
            this.label13 = new System.Windows.Forms.Label();
            this.lvProjects = new System.Windows.Forms.ListView();
            this.lblProjectCount = new System.Windows.Forms.Label();
            this.rbBlockedUnits = new System.Windows.Forms.RadioButton();
            this.rbSalesSummaryByRep = new System.Windows.Forms.RadioButton();
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
            // rbAnnualSalesPosition
            // 
            this.rbAnnualSalesPosition.AutoSize = true;
            this.rbAnnualSalesPosition.Location = new System.Drawing.Point(28, 159);
            this.rbAnnualSalesPosition.Name = "rbAnnualSalesPosition";
            this.rbAnnualSalesPosition.Size = new System.Drawing.Size(223, 17);
            this.rbAnnualSalesPosition.TabIndex = 3;
            this.rbAnnualSalesPosition.Text = "(QF-SAL-05) Annual Sales Position";
            this.rbAnnualSalesPosition.UseVisualStyleBackColor = true;
            // 
            // rbTargetAchievement_ByYear
            // 
            this.rbTargetAchievement_ByYear.AutoSize = true;
            this.rbTargetAchievement_ByYear.Location = new System.Drawing.Point(28, 182);
            this.rbTargetAchievement_ByYear.Name = "rbTargetAchievement_ByYear";
            this.rbTargetAchievement_ByYear.Size = new System.Drawing.Size(253, 17);
            this.rbTargetAchievement_ByYear.TabIndex = 3;
            this.rbTargetAchievement_ByYear.Text = "(QF-SAL-03) Sales Target && Achievement";
            this.rbTargetAchievement_ByYear.UseVisualStyleBackColor = true;
            // 
            // rbSummaryOfSales_ByYear
            // 
            this.rbSummaryOfSales_ByYear.AutoSize = true;
            this.rbSummaryOfSales_ByYear.Location = new System.Drawing.Point(28, 205);
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
            this.label4.Location = new System.Drawing.Point(17, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Summarized Reports:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "for the Year of";
            // 
            // cmbSalesYear
            // 
            this.cmbSalesYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesYear.FormattingEnabled = true;
            this.cmbSalesYear.Location = new System.Drawing.Point(289, 187);
            this.cmbSalesYear.Name = "cmbSalesYear";
            this.cmbSalesYear.Size = new System.Drawing.Size(87, 21);
            this.cmbSalesYear.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.GreenYellow;
            this.label6.Location = new System.Drawing.Point(18, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Information of Canceled Unit(s)";
            // 
            // cmbDateBy
            // 
            this.cmbDateBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateBy.FormattingEnabled = true;
            this.cmbDateBy.Items.AddRange(new object[] {
            "Booking Date",
            "Cancel Date"});
            this.cmbDateBy.Location = new System.Drawing.Point(52, 276);
            this.cmbDateBy.Name = "cmbDateBy";
            this.cmbDateBy.Size = new System.Drawing.Size(121, 21);
            this.cmbDateBy.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "between";
            // 
            // dtpCU_EndDate
            // 
            this.dtpCU_EndDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpCU_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCU_EndDate.Location = new System.Drawing.Point(243, 305);
            this.dtpCU_EndDate.Name = "dtpCU_EndDate";
            this.dtpCU_EndDate.Size = new System.Drawing.Size(107, 20);
            this.dtpCU_EndDate.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "&&";
            // 
            // dtpCU_StartDate
            // 
            this.dtpCU_StartDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpCU_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCU_StartDate.Location = new System.Drawing.Point(111, 305);
            this.dtpCU_StartDate.Name = "dtpCU_StartDate";
            this.dtpCU_StartDate.Size = new System.Drawing.Size(107, 20);
            this.dtpCU_StartDate.TabIndex = 1;
            // 
            // rbCanceledClientList
            // 
            this.rbCanceledClientList.AutoSize = true;
            this.rbCanceledClientList.Location = new System.Drawing.Point(33, 257);
            this.rbCanceledClientList.Name = "rbCanceledClientList";
            this.rbCanceledClientList.Size = new System.Drawing.Size(163, 17);
            this.rbCanceledClientList.TabIndex = 3;
            this.rbCanceledClientList.Text = "Details list of unit(s)";
            this.rbCanceledClientList.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.GreenYellow;
            this.label11.Location = new System.Drawing.Point(17, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Sales Report";
            // 
            // btnShowReport
            // 
            this.btnShowReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowReport.Image = global::RealEstateManagementSystem.Properties.Resources.rating;
            this.btnShowReport.Location = new System.Drawing.Point(854, 312);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(958, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(943, 17);
            this.tssStatus.Spring = true;
            this.tssStatus.Text = "Ready";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(958, 400);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.Location = new System.Drawing.Point(11, 243);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(373, 88);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(11, 151);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(373, 75);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(11, 19);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(373, 117);
            // 
            // rbSummarizedSalesStatus_ByProject
            // 
            this.rbSummarizedSalesStatus_ByProject.AutoSize = true;
            this.rbSummarizedSalesStatus_ByProject.Location = new System.Drawing.Point(392, 297);
            this.rbSummarizedSalesStatus_ByProject.Name = "rbSummarizedSalesStatus_ByProject";
            this.rbSummarizedSalesStatus_ByProject.Size = new System.Drawing.Size(235, 17);
            this.rbSummarizedSalesStatus_ByProject.TabIndex = 3;
            this.rbSummarizedSalesStatus_ByProject.Text = "(QF-SAL-06) Summarized Sales Status";
            this.rbSummarizedSalesStatus_ByProject.UseVisualStyleBackColor = true;
            // 
            // rbCollectionOfProject
            // 
            this.rbCollectionOfProject.AutoSize = true;
            this.rbCollectionOfProject.Location = new System.Drawing.Point(392, 274);
            this.rbCollectionOfProject.Name = "rbCollectionOfProject";
            this.rbCollectionOfProject.Size = new System.Drawing.Size(151, 17);
            this.rbCollectionOfProject.TabIndex = 3;
            this.rbCollectionOfProject.Text = "Collection of Project";
            this.rbCollectionOfProject.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(392, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Project Status:";
            // 
            // lvProjectStatus
            // 
            this.lvProjectStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.lvProjectStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProjectStatus.CheckBoxes = true;
            this.lvProjectStatus.ForeColor = System.Drawing.Color.LightCyan;
            this.lvProjectStatus.FullRowSelect = true;
            this.lvProjectStatus.GridLines = true;
            this.lvProjectStatus.Location = new System.Drawing.Point(392, 19);
            this.lvProjectStatus.Name = "lvProjectStatus";
            this.lvProjectStatus.Size = new System.Drawing.Size(178, 249);
            this.lvProjectStatus.TabIndex = 1;
            this.lvProjectStatus.UseCompatibleStateImageBehavior = false;
            this.lvProjectStatus.View = System.Windows.Forms.View.List;
            this.lvProjectStatus.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvProjectStatus_ItemChecked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(576, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "List of Project(s):";
            // 
            // lvProjects
            // 
            this.lvProjects.BackColor = System.Drawing.Color.SteelBlue;
            this.lvProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProjects.CheckBoxes = true;
            this.lvProjects.ForeColor = System.Drawing.Color.LightCyan;
            this.lvProjects.FullRowSelect = true;
            this.lvProjects.GridLines = true;
            this.lvProjects.Location = new System.Drawing.Point(576, 19);
            this.lvProjects.Name = "lvProjects";
            this.lvProjects.Size = new System.Drawing.Size(376, 272);
            this.lvProjects.TabIndex = 1;
            this.lvProjects.UseCompatibleStateImageBehavior = false;
            this.lvProjects.View = System.Windows.Forms.View.List;
            // 
            // lblProjectCount
            // 
            this.lblProjectCount.AutoSize = true;
            this.lblProjectCount.Location = new System.Drawing.Point(837, 294);
            this.lblProjectCount.Name = "lblProjectCount";
            this.lblProjectCount.Size = new System.Drawing.Size(115, 13);
            this.lblProjectCount.TabIndex = 2;
            this.lblProjectCount.Text = "0 Project(s) Found";
            // 
            // rbBlockedUnits
            // 
            this.rbBlockedUnits.AutoSize = true;
            this.rbBlockedUnits.Location = new System.Drawing.Point(392, 320);
            this.rbBlockedUnits.Name = "rbBlockedUnits";
            this.rbBlockedUnits.Size = new System.Drawing.Size(163, 17);
            this.rbBlockedUnits.TabIndex = 10;
            this.rbBlockedUnits.Text = "List of Blocked Unit(s)";
            this.rbBlockedUnits.UseVisualStyleBackColor = true;
            // 
            // rbSalesSummaryByRep
            // 
            this.rbSalesSummaryByRep.AutoSize = true;
            this.rbSalesSummaryByRep.Location = new System.Drawing.Point(20, 340);
            this.rbSalesSummaryByRep.Name = "rbSalesSummaryByRep";
            this.rbSalesSummaryByRep.Size = new System.Drawing.Size(145, 17);
            this.rbSalesSummaryByRep.TabIndex = 11;
            this.rbSalesSummaryByRep.Text = "Sales Summary by Rep";
            this.rbSalesSummaryByRep.UseVisualStyleBackColor = true;
            // 
            // frmSummarizedSalesReport
            // 
            this.AcceptButton = this.btnShowReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(958, 400);
            this.Controls.Add(this.rbSalesSummaryByRep);
            this.Controls.Add(this.rbBlockedUnits);
            this.Controls.Add(this.lblProjectCount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lvProjects);
            this.Controls.Add(this.rbSummarizedSalesStatus_ByProject);
            this.Controls.Add(this.rbCollectionOfProject);
            this.Controls.Add(this.lvProjectStatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmbDateBy);
            this.Controls.Add(this.cmbSalesYear);
            this.Controls.Add(this.rbCanceledClientList);
            this.Controls.Add(this.rbSummaryOfSales_ByYear);
            this.Controls.Add(this.rbTargetAchievement_ByYear);
            this.Controls.Add(this.rbAnnualSalesPosition);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shapeContainer1);
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
        private System.Windows.Forms.RadioButton rbAnnualSalesPosition;
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
        private System.Windows.Forms.RadioButton rbCanceledClientList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.RadioButton rbSummarizedSalesStatus_ByProject;
        private System.Windows.Forms.RadioButton rbCollectionOfProject;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView lvProjectStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView lvProjects;
        private System.Windows.Forms.Label lblProjectCount;
        private System.Windows.Forms.RadioButton rbBlockedUnits;
        private System.Windows.Forms.RadioButton rbSalesSummaryByRep;
    }
}