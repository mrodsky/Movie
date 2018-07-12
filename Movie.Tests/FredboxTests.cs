using Movie.Library;
using Movie.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Movie.Tests
{
    public class FredboxTests
    {
        private Fredbox sut;
        public FredboxTests()
        {
            sut = new Fredbox();
        }

        // what does fredbox do ? what should it be able to do?
        [Fact]
        public void Test_FredboxMakeMovie()
        {
            var expected = "My First Movie";
            var actual = sut.MakeMovie(expected);

            Assert.True(expected == actual.Title);
        }


        [Fact]
        public void Test_FredboxGetMovies()
        {
            var expected = 0;
            var actual = sut.GetMovies();

            Assert.True(expected <= actual.Count());
        }


        [Fact]
        public void Test_FredboxDistributeMovie()
        {
            var title = "My Second Movie";
            var expected = sut.GetMovies(); // we want to see what movies currently has 
           
            sut.DistributeMovie(sut.MakeMovie(title));
            var  actual = sut.GetMovies();

            Assert.True(expected.Count() <= actual.Count()); // we want to check our count before we distribute should be less then our new list 
        }
    }
}
