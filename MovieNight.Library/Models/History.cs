using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;


namespace MovieNight.Library.Models
{
    public class History : AModel
    {
        public List<Movie> Movies //doesn't actually have a list in it yet, it can mearly hold a list
        {
            get;
            set;
        }
        public History()
        {
            Movies = new List<Movie>();
            {
                Movies.Add(new Movie());
            }
        }
    }
}
