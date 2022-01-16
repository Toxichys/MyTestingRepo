using System;

namespace MyHomework_Lesson_4_3
{
    class Program
    {
        enum Season
        {
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the month number!");
            int nMonth = Convert.ToInt32(Console.ReadLine());
            Season userSeason = GetSeason(nMonth);
            string textTimeYear = GetNameSeason(userSeason);
            Console.WriteLine(textTimeYear);
            Console.ReadLine();

        }
        static Season GetSeason(int nMonth)
        {
            Season userSeason = new Season();
            switch (nMonth)
            {
                case 12:
                case 1:
                case 2: userSeason = Season.Winter; break;
                case 3:
                case 4:
                case 5: userSeason = Season.Spring; break;
                case 6:
                case 7:
                case 8: userSeason = Season.Summer; break;
                case 9:
                case 10:
                case 11: userSeason = Season.Autumn; break;
            }
            return userSeason;
        }
        static string GetNameSeason(Season userSeason)
        {
            string textTimeYear = "";
            switch (userSeason)
            {
                case Season.Autumn: textTimeYear = "Autumn";break;
                case Season.Spring: textTimeYear = "Spring"; break;
                case Season.Summer: textTimeYear = "Summer"; break;
                case Season.Winter: textTimeYear = "Winter"; break;
                default: textTimeYear = "Error: Enter a number from 1 to 12!"; break;
            }
            return textTimeYear;
        }
    }
}
