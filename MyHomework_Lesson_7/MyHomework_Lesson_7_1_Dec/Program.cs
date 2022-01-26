// Decompiled with JetBrains decompiler
// Type: MyHomework_Lesson_7_1.Program
// Assembly: MyHomework_Lesson_7_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BFD8DA18-A33D-4D8F-940D-C446B3FC5B0F
// Assembly location: C:\Users\Toxich\source\repos\MyHomework_Lesson_7\MyHomework_Lesson_7_1\bin\Release\MyHomework_Lesson_7_1.exe

using System;
using System.Diagnostics;

namespace MyHomework_Lesson_7_1
{
  internal class Program
  {
    private static void Main(string[] args)
    {
        //Это правка для ДЗ
      Program.ListProcesses();
      while (true)
      {
        Console.WriteLine("Введите ID или Имя процесса для удаления, для выхода введите exit!");
        string str = Console.ReadLine();
        if (!(str == "exit"))
        {
          int processId = -1;
          string processName = "";
          try
          {
            processId = Convert.ToInt32(str);
          }
          catch
          {
            processName = str;
          }
          try
          {
            if (processId != -1)
            {
              Process.GetProcessById(processId).Kill();
            }
            else
            {
              Process[] processesByName = Process.GetProcessesByName(processName);
              for (int index = 0; index < processesByName.Length; ++index)
              {
                if (processesByName[index].ProcessName == processName)
                  processesByName[index].Kill();
              }
            }
            Console.WriteLine("Операция завершена.");
          }
          catch
          {
            Console.WriteLine("Ошибка удаления.");
          }
        }
        else
          break;
      }
    }

    private static void ListProcesses()
    {
      Console.WriteLine("Список процессов!");
      Process[] processes = Process.GetProcesses();
      for (int index = 0; index < processes.Length; ++index)
        Console.WriteLine("ID: " + processes[index].Id.ToString() + "; Имя:" + processes[index].ProcessName);
    }
  }
}
