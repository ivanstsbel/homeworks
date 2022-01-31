using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class RationalNumber
    {
        private int numerator;              // Числитель
        private int denominator;            // Знаменатель

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("В знаменателе не может быть нуля");
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public RationalNumber(int number)
            : this(number, 1)
        { }

        public static bool operator ==(RationalNumber a, RationalNumber b)
        {

            Object aAsObj = a as Object;
            Object bAsObj = b as Object;
            if (aAsObj == null || bAsObj == null)
            {
                return aAsObj == bAsObj;
            }
            return a.Equals(b);
        }

        public static bool operator ==(RationalNumber a, int b)
        {
            return a == new RationalNumber(b);
        }


        public static bool operator ==(int a, RationalNumber b)
        {
            return new RationalNumber(a) == b;
        }


        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !(a == b);
        }


        public static bool operator !=(RationalNumber a, int b)
        {
            return a != new RationalNumber(b);
        }


        public static bool operator !=(int a, RationalNumber b)
        {
            return new RationalNumber(a) != b;
        }


        public override bool Equals(object obj)
        {
            if (!(obj is RationalNumber))
            {
                return false;
            }

            var number = (RationalNumber)obj;
            return numerator == number.numerator &&
                   denominator == number.denominator;
        }

        private static int getGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }


        public RationalNumber Reduce()
        {
            RationalNumber result = this;
            int greatestCommonDivisor = getGreatestCommonDivisor(numerator, denominator);
            result.numerator /= greatestCommonDivisor;
            result.denominator /= greatestCommonDivisor;
            return result;
        }

        private int CompareTo(RationalNumber that)
        {
            if (Equals(that))
            {
                return 0;
            }
            RationalNumber a = this.Reduce();
            RationalNumber b = that.Reduce();
            if (a.numerator * b.denominator > b.numerator * a.denominator)
            {
                return 1;
            }
            return -1;
        }


        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return a.CompareTo(b) > 0;
        }

        public static bool operator >(RationalNumber a, int b)
        {
            return a > new RationalNumber(b);
        }

        public static bool operator >(int a, RationalNumber b)
        {
            return new RationalNumber(a) > b;
        }

        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return a.CompareTo(b) < 0;
        }

        public static bool operator <(RationalNumber a, int b)
        {
            return a < new RationalNumber(b);
        }

        public static bool operator <(int a, RationalNumber b)
        {
            return new RationalNumber(a) < b;
        }

        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return a.CompareTo(b) >= 0;
        }

        public static bool operator >=(RationalNumber a, int b)
        {
            return a >= new RationalNumber(b);
        }

        public static bool operator >=(int a, RationalNumber b)
        {
            return new RationalNumber(a) >= b;
        }

        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return a.CompareTo(b) <= 0;
        }

        public static bool operator <=(RationalNumber a, int b)
        {
            return a <= new RationalNumber(b);
        }

        public static bool operator <=(int a, RationalNumber b)
        {
            return new RationalNumber(a) <= b;
        }


        private static int getLeastCommonMultiple(int a, int b)
        {
            return a * b / getGreatestCommonDivisor(a, b);
        }


        private static RationalNumber performOperation(RationalNumber a, RationalNumber b, Func<int, int, int> operation)
        {

            int leastCommonMultiple = getLeastCommonMultiple(a.denominator, b.denominator);

            int additionalMultiplierFirst = leastCommonMultiple / a.denominator;

            int additionalMultiplierSecond = leastCommonMultiple / b.denominator;

            int operationResult = operation(a.numerator * additionalMultiplierFirst,
            b.numerator * additionalMultiplierSecond);
            return new RationalNumber(operationResult, a.denominator * additionalMultiplierFirst);
        }


        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            return performOperation(a, b, (int x, int y) => x + y);
        }

        public static RationalNumber operator +(RationalNumber a, int b)
        {
            return a + new RationalNumber(b);
        }

        public static RationalNumber operator +(int a, RationalNumber b)
        {
            return b + a;
        }


        public static RationalNumber operator ++(RationalNumber a)
        {
            return a + 1;
        }

        public override string ToString()
        {
            if (numerator == 0)
            {
                return "0";
            }

            if (numerator == denominator)
            {
                return "1";
            }
            if (denominator == 1)
            {
                return numerator.ToString();
            }
            return numerator + "/" + denominator;
        }
    }
}
