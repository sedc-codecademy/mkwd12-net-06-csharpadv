namespace Class14.Examples.Principles
{
    //bad example
    public interface ISuperMarket
    {
        void SellBeverages();
        void SellMeat();
        void SellVegetables();
        void SellFruits();
        void SellMisclenious();
        bool CheckStock(int itemId);
        int CheckMeatFridgeTemperature();
    }

    public class SuperMarket : ISuperMarket
    {
        public List<int> ItemIds { get; set; }

        public int CheckMeatFridgeTemperature()
        {
            return 10;
        }

        public bool CheckStock(int itemId)
        {
            return ItemIds.Exists(x => x== itemId);
        }

        public void SellBeverages()
        {
            Console.WriteLine("Beverage is sold!");
        }

        public void SellFruits()
        {
            Console.WriteLine("Fruit is sold!");
        }

        public void SellMeat()
        {
            Console.WriteLine("Meat is sold!");
        }

        public void SellMisclenious()
        {
            Console.WriteLine("Miscelenious is sold!");
        }

        public void SellVegetables()
        {
            Console.WriteLine("Vegetable is sold!");
        }
    }

    //the client now wants to open greenmarket and add it to the application
    //bad way
    public class GreenMarket : ISuperMarket
    {
        public int CheckMeatFridgeTemperature()
        {
            throw new NotImplementedException();
        }

        public bool CheckStock(int itemId)
        {
            throw new NotImplementedException();
        }

        public void SellBeverages()
        {
            throw new NotImplementedException();
        }

        public void SellFruits()
        {
            Console.WriteLine("Fruit is sold!");
        }

        public void SellMeat()
        {
            throw new NotImplementedException();
        }

        public void SellMisclenious()
        {
            throw new NotImplementedException();
        }

        public void SellVegetables()
        {
            Console.WriteLine("Vegetable is sold!");
        }
    }

    //good example
    public interface IBasicMarket
    {
        void SellBeverages();
        void SellMiscelenious();
        bool CheckStock(int itemId);
    }

    public interface IGreenMarket
    {
        void SellVegetables();
        void SellFruits();
    }

    public interface IButcherMarket
    {
        void SellMeat();
        int CheckMeatFridgeTemperature();
    }

    public class SuperMarketGood : IBasicMarket, IGreenMarket, IButcherMarket
    {
        public List<int> ItemIds { get; set; }

        public int CheckMeatFridgeTemperature()
        {
            //some code ...
            return 10;
        }

        public bool CheckStock(int itemId)
        {
            return ItemIds.Exists(x => x == itemId);
        }

        public void SellBeverages()
        {
            Console.WriteLine("Beverage is sold!");
        }

        public void SellFruits()
        {
            Console.WriteLine("Fruit is sold!");
        }

        public void SellMeat()
        {
            Console.WriteLine("Meat is sold!");
        }

        public void SellMiscelenious()
        {
            Console.WriteLine("Miscelenious is sold!");
        }

        public void SellVegetables()
        {
            Console.WriteLine("Vegetable is sold!");
        }
    }

    // the client opens a greenmarket and needs to add this to the app
    //good way
    public class GreenMarketGood : IGreenMarket
    {
        public void SellFruits()
        {
            Console.WriteLine("Fruit is sold!");
        }

        public void SellVegetables()
        {
            Console.WriteLine("Vegetable is sold!");
        }
    }

    public class ConvenientStore : IBasicMarket, IGreenMarket
    {
        public List<int> ItemIds { get; set; }

        public bool CheckStock(int itemId)
        {
            return ItemIds.Exists(x => x == itemId);
        }

        public void SellBeverages()
        {
            Console.WriteLine("Beverage is sold!");
        }

        public void SellFruits()
        {
            Console.WriteLine("Fruit is sold!");
        }

        public void SellMiscelenious()
        {
            Console.WriteLine("Miscelenious is sold!");
        }

        public void SellVegetables()
        {
            Console.WriteLine("Vegetable is sold!");
        }
    }
}
