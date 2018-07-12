using Movie.Library;
using Movie.Library.Enums;
using Movie.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Movie.Tests
{
    public class MovieTests
    {

       private MovieClass sut;         // Field for the movieclass object. 

        public MovieTests()                //constructor for MovieTests
        {
            sut = new MovieClass();
        }

        [Fact]
        public void Test_MovieId()
        {
            var expected = typeof(Guid);
          
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        // what can be an enum? 
        public void Test_MovieActor()
        {
            var expected = 1;
            var actual = sut.Actors;

            Assert.True(typeof(List<Actor>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }

        [Fact]
        public void Test_MovieTitle()
        {
            var expected = typeof(string);

            Assert.True(expected == sut.Title.GetType());
            Assert.NotEmpty(sut.Title);
        }

        [Fact]
        public void Test_MovieGenre()
        {
            var expected = typeof(EGenre);

            Assert.True(expected == sut.Genre.GetType());
            Assert.NotEqual(EGenre.None, sut.Genre);
        }
    }
}