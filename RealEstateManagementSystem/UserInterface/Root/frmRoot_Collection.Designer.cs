namespace RealEstateManagementSystem.UserInterface.Root
{
    partial class frmRoot_Collection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoot_Collection));
            this.lstTransactionList = new System.Windows.Forms.ListView();
            this.colClientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBookingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPaymentStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPaymentMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTransactionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRemarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCurrentDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnReload = new System.Windows.Forms.Button();
            this.tssCollection = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTransactionList
            // 
            this.lstTransactionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTransactionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colClientId,
            this.colName,
            this.colBookingDate,
            this.colUnit,
            this.colPaymentStatus,
            this.colPaymentMode,
            this.colTransactionDate,
            this.colAmount,
            this.colRemarks,
            this.colCurrentDue});
            this.lstTransactionList.FullRowSelect = true;
            this.lstTransactionList.GridLines = true;
            this.lstTransactionList.Location = new System.Drawing.Point(0, 32);
            this.lstTransactionList.Name = "lstTransactionList";
            this.lstTransactionList.Size = new System.Drawing.Size(1180, 655);
            this.lstTransactionList.TabIndex = 0;
            this.lstTransactionList.UseCompatibleStateImageBehavior = false;
            this.lstTransactionList.View = System.Windows.Forms.View.Details;
            this.lstTransactionList.SelectedIndexChanged += new System.EventHandler(this.lstTransactionList_SelectedIndexChanged);
            this.lstTransactionList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstTransactionList_MouseUp);
            // 
            // colClientId
            // 
            this.colClientId.Text = "Client #";
            this.colClientId.Width = 96;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 169;
            // 
            // colBookingDate
            // 
            this.colBookingDate.Text = "Booking Date";
            this.colBookingDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBookingDate.Width = 103;
            // 
            // colUnit
            // 
            this.colUnit.Text = "Unit";
            this.colUnit.Width = 133;
            // 
            // colPaymentStatus
            // 
            this.colPaymentStatus.Text = "Status";
            this.colPaymentStatus.Width = 86;
            // 
            // colPaymentMode
            // 
            this.colPaymentMode.Text = "Payment Mode";
            this.colPaymentMode.Width = 114;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Text = "Tr. Date";
            this.colTransactionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colAmount
            // 
            this.colAmount.Text = "Amount";
            this.colAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colAmount.Width = 111;
            // 
            // colRemarks
            // 
            this.colRemarks.Text = "Remarks";
            this.colRemarks.Width = 134;
            // 
            // colCurrentDue
            // 
            this.colCurrentDue.Text = "Current Due";
            this.colCurrentDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colCurrentDue.Width = 127;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssCollection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 690);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1180, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(582, 17);
            this.tssStatus.Spring = true;
            this.tssStatus.Text = "Ready";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transactions From";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(137, 6);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(106, 20);
            this.dtpStartDate.TabIndex = 3;
            // 
            // btnReload
            // 
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.Color.Teal;
            this.btnReload.Image = global::RealEstateManagementSystem.Properties.Resources.update;
            this.btnReload.Location = new System.Drawing.Point(249, 1);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(27, 25);
            this.btnReload.TabIndex = 4;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // tssCollection
            // 
            this.tssCollection.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssCollection.ForeColor = System.Drawing.Color.Maroon;
            this.tssCollection.Name = "tssCollection";
            this.tssCollection.Size = new System.Drawing.Size(582, 17);
            this.tssCollection.Spring = true;
            this.tssCollection.Text = "Total Collection: Tk. 0/-";
            this.tssCollection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmRoot_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 712);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTransactionList);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRoot_Collection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collection Details";
            this.Load += new System.EventHandler(this.frmRoot_Collection_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstTransactionList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ColumnHeader colClientId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colBookingDate;
        private System.Windows.Forms.ColumnHeader colUnit;
        private System.Windows.Forms.ColumnHeader colPaymentStatus;
        private System.Windows.Forms.ColumnHeader colPaymentMode;
        private System.Windows.Forms.ColumnHeader colTransactionDate;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.ColumnHeader colRemarks;
        private System.Windows.Forms.ColumnHeader colCurrentDue;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ToolStripStatusLabel tssCollection;
    }
}