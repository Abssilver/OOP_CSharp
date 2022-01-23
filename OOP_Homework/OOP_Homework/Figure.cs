using System.Drawing;

namespace OOP_Homework
{
    /*
    Создать класс Figure для работы с геометрическими фигурами.
    В качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое».
    Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение цвета,
    опрос состояния (видимый/невидимый). Метод вывода на экран должен выводить состояние всех полей объекта.
    */
    internal abstract class Figure
    {
        private Color _color;
        private bool _isVisible;
        private System.Drawing.Point _center;

        public Color Color => _color;
        public bool IsVisible => _isVisible;
        
        protected Figure(Color color, bool isVisible, System.Drawing.Point center)
        {
            _color = color;
            _isVisible = isVisible;
            _center = center;
        }

        public void ChangeColor(Color changeTo)
        {
            _color = changeTo;
        }

        public void MoveHorizontal(int offset)
        {
            _center.X += offset;
        }

        public void MoveVertical(int offset)
        {
            _center.Y += offset;
        }

        public override string ToString()
        {
            return string.Format("Figure: {0}, Color: {1}, IsVisible: {2}, Center: X: {3} Y: {4}",
                this.GetType().Name,
                this.Color,
                this.IsVisible,
                this._center.X,
                this._center.Y);
        }
    }
}