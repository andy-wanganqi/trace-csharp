namespace CSharp71
{
    internal class Program
    {
        static async Task Main(string[] args) // async Main method
        {
            Func<int, int> nthFactorial = default; // default literal
        }

        private static void InferredTupleElementNames()
        {
            var groups = new List<(Guid key, IList<(string, bool)> items)>();
            (Guid key, IList<(string, bool)> items) group = (Guid.NewGuid(), new List<(string, bool)>
                {
                    ("a", true),
                    ("b", false),
                    ("c", false)
                });
            groups.Add(group);

            var key = group.key;
            var items = group.items;
        }

        private static void InferredTupleElementNames2()
        {
            var groups = new List<(Guid key, IList<(string, bool)> items)>();
            var group = (Guid.NewGuid(), new List<(string, bool)>
                {
                    ("a", true),
                    ("b", false),
                    ("c", false)
                });
            groups.Add(group);

            // Still failed to infer the name
            //var key = group.key; 
            //var items = group.items;
        }
    }
}