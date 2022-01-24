using System;
using System.IO;

namespace MyHomework_Lesson_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
            string filename = "startup.txt";
            Console.WriteLine($"Будет произведена запись в файл '{filename}' данные текущего времени!");
            Console.ReadKey();
            DateTime dateTime = DateTime.Now;
            File.AppendAllText(filename, dateTime.ToString("HH:mm:ss") + " " +Environment.NewLine);
        }
    }
}
