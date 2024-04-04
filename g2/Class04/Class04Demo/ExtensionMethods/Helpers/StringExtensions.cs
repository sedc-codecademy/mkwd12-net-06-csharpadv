namespace ExtensionMethods.Helpers
{
    public static class StringExtensions
    {
        public static string Shorten(this string text, int numberOfWords)
        {
            string[] words = text.Split(' ');
            List<string> wordsResult = words.Take(numberOfWords).ToList();
            string resultString = string.Join(" ", wordsResult);
            return resultString + "...";
        }

        public static string QuoteString(this string text)
        {
            return '"' + text + '"';
        }
    }
}
