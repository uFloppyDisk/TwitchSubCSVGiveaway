namespace SubscriberGiveaway
{
    partial class settingsmenu
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
            this.btnBack_settingsmenu = new System.Windows.Forms.Button();
            this.lblTiers = new System.Windows.Forms.Label();
            this.combTiers = new System.Windows.Forms.ComboBox();
            this.grpTierSettings = new System.Windows.Forms.GroupBox();
            this.lblTicketPlan0 = new System.Windows.Forms.Label();
            this.lblTicketPlan1 = new System.Windows.Forms.Label();
            this.lblTicketPlan2 = new System.Windows.Forms.Label();
            this.lblTicketPlan3 = new System.Windows.Forms.Label();
            this.numbPlan0 = new System.Windows.Forms.NumericUpDown();
            this.numbPlan1 = new System.Windows.Forms.NumericUpDown();
            this.numbPlan2 = new System.Windows.Forms.NumericUpDown();
            this.numbPlan3 = new System.Windows.Forms.NumericUpDown();
            this.cboxDifferPrime = new System.Windows.Forms.CheckBox();
            this.grpTierSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbPlan0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbPlan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbPlan2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbPlan3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack_settingsmenu
            // 
            this.btnBack_settingsmenu.Location = new System.Drawing.Point(12, 185);
            this.btnBack_settingsmenu.Name = "btnBack_settingsmenu";
            this.btnBack_settingsmenu.Size = new System.Drawing.Size(76, 27);
            this.btnBack_settingsmenu.TabIndex = 0;
            this.btnBack_settingsmenu.Text = "Back";
            this.btnBack_settingsmenu.UseVisualStyleBackColor = true;
            this.btnBack_settingsmenu.Click += new System.EventHandler(this.btnBack_settingsmenu_Click);
            // 
            // lblTiers
            // 
            this.lblTiers.AutoSize = true;
            this.lblTiers.Location = new System.Drawing.Point(9, 11);
            this.lblTiers.Name = "lblTiers";
            this.lblTiers.Size = new System.Drawing.Size(33, 13);
            this.lblTiers.TabIndex = 1;
            this.lblTiers.Text = "Tiers:";
            // 
            // combTiers
            // 
            this.combTiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combTiers.FormattingEnabled = true;
            this.combTiers.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.combTiers.Location = new System.Drawing.Point(48, 8);
            this.combTiers.Name = "combTiers";
            this.combTiers.Size = new System.Drawing.Size(79, 21);
            this.combTiers.TabIndex = 2;
            this.combTiers.SelectedIndexChanged += new System.EventHandler(this.combTiers_SelectedIndexChanged);
            // 
            // grpTierSettings
            // 
            this.grpTierSettings.Controls.Add(this.lblTicketPlan0);
            this.grpTierSettings.Controls.Add(this.lblTicketPlan1);
            this.grpTierSettings.Controls.Add(this.lblTicketPlan2);
            this.grpTierSettings.Controls.Add(this.lblTicketPlan3);
            this.grpTierSettings.Controls.Add(this.numbPlan0);
            this.grpTierSettings.Controls.Add(this.numbPlan1);
            this.grpTierSettings.Controls.Add(this.numbPlan2);
            this.grpTierSettings.Controls.Add(this.numbPlan3);
            this.grpTierSettings.Controls.Add(this.cboxDifferPrime);
            this.grpTierSettings.Location = new System.Drawing.Point(12, 44);
            this.grpTierSettings.Name = "grpTierSettings";
            this.grpTierSettings.Size = new System.Drawing.Size(135, 137);
            this.grpTierSettings.TabIndex = 3;
            this.grpTierSettings.TabStop = false;
            this.grpTierSettings.Text = "Tier Settings";
            // 
            // lblTicketPlan0
            // 
            this.lblTicketPlan0.AutoSize = true;
            this.lblTicketPlan0.Location = new System.Drawing.Point(20, 105);
            this.lblTicketPlan0.Name = "lblTicketPlan0";
            this.lblTicketPlan0.Size = new System.Drawing.Size(36, 13);
            this.lblTicketPlan0.TabIndex = 8;
            this.lblTicketPlan0.Text = "Prime:";
            // 
            // lblTicketPlan1
            // 
            this.lblTicketPlan1.AutoSize = true;
            this.lblTicketPlan1.Location = new System.Drawing.Point(19, 79);
            this.lblTicketPlan1.Name = "lblTicketPlan1";
            this.lblTicketPlan1.Size = new System.Drawing.Size(37, 13);
            this.lblTicketPlan1.TabIndex = 7;
            this.lblTicketPlan1.Text = "$4.99:";
            // 
            // lblTicketPlan2
            // 
            this.lblTicketPlan2.AutoSize = true;
            this.lblTicketPlan2.Location = new System.Drawing.Point(19, 53);
            this.lblTicketPlan2.Name = "lblTicketPlan2";
            this.lblTicketPlan2.Size = new System.Drawing.Size(37, 13);
            this.lblTicketPlan2.TabIndex = 6;
            this.lblTicketPlan2.Text = "$9.99:";
            // 
            // lblTicketPlan3
            // 
            this.lblTicketPlan3.AutoSize = true;
            this.lblTicketPlan3.Location = new System.Drawing.Point(13, 27);
            this.lblTicketPlan3.Name = "lblTicketPlan3";
            this.lblTicketPlan3.Size = new System.Drawing.Size(43, 13);
            this.lblTicketPlan3.TabIndex = 5;
            this.lblTicketPlan3.Text = "$24.99:";
            // 
            // numbPlan0
            // 
            this.numbPlan0.Enabled = false;
            this.numbPlan0.Location = new System.Drawing.Point(62, 103);
            this.numbPlan0.Name = "numbPlan0";
            this.numbPlan0.Size = new System.Drawing.Size(42, 20);
            this.numbPlan0.TabIndex = 4;
            this.numbPlan0.ValueChanged += new System.EventHandler(this.numbTier_Any_ValueChanged);
            // 
            // numbPlan1
            // 
            this.numbPlan1.Location = new System.Drawing.Point(62, 77);
            this.numbPlan1.Name = "numbPlan1";
            this.numbPlan1.Size = new System.Drawing.Size(42, 20);
            this.numbPlan1.TabIndex = 3;
            this.numbPlan1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numbPlan1.ValueChanged += new System.EventHandler(this.numbTier_Any_ValueChanged);
            // 
            // numbPlan2
            // 
            this.numbPlan2.Location = new System.Drawing.Point(62, 51);
            this.numbPlan2.Name = "numbPlan2";
            this.numbPlan2.Size = new System.Drawing.Size(42, 20);
            this.numbPlan2.TabIndex = 2;
            this.numbPlan2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numbPlan2.ValueChanged += new System.EventHandler(this.numbTier_Any_ValueChanged);
            // 
            // numbPlan3
            // 
            this.numbPlan3.Location = new System.Drawing.Point(62, 25);
            this.numbPlan3.Name = "numbPlan3";
            this.numbPlan3.Size = new System.Drawing.Size(42, 20);
            this.numbPlan3.TabIndex = 1;
            this.numbPlan3.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numbPlan3.ValueChanged += new System.EventHandler(this.numbTier_Any_ValueChanged);
            // 
            // cboxDifferPrime
            // 
            this.cboxDifferPrime.AutoSize = true;
            this.cboxDifferPrime.Location = new System.Drawing.Point(110, 106);
            this.cboxDifferPrime.Name = "cboxDifferPrime";
            this.cboxDifferPrime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboxDifferPrime.Size = new System.Drawing.Size(15, 14);
            this.cboxDifferPrime.TabIndex = 0;
            this.cboxDifferPrime.UseVisualStyleBackColor = true;
            this.cboxDifferPrime.CheckedChanged += new System.EventHandler(this.cboxDifferPrime_CheckedChanged);
            // 
            // settingsmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 224);
            this.ControlBox = false;
            this.Controls.Add(this.grpTierSettings);
            this.Controls.Add(this.combTiers);
            this.Controls.Add(this.lblTiers);
            this.Controls.Add(this.btnBack_settingsmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "settingsmenu";
            this.Text = "Giveaway Settings";
            this.VisibleChanged += new System.EventHandler(this.settingsmenu_VisibleChanged);
            this.grpTierSettings.ResumeLayout(false);
            this.grpTierSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbPlan0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbPlan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbPlan2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbPlan3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack_settingsmenu;
        private System.Windows.Forms.Label lblTiers;
        private System.Windows.Forms.ComboBox combTiers;
        private System.Windows.Forms.GroupBox grpTierSettings;
        private System.Windows.Forms.CheckBox cboxDifferPrime;
        private System.Windows.Forms.NumericUpDown numbPlan0;
        private System.Windows.Forms.NumericUpDown numbPlan1;
        private System.Windows.Forms.NumericUpDown numbPlan2;
        private System.Windows.Forms.NumericUpDown numbPlan3;
        private System.Windows.Forms.Label lblTicketPlan0;
        private System.Windows.Forms.Label lblTicketPlan1;
        private System.Windows.Forms.Label lblTicketPlan2;
        private System.Windows.Forms.Label lblTicketPlan3;
    }
}