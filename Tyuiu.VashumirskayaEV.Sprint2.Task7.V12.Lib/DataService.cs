using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            bool leftArea = (x <= 0) && (y >= 2 - x);

            bool rightArea = (x >= 0) && (y <= 2 - x);

            return leftArea || rightArea;

        }
    }
}
