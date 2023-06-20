using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    internal class RecordTypes
    {
        public static void Play()
        {
            Person person1 = new("Nancy", "Davolio");
            Person person2 = new("Nancy", "Davolio");
            var equals = person1 == person2; // true
            var refEquals = ReferenceEquals(person1, person2); // false

            Person person3 = person1 with { FirstName = "John" };
            Person person4 = person2 with { };

            Person teacher = new Teacher("Nancy", "Davolio", 3);
            Person student = new Student("Nancy", "Davolio", 3);
            var equals2 = teacher == student; // false
        }
    }

    public record Person(string FirstName, string LastName);

    public record Teacher(string FirstName, string LastName, int Grade)
        : Person(FirstName, LastName);

    public record Student(string FirstName, string LastName, int Grade)
        : Person(FirstName, LastName);

    public record Police
    {
        public required string FirstName { get; init; }
        public required string LastName { get; init; }
    };
}
