using System;
using System.Collections.Generic;

namespace Task4_3
{
    class Program
    {
        enum TimeOfYear
        {
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4
        }

        static Dictionary<TimeOfYear, String> dicTimeOfYear = new Dictionary<TimeOfYear, string>()
        {
            { TimeOfYear.Autumn, "Осень" },
            { TimeOfYear.Winter, "Зима" },
            { TimeOfYear.Summer, "Лето" },
            { TimeOfYear.Spring, "Весна"}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, введите номер месяца для определения времени года.");
            int month = int.Parse(Console.ReadLine());
            TimeOfYear tOfYear;
            string translatedTimeOfYear;
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                return;
            }
            tOfYear = GetTimeOfYear(month);
            translatedTimeOfYear = trnslateTimeOfYear(tOfYear);
            Console.WriteLine($"Месяц {month} соответствует времени года {translatedTimeOfYear}");
        }

        static TimeOfYear GetTimeOfYear(int month)
        {
            if (month >= 3 && month <= 5)
            {
                return TimeOfYear.Spring;
            }
            else if (month >= 6 && month <= 8)
            {
                return TimeOfYear.Summer;
            }
            else if (month >= 9 && month <= 11)
            {
                return TimeOfYear.Autumn;
            }
            else
            {
                return TimeOfYear.Winter;
            }
        }

        static string trnslateTimeOfYear(TimeOfYear tOfYear)
        {
            return dicTimeOfYear.GetValueOrDefault(tOfYear);
        }
    }
}
