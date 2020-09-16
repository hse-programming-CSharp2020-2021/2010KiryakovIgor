using System;

namespace Task6
{
    /*
   Дисциплина: "Программирование"
   Группа:      БПИ2010/2
   Студент:     Киряков Игорь Андреевич
   Задача:      Задан круг с центром в начале координат и радиусом R=10.   
Ввести  координаты точки и вывести сообщение:   «Точка внутри круга!» или «Точка вне круга!».

Предусмотреть проверку входных данных и цикл повторения решений.   
     Дата:        2020.09.11
*/

    class Program
    {
        public static string Method(int x, int y) // создаем метод
        {
            string res = string.Empty; //оставляем пустую строку для избежания ошибок
            res = (Math.Pow(x, 2) + Math.Pow(y, 2) <= 100) ? "Точка внутри круга!" : "Точка вне круга!";
            return res;
        }

        static void Main(string[] args)
        {
            do
            {
                int x, y;
                Console.WriteLine("Введите координаты точки:");
                while (!int.TryParse(Console.ReadLine(), out x))
                    Console.WriteLine("Попробуйте еще раз!");
                while (!int.TryParse(Console.ReadLine(), out y))
                    Console.WriteLine("Попробуйте еще раз!");
                Console.WriteLine(Method(x, y));                 // вызываем метод
                Console.WriteLine("Для завершения работы нажмите Esc");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
