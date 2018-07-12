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

        private List<Movie> Movies
        {
            get;
            set;
        }

        public Movie MakeMovie(string title)
        {
            var movie = new Movie();
            try //try is supposed to look for things that will brek the code
            {
                if (string.IsNullOrWhiteSpace(title))
                {
                    throw new ArgumentNullException(title, "title cannot be null or blank"); //creates teh exeption by hand
                }
                else
                {
                    return new Movie()// crux
                    {                 // crux
                        Title = title // crux
                    };                // crux
                }
            }
            catch(ArgumentNullException ex) //gives the exception to someone else, not my problem
            {
                MakeMovie("default"); //swallowing the error
            }
            catch (ArgumentException ex)
            {
                throw new Exception("not sure how it happened", ex);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally //finally happens regardless of the effors catched
            {
                //movie = new Movie(title);
                 GC.Collect(); 
               // GC.GetGeneration();
            }
            return movie;
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
