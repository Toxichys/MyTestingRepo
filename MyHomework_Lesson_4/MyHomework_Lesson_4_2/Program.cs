using System;

namespace MyHomework_Lesson_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers separated by a space!");
            string text = System.Console.ReadLine();
            float sum = GetSum(text);
            Console.WriteLine($"Sum numbers {sum}");
            Console.ReadLine();
        }
        static float GetSum(string text)
        {
            int sum = 0;
            string sumText = "";
            for (int i = 0; i < text.Length; i++) 
            {
                if (text[i] == ' ')
                {
                    sum += Convert.ToInt32(sumText); 
                    sumText = "";
                }
                else
                {
                    sumText += text[i];
                }
            }
            if (sumText != "")
            {
                sum += Convert.ToInt32(sumText);
            }
            return sum;
        }
    }
}
