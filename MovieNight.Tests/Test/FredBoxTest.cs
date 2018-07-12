using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace MovieNight.Tests.Test
{
    public class FredBoxTest
    {
        private FredBox sut;

        public FredBoxTest()
        {
            sut = new FredBox();
        }
        [Fact]
        public void Test_FredBoxMakeMovie()
        {
            var expected = "my first movie";
            var actual = sut.MakeMovie(expected);
            Assert.True(expected == actual.Title);
        }
        [Fact]
        public void Test_FredBoxGetMovies()
        {
            var expected = 0;
            var actual = sut.GetMovie();
            Assert.True(expected <= actual.Count());
        }

        [Fact]
        public void Test_FredBoxDistributedMovie()
        {
            var title = "my second movie";
            var expected = sut.GetMovie().Count();
            var movie = sut.MakeMovie(title);
            sut.DistributeMovies(movie);
            var actual = sut.GetMovie().Count();
            Assert.True(expected < actual);
        }

        //make a movie, have a title, genre, at least 1 actor, none of the added code should be in make move

    }
}
