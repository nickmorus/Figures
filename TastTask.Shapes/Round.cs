using TestTask.Shapes.Abstract;

namespace TestTask.Shapes
{
    public class Round : ShapeBase
    {
        /// <summary>
        /// Round class
        /// </summary>
        /// <param name="diameter">Diameter of the round</param>
        /// <exception cref="ArgumentException">Diameter must be positive</exception>
        public Round(double diameter) : base()
        {
            if(diameter <= 0)
            {
                throw new ArgumentException("Diameter must be positive");
            }
            Diameter = diameter;
        }

        public double Diameter { get; }
        public double Radius { get => Diameter / 2; }

        public override double GetSquare() => (Math.PI * Math.Pow(Radius, 2));        
    }
}