using System;
namespace CW4
{
    /*
     * В основной программе ввести натуральное число и вычислить суммы его цифр, находящихся в чётных и на нечётных разрядах. Разряд единиц считать нулевым и чётным.
     * Для этого написать метод с натуральным параметром,  вычисляющий суммы цифр, находящихся на четных и на нечетных позициях в записи значения параметра.  
    */
    class Program
    {
        // создаем метод
        public static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0;
            sumOdd = 0;
            int n = 0;
            uint num;
            uint number2 = number;
            // счетчик для разрядов
            do
            {
                number2 = number2 / 10;
                n++;
            }
            while (number2 != 0);
            do
            {              
                num = number % 10;
                if (n % 2 != 0)
                    sumEven = sumEven + num;
                else
                {
                    sumOdd = sumOdd + num;
                    number = number / 10;
                    n--;
                }
            }
            while (number != 0);
            
            Console.WriteLine("Сумма нечетных разрядов");
            Console.WriteLine(sumOdd);
            Console.WriteLine("Сумма четных разрядов");
            Console.WriteLine(sumEven);
        }
        static void Main(string[] args)
        {
            uint sumEven;
            uint sumOdd;
            Console.WriteLine("Введите число: ");
            uint number;
            if (uint.TryParse(Console.ReadLine(), out number))
               Sums(number, out sumEven, out sumOdd);        
            else
                Console.WriteLine("Incorrect input");
        }
    }
}