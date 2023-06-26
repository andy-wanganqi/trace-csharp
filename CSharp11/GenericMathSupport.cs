using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    internal class GenericMathSupport
    {
        public static void Play()
        {
            int sf = GenericInterface.StaticField;
            var sp = GenericInterface.StaticProperty;
            //var srp = GenericInterface.StaticReadonlyProperty; // ERROR
            //GenericInterface.Foo(); // ERROR
            //GenericInterface.Bar(); // ERROR

            var concrete = new ConcreteClass();
            //var sf2 = ConcreteClass.StaticField; // ERROR
            //var sp2 = ConcreteClass.StaticProperty; // ERROR
            var srp = ConcreteClass.StaticReadonlyProperty;
            ConcreteClass.Foo();
            ConcreteClass.Bar();

            var a = MathEx.MidPoint(1, 2);
            var b = MathEx.MidPoint(1m, 2m);
            var c = MathEx.MidPoint(1f, 2f);
            var z = MathEx.MidPoint(new Int1024(1), new Int1024(2));

            var str = new RepeatSequence();
            str++;
        }
    }
    
    public interface GenericInterface
    {
        static virtual void Foo() { Console.WriteLine("GenericInterface.Foo()");  }
        static abstract void Bar();
        static int StaticField;
        static string? StaticProperty { get; set; }
        static abstract string? StaticReadonlyProperty { get; }
    }

    public class ConcreteClass : GenericInterface
    {
        public static string? StaticReadonlyProperty => throw new NotImplementedException();

        public static void Foo()
        {
            Console.WriteLine("ConcreteClass.Foo()");
        }

        public static void Bar()
        {
            throw new NotImplementedException();
        }
    }

    public static class MathEx
    {
        //public static double MidPoint(double left, double right) => (left + right) / (2.0);
        public static T MidPoint<T>(T left, T right) where T : INumber<T> => (left + right) / T.CreateChecked(2);
    }

    public class Int1024 : INumber<Int1024> 
    {
        int innerValue;
        public Int1024(int value) { innerValue = value; }

        static Int1024 INumberBase<Int1024>.One => throw new NotImplementedException();

        static int INumberBase<Int1024>.Radix => throw new NotImplementedException();

        static Int1024 INumberBase<Int1024>.Zero => throw new NotImplementedException();

        static Int1024 IAdditiveIdentity<Int1024, Int1024>.AdditiveIdentity => throw new NotImplementedException();

        static Int1024 IMultiplicativeIdentity<Int1024, Int1024>.MultiplicativeIdentity => throw new NotImplementedException();

        static Int1024 INumberBase<Int1024>.Abs(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsCanonical(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsComplexNumber(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsEvenInteger(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsFinite(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsImaginaryNumber(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsInfinity(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsInteger(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsNaN(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsNegative(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsNegativeInfinity(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsNormal(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsOddInteger(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsPositive(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsPositiveInfinity(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsRealNumber(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsSubnormal(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.IsZero(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static Int1024 INumberBase<Int1024>.MaxMagnitude(Int1024 x, Int1024 y)
        {
            throw new NotImplementedException();
        }

        static Int1024 INumberBase<Int1024>.MaxMagnitudeNumber(Int1024 x, Int1024 y)
        {
            throw new NotImplementedException();
        }

        static Int1024 INumberBase<Int1024>.MinMagnitude(Int1024 x, Int1024 y)
        {
            throw new NotImplementedException();
        }

        static Int1024 INumberBase<Int1024>.MinMagnitudeNumber(Int1024 x, Int1024 y)
        {
            throw new NotImplementedException();
        }

        static Int1024 INumberBase<Int1024>.Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        static Int1024 INumberBase<Int1024>.Parse(string s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        static Int1024 ISpanParsable<Int1024>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        static Int1024 IParsable<Int1024>.Parse(string s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.TryConvertFromChecked<TOther>(TOther value, out Int1024 result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.TryConvertFromSaturating<TOther>(TOther value, out Int1024 result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.TryConvertFromTruncating<TOther>(TOther value, out Int1024 result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.TryConvertToChecked<TOther>(Int1024 value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.TryConvertToSaturating<TOther>(Int1024 value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.TryConvertToTruncating<TOther>(Int1024 value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, out Int1024 result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Int1024>.TryParse(string? s, NumberStyles style, IFormatProvider? provider, out Int1024 result)
        {
            throw new NotImplementedException();
        }

        static bool ISpanParsable<Int1024>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out Int1024 result)
        {
            throw new NotImplementedException();
        }

        static bool IParsable<Int1024>.TryParse(string? s, IFormatProvider? provider, out Int1024 result)
        {
            throw new NotImplementedException();
        }

        int IComparable.CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        int IComparable<Int1024>.CompareTo(Int1024? other)
        {
            throw new NotImplementedException();
        }

        bool IEquatable<Int1024>.Equals(Int1024? other)
        {
            throw new NotImplementedException();
        }

        string IFormattable.ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        bool ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        static Int1024 IUnaryPlusOperators<Int1024, Int1024>.operator +(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static Int1024 IAdditionOperators<Int1024, Int1024, Int1024>.operator +(Int1024 left, Int1024 right)
        {
            throw new NotImplementedException();
        }

        static Int1024 IUnaryNegationOperators<Int1024, Int1024>.operator -(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static Int1024 ISubtractionOperators<Int1024, Int1024, Int1024>.operator -(Int1024 left, Int1024 right)
        {
            throw new NotImplementedException();
        }

        static Int1024 IIncrementOperators<Int1024>.operator ++(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static Int1024 IDecrementOperators<Int1024>.operator --(Int1024 value)
        {
            throw new NotImplementedException();
        }

        static Int1024 IMultiplyOperators<Int1024, Int1024, Int1024>.operator *(Int1024 left, Int1024 right)
        {
            throw new NotImplementedException();
        }

        static Int1024 IDivisionOperators<Int1024, Int1024, Int1024>.operator /(Int1024 left, Int1024 right)
        {
            throw new NotImplementedException();
        }

        static Int1024 IModulusOperators<Int1024, Int1024, Int1024>.operator %(Int1024 left, Int1024 right)
        {
            throw new NotImplementedException();
        }

        static bool IEqualityOperators<Int1024, Int1024, bool>.operator ==(Int1024? left, Int1024? right)
        {
            throw new NotImplementedException();
        }

        static bool IEqualityOperators<Int1024, Int1024, bool>.operator !=(Int1024? left, Int1024? right)
        {
            throw new NotImplementedException();
        }

        static bool IComparisonOperators<Int1024, Int1024, bool>.operator <(Int1024 left, Int1024 right)
        {
            throw new NotImplementedException();
        }

        static bool IComparisonOperators<Int1024, Int1024, bool>.operator >(Int1024 left, Int1024 right)
        {
            throw new NotImplementedException();
        }

        static bool IComparisonOperators<Int1024, Int1024, bool>.operator <=(Int1024 left, Int1024 right)
        {
            throw new NotImplementedException();
        }

        static bool IComparisonOperators<Int1024, Int1024, bool>.operator >=(Int1024 left, Int1024 right)
        {
            throw new NotImplementedException();
        }
    }

    public interface IGetNext<T> where T : IGetNext<T>
    {
        static abstract T operator ++(T other);
    }

    public struct RepeatSequence : IGetNext<RepeatSequence>
    {
        private const char Ch = 'A';
        public string Text = new string(Ch, 1);

        public RepeatSequence(char ch) { }

        public static RepeatSequence operator ++(RepeatSequence other)
            => other with { Text = other.Text + Ch };

        public override string ToString() => Text;
    }

    public interface IParseable<TSelf>
        where TSelf : IParseable<TSelf>
    {
        static abstract TSelf Parse(string s, IFormatProvider? provider);

        static abstract bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, out TSelf result);

        public static T InvariantParse<T>(string s)
            where T : IParseable<T>
        {
            return T.Parse(s, CultureInfo.InvariantCulture);
        }
    }

    public readonly struct GuidEx : IParseable<GuidEx>
    {
        public static GuidEx Parse(string s, IFormatProvider? provider)
        {
            /* Implementation */
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, out GuidEx result)
        {
            /* Implementation */
            throw new NotImplementedException();
        }

        public static void Foo()
        {
            IParseable<GuidEx>.InvariantParse<GuidEx>("");
        }
    }
}
