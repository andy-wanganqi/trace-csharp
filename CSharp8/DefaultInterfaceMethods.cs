using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    internal class DefaultInterfaceMethods
    {
        public static void Play()
        {
            var a = new BigInt(100);
            var b = new BigInt(200);
            INumber number = a + b; // Result is BigInt(300)
            var c = a + b; // Result is BigInt(300)

            INumber ia = a;
            INumber ib = b;
            var ic = ia + ib; // Result is null

            var unreal1 = new Unreal();
            //unreal1.GetText(); // Error
            (unreal1 as INumber2).GetText();
        }
    }

    public interface INumber
    {
        int Value { get; init; }

        string GetText();

        protected int GetValueAddress();

        const int Zero = 0;
        const int One = Zero + 1;
        // const string ZeroText = $"{Zero}";

        public static INumber operator +(INumber a) => a;
        public static INumber operator +(INumber a, INumber b) => default(INumber); // a.Value + b.Value;

        static int MinusOne;
        static INumber() // interface can have static constructor to initialize static variables
        {
            MinusOne = -1;
        }
        //public INumber(int val) // interface cannot have instance constructor
        //{
        //    Value = val;
        //}
        static void Foo() { }
        static int Property { get; set; }

        class Nested
        {
            Nested() { }
        }
    }

    public class BigInt : INumber
    {
        public int Value { get; init; }
        int INumber.Value { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }

        public BigInt(int val)
        {
            this.Value = val;
        }

        public string GetText()
        {
            return Value.ToString();
        }

        int INumber.GetValueAddress()
        {
            throw new NotImplementedException();
        }

        public static BigInt operator +(BigInt a) => a;
        public static BigInt operator +(BigInt a, BigInt b) => new BigInt(a.Value + b.Value);

    }

    public interface INumber2 : INumber
    {
        string INumber.GetText() { return "INumber.GetText"; } // Explicit implementation
    }

    public class Unreal : INumber2
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Value { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
        int INumber.Value { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }

        int INumber.GetValueAddress()
        {
            throw new NotImplementedException();
        }
    }
}
