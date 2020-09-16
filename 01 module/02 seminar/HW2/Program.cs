using System;

namespace HW2
{
    /*  
   Задача:      Ввести натуральное трехзначное число Р. Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р.    
    */

    class Program
    {
        public static int Method(int p) // создаем метод
        {
            int x, y, z, a1, a2, a3;
            x = p / 100;
            y = (p % 100) / 10;
            z = p % 10;
            a1 = x > y ? (z < y ? z : y) : (z < x ? z : x); //проверка на минимальное значение тернарным оператором
            a3 = x > y ? (z > x ? z : x) : (z > y ? z : y); //проверка на максимальное значение тернарным оператором
            a2 = (x != a1 && x != a3) ? x : (y != a1 && y != a3) ? y : z; //проверка на среднее значение тернарным оператором
            p = a3 * 100 + a2 * 10 + a1;
            return p; // возвращаем значение
        }
        static void Main(string[] args)
        {
            do
            {
                int p;
                Console.WriteLine("Введите трехзначное число: ");
                while (!int.TryParse(Console.ReadLine(), out p) || p > 999 || p < 100) // делаем проверку
                    Console.WriteLine("Попробуйте снова");
                Console.WriteLine(Method(p));
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);







        }
    }
}
