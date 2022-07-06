using AreaCalculator.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AreaCalculator.Services
{
    public class FigureService : IFigureService
    {
        public IFigure Figure { get; }
        public IEnumerable<IFigure> Figures { get; }
        public FigureService(IFigure figure)
        {
            Figure = figure;
            Figures = new List<IFigure>() { figure };
        }

        public FigureService(IEnumerable<IFigure> figures)
        {
            Figures = figures;
            Figure = figures.FirstOrDefault();
        }
    }
}
