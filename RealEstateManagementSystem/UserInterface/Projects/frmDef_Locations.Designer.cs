namespace RealEstateManagementSystem.UserInterface.Projects
{
    partial class frmDef_Locations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDef_Locations));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRefresh_PI = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstLocationDetails = new System.Windows.Forms.ListView();
            this.cmbArea_Edit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAreas = new System.Windows.Forms.ComboBox();
            this.cmbDistrict_Edit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btnRefresh_PI);
            this.tabPage2.Controls.Add(this.btnSaveData);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.txtLocationName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lstLocationDetails);
            this.tabPage2.Controls.Add(this.cmbArea_Edit);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cmbAreas);
            this.tabPage2.Controls.Add(this.cmbDistrict_Edit);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbDistrict);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Location";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(285, 330);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 18);
            this.label14.TabIndex = 33;
            this.label14.Text = "(বাংলায়ঃ)";
            // 
            // btnRefresh_PI
            // 
            this.btnRefresh_PI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh_PI.FlatAppearance.BorderSize = 0;
            this.btnRefresh_PI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh_PI.Image = global::RealEstateManagementSystem.Properties.Resources.refresh;
            this.btnRefresh_PI.Location = new System.Drawing.Point(354, 378);
            this.btnRefresh_PI.Name = "btnRefresh_PI";
            this.btnRefresh_PI.Size = new System.Drawing.Size(34, 28);
            this.btnRefresh_PI.TabIndex = 32;
            this.btnRefresh_PI.TabStop = false;
            this.btnRefresh_PI.UseVisualStyleBackColor = true;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveData.Image = global::RealEstateManagementSystem.Properties.Resources.insert;
            this.btnSaveData.Location = new System.Drawing.Point(394, 376);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(92, 33);
            this.btnSaveData.TabIndex = 31;
            this.btnSaveData.Text = "Insert";
            this.btnSaveData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 23);
            this.textBox1.TabIndex = 4;
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(138, 328);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(141, 23);
            this.txtLocationName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location Name:";
            // 
            // lstLocationDetails
            // 
            this.lstLocationDetails.Location = new System.Drawing.Point(16, 38);
            this.lstLocationDetails.Name = "lstLocationDetails";
            this.lstLocationDetails.Size = new System.Drawing.Size(514, 282);
            this.lstLocationDetails.TabIndex = 2;
            this.lstLocationDetails.UseCompatibleStateImageBehavior = false;
            // 
            // cmbArea_Edit
            // 
            this.cmbArea_Edit.FormattingEnabled = true;
            this.cmbArea_Edit.Location = new System.Drawing.Point(138, 386);
            this.cmbArea_Edit.Name = "cmbArea_Edit";
            this.cmbArea_Edit.Size = new System.Drawing.Size(141, 23);
            this.cmbArea_Edit.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Area Name:";
            // 
            // cmbAreas
            // 
            this.cmbAreas.FormattingEnabled = true;
            this.cmbAreas.Location = new System.Drawing.Point(372, 9);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(158, 23);
            this.cmbAreas.TabIndex = 1;
            // 
            // cmbDistrict_Edit
            // 
            this.cmbDistrict_Edit.FormattingEnabled = true;
            this.cmbDistrict_Edit.Location = new System.Drawing.Point(138, 357);
            this.cmbDistrict_Edit.Name = "cmbDistrict_Edit";
            this.cmbDistrict_Edit.Size = new System.Drawing.Size(141, 23);
            this.cmbDistrict_Edit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Area Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "District Name:";
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(124, 9);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(159, 23);
            this.cmbDistrict.TabIndex = 1;
            this.cmbDistrict.SelectionChangeCommitted += new System.EventHandler(this.cmbDistrict_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "District Name:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Area";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(544, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "District";
            // 
            // frmDef_Locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(552, 448);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDef_Locations";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Locations";
            this.Load += new System.EventHandler(this.frmDef_Locations_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbAreas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstLocationDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.ComboBox cmbArea_Edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDistrict_Edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh_PI;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;



    }
}