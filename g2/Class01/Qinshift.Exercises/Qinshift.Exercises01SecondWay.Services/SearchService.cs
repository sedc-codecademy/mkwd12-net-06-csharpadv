using Qinshift.Exercises01SecondWay.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.Exercises01SecondWay.Services
{
    public class SearchService
    {
        public List<SearchResult> CountAppearancesInText2(string text, List<string> searchStrings)
        {
            var searchText = text
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return searchStrings
                .Select(_str => new SearchResult()
                {
                    Name = _str,
                    Appearance = searchText.Count(_word => _word.Equals(_str, StringComparison.OrdinalIgnoreCase))
                })
                .ToList();
        }

        public List<string> GetInputNames()
        {
            List<string> names = new List<string>();
            while (true)
            {
                string name = Console.ReadLine().Trim();
                if (name.ToLower() == "x") break;
                names.Add(name);
            }
            return names;
        }
    }
}
