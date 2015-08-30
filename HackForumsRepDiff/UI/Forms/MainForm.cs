using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using HackForumsRepDiff.Core.Extensions;
using HackForumsRepDiff.Core.Helpers;
using HackForumsRepDiff.Core.Models;
using HackForumsRepDiff.UI.Controls;

namespace HackForumsRepDiff.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.Desktop
            })
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                var files = Directory.GetFiles(dialog.SelectedPath, "*", SearchOption.AllDirectories).
                    Where(f => Config.AllowedFileTypes.Any(f.EndsWith)).ToList();

                files.Sort(new NumericComparer());
                InvalidateReputationsFromFiles(files);
            }
        }

        private void tsmiRemove_Click(object sender, EventArgs e)
        {
            foreach (PageViewItem item in lvLoadedDocuments.SelectedItems)
                lvLoadedDocuments.Items.Remove(item);

            var files = lvLoadedDocuments.Items.Cast<PageViewItem>().Select(p => p.Text);
            InvalidateReputationsFromFiles(files.ToArray());
        }

        public void InvalidateReputationsFromFiles(IEnumerable<string> files)
        {
            lvLoadedDocuments.Items.Clear();
            lvGiven.Items.Clear();
            lvReceived.Items.Clear();
            lvDifference.Items.Clear();

            lbTotalGiven.Text = TotalFormatter.FormatTotal(TransactionType.Given);
            lbTotalReceived.Text = TotalFormatter.FormatTotal(TransactionType.Received);
            lbTotalDifference.Text = TotalFormatter.FormatTotal(TransactionType.Difference);

            var parsed = files.
                Select(f => PageParser.Parse(f, PageReadType.FromFile));

            var given = new List<Reputation>();
            var received = new List<Reputation>();

            foreach (var page in parsed)
            {
                if (page.Type == TransactionType.Unknown)
                    continue;

                lvLoadedDocuments.Items.Add(page.ToPageViewItem());

                var reputations = page.Reputations.ToReputationViewItems();
                switch (page.Type)
                {
                    case TransactionType.Given:
                        given.AddRange(page.Reputations);
                        lvGiven.Items.AddRange(reputations);
                        break;
                    case TransactionType.Received:
                        received.AddRange(page.Reputations);
                        lvReceived.Items.AddRange(reputations);
                        break;
                }
            }

            var difference = Differentiator.Differenciate(given, received).ToArray();
            lvDifference.Items.AddRange(difference.ToReputationViewItems());

            lbTotalFiles.Text = string.Concat(@"Total Files: ", lvLoadedDocuments.Items.Count);
            lbTotalGiven.Text = TotalFormatter.FormatTotal(given, TransactionType.Given);
            lbTotalReceived.Text = TotalFormatter.FormatTotal(received, TransactionType.Received);
            lbTotalDifference.Text = TotalFormatter.FormatTotal(difference, TransactionType.Difference);
        }
    }
}