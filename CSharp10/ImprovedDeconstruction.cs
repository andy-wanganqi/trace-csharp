using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    internal class ImprovedDeconstruction
    {
        public static void Play()
        {
            var point = new Point(0, 0);

            int x = 0;
            (x, int y) = point;
        }
    }

    record Point(int x, int y);
}
