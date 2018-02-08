using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranges
{
    /// <summary>
    /// Interface for operations against some type T which represents a range of some type.
    /// <see cref="https://stackoverflow.com/questions/4781611/how-to-know-if-a-datetime-is-between-a-daterange-in-c-sharp"/>
    /// <see cref="https://martinfowler.com/eaaDev/Range.html"/>
    /// </summary>
    public interface IRange<T>
    {
        T Start { get; }
        T End { get; }
        bool Includes(T value);
        bool Includes(IRange<T> range);
    }

}
