using MovieNight.Library.Enum;
using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests.Test
{
    public class MovieTest
    {
        //Movie movieShare = new Movie(); //exist forever, until program is closed, not recomended unless you want it static IE: everyone manipulates the same one between classes

        private Movie sut;

        public MovieTest()
        {
            sut = new Movie(); //only exist during the run time, each individual test is it's own run time 
        }

        [Fact] //atribute 
        public void Test_MovieId()
        {
            var expected = typeof(Guid);
            //var sut = new Movie();
            var actual = sut.Id;
            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_MovieActors()
        {
            var expected = 1;
            //var sut = new Movie();
            var actual = sut.Actors;
            Assert.True(typeof(List<Actor>) == actual.GetType());
            Assert.True(expected >= actual.Count);
        }

        [Fact]
        public void Test_MovieTitle()
        {
            var expected = typeof(string);
            Assert.True(expected == sut.Title.GetType());
        }

        [Fact]
        public void Test_MovieGenre()
        {
            var expected = typeof(EGenre);
            Assert.True(expected == sut.Genre.GetType());
        }

    }
}
