using Movie.Library;
using Movie.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Movie.Tests
{
    public class ShowingTests
    {
        [Fact]
        public void Test_ShowingId()
        {
            var expected = typeof(Guid);
            var sut = new Showing();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
    }
}
