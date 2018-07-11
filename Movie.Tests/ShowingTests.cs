﻿using Movie.Library;
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

        [Fact]
        public void Test_ShowingMovies()
        {
            var expected = 1;
            var sut = new Showing();
            var actual = sut.Movies;

            Assert.True(typeof(List<MovieClass>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
    }
}
