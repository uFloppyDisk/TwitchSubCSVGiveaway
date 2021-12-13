using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriberGiveaway
{
    class Draw
    {
        public static Dictionary<string, dynamic> settings = new Dictionary<string, dynamic>
        {
            { "Tiers_enabled", false },
            { "$24.99", 0 },
            { "$9.99", 0 },
            { "$4.99", 0 },
            { "Prime", 0 },
            { "DifferPrime", false}

        };

        public static Dictionary<string, int> Tickets = new Dictionary<string, int> { };

        private static Random rand = new Random { };

        public static void createDrawList()
        {
            Tickets.Clear();
            if (settings["Tiers_enabled"])
            {
                if (!settings["DifferPrime"])
                {
                    settings["Prime"] = settings["$4.99"];
                }

                foreach (string user in UserManagement.Entrants)
                {
                    if ((int) settings[UserManagement.Users[user].planname] > 0)
                    {
                        Tickets[user] = (int) settings[UserManagement.Users[user].planname];
                    }
                }
            } else
            {
                foreach (string user in UserManagement.Entrants)
                {
                    Tickets[user] = 1;
                }
            }

            return;
        }

        public static string drawWinner()
        {
            double randconst = rand.NextDouble() * Tickets.Sum(a => a.Value);
            double min = 0;
            double max = 0;

            string winner = "";

            foreach (KeyValuePair<string, int> ticket in Tickets)
            {
                max += ticket.Value;
                if (min <= randconst && randconst < max)
                {
                    winner = ticket.Key;
                    break;
                }
                min = max;
            }

            if (winner != "")
            {
                UserManagement.Users[winner].entered = false;
                Tickets.Remove(winner);
            }
            return winner;
        }

    }
}
