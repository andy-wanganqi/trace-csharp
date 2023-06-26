using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    internal class NewlinesInStringInterpolations
    {
        public static int safetyScore { get; set; }
        public string message = $"The usage policy for {safetyScore} is {safetyScore switch
        {
            > 90 => "Unlimited usage",
            > 80 => "General usage, with daily safety check",
            > 70 => "Issues must be addressed within 1 week",
            > 50 => "Issues must be addressed within 1 day",
            _ => "Issues must be addressed before continued use",
        }
        }";

        public void Foo()
        {
            int X = 2;
            int Y = 3;

            var pointMessage = $"""The point "{X}, {Y}" is {Math.Sqrt(X * X + Y * Y)} from the origin""";
            var pointMessage2 = $$"""The point {{{X}}, {{Y}}} is {{Math.Sqrt(X * X + Y * Y)}} from the origin""";
        }
    }
}
