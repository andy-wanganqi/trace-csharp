using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp72
{
    public class FixedExample
    {
        public static void Play()
        {
            int[] PascalsTriangle = {
                          1,
                        1,  1,
                      1,  2,  1,
                    1,  3,  3,  1,
                  1,  4,  6,  4,  1, //RowFive
                1,  5,  10, 10, 5,  1
            };

            Span<int> RowFive = new Span<int>(PascalsTriangle, 10, 5);

            unsafe
            {
                fixed (int* ptrToRow = RowFive)
                {
                    var sum = 0;
                    for (int i = 0; i < RowFive.Length; i++)
                    {
                        sum += *(ptrToRow + i);
                    }
                    Console.WriteLine(sum);
                }
            }
        }

        public static void Play2()
        {
            Int2[] PascalsTriangle = {
                          Int2.N(1),
                        Int2.N(1),  Int2.N(1),
                      Int2.N(1),  Int2.N(2),  Int2.N(1),
                    Int2.N(1),  Int2.N(3),  Int2.N(3),  Int2.N(1),
                  Int2.N(1),  Int2.N(4),  Int2.N(6),  Int2.N(4),  Int2.N(1), //RowFive
                Int2.N(1),  Int2.N(5),  Int2.N(10), Int2.N(10), Int2.N(5),  Int2.N(1)
            };

            Span<Int2> RowFive = new Span<Int2>(PascalsTriangle, 10, 5);

            //unsafe
            //{
            //    fixed (int* ptrToRow = RowFive) // CS0266	Cannot implicitly convert type 'CSharp72.Int2*' to 'int*'
            //    {
            //        var sum = 0;
            //        for (int i = 0; i < RowFive.Length; i++)
            //        {
            //            sum += *(ptrToRow + i);
            //        }
            //        Console.WriteLine(sum);
            //    }
            //}
        }
    }

    public class ValueWrapper<T> where T : notnull
    {
        protected T value;
        public T Value
        {
            get => value;
            set => this.value = value;
        }
    }

    public class Int2 : ValueWrapper<int>
    {
        public static Int2 N(int val)
        {
            return new Int2() { Value = val };
        }

        public ref readonly int GetPinnableReference()
        {
            return ref value;
        }
    }
}
