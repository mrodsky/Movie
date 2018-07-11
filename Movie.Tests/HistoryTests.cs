using System;
using System.Collections.Generic;
using Movie.Library.Models;
using System.Text;
using Xunit;
using Movie.Library;

namespace Movie.Tests
{
    
    public class HistoryTests
    {
        // our expectation is that expected will always be type Guid.
        [Fact]
        public void Test_HistoryId()
        {
            var expected = typeof(Guid);            
            var sut = new History();
            var actual = sut.Id;

            Assert.True(expected  == actual.GetType());
        }

        [Fact]
        public void Test_HistoryMovieList()
        {   
            var expected = 1;
            var sut = new History();
            var actual = sut.Movies;

            Assert.True(typeof(List<MovieClass>) == actual.GetType());
            Assert.True(expected <= actual.Count);
            
        }
    }
}
