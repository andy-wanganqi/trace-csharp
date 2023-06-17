namespace CSharp6
{
    public class NameofOperator
    {
        public static void Play()
        {
            var teacher = new Teacher("Andy");
            var nameOfLastName = nameof(teacher.LastName); // nameOfLastName = "LastName"
            var nameOfAddJuniorToFirstName = nameof(teacher.AddJuniorToFirstName); // nameOfAddJuniorToFirstName = "AddJuniorToFirstName"
        }
    }
}
