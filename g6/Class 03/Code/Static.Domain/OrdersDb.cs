using Static.Domain.Enums;
using Static.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Domain
{
    //This static class simulates Database
    //It is alive during the lifecycle of the app 
    //can be accessed from anywhere
    public static class OrdersDb
    {
        //these lists simulate a real db
        //all members need to be static
        public static List<Order> Orders { get; set; }
        public static List<User> Users { get; set; }

        public static int lastOrderId = 5;

        static OrdersDb()
        {
            Orders = new List<Order>()
            {
                new Order(1, "book of books", "Best book ever", OrderStatusEnum.Delivered),
                new Order(2, "keyboard", "Mechanical", OrderStatusEnum.DeliveryInProcess),
                new Order(3, "Shoes", "Waterproof", OrderStatusEnum.DeliveryInProcess),
                new Order(4, "Set of Pens", "Ordinary pens", OrderStatusEnum.Processing),
                new Order(5, "sticky Notes", "Stickiest notes in the world", OrderStatusEnum.Problem)
            };
            Users = new List<User>()
            {
                new User(10, "PetkoP", "Address1"),
                new User(11, "StefanS", "Address2")
            };
            Users[0].Orders.Add(Orders[0]);
            Users[0].Orders.Add(Orders[1]);
            Users[0].Orders.Add(Orders[2]);
            Users[1].Orders.Add(Orders[3]);
            Users[1].Orders.Add(Orders[4]);
        }

        public static void PrintUsers()
        {
            int i = 1;
            foreach (User user in Users)
            {
                Console.WriteLine($"({i}) {user.Username}");
                i++;
            }
        }
                                       //11, order
        public static void InsertOrder(int userId, Order order)
        {
            //simualte that the db generates the id, it should be +1 from the last order
            lastOrderId++;
            order.Id = lastOrderId;

            //add the order to the list of orders (the table Order in our simulated db)
            Orders.Add(order);

            //add the order to the user
            User userFromDb = Users.FirstOrDefault(x => x.Id == userId);
            if(userFromDb != null)
            {
                userFromDb.Orders.Add(order);
            }
            else
            {
                Console.WriteLine("User not found!");
            }
        }
    }
}
