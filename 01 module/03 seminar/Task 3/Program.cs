using System;

namespace CW3
{
    /*Написать метод, вычисляющий логическое значение функции G=F(X,Y).
    * Результат равен true, если точка с координатами (X,Y) попадает в фигуру G, и результат равен false,
    * если точка с координатами (X,Y) не попадает в фигуру G.
    * Фигура G - сектор круга радиусом R=2 в диапазоне углов -90<= fi <=45.
    */
    class Program
    {
        // создаем метод
        static bool Method(double x, double y)
        {
            double radians = Math.Atan2(x, y);
            return ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 4) && (-0.5 * Math.PI <= radians || radians <= Math.PI * 0.25));
        }
        static void Main(string[] args)
        {
            double x, y;
            do
            {
                Console.Clear();

                Console.Write("Введите значение функции x: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                    Console.WriteLine("Incorrect input");
                Console.Write("Введите значение функции y: ");
                if (!double.TryParse(Console.ReadLine(), out y))
                    Console.WriteLine("Incorrect input");

                Console.WriteLine($"Ответ: {Method(x, y)}");
                Console.WriteLine("Нажмите на ESC, чтобы выйти");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}