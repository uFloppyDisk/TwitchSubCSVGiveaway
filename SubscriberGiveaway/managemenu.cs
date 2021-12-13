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
    public partial class managemenu : Form
    {
        public managemenu()
        {
            InitializeComponent();
            lstEntrants.Sorted = true;
            lstEntrants.DataSource = UserManagement.Users.Keys.ToList();
        }

        private void managemenu_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.Owner.Enabled = false;
                performFilter();
            }
            else
            {
                this.Owner.Enabled = true;
            }
        }

        private void Update_ExRe_button()
        {
            btnExcludeRestoreAll_Toggle.Text = ExRe_action + ExRe_context;
        }

        private List<string> display_list = UserManagement.Users.Keys.ToList();
        private Boolean toggle_entered_to = false;

        private string filter_user_name;

        private string ExRe_action = "Exclude ";
        private string ExRe_context = "All";

        private void performFilter()
        {
            List<CheckBox> checkboxes = new List<CheckBox> { cboxPlan0, cboxPlan1, cboxPlan2, cboxPlan3};
            List<string> plan_filter = new List<string> { };
            List<string> status_filtered_users = new List<string> { };
            List<string> plan_filtered_users = new List<string> { };

            if (tboxFilterUser.Text.Length > 25)
            {
                MessageBox.Show("Usernames cannot be longer than 25 characters", "Out of Bounds");
                tboxFilterUser.Text = filter_user_name;
                return;
            }

            if (!radAll.Checked)
            {
                Boolean boolEntered = true;
                if (radNotEntered.Checked)
                {
                    boolEntered = false;
                }

                foreach (string user in UserManagement.Users.Keys)
                {
                    if (UserManagement.Users[user].entered == boolEntered)
                    {
                        status_filtered_users.Add(user);
                    }
                }
            }
            else
            {
                status_filtered_users = UserManagement.Users.Keys.ToList();
            }
          
            foreach (CheckBox checkbox in checkboxes)
            {
                if (checkbox.Checked)
                {
                    plan_filter.Add(checkbox.Text);
                }
            }

            foreach (string user in status_filtered_users)
            {
                if (plan_filter.Contains(UserManagement.Users[user].planname))
                {
                    plan_filtered_users.Add(user);
                }
            }

            if (tboxFilterUser.Text.Length >= 1)
            {
                filter_user_name = tboxFilterUser.Text;
                display_list = plan_filtered_users.FindAll(x => x.Contains(filter_user_name));
            }
            else
            {
                display_list = plan_filtered_users;
            }

            if (display_list.Count == 0)
            {
                btnExcludeRestore_Toggle.Enabled = false;
                btnExcludeRestoreAll_Toggle.Enabled = false;
            }
            else
            {
                btnExcludeRestore_Toggle.Enabled = true;
                btnExcludeRestoreAll_Toggle.Enabled = true;
            }

            if (radEntered.Checked)
            {
                ExRe_action = "Exclude ";
                toggle_entered_to = false;
            }
            else if (radNotEntered.Checked)
            {
                ExRe_action = "Restore ";
                toggle_entered_to = true;
            }

            if (radAll.Checked && plan_filter.Count == 4 && tboxFilterUser.Text.Length < 1)
            {
                ExRe_context = "All";
            }
            else
            {
                ExRe_context = "Visible";
            }

            lstEntrants.DataSource = display_list;
            Update_ExRe_button();
        }

        private void btnBack_managemenu_Click(object sender, EventArgs e)
        {
            UserManagement.Entrants.Clear();
            foreach (string user in UserManagement.Users.Keys.ToList())
            {
                if (UserManagement.Users[user].entered)
                {
                    UserManagement.Entrants.Add(user);
                }
            }

            Draw.createDrawList();

            this.Hide();
        }

        private void lstEntrants_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_user_name;
            UserManagement.User user;

            selected_user_name = lstEntrants.SelectedItem.ToString();
            user = UserManagement.Users[selected_user_name];

            lblUserName.Text = "Username: " + user.name;
            lblUserPlan.Text = "Plan: " + user.planname;
            lblUserDate.Text = "Subscribe Date: " + user.formatted_date.ToString();
            lblUserEntered.Text = "Entered: " + user.entered.ToString();

            if (radAll.Checked)
            {
                if (user.entered)
                {
                    btnExcludeRestore_Toggle.Text = "Exclude";
                }
                else
                {
                    btnExcludeRestore_Toggle.Text = "Restore";
                }
            }
        }

        private void tboxFilterUser_TextChanged(object sender, EventArgs e)
        {
            performFilter();
        }

        private void btnExcludeRestore_Toggle_Click(object sender, EventArgs e)
        {
            string selected_user_name;
            selected_user_name = lstEntrants.SelectedItem.ToString();

            UserManagement.Users[selected_user_name].toggle_entered();
            lblUserEntered.Text = "Entered: " + UserManagement.Users[selected_user_name].entered;
            if (radAll.Checked)
            {
                if (UserManagement.Users[selected_user_name].entered)
                {
                    btnExcludeRestore_Toggle.Text = "Exclude";
                }
                else
                {
                    btnExcludeRestore_Toggle.Text = "Restore";
                }
            }

            performFilter();
        }

        private void btnExcludeRestoreAll_Toggle_Click(object sender, EventArgs e)
        {

            foreach (string user in lstEntrants.Items)
            {
                UserManagement.Users[user].entered = toggle_entered_to;
            }
            lblUserEntered.Text = "Entered: " + toggle_entered_to;

            if (toggle_entered_to)
            {
                ExRe_action = "Exclude ";
                if (radAll.Checked)
                {
                    btnExcludeRestore_Toggle.Text = "Exclude";
                }
            }
            else
            {
                ExRe_action = "Restore ";
                if (radAll.Checked)
                {
                    btnExcludeRestore_Toggle.Text = "Restore";
                }
            }

            if (radAll.Checked)
            {
                toggle_entered_to = !toggle_entered_to;
            }

            performFilter();
            Update_ExRe_button();
        }

        private void cboxPlan_Any_CheckedChanged(object sender, EventArgs e)
        {
            performFilter();
        }

        private void rad_Any_CheckedChanged(object sender, EventArgs e)
        {
            if (!radAll.Checked)
            {
                if (radEntered.Checked)
                {
                    btnExcludeRestore_Toggle.Text = "Exclude";
                }
                else
                {
                    btnExcludeRestore_Toggle.Text = "Restore";
                }
            }
            performFilter();
        }

        private void btnFilterUserClear_Click(object sender, EventArgs e)
        {
            tboxFilterUser.Clear();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            radAll.Checked = true;
            radEntered.Checked = false;
            radNotEntered.Checked = false;

            cboxPlan0.Checked = true;
            cboxPlan1.Checked = true;
            cboxPlan2.Checked = true;
            cboxPlan3.Checked = true;

            tboxFilterUser.Clear();
        }
    }
}
