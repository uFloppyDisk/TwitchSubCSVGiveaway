namespace SubscriberGiveaway
{
    partial class formMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_New = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_Open_CSV = new System.Windows.Forms.ToolStripMenuItem();
            this.giveawayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_Credits = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstPreviousWinners = new System.Windows.Forms.ListBox();
            this.grpDraw = new System.Windows.Forms.GroupBox();
            this.btnResetDraw = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblPreviousWinners = new System.Windows.Forms.Label();
            this.linkWinner = new System.Windows.Forms.LinkLabel();
            this.menuMain.SuspendLayout();
            this.grpDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.giveawayToolStripMenuItem,
            this.menuMain_Credits,
            this.exitToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(495, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMain_New,
            this.menuMain_Open});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuMain_New
            // 
            this.menuMain_New.Name = "menuMain_New";
            this.menuMain_New.Size = new System.Drawing.Size(103, 22);
            this.menuMain_New.Text = "New";
            // 
            // menuMain_Open
            // 
            this.menuMain_Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMain_Open_CSV});
            this.menuMain_Open.Name = "menuMain_Open";
            this.menuMain_Open.Size = new System.Drawing.Size(103, 22);
            this.menuMain_Open.Text = "Open";
            // 
            // menuMain_Open_CSV
            // 
            this.menuMain_Open_CSV.Name = "menuMain_Open_CSV";
            this.menuMain_Open_CSV.Size = new System.Drawing.Size(95, 22);
            this.menuMain_Open_CSV.Text = "CSV";
            this.menuMain_Open_CSV.Click += new System.EventHandler(this.menuMain_Open_CSV_Click);
            // 
            // giveawayToolStripMenuItem
            // 
            this.giveawayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.giveawayToolStripMenuItem.Name = "giveawayToolStripMenuItem";
            this.giveawayToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.giveawayToolStripMenuItem.Text = "Giveaway";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // menuMain_Credits
            // 
            this.menuMain_Credits.Name = "menuMain_Credits";
            this.menuMain_Credits.Size = new System.Drawing.Size(56, 20);
            this.menuMain_Credits.Text = "Credits";
            this.menuMain_Credits.Click += new System.EventHandler(this.menuMain_Credits_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lstPreviousWinners
            // 
            this.lstPreviousWinners.FormattingEnabled = true;
            this.lstPreviousWinners.Location = new System.Drawing.Point(331, 53);
            this.lstPreviousWinners.Name = "lstPreviousWinners";
            this.lstPreviousWinners.Size = new System.Drawing.Size(152, 134);
            this.lstPreviousWinners.TabIndex = 1;
            // 
            // grpDraw
            // 
            this.grpDraw.Controls.Add(this.btnResetDraw);
            this.grpDraw.Location = new System.Drawing.Point(12, 194);
            this.grpDraw.Name = "grpDraw";
            this.grpDraw.Size = new System.Drawing.Size(313, 139);
            this.grpDraw.TabIndex = 2;
            this.grpDraw.TabStop = false;
            this.grpDraw.Text = "Draw";
            // 
            // btnResetDraw
            // 
            this.btnResetDraw.Location = new System.Drawing.Point(232, 19);
            this.btnResetDraw.Name = "btnResetDraw";
            this.btnResetDraw.Size = new System.Drawing.Size(75, 23);
            this.btnResetDraw.TabIndex = 0;
            this.btnResetDraw.Text = "Reset";
            this.btnResetDraw.UseVisualStyleBackColor = true;
            this.btnResetDraw.Click += new System.EventHandler(this.btnResetDraw_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(331, 275);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(152, 26);
            this.btnManage.TabIndex = 3;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Enabled = false;
            this.btnDraw.Location = new System.Drawing.Point(331, 194);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(152, 75);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(331, 307);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(152, 26);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblPreviousWinners
            // 
            this.lblPreviousWinners.AutoSize = true;
            this.lblPreviousWinners.Location = new System.Drawing.Point(328, 37);
            this.lblPreviousWinners.Name = "lblPreviousWinners";
            this.lblPreviousWinners.Size = new System.Drawing.Size(93, 13);
            this.lblPreviousWinners.TabIndex = 7;
            this.lblPreviousWinners.Text = "Previous Winners:";
            // 
            // linkWinner
            // 
            this.linkWinner.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkWinner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkWinner.AutoSize = true;
            this.linkWinner.BackColor = System.Drawing.Color.Transparent;
            this.linkWinner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkWinner.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkWinner.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkWinner.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkWinner.Location = new System.Drawing.Point(65, 37);
            this.linkWinner.MaximumSize = new System.Drawing.Size(200, 40);
            this.linkWinner.MinimumSize = new System.Drawing.Size(200, 40);
            this.linkWinner.Name = "linkWinner";
            this.linkWinner.Size = new System.Drawing.Size(200, 40);
            this.linkWinner.TabIndex = 8;
            this.linkWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkWinner.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWinner_LinkClicked);
            this.linkWinner.TextChanged += new System.EventHandler(this.linkWinner_TextChanged);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 347);
            this.Controls.Add(this.linkWinner);
            this.Controls.Add(this.lblPreviousWinners);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.grpDraw);
            this.Controls.Add(this.lstPreviousWinners);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "EZ Sub-Only Giveaway";
            this.EnabledChanged += new System.EventHandler(this.formMain_EnabledChanged);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.grpDraw.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox lstPreviousWinners;
        private System.Windows.Forms.GroupBox grpDraw;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ToolStripMenuItem menuMain_New;
        private System.Windows.Forms.ToolStripMenuItem menuMain_Open;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolStripMenuItem menuMain_Open_CSV;
        private System.Windows.Forms.ToolStripMenuItem menuMain_Credits;
        private System.Windows.Forms.ToolStripMenuItem giveawayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button btnResetDraw;
        private System.Windows.Forms.Label lblPreviousWinners;
        private System.Windows.Forms.LinkLabel linkWinner;
    }
}

