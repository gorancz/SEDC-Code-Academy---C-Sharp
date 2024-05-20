using AbstractClassesAndInterfaces.Interfaces;

namespace AbstractClassesAndInterfaces.Models
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}
