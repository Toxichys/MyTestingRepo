using System;

namespace MyHomework_Lesson_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //«Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
            char[,] array = new char[10, 10];
            for (int i=0;i<10;i++)
            {
                for (int j=0; j<10;j++)
                {
                    array[i, j] = 'O';
                }
            }
            //Карабли
            array[2, 8] = 'X';
            array[5, 5] = 'X';
            array[4, 1] = 'X';
            array[7, 6] = 'X';
            array[9, 7] = 'X';
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
