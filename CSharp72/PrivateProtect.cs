using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp72
{
    public class BaseClass
    {
        private protected int myValue = 0;
    }

    public class DerivedClass1 : BaseClass
    {
        void Access()
        {
            var baseObject = new BaseClass();

            // Error CS1540, because myValue can only be accessed by
            // classes derived from BaseClass.
            // baseObject.myValue = 5;

            // OK, accessed through the current derived class instance (only in the same assembly)
            myValue = 5;
        }
    }
}
