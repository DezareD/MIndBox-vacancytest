using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Shapes
{
    /// <summary>
    /// Реализация абстрактного класса в виде треугольника
    /// </summary>
    public class Triangle : Shape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            if (c <= 0 || a <= 0 || b <= 0) throw new ArgumentException("Одна или несколько сторон треугольника не могут быть отрицательными.");
            if (c > a + b || b > a + c || b > a + c) throw new ArgumentException("Одна из сторон больше суммы други двух. Треугольник существовать не может.");

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
}
