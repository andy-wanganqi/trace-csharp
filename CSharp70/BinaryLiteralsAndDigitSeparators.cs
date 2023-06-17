using static System.Console;

namespace CSharp70
{
    public class BinaryLiteralsAndDigitSeparators
    {
        public static void Play()
        {
            var bn = 0b1000001;
            WriteLine(bn.GetType()); // System.Int32
            WriteLine(Convert.ToChar(bn)); // A

            long Salary = 1_00_00_00_00_000;
            WriteLine(Salary.GetType()); // System.Int64
            WriteLine(Salary); // 100000000000
        }
    }
}
