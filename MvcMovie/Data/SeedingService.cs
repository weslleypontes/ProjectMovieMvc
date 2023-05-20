using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Models;
namespace MvcMovie.Data
{
    public class SeedingService
    {
        public static void SeedAsync(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return; // DB has been seeded
                }

                Movie d1 = new Movie(new int(), "When Harry Met Sally", DateTime.Parse("1989-2-12"), "Romantic Comedy", 7.99M);
                Movie d2 = new Movie(new int(), "Ghostbusters ", DateTime.Parse("1984-3-13"), "Comedy", 8.99M);
                Movie d3 = new Movie(new int(), "Ghostbusters 2", DateTime.Parse("1986-2-23"), "Comedy", 9.99M);
                Movie d4 = new Movie(new int(), "Rio Bravo", DateTime.Parse("1959-4-15"), "Western", 3.99M);


                context.Movie.AddRange(d1, d2, d3, d4);

                context.SaveChanges();
            }

        }
    }
}
