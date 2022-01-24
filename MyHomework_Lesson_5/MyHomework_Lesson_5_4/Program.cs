using System;
using System.IO;

namespace MyHomework_Lesson_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
            Console.WriteLine("Введите путь к директории!"); 
            string workDir = @Console.ReadLine();
            if (!Directory.Exists(workDir))
            {
                Console.WriteLine("Каталог не найден!");
                return;
            }
            string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);
            File.WriteAllLines("NoRecursion.txt", entries);

            Recursion(workDir);

        }

        static void Recursion(string workDir)
        {
            string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < entries.Length; i++)
            {
                File.AppendAllText("Recursion.txt", entries[i]);
                File.AppendAllText("Recursion.txt", Environment.NewLine);
                if (Directory.Exists(entries[i]))
                {
                    Recursion(entries[i]);
                }
            }
        }
    }
}
