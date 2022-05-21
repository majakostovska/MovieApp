using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Genre
    {
        public Genre()
        {
            movies = new List<Movie>();
        }
        [Key] 
        public int Id { get; set; }
        [Required]
        public string GenreName { get; set; }
        public virtual ICollection<Movie> movies { get; set; }

    }
}