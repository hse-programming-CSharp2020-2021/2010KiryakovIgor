using System;

namespace CW_6
{
    /*
     Написать методы, вычисляющие суммы рядов с машинной точностью (если это возможно):
     𝑺=𝒙^𝟐−(𝟐^𝟑 𝒙^𝟒)/𝟒!+(𝟐^𝟓 𝒙^𝟔)/𝟔!−…
     𝑺=𝟏+𝒙/𝟏!+𝒙^𝟐/𝟐!+…+𝒙^𝒏/𝒏!+…
     Вещественные значения x получать от пользователя в основной программе.
     */
    class Program
    {
        /// <summary>
        /// Метод,который вычисляет факториал
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        static int Fact(int k)
        {
            if (k == 1)
            {
                return 1;
            }
            else
            {
                int res = 1;
                for (int i = 1; i <= k; i++)
                {
                    res *= i;
                }

                return res;
            }
        }

        /// <summary>
        /// Метод,который вычисляет значение первй функции
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double Number1(double x)
        {
            double sum = 0;
            double prevSum = -1;
            int k = 0;
            while (prevSum != sum && sum != Double.PositiveInfinity)
            {
                k += 1;
                prevSum = sum;
                sum += ((double)(2 * k - 1) * Math.Pow(x, 2 * k)) / (Fact(2 * k));
            }

            return prevSum;
        }

        /// <summary>
        /// Метод, который вычисляет вторую функцию
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double Number2(double x)
        {
            double sum = 0;          
            double prevSum = -1;
            int k = 0;         
            while (prevSum != sum && sum != Double.PositiveInfinity)
            {
                k += 1;
                prevSum = sum;
                sum += Math.Pow(x, k) / Fact(k);
            }

            
            return prevSum;
        }

        static void Main(string[] args)
        {
            do
            {
                int x;
                Console.Write("Введите значение x: ");
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    for (int i = 1; i <= x; i++)
                    {
                        Console.WriteLine($"S1({i})={Number1(i)}");
                    }
                    for (int i = 1; i <= x; i++)
                    {
                        Console.WriteLine($"S2({i})={Number2(i)}");
                    }
                }
                else Console.WriteLine("Повторите ввод");
                Console.WriteLine("Введите ESC для выхода из программы или нажмите любую клавишу для повтора решения");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);    
        }
    }
}