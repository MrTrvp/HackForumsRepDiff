using System.Collections.Generic;
using System.Linq;
using HackForumsRepDiff.Core.Models;

namespace HackForumsRepDiff.Core.Helpers
{
    public static class TotalFormatter
    {
        private const string TotalFilesFormat = "Total Files: {0}";
        private const string TotalTransactionFormat = "Total {0} Count: {1} - Total {0}: {2}";

        public static string FormatTotalTransaction(IEnumerable<Reputation> reputations, TransactionType type)
        {
            if (reputations == null)
                return FormatTotalTransaction(type);

            var reputationArray = reputations.ToArray();

            var count = reputationArray.Count();
            var sum = reputationArray.Select(r => r.Number).Sum();

            return FormatTotalTransaction(type, count, sum);
        }

        public static string FormatTotalTransaction(TransactionType type, int count = 0, int sum = 0)
        {
            return string.Format(TotalTransactionFormat, type, count, sum);
        }

        public static string FormatTotalFiles(int count)
        {
            return string.Format(TotalFilesFormat, count);
        }
    }
}