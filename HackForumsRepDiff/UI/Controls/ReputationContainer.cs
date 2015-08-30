using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HackForumsRepDiff.Core.Extensions;
using HackForumsRepDiff.Core.Helpers;
using HackForumsRepDiff.Core.Models;

namespace HackForumsRepDiff.UI.Controls
{
    public partial class ReputationContainer : UserControl
    {
        private TransactionType _type;
        public TransactionType Type
        {
            get { return _type; }
            set
            {
                _type = value;
                InvalidateLabel();
            }
        }

        private List<Reputation> _reputations;
        public Reputation[] Reputations
        {
            get { return _reputations.ToArray(); }
            set
            {
                _reputations = value == null
                    ? new List<Reputation>()
                    : new List<Reputation>(value);

                InvalidateLabel();
            }
        }

        public ReputationContainer()
        {
            InitializeComponent();

            Type = TransactionType.Unknown;
            Reputations = new Reputation[0];
        }

        public void AddRange(IEnumerable<Reputation> reputations)
        {
            var reputationArray = reputations.ToArray();

            _reputations.AddRange(reputationArray);
            lvReputations.Items.AddRange(reputationArray.ToReputationViewItems());

            InvalidateLabel();
        }

        private void InvalidateLabel()
        {
            lbTotal.Text = TotalFormatter.FormatTotalTransaction(_reputations, _type);
        }

        public void Clear()
        {
            Reputations = null;
            lvReputations.Items.Clear();

            InvalidateLabel();
        }

        private void tsmiCopy_Click(object sender, System.EventArgs e)
        {
            var clipboardBuilder = new StringBuilder();
            foreach (ListViewItem item in lvReputations.SelectedItems)
            {
                for (var i = 0; i < lvReputations.Columns.Count; i++)
                {
                    clipboardBuilder.Append(lvReputations.Columns[i].Text);
                    clipboardBuilder.Append(": ");

                    clipboardBuilder.AppendLine(item.SubItems[i].Text);
                }

                clipboardBuilder.AppendLine();
            }
            clipboardBuilder.Length -= 4;

            Clipboard.SetText(clipboardBuilder.ToString());
        }
    }
}