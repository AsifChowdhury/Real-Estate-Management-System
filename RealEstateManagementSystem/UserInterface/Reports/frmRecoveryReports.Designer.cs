namespace RealEstateManagementSystem.UserInterface.Reports
{
    partial class frmRecoveryReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecoveryReports));
            this.rbProjectValuation = new System.Windows.Forms.RadioButton();
            this.dtpProjectValuation = new System.Windows.Forms.DateTimePicker();
            this.rbMonthlyRecoveryPosition = new System.Windows.Forms.RadioButton();
            this.dtpMonthlyRecoveryPosition = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMRP_Analysis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbAnnualRecoveryPosition = new System.Windows.Forms.RadioButton();
            this.rbAnnualAgreementList = new System.Windows.Forms.RadioButton();
            this.rbRefundAmountFrom = new System.Windows.Forms.RadioButton();
            this.rbTransactionSummary = new System.Windows.Forms.RadioButton();
            this.rbComparePaymentStatus = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMRP_ActualReceivable = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMRP_ActualReceived = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMRP_AmountRefund = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMRP_Target = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMRP_OutstandingInstallment = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtMRP_OutstandingBDPayment = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMRP_Total = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvSalesYears = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rbRefundAmountBetween = new System.Windows.Forms.RadioButton();
            this.rbRegistrationCompleted = new System.Windows.Forms.RadioButton();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lvProjects = new System.Windows.Forms.ListView();
            this.lvProjectStatus = new System.Windows.Forms.ListView();
            this.label31 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.nudMaximumAmount = new System.Windows.Forms.NumericUpDown();
            this.nudMinimumAmount = new System.Windows.Forms.NumericUpDown();
            this.rbCurrentDue = new System.Windows.Forms.RadioButton();
            this.label28 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rbRecoveryPosition = new System.Windows.Forms.RadioButton();
            this.lblProjectCount = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtpTransactionSummary = new System.Windows.Forms.DateTimePicker();
            this.cmbInstallments = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumAmount)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbProjectValuation
            // 
            this.rbProjectValuation.AutoSize = true;
            this.rbProjectValuation.Checked = true;
            this.rbProjectValuation.Location = new System.Drawing.Point(5, 7);
            this.rbProjectValuation.Name = "rbProjectValuation";
            this.rbProjectValuation.Size = new System.Drawing.Size(283, 17);
            this.rbProjectValuation.TabIndex = 0;
            this.rbProjectValuation.TabStop = true;
            this.rbProjectValuation.Text = "Project Valuation (Amount Received Before):";
            this.rbProjectValuation.UseVisualStyleBackColor = true;
            this.rbProjectValuation.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // dtpProjectValuation
            // 
            this.dtpProjectValuation.CustomFormat = "dd/MMM/yyyy";
            this.dtpProjectValuation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProjectValuation.Location = new System.Drawing.Point(292, 5);
            this.dtpProjectValuation.Name = "dtpProjectValuation";
            this.dtpProjectValuation.Size = new System.Drawing.Size(113, 20);
            this.dtpProjectValuation.TabIndex = 1;
            // 
            // rbMonthlyRecoveryPosition
            // 
            this.rbMonthlyRecoveryPosition.AutoSize = true;
            this.rbMonthlyRecoveryPosition.Location = new System.Drawing.Point(5, 7);
            this.rbMonthlyRecoveryPosition.Name = "rbMonthlyRecoveryPosition";
            this.rbMonthlyRecoveryPosition.Size = new System.Drawing.Size(253, 17);
            this.rbMonthlyRecoveryPosition.TabIndex = 0;
            this.rbMonthlyRecoveryPosition.Text = "(QF-REC-08) Monthly Recovery Position:";
            this.rbMonthlyRecoveryPosition.UseVisualStyleBackColor = true;
            this.rbMonthlyRecoveryPosition.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // dtpMonthlyRecoveryPosition
            // 
            this.dtpMonthlyRecoveryPosition.CustomFormat = "MMMM - yyyy";
            this.dtpMonthlyRecoveryPosition.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonthlyRecoveryPosition.Location = new System.Drawing.Point(125, 30);
            this.dtpMonthlyRecoveryPosition.Name = "dtpMonthlyRecoveryPosition";
            this.dtpMonthlyRecoveryPosition.Size = new System.Drawing.Size(135, 20);
            this.dtpMonthlyRecoveryPosition.TabIndex = 1;
            this.dtpMonthlyRecoveryPosition.ValueChanged += new System.EventHandler(this.dtpMonthlyRecoveryPosition_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "For the Month of:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Analysis:";
            // 
            // txtMRP_Analysis
            // 
            this.txtMRP_Analysis.Location = new System.Drawing.Point(266, 23);
            this.txtMRP_Analysis.Multiline = true;
            this.txtMRP_Analysis.Name = "txtMRP_Analysis";
            this.txtMRP_Analysis.Size = new System.Drawing.Size(184, 159);
            this.txtMRP_Analysis.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Actual Receivable:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Actual Received:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount Refunded:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Target:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Outstanding:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Installment:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "B/D Payment:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Total:";
            // 
            // rbAnnualRecoveryPosition
            // 
            this.rbAnnualRecoveryPosition.AutoSize = true;
            this.rbAnnualRecoveryPosition.Location = new System.Drawing.Point(5, 7);
            this.rbAnnualRecoveryPosition.Name = "rbAnnualRecoveryPosition";
            this.rbAnnualRecoveryPosition.Size = new System.Drawing.Size(169, 17);
            this.rbAnnualRecoveryPosition.TabIndex = 0;
            this.rbAnnualRecoveryPosition.TabStop = true;
            this.rbAnnualRecoveryPosition.Text = "Annual Recovery Position";
            this.rbAnnualRecoveryPosition.UseVisualStyleBackColor = true;
            this.rbAnnualRecoveryPosition.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbAnnualAgreementList
            // 
            this.rbAnnualAgreementList.AutoSize = true;
            this.rbAnnualAgreementList.Location = new System.Drawing.Point(5, 31);
            this.rbAnnualAgreementList.Name = "rbAnnualAgreementList";
            this.rbAnnualAgreementList.Size = new System.Drawing.Size(151, 17);
            this.rbAnnualAgreementList.TabIndex = 1;
            this.rbAnnualAgreementList.TabStop = true;
            this.rbAnnualAgreementList.Text = "Annual Agreement List";
            this.rbAnnualAgreementList.UseVisualStyleBackColor = true;
            this.rbAnnualAgreementList.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbRefundAmountFrom
            // 
            this.rbRefundAmountFrom.AutoSize = true;
            this.rbRefundAmountFrom.Location = new System.Drawing.Point(5, 6);
            this.rbRefundAmountFrom.Name = "rbRefundAmountFrom";
            this.rbRefundAmountFrom.Size = new System.Drawing.Size(133, 17);
            this.rbRefundAmountFrom.TabIndex = 0;
            this.rbRefundAmountFrom.TabStop = true;
            this.rbRefundAmountFrom.Text = "Refund Amount from";
            this.rbRefundAmountFrom.UseVisualStyleBackColor = true;
            this.rbRefundAmountFrom.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbTransactionSummary
            // 
            this.rbTransactionSummary.AutoSize = true;
            this.rbTransactionSummary.Location = new System.Drawing.Point(7, 6);
            this.rbTransactionSummary.Name = "rbTransactionSummary";
            this.rbTransactionSummary.Size = new System.Drawing.Size(241, 17);
            this.rbTransactionSummary.TabIndex = 0;
            this.rbTransactionSummary.TabStop = true;
            this.rbTransactionSummary.Text = "Transaction summary for the Month of";
            this.rbTransactionSummary.UseVisualStyleBackColor = true;
            this.rbTransactionSummary.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbComparePaymentStatus
            // 
            this.rbComparePaymentStatus.AutoSize = true;
            this.rbComparePaymentStatus.Location = new System.Drawing.Point(5, 6);
            this.rbComparePaymentStatus.Name = "rbComparePaymentStatus";
            this.rbComparePaymentStatus.Size = new System.Drawing.Size(157, 17);
            this.rbComparePaymentStatus.TabIndex = 0;
            this.rbComparePaymentStatus.Text = "Compare Payment Status";
            this.rbComparePaymentStatus.UseVisualStyleBackColor = true;
            this.rbComparePaymentStatus.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(124, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tk.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(241, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "/-";
            // 
            // txtMRP_ActualReceivable
            // 
            this.txtMRP_ActualReceivable.BackColor = System.Drawing.Color.White;
            this.txtMRP_ActualReceivable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMRP_ActualReceivable.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtMRP_ActualReceivable.Location = new System.Drawing.Point(155, 57);
            this.txtMRP_ActualReceivable.Name = "txtMRP_ActualReceivable";
            this.txtMRP_ActualReceivable.ReadOnly = true;
            this.txtMRP_ActualReceivable.Size = new System.Drawing.Size(85, 20);
            this.txtMRP_ActualReceivable.TabIndex = 8;
            this.txtMRP_ActualReceivable.TabStop = false;
            this.txtMRP_ActualReceivable.Text = "0";
            this.txtMRP_ActualReceivable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(124, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tk.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(241, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "/-";
            // 
            // txtMRP_ActualReceived
            // 
            this.txtMRP_ActualReceived.BackColor = System.Drawing.Color.White;
            this.txtMRP_ActualReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMRP_ActualReceived.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtMRP_ActualReceived.Location = new System.Drawing.Point(155, 80);
            this.txtMRP_ActualReceived.Name = "txtMRP_ActualReceived";
            this.txtMRP_ActualReceived.ReadOnly = true;
            this.txtMRP_ActualReceived.Size = new System.Drawing.Size(85, 20);
            this.txtMRP_ActualReceived.TabIndex = 8;
            this.txtMRP_ActualReceived.TabStop = false;
            this.txtMRP_ActualReceived.Text = "0";
            this.txtMRP_ActualReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(124, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Tk.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(241, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "/-";
            // 
            // txtMRP_AmountRefund
            // 
            this.txtMRP_AmountRefund.BackColor = System.Drawing.Color.White;
            this.txtMRP_AmountRefund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMRP_AmountRefund.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtMRP_AmountRefund.Location = new System.Drawing.Point(155, 104);
            this.txtMRP_AmountRefund.Name = "txtMRP_AmountRefund";
            this.txtMRP_AmountRefund.ReadOnly = true;
            this.txtMRP_AmountRefund.Size = new System.Drawing.Size(85, 20);
            this.txtMRP_AmountRefund.TabIndex = 8;
            this.txtMRP_AmountRefund.TabStop = false;
            this.txtMRP_AmountRefund.Text = "0";
            this.txtMRP_AmountRefund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(124, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Tk.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(241, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "/-";
            // 
            // txtMRP_Target
            // 
            this.txtMRP_Target.BackColor = System.Drawing.Color.White;
            this.txtMRP_Target.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMRP_Target.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtMRP_Target.Location = new System.Drawing.Point(155, 128);
            this.txtMRP_Target.Name = "txtMRP_Target";
            this.txtMRP_Target.Size = new System.Drawing.Size(85, 20);
            this.txtMRP_Target.TabIndex = 2;
            this.txtMRP_Target.Text = "0";
            this.txtMRP_Target.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMRP_Target.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtMRP_Target.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            this.txtMRP_Target.Leave += new System.EventHandler(this.txtMRP_Target_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(124, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Tk.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(241, 169);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "/-";
            // 
            // txtMRP_OutstandingInstallment
            // 
            this.txtMRP_OutstandingInstallment.BackColor = System.Drawing.Color.White;
            this.txtMRP_OutstandingInstallment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMRP_OutstandingInstallment.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtMRP_OutstandingInstallment.Location = new System.Drawing.Point(155, 165);
            this.txtMRP_OutstandingInstallment.Name = "txtMRP_OutstandingInstallment";
            this.txtMRP_OutstandingInstallment.Size = new System.Drawing.Size(85, 20);
            this.txtMRP_OutstandingInstallment.TabIndex = 3;
            this.txtMRP_OutstandingInstallment.Text = "0";
            this.txtMRP_OutstandingInstallment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMRP_OutstandingInstallment.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtMRP_OutstandingInstallment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            this.txtMRP_OutstandingInstallment.Leave += new System.EventHandler(this.calculateTotalOutstanding_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(124, 192);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Tk.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(241, 192);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "/-";
            // 
            // txtMRP_OutstandingBDPayment
            // 
            this.txtMRP_OutstandingBDPayment.BackColor = System.Drawing.Color.White;
            this.txtMRP_OutstandingBDPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMRP_OutstandingBDPayment.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtMRP_OutstandingBDPayment.Location = new System.Drawing.Point(155, 188);
            this.txtMRP_OutstandingBDPayment.Name = "txtMRP_OutstandingBDPayment";
            this.txtMRP_OutstandingBDPayment.Size = new System.Drawing.Size(85, 20);
            this.txtMRP_OutstandingBDPayment.TabIndex = 4;
            this.txtMRP_OutstandingBDPayment.Text = "0";
            this.txtMRP_OutstandingBDPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMRP_OutstandingBDPayment.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtMRP_OutstandingBDPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            this.txtMRP_OutstandingBDPayment.Leave += new System.EventHandler(this.calculateTotalOutstanding_Leave);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(319, 192);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "Tk.";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(434, 192);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "/-";
            // 
            // txtMRP_Total
            // 
            this.txtMRP_Total.BackColor = System.Drawing.Color.White;
            this.txtMRP_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMRP_Total.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtMRP_Total.Location = new System.Drawing.Point(350, 188);
            this.txtMRP_Total.Name = "txtMRP_Total";
            this.txtMRP_Total.ReadOnly = true;
            this.txtMRP_Total.Size = new System.Drawing.Size(85, 20);
            this.txtMRP_Total.TabIndex = 8;
            this.txtMRP_Total.TabStop = false;
            this.txtMRP_Total.Text = "0";
            this.txtMRP_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(180, 5);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(103, 13);
            this.label25.TabIndex = 5;
            this.label25.Text = "for the year of:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(177, 51);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(103, 20);
            this.dtpStartDate.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(299, 51);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(103, 20);
            this.dtpEndDate.TabIndex = 5;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(283, 55);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(13, 13);
            this.label27.TabIndex = 5;
            this.label27.Text = "&&";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1052, 22);
            this.statusStrip1.TabIndex = 10;
            // 
            // tssStatus
            // 
            this.tssStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(135)))));
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(1037, 17);
            this.tssStatus.Spring = true;
            this.tssStatus.Text = "Ready";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowReport.Image = global::RealEstateManagementSystem.Properties.Resources.bangladeshi_taka;
            this.btnShowReport.Location = new System.Drawing.Point(951, 403);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(87, 63);
            this.btnShowReport.TabIndex = 2;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpProjectValuation);
            this.panel1.Controls.Add(this.rbProjectValuation);
            this.panel1.Location = new System.Drawing.Point(7, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 32);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtMRP_Total);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.txtMRP_OutstandingBDPayment);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.txtMRP_OutstandingInstallment);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txtMRP_Target);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.txtMRP_AmountRefund);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtMRP_ActualReceived);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtMRP_ActualReceivable);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMRP_Analysis);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpMonthlyRecoveryPosition);
            this.panel2.Controls.Add(this.rbMonthlyRecoveryPosition);
            this.panel2.Location = new System.Drawing.Point(587, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 217);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lvSalesYears);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.rbAnnualAgreementList);
            this.panel3.Controls.Add(this.rbAnnualRecoveryPosition);
            this.panel3.Location = new System.Drawing.Point(587, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 190);
            this.panel3.TabIndex = 2;
            // 
            // lvSalesYears
            // 
            this.lvSalesYears.CheckBoxes = true;
            this.lvSalesYears.FullRowSelect = true;
            this.lvSalesYears.GridLines = true;
            this.lvSalesYears.Location = new System.Drawing.Point(183, 21);
            this.lvSalesYears.Name = "lvSalesYears";
            this.lvSalesYears.Size = new System.Drawing.Size(100, 162);
            this.lvSalesYears.TabIndex = 2;
            this.lvSalesYears.UseCompatibleStateImageBehavior = false;
            this.lvSalesYears.View = System.Windows.Forms.View.Details;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbInstallments);
            this.panel4.Controls.Add(this.rbRefundAmountFrom);
            this.panel4.Location = new System.Drawing.Point(7, 330);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 32);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.rbRefundAmountBetween);
            this.panel6.Controls.Add(this.rbRegistrationCompleted);
            this.panel6.Controls.Add(this.label29);
            this.panel6.Controls.Add(this.label27);
            this.panel6.Controls.Add(this.dtpEndDate);
            this.panel6.Controls.Add(this.dtpStartDate);
            this.panel6.Controls.Add(this.rbComparePaymentStatus);
            this.panel6.Location = new System.Drawing.Point(7, 370);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(412, 77);
            this.panel6.TabIndex = 3;
            // 
            // rbRefundAmountBetween
            // 
            this.rbRefundAmountBetween.AutoSize = true;
            this.rbRefundAmountBetween.Location = new System.Drawing.Point(5, 29);
            this.rbRefundAmountBetween.Name = "rbRefundAmountBetween";
            this.rbRefundAmountBetween.Size = new System.Drawing.Size(103, 17);
            this.rbRefundAmountBetween.TabIndex = 2;
            this.rbRefundAmountBetween.Text = "Refund Amount";
            this.rbRefundAmountBetween.UseVisualStyleBackColor = true;
            this.rbRefundAmountBetween.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // rbRegistrationCompleted
            // 
            this.rbRegistrationCompleted.AutoSize = true;
            this.rbRegistrationCompleted.Location = new System.Drawing.Point(168, 6);
            this.rbRegistrationCompleted.Name = "rbRegistrationCompleted";
            this.rbRegistrationCompleted.Size = new System.Drawing.Size(157, 17);
            this.rbRegistrationCompleted.TabIndex = 1;
            this.rbRegistrationCompleted.Text = "Registration Completed";
            this.rbRegistrationCompleted.UseVisualStyleBackColor = true;
            this.rbRegistrationCompleted.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(50, 55);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(121, 13);
            this.label29.TabIndex = 3;
            this.label29.Text = "Report Date Between";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(189, 6);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(121, 13);
            this.label30.TabIndex = 18;
            this.label30.Text = "List of Project(s):";
            // 
            // lvProjects
            // 
            this.lvProjects.BackColor = System.Drawing.Color.White;
            this.lvProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProjects.CheckBoxes = true;
            this.lvProjects.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lvProjects.FullRowSelect = true;
            this.lvProjects.GridLines = true;
            this.lvProjects.Location = new System.Drawing.Point(189, 21);
            this.lvProjects.Name = "lvProjects";
            this.lvProjects.Size = new System.Drawing.Size(376, 261);
            this.lvProjects.TabIndex = 1;
            this.lvProjects.UseCompatibleStateImageBehavior = false;
            this.lvProjects.View = System.Windows.Forms.View.List;
            // 
            // lvProjectStatus
            // 
            this.lvProjectStatus.BackColor = System.Drawing.Color.White;
            this.lvProjectStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProjectStatus.CheckBoxes = true;
            this.lvProjectStatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lvProjectStatus.FullRowSelect = true;
            this.lvProjectStatus.GridLines = true;
            this.lvProjectStatus.Location = new System.Drawing.Point(5, 21);
            this.lvProjectStatus.Name = "lvProjectStatus";
            this.lvProjectStatus.Size = new System.Drawing.Size(178, 173);
            this.lvProjectStatus.TabIndex = 0;
            this.lvProjectStatus.UseCompatibleStateImageBehavior = false;
            this.lvProjectStatus.View = System.Windows.Forms.View.List;
            this.lvProjectStatus.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvProjectStatus_ItemChecked);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(5, 5);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(97, 13);
            this.label31.TabIndex = 19;
            this.label31.Text = "Project Status:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.lblProjectCount);
            this.panel5.Controls.Add(this.label30);
            this.panel5.Controls.Add(this.lvProjects);
            this.panel5.Controls.Add(this.lvProjectStatus);
            this.panel5.Controls.Add(this.label31);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(572, 454);
            this.panel5.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.nudMaximumAmount);
            this.panel9.Controls.Add(this.nudMinimumAmount);
            this.panel9.Controls.Add(this.rbCurrentDue);
            this.panel9.Controls.Add(this.label28);
            this.panel9.Location = new System.Drawing.Point(425, 351);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(140, 98);
            this.panel9.TabIndex = 24;
            // 
            // nudMaximumAmount
            // 
            this.nudMaximumAmount.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMaximumAmount.Location = new System.Drawing.Point(23, 70);
            this.nudMaximumAmount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudMaximumAmount.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMaximumAmount.Name = "nudMaximumAmount";
            this.nudMaximumAmount.Size = new System.Drawing.Size(87, 20);
            this.nudMaximumAmount.TabIndex = 2;
            this.nudMaximumAmount.ThousandsSeparator = true;
            this.nudMaximumAmount.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // nudMinimumAmount
            // 
            this.nudMinimumAmount.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMinimumAmount.Location = new System.Drawing.Point(23, 49);
            this.nudMinimumAmount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudMinimumAmount.Name = "nudMinimumAmount";
            this.nudMinimumAmount.Size = new System.Drawing.Size(87, 20);
            this.nudMinimumAmount.TabIndex = 1;
            this.nudMinimumAmount.ThousandsSeparator = true;
            // 
            // rbCurrentDue
            // 
            this.rbCurrentDue.AutoSize = true;
            this.rbCurrentDue.Location = new System.Drawing.Point(4, 2);
            this.rbCurrentDue.Name = "rbCurrentDue";
            this.rbCurrentDue.Size = new System.Drawing.Size(121, 43);
            this.rbCurrentDue.TabIndex = 0;
            this.rbCurrentDue.Text = "List of Clients \r\nby current dues \r\nbetween";
            this.rbCurrentDue.UseVisualStyleBackColor = true;
            this.rbCurrentDue.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(109, 63);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(13, 13);
            this.label28.TabIndex = 3;
            this.label28.Text = "&&";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.rbRecoveryPosition);
            this.panel8.Location = new System.Drawing.Point(425, 313);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(136, 32);
            this.panel8.TabIndex = 2;
            // 
            // rbRecoveryPosition
            // 
            this.rbRecoveryPosition.AutoSize = true;
            this.rbRecoveryPosition.Location = new System.Drawing.Point(8, 7);
            this.rbRecoveryPosition.Name = "rbRecoveryPosition";
            this.rbRecoveryPosition.Size = new System.Drawing.Size(127, 17);
            this.rbRecoveryPosition.TabIndex = 0;
            this.rbRecoveryPosition.TabStop = true;
            this.rbRecoveryPosition.Text = "Recovery Position";
            this.rbRecoveryPosition.UseVisualStyleBackColor = true;
            this.rbRecoveryPosition.CheckedChanged += new System.EventHandler(this._checkedChanged);
            // 
            // lblProjectCount
            // 
            this.lblProjectCount.AutoSize = true;
            this.lblProjectCount.Location = new System.Drawing.Point(450, 285);
            this.lblProjectCount.Name = "lblProjectCount";
            this.lblProjectCount.Size = new System.Drawing.Size(115, 13);
            this.lblProjectCount.TabIndex = 22;
            this.lblProjectCount.Text = "0 Project(s) Found";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.dtpTransactionSummary);
            this.panel7.Controls.Add(this.rbTransactionSummary);
            this.panel7.Location = new System.Drawing.Point(587, 232);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(397, 33);
            this.panel7.TabIndex = 23;
            // 
            // dtpTransactionSummary
            // 
            this.dtpTransactionSummary.CustomFormat = "MMMM - yyyy";
            this.dtpTransactionSummary.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionSummary.Location = new System.Drawing.Point(249, 5);
            this.dtpTransactionSummary.Name = "dtpTransactionSummary";
            this.dtpTransactionSummary.Size = new System.Drawing.Size(142, 20);
            this.dtpTransactionSummary.TabIndex = 1;
            // 
            // cmbInstallments
            // 
            this.cmbInstallments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstallments.FormattingEnabled = true;
            this.cmbInstallments.Location = new System.Drawing.Point(144, 4);
            this.cmbInstallments.Name = "cmbInstallments";
            this.cmbInstallments.Size = new System.Drawing.Size(264, 21);
            this.cmbInstallments.TabIndex = 2;
            // 
            // frmRecoveryReports
            // 
            this.AcceptButton = this.btnShowReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 492);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecoveryReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recovery Reports";
            this.Load += new System.EventHandler(this.frmRecoveryReports_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumAmount)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbProjectValuation;
        private System.Windows.Forms.DateTimePicker dtpProjectValuation;
        private System.Windows.Forms.RadioButton rbMonthlyRecoveryPosition;
        private System.Windows.Forms.DateTimePicker dtpMonthlyRecoveryPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMRP_Analysis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbAnnualRecoveryPosition;
        private System.Windows.Forms.RadioButton rbAnnualAgreementList;
        private System.Windows.Forms.RadioButton rbRefundAmountFrom;
        private System.Windows.Forms.RadioButton rbTransactionSummary;
        private System.Windows.Forms.RadioButton rbComparePaymentStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMRP_ActualReceivable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMRP_ActualReceived;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMRP_AmountRefund;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMRP_Target;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMRP_OutstandingInstallment;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtMRP_OutstandingBDPayment;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtMRP_Total;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.RadioButton rbRegistrationCompleted;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ListView lvProjects;
        private System.Windows.Forms.ListView lvProjectStatus;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblProjectCount;
        private System.Windows.Forms.RadioButton rbRefundAmountBetween;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dtpTransactionSummary;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton rbRecoveryPosition;
        private System.Windows.Forms.ListView lvSalesYears;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.NumericUpDown nudMaximumAmount;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown nudMinimumAmount;
        private System.Windows.Forms.RadioButton rbCurrentDue;
        private System.Windows.Forms.ComboBox cmbInstallments;
    }
}