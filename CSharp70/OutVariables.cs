using static System.Console;

namespace CSharp70
{
    public class OutVariables
    {
        public static void Play()
        {
            var str1 = "100";
            if (int.TryParse(str1, out var int1))
            {
                WriteLine(int1);
            }

            var str2 = "abc";
            if(int.TryParse(str2, out var int2))
            {
                WriteLine(int2);
            }
        }
    }
}
