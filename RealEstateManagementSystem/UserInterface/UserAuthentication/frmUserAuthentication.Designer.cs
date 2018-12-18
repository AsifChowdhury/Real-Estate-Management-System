namespace RealEstateManagementSystem.UserInterface.UserAuthentication
{
    partial class frmUserAuthentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAuthentication));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSetAppPermission = new System.Windows.Forms.Button();
            this.lvAppAuthentication = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvMainMenu = new System.Windows.Forms.TreeView();
            this.btnSetMenuPermission = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListView();
            this.colUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCompanyId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDesignation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnSetAppPermission);
            this.tabPage1.Controls.Add(this.lvAppAuthentication);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "App Authentication";
            // 
            // btnSetAppPermission
            // 
            this.btnSetAppPermission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetAppPermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetAppPermission.Image = global::RealEstateManagementSystem.Properties.Resources.userauthentication;
            this.btnSetAppPermission.Location = new System.Drawing.Point(491, 377);
            this.btnSetAppPermission.Name = "btnSetAppPermission";
            this.btnSetAppPermission.Size = new System.Drawing.Size(221, 39);
            this.btnSetAppPermission.TabIndex = 1;
            this.btnSetAppPermission.Text = " Set App Authentication";
            this.btnSetAppPermission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetAppPermission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetAppPermission.UseVisualStyleBackColor = true;
            this.btnSetAppPermission.Click += new System.EventHandler(this.btnSetAppPermission_Click);
            // 
            // lvAppAuthentication
            // 
            this.lvAppAuthentication.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvAppAuthentication.Location = new System.Drawing.Point(0, 0);
            this.lvAppAuthentication.Name = "lvAppAuthentication";
            this.lvAppAuthentication.Size = new System.Drawing.Size(720, 371);
            this.lvAppAuthentication.TabIndex = 0;
            this.lvAppAuthentication.UseCompatibleStateImageBehavior = false;
            this.lvAppAuthentication.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "UserId";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CompanyId";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 218;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Designation";
            this.columnHeader4.Width = 185;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Menu >> User";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvMainMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSetMenuPermission);
            this.splitContainer1.Panel2.Controls.Add(this.lstUsers);
            this.splitContainer1.Size = new System.Drawing.Size(712, 416);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 3;
            // 
            // tvMainMenu
            // 
            this.tvMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tvMainMenu.Name = "tvMainMenu";
            this.tvMainMenu.Size = new System.Drawing.Size(237, 416);
            this.tvMainMenu.TabIndex = 0;
            this.tvMainMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMainMenu_NodeMouseClick);
            // 
            // btnSetMenuPermission
            // 
            this.btnSetMenuPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetMenuPermission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetMenuPermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetMenuPermission.Image = global::RealEstateManagementSystem.Properties.Resources.menuAuthentication;
            this.btnSetMenuPermission.Location = new System.Drawing.Point(174, 384);
            this.btnSetMenuPermission.Name = "btnSetMenuPermission";
            this.btnSetMenuPermission.Size = new System.Drawing.Size(293, 29);
            this.btnSetMenuPermission.TabIndex = 3;
            this.btnSetMenuPermission.Text = " Set Menu Authentication";
            this.btnSetMenuPermission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetMenuPermission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetMenuPermission.UseVisualStyleBackColor = true;
            this.btnSetMenuPermission.Click += new System.EventHandler(this.btnSetMenuPermission_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUsers.CheckBoxes = true;
            this.lstUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUserId,
            this.colCompanyId,
            this.colName,
            this.colDesignation});
            this.lstUsers.FullRowSelect = true;
            this.lstUsers.GridLines = true;
            this.lstUsers.Location = new System.Drawing.Point(3, 3);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(468, 378);
            this.lstUsers.TabIndex = 2;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
            // 
            // colUserId
            // 
            this.colUserId.Text = "UserId";
            this.colUserId.Width = 94;
            // 
            // colCompanyId
            // 
            this.colCompanyId.Text = "CompanyId";
            this.colCompanyId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCompanyId.Width = 142;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 93;
            // 
            // colDesignation
            // 
            this.colDesignation.Text = "Designation";
            this.colDesignation.Width = 130;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(720, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "User >> Menu";
            // 
            // frmUserAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 454);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserAuthentication";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Authentication";
            this.Load += new System.EventHandler(this.frmUserAuthentication_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvAppAuthentication;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnSetAppPermission;
        private System.Windows.Forms.TreeView tvMainMenu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.ColumnHeader colUserId;
        private System.Windows.Forms.ColumnHeader colCompanyId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colDesignation;
        private System.Windows.Forms.Button btnSetMenuPermission;
    }
}