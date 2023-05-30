namespace DDPNB.Forms.Users
{
    partial class FrmPickUser
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tBoxSearch = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cmbBoxFindBy = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.panelbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(777, 440);
            this.panel1.TabIndex = 28;
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
            this.lblTitle.Location = new System.Drawing.Point(340, 4);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTitle.Size = new System.Drawing.Size(67, 23);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Pick User";
            // 
            // panelbody
            // 
            this.panelbody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelbody.Controls.Add(this.dgvUsers);
            this.panelbody.Controls.Add(this.tBoxSearch);
            this.panelbody.Controls.Add(this.lblPhone);
            this.panelbody.Controls.Add(this.cmbBoxFindBy);
            this.panelbody.Controls.Add(this.lblRole);
            this.panelbody.Location = new System.Drawing.Point(4, 47);
            this.panelbody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(767, 340);
            this.panelbody.TabIndex = 22;
            // 
            // dgvUsers
            // 
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(5, 52);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(755, 283);
            this.dgvUsers.TabIndex = 17;
            // 
            // tBoxSearch
            // 
            this.tBoxSearch.Location = new System.Drawing.Point(375, 15);
            this.tBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxSearch.Name = "tBoxSearch";
            this.tBoxSearch.Size = new System.Drawing.Size(384, 22);
            this.tBoxSearch.TabIndex = 8;
            this.tBoxSearch.TextChanged += new System.EventHandler(this.tBoxSearch_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(312, 18);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 16);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Search";
            // 
            // cmbBoxFindBy
            // 
            this.cmbBoxFindBy.FormattingEnabled = true;
            this.cmbBoxFindBy.Location = new System.Drawing.Point(83, 15);
            this.cmbBoxFindBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBoxFindBy.Name = "cmbBoxFindBy";
            this.cmbBoxFindBy.Size = new System.Drawing.Size(220, 24);
            this.cmbBoxFindBy.TabIndex = 16;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(4, 18);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(51, 16);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Find by";
            // 
            // panelFooter
            // 
            this.panelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFooter.Controls.Add(this.btnRefresh);
            this.panelFooter.Controls.Add(this.btnCancel);
            this.panelFooter.Controls.Add(this.btnSubmit);
            this.panelFooter.Location = new System.Drawing.Point(5, 395);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(765, 39);
            this.panelFooter.TabIndex = 23;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(4, 4);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 28);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh (F5)";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnSubmit.Text = "Pick (F2)";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmPickUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 470);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPickUser";
            this.Text = "Pick User";
            this.Load += new System.EventHandler(this.FrmPickUser_Load);
            this.panel1.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelbody.ResumeLayout(false);
            this.panelbody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelbody;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox tBoxSearch;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox cmbBoxFindBy;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRefresh;
    }
}