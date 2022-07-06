using AreaCalculator.Interfaces;
using System;

namespace AreaCalculator.Figures
{
    public class Square : IFigure
    {
        private readonly double _radius;
        public Square(double radius)
        {
            _radius = radius;
        }
        public double GetArea() => Math.PI * Math.Pow(_radius, 2);

        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
