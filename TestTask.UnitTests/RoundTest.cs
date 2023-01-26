using TestTask.Shapes;

namespace TestTask.UnitTests
{
    [TestFixture]
    public class RoundTest
    {

        [TestCase(10, 78.53982)]
        [TestCase(20, 314.15927)]
        [TestCase(30, 706.85835)]
        [TestCase(15, 176.71459)]
        [TestCase(24, 452.38934)]
        [TestCase(33, 855.2986)]
        [TestCase(42, 1385.44236)]
        [TestCase(51, 2042.82062)]
        public void SquareTest(double diameter, double result)
        {
            double precision = 1.0 / Math.Pow(10, 2);

            Round r = new(diameter);
            Assert.That(result, Is.EqualTo(r.GetSquare()).Within(precision));
        }

        [TestCase(0)]
        [TestCase(-1)]

        public void ConstructorTest(double diameter)
        {
            Assert.Throws(typeof(ArgumentException), () => new Round(diameter));
        }

    }
}