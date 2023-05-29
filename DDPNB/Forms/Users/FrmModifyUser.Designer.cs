namespace DDPNB.Forms.Users
{
    partial class FrmModifyUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHead = new System.Windows.Forms.Panel();
            this.panelbody = new System.Windows.Forms.Panel();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.chkBoxActive = new System.Windows.Forms.CheckBox();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.chkBoxMultiSession = new System.Windows.Forms.CheckBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tBoxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cmbBoxRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tBoxAddress = new System.Windows.Forms.TextBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValueUpdatedBy = new System.Windows.Forms.Label();
            this.lblValueCreatedBy = new System.Windows.Forms.Label();
            this.lblValueUpdatedAt = new System.Windows.Forms.Label();
            this.lblValueCreatedAt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.panelbody.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelHead);
            this.panel1.Controls.Add(this.panelbody);
            this.panel1.Controls.Add(this.panelFooter);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 232);
            this.panel1.TabIndex = 27;
            // 
            // panelHead
            // 
            this.panelHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHead.Controls.Add(this.lblTitle);
            this.panelHead.Location = new System.Drawing.Point(3, 3);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(576, 29);
            this.panelHead.TabIndex = 25;
            // 
            // panelbody
            // 
            this.panelbody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelbody.Controls.Add(this.lblValueUpdatedBy);
            this.panelbody.Controls.Add(this.lblValueCreatedBy);
            this.panelbody.Controls.Add(this.lblValueUpdatedAt);
            this.panelbody.Controls.Add(this.lblValueCreatedAt);
            this.panelbody.Controls.Add(this.label4);
            this.panelbody.Controls.Add(this.label3);
            this.panelbody.Controls.Add(this.label2);
            this.panelbody.Controls.Add(this.label1);
            this.panelbody.Controls.Add(this.tBoxName);
            this.panelbody.Controls.Add(this.lblName);
            this.panelbody.Controls.Add(this.chkBoxActive);
            this.panelbody.Controls.Add(this.tBoxEmail);
            this.panelbody.Controls.Add(this.chkBoxMultiSession);
            this.panelbody.Controls.Add(this.lblEmail);
            this.panelbody.Controls.Add(this.tBoxPhone);
            this.panelbody.Controls.Add(this.lblPhone);
            this.panelbody.Controls.Add(this.cmbBoxRole);
            this.panelbody.Controls.Add(this.lblRole);
            this.panelbody.Controls.Add(this.lblAddress);
            this.panelbody.Controls.Add(this.tBoxAddress);
            this.panelbody.Location = new System.Drawing.Point(3, 38);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(576, 154);
            this.panelbody.TabIndex = 22;
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(64, 3);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(250, 20);
            this.tBoxName.TabIndex = 4;
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
            // chkBoxActive
            // 
            this.chkBoxActive.AutoSize = true;
            this.chkBoxActive.Location = new System.Drawing.Point(377, 53);
            this.chkBoxActive.Name = "chkBoxActive";
            this.chkBoxActive.Size = new System.Drawing.Size(56, 17);
            this.chkBoxActive.TabIndex = 20;
            this.chkBoxActive.Text = "Active";
            this.chkBoxActive.UseVisualStyleBackColor = true;
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(64, 29);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(250, 20);
            this.tBoxEmail.TabIndex = 6;
            // 
            // chkBoxMultiSession
            // 
            this.chkBoxMultiSession.AutoSize = true;
            this.chkBoxMultiSession.Location = new System.Drawing.Point(377, 30);
            this.chkBoxMultiSession.Name = "chkBoxMultiSession";
            this.chkBoxMultiSession.Size = new System.Drawing.Size(88, 17);
            this.chkBoxMultiSession.TabIndex = 19;
            this.chkBoxMultiSession.Text = "Multi Session";
            this.chkBoxMultiSession.UseVisualStyleBackColor = true;
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
            // tBoxPhone
            // 
            this.tBoxPhone.Location = new System.Drawing.Point(64, 55);
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(250, 20);
            this.tBoxPhone.TabIndex = 8;
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
            // cmbBoxRole
            // 
            this.cmbBoxRole.FormattingEnabled = true;
            this.cmbBoxRole.Location = new System.Drawing.Point(377, 3);
            this.cmbBoxRole.Name = "cmbBoxRole";
            this.cmbBoxRole.Size = new System.Drawing.Size(194, 21);
            this.cmbBoxRole.TabIndex = 16;
            this.cmbBoxRole.SelectedIndexChanged += new System.EventHandler(this.cmbBoxRole_SelectedIndexChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(320, 6);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Role";
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
            this.tBoxAddress.Size = new System.Drawing.Size(250, 65);
            this.tBoxAddress.TabIndex = 12;
            // 
            // panelFooter
            // 
            this.panelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFooter.Controls.Add(this.btnCancel);
            this.panelFooter.Controls.Add(this.btnSubmit);
            this.panelFooter.Location = new System.Drawing.Point(4, 198);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(574, 29);
            this.panelFooter.TabIndex = 23;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(481, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel (ESC)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(388, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit (F2)";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(247, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(3);
            this.lblTitle.Size = new System.Drawing.Size(81, 21);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Modify User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Created At";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Updated At";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Created By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Updated By";
            // 
            // lblValueUpdatedBy
            // 
            this.lblValueUpdatedBy.AutoSize = true;
            this.lblValueUpdatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueUpdatedBy.Location = new System.Drawing.Point(386, 133);
            this.lblValueUpdatedBy.Margin = new System.Windows.Forms.Padding(3);
            this.lblValueUpdatedBy.Name = "lblValueUpdatedBy";
            this.lblValueUpdatedBy.Size = new System.Drawing.Size(24, 13);
            this.lblValueUpdatedBy.TabIndex = 28;
            this.lblValueUpdatedBy.Text = "NA";
            // 
            // lblValueCreatedBy
            // 
            this.lblValueCreatedBy.AutoSize = true;
            this.lblValueCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueCreatedBy.Location = new System.Drawing.Point(386, 95);
            this.lblValueCreatedBy.Margin = new System.Windows.Forms.Padding(3);
            this.lblValueCreatedBy.Name = "lblValueCreatedBy";
            this.lblValueCreatedBy.Size = new System.Drawing.Size(24, 13);
            this.lblValueCreatedBy.TabIndex = 27;
            this.lblValueCreatedBy.Text = "NA";
            // 
            // lblValueUpdatedAt
            // 
            this.lblValueUpdatedAt.AutoSize = true;
            this.lblValueUpdatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueUpdatedAt.Location = new System.Drawing.Point(386, 114);
            this.lblValueUpdatedAt.Margin = new System.Windows.Forms.Padding(3);
            this.lblValueUpdatedAt.Name = "lblValueUpdatedAt";
            this.lblValueUpdatedAt.Size = new System.Drawing.Size(24, 13);
            this.lblValueUpdatedAt.TabIndex = 26;
            this.lblValueUpdatedAt.Text = "NA";
            // 
            // lblValueCreatedAt
            // 
            this.lblValueCreatedAt.AutoSize = true;
            this.lblValueCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueCreatedAt.Location = new System.Drawing.Point(386, 76);
            this.lblValueCreatedAt.Margin = new System.Windows.Forms.Padding(3);
            this.lblValueCreatedAt.Name = "lblValueCreatedAt";
            this.lblValueCreatedAt.Size = new System.Drawing.Size(24, 13);
            this.lblValueCreatedAt.TabIndex = 25;
            this.lblValueCreatedAt.Text = "NA";
            // 
            // FrmModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 256);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmModifyUser";
            this.Text = "Modify User";
            this.Load += new System.EventHandler(this.FrmModifyUser_Load);
            this.panel1.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelbody.ResumeLayout(false);
            this.panelbody.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelbody;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox chkBoxActive;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.CheckBox chkBoxMultiSession;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tBoxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox cmbBoxRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tBoxAddress;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblValueUpdatedBy;
        private System.Windows.Forms.Label lblValueCreatedBy;
        private System.Windows.Forms.Label lblValueUpdatedAt;
        private System.Windows.Forms.Label lblValueCreatedAt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}