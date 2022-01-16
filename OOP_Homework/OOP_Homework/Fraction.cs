using System;

namespace OOP_Homework
{
    /*
     Создать класс рациональных чисел. В классе два поля – числитель и знаменатель. 
     Предусмотреть конструктор. Определить операторы ==, != (метод Equals()), <, >, <=, >=, +, – , ++, --. 
     Переопределить метод ToString() для вывода дроби. 
     Определить операторы преобразования типов между типом дробь, float, int. Определить операторы *, /, %. 
     */
    internal sealed class Fraction
    {
        private readonly int _immutableNumerator;
        private readonly int _immutableDenominator;
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        
        public double DecimalFraction => (double)Numerator / (double)Denominator;
        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this._immutableNumerator = numerator;
            if (denominator == 0)
            {
                throw new ArgumentException("The denominator cannot be equal to 0");
            }
            else
            {
                this.Denominator = denominator;
            }
            if (this.Numerator != 0)
                FractionSimplification(this.Numerator, this.Denominator);

            _immutableNumerator = this.Numerator;
            _immutableDenominator = this.Denominator;
        }

        public Fraction() : this(0, 1)
        { }

        #region Methods
        public Fraction Addition(Fraction toAdd) =>
            new(this.Numerator * toAdd.Denominator + this.Denominator * toAdd.Numerator,
                this.Denominator * toAdd.Denominator);
        public Fraction Subtraction(Fraction toSubtract) =>
            this.Addition(toSubtract.MultiplyFractionByNumber(-1));
        public Fraction Multiplication(Fraction toMultiplyWith) =>
            new(this.Numerator * toMultiplyWith.Numerator,
                this.Denominator * toMultiplyWith.Denominator);
        public Fraction Division(Fraction divideBy) =>
            new(this.Numerator * divideBy.Denominator,
                this.Denominator * divideBy.Numerator);
        public Fraction MultiplyFractionByNumber(int number) => new(this.Numerator * number, this.Denominator);
        
        public Fraction DivideFractionByNumber(int number) => number>0
            ? new Fraction(this.Numerator, this.Denominator * number)
            : new Fraction(this.Numerator * (-1), this.Denominator * -number);
        public Fraction AddNumberToFraction(int number) =>
            new(this.Numerator + this.Denominator * number, this.Denominator);
        
        public Fraction SubtractNumberFromFraction(int number) =>
            AddNumberToFraction(-number);
        
        #endregion 
        
        private void FractionSimplification(int numerator, int denominator)
        {
            numerator = numerator > 0 ? numerator : -numerator;
            denominator = denominator > 0 ? denominator : -denominator;
            int gcf = GreatestCommonFactor(numerator, denominator);
            if (gcf != 1)
            {
                this.Numerator /= gcf;
                this.Denominator /= gcf;
            }
        }
        private int GreatestCommonFactor(int first, int second) =>
            first != second ? first > second ?
            GreatestCommonFactor(first - second, second) :
            GreatestCommonFactor(first, second - first) : first;

        private static void NullCheck(Fraction first, Fraction second)
        {
            if (first is null || second is null)
                throw new ArgumentException("Invalid fraction data");
        }
        
        private static void NullCheck(Fraction fraction)
        {
            if (fraction is null)
                throw new ArgumentException("Invalid fraction data");
        }
        

        #region Operators

        public static bool operator ==(Fraction first, Fraction second)
        {
            if (first is null || second is null)
                return false;
            return first.Numerator == second.Numerator && first.Denominator == second.Denominator;
        }

        public static bool operator !=(Fraction first, Fraction second)
        {
            if (first is null || second is null)
                return true;
            return first.Numerator != second.Numerator || first.Denominator != second.Denominator;
        }

        public override bool Equals(object? obj) => Equals(obj as Fraction);

        public bool Equals(Fraction other)
        {
            return other != null &&
                   this.Numerator == other.Numerator &&
                   this.Denominator == other.Denominator;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_immutableNumerator, _immutableDenominator);
        }
        
        public static bool operator >(Fraction first, Fraction second)
        {
            if (first is null || second is null)
                return false;
            return first.DecimalFraction > second.DecimalFraction;
        }
        
        public static bool operator <(Fraction first, Fraction second)
        {
            if (first is null || second is null)
                return false;
            return first.DecimalFraction < second.DecimalFraction;;
        }
        
        public static bool operator >=(Fraction first, Fraction second)
        {
            if (first is null || second is null)
                return false;
            return first.DecimalFraction >= second.DecimalFraction;
        }
        
        public static bool operator <=(Fraction first, Fraction second)
        {
            if (first is null || second is null)
                return false;
            return first.DecimalFraction <= second.DecimalFraction;;
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            NullCheck(first, second);
            return first.Addition(second);
        }

        public static Fraction operator -(Fraction first, Fraction second)
        {
            NullCheck(first, second);
            return first.Subtraction(second);
        }
        
        public static Fraction operator ++(Fraction fraction)
        {
            NullCheck(fraction);
            return new(fraction.Numerator + 1, fraction.Denominator);
        }

        public static Fraction operator --(Fraction fraction)
        {
            NullCheck(fraction);
            return new(fraction.Numerator - 1, fraction.Denominator);
        }

        public static implicit operator float(Fraction fraction)
        {
            NullCheck(fraction);
            return (float)fraction.Numerator / fraction.Denominator;
        }
        
        public static explicit operator int(Fraction fraction)
        {
            NullCheck(fraction);
            return fraction.Numerator / fraction.Denominator;
        }
        
        public static Fraction operator *(Fraction first, Fraction second)
        {
            NullCheck(first, second);
            return first.Multiplication(second);
        }
        
        public static Fraction operator /(Fraction first, Fraction second)
        {
            NullCheck(first, second);
            return first.Division(second);
        }

        public static Fraction operator %(Fraction first, Fraction second)
        {
            NullCheck(first, second);
            return new(first.Numerator * second.Denominator % first.Denominator * second.Numerator,
                first.Denominator * second.Denominator);
        }

        public override string ToString() =>
            Math.Abs(Numerator) < Math.Abs(Denominator) && Numerator != 0 
                ? $"[ {Numerator} / {Denominator} ]" 
                : Math.Abs(Numerator) > Math.Abs(Denominator) && Numerator % Denominator != 0 
                    ? $"[ {Numerator / Denominator} and {Math.Abs(Numerator % Denominator)} / {Denominator} ]" 
                    : $"[ {Numerator / Denominator} ]";
        
        #endregion
    }
}