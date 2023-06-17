namespace CSharp6
{
    public class IndexInitializers
    {
        public static void Play()
        {
            var list = new List<int>() { 1, 2, 3, 4 };
            var dict = new Dictionary<int, string>()
            {
                [1] = "1",
                [2] = "2",
            };
        }
    }
}
