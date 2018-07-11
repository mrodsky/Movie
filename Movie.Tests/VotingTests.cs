using Movie.Library;
using Movie.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Movie.Tests
{
    public class VotingTests
    {
        [Fact]
        public void Test_VotingId()
        {
            var expected = typeof(Guid);
            var sut = new Voting();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
    }
}
