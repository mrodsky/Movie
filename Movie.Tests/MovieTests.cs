using Movie.Library;
using Movie.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Movie.Tests
{
    public class MovieTests
    {
        [Fact]
        public void Test_MovieId()
        {
            var expected = typeof(Guid);
            var sut = new MovieClass();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        // what can be an enum? 
        public void Test_MovieActor()
        {
            var expected = 1;
            var sut = new MovieClass();
            var actual = sut.Actors;

            Assert.True(typeof(List<Actor>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
    }
}
