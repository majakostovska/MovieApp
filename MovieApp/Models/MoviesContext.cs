using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class MoviesContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public MoviesContext() : base("DefaultConnection")
        {
        }
        public static MoviesContext Create()
        {
            return new MoviesContext();
        }
    }
}