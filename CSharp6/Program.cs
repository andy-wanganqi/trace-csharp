using static System.Console;

namespace CSharp6
{
    internal class Program
    {
        public static void Main()
        {
            var teacher = new Teacher("Andy", "W")
            {
                DOB = DateTime.Today,
            };
            teacher.PropertyChanged += Teacher_PropertyChanged;

            teacher.Gender = "M";
            teacher.AddJuniorToFirstName();
        }

        private static void Teacher_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            WriteLine(sender?.ToString());
            WriteLine(e.PropertyName);
        }
    }
}