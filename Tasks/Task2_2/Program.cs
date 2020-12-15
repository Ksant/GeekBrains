using System;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста введите номер текущего месяца");
            int numOfCurrMonth = Convert.ToInt32(Console.ReadLine());
            DateTime workDate = new DateTime(2020, numOfCurrMonth, 1);
            Console.WriteLine($"Текущий месяц - {workDate.ToString("MMMM")}");
        }
    }
}
