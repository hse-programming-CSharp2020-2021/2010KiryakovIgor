using System;

namespace Task5
{  /*
   Дисциплина: "Программирование"
   Группа:      БПИ2010/2
   Студент:     Киряков Игорь Андреевич
   Задача:    Ввести трехзначное натуральное число и напечатать его цифры "столбиком".
    Дата:    2020.09.11
*/

    class Program
    {
        public static void Method(int a) // метод для вывода чисел в отдельные строки
        {
            int x, y, z;
            x = a / 100;
            Console.WriteLine($"{x}");
            y = (a - x * 100) / 10;
            Console.WriteLine($"{y}");
            z = a - x * 100 - y * 10;
            Console.WriteLine($"{z}");
        }
        static void Main(string[] args)
        {
            do
            {
                int a;
                Console.WriteLine("Введите трехзначное число: ");
                while (!int.TryParse(Console.ReadLine(), out a) || a > 999 || a < 100) ; // вводим с клавиатуры число и проверяем его на условия задачи
                Method(a); //вызываем метод
                Console.WriteLine("Введите ESC для выхода . . . ");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);


        }
    }
}
