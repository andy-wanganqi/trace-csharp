using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    internal class RawStringLiterals
    {
        string longMessage = """
            This is a long message.
            It has several lines.
                Some are indented
                        more than others.
            Some should start at the first column.
            Some have "quoted text" in them.
            """;

        static double Longitude;
        static double Latitude;
        string location = $$"""
           You are at {{{Longitude}}, {{Latitude}}}
           """;
    }
}
