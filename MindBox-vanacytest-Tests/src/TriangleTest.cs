using MindBox.Shapes;
using System;
using Xunit;

namespace MindBox.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void Triangle_GetSquare_ShouldResultSquare()
        {
            var triangle = new Triangle(3, 4, 5);
            double result = triangle.getSquare();

            Assert.Equal(6, result, 1);
        }

        [Fact]
        public void Triangle_Constructor_ShouldResultArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 20, 35));
        }

        [Fact]
        public void Triangle_Constructor_ShouldResultArgumentException_NegativeSide()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, -5, 3));
        }

        [Fact]
        public void Triangle_IsRect_ShouldResultTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            bool result = triangle.isRect();

            Assert.True(result);
        }

        [Fact]
        public void Triangle_IsRect_ShouldResultFalse()
        {
            var triangle = new Triangle(7, 3, 8);
            bool result = triangle.isRect();

            Assert.False(result);
        }
    }
}
