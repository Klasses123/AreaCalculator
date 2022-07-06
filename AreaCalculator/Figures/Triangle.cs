using AreaCalculator.Interfaces;
using System;
using System.Linq;

namespace AreaCalculator.Figures
{
    public class Triangle : IFigure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public bool IsRight { get; }
        
        public Triangle(double a, double b, double c)
        {
            var list = new double[] { a, b, c }.OrderBy(x => x).ToArray();

            _a = list[0];
            _b = list[1];
            _c = list[2];

            IsRight = _c * _c == _a * _a + _b * _b;
        }

        public double GetArea()
        {
            var p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public double GetPerimeter() => _a + _b + _c;
    }
}
