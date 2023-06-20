namespace CSharp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
#line 200 "Special"
            int i;
            int j;
#line default
            char c;
            float f;
#line hidden // numbering not affected
            string s;
            double d;
            /*
1>D:\Workplace\trace-csharp\CSharp10\Special(200,17,200,18): warning CS0168: The variable 'i' is declared but never used
1>D:\Workplace\trace-csharp\CSharp10\Special(201,17,201,18): warning CS0168: The variable 'j' is declared but never used
1>D:\Workplace\trace-csharp\CSharp10\Program.cs(11,18,11,19): warning CS0168: The variable 'c' is declared but never used
1>D:\Workplace\trace-csharp\CSharp10\Program.cs(12,19,12,20): warning CS0168: The variable 'f' is declared but never used
1>D:\Workplace\trace-csharp\CSharp10\Program.cs(14,20,14,21): warning CS0168: The variable 's' is declared but never used
1>D:\Workplace\trace-csharp\CSharp10\Program.cs(15,20,15,21): warning CS0168: The variable 'd' is declared but never used
            */


#line (1, 1) - (5, 60) 10 "partial-class.cs"
            /*34567*/ int b = 0;
            /*
1>D:\Workplace\trace-csharp\CSharp10\partial-class.cs(1,18,1,19): warning CS0219: The variable 'b' is assigned but its value is never used

EXPLANATION:
(1, 1): The start line and column for the first character on the line that follows the directive. In this example, the next line would be reported as line 1, column 1.
(5, 60): The end line and column for the marked region.
10: The column offset for the #line directive to take effect. In this example, the 10th column would be reported as column one. That's where the declaration int b = 0; begins. This field is optional. If omitted, the directive takes effect on the first column.
"partial-class.cs": The name of the output file.
            */
        }

    }
}