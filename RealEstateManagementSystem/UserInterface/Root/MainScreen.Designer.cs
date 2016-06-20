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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.ssMainForm = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUserLoggedIn = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDesignation = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssCurrentVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssWorkStationIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssAutoUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMainForm = new System.Windows.Forms.MenuStrip();
            this.MarketingSection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProjectInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProjectReports = new System.Windows.Forms.ToolStripMenuItem();
            this.SalesSection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientReports = new System.Windows.Forms.ToolStripMenuItem();
            this.RecoverySection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecoveryReports = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserAuthentication = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssConnectedServerIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssMainForm.SuspendLayout();
            this.msMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMainForm
            // 
            this.ssMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssUserLoggedIn,
            this.tssDesignation,
            this.tssCurrentVersion,
            this.tssWorkStationIP,
            this.tssAutoUpdate,
            this.tssConnectedServerIP});
            this.ssMainForm.Location = new System.Drawing.Point(0, 440);
            this.ssMainForm.Name = "ssMainForm";
            this.ssMainForm.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.ssMainForm.Size = new System.Drawing.Size(869, 24);
            this.ssMainForm.SizingGrip = false;
            this.ssMainForm.TabIndex = 2;
            this.ssMainForm.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(331, 19);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssUserLoggedIn
            // 
            this.tssUserLoggedIn.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssUserLoggedIn.Name = "tssUserLoggedIn";
            this.tssUserLoggedIn.Size = new System.Drawing.Size(90, 19);
            this.tssUserLoggedIn.Text = "User Logged In";
            // 
            // tssDesignation
            // 
            this.tssDesignation.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssDesignation.Name = "tssDesignation";
            this.tssDesignation.Size = new System.Drawing.Size(74, 19);
            this.tssDesignation.Text = "Designation";
            // 
            // tssCurrentVersion
            // 
            this.tssCurrentVersion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssCurrentVersion.Name = "tssCurrentVersion";
            this.tssCurrentVersion.Size = new System.Drawing.Size(92, 19);
            this.tssCurrentVersion.Text = "Current Version";
            // 
            // tssWorkStationIP
            // 
            this.tssWorkStationIP.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssWorkStationIP.Name = "tssWorkStationIP";
            this.tssWorkStationIP.Size = new System.Drawing.Size(86, 19);
            this.tssWorkStationIP.Text = "WorkStationIP";
            // 
            // tssAutoUpdate
            // 
            this.tssAutoUpdate.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssAutoUpdate.Name = "tssAutoUpdate";
            this.tssAutoUpdate.Size = new System.Drawing.Size(99, 19);
            this.tssAutoUpdate.Text = "NextAutoUpdate";
            // 
            // msMainForm
            // 
            this.msMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MarketingSection,
            this.SalesSection,
            this.RecoverySection,
            this.accountsSectionToolStripMenuItem,
            this.adminControlsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.msMainForm.Location = new System.Drawing.Point(0, 0);
            this.msMainForm.Name = "msMainForm";
            this.msMainForm.Size = new System.Drawing.Size(869, 39);
            this.msMainForm.TabIndex = 5;
            this.msMainForm.Text = "menuStrip1";
            // 
            // MarketingSection
            // 
            this.MarketingSection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProjectInformation,
            this.tsmiProjectReports});
            this.MarketingSection.Image = global::RealEstateManagementSystem.Properties.Resources.marketing;
            this.MarketingSection.Name = "MarketingSection";
            this.MarketingSection.Size = new System.Drawing.Size(115, 35);
            this.MarketingSection.Text = "Marketing Section";
            this.MarketingSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiProjectInformation
            // 
            this.tsmiProjectInformation.Image = global::RealEstateManagementSystem.Properties.Resources.house1;
            this.tsmiProjectInformation.Name = "tsmiProjectInformation";
            this.tsmiProjectInformation.Size = new System.Drawing.Size(177, 22);
            this.tsmiProjectInformation.Text = "Project Information";
            this.tsmiProjectInformation.Click += new System.EventHandler(this.tsmiProjectInformation_Click);
            // 
            // tsmiProjectReports
            // 
            this.tsmiProjectReports.Name = "tsmiProjectReports";
            this.tsmiProjectReports.Size = new System.Drawing.Size(177, 22);
            this.tsmiProjectReports.Text = "Reports";
            // 
            // SalesSection
            // 
            this.SalesSection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClientInformation,
            this.tsmiClientReports});
            this.SalesSection.Name = "SalesSection";
            this.SalesSection.Size = new System.Drawing.Size(87, 35);
            this.SalesSection.Text = "Sales Section";
            this.SalesSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiClientInformation
            // 
            this.tsmiClientInformation.Name = "tsmiClientInformation";
            this.tsmiClientInformation.Size = new System.Drawing.Size(171, 22);
            this.tsmiClientInformation.Text = "Client Information";
            // 
            // tsmiClientReports
            // 
            this.tsmiClientReports.Name = "tsmiClientReports";
            this.tsmiClientReports.Size = new System.Drawing.Size(171, 22);
            this.tsmiClientReports.Text = "Reports";
            // 
            // RecoverySection
            // 
            this.RecoverySection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPayment,
            this.tsmiRecoveryReports});
            this.RecoverySection.Name = "RecoverySection";
            this.RecoverySection.Size = new System.Drawing.Size(109, 35);
            this.RecoverySection.Text = "Recovery Section";
            this.RecoverySection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiPayment
            // 
            this.tsmiPayment.Name = "tsmiPayment";
            this.tsmiPayment.Size = new System.Drawing.Size(121, 22);
            this.tsmiPayment.Text = "Payment";
            // 
            // tsmiRecoveryReports
            // 
            this.tsmiRecoveryReports.Name = "tsmiRecoveryReports";
            this.tsmiRecoveryReports.Size = new System.Drawing.Size(121, 22);
            this.tsmiRecoveryReports.Text = "Reports";
            // 
            // accountsSectionToolStripMenuItem
            // 
            this.accountsSectionToolStripMenuItem.Name = "accountsSectionToolStripMenuItem";
            this.accountsSectionToolStripMenuItem.Size = new System.Drawing.Size(111, 35);
            this.accountsSectionToolStripMenuItem.Text = "Accounts Section";
            this.accountsSectionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // adminControlsToolStripMenuItem
            // 
            this.adminControlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserAuthentication});
            this.adminControlsToolStripMenuItem.Name = "adminControlsToolStripMenuItem";
            this.adminControlsToolStripMenuItem.Size = new System.Drawing.Size(103, 35);
            this.adminControlsToolStripMenuItem.Text = "Admin Controls";
            this.adminControlsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiUserAuthentication
            // 
            this.tsmiUserAuthentication.Name = "tsmiUserAuthentication";
            this.tsmiUserAuthentication.Size = new System.Drawing.Size(179, 22);
            this.tsmiUserAuthentication.Text = "User Authentication";
            this.tsmiUserAuthentication.Click += new System.EventHandler(this.tsmiUserAuthentication_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutToolStripMenuItem.Image = global::RealEstateManagementSystem.Properties.Resources.REMS1;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(28, 35);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tssConnectedServerIP
            // 
            this.tssConnectedServerIP.Name = "tssConnectedServerIP";
            this.tssConnectedServerIP.Size = new System.Drawing.Size(49, 19);
            this.tssConnectedServerIP.Text = "ServerIP";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 464);
            this.Controls.Add(this.ssMainForm);
            this.Controls.Add(this.msMainForm);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainForm;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ssMainForm.ResumeLayout(false);
            this.ssMainForm.PerformLayout();
            this.msMainForm.ResumeLayout(false);
            this.msMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssMainForm;
        private System.Windows.Forms.ToolStripStatusLabel tssUserLoggedIn;
        private System.Windows.Forms.ToolStripStatusLabel tssCurrentVersion;
        private System.Windows.Forms.ToolStripStatusLabel tssWorkStationIP;
        private System.Windows.Forms.ToolStripStatusLabel tssAutoUpdate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssDesignation;
        private System.Windows.Forms.ToolStripMenuItem MarketingSection;
        private System.Windows.Forms.ToolStripMenuItem SalesSection;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjectInformation;
        private System.Windows.Forms.ToolStripMenuItem RecoverySection;
        private System.Windows.Forms.ToolStripMenuItem accountsSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserAuthentication;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientInformation;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientReports;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjectReports;
        private System.Windows.Forms.ToolStripMenuItem tsmiPayment;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecoveryReports;
        public System.Windows.Forms.MenuStrip msMainForm;
        private System.Windows.Forms.ToolStripStatusLabel tssConnectedServerIP;
    }
}