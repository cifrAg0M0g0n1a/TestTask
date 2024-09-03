using Geometry.Library.Interfaces;

namespace Geometry.Library.Models
{
    /* АБСТРАКТНЫЙ КЛАСС ФИГУРЫ */

    public abstract class Shape : IShape
    {
        public abstract double CalculateArea();
    }
}
