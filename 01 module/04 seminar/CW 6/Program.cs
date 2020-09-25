using System;


namespace CW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            double x;
            if (double.TryParse(Console.ReadLine(),out x))
            {
                Console.WriteLine("");
            }
            else Console.WriteLine("Incorrect input");
        }
    }
}
