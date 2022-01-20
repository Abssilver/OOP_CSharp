using System.Drawing;

namespace OOP_Homework
{
    /*
    Создать класс Point (точка) как потомок геометрической фигуры.
    */
    internal class Point: Figure
    {
        public Point(Color color, bool isVisible, System.Drawing.Point center) : base(color, isVisible, center)
        { }
    }
}