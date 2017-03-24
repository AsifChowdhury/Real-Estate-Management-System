namespace RealEstateManagementSystem.UserInterface.Projects
{
    partial class frmUnitInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnitInformation));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUnitDetailsReport = new System.Windows.Forms.Button();
            this.cmbProjectName = new System.Windows.Forms.ComboBox();
            this.chkIsCPAvailable = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkIsBlocked = new System.Windows.Forms.CheckBox();
            this.chkIsSaleable = new System.Windows.Forms.CheckBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFloorNumber = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitNumber = new System.Windows.Forms.TextBox();
            this.cmbTypeOfUnit = new System.Windows.Forms.ComboBox();
            this.lblUnitNumber = new System.Windows.Forms.Label();
            this.lblUnitType = new System.Windows.Forms.Label();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFacing = new System.Windows.Forms.ComboBox();
            this.cmbBuilding = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUnitType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tvUnitDetails = new System.Windows.Forms.TreeView();
            this.imgUnitInformation = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttUnitInformation = new System.Windows.Forms.ToolTip(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tcUnitData = new System.Windows.Forms.TabControl();
            this.tpUnit = new System.Windows.Forms.TabPage();
            this.lblCPHashWarning = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlBlock = new System.Windows.Forms.Panel();
            this.btnBlock = new System.Windows.Forms.Button();
            this.txtBlockRemark = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpBlockEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBlockStart = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.lvBlockingHistory = new System.Windows.Forms.ListView();
            this.colBlockingId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBlockedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnBlockedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRemarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnUnBlock = new System.Windows.Forms.Button();
            this.tpHashParking = new System.Windows.Forms.TabPage();
            this.lblMasterUnit = new System.Windows.Forms.Label();
            this.btnHashParkingUpdate = new System.Windows.Forms.Button();
            this.txtHashParkingNumber = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lvHashParkingList = new System.Windows.Forms.ListView();
            this.colUnitId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnitNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colParkingNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkAutoExpand = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tcUnitData.SuspendLayout();
            this.tpUnit.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlBlock.SuspendLayout();
            this.tpHashParking.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUnitDetailsReport);
            this.panel1.Controls.Add(this.cmbProjectName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(189, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 41);
            this.panel1.TabIndex = 0;
            // 
            // btnUnitDetailsReport
            // 
            this.btnUnitDetailsReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitDetailsReport.FlatAppearance.BorderSize = 0;
            this.btnUnitDetailsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitDetailsReport.Image = global::RealEstateManagementSystem.Properties.Resources.printer;
            this.btnUnitDetailsReport.Location = new System.Drawing.Point(469, 8);
            this.btnUnitDetailsReport.Name = "btnUnitDetailsReport";
            this.btnUnitDetailsReport.Size = new System.Drawing.Size(25, 25);
            this.btnUnitDetailsReport.TabIndex = 1;
            this.btnUnitDetailsReport.TabStop = false;
            this.ttUnitInformation.SetToolTip(this.btnUnitDetailsReport, "Print Unit Details Report");
            this.btnUnitDetailsReport.UseVisualStyleBackColor = false;
            this.btnUnitDetailsReport.Click += new System.EventHandler(this.btnUnitDetailsReport_Click);
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Location = new System.Drawing.Point(117, 9);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(346, 22);
            this.cmbProjectName.TabIndex = 0;
            this.cmbProjectName.SelectionChangeCommitted += new System.EventHandler(this.cmbProjectName_SelectionChangeCommitted);
            // 
            // chkIsCPAvailable
            // 
            this.chkIsCPAvailable.AutoSize = true;
            this.chkIsCPAvailable.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkIsCPAvailable.Location = new System.Drawing.Point(349, 194);
            this.chkIsCPAvailable.Name = "chkIsCPAvailable";
            this.chkIsCPAvailable.Size = new System.Drawing.Size(109, 32);
            this.chkIsCPAvailable.TabIndex = 12;
            this.chkIsCPAvailable.Text = "C/P Available?";
            this.chkIsCPAvailable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkIsCPAvailable.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::RealEstateManagementSystem.Properties.Resources.insert;
            this.btnSave.Location = new System.Drawing.Point(377, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 57);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkIsBlocked
            // 
            this.chkIsBlocked.AutoSize = true;
            this.chkIsBlocked.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkIsBlocked.Enabled = false;
            this.chkIsBlocked.Location = new System.Drawing.Point(231, 194);
            this.chkIsBlocked.Name = "chkIsBlocked";
            this.chkIsBlocked.Size = new System.Drawing.Size(88, 32);
            this.chkIsBlocked.TabIndex = 11;
            this.chkIsBlocked.Text = "Is Blocked?";
            this.chkIsBlocked.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkIsBlocked.UseVisualStyleBackColor = true;
            // 
            // chkIsSaleable
            // 
            this.chkIsSaleable.AutoSize = true;
            this.chkIsSaleable.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkIsSaleable.Location = new System.Drawing.Point(98, 193);
            this.chkIsSaleable.Name = "chkIsSaleable";
            this.chkIsSaleable.Size = new System.Drawing.Size(95, 32);
            this.chkIsSaleable.TabIndex = 10;
            this.chkIsSaleable.Text = "Is Saleable?";
            this.chkIsSaleable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkIsSaleable.UseVisualStyleBackColor = true;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(335, 121);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(98, 22);
            this.txtRate.TabIndex = 8;
            this.txtRate.Text = "0";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowNumericOnly);
            this.txtRate.Leave += new System.EventHandler(this.txtRate_Leave);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(284, 153);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(149, 22);
            this.txtTotalPrice.TabIndex = 9;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(142, 121);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(80, 22);
            this.txtArea.TabIndex = 7;
            this.txtArea.Text = "0";
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            this.txtArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowNumericOnly);
            this.txtArea.Leave += new System.EventHandler(this.txtArea_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "Rate:";
            // 
            // cmbFloorNumber
            // 
            this.cmbFloorNumber.FormattingEnabled = true;
            this.cmbFloorNumber.Location = new System.Drawing.Point(142, 37);
            this.cmbFloorNumber.Name = "cmbFloorNumber";
            this.cmbFloorNumber.Size = new System.Drawing.Size(104, 22);
            this.cmbFloorNumber.TabIndex = 2;
            this.cmbFloorNumber.SelectionChangeCommitted += new System.EventHandler(this.cmbFloorNumber_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Floor #:";
            // 
            // txtUnitNumber
            // 
            this.txtUnitNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnitNumber.Location = new System.Drawing.Point(390, 65);
            this.txtUnitNumber.Name = "txtUnitNumber";
            this.txtUnitNumber.Size = new System.Drawing.Size(93, 22);
            this.txtUnitNumber.TabIndex = 5;
            // 
            // cmbTypeOfUnit
            // 
            this.cmbTypeOfUnit.Enabled = false;
            this.cmbTypeOfUnit.FormattingEnabled = true;
            this.cmbTypeOfUnit.Location = new System.Drawing.Point(142, 65);
            this.cmbTypeOfUnit.Name = "cmbTypeOfUnit";
            this.cmbTypeOfUnit.Size = new System.Drawing.Size(104, 22);
            this.cmbTypeOfUnit.TabIndex = 4;
            this.cmbTypeOfUnit.SelectionChangeCommitted += new System.EventHandler(this.cmbTypeOfUnit_SelectionChangeCommitted);
            // 
            // lblUnitNumber
            // 
            this.lblUnitNumber.Location = new System.Drawing.Point(256, 67);
            this.lblUnitNumber.Name = "lblUnitNumber";
            this.lblUnitNumber.Size = new System.Drawing.Size(129, 18);
            this.lblUnitNumber.TabIndex = 0;
            this.lblUnitNumber.Text = "Car Parking #:";
            this.lblUnitNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnitType
            // 
            this.lblUnitType.Location = new System.Drawing.Point(8, 68);
            this.lblUnitType.Name = "lblUnitType";
            this.lblUnitType.Size = new System.Drawing.Size(129, 17);
            this.lblUnitType.TabIndex = 0;
            this.lblUnitType.Text = "Car Parking Type:";
            this.lblUnitType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbOwner
            // 
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Items.AddRange(new object[] {
            "SEL",
            "Land Owner"});
            this.cmbOwner.Location = new System.Drawing.Point(142, 93);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(149, 22);
            this.cmbOwner.TabIndex = 6;
            this.cmbOwner.SelectionChangeCommitted += new System.EventHandler(this.cmbOwner_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Area:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Owner:";
            // 
            // cmbFacing
            // 
            this.cmbFacing.Enabled = false;
            this.cmbFacing.FormattingEnabled = true;
            this.cmbFacing.Location = new System.Drawing.Point(314, 37);
            this.cmbFacing.Name = "cmbFacing";
            this.cmbFacing.Size = new System.Drawing.Size(169, 22);
            this.cmbFacing.TabIndex = 3;
            // 
            // cmbBuilding
            // 
            this.cmbBuilding.FormattingEnabled = true;
            this.cmbBuilding.Location = new System.Drawing.Point(142, 9);
            this.cmbBuilding.Name = "cmbBuilding";
            this.cmbBuilding.Size = new System.Drawing.Size(149, 22);
            this.cmbBuilding.TabIndex = 0;
            this.cmbBuilding.SelectionChangeCommitted += new System.EventHandler(this.cmbBuilding_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Facing:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Building/Block:";
            // 
            // cmbUnitType
            // 
            this.cmbUnitType.FormattingEnabled = true;
            this.cmbUnitType.Location = new System.Drawing.Point(379, 9);
            this.cmbUnitType.Name = "cmbUnitType";
            this.cmbUnitType.Size = new System.Drawing.Size(104, 22);
            this.cmbUnitType.TabIndex = 1;
            this.cmbUnitType.SelectedIndexChanged += new System.EventHandler(this.cmbUnitType_SelectedIndexChanged);
            this.cmbUnitType.SelectionChangeCommitted += new System.EventHandler(this.cmbUnitType_SelectionChangeCommitted);
            this.cmbUnitType.SelectedValueChanged += new System.EventHandler(this.cmbUnitType_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unit Type:";
            // 
            // tvUnitDetails
            // 
            this.tvUnitDetails.ForeColor = System.Drawing.Color.Black;
            this.tvUnitDetails.FullRowSelect = true;
            this.tvUnitDetails.HideSelection = false;
            this.tvUnitDetails.ImageIndex = 0;
            this.tvUnitDetails.ImageList = this.imgUnitInformation;
            this.tvUnitDetails.Location = new System.Drawing.Point(12, 60);
            this.tvUnitDetails.Name = "tvUnitDetails";
            this.tvUnitDetails.SelectedImageIndex = 0;
            this.tvUnitDetails.Size = new System.Drawing.Size(353, 328);
            this.tvUnitDetails.TabIndex = 1;
            this.tvUnitDetails.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvUnitDetails_AfterSelect);
            // 
            // imgUnitInformation
            // 
            this.imgUnitInformation.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgUnitInformation.ImageStream")));
            this.imgUnitInformation.TransparentColor = System.Drawing.Color.Transparent;
            this.imgUnitInformation.Images.SetKeyName(0, "CarParking.png");
            this.imgUnitInformation.Images.SetKeyName(1, "CommercialUnit.png");
            this.imgUnitInformation.Images.SetKeyName(2, "ResidentialUnit.png");
            this.imgUnitInformation.Images.SetKeyName(3, "Building.png");
            this.imgUnitInformation.Images.SetKeyName(4, "Shop.png");
            this.imgUnitInformation.Images.SetKeyName(5, "ServicedApartment.png");
            this.imgUnitInformation.Images.SetKeyName(6, "ShowRoom.png");
            this.imgUnitInformation.Images.SetKeyName(7, "UnitTypeNotFound.png");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(885, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(870, 17);
            this.tssStatus.Spring = true;
            this.tssStatus.Text = "Ready";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ttUnitInformation
            // 
            this.ttUnitInformation.IsBalloon = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::RealEstateManagementSystem.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(337, 273);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 28);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.TabStop = false;
            this.ttUnitInformation.SetToolTip(this.btnRefresh, "New Unit");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tcUnitData
            // 
            this.tcUnitData.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcUnitData.Controls.Add(this.tpUnit);
            this.tcUnitData.Controls.Add(this.tabPage2);
            this.tcUnitData.Controls.Add(this.tpHashParking);
            this.tcUnitData.Location = new System.Drawing.Point(371, 60);
            this.tcUnitData.Name = "tcUnitData";
            this.tcUnitData.SelectedIndex = 0;
            this.tcUnitData.Size = new System.Drawing.Size(504, 352);
            this.tcUnitData.TabIndex = 2;
            // 
            // tpUnit
            // 
            this.tpUnit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tpUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpUnit.Controls.Add(this.btnRefresh);
            this.tpUnit.Controls.Add(this.lblCPHashWarning);
            this.tpUnit.Controls.Add(this.label12);
            this.tpUnit.Controls.Add(this.label11);
            this.tpUnit.Controls.Add(this.btnSave);
            this.tpUnit.Controls.Add(this.label10);
            this.tpUnit.Controls.Add(this.label2);
            this.tpUnit.Controls.Add(this.chkIsCPAvailable);
            this.tpUnit.Controls.Add(this.cmbUnitType);
            this.tpUnit.Controls.Add(this.label3);
            this.tpUnit.Controls.Add(this.chkIsBlocked);
            this.tpUnit.Controls.Add(this.label5);
            this.tpUnit.Controls.Add(this.chkIsSaleable);
            this.tpUnit.Controls.Add(this.cmbBuilding);
            this.tpUnit.Controls.Add(this.txtRate);
            this.tpUnit.Controls.Add(this.cmbFacing);
            this.tpUnit.Controls.Add(this.txtTotalPrice);
            this.tpUnit.Controls.Add(this.label6);
            this.tpUnit.Controls.Add(this.txtArea);
            this.tpUnit.Controls.Add(this.label7);
            this.tpUnit.Controls.Add(this.label9);
            this.tpUnit.Controls.Add(this.label8);
            this.tpUnit.Controls.Add(this.cmbFloorNumber);
            this.tpUnit.Controls.Add(this.cmbOwner);
            this.tpUnit.Controls.Add(this.label4);
            this.tpUnit.Controls.Add(this.lblUnitType);
            this.tpUnit.Controls.Add(this.txtUnitNumber);
            this.tpUnit.Controls.Add(this.lblUnitNumber);
            this.tpUnit.Controls.Add(this.cmbTypeOfUnit);
            this.tpUnit.Location = new System.Drawing.Point(4, 26);
            this.tpUnit.Name = "tpUnit";
            this.tpUnit.Padding = new System.Windows.Forms.Padding(3);
            this.tpUnit.Size = new System.Drawing.Size(496, 322);
            this.tpUnit.TabIndex = 0;
            this.tpUnit.Text = "Unit Information";
            this.tpUnit.Enter += new System.EventHandler(this.tpUnit_Enter);
            this.tpUnit.Leave += new System.EventHandler(this.tpUnit_Leave);
            // 
            // lblCPHashWarning
            // 
            this.lblCPHashWarning.ForeColor = System.Drawing.Color.Red;
            this.lblCPHashWarning.Location = new System.Drawing.Point(311, 89);
            this.lblCPHashWarning.Name = "lblCPHashWarning";
            this.lblCPHashWarning.Size = new System.Drawing.Size(172, 29);
            this.lblCPHashWarning.TabIndex = 15;
            this.lblCPHashWarning.Text = "Use \'#\' sign only for undecided parkings";
            this.lblCPHashWarning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(439, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 14);
            this.label12.TabIndex = 14;
            this.label12.Text = "/-Tk.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(439, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 14);
            this.label11.TabIndex = 14;
            this.label11.Text = "/-Tk.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 14);
            this.label10.TabIndex = 13;
            this.label10.Text = "sft.";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.pnlBlock);
            this.tabPage2.Controls.Add(this.lvBlockingHistory);
            this.tabPage2.Controls.Add(this.lblUnit);
            this.tabPage2.Controls.Add(this.btnUnBlock);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(496, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Block/Unblock";
            // 
            // pnlBlock
            // 
            this.pnlBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBlock.Controls.Add(this.btnBlock);
            this.pnlBlock.Controls.Add(this.txtBlockRemark);
            this.pnlBlock.Controls.Add(this.label15);
            this.pnlBlock.Controls.Add(this.label14);
            this.pnlBlock.Controls.Add(this.dtpBlockEnd);
            this.pnlBlock.Controls.Add(this.dtpBlockStart);
            this.pnlBlock.Controls.Add(this.label13);
            this.pnlBlock.Location = new System.Drawing.Point(14, 151);
            this.pnlBlock.Name = "pnlBlock";
            this.pnlBlock.Size = new System.Drawing.Size(462, 130);
            this.pnlBlock.TabIndex = 1;
            this.pnlBlock.Enter += new System.EventHandler(this.pnlBlock_Enter);
            this.pnlBlock.Leave += new System.EventHandler(this.pnlBlock_Leave);
            // 
            // btnBlock
            // 
            this.btnBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlock.Location = new System.Drawing.Point(353, 83);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(93, 41);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // txtBlockRemark
            // 
            this.txtBlockRemark.Location = new System.Drawing.Point(164, 59);
            this.txtBlockRemark.Multiline = true;
            this.txtBlockRemark.Name = "txtBlockRemark";
            this.txtBlockRemark.Size = new System.Drawing.Size(183, 65);
            this.txtBlockRemark.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(98, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 14);
            this.label15.TabIndex = 2;
            this.label15.Text = "Remarks";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(133, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 14);
            this.label14.TabIndex = 2;
            this.label14.Text = "To";
            // 
            // dtpBlockEnd
            // 
            this.dtpBlockEnd.CustomFormat = "dd-MMM-yyyy hh:mm tt";
            this.dtpBlockEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBlockEnd.Location = new System.Drawing.Point(164, 32);
            this.dtpBlockEnd.Name = "dtpBlockEnd";
            this.dtpBlockEnd.Size = new System.Drawing.Size(183, 22);
            this.dtpBlockEnd.TabIndex = 1;
            // 
            // dtpBlockStart
            // 
            this.dtpBlockStart.CustomFormat = "dd-MMM-yyyy hh:mm tt";
            this.dtpBlockStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBlockStart.Location = new System.Drawing.Point(164, 5);
            this.dtpBlockStart.Name = "dtpBlockStart";
            this.dtpBlockStart.Size = new System.Drawing.Size(183, 22);
            this.dtpBlockStart.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 14);
            this.label13.TabIndex = 0;
            this.label13.Text = "Block this Unit From";
            // 
            // lvBlockingHistory
            // 
            this.lvBlockingHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBlockingId,
            this.colBlockedBy,
            this.colStartDate,
            this.colEndDate,
            this.colUnBlockedBy,
            this.colRemarks});
            this.lvBlockingHistory.FullRowSelect = true;
            this.lvBlockingHistory.GridLines = true;
            this.lvBlockingHistory.Location = new System.Drawing.Point(6, 6);
            this.lvBlockingHistory.Name = "lvBlockingHistory";
            this.lvBlockingHistory.Size = new System.Drawing.Size(484, 119);
            this.lvBlockingHistory.TabIndex = 0;
            this.lvBlockingHistory.UseCompatibleStateImageBehavior = false;
            this.lvBlockingHistory.View = System.Windows.Forms.View.Details;
            // 
            // colBlockingId
            // 
            this.colBlockingId.Text = "Id";
            this.colBlockingId.Width = 0;
            // 
            // colBlockedBy
            // 
            this.colBlockedBy.Text = "Blocked By";
            this.colBlockedBy.Width = 120;
            // 
            // colStartDate
            // 
            this.colStartDate.Text = "Start";
            this.colStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStartDate.Width = 100;
            // 
            // colEndDate
            // 
            this.colEndDate.Text = "End";
            this.colEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEndDate.Width = 100;
            // 
            // colUnBlockedBy
            // 
            this.colUnBlockedBy.Text = "Un-Blocked By";
            this.colUnBlockedBy.Width = 120;
            // 
            // colRemarks
            // 
            this.colRemarks.Text = "Remarks";
            this.colRemarks.Width = 150;
            // 
            // lblUnit
            // 
            this.lblUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.Maroon;
            this.lblUnit.Location = new System.Drawing.Point(85, 128);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(330, 20);
            this.lblUnit.TabIndex = 5;
            this.lblUnit.Text = "Unit #";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUnBlock
            // 
            this.btnUnBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnBlock.Location = new System.Drawing.Point(104, 281);
            this.btnUnBlock.Name = "btnUnBlock";
            this.btnUnBlock.Size = new System.Drawing.Size(311, 41);
            this.btnUnBlock.TabIndex = 2;
            this.btnUnBlock.Text = "Un-Block Now";
            this.btnUnBlock.UseVisualStyleBackColor = true;
            this.btnUnBlock.Click += new System.EventHandler(this.btnUnBlock_Click);
            // 
            // tpHashParking
            // 
            this.tpHashParking.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tpHashParking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpHashParking.Controls.Add(this.lblMasterUnit);
            this.tpHashParking.Controls.Add(this.btnHashParkingUpdate);
            this.tpHashParking.Controls.Add(this.txtHashParkingNumber);
            this.tpHashParking.Controls.Add(this.label17);
            this.tpHashParking.Controls.Add(this.label16);
            this.tpHashParking.Controls.Add(this.lvHashParkingList);
            this.tpHashParking.Location = new System.Drawing.Point(4, 26);
            this.tpHashParking.Name = "tpHashParking";
            this.tpHashParking.Padding = new System.Windows.Forms.Padding(3);
            this.tpHashParking.Size = new System.Drawing.Size(496, 322);
            this.tpHashParking.TabIndex = 2;
            this.tpHashParking.Text = "# Parking Update";
            this.tpHashParking.Enter += new System.EventHandler(this.tpHashParking_Enter);
            this.tpHashParking.Leave += new System.EventHandler(this.tpHashParking_Leave);
            // 
            // lblMasterUnit
            // 
            this.lblMasterUnit.AutoSize = true;
            this.lblMasterUnit.Location = new System.Drawing.Point(117, 293);
            this.lblMasterUnit.Name = "lblMasterUnit";
            this.lblMasterUnit.Size = new System.Drawing.Size(0, 14);
            this.lblMasterUnit.TabIndex = 4;
            // 
            // btnHashParkingUpdate
            // 
            this.btnHashParkingUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHashParkingUpdate.Location = new System.Drawing.Point(387, 289);
            this.btnHashParkingUpdate.Name = "btnHashParkingUpdate";
            this.btnHashParkingUpdate.Size = new System.Drawing.Size(103, 23);
            this.btnHashParkingUpdate.TabIndex = 2;
            this.btnHashParkingUpdate.Text = "Update";
            this.btnHashParkingUpdate.UseVisualStyleBackColor = true;
            this.btnHashParkingUpdate.Click += new System.EventHandler(this.btnHashParkingUpdate_Click);
            // 
            // txtHashParkingNumber
            // 
            this.txtHashParkingNumber.Location = new System.Drawing.Point(309, 289);
            this.txtHashParkingNumber.Name = "txtHashParkingNumber";
            this.txtHashParkingNumber.Size = new System.Drawing.Size(72, 22);
            this.txtHashParkingNumber.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 293);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 14);
            this.label17.TabIndex = 1;
            this.label17.Text = "Master Unit #:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(198, 293);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 14);
            this.label16.TabIndex = 1;
            this.label16.Text = "New Parking #:";
            // 
            // lvHashParkingList
            // 
            this.lvHashParkingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUnitId,
            this.colClientId,
            this.colClientName,
            this.colUnitNumber,
            this.colParkingNumber});
            this.lvHashParkingList.FullRowSelect = true;
            this.lvHashParkingList.GridLines = true;
            this.lvHashParkingList.HideSelection = false;
            this.lvHashParkingList.Location = new System.Drawing.Point(6, 6);
            this.lvHashParkingList.MultiSelect = false;
            this.lvHashParkingList.Name = "lvHashParkingList";
            this.lvHashParkingList.Size = new System.Drawing.Size(484, 277);
            this.lvHashParkingList.TabIndex = 0;
            this.lvHashParkingList.UseCompatibleStateImageBehavior = false;
            this.lvHashParkingList.View = System.Windows.Forms.View.Details;
            this.lvHashParkingList.SelectedIndexChanged += new System.EventHandler(this.lvHashParkingList_SelectedIndexChanged);
            // 
            // colUnitId
            // 
            this.colUnitId.Text = "UnitId";
            // 
            // colClientId
            // 
            this.colClientId.Text = "Client Id";
            this.colClientId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colClientId.Width = 120;
            // 
            // colClientName
            // 
            this.colClientName.Text = "Name";
            this.colClientName.Width = 120;
            // 
            // colUnitNumber
            // 
            this.colUnitNumber.Text = "Unit #";
            this.colUnitNumber.Width = 80;
            // 
            // colParkingNumber
            // 
            this.colParkingNumber.Text = "Parking #";
            this.colParkingNumber.Width = 80;
            // 
            // chkAutoExpand
            // 
            this.chkAutoExpand.AutoSize = true;
            this.chkAutoExpand.Checked = true;
            this.chkAutoExpand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoExpand.Location = new System.Drawing.Point(12, 394);
            this.chkAutoExpand.Name = "chkAutoExpand";
            this.chkAutoExpand.Size = new System.Drawing.Size(173, 18);
            this.chkAutoExpand.TabIndex = 5;
            this.chkAutoExpand.Text = "Auto-Expand Unit List";
            this.chkAutoExpand.UseVisualStyleBackColor = true;
            this.chkAutoExpand.CheckedChanged += new System.EventHandler(this.chkAutoExpand_CheckedChanged);
            // 
            // frmUnitInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(885, 443);
            this.Controls.Add(this.chkAutoExpand);
            this.Controls.Add(this.tcUnitData);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tvUnitDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUnitInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Information";
            this.Load += new System.EventHandler(this.frmUnitInformation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tcUnitData.ResumeLayout(false);
            this.tpUnit.ResumeLayout(false);
            this.tpUnit.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlBlock.ResumeLayout(false);
            this.pnlBlock.PerformLayout();
            this.tpHashParking.ResumeLayout(false);
            this.tpHashParking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbProjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUnitType;
        private System.Windows.Forms.ComboBox cmbFloorNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBuilding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTypeOfUnit;
        private System.Windows.Forms.Label lblUnitType;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFacing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView tvUnitDetails;
        private System.Windows.Forms.Label lblUnitNumber;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtUnitNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkIsCPAvailable;
        private System.Windows.Forms.CheckBox chkIsBlocked;
        private System.Windows.Forms.CheckBox chkIsSaleable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ImageList imgUnitInformation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.Button btnUnitDetailsReport;
        private System.Windows.Forms.ToolTip ttUnitInformation;
        private System.Windows.Forms.TabControl tcUnitData;
        private System.Windows.Forms.TabPage tpUnit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnUnBlock;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.TextBox txtBlockRemark;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpBlockEnd;
        private System.Windows.Forms.DateTimePicker dtpBlockStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView lvBlockingHistory;
        private System.Windows.Forms.ColumnHeader colBlockingId;
        private System.Windows.Forms.ColumnHeader colBlockedBy;
        private System.Windows.Forms.ColumnHeader colStartDate;
        private System.Windows.Forms.ColumnHeader colEndDate;
        private System.Windows.Forms.ColumnHeader colUnBlockedBy;
        private System.Windows.Forms.Panel pnlBlock;
        private System.Windows.Forms.ColumnHeader colRemarks;
        private System.Windows.Forms.Label lblCPHashWarning;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabPage tpHashParking;
        private System.Windows.Forms.ListView lvHashParkingList;
        private System.Windows.Forms.ColumnHeader colUnitId;
        private System.Windows.Forms.ColumnHeader colClientId;
        private System.Windows.Forms.ColumnHeader colClientName;
        private System.Windows.Forms.ColumnHeader colUnitNumber;
        private System.Windows.Forms.ColumnHeader colParkingNumber;
        private System.Windows.Forms.Button btnHashParkingUpdate;
        private System.Windows.Forms.TextBox txtHashParkingNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblMasterUnit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkAutoExpand;
    }
}