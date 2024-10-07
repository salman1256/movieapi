using WebAPIGitEx.Models;

namespace WebAPIGitEx.Repos
{
    public interface IMovieRepo
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovieById(int id);
        void DeleteMovie(Movie movie);
        void UpdateMovie(Movie movie);
        void CreateMovie(Movie movie);  
    }
}
