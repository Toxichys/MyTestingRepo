using System;

namespace MyHomework_Lesson_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите минимальную температуру за сутки!");
            double MinT = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Введите максимальную температуру за сутки!");
            double MaxT = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Средняя температура за сутки - " + (MinT + MaxT)/2);
            System.Console.ReadLine();
        }
    }
}
