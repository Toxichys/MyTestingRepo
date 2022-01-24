using System;

namespace MyHomework_Lesson_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.
            string[,] strArray =
            {
                {"Иванов", "+79115553322"},
                {"Петров", "+79061112233"},
                {"Сидоров", "Sid@gmail.com"},
                {"Пупкин", "+79090001111/Pup@ya.ru"},
                {"Дедищев", "Ded@bk.ru"},
            };
            Console.WriteLine("Телефонный справочник.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Имя: " + strArray[i, 1] + ", Телефон/емайл: " + strArray[i, 1]);
            }
        }
    }
}
