using System;

namespace Task_8
{
    /*
     Определить все тройки попарно различных целых чисел 𝑎,𝑏,𝑐 из интервала [1;20], для которых верно 𝑎^2+𝑏^2=𝑐^2
    */
    // Метод, выводящий все тройки чисел a, b и c из интервала [1, 20], для который a^2 + b^2 = c^2.
    class Program 
    {
        /// <summary>
        /// Метод,который 
        /// </summary>
        static void Digits()
        {
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= 20 && j != i; j++)
                {
                    if (i * i + j * j >= 1 && i * i + j * j <= 20) 
                        Console.WriteLine($"{i}, {j}, {i * i + j * j}");
                }
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ваши цифры:");
                Digits();
                Console.WriteLine("Для выхода из программы нажмите ESC или любую клавишу для повтора решения");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);          
        }
    }  
}
