using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    file interface IWidget // only visible inside this file
    {
        int ProvideAnswer();
    }

    file class HiddenWidget
    {
        public int Work() => 42;
    }

    public class Widget : IWidget
    {
        public int ProvideAnswer()
        {
            var worker = new HiddenWidget();
            return worker.Work();
        }
    }
}
