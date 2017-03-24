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
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstcancelList
            // 
            this.lstcancelList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colClientId,
            this.colName,
            this.colContactNumber,
            this.colProjectName,
            this.colUnit,
            this.colCancelDate});
            this.lstcancelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstcancelList.FullRowSelect = true;
            this.lstcancelList.GridLines = true;
            this.lstcancelList.Location = new System.Drawing.Point(0, 0);
            this.lstcancelList.Name = "lstcancelList";
            this.lstcancelList.Size = new System.Drawing.Size(914, 562);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(118, 17);
            this.tssStatus.Text = "toolStripStatusLabel1";
            // 
            // frmRoot_CancelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 584);
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
    }
}