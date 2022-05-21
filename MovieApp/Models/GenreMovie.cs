using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class GenreMovie
    {
        public Movie movie { get; set; }
        public List<Genre> genres { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
    }
}