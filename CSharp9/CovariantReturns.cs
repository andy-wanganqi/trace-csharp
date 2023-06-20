using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    public class ClassA
    {
        public virtual ClassA Foo(ClassA input) { return input; }
    }

    public class ClassB : ClassA
    {
        public override ClassB Foo(ClassA input)
        {
            return new();
        }
    }
}
