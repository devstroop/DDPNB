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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelbody = new System.Windows.Forms.Panel();
            this.lblValueUpdatedBy = new System.Windows.Forms.Label();
            this.lblValueCreatedBy = new System.Windows.Forms.Label();
            this.lblValueUpdatedAt = new System.Windows.Forms.Label();
            this.lblValueCreatedAt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblValueId = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 285);
            this.panel1.TabIndex = 27;
            // 
            // panelHead
            // 
            this.panelHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHead.Controls.Add(this.lblTitle);
            this.panelHead.Location = new System.Drawing.Point(4, 4);
            this.panelHead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(767, 35);
            this.panelHead.TabIndex = 25;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(329, 4);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTitle.Size = new System.Drawing.Size(83, 23);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Modify User";
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
            this.panelbody.Location = new System.Drawing.Point(4, 47);
            this.panelbody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(767, 189);
            this.panelbody.TabIndex = 22;
            // 
            // lblValueUpdatedBy
            // 
            this.lblValueUpdatedBy.AutoSize = true;
            this.lblValueUpdatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueUpdatedBy.Location = new System.Drawing.Point(515, 164);
            this.lblValueUpdatedBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblValueUpdatedBy.Name = "lblValueUpdatedBy";
            this.lblValueUpdatedBy.Size = new System.Drawing.Size(24, 13);
            this.lblValueUpdatedBy.TabIndex = 28;
            this.lblValueUpdatedBy.Text = "NA";
            // 
            // lblValueCreatedBy
            // 
            this.lblValueCreatedBy.AutoSize = true;
            this.lblValueCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueCreatedBy.Location = new System.Drawing.Point(515, 117);
            this.lblValueCreatedBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblValueCreatedBy.Name = "lblValueCreatedBy";
            this.lblValueCreatedBy.Size = new System.Drawing.Size(24, 13);
            this.lblValueCreatedBy.TabIndex = 27;
            this.lblValueCreatedBy.Text = "NA";
            // 
            // lblValueUpdatedAt
            // 
            this.lblValueUpdatedAt.AutoSize = true;
            this.lblValueUpdatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueUpdatedAt.Location = new System.Drawing.Point(515, 140);
            this.lblValueUpdatedAt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblValueUpdatedAt.Name = "lblValueUpdatedAt";
            this.lblValueUpdatedAt.Size = new System.Drawing.Size(24, 13);
            this.lblValueUpdatedAt.TabIndex = 26;
            this.lblValueUpdatedAt.Text = "NA";
            // 
            // lblValueCreatedAt
            // 
            this.lblValueCreatedAt.AutoSize = true;
            this.lblValueCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueCreatedAt.Location = new System.Drawing.Point(515, 94);
            this.lblValueCreatedAt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblValueCreatedAt.Name = "lblValueCreatedAt";
            this.lblValueCreatedAt.Size = new System.Drawing.Size(24, 13);
            this.lblValueCreatedAt.TabIndex = 25;
            this.lblValueCreatedAt.Text = "NA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Updated By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Created By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Updated At";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Created At";
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(85, 4);
            this.tBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(332, 22);
            this.tBoxName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 7);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // chkBoxActive
            // 
            this.chkBoxActive.AutoSize = true;
            this.chkBoxActive.Location = new System.Drawing.Point(503, 65);
            this.chkBoxActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBoxActive.Name = "chkBoxActive";
            this.chkBoxActive.Size = new System.Drawing.Size(63, 20);
            this.chkBoxActive.TabIndex = 20;
            this.chkBoxActive.Text = "Active";
            this.chkBoxActive.UseVisualStyleBackColor = true;
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(85, 36);
            this.tBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(332, 22);
            this.tBoxEmail.TabIndex = 6;
            // 
            // chkBoxMultiSession
            // 
            this.chkBoxMultiSession.AutoSize = true;
            this.chkBoxMultiSession.Location = new System.Drawing.Point(503, 37);
            this.chkBoxMultiSession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBoxMultiSession.Name = "chkBoxMultiSession";
            this.chkBoxMultiSession.Size = new System.Drawing.Size(105, 20);
            this.chkBoxMultiSession.TabIndex = 19;
            this.chkBoxMultiSession.Text = "Multi Session";
            this.chkBoxMultiSession.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 39);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // tBoxPhone
            // 
            this.tBoxPhone.Location = new System.Drawing.Point(85, 68);
            this.tBoxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(332, 22);
            this.tBoxPhone.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(7, 71);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // cmbBoxRole
            // 
            this.cmbBoxRole.FormattingEnabled = true;
            this.cmbBoxRole.Location = new System.Drawing.Point(503, 4);
            this.cmbBoxRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBoxRole.Name = "cmbBoxRole";
            this.cmbBoxRole.Size = new System.Drawing.Size(257, 24);
            this.cmbBoxRole.TabIndex = 16;
            this.cmbBoxRole.SelectedIndexChanged += new System.EventHandler(this.cmbBoxRole_SelectedIndexChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(427, 7);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(36, 16);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Role";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 103);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            // 
            // tBoxAddress
            // 
            this.tBoxAddress.Location = new System.Drawing.Point(85, 100);
            this.tBoxAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxAddress.Multiline = true;
            this.tBoxAddress.Name = "tBoxAddress";
            this.tBoxAddress.Size = new System.Drawing.Size(332, 79);
            this.tBoxAddress.TabIndex = 12;
            // 
            // panelFooter
            // 
            this.panelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFooter.Controls.Add(this.lblValueId);
            this.panelFooter.Controls.Add(this.label5);
            this.panelFooter.Controls.Add(this.btnCancel);
            this.panelFooter.Controls.Add(this.btnSubmit);
            this.panelFooter.Location = new System.Drawing.Point(5, 244);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(765, 35);
            this.panelFooter.TabIndex = 23;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(641, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 28);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel (ESC)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(517, 4);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(116, 28);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit (F2)";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Id";
            // 
            // lblValueId
            // 
            this.lblValueId.AutoSize = true;
            this.lblValueId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueId.Location = new System.Drawing.Point(30, 10);
            this.lblValueId.Name = "lblValueId";
            this.lblValueId.Size = new System.Drawing.Size(28, 16);
            this.lblValueId.TabIndex = 20;
            this.lblValueId.Text = "NA";
            // 
            // FrmModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 315);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmModifyUser";
            this.Text = "Modify User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmModifyUser_FormClosing);
            this.Load += new System.EventHandler(this.FrmModifyUser_Load);
            this.panel1.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelbody.ResumeLayout(false);
            this.panelbody.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
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
        private System.Windows.Forms.Label lblValueId;
        private System.Windows.Forms.Label label5;
    }
}