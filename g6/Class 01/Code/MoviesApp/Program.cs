using MoviesApp.Domain;
using MoviesApp.Domain.Enums;
using MoviesApp.Domain.Models;

try
{
    Movie movie1 = new Movie("Scary Movie", GenreEnum.Comedy, 4);
    Movie movie2 = new Movie("American Pie", GenreEnum.Comedy, 4);
    Movie movie3 = new Movie("Saw", GenreEnum.Horror, 4);
    Movie movie4 = new Movie("The Shining", GenreEnum.Horror, 4);
    Movie movie5 = new Movie("Rambo", GenreEnum.Action, 4);
    Movie movie6 = new Movie("The Terminator", GenreEnum.Action, 4);
    Movie movie7 = new Movie("Forrest Gump", GenreEnum.Drama, 4);
    Movie movie8 = new Movie("12 Angru Men", GenreEnum.Drama, 4);
    Movie movie9 = new Movie("Passengers", GenreEnum.SciFi, 4);
    Movie movie10 = new Movie("Interstellar", GenreEnum.SciFi, 4);

    Movie movie11 = new Movie("Airplane", GenreEnum.Comedy, 4);
    Movie movie12 = new Movie("Johnny English", GenreEnum.Comedy, 4);
    Movie movie13 = new Movie("The Ring", GenreEnum.Horror, 4);
    Movie movie14 = new Movie("Sinister", GenreEnum.Horror, 4);
    Movie movie15 = new Movie("RoboCop", GenreEnum.Action, 4);
    Movie movie16 = new Movie("Judge Dredd", GenreEnum.Action, 4);
    Movie movie17 = new Movie("The Social Network", GenreEnum.Drama, 4);
    Movie movie18 = new Movie("The Shawshank Redemption", GenreEnum.Drama, 4);
    Movie movie19 = new Movie("Inception", GenreEnum.SciFi, 4);
    Movie movie20 = new Movie("Avatar", GenreEnum.SciFi, 4);

    Cinema cinema1 = new Cinema("Cineplex");
    cinema1.Halls = new List<int> { 1, 2, 3, 4, 5 };
    cinema1.Movies = new List<Movie> { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };

    Cinema cinema2 = new Cinema("Milenium");
    cinema2.Halls = new List<int> { 1, 2, 3 };
    cinema2.Movies = new List<Movie> { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };
   
    Console.WriteLine("Choose a cinema");
    Console.WriteLine($"1. {cinema1.Name}");
    Console.WriteLine($"2. {cinema2.Name}");

    string input = Console.ReadLine();
    int cinemaInput = int.Parse(input); //Potential FormatException

    //find the chosen cinema
    Cinema cinema; //we could also use a method to wrap all the remaining logic and call the method in the if-else with the chosen cinema
    if(cinemaInput == 1)
    {
        cinema = cinema1;
    }else if(cinemaInput == 2)
    {
        cinema = cinema2;
    }
    else
    {
        throw new Exception("Wrong input! You need to choose between option 1 and option 2");
    }

    //choose what to do 
    Console.WriteLine("What to you want to search for?");
    Console.WriteLine("1. All movies");
    Console.WriteLine("2. Movies by genre");

    int moviesInput = int.Parse(Console.ReadLine()); //Potential FormatException
    if(moviesInput == 1)
    {
        //the logic for AllMovies
        //show all movies 
        foreach(Movie movie in cinema.Movies)
        {
            Console.WriteLine(movie.Title);
        }

        //give option to choose a movie (the movie Playing method should be called)
        Console.WriteLine("Enter the title of the movie that you want to watch");
        string movieName = Console.ReadLine();
        Movie movieToWatch = cinema.Movies.FirstOrDefault(x => x.Title == movieName);

        cinema.MoviePlaying(movieToWatch);

    }
    else if(moviesInput == 2)
    {
        //logic for filtering by genre
        //By genre the user should input his favorite genre and a list of movies 
        //from that genre from the cinema should be displayed and give an option to choose one.
        Console.WriteLine("Enter genre");
        Console.WriteLine("1. Comedy");
        Console.WriteLine("2. Horror");
        Console.WriteLine("3. Action");
        Console.WriteLine("4. Drama");
        Console.WriteLine("5. SciFi");

        int genreInput = int.Parse(Console.ReadLine());//Potential FormatException

        if(genreInput < 1 || genreInput > 5)
        {
            throw new Exception("Wrong input. You need to choose from the given options from 1 to 5!");
        }
        //we cannot compare values from type GenreEnum with value from type int; we need to cast one of them
        //in order for them to be from the same type(we eiter cast the Genre to be int, or the input to become GenreEnum)
        List<Movie> filteredMovies = cinema.Movies.Where(x => (int)x.Genre == genreInput).ToList();

        List<Movie> filteredMoviesSecondWay = cinema.Movies.Where(x => x.Genre == (GenreEnum)genreInput).ToList();

        foreach(Movie movie in filteredMovies)
        {
            Console.WriteLine(movie.Title);
        }
        string movieName = Console.ReadLine();
        Movie movieToWatch = cinema.Movies.FirstOrDefault(x => x.Title == movieName && x.Genre == (GenreEnum)genreInput); //we can double check the genre here

        cinema.MoviePlaying(movieToWatch);

    }
    else
    {
        throw new Exception("Wrong input! Choose between 1 and 2!");
    }

}
catch (FormatException e)
{
    Console.WriteLine("The input was in wrong format");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}