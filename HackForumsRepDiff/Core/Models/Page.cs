using System.Windows.Forms;
using HackForumsRepDiff.UI.Controls;

namespace HackForumsRepDiff.Core.Models
{
    public enum TransactionType { Given, Received, Unknown }

    public class Page
    {
        public string FileName { get; set; }  

        public string Source { get; set; }  
        
        public TransactionType Type { get; set; }  
        
        public Reputation[] Reputations { get; set; } 

        public Page() { }

        public Page(TransactionType transactionType, Reputation[] reputations)
        {
            Type = transactionType;
            Reputations = reputations;
        }

        public ListViewItem ToPageViewItem()
        {
            return new PageViewItem(this);
        }
    }
}