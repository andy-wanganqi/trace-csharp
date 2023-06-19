using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    internal class ReadonlyMembers
    {
        public static void Play()
        {
            var coords = new Coords(100, 200);
            //coords.X = 101; // Error
        }
    }

    public readonly struct Coords
    {
        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; init; }
        public double Y { get; init; }

        public override string ToString() => $"({X}, {Y})";
    }

    public struct Transcript
    {
        public int Math { get; set; }
        public int Chemical { get; set; }

        private int counter;
        public int Counter
        {
            readonly get 
            {
                // counter++; // Error
                return counter;
            }
            set => counter = value;
        }

        private int biology;
        public readonly int Biology
        {
            get
            {
                // biology++; // Error
                return biology;
            }
            set
            {
                // biology = value; // Error
            }
        }

        public int Average()
        {
            Math = 100;
            return (Math + Chemical) / 2;
        }

        public readonly int Sum()
        {
            // Math = 100; // Error
            return Math + Chemical;
        }

        public readonly override string ToString() => $"({Math}, {Chemical})";
    }

}
