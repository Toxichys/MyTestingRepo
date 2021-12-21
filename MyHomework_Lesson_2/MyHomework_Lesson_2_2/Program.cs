using System;

namespace MyHomework_Lesson_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите порядковый номер месяца.");
            int monthnumber = System.Convert.ToInt32(System.Console.ReadLine());
            string monthTitle = "";
            switch (monthnumber)
            {
                case 1:
                    monthTitle = "Январь";
                    break;
                case 2:
                    monthTitle = "Февраль";
                    break;
                case 3:
                    monthTitle = "Март";
                    break;
                case 4:
                    monthTitle = "Апрель";
                    break;
                case 5:
                    monthTitle = "Май";
                    break;
                case 6:
                    monthTitle = "Июнь";
                    break;
                case 7:
                    monthTitle = "Июль";
                    break;
                case 8:
                    monthTitle = "Август";
                    break;
                case 9:
                    monthTitle = "Сентябрь";
                    break;
                case 10:
                    monthTitle = "Октябрь";
                    break;
                case 11:
                    monthTitle = "Ноябрь";
                    break;
                case 12:
                    monthTitle = "Декабрь";
                    break;
                default:
                    monthTitle = "Неправильный порядковый номер";
                    break;
            }
            Console.WriteLine(monthTitle);
        }
    }
}
