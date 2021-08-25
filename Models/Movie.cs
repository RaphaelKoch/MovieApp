using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System.Linq;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }        
        public string MovieName { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }

        public ICollection<MovieMapping> Mappings { get; set; } // navigation
    }
}