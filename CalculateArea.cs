namespace Mindbox
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            const double pi = 3.14;
            return pi * radius * radius;
        }
    }

    public class Triangle : Shape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double CalculateArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool RightTriangle()
        {
            return a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a;
        }
    }
    public static class ShapeFactory
    {
        public static Shape CreateShape(string shapeName, params double[] parameters)
        {
            switch (shapeName)
            {
                case "Circle":
                    return new Circle(parameters[0]);
                case "Triangle":
                    return new Triangle(parameters[0], parameters[1], parameters[2]);
                default:
                    throw new ArgumentException("Неверное имя фигуры");
            }
        }
    }


}

