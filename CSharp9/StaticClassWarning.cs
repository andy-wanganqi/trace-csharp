using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    internal class StaticClassWarning
    {
        static class StaticClass
        {
            public static void Thing() { }
        }

        void M(object o)
        {
            // warning: cannot use a static type in 'is' or 'as'
            if (o is StaticClass)
            {
                Console.WriteLine("Can't happen");
            }
            else
            {
                Console.WriteLine("o is not an instance of a static class");
            }
        }
    }
}
