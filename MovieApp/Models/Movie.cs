using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Movie
    {
        public Movie()
        {
            people = new List<Person>();
            genres = new List<Genre>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImageURL { get; set; }
        [Required]
        public float Rating { get; set; }
        public virtual ICollection<Person> people { get; set; }
        public virtual ICollection<Genre> genres { get; set; }
    }
}