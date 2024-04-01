namespace Models
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; } = new List<Dog>();

        public static void AddDog(Dog dog)
        {
            if(DogHelper.Validate(dog))
            {
                Dogs.Add(dog);
            } else
            {
                throw new Exception("Dog object is not valid");
            }
        }

        public static string GetAllDogs()
        {
            //string result = string.Empty;
            //string result = "";

            List<string> dogsBark = Dogs.Select(x => x.Bark()).ToList();
            return string.Join("\n", dogsBark);
        }
    }
}
