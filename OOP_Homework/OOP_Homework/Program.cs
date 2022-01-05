using System;

namespace OOP_Homework
{
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