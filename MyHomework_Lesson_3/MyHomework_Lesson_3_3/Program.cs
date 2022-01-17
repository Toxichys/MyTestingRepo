using System;

namespace MyHomework_Lesson_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            for (int i=1; i <= text.Length;i++)
            {
                Console.Write(text[text.Length - i]);
            }
        }
    }
}
