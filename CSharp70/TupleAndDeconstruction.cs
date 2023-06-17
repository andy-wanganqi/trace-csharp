using static System.Console;

namespace CSharp70
{
    public class TupleAndDeconstruction
    {
        public static void Play()
        {
            (double, int) t1 = (4.5, 3);
            WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");

            (double Sum, int Count) t2 = (4.5, 3);
            WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");

            WriteLine(t2.ToString()); // (4.5, 3)

            var Sum = 4.5;
            var Count = 3;
            var t3 = (Sum, Count);
            WriteLine($"Sum of {t3.Count} elements is {t3.Sum}.");
            
            t3 = t1; // Tuple Assignment

            var t =
                (1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18,
                19, 20, 21, 22, 23, 24, 25, 26);
            WriteLine(t.Item26);  // output: 26

            for (int i = 4; i < 20; i++)
            {
                if (Math.DivRem(i, 3) is (Quotient: var q, Remainder: 0))
                {
                    WriteLine($"{i} is divisible by 3, with quotient {q}");
                }
            }

            var t4 = (Sum: 4.5, Count: 3);
            WriteLine(t4 == t2 ? "TRUE" : "FALSE"); // TRUE

            var t5 = ((Sum: 4.5, Count: 3), (string?)null);
            // WriteLine(t4 == t5 ? "TRUE" : "FALSE"); // Cannot compile

            var limitsLookup = new Dictionary<int, (int Min, int Max)>()
            {
                [2] = (4, 10),
                [4] = (10, 20),
                [6] = (0, 23)
            };
            if (limitsLookup.TryGetValue(4, out (int Min, int Max) limits))
            {
                Console.WriteLine($"Found limits: min is {limits.Min}, max is {limits.Max}");
            }
            // Output:
            // Found limits: min is 10, max is 20
        }
    }
}
