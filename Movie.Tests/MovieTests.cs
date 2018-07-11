using Movie.Library;
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
    }
}
