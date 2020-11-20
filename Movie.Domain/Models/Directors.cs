using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Domain.Models
{
    public class Directors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountMovies { get; set; }
    }
}
