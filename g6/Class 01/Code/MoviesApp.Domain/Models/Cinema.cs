//Make a class Cinema. Cinema must have: Name, Halls, ListOfMovies
//Cinema should have method MoviePlaying  that will have a parameter ‘movie’ and then print out in the console “Watching Movie.Title”
//We will provide 10 movies per cinema to put in the cinema movies list


namespace MoviesApp.Domain.Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; } //usually the name of the hall is an int //ex. Hall 1, Hall 2...

        public List<Movie> Movies { get; set; }


        public Cinema()
        {
            Halls = new List<int>();
            Movies = new List<Movie>(); 
        }

        public Cinema(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("You must provide a name for the cinema");

            }
            Name = name;
            Halls = new List<int>();
            Movies = new List<Movie>();

        }

        public void MoviePlaying(Movie movie)
        {
            //check if it is null
            if(movie == null)
            {
                throw new Exception("You entered a wrong movie!");
            }
            //check if this movie is playing in this cinema

            //check if all titles from the list of movies are different than the movie provided as param
            //if yes, throw an exception => this cinema does not have that movie
            if(Movies.All(m => m.Title.ToLower() != movie.Title.ToLower()))
            {
                throw new Exception($"The movie {movie.Title} is not playing in {Name}");
            }

            //Movie m = Movies.Where(x => x.Title.ToLower() == movie.Title).FirstOrDefault();
            //if(m == null)
            //{
            // throw new Exception($"The movie {movie.Title} is not playing in {Name}");
            //}


            Console.WriteLine($"You are now watching {movie.Title}");
        }

    }
}
