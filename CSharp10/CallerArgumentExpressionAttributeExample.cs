using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    public static class CallerArgumentExpressionAttributeExample
    {
        public static void Operation(Action func)
        {
            // if func is null, then the output is:
            //   Argument failed validation: <func is not null>
            ValidateArgument(nameof(func), func is not null); 
            func();
        }

        // CallerArgumentExpression will use the expression of "condition" as the message
        public static void ValidateArgument(string parameterName, bool condition, [CallerArgumentExpression("condition")] string? message = null)
        {
            if (!condition)
            {
                throw new ArgumentException($"Argument failed validation: <{message}>", parameterName);
            }
        }


        public static IEnumerable<T> Sample<T>(this IEnumerable<T> sequence, int frequency,
            [CallerArgumentExpression(nameof(sequence))] string? message = null)
        {
            if (sequence.Count() < frequency)
                throw new ArgumentException($"Expression doesn't have enough elements: {message}", nameof(sequence));
            int i = 0;
            foreach (T item in sequence)
            {
                if (i++ % frequency == 0)
                    yield return item;
            }
        }

        public static void CallSample()
        {
            var sample = Enumerable.Range(0, 10).Sample(100);
            // Output: 
            //   Expression doesn't have enough elements: Enumerable.Range(0, 10) (Parameter 'sequence')
        }
    }
}
