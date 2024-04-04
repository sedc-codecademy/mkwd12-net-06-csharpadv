

namespace QinshiftAcademy.Class04.ExtensionMethods
{
    public static class StringHelper
    {
        //by using the this keyword, we make TakeFirstWords method to look like it is part of the definition for 
        //string type
        public static List<string> TakeFirstWords(this string input, int numOfWords)
        {
            if(numOfWords <= 0)
            {
                return null;
            }

            if (string.IsNullOrEmpty(input))
            {
                return new List<string>();
            }

            string[] words = input.Split(' ');

            //this method Take, takes numOfWords items ffrom words array
            List<string> result = words.Take(numOfWords).ToList();
            return result;
        }
    }
}
