using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    public class DeclarationPattern
    {
        public static void Play()
        {
            object greeting = "Hello, World!";
            if (greeting is string message)
            {
                Console.WriteLine(message.ToLower());  // output: hello, world!
            }
        }
    }

    public class TypePattern
    {
        public static void Play()
        {
            var numbers = new int[] { 10, 20, 30 };
            Console.WriteLine(GetSourceLabel(numbers));  // output: 1

            var letters = new List<char> { 'a', 'b', 'c', 'd' };
            Console.WriteLine(GetSourceLabel(letters));  // output: 2
        }

        static int GetSourceLabel<T>(IEnumerable<T> source) => source switch
        {
            Array array => 1, // Array: System.Collections.ICollection
            System.Collections.ICollection collection => 1,
            ICollection<T> collection => 2,
            null => 3, // Null constant pattern
            _ => 4,
        };
    }

    public class ConstantPattern
    {
        const int One = 1;
        public static decimal GetGroupTicketPrice(int visitorCount) => visitorCount switch
        {
            One => 12.0m,
            2 => 20.0m,
            3 => 27.0m,
            4 => 32.0m,
            0 => 0.0m,
            _ => throw new ArgumentException($"Not supported number of visitors: {visitorCount}", nameof(visitorCount)),
        };
    }

    public class RelationalPatterns
    {
        public static void Play()
        {
            Console.WriteLine(Classify(13));  // output: Too high
            Console.WriteLine(Classify(double.NaN));  // output: Unknown
            Console.WriteLine(Classify(2.4));  // output: Acceptable

            Console.WriteLine(GetCalendarSeason(new DateTime(2021, 3, 14)));  // output: spring
            Console.WriteLine(GetCalendarSeason(new DateTime(2021, 7, 19)));  // output: summer
            Console.WriteLine(GetCalendarSeason(new DateTime(2021, 2, 17)));  // output: winter
        }

        static string Classify(double measurement) => measurement switch
        {
            < -4.0 => "Too low",
            > 10.0 => "Too high",
            double.NaN => "Unknown",
            _ => "Acceptable",
        };

        static string GetCalendarSeason(DateTime date) => date.Month switch
        {
            >= 3 and < 6 => "spring",
            >= 6 and < 9 => "summer",
            >= 9 and < 12 => "autumn",
            12 or (>= 1 and < 3) => "winter",
            _ => throw new ArgumentOutOfRangeException(nameof(date), $"Date with unexpected month: {date.Month}."),
        };
    }

    public class LogicalPatterns
    {
        // Precedence and order of checking: not, and, or

        static string Classify(double measurement) => measurement switch
        {
            < -40.0 => "Too low",
            >= -40.0 and < 0 => "Low",
            >= 0 and < 10.0 => "Acceptable",
            >= 10.0 and < 20.0 => "High",
            >= 20.0 => "Too high",
            double.NaN => "Unknown",
        };

        static string GetCalendarSeason(DateTime date) => date.Month switch
        {
            3 or 4 or 5 => "spring",
            6 or 7 or 8 => "summer",
            9 or 10 or 11 => "autumn",
            12 or 1 or 2 => "winter",
            _ => throw new ArgumentOutOfRangeException(nameof(date), $"Date with unexpected month: {date.Month}."),
        };

        static bool IsLetter(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');
    }

    public class PropertyPattern
    {
        static bool IsConferenceDay(DateTime date) => date is { Year: 2020, Month: 5, Day: 19 or 20 or 21 };

        public static void Play()
        {
            Console.WriteLine(TakeFive("Hello, world!"));  // output: Hello
            Console.WriteLine(TakeFive("Hi!"));  // output: Hi!
            Console.WriteLine(TakeFive(new[] { '1', '2', '3', '4', '5', '6', '7' }));  // output: 12345
            Console.WriteLine(TakeFive(new[] { 'a', 'b', 'c' }));  // output: abc
        }

        static string TakeFive(object input) => input switch
        {
            string { Length: >= 5 } s => s.Substring(0, 5),
            string s => s,

            ICollection<char> { Count: >= 5 } symbols => new string(symbols.Take(5).ToArray()),
            ICollection<char> symbols => new string(symbols.ToArray()),

            null => throw new ArgumentNullException(nameof(input)),
            _ => throw new ArgumentException("Not supported input type."),
        };

        public record Point(int X, int Y);
        public record Segment(Point Start, Point End);
        static bool IsAnyEndOnXAxis(Segment segment) =>
            segment is { Start: { Y: 0 } } or { End: { Y: 0 } };
        static bool IsAnyEndOnXAxis2(Segment segment) =>
            segment is { Start.Y: 0 } or { End.Y: 0 };
    }

    public class PositionalPattern
    {
        public readonly struct Point
        {
            public int X { get; }
            public int Y { get; }
            public Point(int x, int y) => (X, Y) = (x, y);
            public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
        }

        static string Classify(Point point) => point switch
        {
            (0, 0) => "Origin",
            (1, 0) => "positive X basis end",
            (0, 1) => "positive Y basis end",
            _ => "Just a point",
        };


        public static void Play()
        {
            var numbers = new List<int> { 1, 2, 3 };
            if (SumAndCount(numbers) is (Sum: var sum, Count: > 0)) // Tuple and Property Pattern
            {
                Console.WriteLine($"Sum of [{string.Join(" ", numbers)}] is {sum}");  // output: Sum of [1 2 3] is 6
            }
        }
        static (double Sum, int Count) SumAndCount(IEnumerable<int> numbers) // Return a tuple
        {
            int sum = 0;
            int count = 0;
            foreach (int number in numbers)
            {
                sum += number;
                count++;
            }
            return (sum, count);
        }


        public record WeightedPoint(int X, int Y)
        {
            public double Weight { get; set; }
        }
        static bool IsInDomain(WeightedPoint point) => point is ( >= 0, >= 0) { Weight: >= 0.0 };
    }

    public class VarPattern
    {
        static bool IsAcceptable(int id, int absLimit) =>
            SimulateDataFetch(id) is var results
            && results.Min() >= -absLimit
            && results.Max() <= absLimit;
        static int[] SimulateDataFetch(int id)
        {
            var rand = new Random();
            return Enumerable
                .Range(start: 0, count: 5)
                .Select(s => rand.Next(minValue: -10, maxValue: 11))
                .ToArray();
        }


        public record Point(int X, int Y);
        static Point Transform(Point point) => point switch
        {
            var (x, y) when x < y => new Point(-x, y),
            var (x, y) when x > y => new Point(x, -y),
            var (x, y) => new Point(x, y),
        };
        static void TestTransform()
        {
            Console.WriteLine(Transform(new Point(1, 2)));  // output: Point { X = -1, Y = 2 }
            Console.WriteLine(Transform(new Point(5, 2)));  // output: Point { X = 5, Y = -2 }
        }

        static Point Transform2(Point point) => point switch
        {
            (var x, var y) when x < y => new Point(-x, y),
            (var x, var y) when x > y => new Point(x, -y),
            (var x, var y) => new Point(x, y),
        };
    }

    public class DiscardPattern
    {
        public static void Play()
        {
            Console.WriteLine(GetDiscountInPercent(DayOfWeek.Friday));  // output: 5.0
            Console.WriteLine(GetDiscountInPercent(null));  // output: 0.0
            Console.WriteLine(GetDiscountInPercent((DayOfWeek)10));  // output: 0.0
        }
        static decimal GetDiscountInPercent(DayOfWeek? dayOfWeek) => dayOfWeek switch
        {
            DayOfWeek.Monday => 0.5m,
            DayOfWeek.Tuesday => 12.5m,
            DayOfWeek.Wednesday => 7.5m,
            DayOfWeek.Thursday => 12.5m,
            DayOfWeek.Friday => 5.0m,
            DayOfWeek.Saturday => 2.5m,
            DayOfWeek.Sunday => 2.0m,
            _ => 0.0m, // Here is the discard pattern
        };
    }

    //public class ParenthesizedPattern // C# 9
    //{
    //    public static void Play(object input)
    //    {
    //        if (input is not (float or double))
    //        {
    //            return;
    //        }
    //    }
    //}

    //public class ListPatterns // C# 11
    //{
    //    public static void Play()
    //    {
    //        int[] numbers = { 1, 2, 3 };

    //        Console.WriteLine(numbers is [1, 2, 3]);  // True
    //        Console.WriteLine(numbers is [1, 2, 4]);  // False
    //        Console.WriteLine(numbers is [1, 2, 3, 4]);  // False
    //        Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]);  // True
    //    }
    //}
}
