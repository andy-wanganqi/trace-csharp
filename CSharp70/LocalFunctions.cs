using System.Diagnostics.CodeAnalysis;
using static System.Console;

namespace CSharp70
{
    public class LocalFunctions
    {
        public static int Play()
        {
            var y = VariableCapture(100);
            int VariableCapture(int x)
            {
                return x + 1;
            }
            return y;
        }

        private static string GetText(string path, string filename)
        {
            var reader = File.OpenText($"{AppendPathSeparator(path)}{filename}");
            var text = reader.ReadToEnd();
            return text;

            string AppendPathSeparator(string filepath)
            {
                return filepath.EndsWith(@"\") ? filepath : filepath + @"\";
            }
        }

        private static void Process(string?[] lines, string mark)
        {
            foreach (var line in lines)
            {
                if (IsValid(line))
                {
                    // Processing logic...
                }
            }

            bool IsValid([NotNullWhen(true)] string? line)
            {
                return !string.IsNullOrEmpty(line) && line.Length >= mark.Length;
            }
        }

        public static int VariableCapture(int x)
        {
            int y = int.MaxValue;
            LocalFunction();
            return y;

            void LocalFunction() => y = x;
        }

        public static IEnumerable<string> SequenceToLowercase(IEnumerable<string> input)
        {
            if (!input.Any())
            {
                throw new ArgumentException("There are no items to convert to lowercase.");
            }

            return LowercaseIterator();

            IEnumerable<string> LowercaseIterator()
            {
                foreach (var output in input.Select(item => item.ToLower()))
                {
                    yield return output; // using yield return to generate a sequence of values
                }
            }
        }
    }

    public class IteratorWithoutLocalExample
    {
        public static void Output()
        {
            IEnumerable<int> xs = OddSequence(50, 110);
            WriteLine("Retrieved enumerator...");
            foreach (var x in xs)
            {
                Write($"{x} ");
            }
            //    Retrieved enumerator...
            //    Unhandled exception. System.ArgumentOutOfRangeException: end must be less than or equal to 100. (Parameter 'end')
            //    at IteratorWithoutLocalExample.OddSequence(Int32 start, Int32 end)+MoveNext() in IteratorWithoutLocal.cs:line 22
            //    at IteratorWithoutLocalExample.Main() in IteratorWithoutLocal.cs:line 11
        }

        public static IEnumerable<int> OddSequence(int start, int end)
        {
            if (start < 0 || start > 99)
                throw new ArgumentOutOfRangeException(nameof(start), "start must be between 0 and 99.");
            if (end > 100)
                throw new ArgumentOutOfRangeException(nameof(end), "end must be less than or equal to 100.");
            if (start >= end)
                throw new ArgumentException("start must be less than end.");

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 1)
                    yield return i;
            }
        }

        public static void Output2()
        {
            IEnumerable<int> xs = OddSequence2(50, 110);
            WriteLine("Retrieved enumerator...");
            foreach (var x in xs)
            {
                Write($"{x} ");
            }
            //    Unhandled exception. System.ArgumentOutOfRangeException: end must be less than or equal to 100. (Parameter 'end')
            //    at IteratorWithLocalExample.OddSequence(Int32 start, Int32 end) in IteratorWithLocal.cs:line 22
            //    at IteratorWithLocalExample.Main() in IteratorWithLocal.cs:line 8
        }
        public static IEnumerable<int> OddSequence2(int start, int end)
        {
            if (start < 0 || start > 99)
                throw new ArgumentOutOfRangeException(nameof(start), "start must be between 0 and 99.");
            if (end > 100)
                throw new ArgumentOutOfRangeException(nameof(end), "end must be less than or equal to 100.");
            if (start >= end)
                throw new ArgumentException("start must be less than end.");

            return GetOddSequenceEnumerator();

            IEnumerable<int> GetOddSequenceEnumerator()
            {
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 1)
                        yield return i;
                }
            }
        }
    }

    public class LocalFunctionVSLambda
    {
        public static int LocalFunctionFactorial(int n)
        {
            return nthFactorial(n);

            int nthFactorial(int number) => number < 2
                ? 1
                : number * nthFactorial(number - 1);
        }

        public static int LocalFunctionFactorial2(int n)
        {
            return n < 2
                ? 1
                : n * LocalFunctionFactorial2(n - 1);
        }

        public static int LambdaFactorial(int n)
        {
            Func<int, int> nthFactorial = default(Func<int, int>);

            nthFactorial = number => number < 2
                ? 1
                : number * nthFactorial(number - 1);

            return nthFactorial(n);
        }

        // Local functions will have less heap allocation
        async Task<int> FirstWork(string address) => 0;
        async Task<int> SecondStep(int index, string name) => 0;
        public async Task<string> PerformLongRunningWorkLambda(string address, int index, string name)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException(message: "An address is required", paramName: nameof(address));
            if (index < 0)
                throw new ArgumentOutOfRangeException(paramName: nameof(index), message: "The index must be non-negative");
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(message: "You must supply a name", paramName: nameof(name));

            Func<Task<string>> longRunningWorkImplementation = async () =>
            {
                var interimResult = await FirstWork(address);
                var secondResult = await SecondStep(index, name);
                return $"The results are {interimResult} and {secondResult}. Enjoy.";
            };

            return await longRunningWorkImplementation();
        }

        public async Task<string> PerformLongRunningWork(string address, int index, string name)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException(message: "An address is required", paramName: nameof(address));
            if (index < 0)
                throw new ArgumentOutOfRangeException(paramName: nameof(index), message: "The index must be non-negative");
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(message: "You must supply a name", paramName: nameof(name));

            return await longRunningWorkImplementation();

            async Task<string> longRunningWorkImplementation()
            {
                var interimResult = await FirstWork(address);
                var secondResult = await SecondStep(index, name);
                return $"The results are {interimResult} and {secondResult}. Enjoy.";
            }
        }
    }
}
