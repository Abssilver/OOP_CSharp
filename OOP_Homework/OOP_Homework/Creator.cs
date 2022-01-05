using System;
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
    
    internal class Creator : BaseCreator
    {
        private static readonly Hashtable BuildingCollection = new Hashtable();

        public override Building CreateBuilding()
        {
            var building = new Building();
            try
            {
                BuildingCollection.Add(building.GetId(), building);
            }
            catch
            {
                Console.WriteLine($"An element with Key: {building.GetId()} already exists.");
            }
            return building;
        }

        public override void DeleteBuilding(long id)
        {
            if (!BuildingCollection.ContainsKey(id))
            {
                Console.WriteLine($"Building with id: {id} is not exits in collection");
                return; 
            }

            BuildingCollection.Remove(id);
            Console.WriteLine($"Removing building with id: {id}");
        }
    }
}