namespace SubscriberGiveaway
{
    partial class credits
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
            this.lblThanks = new System.Windows.Forms.Label();
            this.btnBack_Credits = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSkttie = new System.Windows.Forms.Label();
            this.lblBingoBangoBongoTV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Location = new System.Drawing.Point(62, 22);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(118, 13);
            this.lblThanks.TabIndex = 1;
            this.lblThanks.Text = "Thanks to all the peeps";
            this.lblThanks.Click += new System.EventHandler(this.lblThanks_Click);
            // 
            // btnBack_Credits
            // 
            this.btnBack_Credits.Location = new System.Drawing.Point(81, 109);
            this.btnBack_Credits.Name = "btnBack_Credits";
            this.btnBack_Credits.Size = new System.Drawing.Size(75, 23);
            this.btnBack_Credits.TabIndex = 2;
            this.btnBack_Credits.Text = "Back";
            this.btnBack_Credits.UseVisualStyleBackColor = true;
            this.btnBack_Credits.Click += new System.EventHandler(this.btnBack_Credits_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Copyright 2018 \"FloppyDisk Productions\"";
            // 
            // lblSkttie
            // 
            this.lblSkttie.AutoSize = true;
            this.lblSkttie.Location = new System.Drawing.Point(101, 46);
            this.lblSkttie.Name = "lblSkttie";
            this.lblSkttie.Size = new System.Drawing.Size(34, 13);
            this.lblSkttie.TabIndex = 4;
            this.lblSkttie.Text = "Skttie";
            // 
            // lblBingoBangoBongoTV
            // 
            this.lblBingoBangoBongoTV.AutoSize = true;
            this.lblBingoBangoBongoTV.Location = new System.Drawing.Point(66, 69);
            this.lblBingoBangoBongoTV.Name = "lblBingoBangoBongoTV";
            this.lblBingoBangoBongoTV.Size = new System.Drawing.Size(114, 13);
            this.lblBingoBangoBongoTV.TabIndex = 5;
            this.lblBingoBangoBongoTV.Text = "BingoBangoBonGOTV";
            // 
            // credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 157);
            this.ControlBox = false;
            this.Controls.Add(this.lblBingoBangoBongoTV);
            this.Controls.Add(this.lblSkttie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack_Credits);
            this.Controls.Add(this.lblThanks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "credits";
            this.ShowInTaskbar = false;
            this.Text = "Credits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Button btnBack_Credits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSkttie;
        private System.Windows.Forms.Label lblBingoBangoBongoTV;
    }
}