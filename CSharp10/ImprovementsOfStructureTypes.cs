using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    internal class ImprovementsOfStructureTypes
    {
        public static void Play()
        {
            var m1 = new Measurement();
            Console.WriteLine(m1);  // output: NaN (Undefined)

            var m2 = default(Measurement);
            Console.WriteLine(m2);  // output: 0 ()

            var m3 = new Measurement(5);
            Console.WriteLine(m1);  // output: 5 (Ordinary measurement)

            var ms = new Measurement[2];
            Console.WriteLine(string.Join(", ", ms));  // output: 0 (), 0 ()
        }
    }

    public readonly struct Measurement
    {
        public Measurement()
        {
            Value = double.NaN;
            Description = "Undefined";
        }

        public Measurement(double value, string description)
        {
            Value = value;
            Description = description;
        }

        public Measurement(double value)
        {
            Value = value;
        }

        public Measurement(string description)
        {
            Description = description;
        }

        public double Value { get; init; }
        public string Description { get; init; } = "Ordinary measurement";

        public override string ToString() => $"{Value} ({Description})";
    }
}
