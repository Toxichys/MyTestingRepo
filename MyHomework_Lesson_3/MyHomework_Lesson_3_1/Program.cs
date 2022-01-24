using System;

namespace MyHomework_Lesson_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, выводящую элементы двухмерного массива по диагонали
            string[,] array =
            {
                {"1","2","3","4","5"},
                {"6","7","8","9","10"},
                {"11","12","13","14","15"},
                {"16","17","18","19","20"},
                {"21","22","23","24","25"}
            };
            Console.WriteLine("Значения массива по диагонали.");
            for (int i=0; i<5;i++)
            {
                Console.WriteLine(array[i,i]);
            }
        }
    }
}
