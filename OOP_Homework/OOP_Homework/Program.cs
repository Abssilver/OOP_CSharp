using System;

namespace OOP_Homework
{
    /*
     (*) Разбить созданные классы (здания, фабричный класс) и тестовый пример в разные исходные файлы. 
     Разместить классы в одном пространстве имен. 
     Создать сборку (DLL), включающие эти классы. 
     Подключить сборку к проекту и откомпилировать тестовый пример со сборкой. 
     Получить исполняемый файл, проверить с помощью утилиты ILDASM, что тестовый пример ссылается на сборку и 
     не содержит в себе классов здания и Creator.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var building = Creator.CreateBuilding();
            Console.WriteLine("BreakPoint");
            Console.WriteLine(building.Print());
            Console.ReadKey();
            var anotherBuilding = Creator.CreateBuilding(10, 5, 8, 10);
            Console.WriteLine("BreakPoint");
            Console.WriteLine(anotherBuilding.Print());
            Console.ReadKey();
            Console.WriteLine("BreakPoint");
            Console.WriteLine($"Deleting building: {building.GetId()}");
            Creator.DeleteBuilding(building.GetId());
            Console.ReadKey();
        }
    }
}