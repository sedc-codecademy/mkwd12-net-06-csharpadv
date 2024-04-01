namespace Models
{
    public class Loan : BaseClass
    {
        public Loan(User user, decimal amount, string createdBy) : base(createdBy)
        {
            Amount = amount;
            User = user;
        }

        public User User { get; set; }
        public decimal Amount { get; set; }

    }
}
