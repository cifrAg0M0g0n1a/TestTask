using Geometry.Library.Models;

namespace Geometry.Library.Tests.Models
{
    /* ЮНИТ-ТЕСТЫ ДЛЯ КРУГА */

    public class CircleTests
    {
        [Fact]
        public void CircleArea_ShouldReturnCorrectArea()
        {
            // Arrange
            double radius = 5;
            var circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.Equal(Math.PI * 25, area, 5);
        }
    }
}
