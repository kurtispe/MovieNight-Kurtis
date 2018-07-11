using System;
using System.Collections.Generic;
using System.Text;
using MovieNight.Library.Abstracts;

namespace MovieNight.Library.Models
{
    public class Showing : AModel
    {

        public List<Movie> Movies
        {
            get;
            set;
        }

        public Showing()
        {
            Movies = new List<Movie>();
            {
                Movies.Add(new Movie());
            }
        }
    }
}
