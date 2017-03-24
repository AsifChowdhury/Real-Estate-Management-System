namespace RealEstateManagementSystem.UserInterface.Clients
{
    partial class frmDefinition_NOR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDefinition_NOR));
            this.bntSave = new System.Windows.Forms.Button();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.lvDefinition = new System.Windows.Forms.ListView();
            this.rbNationality = new System.Windows.Forms.RadioButton();
            this.rbOccupation = new System.Windows.Forms.RadioButton();
            this.rbReligion = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntSave
            // 
            this.bntSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSave.Image = global::RealEstateManagementSystem.Properties.Resources.insert;
            this.bntSave.Location = new System.Drawing.Point(293, 40);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(88, 51);
            this.bntSave.TabIndex = 7;
            this.bntSave.Text = "Save";
            this.bntSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(100, 11);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(281, 23);
            this.txtDefinition.TabIndex = 6;
            // 
            // lblDefinition
            // 
            this.lblDefinition.Location = new System.Drawing.Point(3, 11);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(91, 23);
            this.lblDefinition.TabIndex = 5;
            this.lblDefinition.Text = "Nationality:";
            this.lblDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvDefinition
            // 
            this.lvDefinition.Location = new System.Drawing.Point(8, 3);
            this.lvDefinition.Name = "lvDefinition";
            this.lvDefinition.Size = new System.Drawing.Size(588, 222);
            this.lvDefinition.TabIndex = 4;
            this.lvDefinition.UseCompatibleStateImageBehavior = false;
            this.lvDefinition.SelectedIndexChanged += new System.EventHandler(this.lvDefinition_SelectedIndexChanged);
            this.lvDefinition.Click += new System.EventHandler(this.lvDefinition_Click);
            // 
            // rbNationality
            // 
            this.rbNationality.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNationality.AutoSize = true;
            this.rbNationality.Checked = true;
            this.rbNationality.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNationality.Location = new System.Drawing.Point(7, 8);
            this.rbNationality.Name = "rbNationality";
            this.rbNationality.Size = new System.Drawing.Size(94, 25);
            this.rbNationality.TabIndex = 9;
            this.rbNationality.TabStop = true;
            this.rbNationality.Text = "Nationality";
            this.rbNationality.UseVisualStyleBackColor = true;
            this.rbNationality.CheckedChanged += new System.EventHandler(this.rbNationality_CheckedChanged);
            // 
            // rbOccupation
            // 
            this.rbOccupation.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbOccupation.AutoSize = true;
            this.rbOccupation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbOccupation.Location = new System.Drawing.Point(118, 8);
            this.rbOccupation.Name = "rbOccupation";
            this.rbOccupation.Size = new System.Drawing.Size(87, 25);
            this.rbOccupation.TabIndex = 9;
            this.rbOccupation.Text = "Occupation";
            this.rbOccupation.UseVisualStyleBackColor = true;
            this.rbOccupation.CheckedChanged += new System.EventHandler(this.rbOccupation_CheckedChanged);
            // 
            // rbReligion
            // 
            this.rbReligion.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbReligion.AutoSize = true;
            this.rbReligion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbReligion.Location = new System.Drawing.Point(222, 8);
            this.rbReligion.Name = "rbReligion";
            this.rbReligion.Size = new System.Drawing.Size(73, 25);
            this.rbReligion.TabIndex = 9;
            this.rbReligion.Text = "Religion";
            this.rbReligion.UseVisualStyleBackColor = true;
            this.rbReligion.CheckedChanged += new System.EventHandler(this.rbReligion_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbReligion);
            this.panel1.Controls.Add(this.rbOccupation);
            this.panel1.Controls.Add(this.rbNationality);
            this.panel1.Location = new System.Drawing.Point(153, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 42);
            this.panel1.TabIndex = 10;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(8, 230);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(126, 15);
            this.lblRecordCount.TabIndex = 5;
            this.lblRecordCount.Text = "0 Record(s) Found";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::RealEstateManagementSystem.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(260, 40);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(27, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lvDefinition);
            this.panel2.Controls.Add(this.lblRecordCount);
            this.panel2.Location = new System.Drawing.Point(12, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 254);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.bntSave);
            this.panel3.Controls.Add(this.txtDefinition);
            this.panel3.Controls.Add(this.lblDefinition);
            this.panel3.Location = new System.Drawing.Point(227, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 99);
            this.panel3.TabIndex = 13;
            // 
            // frmDefinition_NOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 416);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDefinition_NOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definition";
            this.Load += new System.EventHandler(this.frmDefinition_NOR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.ListView lvDefinition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.RadioButton rbNationality;
        public System.Windows.Forms.RadioButton rbOccupation;
        public System.Windows.Forms.RadioButton rbReligion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}