using Tyuiu.VashumirskayaEV.Sprint2.Task4.V27.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint2.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds  = new DataService();    
            Console.Title = "Спринт #1 | Выполнила: Вашумирская Е.В. | СМАРТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Тернарная операция                                                *");
            Console.WriteLine("* Задание #                                                               *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора. Если x*10 > y+2, то                *");
            Console.WriteLine("* z = x*((y+2)/(x-1))^x, иначе z = y^2*(2/x). Округлить до 3 знаков.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x, y);
            Console.WriteLine($"z = {result}");

            Console.ReadKey();
        }
    }
}
