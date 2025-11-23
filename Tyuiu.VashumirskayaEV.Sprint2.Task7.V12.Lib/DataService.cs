using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            return (y >= x * x && y <= 2 - x) || (y <= x * x && y >= 2 - x);

        }
    }
}
