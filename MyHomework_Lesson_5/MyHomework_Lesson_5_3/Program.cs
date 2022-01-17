using System;
using System.IO;

namespace MyHomework_Lesson_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
            Console.WriteLine("Ввести с клавиатуры произвольный набор чисел (0...255)!");
            string[] strArray = Console.ReadLine().Split(' ');
            byte[] byteArray = new byte[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                byteArray[i] = Convert.ToByte(strArray[i]);
            }
            File.WriteAllBytes("bytes.bin", byteArray);
        }
    }
}
