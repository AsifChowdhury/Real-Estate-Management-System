namespace RealEstateManagementSystem.UserInterface.Root
{
    partial class frmRoot_CancelList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoot_CancelList));
            this.lstcancelList = new System.Windows.Forms.ListView();
            this.colClientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContactNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCancelDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnReload = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstcancelList
            // 
            this.lstcancelList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstcancelList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colClientId,
            this.colName,
            this.colContactNumber,
            this.colProjectName,
            this.colUnit,
            this.colCancelDate});
            this.lstcancelList.FullRowSelect = true;
            this.lstcancelList.GridLines = true;
            this.lstcancelList.Location = new System.Drawing.Point(0, 40);
            this.lstcancelList.Name = "lstcancelList";
            this.lstcancelList.Size = new System.Drawing.Size(1046, 593);
            this.lstcancelList.TabIndex = 0;
            this.lstcancelList.UseCompatibleStateImageBehavior = false;
            this.lstcancelList.View = System.Windows.Forms.View.Details;
            this.lstcancelList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstcancelList_MouseUp);
            // 
            // colClientId
            // 
            this.colClientId.Text = "Client Id";
            this.colClientId.Width = 139;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 177;
            // 
            // colContactNumber
            // 
            this.colContactNumber.Text = "Contact #";
            this.colContactNumber.Width = 163;
            // 
            // colProjectName
            // 
            this.colProjectName.Text = "Project Name";
            this.colProjectName.Width = 163;
            // 
            // colUnit
            // 
            this.colUnit.Text = "Unit #";
            this.colUnit.Width = 117;
            // 
            // colCancelDate
            // 
            this.colCancelDate.Text = "Cancel Date";
            this.colCancelDate.Width = 121;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 657);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1046, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(1031, 17);
            this.tssStatus.Spring = true;
            this.tssStatus.Text = "Ready";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReload
            // 
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.Color.Teal;
            this.btnReload.Image = global::RealEstateManagementSystem.Properties.Resources.update;
            this.btnReload.Location = new System.Drawing.Point(216, 5);
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
            this.dtpStartDate.Location = new System.Drawing.Point(104, 10);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(106, 20);
            this.dtpStartDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cancelled From";
            // 
            // label2
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(7, 638);
            this.lblRecordCount.Name = "label2";
            this.lblRecordCount.Size = new System.Drawing.Size(169, 13);
            this.lblRecordCount.TabIndex = 8;
            this.lblRecordCount.Text = "# of Cancelled Client(s): 0";
            // 
            // frmRoot_CancelList
            // 
            this.AcceptButton = this.btnReload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 679);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstcancelList);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRoot_CancelList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelList";
            this.Load += new System.EventHandler(this.frmRoot_CancelList_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstcancelList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ColumnHeader colClientId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colContactNumber;
        private System.Windows.Forms.ColumnHeader colProjectName;
        private System.Windows.Forms.ColumnHeader colUnit;
        private System.Windows.Forms.ColumnHeader colCancelDate;
        private System.Windows.Forms.Button btnReload;
        public System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecordCount;
    }
}