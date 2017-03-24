namespace RealEstateManagementSystem.UserInterface.Projects
{
    partial class frmDef_Locations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDef_Locations));
            this.tvLocationDetails = new System.Windows.Forms.TreeView();
            this.imgDefLocation = new System.Windows.Forms.ImageList(this.components);
            this.pnlDistrict = new System.Windows.Forms.Panel();
            this.txtDistrictName_Bangla = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDistrictName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlArea = new System.Windows.Forms.Panel();
            this.txtAreaName_Bangla = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbA_District = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.txtLocationName_Bangla = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.cmbL_Area = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbL_District = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbLocation = new System.Windows.Forms.RadioButton();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.rbDistrict = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlDistrict.SuspendLayout();
            this.pnlArea.SuspendLayout();
            this.pnlLocation.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvLocationDetails
            // 
            this.tvLocationDetails.ImageIndex = 0;
            this.tvLocationDetails.ImageList = this.imgDefLocation;
            this.tvLocationDetails.Location = new System.Drawing.Point(2, 1);
            this.tvLocationDetails.Name = "tvLocationDetails";
            this.tvLocationDetails.SelectedImageIndex = 0;
            this.tvLocationDetails.Size = new System.Drawing.Size(272, 446);
            this.tvLocationDetails.TabIndex = 0;
            this.tvLocationDetails.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvLocationDetails_NodeMouseClick);
            // 
            // imgDefLocation
            // 
            this.imgDefLocation.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDefLocation.ImageStream")));
            this.imgDefLocation.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDefLocation.Images.SetKeyName(0, "route.png");
            this.imgDefLocation.Images.SetKeyName(1, "locations.png");
            this.imgDefLocation.Images.SetKeyName(2, "placeholder.png");
            // 
            // pnlDistrict
            // 
            this.pnlDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDistrict.Controls.Add(this.txtDistrictName_Bangla);
            this.pnlDistrict.Controls.Add(this.label18);
            this.pnlDistrict.Controls.Add(this.txtDistrictName);
            this.pnlDistrict.Controls.Add(this.label1);
            this.pnlDistrict.Location = new System.Drawing.Point(278, 152);
            this.pnlDistrict.Name = "pnlDistrict";
            this.pnlDistrict.Size = new System.Drawing.Size(329, 69);
            this.pnlDistrict.TabIndex = 2;
            this.pnlDistrict.Visible = false;
            // 
            // txtDistrictName_Bangla
            // 
            this.txtDistrictName_Bangla.BackColor = System.Drawing.SystemColors.Window;
            this.txtDistrictName_Bangla.Location = new System.Drawing.Point(127, 36);
            this.txtDistrictName_Bangla.Name = "txtDistrictName_Bangla";
            this.txtDistrictName_Bangla.Size = new System.Drawing.Size(189, 23);
            this.txtDistrictName_Bangla.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(67, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 18);
            this.label18.TabIndex = 6;
            this.label18.Text = "(বাংলায়ঃ)";
            // 
            // txtDistrictName
            // 
            this.txtDistrictName.Location = new System.Drawing.Point(127, 7);
            this.txtDistrictName.Name = "txtDistrictName";
            this.txtDistrictName.Size = new System.Drawing.Size(189, 23);
            this.txtDistrictName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "District Name:";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::RealEstateManagementSystem.Properties.Resources.insert;
            this.btnSave.Location = new System.Drawing.Point(506, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 49);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Insert";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlArea
            // 
            this.pnlArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlArea.Controls.Add(this.txtAreaName_Bangla);
            this.pnlArea.Controls.Add(this.label7);
            this.pnlArea.Controls.Add(this.txtAreaName);
            this.pnlArea.Controls.Add(this.label3);
            this.pnlArea.Controls.Add(this.cmbA_District);
            this.pnlArea.Controls.Add(this.label2);
            this.pnlArea.Location = new System.Drawing.Point(278, 152);
            this.pnlArea.Name = "pnlArea";
            this.pnlArea.Size = new System.Drawing.Size(329, 101);
            this.pnlArea.TabIndex = 3;
            this.pnlArea.Visible = false;
            // 
            // txtAreaName_Bangla
            // 
            this.txtAreaName_Bangla.BackColor = System.Drawing.SystemColors.Window;
            this.txtAreaName_Bangla.Location = new System.Drawing.Point(130, 70);
            this.txtAreaName_Bangla.Name = "txtAreaName_Bangla";
            this.txtAreaName_Bangla.Size = new System.Drawing.Size(189, 23);
            this.txtAreaName_Bangla.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "(বাংলায়ঃ)";
            // 
            // txtAreaName
            // 
            this.txtAreaName.Location = new System.Drawing.Point(130, 41);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(189, 23);
            this.txtAreaName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Area Name:";
            // 
            // cmbA_District
            // 
            this.cmbA_District.FormattingEnabled = true;
            this.cmbA_District.Location = new System.Drawing.Point(130, 12);
            this.cmbA_District.Name = "cmbA_District";
            this.cmbA_District.Size = new System.Drawing.Size(189, 23);
            this.cmbA_District.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "District:";
            // 
            // pnlLocation
            // 
            this.pnlLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLocation.Controls.Add(this.txtLocationName_Bangla);
            this.pnlLocation.Controls.Add(this.label8);
            this.pnlLocation.Controls.Add(this.txtLocationName);
            this.pnlLocation.Controls.Add(this.cmbL_Area);
            this.pnlLocation.Controls.Add(this.label6);
            this.pnlLocation.Controls.Add(this.cmbL_District);
            this.pnlLocation.Controls.Add(this.label5);
            this.pnlLocation.Controls.Add(this.label4);
            this.pnlLocation.Location = new System.Drawing.Point(278, 152);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(329, 129);
            this.pnlLocation.TabIndex = 4;
            this.pnlLocation.Visible = false;
            // 
            // txtLocationName_Bangla
            // 
            this.txtLocationName_Bangla.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocationName_Bangla.Location = new System.Drawing.Point(127, 97);
            this.txtLocationName_Bangla.Name = "txtLocationName_Bangla";
            this.txtLocationName_Bangla.Size = new System.Drawing.Size(189, 23);
            this.txtLocationName_Bangla.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "(বাংলায়ঃ)";
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(127, 68);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(189, 23);
            this.txtLocationName.TabIndex = 2;
            // 
            // cmbL_Area
            // 
            this.cmbL_Area.FormattingEnabled = true;
            this.cmbL_Area.Location = new System.Drawing.Point(127, 36);
            this.cmbL_Area.Name = "cmbL_Area";
            this.cmbL_Area.Size = new System.Drawing.Size(189, 23);
            this.cmbL_Area.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Area Name:";
            // 
            // cmbL_District
            // 
            this.cmbL_District.FormattingEnabled = true;
            this.cmbL_District.Location = new System.Drawing.Point(127, 7);
            this.cmbL_District.Name = "cmbL_District";
            this.cmbL_District.Size = new System.Drawing.Size(189, 23);
            this.cmbL_District.TabIndex = 0;
            this.cmbL_District.SelectedIndexChanged += new System.EventHandler(this.cmbL_District_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Location Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "District:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rbLocation);
            this.panel4.Controls.Add(this.rbArea);
            this.panel4.Controls.Add(this.rbDistrict);
            this.panel4.Location = new System.Drawing.Point(278, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(329, 35);
            this.panel4.TabIndex = 1;
            // 
            // rbLocation
            // 
            this.rbLocation.AutoSize = true;
            this.rbLocation.Location = new System.Drawing.Point(196, 7);
            this.rbLocation.Name = "rbLocation";
            this.rbLocation.Size = new System.Drawing.Size(81, 19);
            this.rbLocation.TabIndex = 2;
            this.rbLocation.TabStop = true;
            this.rbLocation.Text = "Location";
            this.rbLocation.UseVisualStyleBackColor = true;
            this.rbLocation.CheckedChanged += new System.EventHandler(this.rbLocation_CheckedChanged);
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Location = new System.Drawing.Point(137, 7);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(53, 19);
            this.rbArea.TabIndex = 1;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "Area";
            this.rbArea.UseVisualStyleBackColor = true;
            this.rbArea.CheckedChanged += new System.EventHandler(this.rbArea_CheckedChanged);
            // 
            // rbDistrict
            // 
            this.rbDistrict.AutoSize = true;
            this.rbDistrict.Location = new System.Drawing.Point(50, 7);
            this.rbDistrict.Name = "rbDistrict";
            this.rbDistrict.Size = new System.Drawing.Size(81, 19);
            this.rbDistrict.TabIndex = 0;
            this.rbDistrict.TabStop = true;
            this.rbDistrict.Text = "District";
            this.rbDistrict.UseVisualStyleBackColor = true;
            this.rbDistrict.CheckedChanged += new System.EventHandler(this.rbDistrict_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::RealEstateManagementSystem.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(458, 287);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(42, 34);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmDef_Locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(622, 448);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlDistrict);
            this.Controls.Add(this.tvLocationDetails);
            this.Controls.Add(this.pnlLocation);
            this.Controls.Add(this.pnlArea);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDef_Locations";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Locations";
            this.Load += new System.EventHandler(this.frmDef_Locations_Load);
            this.pnlDistrict.ResumeLayout(false);
            this.pnlDistrict.PerformLayout();
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            this.pnlLocation.ResumeLayout(false);
            this.pnlLocation.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvLocationDetails;
        private System.Windows.Forms.Panel pnlDistrict;
        private System.Windows.Forms.TextBox txtDistrictName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlArea;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbA_District;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlLocation;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.ComboBox cmbL_Area;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbL_District;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtDistrictName_Bangla;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAreaName_Bangla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLocationName_Bangla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList imgDefLocation;
        public System.Windows.Forms.RadioButton rbLocation;
        public System.Windows.Forms.RadioButton rbArea;
        public System.Windows.Forms.RadioButton rbDistrict;
    }
}