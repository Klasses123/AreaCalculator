using System.Collections.Generic;

namespace AreaCalculator.Interfaces
{
    public interface IFigureService
    {
        IFigure Figure { get; }
        IEnumerable<IFigure> Figures { get; }
    }
}
