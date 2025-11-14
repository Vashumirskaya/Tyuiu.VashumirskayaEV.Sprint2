using Tyuiu.VashumirskayaEV.Sprint2.Task6.V7.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Вашумирская Е.В. | СМАРТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращенная форма записи оператора switch                         *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* С начала 1990 года по некоторый день прошло n месяцев и 2 дня.         *");
            Console.WriteLine("* Определить название месяца этого дня.                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите начальный год (startYear): ");
            int startYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество месяцев (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindMonthName(startYear, n);
            Console.WriteLine($"Название месяца: {result}");

            Console.ReadKey();
        }
    }
}
