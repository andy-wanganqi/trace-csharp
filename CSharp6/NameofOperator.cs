using static System.Console;

namespace CSharp6
{
    public class NameofOperator
    {
        public static void Play()
        {
            var teacher = new Teacher("Andy", "W");
            var nameOfLastName = nameof(teacher.LastName); 
            WriteLine($"nameOfLastName = {nameOfLastName}"); // nameOfLastName = "LastName"

            var nameOfAddJuniorToFirstName = nameof(teacher.AddJuniorToFirstName); 
            WriteLine($"nameOfAddJuniorToFirstName = {nameOfAddJuniorToFirstName}"); // nameOfAddJuniorToFirstName = "AddJuniorToFirstName"
        }
    }
}
