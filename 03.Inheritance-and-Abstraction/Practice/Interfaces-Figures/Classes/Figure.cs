using Interfaces_Figures.Interfaces;

namespace Interfaces_Figures.Classes
{
    public abstract class Figure : ICalcArea
    {
        public abstract double CalcArea();
    }
}