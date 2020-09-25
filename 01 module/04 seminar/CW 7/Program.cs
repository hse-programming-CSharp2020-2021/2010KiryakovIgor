using System;
using System.Security.Cryptography;

namespace CW_7
{
    /*
     * Написать программу, которая по двум целым неотрицательным числам A и B возвращает их наибольший общий делитель (НОД) и наименьшее общее кратное (НОК)
    */
    class Program
    {
        // создаем метод
        public static void Method(uint a, uint b, out uint nod, out uint nok)
        {
            nod = 0;
            nok = 0;
            uint a1 = a;
            uint b1 = b;
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            nod += a;
            nok += a1 * b1 / nod;
            Console.WriteLine($"НОД={nod}");
            Console.WriteLine($"НОК={nok}");
        }
        static void Main(string[] args)
        {
            uint a, b, nod, nok;
            Console.WriteLine("Введите 2 числа: ");
            if (uint.TryParse(Console.ReadLine(), out a) && (uint.TryParse(Console.ReadLine(), out b)) && (a != 0 || b != 0)) 
            {
                // вызываем метод
                Method(a, b, out nod, out nok);
            }
            else Console.WriteLine("Incorrect input");
        }
    }
}
