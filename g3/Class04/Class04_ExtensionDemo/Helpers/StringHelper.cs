using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Helpers
namespace System
{
    public static class StringHelper
    {
        public static string AddQuotes(this string s)
        {
            return "\"" + s + "\"";
        }

        public static string RemoveWordsFromBegining(this string text, int wordNumber)
        {
            if (string.IsNullOrEmpty(text))
                throw new Exception("Empty string");

            List<string> words = text.Split(" ").ToList();

            if (words.Count < wordNumber)
                throw new Exception($"Text has less than {wordNumber} words");

            List<string> restOfWords = words.Skip(wordNumber).Take(words.Count - wordNumber).ToList();

            return string.Join(" ", restOfWords);
        }
    }
}
