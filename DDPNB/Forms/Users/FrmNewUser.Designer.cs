namespace DDPNB.Forms.Users
{
    partial class FrmNewUser
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
            this.lblName = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tBoxPhone = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tBoxAddress = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbBoxRole = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkBoxMultiSession = new System.Windows.Forms.CheckBox();
            this.chkBoxActive = new System.Windows.Forms.CheckBox();
            this.panelbody = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelHead = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelbody.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(64, 3);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(250, 20);
            this.tBoxName.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(5, 32);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(64, 29);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(250, 20);
            this.tBoxEmail.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(5, 58);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // tBoxPhone
            // 
            this.tBoxPhone.Location = new System.Drawing.Point(64, 55);
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(250, 20);
            this.tBoxPhone.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(320, 6);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(379, 3);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(194, 20);
            this.tBoxPassword.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(5, 84);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            // 
            // tBoxAddress
            // 
            this.tBoxAddress.Location = new System.Drawing.Point(64, 81);
            this.tBoxAddress.Multiline = true;
            this.tBoxAddress.Name = "tBoxAddress";
            this.tBoxAddress.Size = new System.Drawing.Size(250, 51);
            this.tBoxAddress.TabIndex = 12;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(320, 31);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Role";
            // 
            // cmbBoxRole
            // 
            this.cmbBoxRole.FormattingEnabled = true;
            this.cmbBoxRole.Location = new System.Drawing.Point(379, 28);
            this.cmbBoxRole.Name = "cmbBoxRole";
            this.cmbBoxRole.Size = new System.Drawing.Size(194, 21);
            this.cmbBoxRole.TabIndex = 16;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(392, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit (F2)";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(485, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel (ESC)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkBoxMultiSession
            // 
            this.chkBoxMultiSession.AutoSize = true;
            this.chkBoxMultiSession.Location = new System.Drawing.Point(379, 55);
            this.chkBoxMultiSession.Name = "chkBoxMultiSession";
            this.chkBoxMultiSession.Size = new System.Drawing.Size(88, 17);
            this.chkBoxMultiSession.TabIndex = 19;
            this.chkBoxMultiSession.Text = "Multi Session";
            this.chkBoxMultiSession.UseVisualStyleBackColor = true;
            // 
            // chkBoxActive
            // 
            this.chkBoxActive.AutoSize = true;
            this.chkBoxActive.Location = new System.Drawing.Point(379, 78);
            this.chkBoxActive.Name = "chkBoxActive";
            this.chkBoxActive.Size = new System.Drawing.Size(56, 17);
            this.chkBoxActive.TabIndex = 20;
            this.chkBoxActive.Text = "Active";
            this.chkBoxActive.UseVisualStyleBackColor = true;
            // 
            // panelbody
            // 
            this.panelbody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbody.Controls.Add(this.tBoxName);
            this.panelbody.Controls.Add(this.lblName);
            this.panelbody.Controls.Add(this.chkBoxActive);
            this.panelbody.Controls.Add(this.tBoxEmail);
            this.panelbody.Controls.Add(this.chkBoxMultiSession);
            this.panelbody.Controls.Add(this.lblEmail);
            this.panelbody.Controls.Add(this.tBoxPhone);
            this.panelbody.Controls.Add(this.lblPhone);
            this.panelbody.Controls.Add(this.cmbBoxRole);
            this.panelbody.Controls.Add(this.tBoxPassword);
            this.panelbody.Controls.Add(this.lblRole);
            this.panelbody.Controls.Add(this.lblPassword);
            this.panelbody.Controls.Add(this.lblAddress);
            this.panelbody.Controls.Add(this.tBoxAddress);
            this.panelbody.Location = new System.Drawing.Point(12, 42);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(576, 138);
            this.panelbody.TabIndex = 22;
            // 
            // panelFooter
            // 
            this.panelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFooter.Controls.Add(this.btnCancel);
            this.panelFooter.Controls.Add(this.btnSubmit);
            this.panelFooter.Location = new System.Drawing.Point(12, 186);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(576, 29);
            this.panelFooter.TabIndex = 23;
            // 
            // panelHead
            // 
            this.panelHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHead.Controls.Add(this.lblTitle);
            this.panelHead.Location = new System.Drawing.Point(12, 7);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(576, 29);
            this.panelHead.TabIndex = 25;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(254, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(3);
            this.lblTitle.Size = new System.Drawing.Size(68, 21);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "New User";
            // 
            // FrmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 225);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelbody);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmNewUser";
            this.Text = "New User";
            this.Load += new System.EventHandler(this.FrmNewUser_Load);
            this.panelbody.ResumeLayout(false);
            this.panelbody.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tBoxPhone;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tBoxAddress;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbBoxRole;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkBoxMultiSession;
        private System.Windows.Forms.CheckBox chkBoxActive;
        private System.Windows.Forms.Panel panelbody;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label lblTitle;
    }
}