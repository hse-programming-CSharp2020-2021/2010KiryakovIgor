using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите напряжение (U) : ");
            string input = Console.ReadLine();
            int u = int.Parse(input);
            Console.WriteLine("Введите сопротивление (R) : ");
            string input1 = Console.ReadLine();
            int r = int.Parse(input1);
            Console.WriteLine("Сила тока (I) = " + (u / r));
            Console.WriteLine("Потребляемая мощность (P) = " + (u * u / r));
            Console.ReadLine();


        }
    }
}
