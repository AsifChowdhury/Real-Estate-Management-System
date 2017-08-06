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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChequeManagement));
            this.ssChequeManagement = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colInvoiceNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTransactionStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnitNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPaymentMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTransactionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmountPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colParticulars = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colParticularsDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBankInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.chkExcludeReceived = new System.Windows.Forms.CheckBox();
            this.chkExcludeCashTransactions = new System.Windows.Forms.CheckBox();
            this.colClientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ssChequeManagement.SuspendLayout();
            this.pnlInvoice.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlClientId.SuspendLayout();
            this.pnlBank.SuspendLayout();
            this.pnlDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssChequeManagement
            // 
            this.ssChequeManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.ssChequeManagement.Location = new System.Drawing.Point(0, 553);
            this.ssChequeManagement.Name = "ssChequeManagement";
            this.ssChequeManagement.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssChequeManagement.Size = new System.Drawing.Size(1140, 22);
            this.ssChequeManagement.SizingGrip = false;
            this.ssChequeManagement.TabIndex = 0;
            this.ssChequeManagement.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(1125, 17);
            this.tssStatus.Spring = true;
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInvoice.Controls.Add(this.txtInvoice);
            this.pnlInvoice.Controls.Add(this.label1);
            this.pnlInvoice.Location = new System.Drawing.Point(478, 21);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(216, 35);
            this.pnlInvoice.TabIndex = 1;
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(74, 6);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(130, 20);
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
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 292);
            this.panel2.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colInvoiceNumber,
            this.colTransactionStatus,
            this.colClientId,
            this.colClientName,
            this.colUnitNumber,
            this.colPaymentMode,
            this.colTransactionDate,
            this.colAmountPaid,
            this.colParticulars,
            this.colParticularsDate,
            this.colBankInfo});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1103, 266);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colInvoiceNumber
            // 
            this.colInvoiceNumber.Text = "Invoice #";
            this.colInvoiceNumber.Width = 83;
            // 
            // colTransactionStatus
            // 
            this.colTransactionStatus.Text = "Status";
            this.colTransactionStatus.Width = 104;
            // 
            // colClientName
            // 
            this.colClientName.Text = "Name";
            this.colClientName.Width = 116;
            // 
            // colUnitNumber
            // 
            this.colUnitNumber.Text = "Unit #";
            this.colUnitNumber.Width = 108;
            // 
            // colPaymentMode
            // 
            this.colPaymentMode.Text = "Mode";
            this.colPaymentMode.Width = 86;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Text = "Transaction Date";
            this.colTransactionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTransactionDate.Width = 121;
            // 
            // colAmountPaid
            // 
            this.colAmountPaid.Text = "Amount Paid";
            this.colAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colAmountPaid.Width = 100;
            // 
            // colParticulars
            // 
            this.colParticulars.Text = "Particulars";
            this.colParticulars.Width = 116;
            // 
            // colParticularsDate
            // 
            this.colParticularsDate.Text = "CQ Date";
            this.colParticularsDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colParticularsDate.Width = 114;
            // 
            // colBankInfo
            // 
            this.colBankInfo.Text = "Bank Info";
            this.colBankInfo.Width = 132;
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
            this.panel3.Controls.Add(this.chkExcludeCashTransactions);
            this.panel3.Controls.Add(this.chkExcludeReceived);
            this.panel3.Controls.Add(this.rbDateRange);
            this.panel3.Controls.Add(this.rbBank);
            this.panel3.Controls.Add(this.rbClient);
            this.panel3.Controls.Add(this.rbInvoice);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 52);
            this.panel3.TabIndex = 3;
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
            this.pnlClientId.Location = new System.Drawing.Point(478, 21);
            this.pnlClientId.Name = "pnlClientId";
            this.pnlClientId.Size = new System.Drawing.Size(219, 35);
            this.pnlClientId.TabIndex = 4;
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
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(70, 6);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(109, 20);
            this.txtClientId.TabIndex = 1;
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
            this.pnlBank.Location = new System.Drawing.Point(478, 21);
            this.pnlBank.Name = "pnlBank";
            this.pnlBank.Size = new System.Drawing.Size(321, 35);
            this.pnlBank.TabIndex = 5;
            this.pnlBank.Visible = false;
            // 
            // cmbBank
            // 
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
            this.pnlDateRange.Location = new System.Drawing.Point(478, 21);
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
            // chkExcludeReceived
            // 
            this.chkExcludeReceived.AutoSize = true;
            this.chkExcludeReceived.Location = new System.Drawing.Point(94, 28);
            this.chkExcludeReceived.Name = "chkExcludeReceived";
            this.chkExcludeReceived.Size = new System.Drawing.Size(170, 17);
            this.chkExcludeReceived.TabIndex = 2;
            this.chkExcludeReceived.Text = "Exclude Received Cheques";
            this.chkExcludeReceived.UseVisualStyleBackColor = true;
            // 
            // chkExcludeCashTransactions
            // 
            this.chkExcludeCashTransactions.AutoSize = true;
            this.chkExcludeCashTransactions.Location = new System.Drawing.Point(270, 28);
            this.chkExcludeCashTransactions.Name = "chkExcludeCashTransactions";
            this.chkExcludeCashTransactions.Size = new System.Drawing.Size(170, 17);
            this.chkExcludeCashTransactions.TabIndex = 2;
            this.chkExcludeCashTransactions.Text = "Exclude Cash Transaction";
            this.chkExcludeCashTransactions.UseVisualStyleBackColor = true;
            // 
            // colClientId
            // 
            this.colClientId.Text = "ClinetId";
            this.colClientId.Width = 81;
            // 
            // frmChequeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 575);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ssChequeManagement);
            this.Controls.Add(this.pnlInvoice);
            this.Controls.Add(this.pnlBank);
            this.Controls.Add(this.pnlDateRange);
            this.Controls.Add(this.pnlClientId);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colInvoiceNumber;
        private System.Windows.Forms.ColumnHeader colTransactionStatus;
        private System.Windows.Forms.ColumnHeader colClientName;
        private System.Windows.Forms.ColumnHeader colUnitNumber;
        private System.Windows.Forms.ColumnHeader colPaymentMode;
        private System.Windows.Forms.ColumnHeader colTransactionDate;
        private System.Windows.Forms.ColumnHeader colAmountPaid;
        private System.Windows.Forms.ColumnHeader colParticulars;
        private System.Windows.Forms.ColumnHeader colParticularsDate;
        private System.Windows.Forms.ColumnHeader colBankInfo;
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
        private System.Windows.Forms.ColumnHeader colClientId;
    }
}