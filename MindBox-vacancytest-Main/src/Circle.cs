using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Shapes
{
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
