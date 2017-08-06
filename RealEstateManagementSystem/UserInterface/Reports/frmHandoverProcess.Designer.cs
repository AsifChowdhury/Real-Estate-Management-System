namespace RealEstateManagementSystem.UserInterface.Reports
{
    partial class frmHandoverProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHandoverProcess));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPaymentClearance = new System.Windows.Forms.RadioButton();
            this.rbListOfKeys = new System.Windows.Forms.RadioButton();
            this.rbHandoverCertificate = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGetCertificate = new System.Windows.Forms.Button();
            this.pnlPaymentClearance = new System.Windows.Forms.Panel();
            this.cmbPC_RecommendedBy = new System.Windows.Forms.ComboBox();
            this.cmbPC_CheckedBy = new System.Windows.Forms.ComboBox();
            this.cmbPC_VerifiedBy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPaymentClearance = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlListOfKeys = new System.Windows.Forms.Panel();
            this.pbKeyList = new System.Windows.Forms.PictureBox();
            this.cmbKey_ProjectEngineer = new System.Windows.Forms.ComboBox();
            this.dtpKeysDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlHandover = new System.Windows.Forms.Panel();
            this.pbHandover = new System.Windows.Forms.PictureBox();
            this.cmbHO_RecommendedBy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbHO_ForwardedBy = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbHO_HandoverBy = new System.Windows.Forms.ComboBox();
            this.dtpHandoverDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPaymentClearance.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlListOfKeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKeyList)).BeginInit();
            this.pnlHandover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHandover)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtClientId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(100, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 41);
            this.panel1.TabIndex = 0;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(71, 9);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.ReadOnly = true;
            this.txtClientId.Size = new System.Drawing.Size(166, 20);
            this.txtClientId.TabIndex = 2;
            this.txtClientId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Id:";
            // 
            // rbPaymentClearance
            // 
            this.rbPaymentClearance.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPaymentClearance.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPaymentClearance.Checked = true;
            this.rbPaymentClearance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPaymentClearance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPaymentClearance.Location = new System.Drawing.Point(11, 10);
            this.rbPaymentClearance.Name = "rbPaymentClearance";
            this.rbPaymentClearance.Size = new System.Drawing.Size(207, 31);
            this.rbPaymentClearance.TabIndex = 0;
            this.rbPaymentClearance.TabStop = true;
            this.rbPaymentClearance.Text = "(QF-REC-04) Payment Clearance";
            this.rbPaymentClearance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPaymentClearance.UseVisualStyleBackColor = true;
            this.rbPaymentClearance.CheckedChanged += new System.EventHandler(this.rbPaymentClearance_CheckedChanged);
            // 
            // rbListOfKeys
            // 
            this.rbListOfKeys.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbListOfKeys.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbListOfKeys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbListOfKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbListOfKeys.Location = new System.Drawing.Point(224, 10);
            this.rbListOfKeys.Name = "rbListOfKeys";
            this.rbListOfKeys.Size = new System.Drawing.Size(207, 31);
            this.rbListOfKeys.TabIndex = 0;
            this.rbListOfKeys.TabStop = true;
            this.rbListOfKeys.Text = "(QF-REC-06) List of Keys";
            this.rbListOfKeys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbListOfKeys.UseVisualStyleBackColor = true;
            this.rbListOfKeys.CheckedChanged += new System.EventHandler(this.rbListOfKeys_CheckedChanged);
            // 
            // rbHandoverCertificate
            // 
            this.rbHandoverCertificate.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbHandoverCertificate.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbHandoverCertificate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbHandoverCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbHandoverCertificate.Location = new System.Drawing.Point(98, 47);
            this.rbHandoverCertificate.Name = "rbHandoverCertificate";
            this.rbHandoverCertificate.Size = new System.Drawing.Size(245, 31);
            this.rbHandoverCertificate.TabIndex = 0;
            this.rbHandoverCertificate.TabStop = true;
            this.rbHandoverCertificate.Text = "(QF-REC-05) Handover Certificate";
            this.rbHandoverCertificate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbHandoverCertificate.UseVisualStyleBackColor = true;
            this.rbHandoverCertificate.CheckedChanged += new System.EventHandler(this.rbHandoverCertificate_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbHandoverCertificate);
            this.panel2.Controls.Add(this.rbListOfKeys);
            this.panel2.Controls.Add(this.rbPaymentClearance);
            this.panel2.Location = new System.Drawing.Point(12, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 86);
            this.panel2.TabIndex = 1;
            // 
            // btnGetCertificate
            // 
            this.btnGetCertificate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetCertificate.Image = global::RealEstateManagementSystem.Properties.Resources.printer;
            this.btnGetCertificate.Location = new System.Drawing.Point(309, 152);
            this.btnGetCertificate.Name = "btnGetCertificate";
            this.btnGetCertificate.Size = new System.Drawing.Size(146, 52);
            this.btnGetCertificate.TabIndex = 2;
            this.btnGetCertificate.Text = "Get Certificate";
            this.btnGetCertificate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGetCertificate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGetCertificate.UseVisualStyleBackColor = true;
            this.btnGetCertificate.Click += new System.EventHandler(this.btnGetCertificate_Click);
            // 
            // pnlPaymentClearance
            // 
            this.pnlPaymentClearance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaymentClearance.Controls.Add(this.cmbPC_RecommendedBy);
            this.pnlPaymentClearance.Controls.Add(this.cmbPC_CheckedBy);
            this.pnlPaymentClearance.Controls.Add(this.cmbPC_VerifiedBy);
            this.pnlPaymentClearance.Controls.Add(this.label4);
            this.pnlPaymentClearance.Controls.Add(this.label3);
            this.pnlPaymentClearance.Controls.Add(this.label2);
            this.pnlPaymentClearance.Controls.Add(this.lstPaymentClearance);
            this.pnlPaymentClearance.Controls.Add(this.shapeContainer1);
            this.pnlPaymentClearance.Location = new System.Drawing.Point(12, 210);
            this.pnlPaymentClearance.Name = "pnlPaymentClearance";
            this.pnlPaymentClearance.Size = new System.Drawing.Size(443, 309);
            this.pnlPaymentClearance.TabIndex = 3;
            // 
            // cmbPC_RecommendedBy
            // 
            this.cmbPC_RecommendedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPC_RecommendedBy.FormattingEnabled = true;
            this.cmbPC_RecommendedBy.Location = new System.Drawing.Point(108, 280);
            this.cmbPC_RecommendedBy.Name = "cmbPC_RecommendedBy";
            this.cmbPC_RecommendedBy.Size = new System.Drawing.Size(322, 21);
            this.cmbPC_RecommendedBy.TabIndex = 3;
            // 
            // cmbPC_CheckedBy
            // 
            this.cmbPC_CheckedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPC_CheckedBy.FormattingEnabled = true;
            this.cmbPC_CheckedBy.Location = new System.Drawing.Point(108, 253);
            this.cmbPC_CheckedBy.Name = "cmbPC_CheckedBy";
            this.cmbPC_CheckedBy.Size = new System.Drawing.Size(322, 21);
            this.cmbPC_CheckedBy.TabIndex = 3;
            // 
            // cmbPC_VerifiedBy
            // 
            this.cmbPC_VerifiedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPC_VerifiedBy.FormattingEnabled = true;
            this.cmbPC_VerifiedBy.Location = new System.Drawing.Point(108, 226);
            this.cmbPC_VerifiedBy.Name = "cmbPC_VerifiedBy";
            this.cmbPC_VerifiedBy.Size = new System.Drawing.Size(322, 21);
            this.cmbPC_VerifiedBy.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Recommended By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Checked By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Verified By:";
            // 
            // lstPaymentClearance
            // 
            this.lstPaymentClearance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstPaymentClearance.FullRowSelect = true;
            this.lstPaymentClearance.GridLines = true;
            this.lstPaymentClearance.Location = new System.Drawing.Point(3, 3);
            this.lstPaymentClearance.Name = "lstPaymentClearance";
            this.lstPaymentClearance.Size = new System.Drawing.Size(437, 211);
            this.lstPaymentClearance.TabIndex = 0;
            this.lstPaymentClearance.UseCompatibleStateImageBehavior = false;
            this.lstPaymentClearance.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Payment Type";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Payable";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Paid";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Balance";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 99;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(441, 307);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -5;
            this.lineShape1.X2 = 457;
            this.lineShape1.Y1 = 220;
            this.lineShape1.Y2 = 220;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(467, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(452, 17);
            this.tssStatus.Spring = true;
            this.tssStatus.Text = "Ready";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlListOfKeys
            // 
            this.pnlListOfKeys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListOfKeys.Controls.Add(this.pbKeyList);
            this.pnlListOfKeys.Controls.Add(this.cmbKey_ProjectEngineer);
            this.pnlListOfKeys.Controls.Add(this.dtpKeysDate);
            this.pnlListOfKeys.Controls.Add(this.label6);
            this.pnlListOfKeys.Controls.Add(this.label5);
            this.pnlListOfKeys.Location = new System.Drawing.Point(12, 210);
            this.pnlListOfKeys.Name = "pnlListOfKeys";
            this.pnlListOfKeys.Size = new System.Drawing.Size(443, 68);
            this.pnlListOfKeys.TabIndex = 5;
            this.pnlListOfKeys.Visible = false;
            // 
            // pbKeyList
            // 
            this.pbKeyList.Image = global::RealEstateManagementSystem.Properties.Resources.update;
            this.pbKeyList.InitialImage = global::RealEstateManagementSystem.Properties.Resources.update;
            this.pbKeyList.Location = new System.Drawing.Point(412, 7);
            this.pbKeyList.Name = "pbKeyList";
            this.pbKeyList.Size = new System.Drawing.Size(18, 18);
            this.pbKeyList.TabIndex = 15;
            this.pbKeyList.TabStop = false;
            // 
            // cmbKey_ProjectEngineer
            // 
            this.cmbKey_ProjectEngineer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKey_ProjectEngineer.FormattingEnabled = true;
            this.cmbKey_ProjectEngineer.Location = new System.Drawing.Point(127, 36);
            this.cmbKey_ProjectEngineer.Name = "cmbKey_ProjectEngineer";
            this.cmbKey_ProjectEngineer.Size = new System.Drawing.Size(304, 21);
            this.cmbKey_ProjectEngineer.TabIndex = 5;
            // 
            // dtpKeysDate
            // 
            this.dtpKeysDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpKeysDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKeysDate.Location = new System.Drawing.Point(127, 10);
            this.dtpKeysDate.Name = "dtpKeysDate";
            this.dtpKeysDate.Size = new System.Drawing.Size(105, 20);
            this.dtpKeysDate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Project Engineer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date:";
            // 
            // pnlHandover
            // 
            this.pnlHandover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHandover.Controls.Add(this.pbHandover);
            this.pnlHandover.Controls.Add(this.cmbHO_RecommendedBy);
            this.pnlHandover.Controls.Add(this.label10);
            this.pnlHandover.Controls.Add(this.cmbHO_ForwardedBy);
            this.pnlHandover.Controls.Add(this.label9);
            this.pnlHandover.Controls.Add(this.cmbHO_HandoverBy);
            this.pnlHandover.Controls.Add(this.dtpHandoverDate);
            this.pnlHandover.Controls.Add(this.label7);
            this.pnlHandover.Controls.Add(this.label8);
            this.pnlHandover.Location = new System.Drawing.Point(12, 210);
            this.pnlHandover.Name = "pnlHandover";
            this.pnlHandover.Size = new System.Drawing.Size(443, 122);
            this.pnlHandover.TabIndex = 6;
            this.pnlHandover.Visible = false;
            // 
            // pbHandover
            // 
            this.pbHandover.Image = global::RealEstateManagementSystem.Properties.Resources.update;
            this.pbHandover.InitialImage = global::RealEstateManagementSystem.Properties.Resources.update;
            this.pbHandover.Location = new System.Drawing.Point(410, 7);
            this.pbHandover.Name = "pbHandover";
            this.pbHandover.Size = new System.Drawing.Size(18, 17);
            this.pbHandover.TabIndex = 14;
            this.pbHandover.TabStop = false;
            // 
            // cmbHO_RecommendedBy
            // 
            this.cmbHO_RecommendedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHO_RecommendedBy.FormattingEnabled = true;
            this.cmbHO_RecommendedBy.Location = new System.Drawing.Point(110, 88);
            this.cmbHO_RecommendedBy.Name = "cmbHO_RecommendedBy";
            this.cmbHO_RecommendedBy.Size = new System.Drawing.Size(320, 21);
            this.cmbHO_RecommendedBy.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Recommended By:";
            // 
            // cmbHO_ForwardedBy
            // 
            this.cmbHO_ForwardedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHO_ForwardedBy.FormattingEnabled = true;
            this.cmbHO_ForwardedBy.Location = new System.Drawing.Point(110, 61);
            this.cmbHO_ForwardedBy.Name = "cmbHO_ForwardedBy";
            this.cmbHO_ForwardedBy.Size = new System.Drawing.Size(320, 21);
            this.cmbHO_ForwardedBy.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Forwarded By:";
            // 
            // cmbHO_HandoverBy
            // 
            this.cmbHO_HandoverBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHO_HandoverBy.FormattingEnabled = true;
            this.cmbHO_HandoverBy.Location = new System.Drawing.Point(110, 34);
            this.cmbHO_HandoverBy.Name = "cmbHO_HandoverBy";
            this.cmbHO_HandoverBy.Size = new System.Drawing.Size(320, 21);
            this.cmbHO_HandoverBy.TabIndex = 9;
            // 
            // dtpHandoverDate
            // 
            this.dtpHandoverDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpHandoverDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHandoverDate.Location = new System.Drawing.Point(110, 8);
            this.dtpHandoverDate.Name = "dtpHandoverDate";
            this.dtpHandoverDate.Size = new System.Drawing.Size(105, 20);
            this.dtpHandoverDate.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Handover By:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date:";
            // 
            // frmHandoverProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 552);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGetCertificate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlListOfKeys);
            this.Controls.Add(this.pnlPaymentClearance);
            this.Controls.Add(this.pnlHandover);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHandoverProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handover Process";
            this.Load += new System.EventHandler(this.frmHandoverProcess_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlPaymentClearance.ResumeLayout(false);
            this.pnlPaymentClearance.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlListOfKeys.ResumeLayout(false);
            this.pnlListOfKeys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKeyList)).EndInit();
            this.pnlHandover.ResumeLayout(false);
            this.pnlHandover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHandover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPaymentClearance;
        private System.Windows.Forms.RadioButton rbListOfKeys;
        private System.Windows.Forms.RadioButton rbHandoverCertificate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGetCertificate;
        private System.Windows.Forms.Panel pnlPaymentClearance;
        private System.Windows.Forms.ComboBox cmbPC_RecommendedBy;
        private System.Windows.Forms.ComboBox cmbPC_CheckedBy;
        private System.Windows.Forms.ComboBox cmbPC_VerifiedBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstPaymentClearance;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.Panel pnlListOfKeys;
        private System.Windows.Forms.ComboBox cmbKey_ProjectEngineer;
        private System.Windows.Forms.DateTimePicker dtpKeysDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlHandover;
        private System.Windows.Forms.ComboBox cmbHO_RecommendedBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbHO_ForwardedBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbHO_HandoverBy;
        private System.Windows.Forms.DateTimePicker dtpHandoverDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbKeyList;
        private System.Windows.Forms.PictureBox pbHandover;
    }
}