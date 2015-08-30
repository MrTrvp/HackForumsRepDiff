using System.Windows.Forms;
using HackForumsRepDiff.Core.Models;

namespace HackForumsRepDiff.UI.Controls
{
    public class ReputationViewItem : ListViewItem
    {
        public Reputation Reputation { get; set; }

        public ReputationViewItem(Reputation reputation)
        {
            Reputation = reputation;

            Text = reputation.Username;
            SubItems.AddRange(new[]
            {
                reputation.Number.ToString("+#;-#;0"),
                reputation.Comment,
                reputation.Time
            });
        }
    }
}