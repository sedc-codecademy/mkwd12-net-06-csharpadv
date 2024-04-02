using Qinshift.Class03.Static.Domain;
using Qinshift.Class03.Static.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.Class03.StaticClass
{
    public static class OrdersDB
    {
        // This is an ID tracking property so that we generate the Id of orders automatically
        public static int orderId = 6;
        // These are the lists that will serve as tables in a database ( Store items in them )
        public static List<User> Users;
        public static List<Orders> Orders;
        // This is a static constructor
        // It will only execute once, the first time this class is instanciated, when the app is started
        // Static constructor does not have access modifier
        static OrdersDB()
        {
            Users = new List<User>()
            {
                new User(12, "bob123","Jane Sandanski 12"),
                new User(13, "smith","Jane Sandanski 13"),
                new User(14, "mile","Jane Sandanski 14"),
                new User(15, "userTest","Jane Sandanski 15"),
            };
            Orders = new List<Orders>()
            {
                new Orders(1, "book of books", "Best book", OrderStatus.Processing),
                new Orders(2, "keyboard", "Mechanical", OrderStatus.Delivered),
                new Orders(3, "shoes", "Nike", OrderStatus.CouldNotDeliver),
                new Orders(4, "pizza", "Best pizza", OrderStatus.Delivered),
                new Orders(5, "Laptop", "Asus", OrderStatus.Processing),
                new Orders(6, "Laptop", "Dell", OrderStatus.Delivered)
            };

            Users[0].Orders.Add(Orders[0]);
            Users[0].Orders.Add(Orders[1]);
            Users[1].Orders.Add(Orders[2]);
            Users[1].Orders.Add(Orders[3]);
            Users[2].Orders.Add(Orders[4]);
            Users[3].Orders.Add(Orders[5]);
        }

        public static void InsertOrder(int userId, Orders orders)
        {
            // When an order is added, we increment the ID and set it to the new order
            orders.Id = ++orderId;
            Orders.Add(orders);
            Users.FirstOrDefault(x => x.Id == userId).Orders.Add(orders);
            Console.WriteLine("Order successfully added in DB!!!!");
        }

        public static void ListUsers()
        {
            for (int i = 0; i < Users.Count; i++)
            {
                Console.WriteLine($"{i}) {Users[i].Username}");
            }
        }
    }
}
