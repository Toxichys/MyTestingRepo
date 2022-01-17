using System;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;

namespace MyHomework_Lesson_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Список задач(ToDo-list):
               - написать приложение для ввода списка задач;
               - задачу описать классом ToDo с полями Title и IsDone;
               - на старте, если есть файл tasks.json / xml / bin(выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
               - если задача выполнена, вывести перед её названием строку «[x]»;
               - вывести порядковый номер для каждой задачи;
               - при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
               - записать актуальный массив задач в файл tasks.json / xml / bin.
            */
            ToDo[] todoArray = GeneratingListTasks();
            string jsonFile = @"tasks.json";
            if (File.Exists(jsonFile))
            {
                string jsonDeser = File.ReadAllText(jsonFile);
                todoArray = JsonConvert.DeserializeObject<ToDo[]>(jsonDeser);
            }
            ShowTaskList(todoArray);
            TaskComplet(todoArray);
            string jsonSer = JsonConvert.SerializeObject(todoArray);
            File.WriteAllText(jsonFile, jsonSer);
        }

        static void ShowTaskList(ToDo[] todoArray)
        {
            Console.WriteLine("Список задач:");
            for (int i=1; i <= todoArray.Length;i++)
            {
                String isDone = " ";
                if (todoArray[i-1].IsDone)
                {
                    isDone = "Х";
                }
                Console.WriteLine($"[{isDone}] {i} - {todoArray[i - 1].Title}");
            }
        }

        static ToDo[] GeneratingListTasks()
        {
            ToDo[] todoArray = new ToDo[5];
            todoArray[0] = new ToDo("Попить кофе.", false);
            todoArray[1] = new ToDo("Поспать.", false);
            todoArray[2] = new ToDo("Умыться.", false);
            todoArray[3] = new ToDo("Сделать ДЗ.", true);
            todoArray[4] = new ToDo("Погулять.", false);
            return todoArray;
        }
        static void TaskComplet(ToDo[] todoArray)
        {
            string strText = "";
            do
            {
                Console.WriteLine("Введите номер задачи для выполнения или 'q' для выхода.");
                strText = Console.ReadLine();
                if (strText != "q")
                {
                    int number = Convert.ToInt32(strText);
                    if ((number > todoArray.Length) || (number < 1))
                    {
                        Console.WriteLine("Не правильный номер!");
                    }
                    else
                    {
                        todoArray[number - 1].IsDone = !todoArray[number - 1].IsDone;
                        Console.Clear();
                        ShowTaskList(todoArray);
                    }
                }
            } while (strText != "q");
        }
    }
}
