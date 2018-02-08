
# Ranges.Date

An extremely small library that provides a Range implementation for dates (DateRange).

This is useful when you want to check if a DateTime is within a date range, e.g.
```csharp
var xmas = new DateTime(2018, 12, 25);

if (range.Includes(xmas))
{
	// Merry Christmas
}
```

For more information see:
* https://martinfowler.com/eaaDev/Range.html
* https://stackoverflow.com/questions/4781611/how-to-know-if-a-datetime-is-between-a-daterange-in-c-sharp

## Installation

```powershell
nuget install Ranges.Date
```

## Full Example

```csharp
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
```