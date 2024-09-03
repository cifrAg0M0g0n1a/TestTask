using Geometry.Library.Models;

namespace Geometry.Library.Tests.Models
{
    /* ЮНИТ-ТЕСТЫ ДЛЯ ТРЕУГОЛЬНИКА */

    public class TriangleTests
    {
        [Fact]
        public void TriangleArea_ShouldReturnCorrectArea()
        {
            // Arrange
            double sideA = 3, sideB = 4, sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.Equal(6, area, 5);
        }

        [Fact]
        public void Triangle_IsRightTriangle_ShouldReturnTrueForRightTriangle()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            bool isRight = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRight);
        }
    }
}
