using System;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            Double number = Convert.ToDouble(Console.ReadLine());
            if ((number % 2) == 0)
            {
                Console.WriteLine($"Число {number} является четным");
            }
            else
            {
                Console.WriteLine($"Число {number} является нечетным");
            }
        }
    }
}
