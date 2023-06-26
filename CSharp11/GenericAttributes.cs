using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    internal class GenericAttributes
    {
        //[GenericAttribute<T>()] // Not allowed! generic attributes must be fully constructed types.
        //[GenericAttribute<dynamic>()] // Error
        //[GenericAttribute<string?>()] // Error
        //[GenericAttribute<(int X, int Y)>()] // Error
        public string Method() => default;

        [GenericAttribute<object>()]
        public string Method2() => default;

        [GenericAttribute<ValueTuple<int, int>>()]
        public string Method3() => default;



        [GenericAttribute<string>()]
        public string MethodZ() => default;
    }

    public class GenericAttribute<T> : Attribute { }
}
