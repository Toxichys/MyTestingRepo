using System;

namespace MyHomework_Lesson_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите строку!");
            string text = System.Console.ReadLine();
            System.Console.WriteLine("Cтрока наоборот!");
            for (int i = text.Length-1; i >= 0; i--)
            {
                System.Console.Write(text[i]);
            }
            System.Console.ReadLine();
        }
    }
}
