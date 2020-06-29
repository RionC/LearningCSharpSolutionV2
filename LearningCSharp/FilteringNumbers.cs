using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class FilteringNumbers
    {
        [Fact]
        public void WeCanFilterOutEvents()
        {
            var numberFilter = new NumberFilter();
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> events = numberFilter.FilterOutEvens(numbers);

            Assert.Equal(1, events[0]);
            Assert.Equal(3, events[1]);
            Assert.Equal(5, events[2]);
            Assert.Equal(7, events[3]);
        }

        [Fact]
        public void WeCanFilterOutOdds()
        {
            var numberFilter = new NumberFilter();
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> events = numberFilter.FilterOutOdds(numbers);

            Assert.Equal(2, events[0]);
            Assert.Equal(4, events[1]);
            Assert.Equal(6, events[2]);
            Assert.Equal(8, events[3]);
        }
    }
}
