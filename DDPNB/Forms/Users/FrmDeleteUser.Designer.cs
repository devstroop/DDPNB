namespace DDPNB.Forms.Users
{
    partial class FrmDeleteUser
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
            this.lblValueUpdatedBy = new System.Windows.Forms.Label();
            this.lblValueCreatedBy = new System.Windows.Forms.Label();
            this.lblValueUpdatedAt = new System.Windows.Forms.Label();
            this.lblValueCreatedAt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblValueId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkBoxConfirm = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblValueName = new System.Windows.Forms.Label();
            this.lblValueEmail = new System.Windows.Forms.Label();
            this.lblValuePhone = new System.Windows.Forms.Label();
            this.lblValueAddress = new System.Windows.Forms.Label();
            this.lblValueRole = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(583, 237);
            this.panel1.TabIndex = 28;
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
            this.panelbody.Controls.Add(this.lblValueRole);
            this.panelbody.Controls.Add(this.lblValueId);
            this.panelbody.Controls.Add(this.label5);
            this.panelbody.Controls.Add(this.lblValueAddress);
            this.panelbody.Controls.Add(this.lblValuePhone);
            this.panelbody.Controls.Add(this.lblValueEmail);
            this.panelbody.Controls.Add(this.lblValueName);
            this.panelbody.Controls.Add(this.lblValueUpdatedBy);
            this.panelbody.Controls.Add(this.lblValueCreatedBy);
            this.panelbody.Controls.Add(this.lblValueUpdatedAt);
            this.panelbody.Controls.Add(this.lblValueCreatedAt);
            this.panelbody.Controls.Add(this.label4);
            this.panelbody.Controls.Add(this.label3);
            this.panelbody.Controls.Add(this.label2);
            this.panelbody.Controls.Add(this.label1);
            this.panelbody.Controls.Add(this.lblName);
            this.panelbody.Controls.Add(this.lblEmail);
            this.panelbody.Controls.Add(this.lblPhone);
            this.panelbody.Controls.Add(this.lblRole);
            this.panelbody.Controls.Add(this.lblAddress);
            this.panelbody.Location = new System.Drawing.Point(3, 38);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(576, 159);
            this.panelbody.TabIndex = 22;
            // 
            // lblValueUpdatedBy
            // 
            this.lblValueUpdatedBy.AutoSize = true;
            this.lblValueUpdatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueUpdatedBy.Location = new System.Drawing.Point(386, 73);
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
            this.lblValueCreatedBy.Location = new System.Drawing.Point(386, 35);
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
            this.lblValueUpdatedAt.Location = new System.Drawing.Point(386, 54);
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
            this.lblValueCreatedAt.Location = new System.Drawing.Point(386, 16);
            this.lblValueCreatedAt.Margin = new System.Windows.Forms.Padding(3);
            this.lblValueCreatedAt.Name = "lblValueCreatedAt";
            this.lblValueCreatedAt.Size = new System.Drawing.Size(24, 13);
            this.lblValueCreatedAt.TabIndex = 25;
            this.lblValueCreatedAt.Text = "NA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Updated By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Created By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Updated At";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Created At";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 56);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(23, 75);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(23, 113);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Role";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(23, 94);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            // 
            // panelFooter
            // 
            this.panelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFooter.Controls.Add(this.btnCancel);
            this.panelFooter.Controls.Add(this.btnDelete);
            this.panelFooter.Controls.Add(this.chkBoxConfirm);
            this.panelFooter.Location = new System.Drawing.Point(4, 203);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(574, 29);
            this.panelFooter.TabIndex = 23;
            // 
            // lblValueId
            // 
            this.lblValueId.AutoSize = true;
            this.lblValueId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueId.Location = new System.Drawing.Point(89, 13);
            this.lblValueId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValueId.Name = "lblValueId";
            this.lblValueId.Size = new System.Drawing.Size(28, 16);
            this.lblValueId.TabIndex = 20;
            this.lblValueId.Text = "NA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Id";
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(388, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete (F2)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkBoxConfirm
            // 
            this.chkBoxConfirm.AutoSize = true;
            this.chkBoxConfirm.Location = new System.Drawing.Point(7, 7);
            this.chkBoxConfirm.Name = "chkBoxConfirm";
            this.chkBoxConfirm.Size = new System.Drawing.Size(61, 17);
            this.chkBoxConfirm.TabIndex = 20;
            this.chkBoxConfirm.Text = "Confirm";
            this.chkBoxConfirm.UseVisualStyleBackColor = true;
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
            this.lblTitle.Size = new System.Drawing.Size(80, 21);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Delete User";
            // 
            // lblValueName
            // 
            this.lblValueName.AutoSize = true;
            this.lblValueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueName.Location = new System.Drawing.Point(89, 37);
            this.lblValueName.Margin = new System.Windows.Forms.Padding(3);
            this.lblValueName.Name = "lblValueName";
            this.lblValueName.Size = new System.Drawing.Size(24, 13);
            this.lblValueName.TabIndex = 29;
            this.lblValueName.Text = "NA";
            // 
            // lblValueEmail
            // 
            this.lblValueEmail.AutoSize = true;
            this.lblValueEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueEmail.Location = new System.Drawing.Point(89, 56);
            this.lblValueEmail.Margin = new System.Windows.Forms.Padding(3);
            this.lblValueEmail.Name = "lblValueEmail";
            this.lblValueEmail.Size = new System.Drawing.Size(24, 13);
            this.lblValueEmail.TabIndex = 30;
            this.lblValueEmail.Text = "NA";
            // 
            // lblValuePhone
            // 
            this.lblValuePhone.AutoSize = true;
            this.lblValuePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuePhone.Location = new System.Drawing.Point(89, 75);
            this.lblValuePhone.Margin = new System.Windows.Forms.Padding(3);
            this.lblValuePhone.Name = "lblValuePhone";
            this.lblValuePhone.Size = new System.Drawing.Size(24, 13);
            this.lblValuePhone.TabIndex = 31;
            this.lblValuePhone.Text = "NA";
            // 
            // lblValueAddress
            // 
            this.lblValueAddress.AutoSize = true;
            this.lblValueAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueAddress.Location = new System.Drawing.Point(89, 94);
            this.lblValueAddress.Margin = new System.Windows.Forms.Padding(3);
            this.lblValueAddress.Name = "lblValueAddress";
            this.lblValueAddress.Size = new System.Drawing.Size(24, 13);
            this.lblValueAddress.TabIndex = 32;
            this.lblValueAddress.Text = "NA";
            // 
            // lblValueRole
            // 
            this.lblValueRole.AutoSize = true;
            this.lblValueRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueRole.Location = new System.Drawing.Point(89, 113);
            this.lblValueRole.Margin = new System.Windows.Forms.Padding(3);
            this.lblValueRole.Name = "lblValueRole";
            this.lblValueRole.Size = new System.Drawing.Size(24, 13);
            this.lblValueRole.TabIndex = 33;
            this.lblValueRole.Text = "NA";
            // 
            // FrmDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 261);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDeleteUser";
            this.Text = "Delete User";
            this.Load += new System.EventHandler(this.FrmDeleteUser_Load);
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
        private System.Windows.Forms.Label lblValueRole;
        private System.Windows.Forms.Label lblValueId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValueAddress;
        private System.Windows.Forms.Label lblValuePhone;
        private System.Windows.Forms.Label lblValueEmail;
        private System.Windows.Forms.Label lblValueName;
        private System.Windows.Forms.Label lblValueUpdatedBy;
        private System.Windows.Forms.Label lblValueCreatedBy;
        private System.Windows.Forms.Label lblValueUpdatedAt;
        private System.Windows.Forms.Label lblValueCreatedAt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkBoxConfirm;
    }
}