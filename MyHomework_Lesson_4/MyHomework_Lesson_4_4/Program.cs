using System;

namespace MyHomework_Lesson_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of sequences!");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int feb = Fibonacci(0, 1, n, ++i);
            Console.WriteLine($"Number Fibonacci = {feb}");
            Console.ReadLine();
        }
        static int Fibonacci(int a, int b, int n, int i) 
        {
            int feb;
            if (i < n)
            { 
                feb = Fibonacci(b, a + b, n, ++i);
            }
            else
            {
                feb = a + b;
            }
            return feb;
        }
    }
}
