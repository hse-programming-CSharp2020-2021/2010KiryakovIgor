using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCDIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string input = Console.ReadLine();
            int Code = int.Parse(input);
            char ch = Convert.ToChar(Code);
            Console.WriteLine(ch);
            Console.ReadLine();
        }
    }
}
