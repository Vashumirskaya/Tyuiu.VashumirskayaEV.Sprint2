using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int[] daysInMonth = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (n == 1)
            {
                if (m == 1)
                {
                    g--;
                    m = 12;
                    n = 31;
                }
                else
                {
                    m--;
                    n = daysInMonth[m - 1];
                }
            }
            else
            {
                n--;
            }

            return $"{n}.{m}.{g}";
        }
    }
}
