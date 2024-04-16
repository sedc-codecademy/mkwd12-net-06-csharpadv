namespace TaxiManager9000.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidateStringInput(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        public static int ValidateNumberInput(string number, int range)
        {
            bool isNumber = int.TryParse(number, out int parsedNumber);
            if (!isNumber || parsedNumber > range || parsedNumber <= 0)
            {
                return -1;
            }
            return parsedNumber;
        }
    }
}
