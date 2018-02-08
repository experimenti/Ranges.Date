using Ranges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ranges.Date
{
    /// <summary>
    /// Helper class that represents a range of dates.
    /// <see cref="https://stackoverflow.com/questions/4781611/how-to-know-if-a-datetime-is-between-a-daterange-in-c-sharp"/>
    /// <see cref="https://martinfowler.com/eaaDev/Range.html"/>
    /// </summary>
    public class DateRange : IRange<DateTime>
    {
        public DateRange(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public bool Includes(DateTime value)
        {
            return (Start <= value) && (value <= End);
        }

        public bool Includes(IRange<DateTime> range)
        {
            return (Start <= range.Start) && (range.End <= End);
        }
    }
}