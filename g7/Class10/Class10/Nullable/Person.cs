namespace Nullable
{
    public class Person
    {
        public int id {  get; set; }
        public int? Score { get; set; } // nullable
        public bool IsEmployed { get; set; }
        public bool? HasPet { get; set; } // nullable
        public string Name { get; set; }
    }
}
