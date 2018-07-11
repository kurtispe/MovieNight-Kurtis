using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Voting : AModel
    {
        public List<Movie> Movies
        {
            get;
            set;
        }
        public List<Person> People
        {
            get;
            set;
        }

        public Voting()
        {
            Movies = new List<Movie>();
            People = new List<Person>();
        }


    }
}
