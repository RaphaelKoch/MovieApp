using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class GenreInfo
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public IEnumerable<string> Genres { get; set; }
    }

}
