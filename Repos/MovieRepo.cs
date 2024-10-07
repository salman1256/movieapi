using WebAPIGitEx.Models;

namespace WebAPIGitEx.Repos
{
    public class MovieRepo : IMovieRepo
    {
        List<Movie> _movies = new List<Movie>()
        { 
        new Movie { Id=1,MName="The Dark Night",StarCast="Christane Bale ,Heath L",Director="Christopher Nolan"},
         new Movie { Id=1,MName="The GodFather",StarCast="Marlone Brando, Al Pacino ",Director="F.Ford Coppola"},
          new Movie { Id=1,MName="Terminator",StarCast="Arnold ",Director="James Cameron"},
           new Movie { Id=1,MName="Titanic",StarCast="Cate Winslet,Leonardo",Director="James Cameron"}
        };

        public IEnumerable<Movie> GetMovies()
        {
          return _movies;
        }

        public Movie GetMovieById(int id)
        {
            return _movies.SingleOrDefault(m => m.Id == id);
        }

        public void DeleteMovie(Movie movie)
        {
           _movies.Remove(movie);

        }

        public void UpdateMovie(Movie movie)
        {
           //

        }

        public void CreateMovie(Movie movie)
        {
            _movies.Add(movie);
        }

        
       
    }
}
