namespace SubscriberGiveaway
{
    partial class managemenu
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
            this.lstEntrants = new System.Windows.Forms.ListBox();
            this.btnBack_managemenu = new System.Windows.Forms.Button();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.lblUserEntered = new System.Windows.Forms.Label();
            this.lblUserDate = new System.Windows.Forms.Label();
            this.lblUserPlan = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnExcludeRestore_Toggle = new System.Windows.Forms.Button();
            this.tboxFilterUser = new System.Windows.Forms.TextBox();
            this.lblFilterUser = new System.Windows.Forms.Label();
            this.btnExcludeRestoreAll_Toggle = new System.Windows.Forms.Button();
            this.grpFilterPlan = new System.Windows.Forms.GroupBox();
            this.cboxPlan0 = new System.Windows.Forms.CheckBox();
            this.cboxPlan1 = new System.Windows.Forms.CheckBox();
            this.cboxPlan2 = new System.Windows.Forms.CheckBox();
            this.cboxPlan3 = new System.Windows.Forms.CheckBox();
            this.grpEntered = new System.Windows.Forms.GroupBox();
            this.radNotEntered = new System.Windows.Forms.RadioButton();
            this.radEntered = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.btnFilterUserClear = new System.Windows.Forms.Button();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.grpUserInfo.SuspendLayout();
            this.grpFilterPlan.SuspendLayout();
            this.grpEntered.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEntrants
            // 
            this.lstEntrants.FormattingEnabled = true;
            this.lstEntrants.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstEntrants.Location = new System.Drawing.Point(12, 12);
            this.lstEntrants.Name = "lstEntrants";
            this.lstEntrants.Size = new System.Drawing.Size(241, 290);
            this.lstEntrants.TabIndex = 0;
            this.lstEntrants.SelectedIndexChanged += new System.EventHandler(this.lstEntrants_SelectedIndexChanged);
            // 
            // btnBack_managemenu
            // 
            this.btnBack_managemenu.Location = new System.Drawing.Point(12, 308);
            this.btnBack_managemenu.Name = "btnBack_managemenu";
            this.btnBack_managemenu.Size = new System.Drawing.Size(76, 27);
            this.btnBack_managemenu.TabIndex = 1;
            this.btnBack_managemenu.Text = "Back";
            this.btnBack_managemenu.UseVisualStyleBackColor = true;
            this.btnBack_managemenu.Click += new System.EventHandler(this.btnBack_managemenu_Click);
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Controls.Add(this.lblUserEntered);
            this.grpUserInfo.Controls.Add(this.lblUserDate);
            this.grpUserInfo.Controls.Add(this.lblUserPlan);
            this.grpUserInfo.Controls.Add(this.lblUserName);
            this.grpUserInfo.Location = new System.Drawing.Point(259, 169);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Size = new System.Drawing.Size(224, 105);
            this.grpUserInfo.TabIndex = 2;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "User Details";
            // 
            // lblUserEntered
            // 
            this.lblUserEntered.AutoSize = true;
            this.lblUserEntered.Location = new System.Drawing.Point(6, 18);
            this.lblUserEntered.Name = "lblUserEntered";
            this.lblUserEntered.Size = new System.Drawing.Size(47, 13);
            this.lblUserEntered.TabIndex = 4;
            this.lblUserEntered.Text = "Entered:";
            // 
            // lblUserDate
            // 
            this.lblUserDate.AutoSize = true;
            this.lblUserDate.Location = new System.Drawing.Point(6, 84);
            this.lblUserDate.Name = "lblUserDate";
            this.lblUserDate.Size = new System.Drawing.Size(83, 13);
            this.lblUserDate.TabIndex = 3;
            this.lblUserDate.Text = "Subscribe Date:";
            // 
            // lblUserPlan
            // 
            this.lblUserPlan.AutoSize = true;
            this.lblUserPlan.Location = new System.Drawing.Point(6, 62);
            this.lblUserPlan.Name = "lblUserPlan";
            this.lblUserPlan.Size = new System.Drawing.Size(31, 13);
            this.lblUserPlan.TabIndex = 1;
            this.lblUserPlan.Text = "Plan:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 40);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username:";
            // 
            // btnExcludeRestore_Toggle
            // 
            this.btnExcludeRestore_Toggle.Location = new System.Drawing.Point(259, 280);
            this.btnExcludeRestore_Toggle.Name = "btnExcludeRestore_Toggle";
            this.btnExcludeRestore_Toggle.Size = new System.Drawing.Size(96, 23);
            this.btnExcludeRestore_Toggle.TabIndex = 3;
            this.btnExcludeRestore_Toggle.Text = "Exclude";
            this.btnExcludeRestore_Toggle.UseVisualStyleBackColor = true;
            this.btnExcludeRestore_Toggle.Click += new System.EventHandler(this.btnExcludeRestore_Toggle_Click);
            // 
            // tboxFilterUser
            // 
            this.tboxFilterUser.Location = new System.Drawing.Point(259, 28);
            this.tboxFilterUser.Name = "tboxFilterUser";
            this.tboxFilterUser.Size = new System.Drawing.Size(89, 20);
            this.tboxFilterUser.TabIndex = 5;
            this.tboxFilterUser.TextChanged += new System.EventHandler(this.tboxFilterUser_TextChanged);
            // 
            // lblFilterUser
            // 
            this.lblFilterUser.AutoSize = true;
            this.lblFilterUser.Location = new System.Drawing.Point(266, 12);
            this.lblFilterUser.Name = "lblFilterUser";
            this.lblFilterUser.Size = new System.Drawing.Size(57, 13);
            this.lblFilterUser.TabIndex = 6;
            this.lblFilterUser.Text = "Filter User:";
            // 
            // btnExcludeRestoreAll_Toggle
            // 
            this.btnExcludeRestoreAll_Toggle.Location = new System.Drawing.Point(361, 280);
            this.btnExcludeRestoreAll_Toggle.Name = "btnExcludeRestoreAll_Toggle";
            this.btnExcludeRestoreAll_Toggle.Size = new System.Drawing.Size(111, 23);
            this.btnExcludeRestoreAll_Toggle.TabIndex = 7;
            this.btnExcludeRestoreAll_Toggle.Text = "Exclude All";
            this.btnExcludeRestoreAll_Toggle.UseVisualStyleBackColor = true;
            this.btnExcludeRestoreAll_Toggle.Click += new System.EventHandler(this.btnExcludeRestoreAll_Toggle_Click);
            // 
            // grpFilterPlan
            // 
            this.grpFilterPlan.Controls.Add(this.cboxPlan0);
            this.grpFilterPlan.Controls.Add(this.cboxPlan1);
            this.grpFilterPlan.Controls.Add(this.cboxPlan2);
            this.grpFilterPlan.Controls.Add(this.cboxPlan3);
            this.grpFilterPlan.Location = new System.Drawing.Point(361, 55);
            this.grpFilterPlan.Name = "grpFilterPlan";
            this.grpFilterPlan.Size = new System.Drawing.Size(122, 108);
            this.grpFilterPlan.TabIndex = 8;
            this.grpFilterPlan.TabStop = false;
            this.grpFilterPlan.Text = "Filter by Plan";
            // 
            // cboxPlan0
            // 
            this.cboxPlan0.AutoSize = true;
            this.cboxPlan0.Checked = true;
            this.cboxPlan0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxPlan0.Location = new System.Drawing.Point(7, 77);
            this.cboxPlan0.Name = "cboxPlan0";
            this.cboxPlan0.Size = new System.Drawing.Size(52, 17);
            this.cboxPlan0.TabIndex = 3;
            this.cboxPlan0.Text = "Prime";
            this.cboxPlan0.UseVisualStyleBackColor = true;
            this.cboxPlan0.CheckedChanged += new System.EventHandler(this.cboxPlan_Any_CheckedChanged);
            // 
            // cboxPlan1
            // 
            this.cboxPlan1.AutoSize = true;
            this.cboxPlan1.Checked = true;
            this.cboxPlan1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxPlan1.Location = new System.Drawing.Point(7, 58);
            this.cboxPlan1.Name = "cboxPlan1";
            this.cboxPlan1.Size = new System.Drawing.Size(53, 17);
            this.cboxPlan1.TabIndex = 2;
            this.cboxPlan1.Text = "$4.99";
            this.cboxPlan1.UseVisualStyleBackColor = true;
            this.cboxPlan1.CheckedChanged += new System.EventHandler(this.cboxPlan_Any_CheckedChanged);
            // 
            // cboxPlan2
            // 
            this.cboxPlan2.AutoSize = true;
            this.cboxPlan2.Checked = true;
            this.cboxPlan2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxPlan2.Location = new System.Drawing.Point(7, 39);
            this.cboxPlan2.Name = "cboxPlan2";
            this.cboxPlan2.Size = new System.Drawing.Size(53, 17);
            this.cboxPlan2.TabIndex = 1;
            this.cboxPlan2.Text = "$9.99";
            this.cboxPlan2.UseVisualStyleBackColor = true;
            this.cboxPlan2.CheckedChanged += new System.EventHandler(this.cboxPlan_Any_CheckedChanged);
            // 
            // cboxPlan3
            // 
            this.cboxPlan3.AutoSize = true;
            this.cboxPlan3.Checked = true;
            this.cboxPlan3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxPlan3.Location = new System.Drawing.Point(7, 20);
            this.cboxPlan3.Name = "cboxPlan3";
            this.cboxPlan3.Size = new System.Drawing.Size(59, 17);
            this.cboxPlan3.TabIndex = 0;
            this.cboxPlan3.Text = "$24.99";
            this.cboxPlan3.UseVisualStyleBackColor = true;
            this.cboxPlan3.CheckedChanged += new System.EventHandler(this.cboxPlan_Any_CheckedChanged);
            // 
            // grpEntered
            // 
            this.grpEntered.Controls.Add(this.radNotEntered);
            this.grpEntered.Controls.Add(this.radEntered);
            this.grpEntered.Controls.Add(this.radAll);
            this.grpEntered.Location = new System.Drawing.Point(259, 55);
            this.grpEntered.Name = "grpEntered";
            this.grpEntered.Size = new System.Drawing.Size(89, 108);
            this.grpEntered.TabIndex = 9;
            this.grpEntered.TabStop = false;
            this.grpEntered.Text = "Filter Status";
            // 
            // radNotEntered
            // 
            this.radNotEntered.AutoSize = true;
            this.radNotEntered.Location = new System.Drawing.Point(6, 65);
            this.radNotEntered.Name = "radNotEntered";
            this.radNotEntered.Size = new System.Drawing.Size(82, 17);
            this.radNotEntered.TabIndex = 2;
            this.radNotEntered.TabStop = true;
            this.radNotEntered.Text = "Not Entered";
            this.radNotEntered.UseVisualStyleBackColor = true;
            this.radNotEntered.CheckedChanged += new System.EventHandler(this.rad_Any_CheckedChanged);
            // 
            // radEntered
            // 
            this.radEntered.AutoSize = true;
            this.radEntered.Location = new System.Drawing.Point(6, 42);
            this.radEntered.Name = "radEntered";
            this.radEntered.Size = new System.Drawing.Size(62, 17);
            this.radEntered.TabIndex = 1;
            this.radEntered.TabStop = true;
            this.radEntered.Text = "Entered";
            this.radEntered.UseVisualStyleBackColor = true;
            this.radEntered.CheckedChanged += new System.EventHandler(this.rad_Any_CheckedChanged);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Checked = true;
            this.radAll.Location = new System.Drawing.Point(6, 19);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(36, 17);
            this.radAll.TabIndex = 0;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.rad_Any_CheckedChanged);
            // 
            // btnFilterUserClear
            // 
            this.btnFilterUserClear.Location = new System.Drawing.Point(361, 26);
            this.btnFilterUserClear.Name = "btnFilterUserClear";
            this.btnFilterUserClear.Size = new System.Drawing.Size(42, 23);
            this.btnFilterUserClear.TabIndex = 10;
            this.btnFilterUserClear.Text = "Clear";
            this.btnFilterUserClear.UseVisualStyleBackColor = true;
            this.btnFilterUserClear.Click += new System.EventHandler(this.btnFilterUserClear_Click);
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Location = new System.Drawing.Point(409, 26);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(75, 23);
            this.btnResetFilters.TabIndex = 11;
            this.btnResetFilters.Text = "Reset Filters";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // managemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 347);
            this.ControlBox = false;
            this.Controls.Add(this.btnResetFilters);
            this.Controls.Add(this.btnFilterUserClear);
            this.Controls.Add(this.grpEntered);
            this.Controls.Add(this.grpFilterPlan);
            this.Controls.Add(this.btnExcludeRestoreAll_Toggle);
            this.Controls.Add(this.lblFilterUser);
            this.Controls.Add(this.tboxFilterUser);
            this.Controls.Add(this.btnExcludeRestore_Toggle);
            this.Controls.Add(this.grpUserInfo);
            this.Controls.Add(this.btnBack_managemenu);
            this.Controls.Add(this.lstEntrants);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "managemenu";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Giveaway";
            this.VisibleChanged += new System.EventHandler(this.managemenu_VisibleChanged);
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            this.grpFilterPlan.ResumeLayout(false);
            this.grpFilterPlan.PerformLayout();
            this.grpEntered.ResumeLayout(false);
            this.grpEntered.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEntrants;
        private System.Windows.Forms.Button btnBack_managemenu;
        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.Button btnExcludeRestore_Toggle;
        private System.Windows.Forms.Label lblUserPlan;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserDate;
        private System.Windows.Forms.TextBox tboxFilterUser;
        private System.Windows.Forms.Label lblFilterUser;
        private System.Windows.Forms.Button btnExcludeRestoreAll_Toggle;
        private System.Windows.Forms.Label lblUserEntered;
        private System.Windows.Forms.GroupBox grpFilterPlan;
        private System.Windows.Forms.CheckBox cboxPlan0;
        private System.Windows.Forms.CheckBox cboxPlan1;
        private System.Windows.Forms.CheckBox cboxPlan2;
        private System.Windows.Forms.CheckBox cboxPlan3;
        private System.Windows.Forms.GroupBox grpEntered;
        private System.Windows.Forms.RadioButton radNotEntered;
        private System.Windows.Forms.RadioButton radEntered;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.Button btnFilterUserClear;
        private System.Windows.Forms.Button btnResetFilters;
    }
}