using System;

namespace OOP_Homework
{
    /*
     Для класса банковский счет переопределить операторы == и != для сравнения информации в двух счетах. 
     Переопределить метод Equals аналогично оператору ==, не забыть переопределить метод GetHashCode(). 
     Переопределить метод ToString() для печати информации о счете.
     Протестировать функционирование переопределенных методов и операторов на простом примере.
     (*) Создать класс Figure для работы с геометрическими фигурами.
     В качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое».
     Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение цвета,
     опрос состояния (видимый/невидимый). Метод вывода на экран должен выводить состояние всех полей объекта.
     Создать класс Point (точка) как потомок геометрической фигуры. Создать класс Circle (окружность) как потомок точки.
     В класс Circle добавить метод, который вычисляет площадь окружности.
     Создать класс Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника.
     Точка, окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и вертикали, изменения цвета.
     */
    class Program
    {
        static void Main(string[] args)
        {
            AccountExample();
        }

        private static void AccountExample()
        {
            var accountFirst = new ImprovedAccount(500_000, AccountType.Individual);
            var accountSecond = new ImprovedAccount(500_000, AccountType.Individual);
            var accountThird = accountFirst;
            Console.WriteLine("BreakPoint");
            Console.WriteLine("Created accounts:");
            Console.WriteLine($"First: {accountFirst}");
            Console.WriteLine($"Second: {accountSecond}");
            Console.WriteLine($"Third (reference to first): {accountThird}");
            Console.WriteLine($"First == Second: {accountFirst == accountSecond}");
            Console.WriteLine($"First != Second: {accountFirst != accountSecond}");
            Console.WriteLine($"First equals Second: {accountFirst.Equals(accountSecond)}");
            Console.WriteLine($"First == Third: {accountFirst == accountThird}");
            Console.WriteLine($"First != Third: {accountFirst != accountThird}");
            Console.WriteLine($"First equals Third: {accountFirst.Equals(accountThird)}");
            Console.WriteLine("BreakPoint. Any key to continue");
            Console.ReadKey();
        }
    }
}