using System;

namespace MyHomework_Lesson_2_6
{
    class Program
    {
        [Flags]
        public enum Week
        {
            monday    = 0b_0000001,
            tuesday   = 0b_0000010,
            wednesday = 0b_0000100,
            thursday  = 0b_0001000,
            friday    = 0b_0010000,
            saturday  = 0b_0100000,
            sunday    = 0b_1000000,
        }
        static void Main(string[] args)
        {
            Week office1 = (Week)0b_0011110;
            Week office2 = (Week)0b_1111111;
            System.Console.WriteLine($"Офис 1 работает: {office1}");
            System.Console.WriteLine($"Офис 2 работает: {office2}");
            System.Console.ReadLine();
        }
    }
}
