using GenericSingletonStudent = ImportedCSharpLibrary.Very.Deep.Namespace.GenericSingleton<ImportedCSharpLibrary.Student>;
using static System.Console;
using static System.Math;
using static ImportedCSharpLibrary.Singleton;
//using static ImportedCSharpLibrary.Very.Deep.Namespace.GenericSingleton<ImportedCSharpLibrary.Student>;

namespace CSharp6
{
    public class StaticImports
    {
        public static void Play()
        {
            GenericSingletonStudent.Instance.HelloWorld();
            WriteLine("Hello, World!");
            Instance.HelloWorld();
            WriteLine(PI);
            //var student2 = GenericSingleton<Student>.Instance;
        }
    }
}
