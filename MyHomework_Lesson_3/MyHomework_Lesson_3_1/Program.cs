using System;

namespace MyHomework_Lesson_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { {1,2},{3,4},{5,6} };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.WriteLine($"Массив array[i,j] = {array[i, j]} при i = {i} и j = {j}!");
                }
            }
            System.Console.ReadLine();
        }
    }
}
