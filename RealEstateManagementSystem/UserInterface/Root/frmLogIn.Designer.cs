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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "LogIn Id:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(102, 12);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(122, 22);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(102, 40);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '^';
            this.txtPassword.Size = new System.Drawing.Size(122, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "adhora";
            // 
            // cmdLogIn
            // 
            this.cmdLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLogIn.Image = global::RealEstateManagementSystem.Properties.Resources.login;
            this.cmdLogIn.Location = new System.Drawing.Point(164, 92);
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
            this.chkRememberLogIn.Location = new System.Drawing.Point(100, 68);
            this.chkRememberLogIn.Name = "chkRememberLogIn";
            this.chkRememberLogIn.Size = new System.Drawing.Size(124, 18);
            this.chkRememberLogIn.TabIndex = 3;
            this.chkRememberLogIn.Text = "Remember my Id";
            this.chkRememberLogIn.UseVisualStyleBackColor = true;
            // 
            // frmLogIn
            // 
            this.AcceptButton = this.cmdLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(249, 144);
            this.Controls.Add(this.chkRememberLogIn);
            this.Controls.Add(this.cmdLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
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
    }
}