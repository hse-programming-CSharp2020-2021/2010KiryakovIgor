using System;

namespace CW_7
{
    class Program
    {
        public static void Method(uint a,uint b,out uint nod, out uint nok)
        {
            uint a1 = a;
            uint b1 = b;
            uint nod;
            uint nok;
            do
            {
                if (a > b)
                {
                    a = a % b;
                }
                else b = b % a;
            }
            while (a % b == 0 || b % a == 0);
                nod = a + b;
            Console.WriteLine(nod);
            
        }
        static void Main(string[] args)
        {
            uint a, b;
            Console.WriteLine("Введите 2 числа: ");
            if (uint.TryParse(Console.ReadLine(),out a) && (uint.TryParse(Console.ReadLine(), out b)))
            {
                Method(a, b);
            }
            else Console.WriteLine("Incorrect input");
        }
    }
}
