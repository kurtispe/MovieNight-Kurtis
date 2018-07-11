using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Person : APerson
    {
       // public Movie Vote
       // {
       //     get;
       //     set;
       // }
        public History HasHistory
        {
            get;
            set;
        }
            
        public Person()
        {
        //    Vote = new Movie();
            HasHistory = new History();
        }
    }
}
