using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator.Interfaces;
using AreaCalculator.Services;
using AreaCalculator.Figures;
using System.Collections.Generic;

namespace AreaCalculatorTests
{
    [TestClass]
    public class AreaCalcTests
    {
        private readonly IFigureService _figureService;
        public AreaCalcTests()
        {
            _figureService = new FigureService(
                new List<IFigure> 
                { 
                    new Circle(10),
                    new Triangle(3, 4, 5)
                });
        }

        //Вычисление площади фигуры без знания типа фигуры в compile-time
        [TestMethod]
        public void AreasTest()
        {
            var results = new List<double>();
            foreach(var f in _figureService.Figures)
            {
                results.Add(f.GetArea());
            }

            Assert.AreEqual(2, results.Count);
            Assert.AreEqual(314.15926535897933, results[0]); 
            Assert.AreEqual(6, results[1]);
        }

        //Проверку на то, является ли треугольник прямоугольным
        [TestMethod]
        public void RightTriangleTest()
        {
            var right = new Triangle(10, 24, 26);
            var notRight = new Triangle(11, 24, 26);

            Assert.AreEqual(right.IsRight, true);
            Assert.AreEqual(notRight.IsRight, false);
        }
    }
}
