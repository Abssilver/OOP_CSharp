﻿using System;
using System.Collections;

namespace OOP_Homework
{
    /*
    (*) Для реализованного класса (Building) создать новый класс Creator, 
        который будет являться фабрикой объектов класса здания. 
        Для этого изменить модификатор доступа к конструкторам класса, 
        в новый созданный класс добавить перегруженные фабричные методы CreateBuild для создания объектов класса здания.
        В классе Creator все методы сделать статическими, конструктор класса сделать закрытым. 
        Для хранения объектов класса здания в классе Creator использовать хеш-таблицу. 
        Предусмотреть возможность удаления объекта здания по его уникальному номеру из хеш-таблицы. 
        Создать тестовый пример, работающий с созданными классами.
    */ 
    
    internal class Creator
    {
        private const double DefaultHeight = 5;
        private const int DefaultFloorCount = 2;
        private const int DefaultApartmentCount = 8;
        private const int DefaultEntranceCount = 1;
        
        private static readonly Hashtable BuildingCollection = new Hashtable();
        private Creator()
        { }

        public static Building CreateBuilding()
        {
            return CreateBuilding(DefaultHeight, DefaultFloorCount, DefaultApartmentCount, DefaultEntranceCount);
        }

        public static Building CreateBuilding(double height)
        {
            return CreateBuilding(height, DefaultFloorCount, DefaultApartmentCount, DefaultEntranceCount);
        }
        
        public static Building CreateBuilding(double height, int floors)
        {
            return CreateBuilding(height, floors, DefaultApartmentCount, DefaultEntranceCount);
        }
        public static Building CreateBuilding(double height, int floors, int apartments)
        {
            return CreateBuilding(height, floors, apartments, DefaultEntranceCount);
        }
        
        public static Building CreateBuilding(double height, int floors, int apartments, int entrances)
        {
            var building = new Building(height, floors, apartments, entrances);
            AddBuildingToCollection(building);
            return building;
        }
        
        private static void AddBuildingToCollection(Building building)
        {
            try
            {
                BuildingCollection.Add(building.GetId(), building);
            }
            catch
            {
                Console.WriteLine($"An element with Key: {building.GetId()} already exists.");
            }
        }

        public static void DeleteBuilding(long id)
        {
            if (!BuildingCollection.ContainsKey(id))
            {
                Console.WriteLine($"Building with id: {id} is not exits in collection");
                return; 
            }

            Console.WriteLine($"Removing building with id: {id}");
            BuildingCollection.Remove(id);
        }
    }
}