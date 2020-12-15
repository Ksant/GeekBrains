using System;

namespace Tasks1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пожалуйста свое имя.");
            String name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now.ToLongDateString()}");
            Console.ReadLine();
        }
    }
}
