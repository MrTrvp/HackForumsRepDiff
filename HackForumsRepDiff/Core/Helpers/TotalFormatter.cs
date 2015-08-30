using System.Collections.Generic;
using System.Linq;
using HackForumsRepDiff.Core.Models;

namespace HackForumsRepDiff.Core.Helpers
{
    public static class TotalFormatter
    {
        private const string TotalFormat = "Total {0} Count: {1} - Total {0}: {2}";

        public static string FormatTotal(IEnumerable<Reputation> reputations, TransactionType type)
        {
            var reputationArray = reputations.ToArray();

            var count = reputationArray.Count();
            var sum = reputationArray.Select(r => r.Number).Sum();

            return FormatTotal(type, count, sum);
        }

        public static string FormatTotal(TransactionType type, int count = 0, int sum = 0)
        {
            return string.Format(TotalFormat, type, count, sum);
        }
    }
}