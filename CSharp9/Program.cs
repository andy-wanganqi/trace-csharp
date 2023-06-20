//Top-level statements
using System.Text;

Console.Write("Hello ");
await Task.Delay(5000); // await
Console.WriteLine("World!");

if (args.Length > 0) // args
{
    foreach (var arg in args)
    {
        Console.WriteLine($"Argument={arg}");
    }
}
else
{
    Console.WriteLine("No arguments");
}

MyClass.TestMethod();
MyNamespace.MyClass.MyMethod();
Console.WriteLine("Hello World!");

return 0; // exit code

// Namespaces and type definitions, must be on the bottom
public class MyClass
{
    public static void TestMethod()
    {
        Console.WriteLine("Hello World!");
    }

}

namespace MyNamespace
{
    class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("Hello World from MyNamespace.MyClass.MyMethod!");
        }
    }
}
