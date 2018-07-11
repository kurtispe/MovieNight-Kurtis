using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace MovieNight.Tests.Test
{
    public class PersonTest
    {

        [Fact] //atribute 
        public void Test_PersonId()
        {
            var expected = typeof(Guid);
            var sut = new Person();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_PersonHistory()
        {
            var sut = new Person();
            Assert.NotNull(sut.HasHistory);
        }

    }
}
