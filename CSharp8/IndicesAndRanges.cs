using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    internal class IndicesAndRanges
    {
        public static void Play()
        {
            int[] numbers = new[] { 0, 10, 20, 30, 40, 50 };
            int start = 1;
            int amountToTake = 3;
            int[] subset = numbers[start..(start + amountToTake)];
            Display(subset);  // output: 10 20 30

            int margin = 1;
            int[] inner = numbers[margin..^margin];
            Display(inner);  // output: 10 20 30 40

            string line = "one two three";
            int amountToTakeFromEnd = 5;
            Range endIndices = ^amountToTakeFromEnd..^0;
            string end = line[endIndices];
            Console.WriteLine(end);  // output: three

            void Display<T>(IEnumerable<T> xs) => Console.WriteLine(string.Join(" ", xs));


            int amountToDrop = numbers.Length / 2;

            int[] rightHalf = numbers[amountToDrop..];
            Display(rightHalf);  // output: 30 40 50

            int[] leftHalf = numbers[..^amountToDrop];
            Display(leftHalf);  // output: 0 10 20

            int[] all = numbers[..];
            Display(all);  // output: 0 10 20 30 40 50
        }

        public static void BetterExample()
        {
            int[] oneThroughTen =
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            Write(oneThroughTen, ..);
            Write(oneThroughTen, ..3);
            Write(oneThroughTen, 2..);
            Write(oneThroughTen, 3..5);
            Write(oneThroughTen, ^2..); // left index = 10 - 2 = 8 ==> 9
            Write(oneThroughTen, ..^3);
            Write(oneThroughTen, 3..^4);
            Write(oneThroughTen, ^4..^2); // left index = 10 - 4 = 6 ==> 7

            static void Write(int[] values, Range range) =>
                Console.WriteLine($"{range}:\t{string.Join(", ", values[range])}");
            // Sample output:
            //      0..^0:      1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            //      0..3:       1, 2, 3
            //      2..^0:      3, 4, 5, 6, 7, 8, 9, 10
            //      3..5:       4, 5
            //      ^2..^0:     9, 10
            //      0..^3:      1, 2, 3, 4, 5, 6, 7
            //      3..^4:      4, 5, 6
            //      ^4..^2:     7, 8
        }
    }
}
