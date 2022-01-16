using System;

namespace OOP_Homework
{
    /*
    Создать класс рациональных чисел. В классе два поля – числитель и знаменатель. 
    Предусмотреть конструктор. Определить операторы ==, != (метод Equals()), <, >, <=, >=, +, – , ++, --. 
    Переопределить метод ToString() для вывода дроби. 
    Определить операторы преобразования типов между типом дробь, float, int. Определить операторы *, /, %. 
    
    (*) На перегрузку операторов. Описать класс комплексных чисел. 
    Реализовать операцию сложения, умножения, вычитания, проверку на равенство двух комплексных чисел. 
    Переопределить метод ToString() для комплексного числа. Протестировать на простом примере.
    */
    class Program
    {
        static void Main(string[] args)
        {
            FractionsExample();
            ComplexNumberExample();
        }

        private static void FractionsExample()
        {
            Console.WriteLine("Fractions");
            var fractionOne = new Fraction(50, 20);
            var fractionTwo = new Fraction(7, 8);

            Console.WriteLine($"The first fraction is: {fractionOne}");
            Console.WriteLine($"The second fraction is: {fractionTwo}");
            Console.WriteLine($"The first == second operator result: {fractionOne == fractionTwo}");
            Console.WriteLine($"The first != second operator result: {fractionOne != fractionTwo}");
            Console.WriteLine($"The first equals second result: {fractionOne.Equals(fractionTwo)}");
            Console.WriteLine($"The first < second operator result: {fractionOne < fractionTwo}");
            Console.WriteLine($"The first > second operator result: {fractionOne > fractionTwo}");
            Console.WriteLine($"The first <= second operator result: {fractionOne <= fractionTwo}");
            Console.WriteLine($"The first >= second operator result: {fractionOne >= fractionTwo}");
            Console.WriteLine($"The first + second operator result: {fractionOne + fractionTwo}");
            Console.WriteLine($"The first - second operator result: {fractionOne - fractionTwo}");
            Console.WriteLine($"The first * second operator result: {fractionOne * fractionTwo}");
            Console.WriteLine($"The first / second operator result: {fractionOne / fractionTwo}");
            Console.WriteLine($"The first % second operator result: {fractionOne % fractionTwo}");
            Console.WriteLine($"The (int)second operator result: {(int)fractionTwo}");
            Console.WriteLine($"The (float)first operator result: {(float)fractionOne}");
            Console.WriteLine($"The ++first operator result: {++fractionOne}");
            Console.WriteLine($"The --second operator result: {--fractionTwo}");
            Console.WriteLine("BreakPoint");
            Console.ReadKey();
        }

        private static void ComplexNumberExample()
        {
            Console.WriteLine("Complex Numbers");

            var complexOne = new ComplexNumber(4, 4);
            var complexTwo = new ComplexNumber(1, 2);
            var complexThree = new ComplexNumber(4, 4);
            
            Console.WriteLine($"The first complex number: {complexOne}");
            Console.WriteLine($"The second complex number: {complexTwo}");
            Console.WriteLine($"The third complex number: {complexThree}");
            
            Console.WriteLine($"The first + the second: {complexOne + complexTwo}");
            Console.WriteLine($"The first - the second: {complexOne - complexTwo}");
            Console.WriteLine($"The first * the second: {complexOne * complexTwo}");
            Console.WriteLine($"The first equals the second: {complexOne.Equals(complexTwo)}");
            Console.WriteLine($"The first == the second: {complexOne == complexTwo}");
            Console.WriteLine($"The first equals the third: {complexOne.Equals(complexThree)}");
            Console.WriteLine($"The first == the third: {complexOne == complexThree}");
            
            Console.WriteLine("BreakPoint");
            Console.ReadKey();
        }
    }
}