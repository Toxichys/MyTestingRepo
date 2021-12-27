using System;

namespace MyHomework_Lesson_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Char[,] array = new char[10, 10];
            array[1, 2] = 'X';
            array[2, 8] = 'X';
            array[5, 5] = 'X';
            array[7, 3] = 'X';
            array[9, 9] = 'X';
            System.Console.WriteLine("Морской бой!");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 'X')
                    {
                        System.Console.Write(array[i, j]);
                    }
                    else
                    {
                        System.Console.Write("O");
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.ReadLine();
        }
    }
}
