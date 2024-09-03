using Geometry.Library.Interfaces;

namespace Geometry.Library.Services
{
    /* ВЫЧИСЛЕНИЕ РАДИУСА ПРОИЗВОЛЬНОЙ ФИГУРЫ */

    public class AreaService
    {
        public double GetArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
