using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class FredBox
    {
        public FredBox()
        {
             Movies = new List<Movie>();   
        }

        public List<Movie> Movies
        {
            get;
            set;
        }

        public Movie MakeMovie(string title)
        {
            return new Movie()
            {
                Title = title
            };
        }

        public IEnumerable<Movie> GetMovie()
        {
            return Movies;
        }

        public void DistributeMovies(Movie movie)
        {
            Movies.Add(movie);
        }
    }
}
