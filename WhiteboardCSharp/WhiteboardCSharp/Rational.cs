using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public struct Rational
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return numerator; }
            private set { numerator = value; }
        }
        public int Denominator
        {
            get{ return denominator == 0 ? 1 : denominator == -1 ? 0 : denominator; }
            private set { denominator = value; }
        }
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            if (denominator == 0)
            {
                throw new ArgumentException("We can not divide by zero");
            }
            if (numerator < 0 && denominator<0)
            {
                numerator *= -1;
                denominator *= -1;
                Numerator = numerator;
                Denominator = denominator;
            }
            if (denominator == -1)
            {
                numerator *= -1;
                denominator *= -1;
                Numerator = numerator;
                Denominator = denominator;
            }
            int variable = GetGCF(numerator, denominator);
            if (variable > 1)
            {
                numerator /= variable;
                Numerator = numerator;
                denominator /= variable;
                Denominator = denominator; 
            }
        }
        public override string ToString()
        {
            if (numerator < 0 && denominator < 0)
            {
                return string.Format("{0}/{1}", numerator*-1, denominator*-1);
            }
            else if (denominator != 1)
            {
                return string.Format("{0}/{1}", numerator, denominator);
            }
            else
            {
                return "" + numerator;
            }
        }
        public int GetGCF(int num, int denom)
        {
            if (denom == 1)
            {
                return 1;
            }
            if (num < denom)
            {
                return GetGCF(denom, num);
            }
            if (denom == 0)
            {
                return num;
            }
            else
            {
                return GetGCF(denom, num % denom);
            }
        }
    }
}
