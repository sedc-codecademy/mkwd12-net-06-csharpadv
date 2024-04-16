using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Events.Market;

namespace Events
{
    public class Mall
    {
        public string Name {  get; set; }

        public StoreEnum StoreOnSale { get; set; }  

        //1.we need a delegate
        public delegate string StoreSale(StoreEnum store);

        //2.we need an event
        public event StoreSale OnSale;

        //3. we need methods for subscribe/unsubscribe that accept methods according to the delegate
        public void SubscribeForSale(StoreSale subscriberMethod)
        {
            OnSale += subscriberMethod;
        }

        //we must have a method that will unsubscribe other methods to our event
        public void UnSubscribeForSale(StoreSale subscriberMethod)
        {
            OnSale -= subscriberMethod;
        }

        //4. we need a method that will trigger the event
        public void SendSaleNotification()
        {
            Console.WriteLine("=================================");
            OnSale(StoreOnSale);
        }

    }
}
