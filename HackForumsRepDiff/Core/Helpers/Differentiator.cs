using System.Collections.Generic;
using System.Linq;
using HackForumsRepDiff.Core.Models;

namespace HackForumsRepDiff.Core.Helpers
{
    public static class Differentiator
    {
        public static IEnumerable<Reputation> Differenciate(IEnumerable<Reputation> given, IEnumerable<Reputation> received)
        {
            return given.Where(rep1 => received.All(rep2 => rep2.Username != rep1.Username));
        }
    }
}