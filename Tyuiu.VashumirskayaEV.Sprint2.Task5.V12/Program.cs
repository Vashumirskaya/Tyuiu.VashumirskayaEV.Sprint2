using Tyuiu.VashumirskayaEV.Sprint2.Task5.V12.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Вашумирская Е.В. | СМАРТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите год (g): ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindDateOfPreviousDay(g, m, n);
            Console.WriteLine($"Дата предыдущего дня: {result}");

            Console.ReadKey();
        }
    }
}
