using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportedCSharpLibrary
{
    public class Person
    {
        public string FirstName { get; protected set; } = String.Empty;
        public string LastName { get; protected set; } = String.Empty;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
