using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MovieNight.Library.Models;

namespace MovieNight.Tests.Test
{
    public class HistoryTest
    {
        [Fact] //atribute 
        public void Test_HistoryId()
        {
            var expected = typeof(Guid);
            var sut = new History();
            var actual = sut.Id;
            Assert.True(expected == actual.GetType());
        } 
        
        [Fact]
        public void Test_HistoryMovieList()
        {
            var expected = 1;
            var sut = new History();
            var actual = sut.Movies;

            Assert.True(typeof(List<Movie>) == actual.GetType());
            Assert.True(expected <= actual.Count);
           
        }
    }
}
