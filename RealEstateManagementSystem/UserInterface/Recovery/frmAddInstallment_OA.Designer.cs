namespace RealEstateManagementSystem.UserInterface.Recovery
{
    partial class frmAddInstallment_OA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddInstallment_OA));
            this.label1 = new System.Windows.Forms.Label();
            this.lblClientId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUnitNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstInstallments = new System.Windows.Forms.ListView();
            this.colInstallmentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInstallmentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbInstallType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNewInstallment = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInstallmentName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ttAddInstallment = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(95, 9);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(105, 14);
            this.lblClientId.TabIndex = 1;
            this.lblClientId.Text = "SEL-0000-00000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(95, 28);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(231, 14);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Asif md. moinul hassan chowdhury";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unit #:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnitNumber
            // 
            this.lblUnitNumber.AutoSize = true;
            this.lblUnitNumber.Location = new System.Drawing.Point(95, 47);
            this.lblUnitNumber.Name = "lblUnitNumber";
            this.lblUnitNumber.Size = new System.Drawing.Size(147, 14);
            this.lblUnitNumber.TabIndex = 1;
            this.lblUnitNumber.Text = "Bishal ekkhan string";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Installment Type:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lstInstallments);
            this.panel1.Controls.Add(this.cmbInstallType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(11, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 204);
            this.panel1.TabIndex = 3;
            // 
            // lstInstallments
            // 
            this.lstInstallments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colInstallmentId,
            this.colInstallmentName,
            this.colAmount});
            this.lstInstallments.FullRowSelect = true;
            this.lstInstallments.GridLines = true;
            this.lstInstallments.HideSelection = false;
            this.lstInstallments.Location = new System.Drawing.Point(9, 35);
            this.lstInstallments.Name = "lstInstallments";
            this.lstInstallments.Size = new System.Drawing.Size(416, 158);
            this.lstInstallments.TabIndex = 4;
            this.lstInstallments.UseCompatibleStateImageBehavior = false;
            this.lstInstallments.View = System.Windows.Forms.View.Details;
            this.lstInstallments.SelectedIndexChanged += new System.EventHandler(this.lstInstallments_SelectedIndexChanged);
            // 
            // colInstallmentId
            // 
            this.colInstallmentId.Width = 0;
            // 
            // colInstallmentName
            // 
            this.colInstallmentName.Text = "Installment Name";
            this.colInstallmentName.Width = 223;
            // 
            // colAmount
            // 
            this.colAmount.Text = "Amount";
            this.colAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colAmount.Width = 100;
            // 
            // cmbInstallType
            // 
            this.cmbInstallType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstallType.FormattingEnabled = true;
            this.cmbInstallType.Location = new System.Drawing.Point(134, 7);
            this.cmbInstallType.Name = "cmbInstallType";
            this.cmbInstallType.Size = new System.Drawing.Size(207, 22);
            this.cmbInstallType.TabIndex = 3;
            this.cmbInstallType.SelectionChangeCommitted += new System.EventHandler(this.cmbInstallType_SelectionChangeCommitted);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnNewInstallment);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbInstallmentName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(11, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 69);
            this.panel2.TabIndex = 4;
            // 
            // btnNewInstallment
            // 
            this.btnNewInstallment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewInstallment.FlatAppearance.BorderSize = 0;
            this.btnNewInstallment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewInstallment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNewInstallment.Image = global::RealEstateManagementSystem.Properties.Resources.refresh;
            this.btnNewInstallment.Location = new System.Drawing.Point(318, 6);
            this.btnNewInstallment.Name = "btnNewInstallment";
            this.btnNewInstallment.Size = new System.Drawing.Size(27, 24);
            this.btnNewInstallment.TabIndex = 11;
            this.btnNewInstallment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewInstallment.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::RealEstateManagementSystem.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(351, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label45);
            this.panel5.Controls.Add(this.label44);
            this.panel5.Controls.Add(this.txtAmount);
            this.panel5.Location = new System.Drawing.Point(147, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 21);
            this.panel5.TabIndex = 3;
            // 
            // label45
            // 
            this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(1, 3);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(28, 14);
            this.label45.TabIndex = 12;
            this.label45.Text = "Tk.";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label44
            // 
            this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(142, 3);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(21, 14);
            this.label44.TabIndex = 11;
            this.label44.Text = "/-";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Location = new System.Drawing.Point(23, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(118, 15);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "Amount:";
            // 
            // cmbInstallmentName
            // 
            this.cmbInstallmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstallmentName.FormattingEnabled = true;
            this.cmbInstallmentName.Location = new System.Drawing.Point(147, 8);
            this.cmbInstallmentName.Name = "cmbInstallmentName";
            this.cmbInstallmentName.Size = new System.Drawing.Size(165, 22);
            this.cmbInstallmentName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Installment Name:";
            // 
            // frmAddInstallment_OA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 359);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUnitNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddInstallment_OA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Installment";
            this.Load += new System.EventHandler(this.frmAddInstallment_OA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbInstallType;
        private System.Windows.Forms.ListView lstInstallments;
        private System.Windows.Forms.ColumnHeader colInstallmentId;
        private System.Windows.Forms.ColumnHeader colInstallmentName;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbInstallmentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewInstallment;
        public System.Windows.Forms.Label lblClientId;
        public System.Windows.Forms.Label lblClientName;
        public System.Windows.Forms.Label lblUnitNumber;
        private System.Windows.Forms.ToolTip ttAddInstallment;
    }
}