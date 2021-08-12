using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
   
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
                {

                // Look for any movies.
                if (context.Movies.Any())
                {
                    return;   // DB has been seeded
                }

                
                Movie movie1 = new Movie()
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Price = 7.99M,
                };

                Movie movie2 = new Movie()
                {
                    Title = "Kevin Grishams Ghostbusters",
                    ReleaseDate = DateTime.Parse("1987-2-09"),
                    Price = 7.99M
                };

                Movie movie3 = new Movie()
                {
                    Title = "Kingdom Hearts - Urban Fervor II",
                    ReleaseDate = DateTime.Parse("2000-2-12"),
                    Price = 6.22M
                };

                Movie movie4 = new Movie()
                {
                    Title = "Alien Space-Cat, Ahoi!",
                    ReleaseDate = DateTime.Parse("1949-2-02"),
                    Price = 16.99M
                };

                Movie movie5 = new Movie()
                {
                    Title = "A Kiwi isn't really fruit - It's Kiwi-meat",
                    ReleaseDate = DateTime.Parse("1973-5-31"),
                    Price = 9.89M
                };

                Movie movie6 = new Movie()
                {
                    Title = "Rural Juror III - Assassin: Penguin",
                    ReleaseDate = DateTime.Parse("1997-7-10"),
                    Price = 7.99M
                };

                Genre genre1 = new Genre()
                {
                    Name = "Action"
                };

                Genre genre2 = new Genre()
                {
                    Name = "Adventure"
                };

                Genre genre3 = new Genre()
                {
                    Name = "Horror"
                };

                Genre genre4 = new Genre()
                {
                    Name = "Comedy"
                };

                Genre genre5 = new Genre()
                {
                    Name = "Historical"
                };

                Genre genre6 = new Genre()
                {
                    Name = "Documentary"
                };

                MovieGenre movieGenre1 = new MovieGenre()
                {
                    Movie = movie1,
                    Genre = genre1, 
                   
                };

                MovieGenre movieGenre2 = new MovieGenre()
                {
                    Movie = movie1,
                    Genre = genre2,

                };

                context.Movies.AddRange(
                    movie1, movie2, movie3, movie4, movie5, movie6
                );

                context.Genres.AddRange(
                    genre1, genre2, genre3, genre4, genre5, genre6
                );
                    
                context.MovieGenres.AddRange(movieGenre1, movieGenre2);



                context.SaveChanges();                
            }
        }
    }
}