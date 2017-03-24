namespace RealEstateManagementSystem.UserInterface.Root
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdLogIn = new System.Windows.Forms.Button();
            this.chkRememberLogIn = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ssLogIn = new System.Windows.Forms.StatusStrip();
            this.tssLogIn = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkRememberPassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ssLogIn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "LogIn Id:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(168, 12);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(122, 22);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(168, 40);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '^';
            this.txtPassword.Size = new System.Drawing.Size(122, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "adhora";
            // 
            // cmdLogIn
            // 
            this.cmdLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLogIn.FlatAppearance.BorderSize = 0;
            this.cmdLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLogIn.Image = global::RealEstateManagementSystem.Properties.Resources.login_circle;
            this.cmdLogIn.Location = new System.Drawing.Point(299, 53);
            this.cmdLogIn.Name = "cmdLogIn";
            this.cmdLogIn.Size = new System.Drawing.Size(60, 40);
            this.cmdLogIn.TabIndex = 2;
            this.cmdLogIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdLogIn.UseVisualStyleBackColor = true;
            this.cmdLogIn.Click += new System.EventHandler(this.cmdLogIn_Click);
            // 
            // chkRememberLogIn
            // 
            this.chkRememberLogIn.AutoSize = true;
            this.chkRememberLogIn.Location = new System.Drawing.Point(76, 3);
            this.chkRememberLogIn.Name = "chkRememberLogIn";
            this.chkRememberLogIn.Size = new System.Drawing.Size(40, 18);
            this.chkRememberLogIn.TabIndex = 3;
            this.chkRememberLogIn.Text = "Id";
            this.chkRememberLogIn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RealEstateManagementSystem.Properties.Resources.REMS1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 68);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ssLogIn
            // 
            this.ssLogIn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLogIn});
            this.ssLogIn.Location = new System.Drawing.Point(0, 103);
            this.ssLogIn.Name = "ssLogIn";
            this.ssLogIn.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssLogIn.Size = new System.Drawing.Size(371, 22);
            this.ssLogIn.SizingGrip = false;
            this.ssLogIn.TabIndex = 8;
            // 
            // tssLogIn
            // 
            this.tssLogIn.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLogIn.Name = "tssLogIn";
            this.tssLogIn.Size = new System.Drawing.Size(356, 17);
            this.tssLogIn.Spring = true;
            this.tssLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox1
            // 
            this.chkRememberPassword.AutoSize = true;
            this.chkRememberPassword.Location = new System.Drawing.Point(122, 3);
            this.chkRememberPassword.Name = "checkBox1";
            this.chkRememberPassword.Size = new System.Drawing.Size(82, 18);
            this.chkRememberPassword.TabIndex = 3;
            this.chkRememberPassword.Text = "Password";
            this.chkRememberPassword.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Remember";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkRememberPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkRememberLogIn);
            this.panel1.Location = new System.Drawing.Point(84, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 25);
            this.panel1.TabIndex = 10;
            // 
            // frmLogIn
            // 
            this.AcceptButton = this.cmdLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(371, 125);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssLogIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ssLogIn.ResumeLayout(false);
            this.ssLogIn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button cmdLogIn;
        private System.Windows.Forms.CheckBox chkRememberLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip ssLogIn;
        private System.Windows.Forms.ToolStripStatusLabel tssLogIn;
        private System.Windows.Forms.CheckBox chkRememberPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}