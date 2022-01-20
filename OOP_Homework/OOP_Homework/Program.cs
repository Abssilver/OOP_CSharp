using System;
using System.Drawing;

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
            FigureExample();
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

        private static void FigureExample()
        {
            var pointCenter = new System.Drawing.Point() { X = 0, Y = 0 };
            var circleCenter = new System.Drawing.Point() { X = 3, Y = 3 };
            var rectangleCenter = new System.Drawing.Point() { X = 5, Y = 5 };
            var isVisible = true;
            
            var point = new Point(Color.Azure, isVisible, pointCenter);
            double radius = 10;
            var circle = new Circle(Color.Aqua, !isVisible, circleCenter, radius);
            var width = 10;
            var height = 5;
            var rectangle = new Rectangle(Color.Coral, isVisible, rectangleCenter, width, height);
            
            Console.WriteLine("BreakPoint");
            Console.WriteLine("Created Figures:");
            Console.WriteLine(point);
            Console.WriteLine(circle);
            Console.WriteLine(rectangle);
            
            var horizontalOffset = 1;
            point.MoveHorizontal(horizontalOffset);
            Console.WriteLine($"Move point to ({horizontalOffset}, 0).");
            Console.WriteLine(point);
            
            var newRadius = 3;
            var newColor = Color.Lime;
            var verticalOffset = -1;
            circle.ChangeRadius(newRadius);
            circle.ChangeColor(newColor);
            circle.MoveVertical(verticalOffset);
            Console.WriteLine($"Move circle to (0, {verticalOffset}). Change color to {newColor}. Change radius to {newRadius}");
            Console.WriteLine(circle);
            
            rectangle.ChangeHeight(rectangle.Width);
            rectangle.MoveHorizontal(horizontalOffset);
            rectangle.MoveVertical(verticalOffset);
            rectangle.ChangeColor(newColor);

            Console.WriteLine("Move rectangle to ({0}, {1}). Change color to {2}. Change Height to {3}",
                horizontalOffset, 
                verticalOffset,
                newColor,
                rectangle.Width);
            Console.WriteLine(rectangle);
            Console.WriteLine("BreakPoint. Any key to continue");
            Console.ReadKey();
        }
    }
}