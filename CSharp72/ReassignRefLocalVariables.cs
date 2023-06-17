using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp72
{
    internal class ReassignRefLocalVariables
    {
        static Post[] posts = new Post[]
        {
            new Post() { Title = "Pilot", Content = "First post" },
            new Post() { Title = "Friday", Content = "This is happened on Friday" },
        };
        static void ReassignRef()
        {
            Post _1st = posts[0];
            _1st.Content = "Here is the first post";
            Console.WriteLine(_1st.Content);

            ref Post aPost = ref posts[0];
            aPost.Content = "This is the first post";
            Console.WriteLine(posts[0].Content);

            aPost = ref posts[1];
            aPost.Content = "This is the second post";
            Console.WriteLine(posts[1].Content);
        }

    }

    public partial struct Post
    {
        public string Title;
        public string Content;
    }
}
