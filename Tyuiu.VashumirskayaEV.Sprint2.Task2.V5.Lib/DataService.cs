using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task2.V5.Lib
{
    public class DataService : ISprint2Task2V5
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            return (y == 2 && (x >= 2 && x <= 6)) || (y == 3 && (x >= 2 && x <= 6)) ||
     (y == 4 && (x == 2 || x == 3)) || (y == 5 && (x == 2 || x == 3 ||
     (x >= 10 && x <= 12))) || (y == 6 && (x == 2 || x == 3 || x == 9 ||
     (x >= 10 && x <= 12))) || (y == 7 && (x == 2 || x == 3 ||
     (x >= 10 && x <= 12))) || (y == 8 && x == 3) || (y == 9 && x == 3) ||
     (y == 10 && x == 3) || (y == 11 && (x >= 3 && x <= 10)) || (y == 12 && x == 10);

        }
    }
}
