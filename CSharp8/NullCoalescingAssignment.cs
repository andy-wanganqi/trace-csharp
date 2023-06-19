using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    internal class NullCoalescingAssignment
    {
        public static void Play()
        {
            string? a = null;
            string? b = "";

            a ??= "a"; // a = "a"
            b ??= "b"; // b = ""
        }
    }
}
