using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System.Linq;

namespace MvcMovie.Models

{
    public class GenreCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<MovieMapping> Mappings { get; set; }
    }
}