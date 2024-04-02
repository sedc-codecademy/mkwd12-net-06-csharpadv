using Static.Domain.Enums;
using Static.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Title {  get; set; }
        public string Description { get; set; }

        public OrderStatusEnum Status { get; set; }

        public Order()
        {
            Id = new Random().Next(1, 100000);
            Status = OrderStatusEnum.Created;
        }

        public Order(int id, string title, string description, OrderStatusEnum status)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = status;
        }

        public void PrintTitle()
        {
            Console.WriteLine(Title);
        }

        public static bool IsValid(Order order)
        {
            return order.Id > 0 && !string.IsNullOrEmpty(order.Title) && !string.IsNullOrEmpty(order.Description);
        }

        public void Print()
        {
            Console.WriteLine($"{TextHelper.ToCapitalFirstLetter(Title)} {Description} {Status.ToString()}");
        }
    }
}
