using System;
using Xunit;
using Ranges.Date;

namespace Ranges.Tests
{
    public class DateRangeTests
    {
        [Fact]
        public void Include_Works()
        {
            var start = new DateTime(2018, 2, 1);
            var end = new DateTime(2018, 2, 28);

            var range = new DateRange(start, end);

            Assert.False(range.Includes(new DateTime(2018, 1, 31)));
            Assert.True(range.Includes(new DateTime(2018, 2, 1)));
            Assert.True(range.Includes(new DateTime(2018, 2, 15)));
            Assert.True(range.Includes(new DateTime(2018, 2, 28)));
            Assert.False(range.Includes(new DateTime(2018, 3, 1)));
        }
    }
}
