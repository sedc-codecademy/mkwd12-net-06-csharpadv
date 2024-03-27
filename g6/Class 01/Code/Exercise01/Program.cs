//The application should ask for names to be entered until the user enteres x
//After that the application should ask for a text
//When that is done the application should show how many times that name was included in the text ignoring upper/lower case

List<string> words = new List<string>();
while (true)
{
    Console.WriteLine("Enter a word:");
    string word = Console.ReadLine(); //Jana  //SEDC //Book //Nikola //G6 //Car
    words.Add(word); //we need to save each input from the user, so that we can use it and search it in the text 

    Console.WriteLine("Enter x if you don't want to continue. Press any other key to continue");
    string option = Console.ReadLine();
    if(option.ToLower() == "x")
    {
        break; //we need to end the infinite loop somehow
    }
}

Console.WriteLine("Enter text:");
string text = Console.ReadLine(); //Jana and Nikola are students at G6 at SEDC academy. Jana and Nikola chose .Net;

List<string> textWords = text.Split(" ").ToList();

foreach (string word in words)
{
    //we need to filter the textwords list and find the matchedWords
    //in this case x has the valiue of each of the elements of the textWords (strings ex. Jana, and, Nikola, are....)
    List<string> matchedWords = textWords.Where(x => x.ToLower()  == word.ToLower()).ToList();

    //we need to cound how many matchedWords were there
    int count = matchedWords.Count();
    //we need to print the result
    Console.WriteLine($"{word} : {count}");
}