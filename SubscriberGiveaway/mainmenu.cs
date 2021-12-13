using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubscriberGiveaway
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }
        
        private managemenu ManageMenu;
        private settingsmenu SettingsMenu = new settingsmenu { };
        private credits Credits = new credits { };

        private OpenFileDialog openCSVFileDialog()
        {
            OpenFileDialog openCSVDialog = new OpenFileDialog();
            openCSVDialog.Filter = "CSV Files|*.csv";
            openCSVDialog.Title = "Choose a CSV file";

            DialogResult result = openCSVDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return null;
            }

            return openCSVDialog;
        }

        private void formMain_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                if (UserManagement.Entrants.Count > 0)
                {
                    btnDraw.Enabled = true;
                }
                else
                {
                    btnDraw.Enabled = false;
                }
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            string winner = Draw.drawWinner();

            if (winner == "")
            {
                MessageBox.Show("List of users to pick is empty", "Ran out of users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (lstPreviousWinners.FindStringExact(winner) > -1)
                {
                    lstPreviousWinners.Items.Remove(winner);
                }
                lstPreviousWinners.Items.Insert(0, winner);
                linkWinner.Text = winner;
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            if (!UserManagement.Users.Any())
            {
                MessageBox.Show("You have not selected a CSV file", "No CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ManageMenu.Show();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsMenu.Owner = this;
            SettingsMenu.Show();
        }

        private void menuMain_Credits_Click(object sender, EventArgs e)
        {
            Credits.Show();
        }

        private void menuMain_Open_CSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog response;
            if (UserManagement.Users.Any())
            {
                DialogResult overwriteCSV = MessageBox.Show("A CSV file has already been opened. Do you want to overwrite?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (overwriteCSV != DialogResult.Yes)
                {
                    return;
                }
            }

            response = openCSVFileDialog();
            
            if (response == null)
            {
                return;
            }

            if (!response.FileName.EndsWith(".csv"))
            {
                MessageBox.Show("File chosen is not a Comma-Separated Values (CSV) file", "Invalid File Extension", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Boolean success = UserManagement.populateUsers(response);

            if (!success)
            {
                MessageBox.Show("CSV file didn't load correctly", "CSV File Import Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserManagement.Entrants = UserManagement.Users.Keys.ToList();
            Draw.createDrawList();
            lstPreviousWinners.Items.Clear();
            linkWinner.Text = "";

            ManageMenu = new managemenu { };
            ManageMenu.Owner = this;
            btnDraw.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManageMenu != null)
            {
                ManageMenu.Close();
            }
            SettingsMenu.Close();
            Credits.Close();
            this.Close();
        }

        private void btnResetDraw_Click(object sender, EventArgs e)
        {
            foreach (string user in lstPreviousWinners.Items)
            {
                Debug.WriteLine("Restoring user: " + user);
                UserManagement.Users[user].entered = true;
                if (!UserManagement.Entrants.Contains(user)){
                    UserManagement.Entrants.Add(user);
                }
            }

            Debug.WriteLine("-------------");

            Draw.createDrawList();
            lstPreviousWinners.Items.Clear();
            linkWinner.Text = "";
        }

        private void linkWinner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkWinner.Links[0].LinkData.ToString());
        }

        private void linkWinner_TextChanged(object sender, EventArgs e)
        {
            linkWinner.Links.Clear();
            if (linkWinner.Text != "")
            {
                //linkWinner.LinkArea = new LinkArea(0, linkWinner.Text.Length);
                linkWinner.Links.Add(0, linkWinner.Text.Length, "http://www.twitch.tv/" + linkWinner.Text);
            }
        }
    }
}
