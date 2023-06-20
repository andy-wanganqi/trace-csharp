using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    record class RecordStruct(string FirstName, string LastName)
    {
        public sealed override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    record Police : RecordStruct
    {
        public Police(string firstName, string lastName) : base(firstName, lastName)
        {
        }
        // public override string ToString() // ERROR

    }
}
