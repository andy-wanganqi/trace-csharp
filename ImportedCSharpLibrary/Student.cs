using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportedCSharpLibrary
{
    public class Student : Person
    {
        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }
    }
}
