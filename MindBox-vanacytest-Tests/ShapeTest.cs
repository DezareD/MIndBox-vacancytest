using MindBox.Shapes;
using System;
using Xunit;

namespace MindBox.Tests
{
    public class ShapeTest
    {
        [Fact]
        public void GetTriangleSquare_3_4_5()
        {
            var triangle = new Triangle(3, 4, 5);
            double result = triangle.getSquare();

            Assert.Equal(6, result, 1);
        }

        [Fact]
        public void GetTriangleSquare_3_7_9()
        {
            var triangle = new Triangle(3, 8, 9);
            double result = triangle.getSquare();

            Assert.Equal(11.83, result, 1);
        }

        [Fact]
        public void GetTriangleSquare_7_3_8()
        {
            var triangle = new Triangle(7, 3, 8);
            double result = triangle.getSquare();

            Assert.Equal(10.39, result, 1);
        }

        [Fact]
        public void GetTriangleSquare_1_20_35()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 20, 35));
        }

        [Fact]
        public void IsRect_3_4_5()
        {
            var triangle = new Triangle(3, 4, 5);
            bool result = triangle.isRect();

            Assert.True(result);
        }

        [Fact]
        public void IsRect_7_3_8()
        {
            var triangle = new Triangle(7, 3, 8);
            bool result = triangle.isRect();

            Assert.False(result);
        }

        [Fact]
        public void GetCircleSquare_5()
        {
            var circle = new Circle(5);
            double result = circle.getSquare();

            Assert.Equal(31.4, result, 1);
        }

        [Fact]
        public void GetCircleSquare_15()
        {
            var circle = new Circle(15);
            double result = circle.getSquare();

            Assert.Equal(94.2, result, 1);
        }

        [Fact]
        public void GetCircleSquare_0()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }
    }
}
