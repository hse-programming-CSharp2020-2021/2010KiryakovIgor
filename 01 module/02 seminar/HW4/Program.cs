using System;
using System.Security.Cryptography.X509Certificates;

namespace HW4
{
    /*  
   Задача:      Получить от пользователя четырехзначное натуральное число и напечатать его цифры в обратном порядке.
*/

    class Program
    {
        public static void Method(int x) // создаем метод
        {
            int a, b, c, d;
            a = x / 1000;
            b = (x % 1000) / 100;
            c = (x % 100) / 10;
            d = x % 10;
            Console.WriteLine($"{d}{c}{b}{a}"); // выводим числа

        }
        static void Main(string[] args)
        {
            do
            {
                int x;
                do
                {
                    Console.WriteLine("Введите четырехзначное число: ");
                }
                while (!int.TryParse(Console.ReadLine(), out x) && (x > 9999) || (x < 1000));
                Method(x); // вызывем метод
                Console.WriteLine("Введите для выхода ESC...");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);





        }
    }
}
