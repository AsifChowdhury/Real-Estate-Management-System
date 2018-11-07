namespace RealEstateManagementSystem.UserInterface.Reports
{
    partial class frmProjectReports
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectReports));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProjectName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbProjectType = new System.Windows.Forms.RadioButton();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.pnlSummaryReportType = new System.Windows.Forms.Panel();
            this.rbSummarizedSalesStatus = new System.Windows.Forms.RadioButton();
            this.rbBlockedUnits_Summary = new System.Windows.Forms.RadioButton();
            this.rbFinancialSummary = new System.Windows.Forms.RadioButton();
            this.rbCommonClientList = new System.Windows.Forms.RadioButton();
            this.rbCommonPriceList = new System.Windows.Forms.RadioButton();
            this.rbProjectConsolidation = new System.Windows.Forms.RadioButton();
            this.rbProjectStatus = new System.Windows.Forms.RadioButton();
            this.cmbSummaryCriteria = new System.Windows.Forms.ComboBox();
            this.rbDistrict = new System.Windows.Forms.RadioButton();
            this.rbLocation = new System.Windows.Forms.RadioButton();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.rbPriceList = new System.Windows.Forms.RadioButton();
            this.rbBookingPosition = new System.Windows.Forms.RadioButton();
            this.chkLOC_withPhotoAndSignature = new System.Windows.Forms.CheckBox();
            this.chkLOC_withPayment = new System.Windows.Forms.CheckBox();
            this.chkLOC_withUnitValue = new System.Windows.Forms.CheckBox();
            this.chkRegistrationStatus_WithPayment = new System.Windows.Forms.CheckBox();
            this.rbPayementDetailsOfAllClient = new System.Windows.Forms.RadioButton();
            this.rbListOfClients = new System.Windows.Forms.RadioButton();
            this.rbListOfLandOwners = new System.Windows.Forms.RadioButton();
            this.rbListOfUnits = new System.Windows.Forms.RadioButton();
            this.rbBlockedUnits = new System.Windows.Forms.RadioButton();
            this.rbOralBooking = new System.Windows.Forms.RadioButton();
            this.rbDeductedAmount = new System.Windows.Forms.RadioButton();
            this.rbDueList = new System.Windows.Forms.RadioButton();
            this.rbGeneralStatusOfClient = new System.Windows.Forms.RadioButton();
            this.rbDeedOfAgreementStatus = new System.Windows.Forms.RadioButton();
            this.rbRegistrationStatus = new System.Windows.Forms.RadioButton();
            this.rbProjectSummary = new System.Windows.Forms.RadioButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttProjectReport = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbRecoveryPosition = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.pnlSummaryReportType.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name:";
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Location = new System.Drawing.Point(95, 7);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(307, 21);
            this.cmbProjectName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbProjectType);
            this.panel1.Controls.Add(this.btnShowReport);
            this.panel1.Controls.Add(this.pnlSummaryReportType);
            this.panel1.Controls.Add(this.rbProjectStatus);
            this.panel1.Controls.Add(this.cmbSummaryCriteria);
            this.panel1.Controls.Add(this.rbDistrict);
            this.panel1.Controls.Add(this.rbLocation);
            this.panel1.Controls.Add(this.rbArea);
            this.panel1.Controls.Add(this.cmbProjectName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbPriceList);
            this.panel1.Controls.Add(this.rbBookingPosition);
            this.panel1.Controls.Add(this.chkLOC_withPhotoAndSignature);
            this.panel1.Controls.Add(this.chkLOC_withPayment);
            this.panel1.Controls.Add(this.chkLOC_withUnitValue);
            this.panel1.Controls.Add(this.chkRegistrationStatus_WithPayment);
            this.panel1.Controls.Add(this.rbPayementDetailsOfAllClient);
            this.panel1.Controls.Add(this.rbListOfClients);
            this.panel1.Controls.Add(this.rbListOfLandOwners);
            this.panel1.Controls.Add(this.rbListOfUnits);
            this.panel1.Controls.Add(this.rbBlockedUnits);
            this.panel1.Controls.Add(this.rbOralBooking);
            this.panel1.Controls.Add(this.rbDeductedAmount);
            this.panel1.Controls.Add(this.rbDueList);
            this.panel1.Controls.Add(this.rbGeneralStatusOfClient);
            this.panel1.Controls.Add(this.rbDeedOfAgreementStatus);
            this.panel1.Controls.Add(this.rbRegistrationStatus);
            this.panel1.Controls.Add(this.rbProjectSummary);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(14, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 441);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rbProjectType
            // 
            this.rbProjectType.AutoSize = true;
            this.rbProjectType.Location = new System.Drawing.Point(546, 8);
            this.rbProjectType.Name = "rbProjectType";
            this.rbProjectType.Size = new System.Drawing.Size(97, 17);
            this.rbProjectType.TabIndex = 20;
            this.rbProjectType.TabStop = true;
            this.rbProjectType.Text = "Project Type";
            this.rbProjectType.UseVisualStyleBackColor = true;
            this.rbProjectType.CheckedChanged += new System.EventHandler(this.rbProjectType_CheckedChanged);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowReport.Image = global::RealEstateManagementSystem.Properties.Resources.printer;
            this.btnShowReport.Location = new System.Drawing.Point(511, 395);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(128, 36);
            this.btnShowReport.TabIndex = 25;
            this.btnShowReport.Text = " Show Report";
            this.btnShowReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowReport.UseVisualStyleBackColor = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            this.btnShowReport.MouseHover += new System.EventHandler(this.btnShowReport_MouseHover);
            // 
            // pnlSummaryReportType
            // 
            this.pnlSummaryReportType.Controls.Add(this.rbRecoveryPosition);
            this.pnlSummaryReportType.Controls.Add(this.rbSummarizedSalesStatus);
            this.pnlSummaryReportType.Controls.Add(this.rbBlockedUnits_Summary);
            this.pnlSummaryReportType.Controls.Add(this.rbFinancialSummary);
            this.pnlSummaryReportType.Controls.Add(this.rbCommonClientList);
            this.pnlSummaryReportType.Controls.Add(this.rbCommonPriceList);
            this.pnlSummaryReportType.Controls.Add(this.rbProjectConsolidation);
            this.pnlSummaryReportType.Location = new System.Drawing.Point(433, 80);
            this.pnlSummaryReportType.Name = "pnlSummaryReportType";
            this.pnlSummaryReportType.Size = new System.Drawing.Size(206, 173);
            this.pnlSummaryReportType.TabIndex = 24;
            // 
            // rbSummarizedSalesStatus
            // 
            this.rbSummarizedSalesStatus.AutoSize = true;
            this.rbSummarizedSalesStatus.Location = new System.Drawing.Point(12, 124);
            this.rbSummarizedSalesStatus.Name = "rbSummarizedSalesStatus";
            this.rbSummarizedSalesStatus.Size = new System.Drawing.Size(163, 17);
            this.rbSummarizedSalesStatus.TabIndex = 5;
            this.rbSummarizedSalesStatus.TabStop = true;
            this.rbSummarizedSalesStatus.Text = "Summarized Sales Status";
            this.rbSummarizedSalesStatus.UseVisualStyleBackColor = true;
            // 
            // rbBlockedUnits_Summary
            // 
            this.rbBlockedUnits_Summary.AutoSize = true;
            this.rbBlockedUnits_Summary.Location = new System.Drawing.Point(12, 101);
            this.rbBlockedUnits_Summary.Name = "rbBlockedUnits_Summary";
            this.rbBlockedUnits_Summary.Size = new System.Drawing.Size(163, 17);
            this.rbBlockedUnits_Summary.TabIndex = 4;
            this.rbBlockedUnits_Summary.TabStop = true;
            this.rbBlockedUnits_Summary.Text = "List of Blocked Unit(s)";
            this.rbBlockedUnits_Summary.UseVisualStyleBackColor = true;
            // 
            // rbFinancialSummary
            // 
            this.rbFinancialSummary.AutoSize = true;
            this.rbFinancialSummary.Location = new System.Drawing.Point(12, 78);
            this.rbFinancialSummary.Name = "rbFinancialSummary";
            this.rbFinancialSummary.Size = new System.Drawing.Size(127, 17);
            this.rbFinancialSummary.TabIndex = 3;
            this.rbFinancialSummary.TabStop = true;
            this.rbFinancialSummary.Text = "Financial Summary";
            this.rbFinancialSummary.UseVisualStyleBackColor = true;
            // 
            // rbCommonClientList
            // 
            this.rbCommonClientList.AutoSize = true;
            this.rbCommonClientList.Location = new System.Drawing.Point(12, 55);
            this.rbCommonClientList.Name = "rbCommonClientList";
            this.rbCommonClientList.Size = new System.Drawing.Size(91, 17);
            this.rbCommonClientList.TabIndex = 2;
            this.rbCommonClientList.TabStop = true;
            this.rbCommonClientList.Text = "Client List";
            this.rbCommonClientList.UseVisualStyleBackColor = true;
            // 
            // rbCommonPriceList
            // 
            this.rbCommonPriceList.AutoSize = true;
            this.rbCommonPriceList.Location = new System.Drawing.Point(12, 32);
            this.rbCommonPriceList.Name = "rbCommonPriceList";
            this.rbCommonPriceList.Size = new System.Drawing.Size(85, 17);
            this.rbCommonPriceList.TabIndex = 1;
            this.rbCommonPriceList.TabStop = true;
            this.rbCommonPriceList.Text = "Price List";
            this.rbCommonPriceList.UseVisualStyleBackColor = true;
            // 
            // rbProjectConsolidation
            // 
            this.rbProjectConsolidation.AutoSize = true;
            this.rbProjectConsolidation.Location = new System.Drawing.Point(12, 9);
            this.rbProjectConsolidation.Name = "rbProjectConsolidation";
            this.rbProjectConsolidation.Size = new System.Drawing.Size(151, 17);
            this.rbProjectConsolidation.TabIndex = 0;
            this.rbProjectConsolidation.TabStop = true;
            this.rbProjectConsolidation.Text = "Project Consolidation";
            this.rbProjectConsolidation.UseVisualStyleBackColor = true;
            // 
            // rbProjectStatus
            // 
            this.rbProjectStatus.AutoSize = true;
            this.rbProjectStatus.Location = new System.Drawing.Point(432, 8);
            this.rbProjectStatus.Name = "rbProjectStatus";
            this.rbProjectStatus.Size = new System.Drawing.Size(109, 17);
            this.rbProjectStatus.TabIndex = 19;
            this.rbProjectStatus.TabStop = true;
            this.rbProjectStatus.Text = "Project Status";
            this.rbProjectStatus.UseVisualStyleBackColor = true;
            this.rbProjectStatus.CheckedChanged += new System.EventHandler(this.rbProjectStatus_CheckedChanged);
            // 
            // cmbSummaryCriteria
            // 
            this.cmbSummaryCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSummaryCriteria.FormattingEnabled = true;
            this.cmbSummaryCriteria.Location = new System.Drawing.Point(432, 53);
            this.cmbSummaryCriteria.Name = "cmbSummaryCriteria";
            this.cmbSummaryCriteria.Size = new System.Drawing.Size(207, 21);
            this.cmbSummaryCriteria.TabIndex = 24;
            // 
            // rbDistrict
            // 
            this.rbDistrict.AutoSize = true;
            this.rbDistrict.Location = new System.Drawing.Point(432, 30);
            this.rbDistrict.Name = "rbDistrict";
            this.rbDistrict.Size = new System.Drawing.Size(73, 17);
            this.rbDistrict.TabIndex = 21;
            this.rbDistrict.TabStop = true;
            this.rbDistrict.Text = "District";
            this.rbDistrict.UseVisualStyleBackColor = true;
            this.rbDistrict.CheckedChanged += new System.EventHandler(this.rbDistrict_CheckedChanged);
            // 
            // rbLocation
            // 
            this.rbLocation.AutoSize = true;
            this.rbLocation.Location = new System.Drawing.Point(566, 30);
            this.rbLocation.Name = "rbLocation";
            this.rbLocation.Size = new System.Drawing.Size(73, 17);
            this.rbLocation.TabIndex = 23;
            this.rbLocation.TabStop = true;
            this.rbLocation.Text = "Location";
            this.rbLocation.UseVisualStyleBackColor = true;
            this.rbLocation.CheckedChanged += new System.EventHandler(this.rbLocation_CheckedChanged);
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Location = new System.Drawing.Point(511, 30);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(49, 17);
            this.rbArea.TabIndex = 22;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "Area";
            this.rbArea.UseVisualStyleBackColor = true;
            this.rbArea.CheckedChanged += new System.EventHandler(this.rbArea_CheckedChanged);
            // 
            // rbPriceList
            // 
            this.rbPriceList.AutoSize = true;
            this.rbPriceList.Location = new System.Drawing.Point(16, 418);
            this.rbPriceList.Name = "rbPriceList";
            this.rbPriceList.Size = new System.Drawing.Size(157, 17);
            this.rbPriceList.TabIndex = 18;
            this.rbPriceList.Text = "(QF-MKT-11) Price List";
            this.rbPriceList.UseVisualStyleBackColor = true;
            this.rbPriceList.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbBookingPosition
            // 
            this.rbBookingPosition.AutoSize = true;
            this.rbBookingPosition.Location = new System.Drawing.Point(16, 395);
            this.rbBookingPosition.Name = "rbBookingPosition";
            this.rbBookingPosition.Size = new System.Drawing.Size(193, 17);
            this.rbBookingPosition.TabIndex = 17;
            this.rbBookingPosition.Text = "(QF-MKT-09) Booking Position";
            this.rbBookingPosition.UseVisualStyleBackColor = true;
            this.rbBookingPosition.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // chkLOC_withPhotoAndSignature
            // 
            this.chkLOC_withPhotoAndSignature.AutoSize = true;
            this.chkLOC_withPhotoAndSignature.Location = new System.Drawing.Point(149, 336);
            this.chkLOC_withPhotoAndSignature.Name = "chkLOC_withPhotoAndSignature";
            this.chkLOC_withPhotoAndSignature.Size = new System.Drawing.Size(158, 17);
            this.chkLOC_withPhotoAndSignature.TabIndex = 15;
            this.chkLOC_withPhotoAndSignature.Text = "with Photo && Signature";
            this.chkLOC_withPhotoAndSignature.UseVisualStyleBackColor = true;
            this.chkLOC_withPhotoAndSignature.Click += new System.EventHandler(this.chkLOC_withPhotoAndSignature_Click);
            // 
            // chkLOC_withPayment
            // 
            this.chkLOC_withPayment.AutoSize = true;
            this.chkLOC_withPayment.Location = new System.Drawing.Point(279, 314);
            this.chkLOC_withPayment.Name = "chkLOC_withPayment";
            this.chkLOC_withPayment.Size = new System.Drawing.Size(98, 17);
            this.chkLOC_withPayment.TabIndex = 14;
            this.chkLOC_withPayment.Text = "With payment";
            this.chkLOC_withPayment.UseVisualStyleBackColor = true;
            this.chkLOC_withPayment.Click += new System.EventHandler(this.chkLOC_withPayment_Click);
            // 
            // chkLOC_withUnitValue
            // 
            this.chkLOC_withUnitValue.AutoSize = true;
            this.chkLOC_withUnitValue.Location = new System.Drawing.Point(149, 313);
            this.chkLOC_withUnitValue.Name = "chkLOC_withUnitValue";
            this.chkLOC_withUnitValue.Size = new System.Drawing.Size(116, 17);
            this.chkLOC_withUnitValue.TabIndex = 13;
            this.chkLOC_withUnitValue.Text = "With Unit Value";
            this.chkLOC_withUnitValue.UseVisualStyleBackColor = true;
            this.chkLOC_withUnitValue.Click += new System.EventHandler(this.chkLOC_withUnitValue_Click);
            // 
            // chkRegistrationStatus_WithPayment
            // 
            this.chkRegistrationStatus_WithPayment.AutoSize = true;
            this.chkRegistrationStatus_WithPayment.Location = new System.Drawing.Point(162, 80);
            this.chkRegistrationStatus_WithPayment.Name = "chkRegistrationStatus_WithPayment";
            this.chkRegistrationStatus_WithPayment.Size = new System.Drawing.Size(98, 17);
            this.chkRegistrationStatus_WithPayment.TabIndex = 3;
            this.chkRegistrationStatus_WithPayment.Text = "With payment";
            this.chkRegistrationStatus_WithPayment.UseVisualStyleBackColor = true;
            this.chkRegistrationStatus_WithPayment.CheckedChanged += new System.EventHandler(this.chkRegistrationStatus_WithPayment_CheckedChanged);
            // 
            // rbPayementDetailsOfAllClient
            // 
            this.rbPayementDetailsOfAllClient.AutoSize = true;
            this.rbPayementDetailsOfAllClient.Location = new System.Drawing.Point(16, 359);
            this.rbPayementDetailsOfAllClient.Name = "rbPayementDetailsOfAllClient";
            this.rbPayementDetailsOfAllClient.Size = new System.Drawing.Size(199, 17);
            this.rbPayementDetailsOfAllClient.TabIndex = 16;
            this.rbPayementDetailsOfAllClient.Text = "Payment details of All Client";
            this.rbPayementDetailsOfAllClient.UseVisualStyleBackColor = true;
            this.rbPayementDetailsOfAllClient.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbListOfClients
            // 
            this.rbListOfClients.AutoSize = true;
            this.rbListOfClients.Location = new System.Drawing.Point(16, 313);
            this.rbListOfClients.Name = "rbListOfClients";
            this.rbListOfClients.Size = new System.Drawing.Size(127, 17);
            this.rbListOfClients.TabIndex = 12;
            this.rbListOfClients.Text = "List of Client(s)";
            this.rbListOfClients.UseVisualStyleBackColor = true;
            this.rbListOfClients.CheckedChanged += new System.EventHandler(this.rbListOfClients_CheckedChanged);
            // 
            // rbListOfLandOwners
            // 
            this.rbListOfLandOwners.AutoSize = true;
            this.rbListOfLandOwners.Location = new System.Drawing.Point(16, 290);
            this.rbListOfLandOwners.Name = "rbListOfLandOwners";
            this.rbListOfLandOwners.Size = new System.Drawing.Size(151, 17);
            this.rbListOfLandOwners.TabIndex = 11;
            this.rbListOfLandOwners.Text = "List of Land Owner(s)";
            this.rbListOfLandOwners.UseVisualStyleBackColor = true;
            this.rbListOfLandOwners.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbListOfUnits
            // 
            this.rbListOfUnits.AutoSize = true;
            this.rbListOfUnits.Location = new System.Drawing.Point(16, 267);
            this.rbListOfUnits.Name = "rbListOfUnits";
            this.rbListOfUnits.Size = new System.Drawing.Size(115, 17);
            this.rbListOfUnits.TabIndex = 10;
            this.rbListOfUnits.Text = "List of Unit(s)";
            this.rbListOfUnits.UseVisualStyleBackColor = true;
            this.rbListOfUnits.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbBlockedUnits
            // 
            this.rbBlockedUnits.AutoSize = true;
            this.rbBlockedUnits.Location = new System.Drawing.Point(16, 231);
            this.rbBlockedUnits.Name = "rbBlockedUnits";
            this.rbBlockedUnits.Size = new System.Drawing.Size(115, 17);
            this.rbBlockedUnits.TabIndex = 9;
            this.rbBlockedUnits.Text = "Blocked Unit(s)";
            this.rbBlockedUnits.UseVisualStyleBackColor = true;
            this.rbBlockedUnits.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbOralBooking
            // 
            this.rbOralBooking.AutoSize = true;
            this.rbOralBooking.Location = new System.Drawing.Point(16, 208);
            this.rbOralBooking.Name = "rbOralBooking";
            this.rbOralBooking.Size = new System.Drawing.Size(97, 17);
            this.rbOralBooking.TabIndex = 8;
            this.rbOralBooking.Text = "Oral Booking";
            this.rbOralBooking.UseVisualStyleBackColor = true;
            this.rbOralBooking.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbDeductedAmount
            // 
            this.rbDeductedAmount.AutoSize = true;
            this.rbDeductedAmount.Location = new System.Drawing.Point(16, 171);
            this.rbDeductedAmount.Name = "rbDeductedAmount";
            this.rbDeductedAmount.Size = new System.Drawing.Size(115, 17);
            this.rbDeductedAmount.TabIndex = 7;
            this.rbDeductedAmount.Text = "Deducted Amount";
            this.rbDeductedAmount.UseVisualStyleBackColor = true;
            this.rbDeductedAmount.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbDueList
            // 
            this.rbDueList.AutoSize = true;
            this.rbDueList.Location = new System.Drawing.Point(16, 148);
            this.rbDueList.Name = "rbDueList";
            this.rbDueList.Size = new System.Drawing.Size(73, 17);
            this.rbDueList.TabIndex = 6;
            this.rbDueList.Text = "Due List";
            this.rbDueList.UseVisualStyleBackColor = true;
            this.rbDueList.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbGeneralStatusOfClient
            // 
            this.rbGeneralStatusOfClient.AutoSize = true;
            this.rbGeneralStatusOfClient.Location = new System.Drawing.Point(16, 125);
            this.rbGeneralStatusOfClient.Name = "rbGeneralStatusOfClient";
            this.rbGeneralStatusOfClient.Size = new System.Drawing.Size(169, 17);
            this.rbGeneralStatusOfClient.TabIndex = 5;
            this.rbGeneralStatusOfClient.Text = "General Status of Client";
            this.rbGeneralStatusOfClient.UseVisualStyleBackColor = true;
            this.rbGeneralStatusOfClient.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbDeedOfAgreementStatus
            // 
            this.rbDeedOfAgreementStatus.AutoSize = true;
            this.rbDeedOfAgreementStatus.Location = new System.Drawing.Point(16, 102);
            this.rbDeedOfAgreementStatus.Name = "rbDeedOfAgreementStatus";
            this.rbDeedOfAgreementStatus.Size = new System.Drawing.Size(169, 17);
            this.rbDeedOfAgreementStatus.TabIndex = 4;
            this.rbDeedOfAgreementStatus.Text = "Deed of Agreement Status";
            this.rbDeedOfAgreementStatus.UseVisualStyleBackColor = true;
            this.rbDeedOfAgreementStatus.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbRegistrationStatus
            // 
            this.rbRegistrationStatus.AutoSize = true;
            this.rbRegistrationStatus.Location = new System.Drawing.Point(16, 79);
            this.rbRegistrationStatus.Name = "rbRegistrationStatus";
            this.rbRegistrationStatus.Size = new System.Drawing.Size(139, 17);
            this.rbRegistrationStatus.TabIndex = 2;
            this.rbRegistrationStatus.Text = "Registration Status";
            this.rbRegistrationStatus.UseVisualStyleBackColor = true;
            this.rbRegistrationStatus.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbProjectSummary
            // 
            this.rbProjectSummary.AutoSize = true;
            this.rbProjectSummary.Checked = true;
            this.rbProjectSummary.Location = new System.Drawing.Point(16, 44);
            this.rbProjectSummary.Name = "rbProjectSummary";
            this.rbProjectSummary.Size = new System.Drawing.Size(115, 17);
            this.rbProjectSummary.TabIndex = 1;
            this.rbProjectSummary.TabStop = true;
            this.rbProjectSummary.Text = "Project Summary";
            this.rbProjectSummary.UseVisualStyleBackColor = true;
            this.rbProjectSummary.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(646, 439);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 424;
            this.lineShape6.X2 = 424;
            this.lineShape6.Y1 = -4;
            this.lineShape6.Y2 = 442;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.White;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = -7;
            this.lineShape5.X2 = 418;
            this.lineShape5.Y1 = 68;
            this.lineShape5.Y2 = 68;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.White;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = -7;
            this.lineShape4.X2 = 418;
            this.lineShape4.Y1 = 386;
            this.lineShape4.Y2 = 386;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.White;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -7;
            this.lineShape3.X2 = 418;
            this.lineShape3.Y1 = 257;
            this.lineShape3.Y2 = 257;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -7;
            this.lineShape2.X2 = 418;
            this.lineShape2.Y1 = 200;
            this.lineShape2.Y2 = 200;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -3;
            this.lineShape1.X2 = 422;
            this.lineShape1.Y1 = 34;
            this.lineShape1.Y2 = 34;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(671, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.ForeColor = System.Drawing.Color.Black;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(656, 17);
            this.tssStatus.Spring = true;
            this.tssStatus.Text = "Ready";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Details Reports:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Summarized Reports:";
            // 
            // rbRecoveryPosition
            // 
            this.rbRecoveryPosition.AutoSize = true;
            this.rbRecoveryPosition.Location = new System.Drawing.Point(12, 147);
            this.rbRecoveryPosition.Name = "rbRecoveryPosition";
            this.rbRecoveryPosition.Size = new System.Drawing.Size(127, 17);
            this.rbRecoveryPosition.TabIndex = 6;
            this.rbRecoveryPosition.TabStop = true;
            this.rbRecoveryPosition.Text = "Recovery Position";
            this.rbRecoveryPosition.UseVisualStyleBackColor = true;
            // 
            // frmProjectReports
            // 
            this.AcceptButton = this.btnShowReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(87)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(671, 501);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProjectReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "|::== SUMMARIZED PROJECT INFORMATION ==::|";
            this.Load += new System.EventHandler(this.frmProjectReports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSummaryReportType.ResumeLayout(false);
            this.pnlSummaryReportType.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProjectName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbProjectSummary;
        private System.Windows.Forms.RadioButton rbPriceList;
        private System.Windows.Forms.RadioButton rbBookingPosition;
        private System.Windows.Forms.CheckBox chkLOC_withPhotoAndSignature;
        private System.Windows.Forms.CheckBox chkLOC_withPayment;
        private System.Windows.Forms.CheckBox chkLOC_withUnitValue;
        private System.Windows.Forms.CheckBox chkRegistrationStatus_WithPayment;
        private System.Windows.Forms.RadioButton rbPayementDetailsOfAllClient;
        private System.Windows.Forms.RadioButton rbListOfClients;
        private System.Windows.Forms.RadioButton rbListOfLandOwners;
        private System.Windows.Forms.RadioButton rbListOfUnits;
        private System.Windows.Forms.RadioButton rbBlockedUnits;
        private System.Windows.Forms.RadioButton rbOralBooking;
        private System.Windows.Forms.RadioButton rbDeductedAmount;
        private System.Windows.Forms.RadioButton rbDueList;
        private System.Windows.Forms.RadioButton rbGeneralStatusOfClient;
        private System.Windows.Forms.RadioButton rbDeedOfAgreementStatus;
        private System.Windows.Forms.RadioButton rbRegistrationStatus;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolTip ttProjectReport;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlSummaryReportType;
        private System.Windows.Forms.RadioButton rbCommonClientList;
        private System.Windows.Forms.RadioButton rbCommonPriceList;
        private System.Windows.Forms.RadioButton rbProjectConsolidation;
        private System.Windows.Forms.ComboBox cmbSummaryCriteria;
        private System.Windows.Forms.RadioButton rbLocation;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.RadioButton rbDistrict;
        private System.Windows.Forms.RadioButton rbProjectStatus;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private System.Windows.Forms.RadioButton rbProjectType;
        private System.Windows.Forms.RadioButton rbFinancialSummary;
        private System.Windows.Forms.RadioButton rbBlockedUnits_Summary;
        private System.Windows.Forms.RadioButton rbSummarizedSalesStatus;
        private System.Windows.Forms.RadioButton rbRecoveryPosition;
    }
}