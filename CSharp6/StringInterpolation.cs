namespace CSharp6
{
    public class StringInterpolation
    {
        public static void Play()
        {
            string name = "Mark";
            var date = DateTime.Now;
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
        }
    }
}
