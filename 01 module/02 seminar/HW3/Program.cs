using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        //Введя значения коэф. А, В, С, вычислить корни квадратного уравнения.
        static void Method(int a, int b, int c)
        {
            double d, x1, x2;
            d = (b * b - 4 * a * c);
            x1 = (-b + Math.Sqrt(d)) / 2;
            x2 = (-b - Math.Sqrt(d)) / 2;
            Console.WriteLine(d > 0 ? $"Корни уравнения:{ x1}, { x2}" : "Выявлено наличие комплексных корней");
        }
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    //вводим коэффициенты
                    Console.WriteLine("Введите коэффициенты");
                    Console.WriteLine("а=");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("b=");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("c=");
                    int c = int.Parse(Console.ReadLine());
                    Method(a, b, c); //вызываем метод
                    Console.WriteLine("Чтобы завершить нажмите ESC");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}