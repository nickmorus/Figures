using TestTask.Shapes.Abstract;

namespace TestTask.Shapes
{
    public class Triangle : ShapeBase
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double Perimeter { get => A+B+C; }

        /// <summary>
        /// Triangle class
        /// </summary>
        /// <param name="a">Side a</param>
        /// <param name="b">Side b</param>
        /// <param name="c">Side c</param>
        /// <exception cref="ArgumentException">Sides must be positive and thr sum of any two sides must be greater than the other</exception>
        public Triangle(double a, double b, double c)
        {
            if (!IsTrianglePossible(a, b, c))
            {
                throw new ArgumentException("Unable to create a triangle with specified sides");
            }

            if(a <=0 || b<=0 || c<=0)
            {
                throw new ArgumentException("Sides must be positive");
            }

            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Check rightness using the Pythagorean theorem
        /// </summary>
        /// <returns></returns>
        
        public bool IsRight()
        {
            return  Math.Pow(A,2) == Math.Pow(B,2) + Math.Pow(C,2) ||
                    Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2) ||
                    Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2);
        }

        /// <summary>
        /// Calculate square using Heron's formula 
        /// </summary>
        /// <returns></returns>
        public override double GetSquare()
        {
            double p = Perimeter / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        //By definition any two sides of the triangle must be greater than the one other
        private bool IsTrianglePossible(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}