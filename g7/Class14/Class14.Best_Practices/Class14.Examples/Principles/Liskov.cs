namespace Class14.Examples.Principles
{
    //bad way
    public class StringComparing 
    {
        protected string _firstString;
        protected string _secondString;

        public StringComparing(string str1, string str2)
        {
            _firstString = str1;
            _secondString = str2;
        }

        public void Compare()
        {
            if(_firstString.Length > _secondString.Length)
            {
                Console.WriteLine("The first string is larger");
            }
            else if (_firstString.Length < _secondString.Length)
            {
                Console.WriteLine("The second string is larger");
            }
            else
            {
                Console.WriteLine("They are the same");
            }
        }
    }

    public class LettersStringComparing : StringComparing
    {
        public LettersStringComparing(string str1 , string str2) : base(str1, str2) { }

        public void Compare()
        {
            if (_firstString.First() == _secondString.First())
            {
                Console.WriteLine("They start with the same letter!");
            }
            else
            {
                Console.WriteLine("The don't start with the same letter");
            }
        }
    }

    public class App
    {
        public void Run()
        {
            //work
            Console.WriteLine("Example 1:");
            StringComparing strComp1 = new StringComparing("bob", "Jill");
            strComp1.Compare();
            LettersStringComparing letterStrComp1 = new LettersStringComparing("bob", "Jill");
            letterStrComp1.Compare();
            // problem
            StringComparing strCompPolymorph1 = new LettersStringComparing("bob", "Jill");
            strCompPolymorph1.Compare();
        }
    }

    //good way
    public abstract class StringComparingGood
    {
        protected string _firstString;
        protected string _secondString;

        public StringComparingGood(string str1, string str2)
        {
            _firstString = str1;
            _secondString = str2;
        }
        public abstract void Compare();
    }

    public class LengthStringComparingGood : StringComparingGood
    {
        public LengthStringComparingGood(string str1, string str2) : base(str1, str2) { }

        public override void Compare()
        {
            if (_firstString.Length > _secondString.Length)
            {
                Console.WriteLine("The first string is larger");
            }
            else if (_firstString.Length < _secondString.Length)
            {
                Console.WriteLine("The second string is larger");
            }
            else
            {
                Console.WriteLine("They are the same");
            }
        }
    } 

    public class LettersStringComparingGood : StringComparingGood
    {
        public LettersStringComparingGood(string str1, string str2) : base (str1, str2) { }

        public override void Compare()
        {
            if (_firstString.First() == _secondString.First())
            {
                Console.WriteLine("They start with the same letter!");
            }
            else
            {
                Console.WriteLine("The don't start with the same letter");
            }
        }
    }

    public class AppGood
    {
        public void Run()
        {
            //Works
            Console.WriteLine("Example 2:");
            LengthStringComparingGood strComp2 = new LengthStringComparingGood("Bob", "Jill");
            strComp2.Compare();
            LettersStringComparingGood lettersStrComp2 = new LettersStringComparingGood("Bob", "Jill");
            lettersStrComp2.Compare();
            //wont be a problem anymore, like in the previous example
            StringComparingGood strCompPolymorph2 = new LettersStringComparingGood("Bob", "Jill");
            StringComparingGood strCompPolymorph3 = new LengthStringComparingGood("Bob", "Jill");
            strCompPolymorph2.Compare();
            strCompPolymorph3.Compare();
        }
    }
}
