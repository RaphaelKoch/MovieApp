using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Collections;
using System.Linq;

using System.Collections.Generic;

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
                    MovieName = "When Harry Met Sally",
                    Mappings = new List<MovieMapping>(),
                    //ReleaseDate = DateTime.Parse("1989-2-12"),
                    //Price = 7.99M,
                };

                Movie movie2 = new Movie()
                {
                    MovieName = "Kevin Grishams Ghostbusters",
                    Mappings = new List<MovieMapping>(),
                    //ReleaseDate = DateTime.Parse("1987-2-09"),
                    //Price = 7.99M
                };

                Movie movie3 = new Movie()
                {
                    MovieName = "Kingdom Hearts - Urban Fervor II",
                    Mappings = new List<MovieMapping>(),
                    //ReleaseDate = DateTime.Parse("2000-2-12"),
                    //Price = 6.22M
                };

                Movie movie4 = new Movie()
                {
                    MovieName = "Alien Space-Cat, Ahoi!",
                    Mappings = new List<MovieMapping>(),
                    //ReleaseDate = DateTime.Parse("1949-2-02"),
                    //Price = 16.99M
                };

                Movie movie5 = new Movie()
                {
                    MovieName = "A Kiwi isn't really fruit - It's Kiwi-meat",
                    Mappings = new List<MovieMapping>(),
                    //ReleaseDate = DateTime.Parse("1973-5-31"),
                    //Price = 9.89M
                };

                Movie movie6 = new Movie()
                {
                    MovieName = "Rural Juror III - Assassin: Penguin",
                    Mappings = new List<MovieMapping>(),
                    //ReleaseDate = DateTime.Parse("1997-7-10"),
                    //Price = 7.99M
                };

                GenreCategory genre1 = new GenreCategory()
                {
                    Name = "Action"
                };

                GenreCategory genre2 = new GenreCategory()
                {
                    Name = "Adventure"
                };

                GenreCategory genre3 = new GenreCategory()
                {
                    Name = "Horror"
                };

                GenreCategory genre4 = new GenreCategory()
                {
                    Name = "Comedy"
                };

                GenreCategory genre5 = new GenreCategory()
                {
                    Name = "Historical"
                };

                GenreCategory genre6 = new GenreCategory()
                {
                    Name = "Documentary"
                };

                MovieMapping movieMapping11 = new MovieMapping()
                {
                    Movie = movie1,
                    Category = genre1,
                };

                MovieMapping movieMapping12 = new MovieMapping()
                {
                    Movie = movie1,
                    Category = genre2,
                };

                MovieMapping movieMapping21 = new MovieMapping()
                {
                    Movie = movie2,
                    Category = genre3,
                };

                MovieMapping movieMapping22 = new MovieMapping()
                {
                    Movie = movie2,
                    Category = genre4,
                };
                                
                MovieMapping movieMapping23 = new MovieMapping()
                {
                    Movie = movie2,
                    Category = genre5,
                };
                MovieMapping movieMapping3 = new MovieMapping()
                {
                    Movie = movie3,
                    Category = genre1,
                };

                MovieMapping movieMapping41 = new MovieMapping()
                {
                    Movie = movie4,
                    Category = genre4,
                };

                MovieMapping movieMapping42 = new MovieMapping()
                {
                    Movie = movie4,
                    Category = genre5,
                };

                MovieMapping movieMapping5 = new MovieMapping()
                {
                    Movie = movie5,
                    Category = genre6,
                };

                MovieMapping movieMapping6 = new MovieMapping()
                {
                    Movie = movie6,
                    Category = genre1,
                };

                movie1.Mappings.Add(movieMapping11);
                movie1.Mappings.Add(movieMapping12);

                movie2.Mappings.Add(movieMapping21);
                movie2.Mappings.Add(movieMapping22);
                movie2.Mappings.Add(movieMapping23);

                movie3.Mappings.Add(movieMapping3);

                movie4.Mappings.Add(movieMapping41);
                movie4.Mappings.Add(movieMapping42);

                movie5.Mappings.Add(movieMapping5);

                movie6.Mappings.Add(movieMapping6);

                context.Movies.AddRange(
                    movie1, movie2, movie3, movie4, movie5, movie6
                );

                context.GenreCategories.AddRange(
                    genre1, genre2, genre3, genre4, genre5, genre6
                );

                context.MovieMappings.AddRange();

                context.SaveChanges();
            }
        }
    }
}