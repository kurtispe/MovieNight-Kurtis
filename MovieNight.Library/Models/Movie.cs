using MovieNight.Library.Abstracts;
using MovieNight.Library.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Movie : AModel
    {
        public List<Actor> Actors
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public EGenre Genre
        {
            get;
            set;
        }
        public Movie() // constructor
        {
            Actors = new List<Actor>();
            {
                Actors.Add(new Actor());
            }
            Title = string.Empty;
            Genre = EGenre.Spaghetti_Western;
        }
    }
}
