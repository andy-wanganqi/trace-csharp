using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportedCSharpLibrary.Very.Deep.Namespace
{
    public class GenericSingleton<T> where T : class
    {
        public static readonly GenericSingleton<T> Instance = new GenericSingleton<T>();

        public void HelloWorld()
        {
            Console.WriteLine("Hello World! -- from GenericSingleton<T>");
        }
    }
}
