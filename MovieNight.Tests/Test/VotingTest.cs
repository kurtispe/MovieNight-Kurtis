using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests.Test
{
    public class VotingTest
    {

        [Fact] //atribute 
        public void Test_VotingId()
        {
            var expected = typeof(Guid);
            var sut = new Voting();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

       // [Fact]
        //public void Test_VotingPerson()
       // {
         //   var sut = new Person();
           // var actual = sut.Vote;
           // Assert.NotNull(actual);
        //}

        //[Fact]
        //public void Test_VotingShowings()
        //{
         //   var sut = new Voting();
          //  var actual = sut.Showings;
          //  Assert.NotNull(actual);
        //}

        [Fact]
        public void Test_VotingMovie()
        {
            var sut = new Voting();
            Assert.NotNull(sut.Movies);
        }

        [Fact]
        public void Test_VotingPeople()
        {
            var expected = 0;
            var sut = new Voting();
            var actual = sut.People;

            Assert.True(typeof(List<Person>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
    }
}
