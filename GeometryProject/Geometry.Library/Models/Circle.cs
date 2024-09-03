namespace Geometry.Library.Models
{
    public class Circle : Shape
    {
        /* ВЫЧИСЛЕНИЕ РАДИУСА КРУГА */

        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным");

            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
