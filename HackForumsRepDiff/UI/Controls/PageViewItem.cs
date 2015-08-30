using System.Windows.Forms;
using HackForumsRepDiff.Core.Models;

namespace HackForumsRepDiff.UI.Controls
{
    public class PageViewItem : ListViewItem
    {
        public Page Page { get; set; }

        public PageViewItem(Page page)
        {
            Page = page;

            Text = page.FileName;
            SubItems.Add(page.Type.ToString());
        }
    }
}