using Geometry.Library.Models;
using Geometry.Library.Services;
using Geometry.Library.Interfaces;

namespace Geometry.Library.Tests.Services
{
    /* ЮНИТ-ТЕСТЫ ДЛЯ ПРОИЗВОЛЬНОЙ ФИГУРЫ */

    public class AreaServiceTests
    {
        [Fact]
        public void AreaService_ShouldCalculateAreaForAnyShape()
        {
            // Arrange
            IShape circle = new Circle(5);
            IShape triangle = new Triangle(3, 4, 5);
            var areaService = new AreaService();

            // Act
            double circleArea = areaService.GetArea(circle);
            double triangleArea = areaService.GetArea(triangle);

            // Assert
            Assert.Equal(Math.PI * 25, circleArea, 5);
            Assert.Equal(6, triangleArea, 5);
        }
    }
}
