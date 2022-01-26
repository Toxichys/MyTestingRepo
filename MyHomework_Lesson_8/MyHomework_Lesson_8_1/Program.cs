using System;

namespace MyHomework_Lesson_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создать консольное приложение, которое при старте выводит приветствие,
             * записанное в настройках приложения (application-scope).
             * Запросить у пользователя имя, возраст и род деятельности,
             * а затем сохранить данные в настройках.
             * При следующем запуске отобразить эти сведения.
             * Задать приложению версию и описание.
            */
            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine($"{greeting}!");

            SetSettingsDefault();

            PrintSettingsDefault();

            Console.ReadLine();
        }
        static void SetSettingsDefault()
        {
            bool flag = false;
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                flag = true;
            }
            if (Properties.Settings.Default.UserAge == 0)
            {
                Console.WriteLine("Введите возраст пользователя:");
                Properties.Settings.Default.UserAge = Convert.ToInt32(Console.ReadLine());
                flag = true;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserTypeOfWork))
            {
                Console.WriteLine("Введите род деятельности пользователя:");
                Properties.Settings.Default.UserTypeOfWork = Console.ReadLine();
                flag = true;
            }
            if (flag)
            {
                Properties.Settings.Default.Save();
            }
        }
        static void PrintSettingsDefault()
        {
            string userName = Properties.Settings.Default.UserName;
            int UserAge = Properties.Settings.Default.UserAge;
            string UserTypeOfWork = Properties.Settings.Default.UserTypeOfWork;

            Console.WriteLine($"Пользователь: {userName}.");
            Console.WriteLine($"возраст: {UserAge}.");
            Console.WriteLine($"род деятельности: {UserTypeOfWork}.");
        }
    }
}
