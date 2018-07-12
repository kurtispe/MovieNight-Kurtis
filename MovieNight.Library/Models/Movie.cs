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

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }
                _title = value;
            }
        }

        public EGenre Genre
        {
            get;
            set;
        }
       



        public Movie()
        {
            Initialize();
        }
        public Movie(string title)
        {
            Initialize(title); 
        }
        public Movie(string title, EGenre genre)
        {
            Initialize(genre: genre, title: title);
        }
        public Movie(string title, EGenre genre, List<Actor> actors)
        {
            Initialize(title, genre, actors);
        }
        public void Initialize(
            string title = "(default title)",
            EGenre genre = EGenre.Action,
            List<Actor> actors = null  //new List<Actor>() //{Actors.Add(new Actor())}
            )
        {
            Title = title;
            Genre = genre;
            Actors = actors ?? new List<Actor> { new Actor() }; //reference values may not be used as default values as they may not exist at runtime, the compiler will not accept these
                         //  ^null operator, if the value to the left is null, use the value to the right         
        }
    }
}
