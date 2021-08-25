using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class MovieMapping
    {
        public long Id { get; set; }

        public int MovieId { get; set; }
        public int CategoryId { get; set; }
        //public string MovieName { get; set; }
        //public string Price { get; set; }
        //public string GenreCategories { get; set; }

        public Movie Movie { get; set; }
        public GenreCategory Category { get; set; }
    }

}
