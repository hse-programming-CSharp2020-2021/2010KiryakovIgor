using System;

namespace Task_5
{
    class Program
    {
        public static double Method(ref double x, ref double y)
        { 
            if (x<=0.5)
            {
                return Math.Sin(Math.PI / 2);
            }
            else
            {
                return Math.Sin((Math.PI * (x - 1)) / 2);
            }
        }
        static void Main(string[] args)
        {
            double x, y;
            while (!double.TryParse(Console.ReadLine(), out x) || (!double.TryParse(Console.ReadLine(), out y)))
                Console.WriteLine("Повторите ввод");
            // выводим полученный результат
            Console.WriteLine(Method(ref x, ref y));
        }
    }
}
