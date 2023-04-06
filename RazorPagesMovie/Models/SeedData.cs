using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesMovieContext>>()))
        {
            if (context == null || context.Movie == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    WatchedDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    TimeStamp = 7.99M,
                    Rating = "R"
                },

                new Movie
                {
                    Title = "Ghostbusters ",
                    WatchedDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    TimeStamp = 8.99M,
                    Rating = "G"
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    WatchedDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    TimeStamp = 9.99M,
                    Rating = "G"
                },

                new Movie
                {
                    Title = "Rio Bravo",
                    WatchedDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    TimeStamp = 3.99M,
                    Rating = "NA"
                }
            );
            context.SaveChanges();
        }
    }
}
