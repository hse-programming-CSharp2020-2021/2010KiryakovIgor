using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первого катета: ");
            string input = Console.ReadLine();
            int a = int.Parse(input);
            Console.WriteLine("Введите длину второго катета: ");
            string input1 = Console.ReadLine();
            int b = int.Parse(input1);
            double d = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Длина гипотенузы равна: " + d);
            Console.ReadLine();
        }
    }
}
