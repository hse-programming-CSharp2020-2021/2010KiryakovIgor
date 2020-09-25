using System;
namespace Task5
{
    /*
     * Написать программу, выводящую на экран таблицу значений суммы ряда из n элементов для n = 1, …, k. Значение k – целое неотрицательное вводится с клавиатуры пользователем.
     */
    class Program
    {
        public static void Method(uint value)
        {
            double sum = 0;
            for (int i = 1; i <= value; i++)
            {
                sum = sum + (i + 0.3) / ((3 * i * i) + 5);
                Console.Write("n= "+i);
                Console.Write(" Сумма равна = "+ sum);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            uint k;
            Console.WriteLine("Введите значение K:");
            if (uint.TryParse(Console.ReadLine(), out k))
                Method(k);
            else
                Console.WriteLine("Incorect input");
        }
    }
}