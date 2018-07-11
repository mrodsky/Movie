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


        [Fact]
        // voting on the movie should have a movie objecty
        // and also we need voters (moviegoer spectators)
        public void Test_VotingForMovie()
        {
            var expected = 1;
            var sut = new Voting();
            

            Assert.NotNull(sut.Movie);
        }

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
