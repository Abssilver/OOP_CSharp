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
            Console.Title = "Fractions";
            Fraction fractionOne = new Fraction(50, 20);
            Fraction fractionTwo = new Fraction(7, 8);
            
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
    }
}