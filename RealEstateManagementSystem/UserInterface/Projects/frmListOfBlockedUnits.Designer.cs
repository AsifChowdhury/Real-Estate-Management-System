namespace RealEstateManagementSystem.UserInterface.Projects
{
    partial class frmListOfBlockedUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListOfBlockedUnits));
            this.label1 = new System.Windows.Forms.Label();
            this.lstProjects = new System.Windows.Forms.ListView();
            this.colProjectId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumberOfUnits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lstBlockedUnits = new System.Windows.Forms.ListView();
            this.colUnitId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnitNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnitType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.lstBlockingHistory = new System.Windows.Forms.ListView();
            this.colBlockedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRemarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project(s):";
            // 
            // lstProjects
            // 
            this.lstProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProjectId,
            this.colProjectName,
            this.colNumberOfUnits});
            this.lstProjects.FullRowSelect = true;
            this.lstProjects.GridLines = true;
            this.lstProjects.HideSelection = false;
            this.lstProjects.Location = new System.Drawing.Point(16, 31);
            this.lstProjects.MultiSelect = false;
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(359, 501);
            this.lstProjects.TabIndex = 1;
            this.lstProjects.UseCompatibleStateImageBehavior = false;
            this.lstProjects.View = System.Windows.Forms.View.Details;
            this.lstProjects.SelectedIndexChanged += new System.EventHandler(this.lstProjects_SelectedIndexChanged);
            // 
            // colProjectId
            // 
            this.colProjectId.Width = 0;
            // 
            // colProjectName
            // 
            this.colProjectName.Text = "Project name";
            this.colProjectName.Width = 223;
            // 
            // colNumberOfUnits
            // 
            this.colNumberOfUnits.Text = "# of Blocked Units";
            this.colNumberOfUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNumberOfUnits.Width = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Blocked Unit(s):";
            // 
            // lstBlockedUnits
            // 
            this.lstBlockedUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBlockedUnits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUnitId,
            this.colUnitNumber,
            this.colUnitType,
            this.colArea,
            this.colRate,
            this.colTotalValue});
            this.lstBlockedUnits.FullRowSelect = true;
            this.lstBlockedUnits.GridLines = true;
            this.lstBlockedUnits.HideSelection = false;
            this.lstBlockedUnits.Location = new System.Drawing.Point(381, 31);
            this.lstBlockedUnits.MultiSelect = false;
            this.lstBlockedUnits.Name = "lstBlockedUnits";
            this.lstBlockedUnits.Size = new System.Drawing.Size(602, 268);
            this.lstBlockedUnits.TabIndex = 3;
            this.lstBlockedUnits.UseCompatibleStateImageBehavior = false;
            this.lstBlockedUnits.View = System.Windows.Forms.View.Details;
            this.lstBlockedUnits.SelectedIndexChanged += new System.EventHandler(this.lstBlockedUnits_SelectedIndexChanged);
            this.lstBlockedUnits.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstBlockedUnits_MouseUp);
            // 
            // colUnitId
            // 
            this.colUnitId.Text = "Unit Id";
            this.colUnitId.Width = 0;
            // 
            // colUnitNumber
            // 
            this.colUnitNumber.Text = "Unit #";
            this.colUnitNumber.Width = 100;
            // 
            // colUnitType
            // 
            this.colUnitType.Text = "Unit Type";
            this.colUnitType.Width = 100;
            // 
            // colArea
            // 
            this.colArea.Text = "Area (sft.)";
            this.colArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colArea.Width = 100;
            // 
            // colRate
            // 
            this.colRate.Text = "Rate";
            this.colRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colRate.Width = 100;
            // 
            // colTotalValue
            // 
            this.colTotalValue.Text = "Value";
            this.colTotalValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colTotalValue.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blocking History:";
            // 
            // lstBlockingHistory
            // 
            this.lstBlockingHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBlockingHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBlockedBy,
            this.colStartDate,
            this.colEndDate,
            this.colRemarks});
            this.lstBlockingHistory.FullRowSelect = true;
            this.lstBlockingHistory.GridLines = true;
            this.lstBlockingHistory.HideSelection = false;
            this.lstBlockingHistory.Location = new System.Drawing.Point(381, 320);
            this.lstBlockingHistory.MultiSelect = false;
            this.lstBlockingHistory.Name = "lstBlockingHistory";
            this.lstBlockingHistory.Size = new System.Drawing.Size(602, 212);
            this.lstBlockingHistory.TabIndex = 3;
            this.lstBlockingHistory.UseCompatibleStateImageBehavior = false;
            this.lstBlockingHistory.View = System.Windows.Forms.View.Details;
            // 
            // colBlockedBy
            // 
            this.colBlockedBy.Text = "Blocked By";
            this.colBlockedBy.Width = 169;
            // 
            // colStartDate
            // 
            this.colStartDate.Text = "Start Date";
            this.colStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStartDate.Width = 156;
            // 
            // colEndDate
            // 
            this.colEndDate.Text = "End Date";
            this.colEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEndDate.Width = 128;
            // 
            // colRemarks
            // 
            this.colRemarks.Text = "Remarks";
            this.colRemarks.Width = 234;
            // 
            // frmListOfBlockedUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(68)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(995, 544);
            this.Controls.Add(this.lstBlockingHistory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstBlockedUnits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstProjects);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListOfBlockedUnits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Blocked Unit";
            this.Load += new System.EventHandler(this.frmListOfBlockedUnits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstProjects;
        private System.Windows.Forms.ColumnHeader colProjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader colNumberOfUnits;
        private System.Windows.Forms.ColumnHeader colProjectId;
        private System.Windows.Forms.ListView lstBlockedUnits;
        private System.Windows.Forms.ColumnHeader colUnitId;
        private System.Windows.Forms.ColumnHeader colUnitNumber;
        private System.Windows.Forms.ColumnHeader colUnitType;
        private System.Windows.Forms.ColumnHeader colArea;
        private System.Windows.Forms.ColumnHeader colRate;
        private System.Windows.Forms.ColumnHeader colTotalValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstBlockingHistory;
        private System.Windows.Forms.ColumnHeader colBlockedBy;
        private System.Windows.Forms.ColumnHeader colStartDate;
        private System.Windows.Forms.ColumnHeader colEndDate;
        private System.Windows.Forms.ColumnHeader colRemarks;
    }
}