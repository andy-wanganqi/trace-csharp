using ImportedCSharpLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp70
{
    public class NumberStore
    {
        int[] numbers = { 1, 3, 7, 15, 31, 63, 127, 255, 511, 1023 };

        public ref int FindNumber(int target)
        {
            for (int ctr = 0; ctr < numbers.Length; ctr++)
            {
                if (numbers[ctr] >= target)
                    return ref numbers[ctr];
            }
            return ref numbers[0];
        }

        public override string ToString() => string.Join(" ", numbers);
    }
}
