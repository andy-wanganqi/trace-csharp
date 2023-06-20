using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    internal class LambdaExpressionImprovements
    {
        public static void Play()
        {
            var parse = (string s) => int.Parse(s); // Func<string, int>
            object parse2 = (string s) => int.Parse(s); // Func<string, int>
            Delegate parse3 = (string s) => int.Parse(s); // Func<string, int>

            var read = Console.Read; // Just one overload; Func<int> inferred
            // var write = Console.Write; // ERROR: Multiple overloads, can't choose

            LambdaExpression parseExpr = (string s) => int.Parse(s); // Expression<Func<string, int>>
            Expression parseExpr2 = (string s) => int.Parse(s);       // Expression<Func<string, int>>

            // var parse4 = s => int.Parse(s); // ERROR: Not enough type info in the lambda
            Func<string, int> parse5 = s => int.Parse(s);

            // var choose = (bool b) => b ? 1 : "two"; // ERROR: Can't infer return type
            var choose2 = object (bool b) => b ? 1 : "two"; // Func<bool, object>

            Func<string?, int?> parse6 = [ProvidesNullCheck] (s) => (s is not null) ? int.Parse(s) : null;
            var concat = ([DisallowNull] string a, [DisallowNull] string b) => a + b;
            var inc = [return: NotNullIfNotNull(nameof(s))] (int? s) => s.HasValue ? s++ : null;
        }
    }

    public class ProvidesNullCheckAttribute : Attribute { }

}
