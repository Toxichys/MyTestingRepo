using System;

namespace MyHomework_Lesson_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите минимальную температуру за сутки!");
            double MinT = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Введите максимальную температуру за сутки!");
            double MaxT = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Введите порядковый номер месяца.");
            int monthnumber = System.Convert.ToInt32(System.Console.ReadLine());
            if ((monthnumber > 10 || monthnumber == 1) && (MinT + MaxT) / 2 > 0)
            {
                System.Console.WriteLine("Дождливая зима");
            }
            System.Console.ReadLine();
        }
    }
}
