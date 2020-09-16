using System;

namespace HW7
{
    /*
   Задача:      Написать программу с использованием двух методов. Первый метод возвращает дробную и целую часть числа. Второй метод возвращает квадрат и корень из числа. В основной программе пользователь вводит дробное число. Программа должна вычислить, если это возможно, значение корня, квадрата числа, выделить целую и дробную часть из числа.
*/

    class Program
    {

        public static void Method1(double x, out double res1, out double res2) //создаем метод
        {
            res1 = Math.Truncate(x);
            res2 = x % 1;
        }

        public static void Method2(double x, out double res1, out double res2) //создаем метод
        {
            res1 = Math.Pow(x, 2);
            res2 = Math.Sqrt(x);
        }

        static void Main(string[] args)
        {
            do
            {
                double x;
                Console.WriteLine("Введите число:");
                while (!double.TryParse(Console.ReadLine(), out x))
                    Console.WriteLine("Попробуйте еще раз!");
                Method1(x, out double whole, out double fraction); //вызываем метод
                Method2(x, out double pow, out double sqrt);       //вызываем метод
                Console.WriteLine($"Целая часть числа: {whole}, дробная часть числа: {fraction}");
                Console.WriteLine($"Квадрат числа: {pow}, корень из числа: {sqrt}");
                Console.WriteLine("Для завершения работы нажмите Esc");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
