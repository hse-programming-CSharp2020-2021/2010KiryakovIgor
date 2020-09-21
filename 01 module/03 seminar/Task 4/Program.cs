using System;

namespace Task_4
{
    /*
     Написать метод, вычисляющий значение функции G=F(X,Y) 
    */
    class Program
    {
        public static double Method(ref double x, ref double y)
        {
            if (x < y && x > 0)
            {
                return x + Math.Sin(y);

            }
            else if (x > y && x < 0)
            {
                return y - Math.Cos(x);
            }
            else
            {
                return 0.5 * y * x;
            }

        }
        static void Main(string[] args)
        {
            double x, y;
            while (!double.TryParse(Console.ReadLine(), out x) || (!double.TryParse(Console.ReadLine(), out y)))
                Console.WriteLine("Повторите ввод");
            Console.WriteLine(Method(ref x, ref y));

        }
    }
}