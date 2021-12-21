using System;

namespace MyHomework_Lesson_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите число!");
            int a = System.Convert.ToInt32(System.Console.ReadLine());
            if (a % 2 == 0)
            {
                System.Console.WriteLine("Четное");
            }
            else
            {
                System.Console.WriteLine("Нечетное");
            }
        }
    }
}
