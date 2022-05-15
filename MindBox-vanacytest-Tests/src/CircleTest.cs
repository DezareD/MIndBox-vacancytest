using MindBox.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MindBox.Tests
{
    public class CircleTest
    {
        [Fact]
        public void Circle_GetSquare_ShouldResultSquare()
        {
            var circle = new Circle(5);
            double result = circle.getSquare();

            Assert.Equal(31.4, result, 1);
        }

        [Fact]
        public void Circle_GetSquare_ShouldResultArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }
    }
}
