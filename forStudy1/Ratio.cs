namespace forStudy1
{
    internal class Ratio
    {
        public int Numerator
        {
            get => numerator; set => numerator = value;
        }
        public int Denominator
        {
            get => denominator;
            set
            {
                if (value < 0)
                {
                    numerator = -numerator;
                    denominator = Math.Abs(value);
                }
                else if (value == 0)
                    throw new DivideByZeroException("Denominator can`t be 0!");
                else
                    denominator = value;
                
            }
        }

        private int numerator;
        private int denominator;

        public Ratio()
        {
            Numerator = 0;
            Denominator = 1;
        }

        public Ratio(int _numerator, int _denominator = 1)
        {
            Numerator = _numerator;
            Denominator = _denominator;

            Simplify();
        }

        public override string ToString()
        {
            if (Denominator != 1) return $"{Numerator}/{Denominator}";
            else return $"{Numerator}";
        }

        public void Simplify()
        {
            int NOD = SimpleMath.Evklid(numerator, denominator);
            Numerator /= NOD;
            Denominator /= NOD;
        }

        public double ToDouble()
        {
            return (double)Numerator / Denominator;
        }

        #region Operators

        public static Ratio operator +(Ratio left, Ratio right)
        {
            return new Ratio(left.Numerator * right.Denominator + right.Numerator * left.Denominator, left.Denominator * right.Denominator);
        }

        public static Ratio operator +(Ratio left, int right)
        {
            return left + new Ratio(right, 1);
        }

        public static Ratio operator +(int left, Ratio right)
        {
            return right + left;
        }

        public static Ratio operator -(Ratio ratio)
        {
            return new Ratio(-ratio.Numerator, ratio.Denominator);
        }

        public static Ratio operator -(Ratio left, Ratio right)
        {
            return left + (-right);
        }

        public static Ratio operator -(Ratio left, int right)
        {
            return left + (-right);
        }

        public static Ratio operator -(int left, Ratio right)
        {
            return left + (-right);
        }

        public static Ratio operator *(Ratio left, Ratio right)
        {
            return new Ratio(left.Numerator * right.Numerator, left.Denominator * right.Denominator);
        }

        public static Ratio operator *(Ratio left, int right)
        {
            return new Ratio(left.Numerator * right, left.Denominator);
        }

        public static Ratio operator *(int left, Ratio right)
        {
            return right * left;
        }

        public static Ratio operator /(Ratio left, Ratio right)
        {
            Ratio r = new Ratio(right.Denominator, right.Numerator);
            return left * r;
        }

        public static Ratio operator /(Ratio left, int right)
        {
            return new Ratio(left.Numerator, left.Denominator * right);
        }

        public static Ratio operator /(int left, Ratio right)
        {
            return new Ratio(left * right.Denominator, right.Numerator);
        }

        public static Ratio operator ++(Ratio ratio)
        {
            return ratio + 1;
        }

        public static Ratio operator --(Ratio ratio)
        {
            return ratio - 1;
        }

        public static bool operator ==(Ratio left, Ratio right)
        {
            return left.Numerator == right.Numerator && left.Denominator == right.Denominator;
        }

        public static bool operator ==(Ratio left, int right)
        {
            return left.ToDouble() == right;
        }

        public static bool operator ==(int left, Ratio right)
        {
            return left == right.ToDouble();
        }

        public static bool operator !=(Ratio left, Ratio right)
        {
            return !(left.Numerator == right.Numerator && left.Denominator == right.Denominator);
        }

        public static bool operator !=(Ratio left, int right)
        {
            return left.ToDouble() != right;
        }

        public static bool operator !=(int left, Ratio right)
        {
            return left != right.ToDouble();
        }

        public static bool operator >(Ratio left, Ratio right)
        {
            return left.ToDouble() > right.ToDouble();
        }

        public static bool operator <(Ratio left, Ratio right)
        {
            return left.ToDouble() < right.ToDouble();
        }

        public static bool operator >(Ratio left, int right)
        {
            return left.ToDouble() > right;
        }

        public static bool operator <(Ratio left, int right)
        {
            return left.ToDouble() < right;
        }

        public static bool operator >(int left, Ratio right)
        {
            return left > right.ToDouble();
        }

        public static bool operator <(int left, Ratio right)
        {
            return left < right.ToDouble();
        }

        public static bool operator >=(Ratio left, Ratio right)
        {
            return left.ToDouble() >= right.ToDouble();
        }

        public static bool operator <=(Ratio left, Ratio right)
        {
            return left.ToDouble() <= right.ToDouble();
        }

        public static bool operator >= (Ratio left, int right)
        {
            return left.ToDouble() >= right;
        }

        public static bool operator <= (Ratio left, int right)
        {
            return left.ToDouble() <= right;
        }

        public static bool operator >=(int left, Ratio right)
        {
            return left >= right.ToDouble();
        }

        public static bool operator <=(int left, Ratio right)
        {
            return left <= right.ToDouble();
        }

        #endregion
    }
}
