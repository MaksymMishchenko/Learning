using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoviesTelegramBotApp.Database;
using MoviesTelegramBotApp.Models;

namespace MoviesTekegramBotApp
{
    internal class Program
    {
        public static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<ApplicationDbContext>(options => options.UseMySQL(GetConnectionString()))
                .BuildServiceProvider();

            using (var context = serviceProvider.GetRequiredService<ApplicationDbContext>())
            {
                DisplayMovies(context);
            }
        }

        private static string GetConnectionString()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration.GetConnectionString("DefaultConnection");
        }

        private static void DisplayMovies(ApplicationDbContext context)
        {
            List<Movie> movies = context.Movies.ToList();

            if (movies.Any())
            {
                foreach (var movie in movies)
                {
                    Console.WriteLine(movie.Name);
                    Console.WriteLine(movie.Category);
                    Console.WriteLine(movie.Country);
                    Console.WriteLine(movie.Budget);
                }
            }
        }
    }
}