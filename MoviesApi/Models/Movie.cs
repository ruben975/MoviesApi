using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Models
{
    public class Movie
    {
        public String Name { get; set; }
        public Guid ID { get; set; }
        public int ReleaseYear { get; set; }
    }
}
