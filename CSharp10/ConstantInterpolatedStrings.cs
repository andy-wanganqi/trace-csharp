using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    internal class ConstantInterpolatedStrings
    {
        const string Day = "Friday";
        const string InterpolatedString = $"Today is {Day}";

        // The placeholder expressions can't be numeric constants because those constants are converted to strings at run time.
        // The current culture may affect their string representation.
        const int Year = 2023;
        // const string InterpolatedString2 = $"Today is {Day} in year {Year}"; // ERROR
    }
}
