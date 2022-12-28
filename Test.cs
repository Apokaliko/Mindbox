using NUnit.Framework;
namespace Mindbox.Tests
{
    public class AreaTests
    {
        [Test]
        public void TestCircleArea()
        {
            Circle circle = new Circle(1.234);
            double area = circle.CalculateArea();
            Assert.AreEqual(4.78145384, area);
        }

        [Test]
        public void TestTriangleArea()
        {
            Triangle triangle = new Triangle(2.0, 2.0, 3.0);
            double area = triangle.CalculateArea();
            Assert.AreEqual(1.984313483298443, area);
        }

        [Test]
        public void TestTriangleIsRight()
        {
            Triangle triangle = new Triangle(6.0, 8.0, 10.0);
            bool isRightTriangle = triangle.RightTriangle();
            Assert.IsTrue(isRightTriangle);

            Triangle triangle2 = new Triangle(7.0, 3.0, 4.0);
            isRightTriangle = triangle2.RightTriangle();
            Assert.IsFalse(isRightTriangle);
        }
    }
}