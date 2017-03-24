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
            this.statusStrip1.SizingGrip = false;
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
            this.lstSold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSold.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSold.ForeColor = System.Drawing.Color.Maroon;
            this.lstSold.FullRowSelect = true;
            this.lstSold.GridLines = true;
            this.lstSold.Location = new System.Drawing.Point(0, 0);
            this.lstSold.Name = "lstSold";
            this.lstSold.Size = new System.Drawing.Size(1019, 541);
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
            // frmRoot_SoldList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 563);
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
    }
}