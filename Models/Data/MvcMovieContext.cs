using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System.Linq;
using MvcMovie.Models;
using System.Data;



namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<GenreCategory> GenreCategories { get; set; }
        public DbSet<MovieMapping> MovieMappings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<MovieMapping>()
                .HasKey(e => new { e.MovieId, e.CategoryId });

            modelBuilder.Entity<MovieMapping>()
                .HasOne(pt => pt.Movie)
                .WithMany(p => p.Mappings)
                .HasForeignKey(pt => pt.MovieId);

            modelBuilder.Entity<MovieMapping>()
                .HasOne(pt => pt.Category)
                .WithMany(t => t.Mappings)
                .HasForeignKey(pt => pt.CategoryId);
        }
        
    }


}

