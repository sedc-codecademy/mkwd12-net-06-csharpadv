

using QinshiftAcademy.Class03.StaticClasses.Domain.Enums;
using QinshiftAcademy.Class03.StaticClasses.Domain.Models;

namespace QinshiftAcademy.Class03.StaticClasses.Domain.Database
{
    //this class will simulate the database
    //it will have properties, where each one of them that is a collection
    //will simulate a table, space from the storage for specific entity records
    //this class has only one instance which is alive as long as the application is alive
    //that means that the data in the properties can be accessed and modified through out the whole app lifetime
    public static class OrdersDb
    {
        public static List<Order> Orders { get; set; }

        public static int LastOrderId { get; set; }
        public static List<User> Users { get; set; }

        //the constructor is marked as static because it is called only once, at the beginning of the app lifetime
        static OrdersDb()
        {
            Orders = new List<Order>()
            {
                new Order(1, "book of books", "Best book ever", OrderStatus.Delivered),
                new Order(2, "keyboard", "Mechanical", OrderStatus.DeliveryInProcess),
                new Order(3, "Shoes", "Waterproof", OrderStatus.DeliveryInProcess),
                new Order(4, "Set of Pens", "Ordinary pens", OrderStatus.Processing),
                new Order(5, "sticky Notes", "Stickiest notes in the world", OrderStatus.Problem)
            };
            LastOrderId = 5;

            Users = new List<User>()
            {
                new User(12, "Bob22", "Bob St. 44"),
                new User(13, "JillCoolCat", "Wayne St. 109a")
            };

            //creating relations between User and Order class by adding order objects in each user's list of orders
            Users[0].Orders.Add(Orders[0]);
            Users[0].Orders.Add(Orders[1]);
            Users[0].Orders.Add(Orders[2]);
            Users[1].Orders.Add(Orders[3]);
            Users[1].Orders.Add(Orders[4]);
        }


        public static void AddOrder(Order order, int userId)
        {
            //simulating that the database is generating the ids
            //we are also making sure that we don't have duplicate ids in our db
            order.Id = LastOrderId + 1;
            LastOrderId++;

            //adding the order to our db
            Orders.Add(order);

            //we want to create a relation between the order and the user with id userId

            //we need to search for the user by id
            User userDb = Users.First(u => u.Id == userId);
            //add the new order to the user
            userDb.Orders.Add(order);
        }
    }
}
