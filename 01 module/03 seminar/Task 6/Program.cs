using System;

namespace Task_6
{
    /*
    Трехзначным целым числом кодируется номер аудитории в учебном корпусе. Старшая цифра обозначают номер этажа, а две младшие –  номер аудитории на этаже. Из трех аудиторий определить и вывести на экран ту аудиторию, которая имеет минимальный номер внутри этажа. Если таких аудиторий несколько - вывести любую из них. 
    */
    class Program
    {
        // создаем метод
        public static void Method(int aud1, int aud2, int aud3)
        {
            int stage1 = aud1 / 100;
            int stage2 = aud2 / 100;
            int stage3 = aud3 / 100;
            if (aud1==aud2 || aud2==aud3 || aud1==aud3)
            {
                Console.WriteLine("Введены одинаковые аудитории");
            }
            else 
            {
                if (stage1 == stage2 && stage1 == stage3)
                {
                    int min = aud1 < aud2 ? ((aud1 < aud3 ? aud1 : aud3)) : ((aud2 < aud3 ? aud2 : aud3));
                    Console.WriteLine("Ваша аудитория:" + min);
                }
                else if (stage1 == stage3 && stage2 != stage3)
                {
                    int min = aud1 < aud3 ? aud1 : aud3;
                    Console.WriteLine("Ваша аудитория:" + min);
                    Console.WriteLine("Ваша аудитория:" + aud2);
                }
                else if (stage1 == stage2 && stage1 != stage3)
                {
                    int min = aud1 < aud2 ? aud1 : aud2;
                    Console.WriteLine("Ваша аудитория:" + min);
                    Console.WriteLine("Ваша аудитория:" + aud3);
                }
                else if (stage2 == stage3 && stage1 != stage3)
                {
                    int min = aud3 < aud2 ? aud3 : aud2;
                    Console.WriteLine("Ваша аудитория:" + min);
                    Console.WriteLine("Ваша аудитория:" + aud1);
                }
                else
                {
                    Console.WriteLine("Ваша аудитория:" + aud1);
                    Console.WriteLine("Ваша аудитория:" + aud2);
                    Console.WriteLine("Ваша аудитория:" + aud3);
                }
            
            }                
        }
        static void Main(string[] args)
        {
            //объявляем переменные
            int aud1,aud2,aud3;
            while ((!int.TryParse(Console.ReadLine(), out aud1)) || ((!int.TryParse(Console.ReadLine(), out aud2)) || (!int.TryParse(Console.ReadLine(), out aud3))))
                 Console.WriteLine("Повторите ввод");
            if ((aud1>100 && aud1<999)&& (aud2 > 100 && aud2 < 999) && (aud3 > 100 && aud3 < 999))
            {
                // вызываем метод
                Method(aud1, aud2, aud3);
            }
            else Console.WriteLine("Повторите ввод");
            
        }
    }
}
