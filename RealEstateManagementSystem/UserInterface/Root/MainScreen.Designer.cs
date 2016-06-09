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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiProjectInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.clientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUserLoggedIn = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssCurrentVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssWorkStationIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssAutoUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDesignation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(869, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProjectInformation});
            this.toolStripDropDownButton1.Image = global::RealEstateManagementSystem.Properties.Resources.marketing;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(116, 35);
            this.toolStripDropDownButton1.Text = "Marketing Section";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiProjectInformation
            // 
            this.tsmiProjectInformation.Image = global::RealEstateManagementSystem.Properties.Resources.house1;
            this.tsmiProjectInformation.Name = "tsmiProjectInformation";
            this.tsmiProjectInformation.Size = new System.Drawing.Size(177, 22);
            this.tsmiProjectInformation.Text = "Project Information";
            this.tsmiProjectInformation.Click += new System.EventHandler(this.tsmiProjectInformation_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientInformationToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(88, 35);
            this.toolStripSplitButton1.Text = "Sales Section";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // clientInformationToolStripMenuItem
            // 
            this.clientInformationToolStripMenuItem.Name = "clientInformationToolStripMenuItem";
            this.clientInformationToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.clientInformationToolStripMenuItem.Text = "Client Information";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssUserLoggedIn,
            this.tssDesignation,
            this.tssCurrentVersion,
            this.tssWorkStationIP,
            this.tssAutoUpdate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 397);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(869, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(380, 19);
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
            // tssDesignation
            // 
            this.tssDesignation.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssDesignation.Name = "tssDesignation";
            this.tssDesignation.Size = new System.Drawing.Size(74, 19);
            this.tssDesignation.Text = "Designation";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 421);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjectInformation;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem clientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tssUserLoggedIn;
        private System.Windows.Forms.ToolStripStatusLabel tssCurrentVersion;
        private System.Windows.Forms.ToolStripStatusLabel tssWorkStationIP;
        private System.Windows.Forms.ToolStripStatusLabel tssAutoUpdate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssDesignation;
    }
}