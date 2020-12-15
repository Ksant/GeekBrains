using System;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, введите минимальную температуру за день.");
            Double minTemp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите максимальную температуру за день.");
            Double maxTemp = Convert.ToDouble(Console.ReadLine());
            Double averageTemp = (maxTemp + minTemp) / 2;
            Console.WriteLine($"Средняя температура за день равна - {averageTemp}");
        }
    }
}
