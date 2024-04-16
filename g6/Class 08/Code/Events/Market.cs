
namespace Events
{
    //publisher class
    //sends notifications about a promotion
    public class Market
    {
        //standard properties
        public string Name { get; set; }
        public string Address { get; set; }

        public ProductTypeEnum CurrentProductOnPromotion { get; set; }

        //in a publisher class we must have a delegate that defines the signature of the subs method that reacts on the event
        public delegate void PromotionSender(ProductTypeEnum productType);

        //this represents 
        //to this event. only methods that follow the signature of the PromotionSender delegate can subsrcibe
        //when this event happens, those methods will get executed
        public event PromotionSender Promotion;

        //we must have a method that will subscribe other methods to our event

        //we should look at the delegate here as a data type, if we have SayHello(string text) we always need to 
        //call SayHello with a string param - we cannot call it with an int
        //the same applies here - we need to have a method with that signature
        public void SubscribeForPromotion(PromotionSender subscriberMethod)
        {
            Promotion += subscriberMethod;
        }

        //we must have a method that will unsubscribe other methods to our event
        public void UnSubscribeForPromotion(PromotionSender subscriberMethod)
        {
            Promotion -= subscriberMethod;
        }

        public void SendPromotion()
        {
            Console.WriteLine("===========================");
            Console.WriteLine($"{Name} market is sending promotion info for {CurrentProductOnPromotion}");
            Promotion(CurrentProductOnPromotion); //this way we call the method from the subsrcibed users, through the delegate
        }
    }
}
