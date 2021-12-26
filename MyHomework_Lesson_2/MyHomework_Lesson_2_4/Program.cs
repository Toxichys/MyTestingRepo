using System;

namespace MyHomework_Lesson_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameComp = "ПАО Рога и Копыта";
            int smena = 123;
            int check = 65;
            DateTime dateCheck = new DateTime(2021,11,10,18,15,46);
            string productName1 = "Бананы";
            float productcount1 = 1.692f;
            decimal productcost1 = 150.59m;
            string productName2 = "Хлеб";
            float productcount2 = 1;
            decimal productcost2 = 36.25m;

            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine($"|----------{nameComp}-----------|");
            Console.WriteLine($"|Смена-:-{smena}---------------------------|");
            Console.WriteLine($"|Номер-:-{check}----------------------------|");
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine("|№-Наименование--------кол------Сумма--|");
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine($"|1-{productName1}-------------{productcount1}------{productcost1}|");
            Console.WriteLine($"|2-{productName2}---------------{productcount2}-----------{productcost2}|");
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine($"|Итого---------------------------{productcost1 + productcost2}|");
            Console.WriteLine("|--------------------------------------|");
        }
    }
}
