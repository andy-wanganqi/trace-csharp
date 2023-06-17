using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp72
{
    internal class Stackalloc
    {
        static void Example()
        {
            Span<int> array1 = stackalloc int[3]; // currently allowed
            Span<int> array2 = stackalloc int[3] { 1, 2, 3 };
            Span<int> array3 = stackalloc int[] { 1, 2, 3 };
            Span<int> array4 = stackalloc[] { 1, 2, 3 };

            int length = 1000;
            Span<byte> buffer = length <= 1024 ? stackalloc byte[length] : new byte[length];

            unsafe
            {
                int size = 3;
                int* numbers = stackalloc int[size];
                for (var i = 0; i < size; i++)
                {
                    numbers[i] = i;
                }
            }
        }

    }
}
