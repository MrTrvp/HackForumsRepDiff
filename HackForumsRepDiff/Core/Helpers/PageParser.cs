using System.Collections.Generic;
using System.IO;
using AngleSharp.Dom;
using AngleSharp.Parser.Html;
using HackForumsRepDiff.Core.Models;

namespace HackForumsRepDiff.Core.Helpers
{
    public enum PageReadType { FromFile, Raw }

    public static class PageParser
    {
        public static Page Parse(string input, PageReadType pageReadType = PageReadType.Raw)
        {
            var source = string.Empty;
            var fileName = string.Empty;

            switch (pageReadType)
            {
                case PageReadType.FromFile:
                    source = File.ReadAllText(input);
                    fileName = input;
                    break;
                case PageReadType.Raw:
                    source = input;
                    break;
            }

            return new Page
            {
                Source = source,
                FileName = fileName,
                Reputations = ParseReputations(source),
                Type = ParseTransactionType(source)
            };
        }

        private static TransactionType ParseTransactionType(string source)
        {
            if (source.Contains("Total Given Reputations"))
                return TransactionType.Given;

            if (source.Contains("Total Reputation"))
                return TransactionType.Received;

            return TransactionType.Unknown;;
        }

        private static Reputation[] ParseReputations(string source)
        {    
            var parser = new HtmlParser();
            using (var document = parser.Parse(source))
            {
                var table = document.QuerySelector("#content > div:nth-child(3) > table");
                var preParsed = table.QuerySelectorAll("tbody > tr");

                var parsedReputations = new List<Reputation>();
                for (var i = 9; i < preParsed.Length - 1; i++)
                {
                    var repElement = preParsed[i];

                    var username = repElement.QuerySelector("td > ul > li > a > span").TextContent;
                    var number = ParseReputationNumber(repElement.QuerySelector("td > ul > li > span:nth-child(1)"));
                    var comment = repElement.QuerySelector("td > ul > li > span:nth-child(2)").TextContent;
                    var time = repElement.QuerySelector("td > ul > li:nth-child(3)").TextContent;

                    parsedReputations.Add(new Reputation(username, number, comment, time));
                }
                return parsedReputations.ToArray();
            }
        }

        private static int ParseReputationNumber(INode element)
        {
            var elementText = element.TextContent.
                Replace("Positive", string.Empty).
                Replace("Negative", string.Empty).
                Replace("(", string.Empty).
                Replace(")", string.Empty).
                Replace(":", string.Empty).
                Trim();

            int result;
            return int.TryParse(elementText, out result) ? result : 0;
        }
    }
}