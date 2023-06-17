using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp72
{
    // Typically, you define a ref struct type when you need a type that also includes data members of ref struct types
    public ref struct CustomRef
    {
        public bool IsValid;
        public Span<int> Inputs;
        public Span<int> Outputs;
    }
    public readonly ref struct ConversionRequest
    {
        public ConversionRequest(double rate, ReadOnlySpan<double> values)
        {
            Rate = rate;
            Values = values;
        }

        public double Rate { get; }
        public ReadOnlySpan<double> Values { get; }
    }
}
