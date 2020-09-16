using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05_c_
{
    class Program
    {
        //Получить от пользователя три вещественных числа и проверить для них неравенство треугольника
        static void Method(double a, double b, double c) //создаем метод Мethod
        {
            double x = Math.Abs(a);
            double y = Math.Abs(b);
            double z = Math.Abs(c);
            double minXY = Math.Min(x, y);
            double maxXY = Math.Max(x, y);
            double max = maxXY < z ? z : maxXY;
            double min = minXY > z ? z : minXY;
            double mid = maxXY == max && minXY == min ? z : x == min || x == max ? y : x;
            Console.WriteLine(max <= mid + min ? "Верно" : "Неверно");
        }
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("Введите длины сторон треугольника: ");
                    double a = double.Parse(Console.ReadLine()); //вводим переменные
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    Method(a, b, c);
                    Console.WriteLine("Чтобы завершить нажмите ESC...");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}