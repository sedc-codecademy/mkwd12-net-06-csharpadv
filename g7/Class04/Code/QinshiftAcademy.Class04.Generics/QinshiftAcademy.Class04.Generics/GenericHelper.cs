

namespace QinshiftAcademy.Class04.Generics
{
    //anywhere in the class, when we meet the letter T, it can be replaced with any data type
    public class GenericHelper<T>
    {
        //as param of PrintValue we can pass any data type
        public void PrintValue(T i)
        {
            Console.WriteLine($"The value is {i}");
        }

        public void PrintList(List<T> list)
        {
            foreach (T s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
