using System;
using System.Diagnostics;

namespace MyHomework_Lesson_7_1
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
             * Написать консольное приложение Task Manager,
             * которое выводит на экран запущенные процессы
             * и позволяет завершить указанный процесс.
             * Предусмотреть возможность завершения процессов
             * с помощью указания его ID или имени процесса.
             * В качестве примера можно использовать консольные
             * утилиты Windows tasklist и taskkill.
            */
            ListProcesses();
            do
            {
                Console.WriteLine("Введите ID или Имя процесса для удаления, для выхода введите exit!");
                string text = Console.ReadLine();

                if (text == "exit")
                    return;

                int id = -1;
                string name = "";
                try
                {
                    id = Convert.ToInt32(text);
                }
                catch
                {
                    name = text;
                }
                try
                {
                    if (id != -1)
                    {
                        Process processId = Process.GetProcessById(id);
                        processId.Kill();
                    }
                    else
                    {
                        Process[] processName = Process.GetProcessesByName(name);
                        for (int i = 0; i < processName.Length; i++)
                        {
                            if (processName[i].ProcessName == name)
                            {
                                processName[i].Kill();
                            }
                        }
                    }
                    Console.WriteLine("Операция завершена.");
                }
                catch
                {
                    Console.WriteLine("Ошибка удаления.");
                }

            } while (true);

        }
        static void ListProcesses()
        {
            Console.WriteLine("Список процессов!");
            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
                Console.WriteLine("ID: " + processes[i].Id + "; Имя:" + processes[i].ProcessName);
        }
    }
}