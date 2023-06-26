using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    public class Person
    {
        public Person() { }

        [SetsRequiredMembers]
        public Person(string firstName) => FirstName = firstName;

        public required string FirstName { get; init; }

        public void Foo()
        {
            var person = new Person("John");
            person = new Person { FirstName = "John" };
            // Error CS9035: Required member `Person.FirstName` must be set:
            //person = new Person();
        }
    }

}
