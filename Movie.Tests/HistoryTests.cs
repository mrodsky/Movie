using System;
using System.Collections.Generic;
using Movie.Library.Models;
using System.Text;
using Xunit;


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
    }
}
