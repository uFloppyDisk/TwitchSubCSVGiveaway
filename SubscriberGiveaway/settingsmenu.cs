using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubscriberGiveaway
{
    public partial class settingsmenu : Form
    {
        public settingsmenu()
        {
            InitializeComponent();
            combTiers.SelectedIndex = 0;
        }
        
        private void numbTier_Any_ValueChanged(object sender, EventArgs e)
        {
            if (numbPlan3.Value < 1 && numbPlan2.Value < 1 && numbPlan1.Value < 1 && numbPlan0.Value < 1)
            {
                numbPlan3.Value = 5;
                numbPlan2.Value = 2;
                numbPlan1.Value = 1;
                numbPlan0.Value = 0;
                cboxDifferPrime.Checked = false;
                combTiers.SelectedIndex = 0;
            }
        }

        private void settingsmenu_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.Owner.Enabled = false;
            }
            else
            {
                this.Owner.Enabled = true;
            }
        }

        private void btnBack_settingsmenu_Click(object sender, EventArgs e)
        {
            if (combTiers.SelectedIndex == 1)
            {
                Draw.settings["Tiers_enabled"] = true;
                Draw.settings["$24.99"] = numbPlan3.Value;
                Draw.settings["$9.99"] = numbPlan2.Value;
                Draw.settings["$4.99"] = numbPlan1.Value;
                if (cboxDifferPrime.Checked)
                {
                    Draw.settings["DifferPrime"] = true;
                    Draw.settings["Prime"] = numbPlan0.Value;
                }
                else
                {
                    Draw.settings["DifferPrime"] = false;
                    Draw.settings["Prime"] = numbPlan1.Value;
                }
            }
            else
            {
                Draw.settings["Tiers_enabled"] = false;
                Draw.settings["$24.99"] = 0;
                Draw.settings["$9.99"] = 0;
                Draw.settings["$4.99"] = 0;
                Draw.settings["Prime"] = 0;
                Draw.settings["DifferPrime"] = false;
            }

            Draw.createDrawList();

            this.Hide();
        }

        private void combTiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combTiers.SelectedIndex == 0)
            {
                grpTierSettings.Enabled = false;
            }
            else
            {
                grpTierSettings.Enabled = true;
            }
        }

        private void cboxDifferPrime_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxDifferPrime.Checked == false)
            {
                numbPlan0.Enabled = false;
            }
            else
            {
                numbPlan0.Enabled = true;
            }
        }
    }
}
