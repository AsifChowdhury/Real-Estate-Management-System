namespace RealEstateManagementSystem.UserInterface.Root
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.msMainForm = new System.Windows.Forms.MenuStrip();
            this.MarketingSection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProjectInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnitInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProjectReports = new System.Windows.Forms.ToolStripMenuItem();
            this.SalesSection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSummarizedSalesReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistrationProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.RecoverySection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecoveryReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAmountTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountsSection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChequeManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminControls = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserAuthentication = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserLoggedIn = new System.Windows.Forms.Label();
            this.lblWorkStation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUnitCancelled = new System.Windows.Forms.Button();
            this.btnUnitSold = new System.Windows.Forms.Button();
            this.btnTotalCollection = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.dtpDataDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ttMainScreen = new System.Windows.Forms.ToolTip(this.components);
            this.lblDeveloperEMail = new System.Windows.Forms.Label();
            this.pbStaging = new System.Windows.Forms.PictureBox();
            this.agreementInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.msMainForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaging)).BeginInit();
            this.SuspendLayout();
            // 
            // msMainForm
            // 
            this.msMainForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msMainForm.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MarketingSection,
            this.SalesSection,
            this.RecoverySection,
            this.AccountsSection,
            this.AdminControls,
            this.AboutUs});
            this.msMainForm.Location = new System.Drawing.Point(0, 613);
            this.msMainForm.MdiWindowListItem = this.MarketingSection;
            this.msMainForm.Name = "msMainForm";
            this.msMainForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msMainForm.Size = new System.Drawing.Size(1035, 38);
            this.msMainForm.TabIndex = 5;
            this.msMainForm.Text = "menuStrip1";
            // 
            // MarketingSection
            // 
            this.MarketingSection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProjectInformation,
            this.toolStripSeparator7,
            this.tsmiUnitInformation,
            this.toolStripSeparator6,
            this.tsmiProjectReports,
            this.toolStripSeparator5});
            this.MarketingSection.ForeColor = System.Drawing.Color.Navy;
            this.MarketingSection.Image = global::RealEstateManagementSystem.Properties.Resources.marketing;
            this.MarketingSection.Name = "MarketingSection";
            this.MarketingSection.Size = new System.Drawing.Size(138, 34);
            this.MarketingSection.Text = "Marketing Section";
            this.MarketingSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiProjectInformation
            // 
            this.tsmiProjectInformation.Image = global::RealEstateManagementSystem.Properties.Resources.house1;
            this.tsmiProjectInformation.Name = "tsmiProjectInformation";
            this.tsmiProjectInformation.Size = new System.Drawing.Size(207, 22);
            this.tsmiProjectInformation.Text = "Project Information";
            this.tsmiProjectInformation.Click += new System.EventHandler(this.tsmiProjectInformation_Click);
            // 
            // tsmiUnitInformation
            // 
            this.tsmiUnitInformation.Image = global::RealEstateManagementSystem.Properties.Resources.Building;
            this.tsmiUnitInformation.Name = "tsmiUnitInformation";
            this.tsmiUnitInformation.Size = new System.Drawing.Size(207, 22);
            this.tsmiUnitInformation.Text = "Unit Information";
            this.tsmiUnitInformation.Click += new System.EventHandler(this.tsmiUnitInformation_Click);
            // 
            // tsmiProjectReports
            // 
            this.tsmiProjectReports.Image = global::RealEstateManagementSystem.Properties.Resources.ResidentialUnit;
            this.tsmiProjectReports.Name = "tsmiProjectReports";
            this.tsmiProjectReports.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmiProjectReports.Size = new System.Drawing.Size(207, 22);
            this.tsmiProjectReports.Text = "Reports";
            this.tsmiProjectReports.Click += new System.EventHandler(this.tsmiProjectReports_Click);
            // 
            // SalesSection
            // 
            this.SalesSection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClientInformation,
            this.toolStripSeparator10,
            this.tsmiClientReports,
            this.toolStripSeparator9,
            this.tsmiSummarizedSalesReport,
            this.toolStripSeparator8,
            this.tsmiRegistrationProcess,
            this.toolStripSeparator11});
            this.SalesSection.ForeColor = System.Drawing.Color.Navy;
            this.SalesSection.Image = global::RealEstateManagementSystem.Properties.Resources.Sales;
            this.SalesSection.Name = "SalesSection";
            this.SalesSection.Size = new System.Drawing.Size(110, 34);
            this.SalesSection.Text = "Sales Section";
            this.SalesSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiClientInformation
            // 
            this.tsmiClientInformation.Image = global::RealEstateManagementSystem.Properties.Resources.family_64;
            this.tsmiClientInformation.Name = "tsmiClientInformation";
            this.tsmiClientInformation.Size = new System.Drawing.Size(256, 22);
            this.tsmiClientInformation.Text = "Client Information";
            this.tsmiClientInformation.Click += new System.EventHandler(this.tsmiClientInformation_Click);
            // 
            // tsmiClientReports
            // 
            this.tsmiClientReports.Image = global::RealEstateManagementSystem.Properties.Resources.ClientReport1;
            this.tsmiClientReports.Name = "tsmiClientReports";
            this.tsmiClientReports.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmiClientReports.Size = new System.Drawing.Size(256, 22);
            this.tsmiClientReports.Text = "General Reports";
            this.tsmiClientReports.Click += new System.EventHandler(this.tsmiClientReports_Click);
            // 
            // tsmiSummarizedSalesReport
            // 
            this.tsmiSummarizedSalesReport.Image = global::RealEstateManagementSystem.Properties.Resources.rating;
            this.tsmiSummarizedSalesReport.Name = "tsmiSummarizedSalesReport";
            this.tsmiSummarizedSalesReport.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.tsmiSummarizedSalesReport.Size = new System.Drawing.Size(256, 22);
            this.tsmiSummarizedSalesReport.Text = "Summarized Sales Report";
            this.tsmiSummarizedSalesReport.Click += new System.EventHandler(this.tsmiSummarizedSalesReport_Click);
            // 
            // tsmiRegistrationProcess
            // 
            this.tsmiRegistrationProcess.Image = global::RealEstateManagementSystem.Properties.Resources.registrationprocess;
            this.tsmiRegistrationProcess.Name = "tsmiRegistrationProcess";
            this.tsmiRegistrationProcess.Size = new System.Drawing.Size(256, 22);
            this.tsmiRegistrationProcess.Text = "Unit Registration";
            this.tsmiRegistrationProcess.Click += new System.EventHandler(this.tsmiRegistrationProcess_Click);
            // 
            // RecoverySection
            // 
            this.RecoverySection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPayment,
            this.toolStripSeparator1,
            this.tsmiRecoveryReports,
            this.toolStripSeparator2,
            this.tsmiAmountTransfer,
            this.toolStripSeparator3,
            this.agreementInformationToolStripMenuItem,
            this.toolStripSeparator4});
            this.RecoverySection.ForeColor = System.Drawing.Color.Navy;
            this.RecoverySection.Image = global::RealEstateManagementSystem.Properties.Resources.recovery;
            this.RecoverySection.Name = "RecoverySection";
            this.RecoverySection.Size = new System.Drawing.Size(131, 34);
            this.RecoverySection.Text = "Recovery Section";
            this.RecoverySection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiPayment
            // 
            this.tsmiPayment.Image = global::RealEstateManagementSystem.Properties.Resources.payment;
            this.tsmiPayment.Name = "tsmiPayment";
            this.tsmiPayment.Size = new System.Drawing.Size(242, 22);
            this.tsmiPayment.Text = "Payment";
            this.tsmiPayment.Click += new System.EventHandler(this.tsmiPayment_Click);
            // 
            // tsmiRecoveryReports
            // 
            this.tsmiRecoveryReports.Image = global::RealEstateManagementSystem.Properties.Resources.bangladeshi_taka;
            this.tsmiRecoveryReports.Name = "tsmiRecoveryReports";
            this.tsmiRecoveryReports.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.tsmiRecoveryReports.Size = new System.Drawing.Size(242, 22);
            this.tsmiRecoveryReports.Text = "Recovery Reports";
            this.tsmiRecoveryReports.Click += new System.EventHandler(this.tsmiRecoveryReports_Click);
            // 
            // tsmiAmountTransfer
            // 
            this.tsmiAmountTransfer.Image = global::RealEstateManagementSystem.Properties.Resources.moneytransfer1;
            this.tsmiAmountTransfer.Name = "tsmiAmountTransfer";
            this.tsmiAmountTransfer.Size = new System.Drawing.Size(242, 22);
            this.tsmiAmountTransfer.Text = "Amount Transfer";
            this.tsmiAmountTransfer.Click += new System.EventHandler(this.tsmiAmountTransfer_Click);
            // 
            // AccountsSection
            // 
            this.AccountsSection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChequeManagement});
            this.AccountsSection.ForeColor = System.Drawing.Color.Navy;
            this.AccountsSection.Image = global::RealEstateManagementSystem.Properties.Resources.accountsSection;
            this.AccountsSection.Name = "AccountsSection";
            this.AccountsSection.Size = new System.Drawing.Size(131, 34);
            this.AccountsSection.Text = "Accounts Section";
            this.AccountsSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiChequeManagement
            // 
            this.tsmiChequeManagement.Image = global::RealEstateManagementSystem.Properties.Resources.ChequeManagement;
            this.tsmiChequeManagement.Name = "tsmiChequeManagement";
            this.tsmiChequeManagement.Size = new System.Drawing.Size(193, 22);
            this.tsmiChequeManagement.Text = "Cheque Management";
            this.tsmiChequeManagement.Click += new System.EventHandler(this.tsmiChequeManagement_Click);
            // 
            // AdminControls
            // 
            this.AdminControls.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserAuthentication});
            this.AdminControls.ForeColor = System.Drawing.Color.Navy;
            this.AdminControls.Image = global::RealEstateManagementSystem.Properties.Resources.admin_console;
            this.AdminControls.Name = "AdminControls";
            this.AdminControls.Size = new System.Drawing.Size(117, 34);
            this.AdminControls.Text = "Admin Controls";
            this.AdminControls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiUserAuthentication
            // 
            this.tsmiUserAuthentication.Image = global::RealEstateManagementSystem.Properties.Resources.menuAuthentication;
            this.tsmiUserAuthentication.Name = "tsmiUserAuthentication";
            this.tsmiUserAuthentication.Size = new System.Drawing.Size(207, 22);
            this.tsmiUserAuthentication.Text = "User Authentication";
            this.tsmiUserAuthentication.Click += new System.EventHandler(this.tsmiUserAuthentication_Click);
            // 
            // AboutUs
            // 
            this.AboutUs.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AboutUs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutUs.Image = global::RealEstateManagementSystem.Properties.Resources.REMS1;
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(28, 34);
            this.AboutUs.Text = "About";
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblUserLoggedIn);
            this.panel1.Controls.Add(this.lblWorkStation);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblCurrentVersion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.Color.Aqua;
            this.panel1.Location = new System.Drawing.Point(528, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 66);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Logged In:";
            // 
            // lblUserLoggedIn
            // 
            this.lblUserLoggedIn.AutoSize = true;
            this.lblUserLoggedIn.Location = new System.Drawing.Point(140, 9);
            this.lblUserLoggedIn.Name = "lblUserLoggedIn";
            this.lblUserLoggedIn.Size = new System.Drawing.Size(33, 12);
            this.lblUserLoggedIn.TabIndex = 1;
            this.lblUserLoggedIn.Text = "user";
            // 
            // lblWorkStation
            // 
            this.lblWorkStation.AutoSize = true;
            this.lblWorkStation.Location = new System.Drawing.Point(140, 27);
            this.lblWorkStation.Name = "lblWorkStation";
            this.lblWorkStation.Size = new System.Drawing.Size(82, 12);
            this.lblWorkStation.TabIndex = 1;
            this.lblWorkStation.Text = "workstation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Channel:";
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.Location = new System.Drawing.Point(140, 43);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(110, 12);
            this.lblCurrentVersion.TabIndex = 1;
            this.lblCurrentVersion.Text = "current version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Current Version:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnUnitCancelled);
            this.panel2.Controls.Add(this.btnUnitSold);
            this.panel2.Controls.Add(this.btnTotalCollection);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.dtpDataDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Aqua;
            this.panel2.Location = new System.Drawing.Point(0, 508);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 105);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnUnitCancelled
            // 
            this.btnUnitCancelled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitCancelled.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnitCancelled.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnUnitCancelled.Location = new System.Drawing.Point(784, 21);
            this.btnUnitCancelled.Name = "btnUnitCancelled";
            this.btnUnitCancelled.Size = new System.Drawing.Size(195, 62);
            this.btnUnitCancelled.TabIndex = 6;
            this.btnUnitCancelled.Text = "Cancelled";
            this.btnUnitCancelled.UseVisualStyleBackColor = true;
            this.btnUnitCancelled.Click += new System.EventHandler(this.btnUnitCancelled_Click);
            // 
            // btnUnitSold
            // 
            this.btnUnitSold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnitSold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitSold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitSold.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnitSold.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnUnitSold.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUnitSold.Location = new System.Drawing.Point(547, 21);
            this.btnUnitSold.Name = "btnUnitSold";
            this.btnUnitSold.Size = new System.Drawing.Size(195, 62);
            this.btnUnitSold.TabIndex = 5;
            this.btnUnitSold.Text = "Sold";
            this.btnUnitSold.UseVisualStyleBackColor = true;
            this.btnUnitSold.Click += new System.EventHandler(this.btnUnitSold_Click);
            // 
            // btnTotalCollection
            // 
            this.btnTotalCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotalCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalCollection.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalCollection.ForeColor = System.Drawing.Color.Thistle;
            this.btnTotalCollection.Location = new System.Drawing.Point(310, 21);
            this.btnTotalCollection.Name = "btnTotalCollection";
            this.btnTotalCollection.Size = new System.Drawing.Size(195, 62);
            this.btnTotalCollection.TabIndex = 4;
            this.btnTotalCollection.Text = "Collection";
            this.btnTotalCollection.UseVisualStyleBackColor = true;
            this.btnTotalCollection.Click += new System.EventHandler(this.btnTotalCollection_Click);
            // 
            // btnReload
            // 
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.Color.Teal;
            this.btnReload.Image = global::RealEstateManagementSystem.Properties.Resources.load_to_right;
            this.btnReload.Location = new System.Drawing.Point(262, 40);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(27, 25);
            this.btnReload.TabIndex = 3;
            this.ttMainScreen.SetToolTip(this.btnReload, "Reload Data");
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dtpDataDate
            // 
            this.dtpDataDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDataDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataDate.Location = new System.Drawing.Point(122, 43);
            this.dtpDataDate.Name = "dtpDataDate";
            this.dtpDataDate.Size = new System.Drawing.Size(116, 19);
            this.dtpDataDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Show Data from:";
            // 
            // ttMainScreen
            // 
            this.ttMainScreen.IsBalloon = true;
            // 
            // lblDeveloperEMail
            // 
            this.lblDeveloperEMail.Location = new System.Drawing.Point(373, 481);
            this.lblDeveloperEMail.Name = "lblDeveloperEMail";
            this.lblDeveloperEMail.Size = new System.Drawing.Size(654, 22);
            this.lblDeveloperEMail.TabIndex = 8;
            this.lblDeveloperEMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbStaging
            // 
            this.pbStaging.Image = global::RealEstateManagementSystem.Properties.Resources.demo;
            this.pbStaging.Location = new System.Drawing.Point(725, 72);
            this.pbStaging.Name = "pbStaging";
            this.pbStaging.Size = new System.Drawing.Size(307, 308);
            this.pbStaging.TabIndex = 9;
            this.pbStaging.TabStop = false;
            // 
            // agreementInformationToolStripMenuItem
            // 
            this.agreementInformationToolStripMenuItem.Name = "agreementInformationToolStripMenuItem";
            this.agreementInformationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.agreementInformationToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.agreementInformationToolStripMenuItem.Text = "Agreement Information";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(239, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(239, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(239, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(204, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(204, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(204, 6);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(253, 6);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(253, 6);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(253, 6);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(253, 6);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1035, 651);
            this.Controls.Add(this.pbStaging);
            this.Controls.Add(this.lblDeveloperEMail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.msMainForm);
            this.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LawnGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMainForm;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.msMainForm.ResumeLayout(false);
            this.msMainForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaging)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem MarketingSection;
        private System.Windows.Forms.ToolStripMenuItem SalesSection;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjectInformation;
        private System.Windows.Forms.ToolStripMenuItem RecoverySection;
        private System.Windows.Forms.ToolStripMenuItem AccountsSection;
        private System.Windows.Forms.ToolStripMenuItem AdminControls;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserAuthentication;
        private System.Windows.Forms.ToolStripMenuItem AboutUs;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientInformation;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientReports;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjectReports;
        private System.Windows.Forms.ToolStripMenuItem tsmiPayment;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecoveryReports;
        public System.Windows.Forms.MenuStrip msMainForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnitInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserLoggedIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWorkStation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpDataDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ToolTip ttMainScreen;
        private System.Windows.Forms.Button btnUnitCancelled;
        private System.Windows.Forms.Button btnUnitSold;
        private System.Windows.Forms.Button btnTotalCollection;
        private System.Windows.Forms.Label lblDeveloperEMail;
        private System.Windows.Forms.ToolStripMenuItem tsmiChequeManagement;
        private System.Windows.Forms.PictureBox pbStaging;
        private System.Windows.Forms.ToolStripMenuItem tsmiSummarizedSalesReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistrationProcess;
        private System.Windows.Forms.ToolStripMenuItem tsmiAmountTransfer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem agreementInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
    }
}