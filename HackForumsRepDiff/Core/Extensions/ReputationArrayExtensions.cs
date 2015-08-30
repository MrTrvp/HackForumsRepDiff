using System.Collections.Generic;
using System.Linq;
using HackForumsRepDiff.Core.Models;
using HackForumsRepDiff.UI.Controls;

namespace HackForumsRepDiff.Core.Extensions
{
    public static class ReputationArrayExtensions
    {
        public static ReputationViewItem[] ToReputationViewItems(this IEnumerable<Reputation> reputations)
        {
            return reputations.Select(r => r.ToReputationViewItem()).ToArray();
        }
    }
}