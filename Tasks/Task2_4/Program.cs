using System;

namespace Task2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте номер месяца");
            int numOfMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте минимальную температуру");
            double minT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Задайте максимальную температуру");
            double maxT = Convert.ToDouble(Console.ReadLine());
            double averT = (minT + maxT) / 2;
            bool winter = false;
            switch (numOfMonth)
            {
                case 1:
                    winter = true;
                    break;
                case 2:
                    winter = true;
                    break;
                case 12:
                    winter = true;
                    break;
            }
            if (winter && averT > 0)
            {
                Console.WriteLine("Дождливая зима");
            }
        }
    }
}
