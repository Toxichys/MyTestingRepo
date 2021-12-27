using System;

namespace MyHomework_Lesson_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[5, 2]
            {
                {"Иванов","+7 911 111 11 11"},
                {"Петров","Petrov@gb.ru"},
                {"Сидоров","8182 666 666"},
                {"GeekBrains","8 800 700-68-41"},
                {"Коллектор","XXX@gmail.com"}
            };
            //Выведем на экран наш список
            System.Console.WriteLine("Список контактов");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                System.Console.WriteLine($"Наименование: {array[i,0]} - телефон (email): {array[i, 1]}!");
            }
            System.Console.ReadLine();
        }
    }
}
