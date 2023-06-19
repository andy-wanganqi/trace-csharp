using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    internal class AsynchronousStreams
    {
        static async IAsyncEnumerable<int> GenerateSequenceAsync()
        {
            for (var i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }

        public static async Task Play()
        {
            await foreach (var item in GenerateSequenceAsync())
            {
                Console.WriteLine(item);
            }
        }
    }
}
