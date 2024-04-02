

namespace QinshiftAcademy.Class03.StaticClasses.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }

        public User()
        {
            Id = new Random().Next();
            Orders = new List<Order>();
        }

        public User(int id, string username, string address)
        {
            Id = id;
            Username = username;
            Address = address;
            Orders = new List<Order>();
        }

        public void PrintOrders()
        {
            Console.WriteLine($"{Username}'s orders:");
            foreach (Order o in Orders)
            {
                o.Print();
            }
        }
    }
}
