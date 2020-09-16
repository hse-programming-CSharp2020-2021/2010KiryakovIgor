using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("x   x   x    x  xxxxxx  xxxxxx  x   x     x x x   xxxxxx");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("x  x    x   xx  x    x  x    x  x  x     x     x  x    x");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("xx      x  x x  xxxxxx  xxxxxx  xx       x     x  xxxxxx");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("x x     x x  x  x          x x  x x      x     x  x    x");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("x   x   xx   x  x         x  x  x   x     x x x   xxxxxx");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.ReadLine();
        }
    }
}
