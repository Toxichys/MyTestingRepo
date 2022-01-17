using System;
using System.IO;

namespace MyHomework_Lesson_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
            Console.WriteLine("Введите текст для сохранения в файл!");
            string text = Console.ReadLine();
            File.WriteAllText("text.txt", text);
        }
    }
}
