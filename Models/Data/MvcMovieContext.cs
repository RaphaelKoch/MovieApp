using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System.Linq;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
            //var result = db.Movie
            //.Select(r => new GenreInfo
            //{
            //    MovieId = r.Id,
            //    Title = r.Title,
            //    Genres = r.Genres
            //        .Select(m => m.Genre.Name)
            //        .ToList() // <-- to avoid N + 1 subquery in EF Core 2.1+
            //})
            //.ToList();
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }


    }
    
}

