namespace RealEstateManagementSystem.UserInterface.Root
{
    partial class frmRoot_SoldList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoot_SoldList));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssSoldCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstSold = new System.Windows.Forms.ListView();
            this.colClientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContactNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnitNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFaceValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRebate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSaleValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBookingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSoldCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1019, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssSoldCount
            // 
            this.tssSoldCount.Name = "tssSoldCount";
            this.tssSoldCount.Size = new System.Drawing.Size(1004, 17);
            this.tssSoldCount.Spring = true;
            this.tssSoldCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstSold
            // 
            this.lstSold.BackColor = System.Drawing.Color.White;
            this.lstSold.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colClientId,
            this.colName,
            this.colContactNumber,
            this.colProjectName,
            this.colUnitNumber,
            this.colFaceValue,
            this.colRebate,
            this.colSaleValue,
            this.colPaid,
            this.colBookingDate});
            this.lstSold.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSold.ForeColor = System.Drawing.Color.Maroon;
            this.lstSold.FullRowSelect = true;
            this.lstSold.GridLines = true;
            this.lstSold.Location = new System.Drawing.Point(0, 32);
            this.lstSold.Name = "lstSold";
            this.lstSold.Size = new System.Drawing.Size(1019, 492);
            this.lstSold.TabIndex = 1;
            this.lstSold.UseCompatibleStateImageBehavior = false;
            this.lstSold.View = System.Windows.Forms.View.Details;
            this.lstSold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstSold_MouseUp);
            // 
            // colClientId
            // 
            this.colClientId.Text = "ClientId";
            this.colClientId.Width = 115;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 140;
            // 
            // colContactNumber
            // 
            this.colContactNumber.Text = "Contact #";
            this.colContactNumber.Width = 111;
            // 
            // colProjectName
            // 
            this.colProjectName.Text = "Project Name";
            this.colProjectName.Width = 140;
            // 
            // colUnitNumber
            // 
            this.colUnitNumber.Text = "Unit #";
            this.colUnitNumber.Width = 84;
            // 
            // colFaceValue
            // 
            this.colFaceValue.Text = "Face Value";
            this.colFaceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colFaceValue.Width = 90;
            // 
            // colRebate
            // 
            this.colRebate.Text = "Rebate";
            this.colRebate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colRebate.Width = 84;
            // 
            // colSaleValue
            // 
            this.colSaleValue.Text = "Sale Value";
            this.colSaleValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSaleValue.Width = 96;
            // 
            // colPaid
            // 
            this.colPaid.Text = "Paid";
            this.colPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPaid.Width = 88;
            // 
            // colBookingDate
            // 
            this.colBookingDate.Text = "Booking Date";
            // 
            // label1
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(4, 526);
            this.lblRecordCount.Name = "label1";
            this.lblRecordCount.Size = new System.Drawing.Size(127, 13);
            this.lblRecordCount.TabIndex = 2;
            this.lblRecordCount.Text = "# of Unit(s) Sold: 0";
            // 
            // btnReload
            // 
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.Color.Teal;
            this.btnReload.Image = global::RealEstateManagementSystem.Properties.Resources.update;
            this.btnReload.Location = new System.Drawing.Point(184, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(27, 25);
            this.btnReload.TabIndex = 7;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(72, 6);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(106, 20);
            this.dtpStartDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sold From";
            // 
            // frmRoot_SoldList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 563);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lstSold);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRoot_SoldList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sold";
            this.Load += new System.EventHandler(this.frmRoot_SoldList_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView lstSold;
        private System.Windows.Forms.ColumnHeader colClientId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colContactNumber;
        private System.Windows.Forms.ColumnHeader colProjectName;
        private System.Windows.Forms.ColumnHeader colUnitNumber;
        private System.Windows.Forms.ColumnHeader colFaceValue;
        private System.Windows.Forms.ColumnHeader colRebate;
        private System.Windows.Forms.ColumnHeader colSaleValue;
        private System.Windows.Forms.ColumnHeader colPaid;
        private System.Windows.Forms.ToolStripStatusLabel tssSoldCount;
        private System.Windows.Forms.ColumnHeader colBookingDate;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button btnReload;
        public System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
    }
}