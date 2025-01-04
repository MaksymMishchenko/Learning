using MoviesTelegramBotApp.Database;
using MoviesTelegramBotApp.Interfaces;
using MoviesTelegramBotApp.Models;
using System.Text;

namespace MoviesTelegramBotApp.Services
{
    internal class MovieService : IMovieService
    {
        private ApplicationDbContext _dbContext;
        public MovieService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public string BuildMoviesResponse(List<Movie> movies)
        {
            var response = new StringBuilder();

            if (!movies.Any())
            {
                return "No movies found!";
            }

            foreach (var movie in movies)
            {
                response.AppendLine($"Name: {movie.Name}");
                response.AppendLine($"Genre: {movie.Category}");
                response.AppendLine($"Description: {movie.Description}");
                response.AppendLine($"Country: {movie.Country}");
                response.AppendLine($"Budget: {movie.Budget}");
                response.AppendLine($"Trailer: {movie.MovieUrl}");
                response.AppendLine();
            }

            return response.ToString();
        }

        public List<Movie> GetMovies()
        {
            return _dbContext.Movies.ToList();
        }
    }
}
