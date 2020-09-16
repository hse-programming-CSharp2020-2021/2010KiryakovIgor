using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Task3
{/*
   Дисциплина: "Программирование"
   Группа:      БПИ2010/2
   Студент:     Киряков Игорь Андреевич
   Задача:     Написать метод, так обменивающий значения трех переменных x, y, z, чтобы выполнилось требование: x <= y <= z. 
В основной программе, вводить значения трех переменных и упорядочивать их с помощью обращения к написанному методу. 
Для выхода из программы вводите ESC, для повторения решения – любую другую клавишу. 
*/

    class Program
    {
        public static void Method(ref int x, ref int y, ref int z) // создание метода,в котором высчитывается фромула
        {
            int a1, a2, a3;
            a1 = x > y ? (z < y ? z : y) : (z < x ? z : x); //проверка на минимальное значение тернарным оператором
            a3 = x > y ? (z > x ? z : x) : (z > y ? z : y); //проверка на максимальное значение тернарным оператором
            a2 = (x != a1 && x != a3) ? x : (y != a1 && y != a3) ? y : z; //проверка на среднее значение тернарным оператором
            x = a1;
            y = a2;
            z = a3;
        }

        static void Main(string[] args)
        {
            do
            {
                int x, y, z;
                Console.WriteLine("Введите 3 числа:");
                while (!int.TryParse(Console.ReadLine(), out x)) //вводим с клавиатуры 3 числа
                    Console.WriteLine("Введите числа:");
                while (!int.TryParse(Console.ReadLine(), out y))
                    Console.WriteLine("Введите число еще раз:");
                while (!int.TryParse(Console.ReadLine(), out z))
                    Console.WriteLine("Введите число еще раз:");
                Method(ref x, ref y, ref z);                      // вызываем метод
                Console.WriteLine($"Числа: {x} , {y} , {z}");    // выводим результат}
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);




        }
    }
}
