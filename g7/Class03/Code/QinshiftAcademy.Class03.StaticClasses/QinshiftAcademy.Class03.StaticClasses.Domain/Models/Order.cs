

using QinshiftAcademy.Class03.StaticClasses.Domain.Enums;
using QinshiftAcademy.Class03.StaticClasses.Domain.Helpers;

namespace QinshiftAcademy.Class03.StaticClasses.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public OrderStatus Status { get; set; }

        public Order()
        {
            Id = new Random().Next(1, 1000000);
            Status = OrderStatus.Created;
        }

        public Order(int id, string title, string description, OrderStatus orderStatus)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = orderStatus;
        }

        public void Print()
        {
            Console.WriteLine($"{TextHelper.ToCapitalFirstLetter(Title)} {Description} {Status.ToString()}");
        }
    }
}
