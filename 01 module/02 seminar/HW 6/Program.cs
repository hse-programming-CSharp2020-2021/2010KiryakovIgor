using System;

namespace HW6
{
    class Program
    {
        static public void Method(double x, uint y)
        {
            double c = x * y / 100; //расчитываем сумму
            double d = c / 74.92; //переводим в доллары
            Console.WriteLine("Сумма равна:");
            Console.WriteLine(string.Format(new System.Globalization.CultureInfo("en-US"), "{0:c}", d));
        }

        static void Main(string[] args)
        {
            do
            {
                double x;
                uint y;
                do
                {
                    Console.WriteLine("Введите бюджет: ");
                }
                while (!double.TryParse(Console.ReadLine(), out x));
                do
                {
                    Console.WriteLine("Введите процент: ");
                }
                while (!uint.TryParse(Console.ReadLine(), out y));
                // вызываем метод
                Method(x, y);
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}