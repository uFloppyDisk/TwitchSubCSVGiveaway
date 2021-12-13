using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubscriberGiveaway
{
    class UserManagement
    {
        public static Dictionary<string, User> Users = new Dictionary<string, User> { };
        public static List<string> Entrants = new List<string> { };
        public static DateTime date_today = DateTime.Today;

        public static Boolean populateUsers(OpenFileDialog openCSVDialog)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(openCSVDialog.FileName);
            UserManagement.Users.Clear();

            string line;
            int i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                string[] columns;
                columns = line.Split(',');

                if (i > 2)
                {
                    UserManagement.User user = new UserManagement.User(columns[0], columns[3], columns[1], columns[2]);
                    if (UserManagement.Users.ContainsKey(columns[0]) == true)
                    {
                        UserManagement.Users[columns[0]] = user;
                    }
                    else
                    {
                        UserManagement.Users.Add(columns[0], user);
                    }
                }
                i++;
            }
            sr.Close();
            return true;
        }

        public class User
        {
            public string name;

            public string planname;
            public int plan;

            public string formatted_date;
            public DateTime date;
            public int resub_month;

            //public int weight = 1;

            public Boolean entered;

            public User(string name, string plan, string date, string paying)
            {
                string[] date_split = new string[] { };
                Boolean boolPaying = true;

                this.name = name;
                this.planname = plan;
                Boolean.TryParse(paying, out boolPaying);
                if (!boolPaying)
                {
                    this.planname = "Prime";
                }

                switch (this.planname)
                {
                    case "Prime":
                        this.plan = 0;
                        break;
                    case "$4.99":
                        this.plan = 1;
                        break;
                    case "$9.99":
                        this.plan = 2;
                        break;
                    case "$24.99":
                        this.plan = 3;
                        break;
                    default:
                        this.plan = 1;
                        break;
                }

                this.date = DateTime.Parse(date.Replace(" UTC", ""));
                this.resub_month = ((date_today.Year - this.date.Year) * 12) + date_today.Month - this.date.Month;
                this.formatted_date = string.Format("({0}) {1}", this.resub_month, this.date.ToShortDateString());


                Boolean.TryParse(paying, out boolPaying);
                if (!boolPaying)
                {
                    this.planname = "Prime";
                }

                this.entered = true;
            }

            public void toggle_entered()
            {
                this.entered = !this.entered;
            }

            public override string ToString()
            {
                return this.name;
            }
        }
    }
}
