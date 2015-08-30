using HackForumsRepDiff.UI.Controls;

namespace HackForumsRepDiff.Core.Models
{
    public class Reputation
    {
        public string Username { get; set; }

        public int Number { get; set; }

        public string Comment { get; set; }

        public string Time { get; set; }

        public Reputation(string username, int number, string comment, string time)
        {
            Username = username;
            Number = number;
            Comment = comment;
            Time = time;
        }

        public ReputationViewItem ToReputationViewItem()
        {
            return new ReputationViewItem(this);
        }
    }
}