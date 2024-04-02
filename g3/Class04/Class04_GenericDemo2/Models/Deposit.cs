namespace Models
{
    internal class Deposit : BaseClass
    {
        public Deposit(string createdBy, User user, decimal amount) : base(createdBy)
        {
            User = user;
            Amount = amount;
        }

        public User User { get; set; }
        public decimal Amount { get; set; }
    }
}
