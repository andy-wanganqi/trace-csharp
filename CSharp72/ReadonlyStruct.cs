using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp72
{
    readonly struct Comment
    {
        public string Author { get; }
        public string Content { get; }

        public Comment(string author, string content)
        {
            Author = author;
            Content = content;
        }
    }

    public class ReadonlyStruct
    {
        // "in" modifier is used to specify that the object is passed by reference but not modified by the method
        static void PrintComment(in Comment comment)
        {
            Console.WriteLine($"Author: {comment.Author}, Content: {comment.Content}");
            // comment.Author = ""; // CS8332	Cannot assign to a member of variable 'in Comment' because it is a readonly variable
        }
    }
}
