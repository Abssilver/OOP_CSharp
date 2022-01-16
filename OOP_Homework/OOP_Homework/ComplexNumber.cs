
using System;

namespace OOP_Homework
{
    /*
    (*) На перегрузку операторов. Описать класс комплексных чисел. 
        Реализовать операцию сложения, умножения, вычитания, проверку на равенство двух комплексных чисел. 
        Переопределить метод ToString() для комплексного числа. Протестировать на простом примере.
    */
    internal sealed class ComplexNumber
    {
        private const double Tolerance = .00001;
        public double Real { get; }
        public double Imaginary { get; }

        public ComplexNumber(): this(default, default)
        { }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public ComplexNumber Addition(ComplexNumber toAdd) =>
            new(this.Real + toAdd.Real, this.Imaginary + toAdd.Imaginary);

        public ComplexNumber Subtraction(ComplexNumber toSubtract) =>
            new(this.Real - toSubtract.Real, this.Imaginary - toSubtract.Imaginary);

        public ComplexNumber Multiplication(ComplexNumber toMultiplyWith) =>
            new(this.Real * toMultiplyWith.Real - this.Imaginary * toMultiplyWith.Imaginary,
                this.Imaginary * toMultiplyWith.Real + this.Real * toMultiplyWith.Imaginary);

        public static ComplexNumber operator +(ComplexNumber first, ComplexNumber second)
            => first.Addition(second);

        public static ComplexNumber operator -(ComplexNumber first, ComplexNumber second)
            => first.Subtraction(second);

        public static ComplexNumber operator *(ComplexNumber first, ComplexNumber second)
            => first.Multiplication(second);
        
        public static bool operator ==(ComplexNumber first, ComplexNumber second)
        {
            if (first is null || second is null)
                return false;
            
            var differenceReal = Math.Abs(first.Real * Tolerance);
            var differenceImaginary = Math.Abs(first.Imaginary * Tolerance);

            return Math.Abs(first.Real - second.Real) <= differenceReal &&
                   Math.Abs(first.Imaginary - second.Imaginary) <= differenceImaginary;
        }

        public static bool operator !=(ComplexNumber first, ComplexNumber second)
        {
            if (first is null || second is null)
                return true;
            
            var differenceReal = Math.Abs(first.Real * Tolerance);
            var differenceImaginary = Math.Abs(first.Imaginary * Tolerance);

            return Math.Abs(first.Real - second.Real) > differenceReal ||
                   Math.Abs(first.Imaginary - second.Imaginary) > differenceImaginary;
        }

        public override bool Equals(object? obj) => Equals(obj as ComplexNumber);

        public bool Equals(ComplexNumber other)
        {
            var differenceReal = Math.Abs(this.Real * Tolerance);
            var differenceImaginary = Math.Abs(this.Imaginary * Tolerance);
            
            return other != null &&
                   Math.Abs(this.Real - other.Real) <= differenceReal &&
                   Math.Abs(this.Imaginary - other.Imaginary) <= differenceImaginary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Real, Imaginary);
        }

        public override string ToString() =>
            $"{Real}{(Imaginary > 0 ? $" + {Imaginary}i" : Imaginary < 0 ? $" - {Imaginary}i" : "")}";
    }
}