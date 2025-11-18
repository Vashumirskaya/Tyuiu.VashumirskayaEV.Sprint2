using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            bool belowParabola = y <= Math.Pow(x, 2);
            bool aboveParabola = y >= Math.Pow(x, 2);

            bool belowLine = y <= 2 - x;
            bool aboveLine = y >= 2 - x;

            bool first = belowParabola && aboveLine;
            bool second = aboveParabola && belowLine;

            return first || second;
            
        }
    }
}
