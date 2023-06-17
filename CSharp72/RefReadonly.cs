using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp72
{
    internal class RefReadonly
    {
        static void Example()
        {
            ref readonly var origin = ref Post.Origin; // It is a ref of origin
            var originValue = Post.Origin; // It is a copy of origin
            // origin = posts[1]; // Error

            Post.ChangeOrigin("A Title", "The Content");
            Console.WriteLine("Origin is: ({0}, {1})", origin.Title, origin.Content); // Origin is: (A Title, The Content)
            Console.WriteLine("Origin is: ({0}, {1})", originValue.Title, originValue.Content); // Origin is: (Empty, Empty)
        }
    }

    public partial struct Post
    {
        public static Post origin = new Post() { Title = "Empty", Content = "Empty" };
        public static ref readonly Post Origin => ref origin;
        public static void ChangeOrigin(string title, string content)
        {
            origin = new Post() { Title = title, Content = content };
        }
    }
}
