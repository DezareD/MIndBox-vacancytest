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

    /// <summary>
    /// Реализация абстрактного класса в виде треугольника
    /// </summary>
    public class Triangle : Shape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            if (c > a + b || b > a + c || b > a + c) throw new ArgumentException("Одна из сторон больше суммы други двух. Треугольник существовать не может");

            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Является ли треугольник прямоугольным?
        /// </summary>
        public bool isRect() => Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);

        public override double getSquare()
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

    /// <summary>
    /// Реализация абстрактного класса в виде круга
    /// </summary>
    public class Circle : Shape
    {
        private double r;

        public Circle(double r)
        {
            if (r <= 0) throw new ArgumentException("Радиус треугольника не может быть меньше или равен нулю.");
            this.r = r;
        }

        public override double getSquare() => 2 * PI * r;
    }
}
