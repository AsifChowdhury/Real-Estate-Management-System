namespace RealEstateManagementSystem.UserInterface.Recovery
{
    partial class frmDefinition_BankBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDefinition_BankBranch));
            this.tcBankBranch = new System.Windows.Forms.TabControl();
            this.tpBank = new System.Windows.Forms.TabPage();
            this.lblBankCount = new System.Windows.Forms.Label();
            this.btnSaveBank = new System.Windows.Forms.Button();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBank = new System.Windows.Forms.ListView();
            this.colBankId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBankName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpBranch = new System.Windows.Forms.TabPage();
            this.lblBranchCount = new System.Windows.Forms.Label();
            this.btnSaveBranch = new System.Windows.Forms.Button();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBranch = new System.Windows.Forms.ListView();
            this.colBranchId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBranchName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefreshBank = new System.Windows.Forms.Button();
            this.btnRefreshBranchTab = new System.Windows.Forms.Button();
            this.tcBankBranch.SuspendLayout();
            this.tpBank.SuspendLayout();
            this.tpBranch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBankBranch
            // 
            this.tcBankBranch.Controls.Add(this.tpBank);
            this.tcBankBranch.Controls.Add(this.tpBranch);
            this.tcBankBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBankBranch.Location = new System.Drawing.Point(0, 0);
            this.tcBankBranch.Name = "tcBankBranch";
            this.tcBankBranch.SelectedIndex = 0;
            this.tcBankBranch.Size = new System.Drawing.Size(738, 388);
            this.tcBankBranch.TabIndex = 0;
            // 
            // tpBank
            // 
            this.tpBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpBank.Controls.Add(this.btnRefreshBank);
            this.tpBank.Controls.Add(this.lblBankCount);
            this.tpBank.Controls.Add(this.btnSaveBank);
            this.tpBank.Controls.Add(this.txtBankName);
            this.tpBank.Controls.Add(this.label1);
            this.tpBank.Controls.Add(this.lstBank);
            this.tpBank.Location = new System.Drawing.Point(4, 22);
            this.tpBank.Name = "tpBank";
            this.tpBank.Padding = new System.Windows.Forms.Padding(3);
            this.tpBank.Size = new System.Drawing.Size(730, 362);
            this.tpBank.TabIndex = 0;
            this.tpBank.Text = "Bank Information";
            this.tpBank.UseVisualStyleBackColor = true;
            // 
            // lblBankCount
            // 
            this.lblBankCount.AutoSize = true;
            this.lblBankCount.Location = new System.Drawing.Point(8, 342);
            this.lblBankCount.Name = "lblBankCount";
            this.lblBankCount.Size = new System.Drawing.Size(97, 13);
            this.lblBankCount.TabIndex = 4;
            this.lblBankCount.Text = "0 Bank(s) Found";
            // 
            // btnSaveBank
            // 
            this.btnSaveBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBank.Image = global::RealEstateManagementSystem.Properties.Resources.save;
            this.btnSaveBank.Location = new System.Drawing.Point(634, 75);
            this.btnSaveBank.Name = "btnSaveBank";
            this.btnSaveBank.Size = new System.Drawing.Size(75, 47);
            this.btnSaveBank.TabIndex = 3;
            this.btnSaveBank.Text = "Save";
            this.btnSaveBank.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveBank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveBank.UseVisualStyleBackColor = true;
            this.btnSaveBank.Click += new System.EventHandler(this.btnSaveBank_Click);
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(402, 49);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(307, 20);
            this.txtBankName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank Name:";
            // 
            // lstBank
            // 
            this.lstBank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBankId,
            this.colBankName});
            this.lstBank.FullRowSelect = true;
            this.lstBank.GridLines = true;
            this.lstBank.Location = new System.Drawing.Point(6, 6);
            this.lstBank.MultiSelect = false;
            this.lstBank.Name = "lstBank";
            this.lstBank.Size = new System.Drawing.Size(378, 333);
            this.lstBank.TabIndex = 0;
            this.lstBank.UseCompatibleStateImageBehavior = false;
            this.lstBank.View = System.Windows.Forms.View.Details;
            this.lstBank.SelectedIndexChanged += new System.EventHandler(this.lstBank_SelectedIndexChanged);
            // 
            // colBankId
            // 
            this.colBankId.Text = "BankId";
            this.colBankId.Width = 0;
            // 
            // colBankName
            // 
            this.colBankName.Text = "Bank Name";
            this.colBankName.Width = 292;
            // 
            // tpBranch
            // 
            this.tpBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpBranch.Controls.Add(this.btnRefreshBranchTab);
            this.tpBranch.Controls.Add(this.lblBranchCount);
            this.tpBranch.Controls.Add(this.btnSaveBranch);
            this.tpBranch.Controls.Add(this.txtBranchName);
            this.tpBranch.Controls.Add(this.label2);
            this.tpBranch.Controls.Add(this.lstBranch);
            this.tpBranch.Location = new System.Drawing.Point(4, 22);
            this.tpBranch.Name = "tpBranch";
            this.tpBranch.Padding = new System.Windows.Forms.Padding(3);
            this.tpBranch.Size = new System.Drawing.Size(730, 362);
            this.tpBranch.TabIndex = 1;
            this.tpBranch.Text = "Branch Information";
            this.tpBranch.UseVisualStyleBackColor = true;
            // 
            // lblBranchCount
            // 
            this.lblBranchCount.AutoSize = true;
            this.lblBranchCount.Location = new System.Drawing.Point(6, 341);
            this.lblBranchCount.Name = "lblBranchCount";
            this.lblBranchCount.Size = new System.Drawing.Size(103, 13);
            this.lblBranchCount.TabIndex = 8;
            this.lblBranchCount.Text = "0 Branches Found";
            // 
            // btnSaveBranch
            // 
            this.btnSaveBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBranch.Image = global::RealEstateManagementSystem.Properties.Resources.save;
            this.btnSaveBranch.Location = new System.Drawing.Point(642, 76);
            this.btnSaveBranch.Name = "btnSaveBranch";
            this.btnSaveBranch.Size = new System.Drawing.Size(75, 47);
            this.btnSaveBranch.TabIndex = 7;
            this.btnSaveBranch.Text = "Save";
            this.btnSaveBranch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveBranch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveBranch.UseVisualStyleBackColor = true;
            this.btnSaveBranch.Click += new System.EventHandler(this.btnSaveBranch_Click);
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(410, 50);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(307, 20);
            this.txtBranchName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Branch Name:";
            // 
            // lstBranch
            // 
            this.lstBranch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBranchId,
            this.colBranchName});
            this.lstBranch.FullRowSelect = true;
            this.lstBranch.GridLines = true;
            this.lstBranch.Location = new System.Drawing.Point(6, 7);
            this.lstBranch.MultiSelect = false;
            this.lstBranch.Name = "lstBranch";
            this.lstBranch.Size = new System.Drawing.Size(378, 331);
            this.lstBranch.TabIndex = 4;
            this.lstBranch.UseCompatibleStateImageBehavior = false;
            this.lstBranch.View = System.Windows.Forms.View.Details;
            this.lstBranch.SelectedIndexChanged += new System.EventHandler(this.lstBranch_SelectedIndexChanged);
            // 
            // colBranchId
            // 
            this.colBranchId.Text = "BranchId";
            this.colBranchId.Width = 0;
            // 
            // colBranchName
            // 
            this.colBranchName.Text = "Branch Name";
            this.colBranchName.Width = 288;
            // 
            // btnRefreshBank
            // 
            this.btnRefreshBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshBank.FlatAppearance.BorderSize = 0;
            this.btnRefreshBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRefreshBank.Image = global::RealEstateManagementSystem.Properties.Resources.refresh;
            this.btnRefreshBank.Location = new System.Drawing.Point(601, 75);
            this.btnRefreshBank.Name = "btnRefreshBank";
            this.btnRefreshBank.Size = new System.Drawing.Size(27, 24);
            this.btnRefreshBank.TabIndex = 7;
            this.btnRefreshBank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefreshBank.UseVisualStyleBackColor = true;
            this.btnRefreshBank.Click += new System.EventHandler(this.btnRefreshBank_Click);
            // 
            // btnRefreshBranchTab
            // 
            this.btnRefreshBranchTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshBranchTab.FlatAppearance.BorderSize = 0;
            this.btnRefreshBranchTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshBranchTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRefreshBranchTab.Image = global::RealEstateManagementSystem.Properties.Resources.refresh;
            this.btnRefreshBranchTab.Location = new System.Drawing.Point(609, 76);
            this.btnRefreshBranchTab.Name = "btnRefreshBranchTab";
            this.btnRefreshBranchTab.Size = new System.Drawing.Size(27, 24);
            this.btnRefreshBranchTab.TabIndex = 9;
            this.btnRefreshBranchTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefreshBranchTab.UseVisualStyleBackColor = true;
            this.btnRefreshBranchTab.Click += new System.EventHandler(this.btnRefreshBranchTab_Click);
            // 
            // frmDefinition_BankBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 388);
            this.Controls.Add(this.tcBankBranch);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDefinition_BankBranch";
            this.Text = "Bank & Branch Information";
            this.Load += new System.EventHandler(this.frmDefinition_BankBranch_Load);
            this.tcBankBranch.ResumeLayout(false);
            this.tpBank.ResumeLayout(false);
            this.tpBank.PerformLayout();
            this.tpBranch.ResumeLayout(false);
            this.tpBranch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tpBank;
        private System.Windows.Forms.TabPage tpBranch;
        private System.Windows.Forms.Button btnSaveBank;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstBank;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstBranch;
        private System.Windows.Forms.ColumnHeader colBankId;
        private System.Windows.Forms.ColumnHeader colBankName;
        private System.Windows.Forms.ColumnHeader colBranchId;
        private System.Windows.Forms.ColumnHeader colBranchName;
        private System.Windows.Forms.Button btnSaveBranch;
        public System.Windows.Forms.TabControl tcBankBranch;
        private System.Windows.Forms.Label lblBankCount;
        private System.Windows.Forms.Label lblBranchCount;
        private System.Windows.Forms.Button btnRefreshBank;
        private System.Windows.Forms.Button btnRefreshBranchTab;
    }
}