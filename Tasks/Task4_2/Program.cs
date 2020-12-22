using System;

namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста введите ряд чисел разделенных пробелами, чтобы получить сумму.");
            string str = Console.ReadLine();
            string[] arr = str.Split(' ');
            double sum = 0;
            foreach (var item in arr)
            {
                sum += Double.Parse(item);
            }
            Console.WriteLine($"Сумма ряда {str} равна {sum}");
        }
    }
}
