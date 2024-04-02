

namespace QinshiftAcademy.Class03.StaticClasses.Domain.Helpers
{
    public static class TextHelper
    {
        public static string ToCapitalFirstLetter(string text) 
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty; //return ""
            }

            if(text.Length == 1)
            {
                return text.ToUpper(); //a -> A
            }
            else
            {
                //return char.ToUpper(text[0]) + text.Substring(1).ToLower();
                return text.Substring(0, 1).ToUpper() + text.Substring(1).ToLower();
            }
        }
    }
}
