﻿namespace OOP_Homework
{
    /*
    Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов). 
    Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати. 
    Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д. 
    Предусмотреть возможность, чтобы уникальный номер здания генерировался программно. 
    Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания, и 
    предусмотреть метод, который увеличивал бы значение этого поля.
    */
    internal class Building
    {
        private const double DefaultHeight = 5;
        private const int DefaultFloorCount = 2;
        private const int DefaultApartmentCount = 8;
        private const int DefaultEntranceCount = 1;
        
        private static long _buildingId;
        private long _id;
        private double _height;
        private int _floorCount;
        private int _apartmentCount;
        private int _entranceCount;

        public Building(): this(DefaultHeight)
        { }
        public Building(double height, int floorCount = DefaultFloorCount, 
            int apartmentCount = DefaultApartmentCount,
            int entranceCount = DefaultEntranceCount)
        {
            SetId(GenerateNewId());
            SetHeight(height);
            SetFloorCount(floorCount);
            SetApartmentCount(apartmentCount);
            SetEntranceCount(entranceCount);
        }

        public long GetId() => _id;
        public double GetHeight() => _height;
        public int GetFloorCount() => _floorCount;
        public int GetTotalApartmentCount() => _apartmentCount;
        public int GetEntranceCount() => _entranceCount;
        public double GetFloorHeight(int floor)
        {
            if (floor <= 0 || floor > _floorCount)
            {
                return -1;
            }
            
            return (_height * floor) / _floorCount;
        }

        public int GetApartmentCountInEntrance(int entrance)
        {
            if (entrance <= 0 || entrance > _entranceCount)
            {
                return -1;
            }

            var apartmentPerEntrance = (float)_apartmentCount / _entranceCount;

            return entrance != _entranceCount
                ? (int)System.MathF.Floor(apartmentPerEntrance)
                : _apartmentCount - (int)System.MathF.Floor((_entranceCount - 1) * apartmentPerEntrance);
        }

        public int GetApartmentCountAtFloor(int floor)
        {
            if (floor <= 0 || floor > _floorCount)
            {
                return -1;
            }
            
            var apartmentPerFloor = (float)_apartmentCount / _floorCount;

            return floor != _floorCount
                ? (int)System.MathF.Floor(apartmentPerFloor)
                : _apartmentCount - (int)System.MathF.Floor((_floorCount - 1) * apartmentPerFloor);
        }

        private void SetId(long id) => _id = id;

        private void SetHeight(double height)
        {
            _height = height <= 0 ? DefaultHeight : height;
        }

        private void SetFloorCount(int floorCount)
        {
            _floorCount = floorCount <= 0 ? DefaultFloorCount : floorCount;
        }

        private void SetApartmentCount(int apartmentCount)
        {
            _apartmentCount = apartmentCount <= 0 ? DefaultApartmentCount : apartmentCount;
        }

        private void SetEntranceCount(int entranceCount)
        {
            _entranceCount = entranceCount <= 0 ? DefaultEntranceCount : entranceCount;
        }
        
        private long GenerateNewId()
        {
            return ++_buildingId;
        }

    }
}