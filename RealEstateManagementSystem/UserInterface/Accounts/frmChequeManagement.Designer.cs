namespace RealEstateManagementSystem.UserInterface.Accounts
{
    partial class frmChequeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChequeManagement));
            this.ssChequeManagement = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lvResultSet = new System.Windows.Forms.ListView();
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkExcludeCashTransactions = new System.Windows.Forms.CheckBox();
            this.chkExcludeReceived = new System.Windows.Forms.CheckBox();
            this.rbDateRange = new System.Windows.Forms.RadioButton();
            this.rbBank = new System.Windows.Forms.RadioButton();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.rbInvoice = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlClientId = new System.Windows.Forms.Panel();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBank = new System.Windows.Forms.Panel();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlDateRange = new System.Windows.Forms.Panel();
            this.btnSearch_DateRange = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.btnModifyAlterReason = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnModifyCompanyBankAccount = new System.Windows.Forms.Button();
            this.cmbCompanyAccounts = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpStatusDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbAlterReason = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbInvoiceStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ttChequeManagement = new System.Windows.Forms.ToolTip(this.components);
            this.btnRealodSearch = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.ssChequeManagement.SuspendLayout();
            this.pnlInvoice.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlClientId.SuspendLayout();
            this.pnlBank.SuspendLayout();
            this.pnlDateRange.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssChequeManagement
            // 
            this.ssChequeManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.ssChequeManagement.Location = new System.Drawing.Point(0, 526);
            this.ssChequeManagement.Name = "ssChequeManagement";
            this.ssChequeManagement.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssChequeManagement.Size = new System.Drawing.Size(1047, 22);
            this.ssChequeManagement.SizingGrip = false;
            this.ssChequeManagement.TabIndex = 0;
            this.ssChequeManagement.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(1032, 17);
            this.tssStatus.Spring = true;
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInvoice.Controls.Add(this.txtInvoice);
            this.pnlInvoice.Controls.Add(this.label1);
            this.pnlInvoice.Location = new System.Drawing.Point(505, 21);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(169, 35);
            this.pnlInvoice.TabIndex = 1;
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(74, 6);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(89, 20);
            this.txtInvoice.TabIndex = 1;
            this.txtInvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice #";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPrintReport);
            this.panel2.Controls.Add(this.lblRecordCount);
            this.panel2.Controls.Add(this.lvResultSet);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 292);
            this.panel2.TabIndex = 2;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(3, 272);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(109, 13);
            this.lblRecordCount.TabIndex = 2;
            this.lblRecordCount.Text = "0 Record(s) Found";
            // 
            // lvResultSet
            // 
            this.lvResultSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStatus,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lvResultSet.FullRowSelect = true;
            this.lvResultSet.GridLines = true;
            this.lvResultSet.HideSelection = false;
            this.lvResultSet.Location = new System.Drawing.Point(8, 21);
            this.lvResultSet.Name = "lvResultSet";
            this.lvResultSet.Size = new System.Drawing.Size(1008, 245);
            this.lvResultSet.TabIndex = 1;
            this.lvResultSet.UseCompatibleStateImageBehavior = false;
            this.lvResultSet.View = System.Windows.Forms.View.Details;
            this.lvResultSet.SelectedIndexChanged += new System.EventHandler(this.lvResultSet_SelectedIndexChanged);
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Payment Mode";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Reason";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cleared?";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 59;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Invoice#";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 76;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Amount";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 81;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tr. Date";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 82;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "C/D/P #";
            this.columnHeader8.Width = 83;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "CQ. Date";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Bank";
            this.columnHeader10.Width = 76;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Remarks";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Deposited To";
            this.columnHeader12.Width = 93;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Deposited On";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Transaction Details";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnRealodSearch);
            this.panel3.Controls.Add(this.chkExcludeCashTransactions);
            this.panel3.Controls.Add(this.chkExcludeReceived);
            this.panel3.Controls.Add(this.rbDateRange);
            this.panel3.Controls.Add(this.rbBank);
            this.panel3.Controls.Add(this.rbClient);
            this.panel3.Controls.Add(this.rbInvoice);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(487, 52);
            this.panel3.TabIndex = 3;
            // 
            // chkExcludeCashTransactions
            // 
            this.chkExcludeCashTransactions.AutoSize = true;
            this.chkExcludeCashTransactions.Checked = true;
            this.chkExcludeCashTransactions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExcludeCashTransactions.Location = new System.Drawing.Point(270, 28);
            this.chkExcludeCashTransactions.Name = "chkExcludeCashTransactions";
            this.chkExcludeCashTransactions.Size = new System.Drawing.Size(170, 17);
            this.chkExcludeCashTransactions.TabIndex = 2;
            this.chkExcludeCashTransactions.Text = "Exclude Cash Transaction";
            this.chkExcludeCashTransactions.UseVisualStyleBackColor = true;
            // 
            // chkExcludeReceived
            // 
            this.chkExcludeReceived.AutoSize = true;
            this.chkExcludeReceived.Checked = true;
            this.chkExcludeReceived.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExcludeReceived.Location = new System.Drawing.Point(94, 28);
            this.chkExcludeReceived.Name = "chkExcludeReceived";
            this.chkExcludeReceived.Size = new System.Drawing.Size(170, 17);
            this.chkExcludeReceived.TabIndex = 2;
            this.chkExcludeReceived.Text = "Exclude Received Cheques";
            this.chkExcludeReceived.UseVisualStyleBackColor = true;
            // 
            // rbDateRange
            // 
            this.rbDateRange.AutoSize = true;
            this.rbDateRange.Location = new System.Drawing.Point(352, 5);
            this.rbDateRange.Name = "rbDateRange";
            this.rbDateRange.Size = new System.Drawing.Size(85, 17);
            this.rbDateRange.TabIndex = 1;
            this.rbDateRange.Text = "Date Range";
            this.rbDateRange.UseVisualStyleBackColor = true;
            this.rbDateRange.CheckedChanged += new System.EventHandler(this.rbDateRange_CheckedChanged);
            // 
            // rbBank
            // 
            this.rbBank.AutoSize = true;
            this.rbBank.Location = new System.Drawing.Point(280, 5);
            this.rbBank.Name = "rbBank";
            this.rbBank.Size = new System.Drawing.Size(49, 17);
            this.rbBank.TabIndex = 1;
            this.rbBank.Text = "Bank";
            this.rbBank.UseVisualStyleBackColor = true;
            this.rbBank.CheckedChanged += new System.EventHandler(this.rbBank_CheckedChanged);
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Location = new System.Drawing.Point(196, 5);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(61, 17);
            this.rbClient.TabIndex = 1;
            this.rbClient.Text = "Client";
            this.rbClient.UseVisualStyleBackColor = true;
            this.rbClient.CheckedChanged += new System.EventHandler(this.rbClient_CheckedChanged);
            // 
            // rbInvoice
            // 
            this.rbInvoice.AutoSize = true;
            this.rbInvoice.Checked = true;
            this.rbInvoice.Location = new System.Drawing.Point(94, 5);
            this.rbInvoice.Name = "rbInvoice";
            this.rbInvoice.Size = new System.Drawing.Size(79, 17);
            this.rbInvoice.TabIndex = 1;
            this.rbInvoice.TabStop = true;
            this.rbInvoice.Text = "Invoice #";
            this.rbInvoice.UseVisualStyleBackColor = true;
            this.rbInvoice.CheckedChanged += new System.EventHandler(this.rbInvoice_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search By ->";
            // 
            // pnlClientId
            // 
            this.pnlClientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClientId.Controls.Add(this.btnSearchClient);
            this.pnlClientId.Controls.Add(this.txtClientId);
            this.pnlClientId.Controls.Add(this.label4);
            this.pnlClientId.Location = new System.Drawing.Point(505, 21);
            this.pnlClientId.Name = "pnlClientId";
            this.pnlClientId.Size = new System.Drawing.Size(219, 35);
            this.pnlClientId.TabIndex = 4;
            this.pnlClientId.Visible = false;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchClient.FlatAppearance.BorderSize = 0;
            this.btnSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClient.Image = global::RealEstateManagementSystem.Properties.Resources.SearchClient;
            this.btnSearchClient.Location = new System.Drawing.Point(185, 6);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(26, 21);
            this.btnSearchClient.TabIndex = 2;
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(70, 6);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(109, 20);
            this.txtClientId.TabIndex = 1;
            this.txtClientId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClientId.Leave += new System.EventHandler(this.txtClientId_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Client Id:";
            // 
            // pnlBank
            // 
            this.pnlBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBank.Controls.Add(this.cmbBank);
            this.pnlBank.Controls.Add(this.label5);
            this.pnlBank.Location = new System.Drawing.Point(505, 21);
            this.pnlBank.Name = "pnlBank";
            this.pnlBank.Size = new System.Drawing.Size(321, 35);
            this.pnlBank.TabIndex = 5;
            this.pnlBank.Visible = false;
            // 
            // cmbBank
            // 
            this.cmbBank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(48, 6);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(268, 21);
            this.cmbBank.TabIndex = 1;
            this.cmbBank.SelectionChangeCommitted += new System.EventHandler(this.cmbBank_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bank:";
            // 
            // pnlDateRange
            // 
            this.pnlDateRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDateRange.Controls.Add(this.btnSearch_DateRange);
            this.pnlDateRange.Controls.Add(this.label7);
            this.pnlDateRange.Controls.Add(this.dtpEndDate);
            this.pnlDateRange.Controls.Add(this.dtpStartDate);
            this.pnlDateRange.Controls.Add(this.label6);
            this.pnlDateRange.Location = new System.Drawing.Point(505, 21);
            this.pnlDateRange.Name = "pnlDateRange";
            this.pnlDateRange.Size = new System.Drawing.Size(350, 35);
            this.pnlDateRange.TabIndex = 6;
            this.pnlDateRange.Visible = false;
            // 
            // btnSearch_DateRange
            // 
            this.btnSearch_DateRange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch_DateRange.FlatAppearance.BorderSize = 0;
            this.btnSearch_DateRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch_DateRange.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnSearch_DateRange.Image = global::RealEstateManagementSystem.Properties.Resources.search;
            this.btnSearch_DateRange.Location = new System.Drawing.Point(316, 5);
            this.btnSearch_DateRange.Name = "btnSearch_DateRange";
            this.btnSearch_DateRange.Size = new System.Drawing.Size(29, 23);
            this.btnSearch_DateRange.TabIndex = 8;
            this.btnSearch_DateRange.UseVisualStyleBackColor = true;
            this.btnSearch_DateRange.Click += new System.EventHandler(this.btnSearch_DateRange_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "to";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(208, 6);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(105, 20);
            this.dtpEndDate.TabIndex = 1;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(78, 6);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(105, 20);
            this.dtpStartDate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date Range:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangeStatus);
            this.panel1.Controls.Add(this.btnModifyAlterReason);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.cmbAlterReason);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbInvoiceStatus);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtInvoiceNumber);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 144);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeStatus.Location = new System.Drawing.Point(894, 88);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(122, 49);
            this.btnChangeStatus.TabIndex = 6;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // btnModifyAlterReason
            // 
            this.btnModifyAlterReason.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyAlterReason.Location = new System.Drawing.Point(983, 10);
            this.btnModifyAlterReason.Name = "btnModifyAlterReason";
            this.btnModifyAlterReason.Size = new System.Drawing.Size(33, 21);
            this.btnModifyAlterReason.TabIndex = 5;
            this.btnModifyAlterReason.Text = "...";
            this.btnModifyAlterReason.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnModifyCompanyBankAccount);
            this.panel4.Controls.Add(this.cmbCompanyAccounts);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.dtpStatusDate);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(113, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(903, 36);
            this.panel4.TabIndex = 4;
            // 
            // btnModifyCompanyBankAccount
            // 
            this.btnModifyCompanyBankAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyCompanyBankAccount.Location = new System.Drawing.Point(863, 6);
            this.btnModifyCompanyBankAccount.Name = "btnModifyCompanyBankAccount";
            this.btnModifyCompanyBankAccount.Size = new System.Drawing.Size(33, 21);
            this.btnModifyCompanyBankAccount.TabIndex = 6;
            this.btnModifyCompanyBankAccount.Text = "...";
            this.btnModifyCompanyBankAccount.UseVisualStyleBackColor = true;
            // 
            // cmbCompanyAccounts
            // 
            this.cmbCompanyAccounts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCompanyAccounts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCompanyAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyAccounts.FormattingEnabled = true;
            this.cmbCompanyAccounts.Location = new System.Drawing.Point(327, 6);
            this.cmbCompanyAccounts.Name = "cmbCompanyAccounts";
            this.cmbCompanyAccounts.Size = new System.Drawing.Size(530, 21);
            this.cmbCompanyAccounts.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(206, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Company Account #:";
            // 
            // dtpStatusDate
            // 
            this.dtpStatusDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpStatusDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStatusDate.Location = new System.Drawing.Point(87, 6);
            this.dtpStatusDate.Name = "dtpStatusDate";
            this.dtpStatusDate.Size = new System.Drawing.Size(115, 20);
            this.dtpStatusDate.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Status Date:";
            // 
            // cmbAlterReason
            // 
            this.cmbAlterReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAlterReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAlterReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlterReason.FormattingEnabled = true;
            this.cmbAlterReason.Location = new System.Drawing.Point(570, 10);
            this.cmbAlterReason.Name = "cmbAlterReason";
            this.cmbAlterReason.Size = new System.Drawing.Size(407, 21);
            this.cmbAlterReason.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Alter Reason:";
            // 
            // cmbInvoiceStatus
            // 
            this.cmbInvoiceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvoiceStatus.FormattingEnabled = true;
            this.cmbInvoiceStatus.Location = new System.Drawing.Point(322, 10);
            this.cmbInvoiceStatus.Name = "cmbInvoiceStatus";
            this.cmbInvoiceStatus.Size = new System.Drawing.Size(147, 21);
            this.cmbInvoiceStatus.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Invoice Status:";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(86, 10);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.ReadOnly = true;
            this.txtInvoiceNumber.Size = new System.Drawing.Size(124, 20);
            this.txtInvoiceNumber.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Invoice #";
            // 
            // btnRealodSearch
            // 
            this.btnRealodSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealodSearch.FlatAppearance.BorderSize = 0;
            this.btnRealodSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealodSearch.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnRealodSearch.Image = global::RealEstateManagementSystem.Properties.Resources.refresh;
            this.btnRealodSearch.Location = new System.Drawing.Point(446, 13);
            this.btnRealodSearch.Name = "btnRealodSearch";
            this.btnRealodSearch.Size = new System.Drawing.Size(29, 23);
            this.btnRealodSearch.TabIndex = 9;
            this.ttChequeManagement.SetToolTip(this.btnRealodSearch, "Reload");
            this.btnRealodSearch.UseVisualStyleBackColor = true;
            this.btnRealodSearch.Click += new System.EventHandler(this.btnRealodSearch_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReport.FlatAppearance.BorderSize = 0;
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReport.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnPrintReport.Image = global::RealEstateManagementSystem.Properties.Resources.printer;
            this.btnPrintReport.Location = new System.Drawing.Point(987, 267);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(29, 23);
            this.btnPrintReport.TabIndex = 9;
            this.ttChequeManagement.SetToolTip(this.btnPrintReport, "Print this list");
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // frmChequeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ssChequeManagement);
            this.Controls.Add(this.pnlInvoice);
            this.Controls.Add(this.pnlDateRange);
            this.Controls.Add(this.pnlClientId);
            this.Controls.Add(this.pnlBank);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChequeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheque Management";
            this.Load += new System.EventHandler(this.frmChequeManagement_Load);
            this.ssChequeManagement.ResumeLayout(false);
            this.ssChequeManagement.PerformLayout();
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoice.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlClientId.ResumeLayout(false);
            this.pnlClientId.PerformLayout();
            this.pnlBank.ResumeLayout(false);
            this.pnlBank.PerformLayout();
            this.pnlDateRange.ResumeLayout(false);
            this.pnlDateRange.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssChequeManagement;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvResultSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbDateRange;
        private System.Windows.Forms.RadioButton rbBank;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.RadioButton rbInvoice;
        private System.Windows.Forms.Panel pnlClientId;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Panel pnlBank;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlDateRange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch_DateRange;
        private System.Windows.Forms.CheckBox chkExcludeCashTransactions;
        private System.Windows.Forms.CheckBox chkExcludeReceived;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAlterReason;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbInvoiceStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnModifyAlterReason;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpStatusDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip ttChequeManagement;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Button btnModifyCompanyBankAccount;
        private System.Windows.Forms.ComboBox cmbCompanyAccounts;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button btnRealodSearch;
        private System.Windows.Forms.Button btnPrintReport;
    }
}