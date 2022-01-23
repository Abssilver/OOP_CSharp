using System.Drawing;

namespace OOP_Homework
{
    /*
    Создать класс Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника.
    */
    internal sealed class Rectangle: Point, ISquareObject
    {
        private int _width;
        private int _height;
        
        public int Width => _width;
        public int Height => _height;

        public Rectangle(Color color, bool isVisible, System.Drawing.Point center, int width, int height) 
            : base(color, isVisible, center)
        {
            _width = width;
            _height = height;
        }

        public void ChangeWidth(int changeTo)
        {
            _width = changeTo;
        }
        
        public void ChangeHeight(int changeTo)
        {
            _height = changeTo;
        }

        public double GetSquare()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return base.ToString() + $" Width: {Width}, Height: {Height}, Square: {GetSquare()}";
        }
    }
}