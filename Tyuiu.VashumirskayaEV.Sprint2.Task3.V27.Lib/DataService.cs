using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task3.V27.Lib
{
    public class DataService : ISprint2Task3V27
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 0)
            {
                y = x * Math.Pow((x + 1) / (Math.Sin(x * x) + x - 0.5), x);
            }
            else if (x == 0)
            {
                y = (x * x - Math.Cos(x * x) + 4) / (x * x - Math.Sin(x * x) + 12);
            }
            else if (-31 < x && x < 0)
            {
                y = Math.Pow(1 + 1 / (x * x), 2);
            }
            else // x < -31
            {
                y = x + Math.Sin(Math.Pow(x, 5)) + Math.Pow(x, 3) - (2 / x);
            }

            return Math.Round(y, 3);

        }
    }
}
