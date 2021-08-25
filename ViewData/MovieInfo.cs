using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class MovieInfo
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public IEnumerable<string> GenreCategories { get; set; }
    }
}