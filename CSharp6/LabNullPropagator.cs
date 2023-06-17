namespace CSharp6
{
    public class LabNullPropagator
    {
        public static void Play()
        {
            string? value = null;
            var result1 = value?.Length; // result1 = null
            Console.WriteLine(result1);

            List<int>? array = null;
            var result2 = array?[0]; // result2 = null
            Console.WriteLine(result1);
        }
    }
}
