using System;

namespace OOP_Homework
{
    /*
    Определить интерфейс IСoder, который полагает методы поддержки шифрования строк. 
    В интерфейсе объявляются два метода Encode() и Decode(), используемые  для шифрования и дешифрования строк. 
    Создать класс ACoder, реализующий интерфейс ICoder. 
    Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше. 
    (В результате такого сдвига буква А становится буквой Б). 
    Создать класс BCoder, реализующий интерфейс ICoder. 
    Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву того же регистра,
    расположенную в алфавите на i-й позиции с конца алфавита. (Например, буква В заменяется на букву Э.
    Написать программу, демонстрирующую функционирование классов).
    (*) Создать класс Figure для работы с геометрическими фигурами.
    В качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое».
    Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение цвета,
    опрос состояния (видимый/невидимый). Метод вывода на экран должен выводить состояние всех полей объекта.
    Создать класс Point (точка) как потомок геометрической фигуры. Создать класс Circle (окружность) как потомок точки.
    В класс Circle добавить метод, который вычисляет площадь окружности.
    Создать класс Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника.
    Точка, окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и вертикали,
    изменения цвета. Подумать, какие методы можно объявить в интерфейсе, нужно ли объявлять абстрактный класс,
    какие методы и поля будут в абстрактном классе, какие методы будут виртуальными, какие перегруженными.
    */
    class Program
    {
        static void Main(string[] args)
        {
            CoderExample();
        }

        private static void CoderExample()
        {
            Console.WriteLine("BreakPoint");
            Console.WriteLine("Creating A coder");
            var aCoder = new ACoder('а', 'я');
            var encodedFirst = aCoder.Encode("южмяэйяпясд");
            Console.WriteLine($"Result Encoded: {encodedFirst}");
            Console.WriteLine($"Result Decoded: {aCoder.Decode(encodedFirst)}");
            Console.WriteLine("BreakPoint. Press any key");
            Console.ReadKey();
            
            Console.WriteLine("BreakPoint");
            Console.WriteLine("Creating B coder");
            var bCoder = new BCoder('а', 'я');
            var encodedSecond = bCoder.Encode("аштябяцхчыс");
            Console.WriteLine($"Result Encoded: {encodedSecond}");
            Console.WriteLine($"Result Decoded: {bCoder.Decode(encodedSecond)}");
            Console.WriteLine("BreakPoint. Press any key");
            Console.ReadKey();
        }
    }
}