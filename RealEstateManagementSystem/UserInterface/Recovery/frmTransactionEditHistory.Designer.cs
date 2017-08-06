namespace RealEstateManagementSystem.UserInterface.Recovery
{
    partial class frmTransactionEditHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionEditHistory));
            this.lstTransactionHistory = new System.Windows.Forms.ListView();
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInstallment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTransactionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstTransactionHistory
            // 
            this.lstTransactionHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStatus,
            this.colInstallment,
            this.colTransactionDate,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.lstTransactionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTransactionHistory.FullRowSelect = true;
            this.lstTransactionHistory.GridLines = true;
            this.lstTransactionHistory.Location = new System.Drawing.Point(0, 0);
            this.lstTransactionHistory.Name = "lstTransactionHistory";
            this.lstTransactionHistory.Size = new System.Drawing.Size(1159, 430);
            this.lstTransactionHistory.TabIndex = 0;
            this.lstTransactionHistory.UseCompatibleStateImageBehavior = false;
            this.lstTransactionHistory.View = System.Windows.Forms.View.Details;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 82;
            // 
            // colInstallment
            // 
            this.colInstallment.Text = "Installment";
            this.colInstallment.Width = 118;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Text = "Transaction Date";
            this.colTransactionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTransactionDate.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount Paid";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Payment Mode";
            this.columnHeader5.Width = 92;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CQ/PO Date";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 83;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Particulars";
            this.columnHeader7.Width = 91;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Remarks";
            this.columnHeader8.Width = 101;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Bank Info";
            this.columnHeader9.Width = 95;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Bank Account #";
            this.columnHeader13.Width = 102;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Cancel Reason";
            this.columnHeader14.Width = 106;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Update Reason";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Updated By";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Updated On";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmTransactionEditHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 430);
            this.Controls.Add(this.lstTransactionHistory);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTransactionEditHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Update History";
            this.Load += new System.EventHandler(this.frmTransactionEditHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstTransactionHistory;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colInstallment;
        private System.Windows.Forms.ColumnHeader colTransactionDate;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
    }
}