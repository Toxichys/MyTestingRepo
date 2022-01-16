using System;

namespace MyHomework_Lesson_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[,]
            {
                {"Ivanov", "Ivan", "Ivanovich"},
                {"Petrov", "Petr", "Petrovich"},
                {"Sidorov", "Maksim", "Karlovich"}
            };
            //string fullName1 = GetFullName("Ivanov", "Ivan", "Ivanovich");
            for (int i = 0; i < 3; i++)
            {
                string fullName1 = GetFullName(array[i, 0], array[i, 1], array[i, 2]);
                System.Console.WriteLine(fullName1);
            }
            //string fullName2 = GetFullName("Petrov", "Petr", "Petrovich");
            //System.Console.WriteLine(fullName2);
            //string fullName3 = GetFullName("Sidorov", "Maksim", "Karlovich");
            //System.Console.WriteLine(fullName3);

            System.Console.ReadLine();
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string fullName = firstName + " " + lastName + " " + patronymic;
            return fullName;
        }
    }
}
