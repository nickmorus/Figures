using TestTask.Shapes;

namespace TestTask.UnitTests
{
    [TestFixture]
    public class TriangleTest
    {

        [TestCase(10,10,10 , 43.30)]
        [TestCase(20, 20, 20, 173.21)]
        [TestCase(30, 30, 30, 389.71)]
        [TestCase(15, 14, 14, 88.66)]
        [TestCase(24, 25, 24, 256.10)]
        [TestCase(33, 36, 33, 497.86)]
        [TestCase(42, 47, 47, 883.00)]
        [TestCase(51, 58, 45, 1103.28)]
        public void SquareTest(double a, double b, double c, double result)
        {
            double precision = 1.0 / Math.Pow(10, 2);

            Triangle t = new(a, b, c);
            Assert.That(result, Is.EqualTo(t.GetSquare()).Within(precision));
        }

        [TestCase(0, 10, 15)]
        [TestCase(1, 1, -1)]
        [TestCase(22, -2, 15)]
        [TestCase(10, 16, 1)]
        [TestCase(16, 3, 11)]
        [TestCase(5, 10, 2)]

        public void ConstructorTest(double a, double b, double c)
        {
            Assert.Throws(typeof(ArgumentException), () => new Triangle(a,b,c));
        }
    }
}