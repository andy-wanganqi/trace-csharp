namespace ImportedCSharpLibrary
{
    public class Singleton
    {
        public static readonly Singleton Instance = new Singleton();

        public void HelloWorld()
        {
            Console.WriteLine("Hello World! -- from Singleton");
        }
    }
}