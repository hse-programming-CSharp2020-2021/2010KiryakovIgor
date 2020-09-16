using System;

namespace Task2
{ /* Написать метод, преобразующий число переданное в качестве параметра в число, записанное теми же цифрами, но идущими в обратном порядке. 
   */
    class Program
    {
        public static void Method(int a) // вызываем метод
        {
            int n = a;
            Console.Write(n % 10);
            while ((n /= 10) != 0)
                Console.Write(n % 10);
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Повторите ввод");
            Method(a); // вызываем метод
        }
    }
}
