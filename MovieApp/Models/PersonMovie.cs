using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class PersonMovie
    {
        public Movie movie { get; set; }
        public List<Person> people { get; set; }
        public int MovieId { get; set; }
        public int PersonId { get; set; }
    }
}