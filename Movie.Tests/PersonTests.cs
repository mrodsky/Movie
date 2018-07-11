﻿using Movie.Library;
using Movie.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Movie.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Test_PersonId()
        {
            var expected = typeof(Guid);
            var sut = new Person();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
    }
}
