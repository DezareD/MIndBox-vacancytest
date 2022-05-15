using System;

namespace MindBox.Shapes
{
    /// <summary>
    /// Общий абстрактный класс для фигур
    /// </summary>
    public abstract class Shape
    {
        public const double PI = Math.PI;

        /// <summary>
        /// Получаем площадь фигуры
        /// </summary>
        public abstract double getSquare();
    }
}
