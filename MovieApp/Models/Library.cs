using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Library
    {
        public Movie movie { get; set; }
        public List<Person> persons { get; set; }
        public Library()
        {
            persons = new List<Person>();
        }
    }
}