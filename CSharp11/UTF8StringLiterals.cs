using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    internal class UTF8StringLiterals
    {
        public UTF8StringLiterals()
        {
            ReadOnlySpan<byte> AuthWithTrailingSpace = new byte[] { 0x41, 0x55, 0x54, 0x48, 0x20 };
            ReadOnlySpan<byte> AuthStringLiteral = "AUTH "u8; // <== u8: UTF-8 string literals 

            byte[] AuthStringLiteral2 = "AUTH "u8.ToArray(); // <== u8: UTF-8 string literals 
        }
    }
}
